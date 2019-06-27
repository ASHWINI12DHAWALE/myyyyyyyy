using System;
using Constitution;
namespace Taxation
{
    public class Tax
    {
        //every  Tax handler should match input parameter
        //and out parameter syntax with delegate syntax

        public static void PaySalesT(IAccountingService acct, double amount)
        {
            acct.Balance -= amount;

        }
        public static void PayIT(IAccountingService acct, double amount)
        {
            acct.Balance -= amount;
        }


        public static void PayGST(IAccountingService acct, double amount)
        {
            acct.Balance -= amount;
        }


    }



}
