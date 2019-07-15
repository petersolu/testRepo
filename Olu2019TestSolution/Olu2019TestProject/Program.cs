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
            //int age = 88;
            //char alphabet = 'c';
            //string name = "Olubukola";
            //double bankBalance = 600000;

            //Console.WriteLine("my age is " + age);
            //Console.WriteLine(alphabet);
            //Console.WriteLine("my name is " + name);
            //Console.WriteLine(bankBalance);
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine();

            //Console.WriteLine("Enter username and press the enter key ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your bank balance");
            //int balance = Convert.ToInt32(Console.ReadLine());

            //if (name.Equals("Olubukola") || name.Equals("Andre"))
            //{
            //    Console.WriteLine(name + " is my name and my balance is " + balance);
            //}

            //else
            //{
            //    Console.WriteLine("Name entered is incorrect, exiting. . . ");
            //}
            //Console.Read();

            //Console.WriteLine("Enter Student Grade for assessment = ");
            ////string FoodName = Console.ReadLine();
            //int StudentNumber = Convert.ToInt32(Console.ReadLine());

            //switch (StudentNumber)
            //{
            //    case 10:
            //        Console.WriteLine("Your grade is {0}, you have failed", StudentNumber);
            //        break;
            //    case 50:
            //        Console.WriteLine("Your grade is {0}, you have passed", StudentNumber);
            //        break;
            //    case 80:
            //        Console.WriteLine("Your grade is {0}, you have done excellently!", StudentNumber);
            //        break;
            //    default:
            //        break;
            //}


            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(i);

            //}
            triangle triangleIsosceles = new triangle();
            triangleIsosceles.triBase = 10;
            triangleIsosceles.triHeight = 10;
            triangleIsosceles.TriangleArea();

            triangle rightAngleTriangle = new triangle();
            rightAngleTriangle.triBase = 7;
            rightAngleTriangle.triHeight = 23;
            rightAngleTriangle.TriangleArea();

            triangle squaredTriangle = new triangle();
            squaredTriangle.triBase = 20;
            squaredTriangle.triHeight = 10;
            squaredTriangle.SquareArea();

            triangle poly = new triangle();
            poly.PolygonArea(100, 10);

            Console.ReadKey();
        }
    }
}