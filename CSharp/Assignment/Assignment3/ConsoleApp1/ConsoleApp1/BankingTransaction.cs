using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class InsufficientBalance : Exception   // Defining User-Defined->Application Exception
    {
        public InsufficientBalance(string msg)   // Constructor 
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
    class BankingTransaction
    {
        int Balance = 10000;
        public void  Deposit(int amt)
        {
            Balance=Balance + amt;
            Console.WriteLine($"You Amount is Deposited: {amt}");
        }
        public void Withdrawn(int amt)
        {
            if (amt > Balance)
                throw new InsufficientBalance($"Insufficient Balance");
            else
            {
                Balance = Balance - amt;
                Console.WriteLine($"Your Amount is Withdrawan: {amt}");
            }
        }
        public void CheckBalanace()
        {
            Console.WriteLine($"Your Remaning Balance: {Balance}");
        }
    }
}
