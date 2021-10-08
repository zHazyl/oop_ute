using System;
using static System.Console;

class SixteenPlace : Grab 
{
    SixteenPlace() : base("Sixteen place", 30, 20, 3) {}
    public override void Pay(double km, bool isHolyday) {
        base.Pay(km, isHolyday);
    }
    ~SixteenPlace() {}
}