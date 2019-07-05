using System;
using System.Collections.Generic ;

namespace iron_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            SweetTooth sweet = new SweetTooth();
            SpiceHound spice = new SpiceHound ();

            while(!sweet.IsFull)
            {
                sweet.Consume(menu.Serve());
            }
            while(!spice.IsFull)
            {
                spice.Consume(menu.Serve());
            }
            if(spice.ConsumptionHistory.Count > sweet.ConsumptionHistory.Count)
            {
                Console.WriteLine($"Spice Hound has {spice.ConsumptionHistory.Count} items. ");
            }
            else
            {
                Console.WriteLine($"Sweet Tooth has {sweet.ConsumptionHistory.Count} items.");
            }

        }
    }
}
