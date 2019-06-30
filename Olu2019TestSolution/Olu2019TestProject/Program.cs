using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olu2019TestProject
{
    class Program
    {       static void Main(string[] args)
        {
            int age = 88;
            char alphabet = 'c';
            string name = "Olubukola";
            double bankBalance = 600000;

            Console.WriteLine("my age is " + age);
            Console.WriteLine(alphabet);
            Console.WriteLine("my name is " + name);
            Console.WriteLine(bankBalance);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();

            if (name == "Olubukola")
            {
                Console.WriteLine(name + " happens to be my name . . . .");
            }

            Console.ReadKey();
        }              
    }
}
