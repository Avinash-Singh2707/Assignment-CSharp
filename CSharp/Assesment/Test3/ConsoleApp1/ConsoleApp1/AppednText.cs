using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AppednText
    {
        string filePath = "Example.txt";
        public static void WriteData()
        {
            FileStream fs = new FileStream("filePath", FileMode.Append,
                FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine("Enter a String :");

            string str = Console.ReadLine();
            sw.Write(str);
            sw.Close();
            fs.Close();

        }

    }
}
