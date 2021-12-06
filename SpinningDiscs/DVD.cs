using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.
        public string Quote { get; set; }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(string name, int minutesOfContent, string content, string discType, bool isSpinable, string quote) : base(name, minutesOfContent, content, discType, isSpinable)
        {
            Quote = quote;
        }

        public void ReadData()
        {
            Console.WriteLine(Quote);
        }

        public void SpinDisc()
        {
            if(IsSpinable == true)
            {
                ReadData();
            }
            else
            {
                Console.WriteLine("Error, Unable to read disc.");
            }
        }
    }
}
