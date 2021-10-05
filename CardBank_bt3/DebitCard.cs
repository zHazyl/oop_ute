using System;

public class DebitCard : Card {
    public DebitCard() : base() {}
    public DebitCard(string id, string name, decimal balance) : base(id, name, balance) {}
    public override void OpenCard() {
        this.status = "Available";
        this.nameCard = "Debit Card";
        Console.WriteLine("This card is AVAILABLE");
    }
    public override void Pay(decimal cost, float percentPromotion = 0) {
        decimal afterPay = this.balance - cost;
        if (afterPay < 0) {
            Console.WriteLine("You can't pay it");
        } else {
            this.balance = afterPay;
            Console.WriteLine("Pay success");
        }
    }
    public override void Tranfer(decimal amount, Card c) {
        decimal afterTranfer = this.balance - amount;
        if (afterTranfer >= 0) {
            this.balance = afterTranfer;
            c.ReceiveMoney(amount);
        } else {
            Console.WriteLine("You can't tranfer");
        }
    }
    ~DebitCard() {}
}