using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10Lab
{
    public class AnalogWatch: Watch
    {
        public string Style { get; set; }
        protected string[] Styles = { "classic", "fashion", "sport", "premium" };

        public AnalogWatch() : base()//без параметров
        {
            Style = "NoStyle";
        }

        public AnalogWatch(string brand, int yearIssue, int number, string style) : base(brand, yearIssue, number) //с параметрами
        {
            Style = style;
        }
        [ExcludeFromCodeCoverage]
        public override void Show()//вирутальный
        {
            base.Show();
            Console.WriteLine($"AnalogWatch: Стиль часов: {Style}");
        }
        [ExcludeFromCodeCoverage]
        public new void Show1() //не виртуальный
        {
            base.Show();
            Console.WriteLine($"AnalogWatch: Стиль часов: {Style}");
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is AnalogWatch)) return false;
            AnalogWatch clock = (AnalogWatch)obj;
            return this.Brand == clock.Brand && this.YearIssue == clock.YearIssue && this.Style == clock.Style;
        }
        [ExcludeFromCodeCoverage]
        public override void Init()//ввод с клавиатуры
        {
            base.Init();
            Console.WriteLine("Введите стиль часов");
            Style = Console.ReadLine();
        }
        [ExcludeFromCodeCoverage]
        public override void RandomInit()//заполнение дсч
        {
            base.RandomInit();
            Style = Styles[rnd.Next(Styles.Length)];
        }
    }
}
