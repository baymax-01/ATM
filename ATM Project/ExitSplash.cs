using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Project
{
    public partial class ExitSplash : Form
    {
        public ExitSplash()
        {
            InitializeComponent();
        }
        string mainForm = null;
        string mainForm1 = null;
        public Form secondaryform = null;
        public ExitSplash(Form callingform, Form callingform2)
        {
            secondaryform = callingform2;
            mainForm1 = callingform.Text;
            InitializeComponent();
            callingform.Hide();
            Display();
        }
        
        public ExitSplash(Form callingform)
        {
            //secondaryform = callingform2;
            mainForm = callingform.Text;
            InitializeComponent();
            callingform.Hide();
            Display();
        }
            int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 2;
            MyProgress.Value = starting;
            ProgressPercent.Text = starting + " %";
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                if (secondaryform == null)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    this.Hide();
                    secondaryform.Show();
                }
                //this.Hide();
                //secondaryform.Show();
            }
        }
        public void Display()
        {

            timer1.Start();
        }
        private void ExitSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
