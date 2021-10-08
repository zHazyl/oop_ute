using System;
using static System.Console;

class SevenPlace : Grab 
{
    SevenPlace() : base("Seven place", 30, 20, 3) {}
    public override void Pay(double km, bool isHolyday) {
        base.Pay(km, isHolyday);
    }
    ~SevenPlace() {}
}