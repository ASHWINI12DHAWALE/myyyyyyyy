using System;

namespace BOL{

    namespace HR
    {
       public  sealed class SalesManager : Manager
        {
            private int bonus;
            public SalesManager() { }
            public SalesManager(string fname, string lname, DateTime birthdate,
                            string dept, DateTime jnDate, int bsal,
                            int da, int hra, int pf,
                            int id, int shares, int bonus) : base()
            {

                this.bonus = bonus;
            }

            public override double ComputePay()
            {
                return base.ComputePay() + bonus;
            }

            public override string ToString()
            {
                return base.ToString() + bonus;
            }
        }
    }

}