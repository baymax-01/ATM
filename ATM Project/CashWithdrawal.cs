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
    public partial class CashWithdrawal : Form
    {
        DateTime dt = new DateTime();
        public CashWithdrawal()
        {
            dt=DateTime.Now;
            InitializeComponent();
        }
        private MainMenu mainForm = null;
        public CashWithdrawal(Form callingForm)
        {
            mainForm = callingForm as MainMenu;
            InitializeComponent();
        }
        String Acc = Login.AccountNum;
        int bal;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MR. BHATTI\SOURCE\REPOS\ATM PROJECT\ATM PROJECT\BIN\DEBUG\ATMMACHINEDB.MDF;Integrated Security=True;Connect Timeout=30");
        private void getBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTable where AccountNumber = '" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AvlBalanceLbl.Text = "Rs " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }

        private void CashWithdrawal_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int oldbalance, newbalance;

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (WithdrawTxt.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else if (Convert.ToInt32(WithdrawTxt.Text) <= 0)
            {
                MessageBox.Show("Enter Valid Amount!");
            }
            else if (Convert.ToInt32(WithdrawTxt.Text) > bal)
            {
                MessageBox.Show("Balance can not be Negative!");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(WithdrawTxt.Text);
                    try
                    {
                        con.Open();
                        string query = "update AccountTable set Balance = " + newbalance + "where AccountNumber = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show("Amount Withdrawn Successfully!");
                        con.Close();
                        addtransaction();
                        //MainMenu mainMenu = new MainMenu();
                        //mainMenu.Show();
                        //this.Hide();
                        FastCash fc=new FastCash();
                        fc.Loading();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void addtransaction()
        {
            string TrType = "Debit";
            try
            {
                con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TrType + "'," + WithdrawTxt.Text + ",'" + dt + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Successfully Created!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void WithdrawTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
