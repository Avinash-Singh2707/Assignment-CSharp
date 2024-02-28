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
            //pro.IsEqual();
            //pro.Ispositive(5);
            //pro.mul(5);
            //pro.DayWord();
            //pro.TripleSum(2, 2);
            //pro.Arr();
            //pro.TenMarks();
            //pro.CopyArray();
            //pro.String();
            pro.StringEquals();
            //pro.Arithmetic_Op(10, 20, out int add, out int sub, out int mul, out int div);
            //Console.WriteLine($"Sum is {add}, Product is {mul}, Subtraction is {sub} and division is {div}");
            //Console.Write(pro.BuildReverse("Avinash")); 
            Console.Read();
        }
        public void IsEqual()
        {
            int a, b;
            Console.WriteLine("Enter a value of a and b: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
                Console.WriteLine("a and b are equals");
            else
                Console.WriteLine("a and b are not equal");
        }
        public void Ispositive(int a)
        {
            if (a >= 0)
                Console.WriteLine("a is positive number");
            else
                Console.WriteLine("a is negative number");
        }
        public void mul(int a)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
        }

        public void DayWord()
        {
            int n;
            Console.WriteLine("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }



        }

        public void TripleSum(int a, int b)
        {
            if (a == b)
                Console.WriteLine($"a and b are equals: {(a + b) * 3}");
            else
                Console.WriteLine($"a and b are not equal: {(a + b)}");
        }

        public void Arr()
        {
            int n;
            Console.WriteLine("Enter the size of an array: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter numbers:   ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine($"The Total is: {sum}");
            Console.WriteLine($"Average value of Array Elements: {sum / n}");
            Console.WriteLine($"Maximum Element is: {arr.Max()}");
            Console.WriteLine($"Minimum Elemenet is: { arr.Min()}");


        }

        public void TenMarks()
        {
            int[] marks = new int[10];
            Console.WriteLine("Enter the marks of the 10 students:  ");
            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += marks[i];
            }
            Console.WriteLine($"The total is {sum}");
            Console.WriteLine($"The Average is {sum / 10}");
            Console.WriteLine($"The Minimum marks is: {marks.Min()}");
            Console.WriteLine($"The Maximum marks is: {marks.Max()}");
            Array.Sort(marks);  // sort funcion -> Ascending order
            Console.WriteLine("The Ascending order: ");
            for (int i = 0; i < marks.Length; i++)
            {

                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();  // for changing line
            Console.WriteLine("The Descending order: ");
            for (int i = marks.Length - 1; i >= 0; i--)
            {

                Console.Write(marks[i] + " ");
            }
        }

        public void CopyArray()
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5];
            // Copying...
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            //Display
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }




        }

        public void String()
        {
            string s;
            Console.WriteLine("ENter a string: ");
            s = Console.ReadLine();
            Console.WriteLine($"The length of string: {s.Length}");
            // Reverse -> s.reverse -> inbuild function
            char []c = s.Reverse().ToArray();   //converting array of charater ??
            Console.WriteLine("The Reverse string using inbuild function: ");
            for(int i=0;i<c.Length;i++)
            {
                Console.Write(c[i]);
            }
            Console.WriteLine();
            // reverse string using loop
            Console.WriteLine("The reverse String is: ");

            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i] + " ");
            }
        }

        public void StringEquals()
        {
            string s1, s2;
            Console.WriteLine("Enter two string: ");
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Not Equals");
                    return;
                }

            }
            Console.WriteLine("Equals");
            // using inbuild function String.equals();
            Console.WriteLine("Using Inbuild function string.equal(s1,s2)");
            //bool x = string.Equals(s1, s2);  
            bool x = s1.Equals(s2);  // it will return bool 
            if (x)
                Console.WriteLine("String were equals");
            else
                Console.WriteLine("String were not equals");



        }

        public void Arithmetic_Op(int n1, int n2, out int add, out int sub, out int mul, out int div)
        {
            add = n1 + n2;
            sub = n1 - n2;
            mul = n1 * n2;
            div = n1 / n2;

        }

        //public char[] BuildReverse(string s)
        //{
        //    char[] reversedString = s.Reverse().ToArray();  //
        //    return reversedString;

        //}
    }
}
