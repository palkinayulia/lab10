using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10Lab
{
    public class DigitalWatch: Watch
    {
        public string TypeDisplay { get; set; }
        protected string[] TypesDisplay = { "TFT LCD", "IPS LCD", "OLED", "AMOLED", "Retina", "Gorilla Glass" };
        public DigitalWatch() : base() //без параметров
        {
            TypeDisplay = "NoType";
        }

        public DigitalWatch(string brand, int yearIssue,int number, string typeDisplay) : base(brand, yearIssue, number)//с параметрами
        {
            TypeDisplay = typeDisplay;
        }
        [ExcludeFromCodeCoverage]
        public override void Show()//вирутальный
        {
            base.Show();
            Console.WriteLine($"DigitalWatch: Тип дисплея: {TypeDisplay}");
        }
        [ExcludeFromCodeCoverage]
        public new void Show1()//не вирутальный
        {
            base.Show();
            Console.WriteLine($"DigitalWatch: Тип дисплея: {TypeDisplay}");
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is DigitalWatch)) return false;
            DigitalWatch clock = (DigitalWatch)obj;
            return this.Brand == clock.Brand && this.YearIssue == clock.YearIssue && this.TypeDisplay == clock.TypeDisplay;
        }
        [ExcludeFromCodeCoverage]
        public override void Init()//ввод с клавиатуры
        {
            base.Init();
            Console.WriteLine("Введите тип дисплея");
            TypeDisplay = Console.ReadLine();
        }
        [ExcludeFromCodeCoverage]
        public override void RandomInit() //заполнение дсч
        {
            base.RandomInit();
            TypeDisplay = TypesDisplay[rnd.Next(TypesDisplay.Length)];
        }
    }
}
