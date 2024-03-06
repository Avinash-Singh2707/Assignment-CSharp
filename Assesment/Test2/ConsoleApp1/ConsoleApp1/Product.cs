using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        int ProductId;
        string ProductName;
        double price;

        public static void SortedListFunction()   //Use Respective Function -> Uses Sorted List
        {
            SortedList s1 = new SortedList();
            s1.Add(100,"Apple");
            s1.Add(90,"Grapes");
            s1.Add(50,"PineApple");
            s1.Add(25,"Apple");
            s1.Add(70,"Grapes");
            s1.Add(10,"PineApple");
            s1.Add(23,"Apple");
            s1.Add(94,"Grapes");
            s1.Add(30,"PineApple");
            s1.Add(60,"Banana");
            Console.WriteLine("------Sorted Based on their price-----");
            foreach (DictionaryEntry de in s1)
            {
                
                Console.WriteLine(""+de.Key+ " "+de.Value);
                Console.WriteLine();
            }

        }
    }
}
