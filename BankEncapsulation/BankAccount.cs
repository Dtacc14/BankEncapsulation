using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public double Deposit(double x)
        {
            return _balance += x;
        }

        public double Withdrawl(double x)
        {
            return _balance -= x;
        }

        public string GetBalance()
        {
            return $"You have ${_balance} in your account.";
        }
    }
}
