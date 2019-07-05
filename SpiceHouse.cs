using System;

namespace iron_ninja
    {
    class SpiceHound : Ninja
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
                    calorieIntake -= 5;
                }
                ConsumptionHistory.Add(item);
                Console.WriteLine(item.GetInfo());
            }
            else
            {
                Console.WriteLine("Wow! That was definitely spicy!");
            }
        }    
    }
}