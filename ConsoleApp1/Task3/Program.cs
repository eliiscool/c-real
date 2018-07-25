using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your first number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 * num2);
            Console.ReadKey();
        }
    }
}
