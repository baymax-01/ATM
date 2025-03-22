namespace ATM_Project
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FastCashBtn = new System.Windows.Forms.Button();
            this.CashDepositBtn = new System.Windows.Forms.Button();
            this.CashWithdrawalBtn = new System.Windows.Forms.Button();
            this.BalanceInquiryBtn = new System.Windows.Forms.Button();
            this.CashTransferBtn = new System.Windows.Forms.Button();
            this.StatementBtn = new System.Windows.Forms.Button();
            this.ChangePinBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.AccNumLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox2.Location = new System.Drawing.Point(0, 435);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(802, 16);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FastCashBtn
            // 
            this.FastCashBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.FastCashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FastCashBtn.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FastCashBtn.ForeColor = System.Drawing.Color.Transparent;
            this.FastCashBtn.Location = new System.Drawing.Point(61, 133);
            this.FastCashBtn.Name = "FastCashBtn";
            this.FastCashBtn.Size = new System.Drawing.Size(285, 57);
            this.FastCashBtn.TabIndex = 3;
            this.FastCashBtn.Text = "FAST CASH";
            this.FastCashBtn.UseVisualStyleBackColor = false;
            this.FastCashBtn.Click += new System.EventHandler(this.FastCashBtn_Click);
            // 
            // CashDepositBtn
            // 
            this.CashDepositBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CashDepositBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CashDepositBtn.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CashDepositBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CashDepositBtn.Location = new System.Drawing.Point(61, 205);
            this.CashDepositBtn.Name = "CashDepositBtn";
            this.CashDepositBtn.Size = new System.Drawing.Size(285, 57);
            this.CashDepositBtn.TabIndex = 4;
            this.CashDepositBtn.Text = "CASH DEPOSIT";
            this.CashDepositBtn.UseVisualStyleBackColor = false;
            this.CashDepositBtn.Click += new System.EventHandler(this.CashDepositBtn_Click);
            // 
            // CashWithdrawalBtn
            // 
            this.CashWithdrawalBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CashWithdrawalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CashWithdrawalBtn.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CashWithdrawalBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CashWithdrawalBtn.Location = new System.Drawing.Point(61, 277);
            this.CashWithdrawalBtn.Name = "CashWithdrawalBtn";
            this.CashWithdrawalBtn.Size = new System.Drawing.Size(285, 57);
            this.CashWithdrawalBtn.TabIndex = 5;
            this.CashWithdrawalBtn.Text = "CASH WITHDRAWAL";
            this.CashWithdrawalBtn.UseVisualStyleBackColor = false;
            this.CashWithdrawalBtn.Click += new System.EventHandler(this.CashWithdrawalBtn_Click);
            // 
            // BalanceInquiryBtn
            // 
            this.BalanceInquiryBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BalanceInquiryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BalanceInquiryBtn.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BalanceInquiryBtn.ForeColor = System.Drawing.Color.Transparent;
            this.BalanceInquiryBtn.Location = new System.Drawing.Point(462, 277);
            this.BalanceInquiryBtn.Name = "BalanceInquiryBtn";
            this.BalanceInquiryBtn.Size = new System.Drawing.Size(285, 57);
            this.BalanceInquiryBtn.TabIndex = 6;
            this.BalanceInquiryBtn.Text = "BALANCE INQUIRY";
            this.BalanceInquiryBtn.UseVisualStyleBackColor = false;
            this.BalanceInquiryBtn.Click += new System.EventHandler(this.BalanceInquiryBtn_Click);
            // 
            // CashTransferBtn
            // 
            this.CashTransferBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CashTransferBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CashTransferBtn.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CashTransferBtn.ForeColor = System.Drawing.Color.Transparent;
            this.CashTransferBtn.Location = new System.Drawing.Point(61, 349);
            this.CashTransferBtn.Name = "CashTransferBtn";
            this.CashTransferBtn.Size = new System.Drawing.Size(285, 57);
            this.CashTransferBtn.TabIndex = 7;
            this.CashTransferBtn.Text = "CASH TRANSFER";
            this.CashTransferBtn.UseVisualStyleBackColor = false;
            this.CashTransferBtn.Click += new System.EventHandler(this.CashTransferBtn_Click);
            // 
            // StatementBtn
            // 
            this.StatementBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.StatementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StatementBtn.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatementBtn.ForeColor = System.Drawing.Color.Transparent;
            this.StatementBtn.Location = new System.Drawing.Point(462, 205);
            this.StatementBtn.Name = "StatementBtn";
            this.StatementBtn.Size = new System.Drawing.Size(285, 57);
            this.StatementBtn.TabIndex = 8;
            this.StatementBtn.Text = "STATEMENT";
            this.StatementBtn.UseVisualStyleBackColor = false;
            this.StatementBtn.Click += new System.EventHandler(this.StatementBtn_Click);
            // 
            // ChangePinBtn
            // 
            this.ChangePinBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ChangePinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangePinBtn.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangePinBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ChangePinBtn.Location = new System.Drawing.Point(462, 133);
            this.ChangePinBtn.Name = "ChangePinBtn";
            this.ChangePinBtn.Size = new System.Drawing.Size(285, 57);
            this.ChangePinBtn.TabIndex = 9;
            this.ChangePinBtn.Text = "CHANGE PIN";
            this.ChangePinBtn.UseVisualStyleBackColor = false;
            this.ChangePinBtn.Click += new System.EventHandler(this.ChangePinBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutBtn.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogoutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.Location = new System.Drawing.Point(462, 349);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(285, 57);
            this.LogoutBtn.TabIndex = 10;
            this.LogoutBtn.Text = "LOGOUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // AccNumLbl
            // 
            this.AccNumLbl.AutoSize = true;
            this.AccNumLbl.BackColor = System.Drawing.Color.White;
            this.AccNumLbl.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccNumLbl.ForeColor = System.Drawing.Color.Black;
            this.AccNumLbl.Location = new System.Drawing.Point(420, 86);
            this.AccNumLbl.Name = "AccNumLbl";
            this.AccNumLbl.Size = new System.Drawing.Size(112, 30);
            this.AccNumLbl.TabIndex = 12;
            this.AccNumLbl.Text = "AccNum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(203, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Account Number : ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccNumLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ChangePinBtn);
            this.Controls.Add(this.StatementBtn);
            this.Controls.Add(this.CashTransferBtn);
            this.Controls.Add(this.BalanceInquiryBtn);
            this.Controls.Add(this.CashWithdrawalBtn);
            this.Controls.Add(this.CashDepositBtn);
            this.Controls.Add(this.FastCashBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            AccNumLbl.Text = Login.AccountNum;
            AccountNum = Login.AccountNum;
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button FastCashBtn;
        private Button CashDepositBtn;
        private Button CashWithdrawalBtn;
        private Button BalanceInquiryBtn;
        private Button CashTransferBtn;
        private Button StatementBtn;
        private Button ChangePinBtn;
        private Button LogoutBtn;
        private Label AccNumLbl;
        private Label label2;
    }
}