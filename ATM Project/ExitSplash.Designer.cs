namespace ATM_Project
{
    partial class ExitSplash
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
            this.components = new System.ComponentModel.Container();
            this.ProgressPercent = new System.Windows.Forms.Label();
            this.MyProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ProgressPercent
            // 
            this.ProgressPercent.AutoSize = true;
            this.ProgressPercent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ProgressPercent.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgressPercent.ForeColor = System.Drawing.Color.White;
            this.ProgressPercent.Location = new System.Drawing.Point(186, 135);
            this.ProgressPercent.Name = "ProgressPercent";
            this.ProgressPercent.Size = new System.Drawing.Size(29, 26);
            this.ProgressPercent.TabIndex = 9;
            this.ProgressPercent.Text = "%";
            // 
            // MyProgress
            // 
            this.MyProgress.Location = new System.Drawing.Point(1, 164);
            this.MyProgress.Name = "MyProgress";
            this.MyProgress.Size = new System.Drawing.Size(391, 30);
            this.MyProgress.TabIndex = 8;
            this.MyProgress.Text = "guna2ProgressBar1";
            this.MyProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGGING OUT . . .";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExitSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(393, 173);
            this.Controls.Add(this.ProgressPercent);
            this.Controls.Add(this.MyProgress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExitSplash";
            this.Load += new System.EventHandler(this.ExitSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ProgressPercent;
        private Guna.UI2.WinForms.Guna2ProgressBar MyProgress;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}