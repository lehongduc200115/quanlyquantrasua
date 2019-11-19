using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FileCommon;

namespace WindowsFormsApp1
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string text;
            //List<string> tendangnhap = new List<string> {"\n"+ textBox1.Text+"\n" };
            //List<string> matkhau = new List<string> { "\n" + textBox2.Text + "\n" };
            //List<string> ten = new List<string> { "\n" + textBox3.Text + "\n" };
            // text = Helper.readtext("staff.txt");
            // List<string> text = new List<string> { Helper.readtext("staff.txt") };
            string tendangnhap = "\n"+ textBox1.Text + "\n";
            string matkhau =textBox2.Text + "\n";
            string ten =  textBox3.Text ;
            string text = Helper.readtext("staff.txt");
            List<string> giatri = new List<string> { text + tendangnhap + matkhau +ten };
            Helper.writetext("staff.txt", giatri);
            //Helper.writetext("staff.txt", matkhau);
            //Helper.writetext("staff.txt", ten);
            this.Hide();
            Form8 f = new Form8();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f = new Form8();
            f.ShowDialog();
        }
    }
}
