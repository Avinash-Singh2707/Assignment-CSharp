using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class TicketConcession
    {
        const int TotalFare = 500;
        public void CalculateConcession(string name,int age)
        {
            if (age <= 5)
            {
                Console.WriteLine("TIKET BOOKED");
                Console.WriteLine($"Little Champs- Free Ticket, Name: {name}, Age: {age}");
                
            }
            else if(age>60)
            {
                float fare = 0.3f * TotalFare;
                Console.WriteLine("TIKET BOOKED");
                Console.WriteLine($"Senior Citizen {fare} Name: {name}, Age: {age}");

            }
        }
    }
}
