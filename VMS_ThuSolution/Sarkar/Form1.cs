using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Constitution;
using Policy;

using Banking;
using Taxation;
using Subsidy;
namespace Sarkar
{
    public partial class Form1 : Form
    {
        //Declare reference for account object
        //IAccountingService iAcct = null;
        Account acct = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acct  = new Account();
            
            //Add event listeners to account object
            acct.OverBalance += new Operation(Tax.PayGST);
            acct.OverBalance += new Operation(Tax.PayIT);
            acct.OverBalance += Tax.PaySalesT;
            acct.UnderBalance += Welfare.AddAllowance;
            //event----------->event listener
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {   // MessageBox.Show("Deposit is called");

            double initialBalance = double.Parse(txtBalance.Text);
            double amount = double.Parse(txtAmount.Text);
            IAccountingService iAcct = acct;
            iAcct.Balance = initialBalance;
           
            //Invoke Account functionality
            acct.Deposit(amount);
            //Show Remaining Balance
            double remainingBalance = iAcct.Balance;
            this.label3.Text = remainingBalance.ToString();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {   // MessageBox.Show("Withdraw is called");

            double initialBalance = double.Parse(txtBalance.Text);
            double amount = double.Parse(txtAmount.Text);
            IAccountingService iAcct = acct;
            iAcct.Balance = initialBalance;

            //Invoke Account functionality
            acct.Withdraw(amount);

            //Show Remaining Balance
            double remainingBalance = iAcct.Balance;
            this.label3.Text = remainingBalance.ToString();
        }
    }
}
