using System;

public class Card {
    protected string nameCard;
    protected string id;
    protected string status;
    protected string name;
    protected decimal balance;
    protected string history;
    public Card() {
        this.nameCard = "";
        this.id = "";
        this.status = "Unvailable";
        this.name = "";
        this.balance = 0M;
    }
    public Card(string id, string name, decimal balance) {
        this.nameCard = "";
        this.id = id;
        this.status = "Unvailable";
        this.name = name;
        this.balance = balance;
    }
    public string Id {
        get {return this.id;}
    }
    public string Name {
        get {return this.name;}
    }
    public decimal Balance {
        get {return this.balance;}
    }
    public void ReceiveMoney(decimal amount) {
        this.balance += amount;
    }
    public virtual void OpenCard() {}
    public virtual void Pay(decimal cost, float percentPromotion = 0) {}
    public virtual void Tranfer(decimal amount, ref Card c) {}
    public void InforCard() {
        Console.WriteLine("\n================");
        Console.WriteLine($"Type: {this.nameCard}");
        Console.WriteLine($"ID: {this.id}");
        Console.WriteLine($"Status: {this.status}");
        Console.WriteLine($"Name: {this.name}");
        Console.WriteLine($"Balance: {this.balance} VND");
    }
    ~Card(){}
}