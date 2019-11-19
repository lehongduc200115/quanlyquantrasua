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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "phanhoi.txt";
            string respone = Helper.readtext(path) + "("+DateTime.UtcNow.ToLocalTime()+") " + textBox1.Text+"."+Constants.endline;
            List<string> phanhoi = new List<string> { respone} ;
            Helper.writetext(path, phanhoi);

            MessageBox.Show("Cảm ơn vì phản hồi của bạn, điều đó giúp chúng tôi hoàn thiện hơn.");
            this.Hide();
            Form6 f = new Form6();
            f.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 g = new Form6();
            g.ShowDialog();
        }
    }
}
