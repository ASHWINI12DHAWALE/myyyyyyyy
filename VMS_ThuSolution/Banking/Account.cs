using System;
using Constitution;
using Policy;
namespace Banking
{
    public class Account:IAccountingService
    {
        //according to Policy Operation  
        //We are defining two event

        public event Operation UnderBalance;
        public event Operation OverBalance;


        private double balance;
        double IAccountingService.Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double amount)
        {

            balance = balance + amount;
            Monitor();
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
            Monitor();
        }

        public void Monitor()
        {
            if (balance >= 500000)
            {
                //raise event
                //trigger event
                OverBalance(this,5000);
            }
            else if (balance <= 10000)
            {
                UnderBalance(this,5000);
            }
        }
    }
}
