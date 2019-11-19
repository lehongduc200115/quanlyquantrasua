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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Value.ToShortDateString().Replace("/","_");
            MessageBox.Show(Helper.readtext("order\\" + textBox1.Text+ "\\" + textBox2.Text+ "\\" + textBox1.Text+"___"+textBox3.Text+".txt"));
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            //Form8 f = new Form8();
            //this.Hide();
            //f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            this.Hide();
            f.ShowDialog();
        }
    }
}
