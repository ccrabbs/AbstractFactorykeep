using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class AbstractFactoryForm : Form
    {
        public AbstractFactoryForm()
        {
            InitializeComponent();
        }

        private void ButtonTestLoan_Click(object sender, EventArgs e)
        {
            BankInfo binfo = new BankInfo
            {
                FirstName = "Bill",
                LastName = "Baker",
                CheckingAccountNum = 12345,
                LoanAccountNum = 12345,
                BankName = "CITY BANK"
            };

            List<BankInfo> BList = new List<BankInfo> { binfo };

            LoanFactory lf = new LoanFactoryUS(); // set of factories

            IBalanceCheck ib = lf.CreateBalanceCheck();
            double bal = ib.GetCurrentBalance(BList);

            ICreditCheck ic = lf.CreateCreditCheck();

            int creditScore = ic.GetCreditScore("Bill", "Baker", 111223333);

            const double loanAmountAsked = 10000;

            if ((bal > .20 * loanAmountAsked) && (creditScore > 600))
            {
                MessageBox.Show("Loan Approved..");
            }
            else
            {
                MessageBox.Show("Loan Denied" +
                   "/nBalances = " + bal.ToString() + "Credit Score = " + creditScore.ToString());
            }
        }
    }
}