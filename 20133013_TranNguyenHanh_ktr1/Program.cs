using System;

namespace _20133013_TranNguyenHanh_ktr1
{
    public enum State
    {
        Block = 0,
        Unblock = 1
    }
    public class IdCard
    {
        private string _name;
        private string _id;
        private DateTime _opening_date;
        private DateTime _expiration_date;
        private double _money;
	private int _state;
        public IdCard()
        {
            this._name = "";
            this._id = "";
            this._opening_date = DateTime.Today;
            this._expiration_date = DateTime.Today;
            this._money = 0.0;
	    this._state = 0;
        }
        public IdCard(string name, string id, DateTime opening_date,
        DateTime expiration_date, double money)
        {
            this._name = name;
            this._id = id;
            this._opening_date = opening_date;
            this._expiration_date = expiration_date;
            this._money = money;
            if (this.ExpTest() == 0) this._state = 0;
            if (this.ExpTest() == 1) this._state = 1;
        }
        public int ExpTest()
        {
            if (this._expiration_date >= DateTime.Today)
                return 1;
            return 0;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + this._name);
            Console.WriteLine("ID: " + this._id);
            Console.WriteLine("Opening date: " + this._opening_date.ToShortDateString());
            Console.WriteLine("Expiration date: " + this._expiration_date.ToShortDateString());
            Console.Write("Money: ");
            Console.Write(this._money);
            Console.WriteLine(" USD");
            Console.Write("State: ");
            if (this.ExpTest() == 0)
                Console.WriteLine(State.Block);
            else Console.WriteLine(State.Unblock);
        }
        ~IdCard() {}
    }
    class Program
    {
        static void Main(string[] args)
        {
            DateTime op1 = new DateTime(2015, 7, 1);
            DateTime ex1 = new DateTime(2022, 1, 1);
            IdCard id1 = new IdCard("Tran Nguyen Hanh", "20133013", op1, ex1, 1000000000);
            id1.ShowInfo();
            Console.ReadLine();
        }
    }
}