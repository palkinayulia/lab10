using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10Lab
{
    public class SmartWatch: Watch
    {
        public string OS { get; set; }
        public bool Pulsometer { get; set; }
        protected string[] OSes = { "Android Wear", "WatchOS", "Tizen" };
        protected bool[] Pulses = { true, false };


        public SmartWatch() : base() //без параметров
        {
            OS = "NoOS";
            Pulsometer = false;
        }

        public SmartWatch(string brand, int yearIssue,int number, string operatingSystem, bool pulsometer) : base(brand, yearIssue, number)//с параметрами
        {
            OS = operatingSystem;
            Pulsometer = pulsometer;
        }

        [ExcludeFromCodeCoverage]
        public override void Show()//вирутальный
        {
            base.Show();
            Console.WriteLine($"SmartWatch: Операционная система: {OS}, Наличие датчика измерения пульса: {Pulsometer}");
        }
        public new void Show1()//не виртуальный
        {
            base.Show();
            Console.WriteLine($"SmartWatch: Операционная система: {OS}, Наличие датчика измерения пульса: {Pulsometer}");
        }

        [ExcludeFromCodeCoverage]
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is SmartWatch)) return false;
            SmartWatch clock = (SmartWatch)obj;
            return this.Brand == clock.Brand && this.YearIssue == clock.YearIssue && this.OS == clock.OS && this.Pulsometer == clock.Pulsometer;
        }

        [ExcludeFromCodeCoverage]
        public override void Init() //ввод с клавиатуры
        {
            base.Init();
            Console.WriteLine("Введите тип дисплея");
            OS = Console.ReadLine();
            Console.WriteLine("Имеется датчик измерения пульса? (Введите true/false)");
            Pulsometer = bool.Parse(Console.ReadLine());
        }

        [ExcludeFromCodeCoverage]
        public override void RandomInit()//заполнение дсч
        {
            base.RandomInit();
            OS = OSes[rnd.Next(OSes.Length)];
            Pulsometer = Pulses[rnd.Next(Pulses.Length)];
        }
    }
}
