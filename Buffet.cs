using System;
using System.Collections.Generic;

class Buffet
    {
        public List<Food> Menu;
         
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Pizza", 1000, false, false),
                new Food("Sandwich", 160, true, false),
                new Food("Steak", 950, false, true),
                new Food("Rice", 450, false, false),
                new Food("Brocolli", 190, false, false),
                new Food("Dumpling", 200, false, false),
                new Food("Soup", 110, true, false)
            };
        }
         
        public Food Serve()
        {
            Random rand = new Random();
            int selection = rand.Next(0, 7);
            System.Console.WriteLine($"Eating {Menu[selection].Name}");
            return Menu[selection];
        }
    }