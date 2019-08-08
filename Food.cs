class Food : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}

        public string GetInfo()
        {
            string info = $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
            System.Console.WriteLine(info);
            return info;
        }
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string Name, int Calories, bool IsSpicy, bool IsSweet)
        {
            this.Name = Name;
            this.Calories = Calories;
            this.IsSpicy = IsSpicy;
            this.IsSweet = IsSweet;
        }
    }