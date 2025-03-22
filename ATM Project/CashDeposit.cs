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
    public partial class CashDeposit : Form
    {
        public CashDeposit()
        {

            dt = DateTime.Now;
            //dt = DateTime.;
            InitializeComponent();
        }
        private MainMenu mainForm = null;
        public CashDeposit(Form callingForm)
        {
            mainForm = callingForm as MainMenu;
            InitializeComponent();
        }
        DateTime dt = new DateTime();
        
        private void addtransaction()
        {
            
            string TrType = "Credit";       
            try
            {
                con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TrType + "'," + DepositamountTxt.Text + ",'"+ dt + "')";
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MainMenu mm = new MainMenu(this);
            //mm.Show();
            MainMenu main = new MainMenu();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MR. BHATTI\SOURCE\REPOS\ATM PROJECT\ATM PROJECT\BIN\DEBUG\ATMMACHINEDB.MDF;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccountNum;

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if(DepositamountTxt.Text == "" || Convert.ToInt32(DepositamountTxt.Text) <=0)
            {
                MessageBox.Show("Enter Correct Amount!");
            }
            else
            {
                newbalance = oldbalance + Convert.ToInt32(DepositamountTxt.Text);
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = "+newbalance+"where AccountNumber = '"+ Acc +"'";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Amount Deposited Successfully!");
                    con.Close();
                    addtransaction();
                    //MainMenu mainMenu = new MainMenu();
                    //mainMenu.Show();
                    //this.Hide();
                    DialogResult result = MessageBox.Show("Amount Deposited Successfully! Would you like to perform another Transaction?", "Success", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //Login main = new Login();
                        //this.Hide();
                        //main.Show();

                        MainMenu main = new MainMenu();
                        Form callingform2 = main;

                        TransactionLoading tl = new TransactionLoading(this, callingform2);
                        tl.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        ExitSplash exit = new ExitSplash(this);
                        exit.Show();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int oldbalance,newbalance;
        private void getBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTable where AccountNumber = '" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void CashDeposit_Load(object sender, EventArgs e)
        {
            getBalance();
        }
    }
}
