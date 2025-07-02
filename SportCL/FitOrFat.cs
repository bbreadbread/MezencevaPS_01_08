using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCL
{
    public class FitOrFat : Athlete
    {
        //Дополнительное поле P - полный или худой?
        public string fitOrFat { get; set; }

        //Дочерний конструктор; наследует поля от базового
        public FitOrFat(double h, int a, double w, string f) : base (h: h, a: a, w: w) {
            fitOrFat = f;
        }
        //Дочерний переопределенный метод качества
        public override double Q()
        {
            if (fitOrFat == "fit")
                return base.Q() - 600;
            else if (fitOrFat == "fat")
                return base.Q() + 900;
            else return 0;
        }

        public override string Print()
        {
            return $"{base.Print()}, {Q()};";
        }
    }
}
