using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        int EmployeeID;
        string FirstName;
        string LastName;
        string Title;
        string DOB;
        string DOJ;
        string City;


        public static void EmpList()
        {
            List<Employee> empList = new List<Employee>()  // Populating...
            {
                new Employee() { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = "16/11/1984", DOJ = "8/6/2011", City = "Mumbai"},
                new Employee() { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = "20/08/1984", DOJ = "7/7/2012", City = "Mumbai" },
                new Employee() { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = "14/11/1987", DOJ = "12/4/2015", City = "Pune" },
                new Employee() { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = "3/6/1990", DOJ = "2/2/2016", City = "Pune" },
                new Employee() { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = "8/3/1991", DOJ = "2/2/2016", City = "Mumbai" },
                new Employee() { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = "7/11/1989", DOJ = "8/8/2014", City = "Chennai" },
                new Employee() { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = "2/12/1989", DOJ = "1/6/2015", City = "Mumbai" },
                new Employee() { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = "11/11/1993", DOJ = "6/11/2014", City = "Chennai" },
                new Employee() { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = "12/8/1992", DOJ = "3/12/2014 ", City = "Chennai" },
                new Employee() { EmployeeID = 1010, FirstName = "Sumit  ", LastName = "Shah", Title = "Manager", DOB = "12/4/1991", DOJ = "2/1/2016", City = "Pune" },
            };
            Console.WriteLine("Display detail of all the employee");
            DisplayDetails(empList);
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Display details of all the employee whose location is not Mumbai");
            var NotInMumbai = empList.Where(emp => emp.City != "Mumbai");
            DisplayDetails(NotInMumbai.ToList());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Display details of all the employee whose title is AsstManager");
            var assMan = empList.Where(emp => emp.Title == "AsstManager");
            DisplayDetails(assMan.ToList());
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Display details of all the employee whose Last Name start with S");
            var LastName = empList.Where(emp => emp.LastName.StartsWith("S"));
            DisplayDetails(LastName.ToList());




        }
        public static void DisplayDetails(List<Employee> employees)
        {
            foreach(var emp in employees)
            {
                Console.WriteLine($"EmployeeID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}, Title: {emp.Title}, Data of Birth: {emp.DOB}, Date of Joining: {emp.DOJ}, Title: {emp.Title}");
            }
        }
        
    }
}
