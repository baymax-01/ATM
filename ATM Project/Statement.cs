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
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }
        private MainMenu mainForm = null;
        public Statement(Form callingForm)
        {
            mainForm = callingForm as MainMenu;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\MR. BHATTI\SOURCE\REPOS\ATM PROJECT\ATM PROJECT\BIN\DEBUG\ATMMACHINEDB.MDF;Integrated Security=True;Connect Timeout=30");
        String Acc = Login.AccountNum;
        private void Populate()
        {
            con.Open();
            string query = "select * from TransactionTable where AccountNumber = '" + Acc + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Datagrid.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Statement_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void BackLbl_Click(object sender, EventArgs e)
        {
            //MainMenu mm = new MainMenu();
            //mm.Show();
            //this.Hide();
            MainMenu main = new MainMenu();
            Form callingform2 = main;

            TransactionLoading tl = new TransactionLoading(this, callingform2);
            tl.Show();

        }

        private void Datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
