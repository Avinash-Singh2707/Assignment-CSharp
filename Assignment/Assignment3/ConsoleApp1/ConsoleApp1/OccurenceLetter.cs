using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OccurenceLetter
    {
        public void OccLett()
        {
            string s;
            char c;
            int count = 0;
            Console.WriteLine("Enter a String: ");
            s = Console.ReadLine();
            Console.WriteLine("Enter a character to count a occurence: ");
            c = Convert.ToChar(Console.ReadLine());
            for(int i=0;i<s.Length;i++)
            {
                if (c == s[i])
                    count++;
            }
            Console.WriteLine($"The occurenec of {c} character is {count}");

        }

    }
}
