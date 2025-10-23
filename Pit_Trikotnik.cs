using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_6_2
{
    public class Pit_Trikotnik
    {
        private double a;
        private double b;
        private double c;

        public Pit_Trikotnik()
        {
            a = 3;
            b = 4;
            c = 5;
        }

        public Pit_Trikotnik(double a, double b)
        {
            this.a = a;
            this.b = b;

            double x = (a * a) + (b * b);
            this.c = Math.Sqrt(x);
        }

        public void Nastavi(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Obseg()
        {
            return a + b + c;
        }

        public double Ploscina()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }


    }
}
