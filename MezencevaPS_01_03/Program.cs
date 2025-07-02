using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportCL;

namespace MezencevaPS_01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Листы - для каждого класса свой.
            List<Athlete> athletes = new List<Athlete>();
            List<FitOrFat> athletesF = new List<FitOrFat>();

            string choice = "0";

            do
            {
                Console.WriteLine("\n\n1. Добавить в список. 2. Показать список базовый. 3. Показать список дочерний. 4. Удаление1. 5. Удаление2. 6. Выход");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Рост: ");
                        string he = Console.ReadLine();
                        Console.Write("Возраст: ");
                        string ag = Console.ReadLine();
                        Console.Write("Вес: ");
                        string we = Console.ReadLine();

                        if (double.TryParse(he, out double h) &&
                            int.TryParse(ag, out int a) &&
                            double.TryParse(we, out double w))
                        {
                            string P = "";
                            for(int i = 0; i < 5; i++)
                            {
                                Console.Write("fit or fat?: ");
                                P = Console.ReadLine();
                                if (P == "fit" || P == "fat") break;

                            }

                            Athlete athlete = new Athlete(h, a, w);
                            FitOrFat athleteF = new FitOrFat(h, a, w, P);

                            athletes.Add(athlete);
                            athletesF.Add(athleteF);
                        }
                        else Console.WriteLine("Были введены некорректные значения");
                            ;
                        break;
                    case "2":
                        foreach(var ath in athletes)
                        {
                            Console.WriteLine($"{ath.Print()}, {ath.Q()}");
                        }
                        break;
                    case "3":
                        foreach (var ath in athletesF)
                        {
                            Console.WriteLine($"{ath.Print()}");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Введите ");
                        break;
                    case "5":
                        foreach (var ath in athletesF)
                        {
                            Console.WriteLine($"{ath.Print()}");
                        }
                        break;
                    default: 

                        break;
                }
            } while (choice != "6");
        }
    }
}
