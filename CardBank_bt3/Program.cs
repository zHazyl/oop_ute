using System;

namespace CardBank_bt3
{
    class Program
    {
        static void Main(string[] args)
        {
            Card c1 = new CreditCard("20133013", "Tran Nguyen Hanh", 1_000_000_000);
            Card c2 = new DebitCard("20133013A", "Tran Nguyen", 1_000_000_000);
            c1.InforCard();
            c2.InforCard();
            c1.OpenCard();
            c1.Pay(1_000_000_000);
            c1.Tranfer(200_000_000, ref c2);
            c2.OpenCard();
            c2.Pay(200_000_000);
            c2.Tranfer(200_000_000, ref c1);
            c2.InforCard();
            c1.InforCard();
            Console.Read();
        }
    }
}
