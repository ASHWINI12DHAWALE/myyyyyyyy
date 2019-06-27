using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
   public  class ContractEmployee:WageEmployee
    {
        public double MonthlyBonus
        {
            get;set;
        }

        public new  virtual double ComputePay()  //Shadowing 
        {
            return HoursWorked * RatePerHour + MonthlyBonus;
        }
    }
}
