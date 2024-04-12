using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netAssesment
{
    class Program
    {
        static DataClasses1DataContext db = new DataClasses1DataContext();  // creating object DataBase Context.....
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for InsertEmployee: ");
            Console.WriteLine("Press 2 for Show Employee: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                InsertEmp();
                Console.WriteLine("Your Employee Details:  ");
                showEmp();
            }
            else if(n==2)
            {
                showEmp();
            }

           
            Console.Read();
        }
        public static void InsertEmp()
        {
            Console.WriteLine("Enter Salary>25000, and EmployeeType is wheather 'P->Permanent' and 'C->Contract':  ");
            Console.WriteLine("Enter Employee Details: ");
            Console.Write("Enter Name: ");
            
            string name = Console.ReadLine();
            Console.Write("Enter Salary: ");
            int sal = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Type: ");
            char emptype = char.Parse(Console.ReadLine());

            // calling stored proceudure....and inserting values in database throught procedure...
            db.Insert_Emp_Details(name,sal,emptype);
        }
        //Showing Employee Details....
        public static void showEmp()
        {
            var e = db.Employee_Details.ToList();
            foreach(var i in e)
            {
                Console.WriteLine($"Employee No: {i.Empno} Employee Name: {i.EmpName} Salary: {i.Empsal} Employee Type: {i.Emptype}" );
            }
        }
    }
}
