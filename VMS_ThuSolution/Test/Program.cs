using BOL;
using BOL.HR;
using System;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  Simple Polymorphism Demo
            /*
                        WageEmployee wEmp = new WageEmployee
                        {
                            FirstName = "Sarang",
                            LastName = "Sharma",
                            BirthDate = Convert.ToDateTime("2/6/1992"),
                            RatePerHour = 2000,
                            HoursWorked = 160

                        };
                        // double package = wEmp.ComputePay();
                        Employee emp = wEmp;
                        double package = emp.ComputePay();

                        Console.WriteLine("Package {0}", package);


                */
            #endregion

            ContractEmployee cEmp = new ContractEmployee
            {
                FirstName = "Sarang",
                LastName = "Sharma",
                BirthDate = Convert.ToDateTime("2/6/1992"),
                RatePerHour = 2000,
                HoursWorked = 160,
                MonthlyBonus = 10000
            };


            WageEmployee  emp = cEmp;

            double package = emp.ComputePay();


            Console.WriteLine("Package {0}", package);
            Console.ReadLine();
        }
    }
}
