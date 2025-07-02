using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCL
{
    public class Athlete
    {
        //Рост
        public double height { get; set; }
        //Возраст
        public int age { get; set; }
        //Вес
        public double weight { get; set; }

        //Базовый конструктор
        public Athlete(double h, int a, double w)
        {
            height = h;
            age = a;
            weight = w;
        }

        //Базовый виртуальный метод качества
        public virtual double Q()
        {
            return (height * 1.8) - (age * 4.7) + (weight * 9.6) + 1255;
        }

        //Вывод информации об объекте
        public virtual string Print()
        {
            return $"Рост: {height}, возраст: {age}, вес: {weight}";
        }

        //Первое удаление
        void deleteAth(List<Athlete> l, int count)
        {
            l.RemoveAt(count);
        }
        //Второе удаление
        void deleteAth(List<Athlete> l, double height)
        {

        }
    }
}
