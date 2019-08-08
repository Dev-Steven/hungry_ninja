class SweetTooth : Ninja
{
    // provide override for IsFull (Full at 1500 Calories)
    public override bool IsFull
    {
        get {
            if(this.calorieIntake > 1500) {
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
            if(item.IsSweet == true)
            {
                this.calorieIntake += 10;
            }
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
        else 
        {
            System.Console.WriteLine("SweetTooth is full.");
        }
    }
}
