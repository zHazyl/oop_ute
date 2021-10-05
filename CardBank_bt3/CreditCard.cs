using System;

public enum CardType {
    Standard = 50_000_000,
    Gold = 100_000_000
}

public class CreditCard : Card {
    private string type;
    private decimal income;
    
    public CreditCard() : base() {
        this.type = "";
        this.income = 0M;
    }
    public CreditCard(decimal income, string id, string name, decimal balance) : base(id, name, balance) {
        this.type = "";
        this.income = income;
    }
    public override void OpenCard()
    {
        if (this.income >= (decimal)CardType.Gold) {
            this.type = "Gold";
            this.nameCard = this.type + " Credit card";
            this.status = "Available";
            Console.WriteLine("This card is AVAILABLE");
        } else if (this.income >= (decimal)CardType.Standard) {
            this.type = "Standard";
            this.nameCard = this.type + " Credit card";
            this.status = "Available";
            Console.WriteLine("This card is AVAILABLE");
        }
        else {
            Console.WriteLine("You can't open this card");
        }
    }
    public override void Pay(decimal cost, float percentPromotion = 0) // ap dung khuyen mai
    {
        decimal afterBuy = this.balance - cost * (1 - (decimal)percentPromotion);
        if (this.type == "Gold") {
            if (afterBuy < -50_000_000) {  // chi truoc tra sau
                Console.WriteLine("You can't pay it");
            } else {
                this.balance = afterBuy;
                Console.WriteLine("Pay success");
            }
        } else {
            if (afterBuy < -20_000_000) {  // chi truoc tra sau
                Console.WriteLine("You can't pay it");
            } else {
                this.balance = afterBuy;
                Console.WriteLine("Pay success");
            }
        }
    }
    public override void Tranfer(decimal amount, Card c) {
        Console.WriteLine("You can't tranfer"); // ko dc chuyen khoan
    }
    public string Type {
        get {return this.type;}
    }
    ~CreditCard() {}
}