using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        int RollNo;
        String Name;
        String Clas;
        int Semester;
        String Branch;
        int[] Marks = new int[5];
        int sum,i= 0;
        int avg;

        static void Main()
        {
            Student st = new Student(1,"Avi","Btech",4,"CSE");
            st.InputData();
            st.Average();
            //st.Result();  
            st.DisplayResult();
            Console.Read();

        }

        public Student(int RollNo,String Name,String Clas,int Semester,String Branch)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Clas = Clas;
            this.Semester = Semester;
            this.Branch = Branch;
        }
        public void InputData()
        {
            Console.WriteLine("Enter the marks of five subject: ");
            for(int i=0;i<5;i++)
            {
                Marks[i] = Convert.ToInt32(Console.ReadLine());
                if (Marks[i] < 35)
                {
                    Console.Write("Failed");
                    return;
                }
            }
        }
        public void Average()
        {
            
            for(int i=0;i<5;i++)
            {
                sum = sum + Marks[i];
            }
            avg = sum / 5;
        }
        public void Result()
        {
            if (avg < 50)
                Console.WriteLine("Failed");
            else if (avg > 50)
                Console.WriteLine("Passed");

        }
        public void DisplayResult()
        {
            Console.WriteLine($"Roll Number: {RollNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Class: {Clas}");
            Console.WriteLine($"Semester: {Semester}");
            Console.WriteLine($"Brnach: {Branch}");
            Console.WriteLine("---------------Marks------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Marks of Subject {i}: {Marks[i]}");
            }
            Console.WriteLine(":::RESULT:::");
            Result();
        }


    }
    


}
