using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConcession
{
    class Lamda_Queries
    {
        //Print a list of whose square is greater then 20...
        public void Square()
        {
            List <int> num = new List<int>();
            Console.WriteLine("Enter the size of list: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter a {size} numbers: ");
            for (int i = 0; i < size; i++)
            {
                int value;
                value = Convert.ToInt32(Console.ReadLine());
                num.Add(value);
            }

            var sqaure = num.FindAll(a => (a * a) > 20);   // lamda queries
            Console.WriteLine("The List of numbers whose square is greater then 20->");
            foreach (var v in sqaure)
            {
                Console.WriteLine(v * v);
            }
        }

        public void StartWithAEndWithM()
        {
            //List<string> names = new List<string> { "Adam", "Avi", "Rahul", "Aram" };
            List<string> names = new List<string>();
            Console.WriteLine("Enter the size of list: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} Names: ");
            for (int i = 0; i < size; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);

            }
            var res = names.Where(name => name.StartsWith("A") && name.EndsWith("m")); // Lamda Queries
            Console.WriteLine("The list of names which start from 'A' and end with 'm' ");
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }

        }
    }
}
