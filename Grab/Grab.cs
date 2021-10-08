using System;
using static System.Console;

class Grab 
{
    protected string type;
    protected decimal priceFirst;
    protected decimal priceAfter;
    protected int timeOrder;
    public Grab() {
        this.type = "";
        this.priceFirst = 0M;
        this.priceAfter = 0M;
        this.timeOrder = 0;
    }
    public Grab(string type, decimal pf, decimal pa, int to) {
        this.type = type;
        this.priceFirst = pf;
        this.priceAfter = pa;
        this.timeOrder = to;
    }
    public void Infor() {
        WriteLine($"Type: {this.type}");
        WriteLine($"Price first: {this.priceFirst:C}");
        WriteLine($"Price After: {this.priceAfter:C}");
        WriteLine($"Time Order before: {this.timeOrder} day");
    }
    public virtual decimal Pay(double km, bool isHolyday) {
        if (km <= 1) {
            return km * this.priceFirst;
        }
        if (isHolyday)
        {
            return (km - 1) * this.priceAfter;
        }
        return this.priceFirst + (km - 1) * this.priceAfter;
    }
    ~Grab() {}
}