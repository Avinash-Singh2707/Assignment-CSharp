using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Employee
    {
        public int EmployeeID {get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>
            {
            new Employee { EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", Title = "Manager", DOB = new DateTime(1984, 11, 16), DOJ = new DateTime(2011, 6, 8), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", DOB = new DateTime(1984, 8, 20), DOJ = new DateTime(2012, 7, 7), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "Madhavi", LastName = "Oza", Title = "Consultant", DOB = new DateTime(1987, 11, 14), DOJ = new DateTime(2015, 4, 12), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1990, 6, 3), DOJ = new DateTime(2016, 2, 2), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", DOB = new DateTime(1991, 3, 8), DOJ = new DateTime(2016, 2, 2), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant", DOB = new DateTime(1989, 11, 7), DOJ = new DateTime(2014, 8, 8), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", DOB = new DateTime(1989, 12, 2), DOJ = new DateTime(2015, 6, 1), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate", DOB = new DateTime(1993, 11, 11), DOJ = new DateTime(2014, 11, 6), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", DOB = new DateTime(1992, 8, 12), DOJ = new DateTime(2014, 12, 3), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "Sumit", LastName = "Shah", Title = "Manager", DOB = new DateTime(1991, 4, 12), DOJ = new DateTime(2016, 1, 2), City = "Pune" }
            };

            // 1. Display a list of all the employees who have joined before 1/1/2015
            IEnumerable<Employee> empJoined = emp.Where(e => e.DOJ < new DateTime(2015,1,1));
            foreach(var e in empJoined)
                Console.WriteLine($"List of Employee who joined before 1/1/2015: {e.FirstName}");
            Console.WriteLine("------------------------------------------------------------");

            //2.Display a list of all the employee whose date of birth is after 1 / 1 / 1990
            IEnumerable<Employee> DOBAfter = emp.Where(e => e.DOB > new DateTime(1990, 1, 1));
            foreach (Employee e in DOBAfter)
                Console.WriteLine($"List of Employee who data of birth is after 1/1/1990: {e.FirstName}");
            Console.WriteLine("------------------------------------------------------------------");

            // 3. Display a list of all the employees whose designation is Consultant and Associate
            Console.WriteLine("The Employee Whose Designation is Consultant and Associate:--");
            var EmpConAss = emp.Where(e => e.Title == "Consultant" || e.Title == "Associate");
            foreach (var e in EmpConAss)
                Console.WriteLine(e.FirstName + " " + e.LastName);

            Console.WriteLine("-------------------------------------------------");
            //4.Display total number of employees
            int EmpCount = emp.Count();
            Console.WriteLine($"The Total Number of Employee: {EmpCount}");

            Console.WriteLine("-----------------------------------------------");
            //5. Display total number of employees belonging to “Chennai”
            var EmpChennai = emp.Where(e => e.City == "Chennai");
            foreach(var e in EmpChennai)
                Console.WriteLine($"The Employee who belongs to Chennai is : {e.FirstName}");

            Console.WriteLine("------------------------------------------------");
            //6. Display highest employee id from the list
            int HighID = emp.Max(e => e.EmployeeID);
            Console.WriteLine($"The Employee with Higest Employee ID: {HighID}");

            Console.WriteLine("------------------------------------------------");
            //7.Display total number of employee who have joined after 1 / 1 / 2015
            int empAfter = emp.Count(e => e.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"Number of Employee who joined after 1/1/2015: {empAfter}");

            Console.WriteLine("-------------------------------------------------------");
            //8.Display total number of employee whose designation is not “Associate”
            var notAss = emp.Count(e => e.Title != "Associate");
            Console.WriteLine($"The Total Number of Employee who is not Associate: {notAss}");
            Console.WriteLine("-------------------------------------------------------");

            //9.Display total number of employee based on City
            var EmpCity = emp.GroupBy(e => e.City).Select(g => new { City = g.Key, Count = g.Count() });
            foreach (var e in EmpCity)
                Console.WriteLine($"{e.City}:{e.Count}");
            Console.WriteLine("--------------------------------------------");

            //10. Display total number of employee based on city and title
            var empcityTit = emp.GroupBy(e => new { e.City, e.Title }).
                Select(g => new { City = g.Key.City, Title = g.Key.Title, Count = g.Count() });
            foreach (var e in empcityTit)
                Console.WriteLine($"{e.City}: {e.Title}: {e.Count}");
            Console.WriteLine("-------------------------------------------------------");

            //11. Display total number of employee who is youngest in the list

            //var YoungEmp = emp.OrderBy(e => e.DOB);
            //foreach (var e in YoungEmp)
            //    Console.WriteLine($"{e.FirstName} DOB:{e.DOB}");

            double Yongemp = emp.Min(e => (DateTime.Today - e.DOB).TotalDays);
            //Console.WriteLine(Yongestemp);
            var Yemp = emp.Where(e => (DateTime.Today - e.DOB).TotalDays == Yongemp);
            foreach (var e in Yemp)
            {
                Console.WriteLine($"Employee who is youngest in the list is :-> {e.FirstName}{e.LastName}");
                Console.WriteLine($"The Total of Employee is: {Yemp.Count()}");
            }
            Console.ReadLine();
        }
    }
}
