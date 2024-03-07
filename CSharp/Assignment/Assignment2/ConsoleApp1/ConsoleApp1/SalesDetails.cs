using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SalesDetails
    {
        int SalesNo;
        int ProductNo;
        double Price;
        string DateOfSale;
        int Qt;
        double TotalAmt;
        static void Main()
        {
            SalesDetails sd = new SalesDetails(102,352,34,3,"04-03-2024");
            sd.Sales();
            sd.ShowData();

            Console.Read();



        }
        SalesDetails(int SalesNo,int ProductNo,double Price,int Qt,string DateOfSale)  // Constructor
        {
            this.SalesNo = SalesNo;
            this.ProductNo = ProductNo;
            this.Price = Price;
            this.Qt = Qt;
            this.DateOfSale = DateOfSale;
        }
        public void Sales()
        {
            TotalAmt = Qt * Price;
        }
        public void ShowData()
        {
            Console.WriteLine($"Sales Number: {SalesNo}");
            Console.WriteLine($"Product Number: {ProductNo}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Date of Sale: : {DateOfSale}");
            Console.WriteLine($"Quantity: {Qt}");
            Console.WriteLine($"Total Amount: {TotalAmt}");
            
        }
    }
    
}
