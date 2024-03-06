using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Scholarship
    {
        double ScAmount;
        public void Merit(int marks, int fees)
        {
            if (marks >= 70 && marks <= 80)
                ScAmount = (0.2 * fees);
            else if (marks > 80 && marks <= 90)
                ScAmount = (0.3 * fees);
            else if (marks > 90)
                ScAmount = 0.5 * fees;
            Console.WriteLine($"The Scholarship Amount: {ScAmount}");
        }
    }
}

