using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class ProgramT4
    {
        public static void Main()
        {
            Console.WriteLine("Please input your first Name");
            string fName = (Console.ReadLine());
            Console.WriteLine("Please input your Last Name");
            string lName = (Console.ReadLine());
            Console.WriteLine(fName + " " + lName);
            Console.ReadKey();
        }
    }
}
