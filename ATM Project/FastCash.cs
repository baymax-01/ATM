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
    public partial class FastCash : Form
    {
        DateTime dt = new DateTime();
        public FastCash()
        {
            InitializeComponent();
        }
        private void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
            dt = DateTime.Now;
        }

        private void Cash500Btn_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Balance can not be Negative!");
            }
            else
            {
                int newbalance = bal - 500;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newbalance + "where AccountNumber = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Amount Withdrawn Successfully!");
                    con.Close();
                    addtransaction1();
                    //MainMenu mainMenu = new MainMenu();
                    //mainMenu.Show();
                    //this.Hide();
                    Loading();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Cash20000Btn_Click(object sender, EventArgs e)
        {
            if (bal < 20000)
            {
                MessageBox.Show("Balance can not be Negative!");
            }
            else
            {
                int newbalance = bal - 20000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newbalance + "where AccountNumber = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Amount Withdrawn Successfully!");
                    con.Close();
                    addtransaction6();
                    //MainMenu mainMenu = new MainMenu();
                    //mainMenu.Show();
                    //this.Hide();
                    Loading();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Cash25000Btn_Click(object sender, EventArgs e)
        {
            if (bal < 25000)
            {
                MessageBox.Show("Balance can not be Negative!");
            }
            else
            {
                int newbalance = bal - 25000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newbalance + "where AccountNumber = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Amount Withdrawn Successfully!");
                    con.Close();
                    addtransaction7();
                    //MainMenu mainMenu = new MainMenu();
                    //mainMenu.Show();
                    //this.Hide();
                    Loading();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void GobackBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //MainMenu mm = new MainMenu(this);
            //mm.Show();
            MainMenu main = new MainMenu();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();
        }
        int bal;
        String Acc = Login.AccountNum;
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
        
        private void addtransaction1()
        {
            string TrType = "Debit";
            try
            {
                con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TrType + "'," + 500 + ",'" + dt + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Successfully Created!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void addtransaction2()
        {
            string TrType = "Debit";
            try
            {
                con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TrType + "'," + 1000 + ",'" + dt + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Successfully Created!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void addtransaction3()
        {
            string TrType = "Debit";
            try
            {
                con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TrType + "'," + 2000 + ",'" + dt + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Successfully Created!");
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void addtransaction4()
        {
            string TrType = "Debit";
            try
            {
                con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TrType + "'," + 5000 + ",'" + dt + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Successfully Created!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void addtransaction5()
        {
            string TrType = "Debit";
            try
            {
                con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TrType + "'," + 10000 + ",'" + dt + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Successfully Created!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void addtransaction6()
        {
            string TrType = "Debit";
            try
            {
                con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TrType + "'," + 20000 + ",'" + dt + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Successfully Created!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void addtransaction7()
        {
            string TrType = "Debit";
            try
            {
                con.Open();
                string query = "insert into TransactionTable values('" + Acc + "','" + TrType + "'," + 25000 + ",'" + dt + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Successfully Created!");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void Cash1000Btn_Click_1(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Balance can not be Negative!");
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newbalance + "where AccountNumber = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Amount Withdrawn Successfully!");
                    con.Close();
                    addtransaction2();
                    //MainMenu mainMenu = new MainMenu();
                    //mainMenu.Show();
                    //this.Hide();
                    Loading();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Cash2000Btn_Click_1(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Balance can not be Negative!");
            }
            else
            {
                int newbalance = bal - 2000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newbalance + "where AccountNumber = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Amount Withdrawn Successfully!");
                    con.Close();
                    addtransaction3();
                    //MainMenu mainMenu = new MainMenu();
                    //mainMenu.Show();
                    //this.Hide();
                    Loading();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Cash5000Btn_Click_1(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Balance can not be Negative!");
            }
            else
            {
                int newbalance = bal - 5000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newbalance + "where AccountNumber = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Amount Withdrawn Successfully!");
                    con.Close();
                    addtransaction4();
                    //MainMenu mainMenu = new MainMenu();
                    //mainMenu.Show();
                    //this.Hide();
                    Loading();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Cash10000Btn_Click_1(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("Balance can not be Negative!");
            }
            else
            {
                int newbalance = bal - 10000;
                try
                {
                    con.Open();
                    string query = "update AccountTable set Balance = " + newbalance + "where AccountNumber = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Amount Withdrawn Successfully!");
                    con.Close();
                    addtransaction5();
                    //MainMenu mainMenu = new MainMenu();
                    //mainMenu.Show();
                    //this.Hide();
                    Loading();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public void Loading()
        {
            DialogResult result = MessageBox.Show("Amount Withdrawn Successfully! Would you like to perform another Transaction?", "Success", MessageBoxButtons.YesNo);
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

        private void FastCash_Load_1(object sender, EventArgs e)
        {
            getBalance();
            dt = DateTime.Now;
        }
    }
}
