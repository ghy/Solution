using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services
{
    public class AccountLogic
    {
        public static string GetName()
        {
            return "Henley";
        }

        private float minimumBalance = 10.00F;
        private float balance;

        public float MinimumBalance
        {
            get { return minimumBalance; }
        }

        public void Deposit(float amount)
        {
            balance += amount;
        }

        public void Withdraw(float amount)
        {
            balance -= amount;
        }

        public void TransferFunds(AccountLogic destination, float amount)
        {
            if (balance - amount < minimumBalance)
                throw new InsufficientFundsException();
            destination.Deposit(amount);

            Withdraw(amount);
        }

        public float Balance
        {
            get { return balance; }
        }
    }
}
