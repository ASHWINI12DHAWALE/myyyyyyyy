using System;
using Constitution;
namespace Subsidy
{
    public class Welfare
    {

        public static void AddAllowance(IAccountingService acct,double amount)
        {
            acct.Balance += amount;
        }
    }
}
