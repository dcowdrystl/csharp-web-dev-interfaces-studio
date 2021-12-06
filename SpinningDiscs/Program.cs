using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.

            // TODO: Call each CD and DVD method to verify that they work as expected.
            DVD series = new DVD("The Witcher", 110, "Netflix series", "DVD", true, "Drop a coin too your witcher...");
            CD rATM = new CD("Evil Empire", 39, "RATM", "Audio CD", true, 2, "Bulls On Parade", "Rally round tha family! With a pocket full of shells...");

            series.SpinDisc();
            Console.WriteLine();
            rATM.SpinDisc();

        }
    }
}
