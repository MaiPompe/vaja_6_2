﻿using System;
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
        }
    }
}
