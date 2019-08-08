class SpiceHound : Ninja
{
    // provide override for IsFull (Full at 1200 Calories)
    public override bool IsFull
    {
        get {
            if(this.calorieIntake > 1200) {
                return true;
            }
            else {
                return false;
            }
        }
    }
    public override void Consume(IConsumable item)
    {
        if(this.IsFull == false)
        {
            this.calorieIntake += item.Calories;
            if(item.IsSpicy == true)
            {
                this.calorieIntake -= 5;
            }
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
        else 
        {
            System.Console.WriteLine("SpiceHound is full.");
        }
    }
}
