using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
namespace ATM_Project
{
    public partial class Login : Form
    {
        public String Pin, AccNo;
        public String Fileinf;
        private String Acc;
        public Login()
        {
            InitializeComponent();
           
        }
        private void label1_CLick(object sender, EventArgs e)
        {
            
        }
        private void label2_CLick(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AccNo = AccountNumberTxt.Text;
            ChangePin cp = new ChangePin();
           // cp.filename = AccountNumberTxt.Text;
            //string filenm = AccountNumber.Text.ToString();
            //string filePt = @"C:\Users\Mr. Bhatti\source\repos\ATM Project\ATM Project\bin\Debug\net6.0-windows\Accounts\";
        }
        //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Mr. Bhatti\source\repos\ATM Project\ATM Project\bin\Debug\ATMmachineDB.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MR. BHATTI\SOURCE\REPOS\ATM PROJECT\ATM PROJECT\BIN\DEBUG\ATMMACHINEDB.MDF;Integrated Security=True;Connect Timeout=30");

        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Mr.Bhatti\source\repos\ATM Project\ATM Project\obj\bin\Debug\ATMmachineDB.mdf;Integrated Security=True;Connect Timeout=30");
        public static String AccountNum;
        
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            AccountNum = AccountNumberTxt.Text;
            con.Open();
            String query = "select count(*) from AccountTable where AccountNumber = '" +AccountNumberTxt.Text +"' and Pin = '" + PinTxt.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MainMenu main = new MainMenu();
                Form callingform2 = main;

                TransactionLoading tl = new TransactionLoading(this, callingform2);
                tl.Show();
                //MainMenu main=new MainMenu();
                //main.Show();
                //this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Account Number or PIN!");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExitSplash exit=new ExitSplash(this);
            //this.Hide();
            exit.Show();
            //exit.Display();
            
        }

        private void PIN_TextChanged(object sender, EventArgs e)
        {
            this.Pin = PinTxt.Text;
        }
        private MainMenu mainForm = null;

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Register register = new Register(this);

            //register.Show();
            //this.Hide();
            Register main = new Register();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();
        }

        public Login(Form callingForm)
        {
            mainForm = callingForm as MainMenu;
            InitializeComponent();
        }
    }
}