﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class ProgramT8
    {
        public static void Main()
        {
            Console.WriteLine("Please input your overall total course mark");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 < 50)
            {
                Console.WriteLine("You have not passed");
            }
            else
            {
                Console.WriteLine("You have passed");
            }
        }
    }
}
