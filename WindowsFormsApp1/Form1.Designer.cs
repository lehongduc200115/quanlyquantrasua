namespace WindowsFormsApp1
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bLogin = new System.Windows.Forms.Button();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.lpassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lusername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bLogin);
            this.panel1.Controls.Add(this.tbpassword);
            this.panel1.Controls.Add(this.lpassword);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 198);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.Maroon;
            this.bLogin.ForeColor = System.Drawing.SystemColors.Info;
            this.bLogin.Location = new System.Drawing.Point(184, 139);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(104, 45);
            this.bLogin.TabIndex = 3;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(129, 96);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(318, 22);
            this.tbpassword.TabIndex = 2;
            this.tbpassword.UseSystemPasswordChar = true;
            this.tbpassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lpassword
            // 
            this.lpassword.AutoSize = true;
            this.lpassword.Font = new System.Drawing.Font(".VnArial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpassword.Location = new System.Drawing.Point(19, 93);
            this.lpassword.Name = "lpassword";
            this.lpassword.Size = new System.Drawing.Size(104, 23);
            this.lpassword.TabIndex = 1;
            this.lpassword.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbUsername);
            this.panel2.Controls.Add(this.lusername);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 74);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(129, 26);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(318, 22);
            this.tbUsername.TabIndex = 1;
            // 
            // lusername
            // 
            this.lusername.AutoSize = true;
            this.lusername.Font = new System.Drawing.Font(".VnArial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lusername.Location = new System.Drawing.Point(17, 23);
            this.lusername.Name = "lusername";
            this.lusername.Size = new System.Drawing.Size(106, 23);
            this.lusername.TabIndex = 0;
            this.lusername.Text = "Username";
            this.lusername.Click += new System.EventHandler(this.lusername_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 208);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lusername;
        private System.Windows.Forms.Label lpassword;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button bLogin;
    }
}

