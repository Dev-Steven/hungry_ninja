using System;
using System.Collections.Generic;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            // Making a Buffet Ojbect
            Buffet buffet1 = new Buffet();

            // Making a SweetTooth Object
            SweetTooth sweet = new SweetTooth();

            // Making a SpiceHound Object
            SpiceHound spice = new SpiceHound();

            // Making sweet Consume
            System.Console.WriteLine("SweetTooth consuming...");
            sweet.Consume(buffet1.Serve());
            sweet.Consume(buffet1.Serve());
            sweet.Consume(buffet1.Serve());
            sweet.Consume(buffet1.Serve());
            sweet.Consume(buffet1.Serve());

            // spice consuming
            System.Console.WriteLine("SpiceHound consuming...");
            spice.Consume(buffet1.Serve());
            spice.Consume(buffet1.Serve());
            spice.Consume(buffet1.Serve());
            spice.Consume(buffet1.Serve());
            spice.Consume(buffet1.Serve());
        }
    }
}
