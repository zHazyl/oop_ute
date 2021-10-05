using System;

public class DebitCard : Card {
    public DebitCard() : base() {}
    public DebitCard(string id, string name, decimal balance) : base(id, name, balance) {}
    public override void OpenCard(decimal income = 0) {
        this.status = "Available";
        this.nameCard = "Debit Card";
        Console.WriteLine("This card is AVAILABLE");
    }
    public bool IsApplyPromotion() {return false;}
    public override void Pay(decimal cost, float percentPromotion = 0) {
        if (!this.IsApplyPromotion()) {percentPromotion = 0;} // ko ap dung khuyen mai
        decimal afterPay = this.balance - cost;
        if (afterPay < 0) {
            Console.WriteLine("You can't pay it");
        } else {
            this.balance = afterPay;
            Console.WriteLine("Pay success");
        }
    }
    public override void Tranfer(decimal amount, ref Card c) {
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