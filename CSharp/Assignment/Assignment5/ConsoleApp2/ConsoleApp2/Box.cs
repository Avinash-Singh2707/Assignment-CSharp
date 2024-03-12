using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Box
    {
        //public int length { get; set; }             // auto properties of length and breadth
        //public int breadth { get; set; }
        
        public int length;
        public int breadth;
        public Box(int len,int bre)
        {
            length = len;
            breadth = bre;
        }
        public static Box operator +(Box b1, Box b2)      // operator overloading
        {
            int newLength = b1.length + b2.length;
            int newBreadth = b1.breadth + b2.breadth;
            return new Box(newLength, newBreadth);
        }

    }
    public class Test             // Creating Test class to execute the above...
    {
        public static void TestBox()
        {
            Console.WriteLine("Enter the length and breadth:->> ");
            int len, bre;
            len = int.Parse(Console.ReadLine());
            bre = int.Parse(Console.ReadLine());


            Box b1 = new Box(len, bre);
            Box b2 = new Box(len, bre);
            Box b3 = b1 + b2;         // 

            Console.WriteLine($"The Length of Third Box is {b3.length}");
            Console.WriteLine($"The breadth of Third Box is {b3.breadth}");


        }
    }
    
}
