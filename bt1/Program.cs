using System;

namespace bt1
{
    class Program
    {
        // _1
        public enum Rank
        {
            Diamond = 500000000,
            Gold = 300000000,
            Silver = 200000000,
            Copper = 100000000,
        }

        public class Customer {
            private string cId;
            private string cName;
            private string cPhone;
            private string cAddress;
            private Rank cRank;
            private double cTotal;
            public Customer()
            {
            this.cId = "";
            this.cPhone = "";
            this.cAddress = "";
            this.cRank = Rank.Copper;
            this.cTotal = 0.0;
            }
            public Customer(string id, string name,
            string phone, string address, double total)
            {
            this.cId = id;
            this.cName = name;
            this.cPhone = phone;
            this.cAddress = address;
            this.cTotal = total;
            this.UpdateRank();
            }
            public void SetTotal(double total)
            {
            this.cTotal = total;
            this.UpdateRank();
            }
            public void DisplayInfo()
            {
                Console.WriteLine("ID: " + this.cId);
                Console.WriteLine("Name: " + this.cName);
                Console.WriteLine("Phone: " + this.cPhone);
                Console.WriteLine("Address: " + this.cAddress);
                Console.Write("Total: ");
                Console.WriteLine(this.cTotal);
                Console.WriteLine("Rank: " + this.cRank);
            }
            public void UpdateRank()
            {
                if (this.cTotal > (double)Rank.Diamond)
                {
                    cRank = Rank.Diamond;
                }
                else if (this.cTotal > (double)Rank.Gold) 
                {
                    cRank = Rank.Gold;
                }
                else if (this.cTotal > (double)Rank.Silver) 
                {
                    cRank = Rank.Silver;
                }
                else
                {
                    cRank = Rank.Copper;
                }
            }
            ~Customer(){}
        }

        //=====================
        // _2
        public class Vaccine 
        {
            private string pName;
            private string pSex;
            private DateTime pBirth;
            private int pAge;
            private string pJob;
            private string pId;
            private string pAddress;
            private int pTimes;
            public Vaccine()
            {
                this.pName = "";
                this.pSex = "";
                this.pBirth = DateTime.Today;
                this.pAge = 0;
                this.pJob = "";
                this.pId = "";
                this.pAddress = "";
                this.pTimes = 0;
            }
            public Vaccine(string name, string sex, DateTime birth,
            string job, string id, string address, int times)
            {
                this.pName = name;
                this.pSex = sex;
                this.pBirth = birth;
                this.pAge = DateTime.Today.Year - this.pBirth.Year;
                this.pJob = job;
                this.pId = id;
                this.pAddress = address;
                this.pTimes = times;
            }
            public int TestVC()
            {
                if (this.pTimes == 2 || this.pAge < 18)
                {
                    return 0;
                }
                else return 1;
            }
            public void UpdateVC() 
            {
                this.pTimes++;
            }
            public void DisplayInfo()
            {
                Console.WriteLine("Name: " + this.pName);
                Console.WriteLine("Sex: " + pSex);
                Console.WriteLine("Birth: " + pBirth.ToLongDateString());
                Console.WriteLine("Job: " + pJob);
                Console.WriteLine("ID: " + this.pId);
                Console.WriteLine("Address: " + this.pAddress);
                Console.Write("Times: ");
                Console.WriteLine(pTimes);
            }
            ~Vaccine(){}
        }

        //=====================
        // _3
        public class Animal
        {
            private string aName;
            private string aTravel;
            private string aVoice;
            public Animal(string name, string travel, string voice) 
            {
                this.aName = name;
                this.aTravel = travel;
                this.aVoice = voice;
            }
            public void InfoAnimal()
            {
                Console.WriteLine("Name: " + this.aName);
                Console.WriteLine("How to Travel: " + aTravel);
                Console.WriteLine("Voice: " + aVoice);
            }
            ~Animal() {}
        }

        //=====================
        // _4
        public class Triangle
        {
            private double a;
            private double b;
            private double c;
            private double _S;
            private double _P;
            private string type;
            public Triangle(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.type = this.TypeTrgl();
                this._S = this.Area();
            }
            public string TypeTrgl()
            {
                if (a + b > c &&
                a + c > b &&
                b + c > a)
                {
                    int mark = 0;
                    if (a == b || a == c || b == c)
                    {
                        mark = 1;
                    }
                    if (a * a == b * b + c * c ||
                    a * a + b * b == c * c ||
                    a * a + c * c == b * b)
                    {
                        if (mark == 0)
                        {
                            return "right triangle";
                        }
                        else return  "isosceles right triangle";
                    }
                    else if (mark == 1) 
                    {
                        return "isosceles triangle";
                    }
                    return "normal triangle";
                }
                return "not triangle";
            }
            public double Area() 
            {
                this._P = this.Perimeter();
                double p_2 = this._P / 2;
                return Math.Sqrt(p_2 * (p_2 - a) * (p_2 - b) * (p_2 - c));
            }
            public double Perimeter()
            {
                return a + b + c;
            }
            ~Triangle() {}
        }

        //=====================
        // _5
        public class Contract
        {
            private string _code;
            private int _days;
            private int _quantity; // so luong
            private double _unit_price; // don gia
            private double _deposit; // tien coc
            private string _id_cus;
            private double _debt;            
            public Contract(string code, int days, int quantity,
            double unit_price, double deposit, string id_cus)
            {
                this._code = code;
                this._days = days;
                this._quantity = quantity;
                this._unit_price = unit_price;
                this._deposit = deposit;
                this._id_cus = id_cus;
                this._debt = this.CalDebt();
            }
            private double CalDebt()
            {
                return _quantity * _unit_price * _days - _deposit;
            }
            public void ShowInfo() 
            {
                Console.WriteLine("Code: " + _code);
                Console.Write("Days: ");
                Console.WriteLine(_days);
                Console.Write("Quantity: ");
                Console.WriteLine(_quantity);
                Console.Write("Unit price: ");
                Console.WriteLine(_unit_price);
                Console.Write("Deposit: ");
                Console.WriteLine(_deposit);
                Console.Write("Days: " + _id_cus);
                Console.WriteLine("Debt: ");
                Console.WriteLine(_debt);
            }
            ~Contract() {}
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1========================\n");
            // _1
            Customer cus = new Customer("20133013", "Tran Nguyen Hanh",
            "0813047991", "HCM", 300000000);
            double price = Convert.ToDouble(Console.ReadLine());
            cus.SetTotal(price);
            cus.DisplayInfo();

            Console.WriteLine("\n2========================\n");

            // _2
            DateTime birth = new DateTime(2002,3,21);
            Vaccine vac = new Vaccine("Tran Nguyen Hanh", "male",
            birth, "Student", "982", "HCM", 0);
            vac.DisplayInfo();

            Console.WriteLine("\n3========================\n");

            //_3
            Animal anl = new Animal("Cat", "4 foot", "Meow");
            anl.InfoAnimal();

            Console.WriteLine("\n4========================\n");

            // _4
            Triangle trg = new Triangle(3, 4, 5);
            Console.WriteLine(trg.TypeTrgl());

            // _5
            Contract ctr = new Contract("u385", 300, 300, 30000, 200000, "20133013");
            ctr.ShowInfo();
        }
    }
}
