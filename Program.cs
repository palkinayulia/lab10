using ClassLibrary10Lab;

namespace Лабораторная10
{
    internal class Program
    {
        static Watch[] WatchArray(Watch[] array) //создание массива 
        {
            for (int i = 0; i < 5; i++)
            {
                Watch clock = new Watch();
                clock.RandomInit();
                array[i] = clock;
            }
            for (int i = 5; i < 10; i++)
            {
                DigitalWatch clock = new DigitalWatch();
                clock.RandomInit();
                array[i] = clock;
            }
            for (int i = 10; i < 15; i++)
            {
                AnalogWatch clock = new AnalogWatch();
                clock.RandomInit();
                array[i] = clock;
            }
            for (int i = 15; i < 20; i++)
            {
                SmartWatch clock = new SmartWatch();
                clock.RandomInit();
                array[i] = clock;
            }

            return array;
        }

        static void PrintWatchArray(Watch[] array)//печать массива 
        {
            foreach (Watch clock in array)
            {
                clock.Show();
            }
        }

        static void CountPulsometer(Watch[] array)//запрос о количестве часов с датчиком пульса
        {
            int countPuls = 0;
            foreach (Watch clock in array) //количество умных часов с датчиком измерения пульса
            {
                if (clock is SmartWatch c)
                    if (c.Pulsometer == true)
                        countPuls++;
            }
            Console.WriteLine($"Количество умных часов с датчиком измерения пульса: {countPuls}");
        }

        static void NewBrandWatch(Watch[] array)//запрос о новом бренде часов по году
        {
            int maxYear = 0;
            string newBrand = "";
            foreach (Watch clock in array) //самый новый бренд часов по году выпуска
            {
                if (clock.YearIssue > maxYear)
                {
                    newBrand = clock.Brand;
                    maxYear = clock.YearIssue;
                }
            }
            Console.WriteLine($"Самый новый бренд часов: {newBrand}");
        }

        static void UniqueStyle(Watch[] array)//запрос об уникальном стиле аналог. часов
        {
            int countClassic = 0;
            int countSport = 0;
            int countFashion = 0;
            int countPremium = 0;
            for (int i = 0; i < 20; i++) //уникальные стили аналоговых часов
            {
                if (array[i] is AnalogWatch clock)
                    if (clock.Style == "classic") countClassic++;
                    else if (clock.Style == "sport") countSport++;
                    else if (clock.Style == "fashion") countFashion++;
                    else if (clock.Style == "premium") countPremium++;
            }
            Console.WriteLine("Уникальные стили аналоговых часов: ");
            if (countClassic == 1) { Console.WriteLine("classic"); }
            if (countSport == 1) { Console.WriteLine("sport"); }
            if (countPremium == 1) { Console.WriteLine("premium"); }
            if (countFashion == 1) { Console.WriteLine("fashion"); }
            else Console.WriteLine("уникальных стилей нет");
        }
        static int NumberCheck() //проверка ввода числа
        {
            bool isConvert;
            int n;
            do
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();
                isConvert = int.TryParse(input, out n);
                if (!isConvert || n < 0) Console.WriteLine("Неправильно введено число \nПопробуйте еще раз.");
            } while (!isConvert || n < 0);
            return n;
        }

        static void Main(string[] args) //функции и меню
        {
            int numberMenu;
            Watch[] array = new Watch[20];
            Console.WriteLine("1 и 2 часть");
            do //меню для 1 и 2 части
            {
                Console.WriteLine("1.Создать массив");
                Console.WriteLine("2.Вывести массив");
                Console.WriteLine("3.Самый новый бренд часов по году");
                Console.WriteLine("4.Количество умных часов с датчиком пульса");
                Console.WriteLine("5.Уникальный стиль аналоговых часов");
                Console.WriteLine("6.Вернуться");
                numberMenu = NumberCheck();
                switch (numberMenu)
                {
                    case 1: //создание массива
                        {
                            WatchArray(array);
                            Console.WriteLine("Массив создан");
                            break;
                        };
                    case 2://печать массива
                        {
                            PrintWatchArray(array);
                            break;
                        };
                    case 3://запрос 1
                        {
                            NewBrandWatch(array);
                            break;
                        };
                    case 4://запрос 2
                        {
                            CountPulsometer(array);
                            break;
                        };
                    case 5://запрос 3
                        {
                            UniqueStyle(array);
                            break;
                        }
                    case 6: { break; } //возвращение в главное меню
                    default: { Console.WriteLine("Неправильно задан пункт меню \nПопробуйте еще раз"); break; };
                }
            } while (numberMenu != 6);

            Console.WriteLine("3 часть");
            IInit[] array2 = new IInit[10];

            do //меню для 3 части
            {
                Console.WriteLine("1.Создать массив из разных элементов");
                Console.WriteLine("2.Вывести массив");
                Console.WriteLine("3.Сортировка массива из прошлой части и поиск элемента");
                Console.WriteLine("4.Сортировка массива по году");
                Console.WriteLine("5.Разница между глубоким и поверхностным копированием");
                Console.WriteLine("6.Вернуться");
                numberMenu = NumberCheck();
                switch (numberMenu)
                {
                    case 1: //создание массива
                        {
                            for (int i = 0; i < 5; i++)
                            {
                                Watch clock = new Watch();
                                clock.RandomInit();
                                array2[i] = clock;
                            }
                            for (int i = 5; i < 10; i++)
                            {
                                Rectangle rec = new Rectangle();
                                rec.RandomInit();
                                array2[i] = rec;
                            }
                            Console.WriteLine("Массив создан");
                            break;
                        };
                    case 2://печать массива
                        {
                            foreach (IInit arr in array2)
                            {
                                arr.Show();
                            }
                            break;
                        };
                    case 3://cortirovka and поиск элемента в массиве
                        {
                            Console.WriteLine();
                            Watch clockk = new Watch();
                            clockk.RandomInit();
                            Console.Write("Элемент для поиска: ");
                            clockk.Show();
                            array[3] = clockk;
                            Array.Sort(array);
                            foreach (Watch clock in array)
                            {
                                clock.Show();
                            }
                            int pos = Array.BinarySearch(array, clockk);
                            if (pos < 0) Console.WriteLine("Нет такого элемента");
                            else Console.WriteLine($"Элемент находится на {pos + 1} позиции");
                            break;
                        };
                    case 4://сортировка по году
                        {
                            Console.WriteLine();
                            Array.Sort(array, new SortByYear());
                            foreach (Watch clock in array)
                            {
                                clock.Show();
                            }
                            break;
                        };
                    case 5://разница между поверхностным и глубоким копированием
                        {
                            Watch watch = new Watch();
                            watch.RandomInit();
                            watch.Show();
                            Watch copy = (Watch)watch.ShallowCopy();
                            copy.Show();
                            Watch clon = (Watch)watch.Clone();
                            clon.Show();
                            Console.WriteLine("after");
                            copy.YearIssue = 2024;               
                            copy.id.number = 100;
                            clon.Brand = "clon" + watch.Brand;
                            clon.id.number = 200;
                            watch.Show();
                            copy.Show();
                            clon.Show();
                            break;
                        }
                    case 6: { break; } //возвращение в главное меню
                    default: { Console.WriteLine("Неправильно задан пункт меню \nПопробуйте еще раз"); break; };
                }
            } while (numberMenu != 6);
        }
    }
}
