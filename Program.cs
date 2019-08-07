using System;
using System.Collections.Generic;

namespace hungry_ninja
{

    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string Name, int Calories, bool IsSpicy, bool IsSweet)
        {
            this.Name = Name;
            this.Calories = Calories;
            this.IsSpicy = IsSpicy;
            this.IsSweet = IsSweet;
        }
    }

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
            System.Console.WriteLine(Menu[selection]);
            return Menu[selection];
        }
    }

    class Ninja
    {
        private int calorieIntake;
        // can set default value here for when any new Ninja is instantiated, or do it in construcotr
        // public List<Food> FoodHistory = new List<Food>();
        public List<Food> FoodHistory;
        private bool isFull;
         
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
         
        // add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get 
            { 
                if(this.calorieIntake > 1200) {
                    return true;
                }
                else {
                    return false;
                }
             }
        }
         
        // build out the Eat method
        public void Eat(Food item)
        {
            // if not full then...
            if(this.IsFull == false)
            {
                this.calorieIntake += item.Calories;
                FoodHistory.Add(item);
                System.Console.WriteLine("Calories: " + this.calorieIntake);
                // System.Console.WriteLine($"Name: {item.Name}, Spice: {item.IsSpicy}, Sweet: {item.IsSweet}");
            }
            else 
            {
                System.Console.WriteLine("Ninja is full.");
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // Making a Buffet Ojbect
            Buffet buffet1 = new Buffet();

            // Making a Ninja Object
            Ninja ninja1 = new Ninja();

            // Making ninja1 eat
            ninja1.Eat(buffet1.Serve());
            ninja1.Eat(buffet1.Serve());
            ninja1.Eat(buffet1.Serve());
            ninja1.Eat(buffet1.Serve());
            ninja1.Eat(buffet1.Serve());
            ninja1.Eat(buffet1.Serve());
        }
    }
}
