class Drink : IConsumable
{
    public string Name {get;set;}
    public int Calories {get;set;}
    public bool IsSpicy {get;set;}
    public bool IsSweet {get;set;}

    public string GetInfo()
    {
        return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
    }

    public Drink(string Name, int Calories)
    {
        this.Name = Name;
        this.Calories = Calories;
        this.IsSpicy = false;
        this.IsSweet = true;
    }
}