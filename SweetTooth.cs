using System;
using System.Collections.Generic;

namespace iron_ninja
{
    class SweetTooth : Ninja
        {
            public override bool IsFull
            {
                get
                {
                    return calorieIntake >= 1500;
                }
            }
            public override void Consume(IConsumable item)
            {
                if(!IsFull)
                {
                    calorieIntake += item.Calories;
                    if(item.IsSweet)
                    {
                        calorieIntake += 10;
                    }
                    ConsumptionHistory.Add(item);
                    Console.WriteLine(item.GetInfo());
                }
                else
                {
                    Console.WriteLine("You fullfilled you Sweet Tooth for today!");
                }
                }
    }
}