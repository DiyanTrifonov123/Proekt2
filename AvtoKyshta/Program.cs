using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoKyshta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CarDealerShip> list = new List<CarDealerShip>();
            Console.Write($"Въведи брой: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                CarDealerShip car = new CarDealerShip();
                car.Input();
                list.Add(car);
            }

            Console.WriteLine($"1. Принтирай всички коли");
            Console.WriteLine($"2. Принтирай всички коли по зададена марка");
            Console.WriteLine($"3. Принтирай всички коли по зададен ценови диапазон");
            Console.WriteLine($"4. Актуализирай или изтрий информация за автомобил по дадена марка");
            Console.WriteLine($"5. Изтрий кола по зададена марка");
            Console.WriteLine($"6. Принтирай средната възраст на колите");
            Console.WriteLine($"7. Принтирай информация за най-старата кола");
            Console.WriteLine($"8. Принтирай информация за най-новата кола по зададена марка");
            Console.WriteLine($"9. Принтирай всички коли сортирани по цените им");
            Console.WriteLine($"10. Изход");
            Console.WriteLine();

            Console.Write($"Въведи номер на команда: ");
            int command = int.Parse(Console.ReadLine());

            while (command < 10)
            {
                switch (command)
                {
                    case 1:
                        foreach (var item in list)
                        {
                            item.Print();
                        }
                        break;

                    case 2:
                        Console.Write($"Марка за търсене: ");
                        string brandSearch = Console.ReadLine().ToLower();
                        foreach (var item in list)
                        {
                            if (item.Brand.ToLower() == brandSearch)
                            {
                                item.Print();
                            }
                        }
                        break;

                    case 3:
                        Console.Write($"Минимална цена: ");
                        int down = int.Parse(Console.ReadLine());
                        Console.Write($"Максимална цена: ");
                        int up = int.Parse(Console.ReadLine());
                        foreach (var item in list)
                        {
                            if (item.Price >= down && item.Price <= up)
                            {
                                item.Print();
                            }
                        }
                        break;

                    case 4:
                        Console.Write($"Актуализация или изтриване: ");
                        string cmd = Console.ReadLine().ToLower();
                        if (cmd == "актуализация")
                        {
                            Console.Write("Марка за актуализация: ");
                            string brandAct = Console.ReadLine().ToLower();
                            foreach (var item in list)
                            {
                                if (item.Brand.ToLower() == brandAct)
                                {
                                    item.Input();
                                }
                            }
                        }
                        else
                        {
                            Console.Write("Марка за изтриване: ");
                            string brandDel = Console.ReadLine().ToLower();
                            list.RemoveAll(item => item.Brand.ToLower() == brandDel);
                        }
                        break;

                    case 5:
                        Console.Write($"Марка за изтриване: ");
                        string brandDelete = Console.ReadLine().ToLower();
                        list.RemoveAll(item => item.Brand.ToLower() == brandDelete);
                        break;

                    case 6:
                        var avg = 0.0;
                        foreach (var item in list)
                        {
                            avg += item.Year;
                        }
                        avg = avg / list.Count;
                        Console.WriteLine($"Средна възраст на колите: {avg:f2} година.");
                        break;

                    case 7:
                        var oldest = 99999999;
                        foreach (var item in list)
                        {
                            if (item.Year < oldest)
                            {
                                oldest = item.Year;
                            }
                        }

                        foreach (var item in list)
                        {
                            if (item.Year == oldest)
                            {
                                item.Print();
                            }
                        }
                        break;

                    case 8:
                        var newest = -99999999;
                        Console.Write($"Марка: ");
                        string brandSearch2 = Console.ReadLine().ToLower();
                        foreach (var item in list)
                        {
                            if (item.Brand.ToLower() == brandSearch2)
                            {
                                if (item.Year > newest)
                                {
                                    newest = item.Year;
                                }
                            }
                        }

                        foreach (var item in list)
                        {
                            if (item.Year == newest)
                            {
                                item.Print();
                            }
                        }
                        break;

                    case 9:
                        list.Sort((x, y) => x.Price.CompareTo(y.Price));
                        foreach (var item in list)
                        {
                            item.Print();
                        }
                        break;

                    default:
                        break;
                }
                Console.Write($"Натисни копче за да продължиш!");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine($"1. Принтирай всички коли");
                Console.WriteLine($"2. Принтирай всички коли по зададена марка");
                Console.WriteLine($"3. Принтирай всички коли по зададен ценови диапазон");
                Console.WriteLine($"4. Актуализирай или изтрий информация за автомобили");
                Console.WriteLine($"5. Изтрий кола по зададена марка");
                Console.WriteLine($"6. Принтирай средната възраст на колите");
                Console.WriteLine($"7. Принтирай информация за най-старата кола");
                Console.WriteLine($"8. Принтирай информация за най-новата кола по зададена марка");
                Console.WriteLine($"9. Принтирай всички коли сортирани по цените им");
                Console.WriteLine($"10. Изход");
                Console.WriteLine();

                Console.Write($"Въведи номер на команда: ");
                command = int.Parse(Console.ReadLine());
            }
        }
    }
}
