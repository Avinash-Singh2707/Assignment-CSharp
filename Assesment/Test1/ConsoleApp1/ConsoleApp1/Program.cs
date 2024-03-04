using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            //pro.FirstQuestion();
            //Console.WriteLine(pro.SecondQuestion());
            Console.WriteLine("The largest number is: "+pro.ThirdQuestion());
            Console.Read();
        }
        public void FirstQuestion()
        {
            string s;
            int n;
            Console.WriteLine("Enter a String and position ");
            string newS="";  //Empty String
            s = Console.ReadLine();
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<s.Length;i++)
            {
                if (i != n)
                    newS = newS + s[i];
            }
            Console.WriteLine(newS);

        }

        public string SecondQuestion()
        {
            string s;
            //char temp;
            Console.WriteLine("Enter a string: ");   //Avi
            s = Console.ReadLine();
            int len = s.Length;
            return s[len-1] + s.Substring(1, len - 2) + s[0];  // using inbuild function

            //Without using inbuild func
            //char Last = s[len - 1];   //i
            ////Console.WriteLine(Last);
            //char first;
            //int LastChar = s.Length - 1;

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (i == 0 || i == s.Length - 1)
            //    {

            //        temp = s[i];   // A
            //        s[LastChar] = temp;


            //    }

            //}
            //return s;

        }

        public int ThirdQuestion()
        {
            int a, b, c;
            Console.WriteLine("Enter the value of a b and c: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a >=b && a >=c)
                return a;
            else if (b >= a && b >= c)
                return b;
            else
                return c;



        }
    }
}
