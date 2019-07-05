using System;
using System.Collections.Generic;

namespace iron_ninja
    {
        class Menu
        {
            public List<IConsumable> Buffet;
            public Menu()
            {
            Buffet = new List<IConsumable>()
                {
                    new Food("Fried Chicken",750, false, false),
                    new Drink("Lemonade", 200, false, true),
                    new Food("Corn on the Cobb", 350, false, false),
                    new Food("Lo Mein", 1000, true, false),
                    new Food("Watermelon", 200, false, true),
                    new Food ("Curry", 500, true, false),
                    new Drink("Tea", 100, false, false)

                };
            }
            public IConsumable Serve()
            {
                Random rand = new Random();
                return Buffet[rand.Next(Buffet.Count)];
            }
        }



}