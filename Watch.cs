using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace ClassLibrary10Lab
{
    public class IdNumber
    {
        public int number;
        public IdNumber(int number)
        {
            this.number = number;
        }

        public int Number
        {
            get => number;
            set
            {
                if (value <= 0) //не может быть меньше 0
                    number = 0;
                else number = value;
            }
        }
        public override string ToString()
        {
            return number.ToString();
        }
        public override bool Equals(object? obj) {
        if (obj is IdNumber n) 
                return this.number == n.number;
        return false;
        }
    }
    public class Watch: IInit, IComparable, ICloneable
    {
        protected string brand;
        protected int yearIssue;
        protected Random rnd = new Random();
        public IdNumber id; 

        static string[] Brands = { "Casio", "Ника", "Seiko", "Breguet", "Chopard", "Longines", "Omega", "Cartier", "Patek", "Philippe", "Rolex" };
        public int YearIssue
        {
            get => yearIssue;
            set
            {
                if (value <= 725) //первые часы появились в 725 году в Китае
                    yearIssue = 0;
                else yearIssue = value;
            }
        }

        public string Brand
        {
            get => brand;
            set { brand = value; }
        }

        public Watch() //конструктор без парамтетров
        {
            Brand = "NoBrand";
            YearIssue = 0;
            id = new IdNumber(1);
        }

        public Watch(string brand, int yearIssue, int Number) //конструктор с параметрами
        {
            Brand = brand;
            YearIssue = yearIssue;
            id = new IdNumber(Number);
        }
        [ExcludeFromCodeCoverage]
        public virtual void Show() //виртуальный метод
        {
            Console.WriteLine($"Watch: Бренд: {Brand}, Год выпуска: {YearIssue},  ");
        }
        [ExcludeFromCodeCoverage]
        public void Show1() //не виртуальный метод
        {
            Console.WriteLine($"Watch: Бренд: {Brand}, Год выпуска: {YearIssue},  ");
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Watch)) return false;
            Watch clock = (Watch)obj;
            return this.Brand == clock.Brand && this.YearIssue == clock.YearIssue;
        }
        [ExcludeFromCodeCoverage]
        public virtual void Init() //ввлд с клавиатуры
        {
            Console.WriteLine("Введите id");
            try
            {
                id.number = int.Parse(Console.ReadLine());
            }
            catch
            {
                id.number = 0;
            }
            Console.WriteLine("Введите бренд");
            Brand = Console.ReadLine();
            Console.WriteLine("Введите год выпуска");
            try
            {
                YearIssue = int.Parse(Console.ReadLine());
            }
            catch
            {
                YearIssue = 0;
            }
        }
        [ExcludeFromCodeCoverage]
        public virtual void RandomInit() //заполнение дсч
        {
            Brand = Brands[rnd.Next(Brands.Length)];
            YearIssue = rnd.Next(725, 2024);
            id.number = rnd.Next(1, 100);
        }

        public int CompareTo(object? obj) //сравнение
        {
            if (obj == null || !(obj is Watch)) return -1;
            Watch clock = obj as Watch;
            return String.Compare(this.Brand, clock.Brand);
        }

        public object Clone()//клонирование
        {
            return new Watch(Brand, YearIssue, id.number);
        }

        public object ShallowCopy()//копирование
        {
            return this.MemberwiseClone();
        }
    }
}
