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
    public partial class BalanceInquiry : Form
    {
        public BalanceInquiry()
        {
            InitializeComponent();
        }
        private MainMenu mainForm = null;
        public BalanceInquiry(Form callingForm)
        {
            mainForm = callingForm as MainMenu;
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MR. BHATTI\SOURCE\REPOS\ATM PROJECT\ATM PROJECT\BIN\DEBUG\ATMMACHINEDB.MDF;Integrated Security=True;Connect Timeout=30");
        private void getBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTable where AccountNumber = '" + AccNumLbl.Text + "'",con);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            BalanceLbl.Text = "Rs "+dt.Rows[0][0].ToString();
            con.Close();
        }
        private void BalanceInquiry_Load(object sender, EventArgs e)
        {
            AccNumLbl.Text = MainMenu.AccountNum;
            getBalance();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MainMenu mm = new MainMenu(this);
            //mm.Show();
            MainMenu main = new MainMenu();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();
        }
    }
}
