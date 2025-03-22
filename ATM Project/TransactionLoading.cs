namespace ATM_Project
{
    public partial class TransactionLoading : Form
    {
        public TransactionLoading()
        {
            InitializeComponent();
        }
        string mainForm = null;
        public Form secondaryform = null;
        public TransactionLoading(Form callingform, Form callingform2)
        {
            secondaryform = callingform2;
            mainForm = callingform.Text;
            InitializeComponent();
            callingform.Hide();
            Display();
            
            //timer1.Start();
            //for (int starting = 0; starting <= 100; starting += 4)
            //{
            //    MyProgress.Value = starting;
            //    ProgressPercent.Text = starting + " %";
            //    if (MyProgress.Value == 100)
            //    {
            //        MyProgress.Value = 0;
            //        timer1.Stop();
            //        this.Hide();
            //        callingform.Show();
            //    }
            //}

            //starting += 4;
            //MyProgress.Value = starting;
            //ProgressPercent.Text = "" + starting;
            //if (MyProgress.Value == 100)
            //{
            //    MyProgress.Value = 0;
            //    timer1.Stop();
            //    this.Hide();
            //    callingform.Show();
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressPercent_Click(object sender, EventArgs e)
        {

        }
        int starting = 0;
        public void timer1_Tick(object sender, EventArgs e)
        {
            starting += 5;
            MyProgress.Value = starting;
            ProgressPercent.Text = starting + " %";
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                this.Hide();
                secondaryform.Show();
            }
        }
        private void Display()
        {
            
            timer1.Start();
        }
        private void TransactionLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
