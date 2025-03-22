using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private Login mainForm = null;
        public MainMenu(Form callingForm)
        {
            mainForm = callingForm as Login;
            InitializeComponent();
        }

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Login login = new Login(this);
        //    login.Show();
            
        //}
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            
            //Login login = new Login();
            //login.Show();
            //this.Hide();
            Login main = new Login();
            Form callingform2 = main;

            ExitSplash exit = new ExitSplash(this, callingform2) ;
            exit.Show();

        }
        private void StatementBtn_Load(object sender, EventArgs e)
        {
            this.Hide();
            Statement statement = new Statement(this);
            statement.Show();
        }

        private void CashTransferBtn_Click(object sender, EventArgs e)
        {

            //CashTransfer cashTransfer = new CashTransfer();
            //cashTransfer.Show();
            //this.Hide();
            CashTransfer main = new CashTransfer();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();

        }

        private void CashDepositBtn_Click(object sender, EventArgs e)
        {

            //CashDeposit cashdeposit = new CashDeposit();
            //cashdeposit.Show();
            //this.Hide();
            CashDeposit main = new CashDeposit();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();

        }

        private void FastCashBtn_Click(object sender, EventArgs e)
        {
            FastCash main = new FastCash();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();
            //FastCash fastcash = new FastCash();
            //fastcash.Show();
            //this.Hide();
        }

        private void CashWithdrawalBtn_Click(object sender, EventArgs e)
        {

            //CashWithdrawal cashwithdraw = new CashWithdrawal();
            //cashwithdraw.Show();
            //this.Hide();
            CashWithdrawal main = new CashWithdrawal();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();

        }
        private void ChangePinBtn_Click(object sender, EventArgs e)
        {

            //ChangePin changepin = new ChangePin();
            //changepin.Show();
            //this.Hide();
            ChangePin main = new ChangePin();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();

        }
        public static String AccountNum;
        private void BalanceInquiryBtn_Click(object sender, EventArgs e)
        {

            //BalanceInquiry balance = new BalanceInquiry();
            //balance.Show();
            //this.Hide();
            BalanceInquiry main = new BalanceInquiry();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();

        }

        private void StatementBtn_Click(object sender, EventArgs e)
        {
            //Statement st=new Statement();
            //st.Show();
            //this.Hide();
            Statement main = new Statement();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
