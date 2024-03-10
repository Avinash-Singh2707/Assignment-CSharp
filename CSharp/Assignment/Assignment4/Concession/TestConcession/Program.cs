using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Concession;   // using namespace

namespace TestConcession
{
    class Program
    {
        const int TotalFare = 500;
        string name;
        int age;

        // Properties of name and age;
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        public int _age
        {
            get { return age; }
            set { age = value; }
        }
        static void Main(string[] args)
        {
            Program pro = new Program();
            Console.WriteLine("Enter Your name and Age: ");
            pro._name = Console.ReadLine();
            pro._age = Convert.ToInt32(Console.ReadLine());
            TicketConcession tc = new TicketConcession();

            tc.CalculateConcession(pro.name, pro.age);   // Calling CalculateConcession 

            //Lamda_Queries lq = new Lamda_Queries();
            //lq.Square();                      //Question 3(First part)
            //lq.StartWithAEndWithM();            //Question 3 (Second part)
            Console.Read();
        }
    }
}
