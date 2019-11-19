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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tongsotien = Helper.readtext2("tongtien.txt");
            //List<string> tongsotien = new list<string> { Helper.readtext2("thanhtoan.txt") };        
            MessageBox.Show("Tong doanh thu: " + tongsotien + "\n","Tổng doanh thu");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 f = new Form13();
            this.Hide();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Helper.readtext("phanhoi.txt"), "Phản hồi khách hàng");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            this.Hide();
            f.ShowDialog();
                
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Form11 f = new Form11();
            this.Hide();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Helper.readtext("quanlynhanvien.txt"),"Quản Lý Nhân Viên");
            //Form12 f = new Form12();
            //this.Hide();
            //f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
        }
    }
}
