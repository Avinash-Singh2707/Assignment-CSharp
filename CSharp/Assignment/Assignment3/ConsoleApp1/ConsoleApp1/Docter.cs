using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Docter
    {
        int RegNo;
        string Name;
        int FeesCharged;

        // declare properties of all private memeber
        public int _RegNo
        {
            get { return RegNo; }
            set { RegNo = value; }
        }
        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int _FeesCharged
        {
            get { return FeesCharged; }
            set { FeesCharged = value; }
        }
        public void properties()
        {
            Docter doc = new Docter();
            doc._RegNo = 1;
            doc._Name = "Avinash Singh";
            doc._FeesCharged = 100000;
            Console.WriteLine(doc._RegNo);
            Console.WriteLine(doc._Name);
            Console.WriteLine(doc._FeesCharged);
            Console.Read();
        }
    }
}
