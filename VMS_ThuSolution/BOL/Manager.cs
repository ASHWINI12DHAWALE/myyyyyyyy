using System;
namespace BOL
{
    namespace HR
    {
       public  class Manager : Employee
        {
            private int shares;

            public int Shares
            {
                get { return shares; }
                set { shares = value; }
            }

            public Manager() { }
            public Manager(string fname, string lname, DateTime birthdate,
                            string dept, DateTime jnDate, int bsal,
                            int da, int hra, int pf,
                            int id, int shares
                            ) : base(fname, lname, birthdate, dept, jnDate, bsal, da, hra, pf, id)
            {
                this.shares = shares;
            }


            public override double ComputePay()
            {
                double earnningPerShare = 0.2;
                double result;
                result = base.ComputePay() + shares * earnningPerShare;
                return result;

            }

            public override string ToString()
            {
                return base.ToString() + " " + shares;
            }
        }
    }
}