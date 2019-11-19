using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Vui lòng nhập lại thông tin để được tích điểm");
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3.tenkhachhang = "others";
            this.Hide();

            Form5 f = new Form5();
            f.ShowDialog();
        }
    }
}
