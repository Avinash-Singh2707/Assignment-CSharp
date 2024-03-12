using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }

        void ShowDetails();       // Only declration not implementation


    }
    class Dayscholar:IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar: StudentID: {StudentId} and Name: {Name}");
        }

    }
    class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public void ShowDetails()
        {
            Console.WriteLine($"Resident: StudentID: {StudentId} and Name: {Name}");
        }
    }
    class Call
    {
        public static void InterFace()
        {
            Console.WriteLine("Enter StudentID and Name of DayScholar: ");
            Dayscholar ds = new Dayscholar();
            ds.StudentId = int.Parse(Console.ReadLine());
            ds.Name = Console.ReadLine();
            ds.ShowDetails();
            Console.WriteLine("Enter StudentID and Name of Resident: ");
            Resident rs = new Resident();
            rs.StudentId = int.Parse(Console.ReadLine());
            rs.Name = Console.ReadLine();
            rs.ShowDetails();

        }

    }
}
