using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Project
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();            
        }

        private void ChangePin_Load(object sender, EventArgs e)
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

        private void OldpinTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewpinTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmpinTxt_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MR. BHATTI\SOURCE\REPOS\ATM PROJECT\ATM PROJECT\BIN\DEBUG\ATMMACHINEDB.MDF;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccountNum;
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (NewpinTxt.Text == "" || ConfirmpinTxt.Text == "")
            {
                MessageBox.Show("Either PIN or Confirm PIN is Missing!");
            }else if(NewpinTxt.Text != ConfirmpinTxt.Text)
            {
                MessageBox.Show("PIN and Confirm PIN Does not match!");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update AccountTable set Pin = '" + NewpinTxt.Text + "' where AccountNumber = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("PIN changed Successfully!");
                    con.Close();

                    //Login lg = new Login();
                    //lg.Show();
                    //this.Hide();
                    DialogResult result = MessageBox.Show("PIN changed Successfully! Would you like to perform another Transaction?", "Success", MessageBoxButtons.YesNo);
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
                finally
                {
                    con.Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
