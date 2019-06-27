using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
  public   class WageEmployee : HR.Employee
    {
        public int HoursWorked { get; set; }
        public double RatePerHour { get; set; }

        public override double ComputePay()
        {
            return HoursWorked*RatePerHour;
        }
    }

}
