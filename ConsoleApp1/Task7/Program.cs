using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your second number");
            int num2 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Please input your third number");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.Write("Number 1 is the highest number", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.Write("Number 2 is the Highest number", num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.Write("Number 3 is the Highest number", num3);
            }
        }
    }
}
