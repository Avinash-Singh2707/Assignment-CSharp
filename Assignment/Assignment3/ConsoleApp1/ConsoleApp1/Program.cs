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

            Docter doc = new Docter();
            doc.properties();
            
            Console.Read();
        
        }
    }
}
