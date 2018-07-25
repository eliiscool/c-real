using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class ProgramT5
    {
        public static void Main()
        {
            Console.WriteLine("Please input your first number");
            int num1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(num1 + " * " + i + " = " +(num1 * i));
            }
            Console.ReadKey();
        }
    }
}
