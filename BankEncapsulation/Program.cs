using System;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank1 = new BankAccount();
            Console.WriteLine(bank1.GetBalance());

            bank1.Deposit(100);
            Console.WriteLine(bank1.GetBalance());

            bank1.Withdrawl(50);
            Console.WriteLine(bank1.GetBalance());
            
        }
    }
}
