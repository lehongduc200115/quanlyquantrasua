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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            textBox1.Text = Helper.readtext("quanlynhanvien.txt");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f = new Form8();
            f.ShowDialog();
        }
    }
}
