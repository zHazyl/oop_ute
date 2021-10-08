using System;
using static System.Console;

class FourPlace : Grab 
{
    FourPlace() : base("Four place", 30, 20, 3) {}
    public override void Pay(double km, bool isHolyday) {
        base.Pay(km, isHolyday);
    }
    ~FourPlace() {}
}