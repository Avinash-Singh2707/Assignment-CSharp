using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FirstName_UpperCase
    {
        public static void UpperCase()
        {
            string FirstName;
            string LastName;
            Console.WriteLine("Enter your first and last name: ");
            FirstName = Console.ReadLine();
            LastName = Console.ReadLine();
            string FirstUpperCase=FirstName.ToUpper();
            string LastUpperCase=LastName.ToUpper();
            Console.WriteLine("Converting to UPPER CASE:  ");
            Console.WriteLine(FirstUpperCase);
            Console.WriteLine(LastUpperCase);
        }
    }
}
