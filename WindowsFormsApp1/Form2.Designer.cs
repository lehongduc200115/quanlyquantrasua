namespace WindowsFormsApp1
{
    partial class fDrinklist
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbdelete = new System.Windows.Forms.Button();
            this.txbthanhtoan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trasua = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbtrasuatruyenthong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbtrasua = new System.Windows.Forms.TextBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txbdelete);
            this.panel4.Controls.Add(this.txbthanhtoan);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txbtrasua);
            this.panel4.Location = new System.Drawing.Point(2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1486, 713);
            this.panel4.TabIndex = 0;
            this.panel4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1115, 642);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tien Khach Tra";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1254, 666);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 22);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1254, 638);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1254, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font(".VnArial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1098, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Typical Customer";
            // 
            // txbdelete
            // 
            this.txbdelete.Location = new System.Drawing.Point(1327, 64);
            this.txbdelete.Name = "txbdelete";
            this.txbdelete.Size = new System.Drawing.Size(148, 35);
            this.txbdelete.TabIndex = 6;
            this.txbdelete.Text = "Clear All";
            this.txbdelete.UseVisualStyleBackColor = true;
            this.txbdelete.Click += new System.EventHandler(this.txbdelete_Click);
            // 
            // txbthanhtoan
            // 
            this.txbthanhtoan.Location = new System.Drawing.Point(1254, 613);
            this.txbthanhtoan.Name = "txbthanhtoan";
            this.txbthanhtoan.Size = new System.Drawing.Size(204, 22);
            this.txbthanhtoan.TabIndex = 5;
            this.txbthanhtoan.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font(".VnArial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1101, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thanh Toan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.button11);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.trasua);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.lbtrasuatruyenthong);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1089, 710);
            this.panel5.TabIndex = 1;
            this.panel5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(20, 625);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(159, 51);
            this.button11.TabIndex = 19;
            this.button11.Text = "Trà sữa chanh leo";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(237, 624);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(159, 51);
            this.button10.TabIndex = 18;
            this.button10.Text = "Matcha trà xanh";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(442, 624);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 51);
            this.button9.TabIndex = 17;
            this.button9.Text = "Caramel machiato";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(639, 624);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(159, 51);
            this.button8.TabIndex = 16;
            this.button8.Text = "Hồng trà machiato";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(857, 624);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 51);
            this.button7.TabIndex = 15;
            this.button7.Text = "Trà sữa kem cheese";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.Image = global::WindowsFormsApp1.Properties.Resources.trà_vải_kem_cheese;
            this.label9.Location = new System.Drawing.Point(857, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 240);
            this.label9.TabIndex = 14;
            this.label9.Text = " ";
            // 
            // label8
            // 
            this.label8.Image = global::WindowsFormsApp1.Properties.Resources.hồng_trà_machiato;
            this.label8.Location = new System.Drawing.Point(639, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 240);
            this.label8.TabIndex = 13;
            this.label8.Text = " ";
            // 
            // label7
            // 
            this.label7.Image = global::WindowsFormsApp1.Properties.Resources.caramel_macchiato;
            this.label7.Location = new System.Drawing.Point(442, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 240);
            this.label7.TabIndex = 12;
            this.label7.Text = " ";
            // 
            // label6
            // 
            this.label6.Image = global::WindowsFormsApp1.Properties.Resources.matcha_tra_xanh_159x240;
            this.label6.Location = new System.Drawing.Point(237, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 240);
            this.label6.TabIndex = 11;
            this.label6.Text = " ";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(857, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 51);
            this.button6.TabIndex = 10;
            this.button6.Text = "Trà sữa cam";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(639, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 51);
            this.button5.TabIndex = 9;
            this.button5.Text = "Trà sữa dâu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(442, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "Trà sữa kiwi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.Image = global::WindowsFormsApp1.Properties.Resources.tsxoai;
            this.label5.Location = new System.Drawing.Point(857, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 240);
            this.label5.TabIndex = 7;
            this.label5.Text = " ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Image = global::WindowsFormsApp1.Properties.Resources.tskiwi;
            this.label4.Location = new System.Drawing.Point(442, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 240);
            this.label4.TabIndex = 6;
            this.label4.Text = " ";
            // 
            // label3
            // 
            this.label3.Image = global::WindowsFormsApp1.Properties.Resources.Tsdau;
            this.label3.Location = new System.Drawing.Point(639, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 240);
            this.label3.TabIndex = 5;
            this.label3.Text = ".";
            // 
            // trasua
            // 
            this.trasua.Image = global::WindowsFormsApp1.Properties.Resources.tschanhleo;
            this.trasua.Location = new System.Drawing.Point(20, 381);
            this.trasua.Name = "trasua";
            this.trasua.Size = new System.Drawing.Size(159, 240);
            this.trasua.TabIndex = 4;
            this.trasua.Text = " ";
            this.trasua.Click += new System.EventHandler(this.trasua_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Trà sữa thái xanh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.Image = global::WindowsFormsApp1.Properties.Resources.TsThaixanh;
            this.label2.Location = new System.Drawing.Point(237, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 240);
            this.label2.TabIndex = 2;
            this.label2.Text = ".";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Trà sữa truyền thống";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lbtrasuatruyenthong
            // 
            this.lbtrasuatruyenthong.ForeColor = System.Drawing.Color.Black;
            this.lbtrasuatruyenthong.Image = global::WindowsFormsApp1.Properties.Resources.TsTruyenthong;
            this.lbtrasuatruyenthong.Location = new System.Drawing.Point(17, 19);
            this.lbtrasuatruyenthong.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.lbtrasuatruyenthong.Name = "lbtrasuatruyenthong";
            this.lbtrasuatruyenthong.Size = new System.Drawing.Size(159, 240);
            this.lbtrasuatruyenthong.TabIndex = 0;
            this.lbtrasuatruyenthong.Text = " ";
            this.lbtrasuatruyenthong.UseWaitCursor = true;
            this.lbtrasuatruyenthong.Click += new System.EventHandler(this.lbtrasuatruyenthong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(".VnArial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1098, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bill";
            // 
            // txbtrasua
            // 
            this.txbtrasua.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbtrasua.Location = new System.Drawing.Point(1095, 103);
            this.txbtrasua.Multiline = true;
            this.txbtrasua.Name = "txbtrasua";
            this.txbtrasua.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txbtrasua.Size = new System.Drawing.Size(386, 479);
            this.txbtrasua.TabIndex = 2;
            this.txbtrasua.TextChanged += new System.EventHandler(this.txbtrasua_TextChanged);
            // 
            // fDrinklist
            // 
            this.ClientSize = new System.Drawing.Size(1487, 717);
            this.Controls.Add(this.panel4);
            this.Name = "fDrinklist";
            this.Text = "Drink List";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        /* private System.Windows.Forms.Panel panel1;
         private System.Windows.Forms.Panel panel2;
         private System.Windows.Forms.Panel panel3;
         private System.Windows.Forms.Button button1;
         private System.Windows.Forms.Label label1;*/
        private System.Windows.Forms.Label lbtrasuatruyenthong;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trasua;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.TextBox txbtrasua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txbthanhtoan;
        private System.Windows.Forms.Button txbdelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}