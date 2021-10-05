using System;

public class Card {
    protected string id;
    public virtual void ShowInfo() 
    {
        Console.WriteLine(this.id);
    }
}

public class CreditCard : Card
{
    double price;
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine(this.price);
    }
}