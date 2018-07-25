using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class ProgramT6
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Please input your first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your second number");
            int num2 = int.Parse(Console.ReadLine());
            int num3;
            int num4;
            num3 = num1;
            num4 = num2;
            num2 = num3;
            num1 = num4;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
