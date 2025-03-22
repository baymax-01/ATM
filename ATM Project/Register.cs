using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Configuration;
using System.Data.SqlClient;

namespace ATM_Project
{
    [Serializable]
    public partial class Register : Form
    {
        //public String Name, AccNo, Pin, CPin;
        AccountCreator ac = new AccountCreator();
        IFormatter objBinaryFormatter = new BinaryFormatter();
        public String filenm;
        

        //private string _filePath = "C:\\WinFormSerializeLog.txt";
        
        public Register()
        {
            InitializeComponent();
            //this.Name = NameTxt.Text;
            //this.AccNo = AccountTxt.Text;
            //this.Pin = NewPinTxt.Text;
            //this.CPin = ConfirmPinTxt.Text;
            
        }
        private Login mainForm = null;
        public Register(Form callingForm)
        {
            mainForm = callingForm as Login;
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MR. BHATTI\SOURCE\REPOS\ATM PROJECT\ATM PROJECT\BIN\DEBUG\ATMMACHINEDB.MDF;Integrated Security=True;Connect Timeout=30");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mr. Bhatti\Documents\ATM1DB.mdf;Integrated Security=True;Connect Timeout=30");        //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Mr. Bhatti\source\repos\ATM Project\ATM Project\bin\Debug\ATMmachineDB.mdf1; Integrated Security = True; Connect Timeout = 30");
        private void RegisterBtn_Click_1(object sender, EventArgs e)
        {
            int balance = 0;
            if(AccountTxt.Text=="" || NameTxt.Text=="" || PhoneTxt.Text == "" || AddressTxt.Text == "" || NameTxt.Text == "" || PinTxt.Text == "" || CpinTxt.Text == "" || OccupationTxt.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else if (PinTxt.Text != CpinTxt.Text)
            {
                MessageBox.Show("PIN and ConfirmPin does not Match!");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into AccountTable values('" + AccountTxt.Text + "','" + NameTxt.Text + "','" + DobTxt.Value.Date + "','" + PhoneTxt.Text + "','" + AddressTxt.Text + "','" + OccupationTxt.SelectedItem.ToString() + "','" + PinTxt.Text + "'," + balance + ")";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult result = MessageBox.Show("Account Successfully Created! Would you like to Login?","Success",MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        //Login main = new Login();
                        //this.Hide();
                        //main.Show();

                        Login main = new Login();
                        Form callingform2 = main;

                        TransactionLoading tl = new TransactionLoading(this, callingform2);
                        tl.Show();
                    }
                    else if(result == DialogResult.No)
                    {
                        System.Windows.Forms.Application.Exit();
                    }
                    
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            //else
            //{
            //    MessageBox.Show("Pin & ConfirmPin Does not Match!");
            //}

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ExitSplash exit = new ExitSplash(this);
            exit.Show();
        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
