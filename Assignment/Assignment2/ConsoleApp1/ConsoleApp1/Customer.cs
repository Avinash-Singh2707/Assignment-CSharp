using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        static int CustID;           // make it static...
        static string Name;
        static int Age;
        static string PhNo;
        static string City;

        public Customer()   // Custructor with no arguments........
        {
           
        }
        public Customer(int CustId, string name,int age,string phNo,string city)  // Constructor with arguments...
        {
            CustID = CustId;          //??
            Name = name;
            Age = age;
            PhNo = phNo;
            City = city;
        }
        ~ Customer()       // Destructor
        {
            Console.WriteLine("Object were Destroyed......");
            Console.Read();    
        }
        static void  DisplayCustomer()      //Static function can only access static member....
        {
            Console.WriteLine($"Customer Id: {CustID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone Number: {PhNo}");
            Console.WriteLine($"City: {City}");

        }
        static void Main()
        {
            Customer cs1 = new Customer();
            Customer cs2 = new Customer(1,"Avi",20,"1233456774","Gorakhpur");   // Constructor called with arguments
            DisplayCustomer();     //GIVEN-> called directly without any object-> make it static function();
            Console.Read();
        }
    }
}
