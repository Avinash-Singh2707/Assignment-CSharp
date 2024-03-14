using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate int Calculate(int a, int b);
    class Delegates
    {
        public static int Add(int a, int b) {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static void Run()
        {

            Calculate c1 = new Calculate(Add);       //Delegates-> Holding referenece method.
            Calculate c2 = new Calculate(Sub);
            Calculate c3 = new Calculate(Mul);

            Console.WriteLine("Enter the value of a and b: ");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Sum of a and b is : {c1(c, d)}");
            Console.WriteLine($"The Subtraction of a and b is : {c2(c, d)}");
            Console.WriteLine($"The Multiplication of a and b is : {c3(c, d)}");

        }

          

    }
}
