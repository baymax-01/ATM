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
    public partial class CashTransfer : Form
    {
        DateTime dt = new DateTime();
        public CashTransfer()
        {
            InitializeComponent();
        }
        private MainMenu mainForm = null;
        public CashTransfer(Form callingForm)
        {
            mainForm = callingForm as MainMenu;
            InitializeComponent();
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
        int bal, recbal;
        

        int newbalance, oldbalance;
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (TransferAmountTxt.Text == "" || RecAccTxt.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else if (Convert.ToInt32(TransferAmountTxt.Text) <= 0)
            {
                MessageBox.Show("Enter Valid Amount!");
            }
            else if (Convert.ToInt32(TransferAmountTxt.Text) > bal)
            {
                MessageBox.Show("Balance can not be Negative!");
            }
            else if (Convert.ToInt32(TransferAmountTxt.Text) < bal && Convert.ToInt32(TransferAmountTxt.Text) > 0 && (TransferAmountTxt.Text != "" && RecAccTxt.Text != ""))
            {

                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTable where AccountNumber = '" + RecAccTxt.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    //AvlBalanceLbl.Text = "Rs " + dt.Rows[0][0].ToString();
                    recbal = Convert.ToInt32(dt.Rows[0][0].ToString());
                    con.Close();
                    newbalance = recbal + Convert.ToInt32(TransferAmountTxt.Text);
                    try
                    {
                        con.Open();
                        string query = "update AccountTable set Balance = " + newbalance + "where AccountNumber = '" + RecAccTxt.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        addtransactionrec();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (FileNotFoundException fex)
                {
                    MessageBox.Show("Account Does not Exist, Therfore amount cannot be transferred!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                try
                {
                    getBalance();
                    newbalance = bal - Convert.ToInt32(TransferAmountTxt.Text);
                    try
                    {
                        con.Open();
                        string query = "update AccountTable set Balance = " + newbalance + "where AccountNumber = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show("Amount Tranferred Successfully!");
                        con.Close();
                        addtransactionsend();
                        //MainMenu mainMenu = new MainMenu();
                        //mainMenu.Show();
                        //this.Hide();
                        DialogResult result = MessageBox.Show("Amount Transferred Successfully! Would you like to perform another Transaction?", "Success", MessageBoxButtons.YesNo);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CashTransfer_Load(object sender, EventArgs e)
        {
            getBalance();
            dt = DateTime.Now;
        }

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
        private void addtransactionrec()
        {

            string TrType = "Credit";
            try
            {
                con.Open();
                string query = "insert into TransactionTable values('" + RecAccTxt.Text + "','" + TrType + "'," + TransferAmountTxt.Text + ",'" + dt + "')";
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
        private void addtransactionsend()
        {
            string TrType = "Debit";
            try
            {
                con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TrType + "'," + TransferAmountTxt.Text + ",'" + dt + "')";
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
    }
}
