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

            //FirstName_UpperCase.UpperCase();    // calling static method...

            //OccurenceLetter oc = new OccurenceLetter();      // creating object....
            //oc.OccLett();

            //Docter doc = new Docter();
            //doc.properties();

            //BankingTransaction BT = new BankingTransaction();
            //BT.Deposit(1000);       // Here calling Deposit method
            //try
            //{
            //    BT.Withdrawn(12000);
            //}
            //catch(InsufficientBalance e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //BT.CheckBalanace();

            Scholarship sc = new Scholarship();
            sc.Merit(91,100);

            Console.Read();

        
        }
    }
}
