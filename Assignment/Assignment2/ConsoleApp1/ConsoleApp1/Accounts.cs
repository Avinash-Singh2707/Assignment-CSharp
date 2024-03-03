using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Accounts
    {
        string AccountNo;
        String CustomerName;
        String AccountType;
        char TransactionType;
        int Amount;
        int Balance;
        public Accounts()         // Default Constructor
        {
            Console.WriteLine("Enter Customer Name, Account No, Account Type, Transaction Type(D/W), Amount, Balance ");
            CustomerName = Console.ReadLine();
            AccountNo = Console.ReadLine();
            AccountType = Console.ReadLine();
            TransactionType = Convert.ToChar(Console.ReadLine());
            Amount = Convert.ToInt32(Console.ReadLine());
            Balance = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            
            Accounts ac = new Accounts();

            ac.Update();
            Console.WriteLine("------------Information After Transaction------------");
            ac.ShowData();
            Console.Read();

        }

        public void Credit(int amount)
        {
            Balance= Balance + amount;
        }
        public void Debit(int amount)
        {
            Balance= Balance - amount;
        }
        public void Update()
        {
            if (TransactionType == 'D' || TransactionType == 'd')
                Credit(Amount);
            else if(TransactionType == 'w' || TransactionType == 'W')
                Debit(Amount);
        }
        public void ShowData()
        {
            Console.WriteLine($"Custtomer Name {CustomerName}");
            Console.WriteLine($"Account Number {AccountNo}");
            Console.WriteLine($"Account Type {AccountType}");
            Console.WriteLine($"Transaction Type {TransactionType}");
            Console.WriteLine($"Amount {Amount}");
            Console.WriteLine($"Balance {Balance}");
        }

    }
}
