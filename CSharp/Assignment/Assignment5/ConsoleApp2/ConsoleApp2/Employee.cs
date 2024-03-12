using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public float salary;

        public Employee(int EmpId,string EmpName,float salary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.salary = salary;
        }

    }
    class PartTimeEmployee : Employee
    {
        int wages;
        public PartTimeEmployee(int EmpId, string EmpName, float salary,int wages):base(EmpId,EmpName,salary) // dereived  class constructor 
        {
            this.wages = wages;
        }
        public static void run()
        {
            Console.WriteLine("Enter EmployeeID, Name, Salary and Wages: ");
            
            int Id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            float sal = int.Parse(Console.ReadLine());
            int wages = int.Parse(Console.ReadLine());  

            // Instantiate Base class through derived constructor
            PartTimeEmployee pt = new PartTimeEmployee(Id,name,sal,wages);

            Console.WriteLine($"Employee ID: {pt.EmpId}");
            Console.WriteLine($"Employee Name: {pt.EmpName}");
            Console.WriteLine($"Employee Salary: {pt.salary}");
            Console.WriteLine($"Employee Wages: {pt.wages}");

        }
    }
}
