using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaja_6_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Pit_Trikotnik t1 = new Pit_Trikotnik(6, 8);
            Console.WriteLine(t1.Ploscina());


            Kvader k1 = new Kvader(3, 3);
            Kvader k2 = new Kvader(6, 4);

            Console.WriteLine("Kvader 1");
            k1.VrniObseg();
            k1.VrniPloscino();
            Console.WriteLine("");
            Console.WriteLine("Kvader 2");
            k2.VrniObseg();
            k2.VrniPloscino();

        }
    }
}
