using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp1.FileCommon;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        public static string tenkhachhang = null;
        public static string sodienthoai = null;
        public static int diemtichluy = 0;


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Helper.Membershipconfirmation();
            
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            tenkhachhang = textBox1.Text;
            sodienthoai = textBox2.Text;
            
            string newtext = Helper.readtext("customers.txt");
            if ((newtext).Contains(tenkhachhang)==false)
                {
                List<string> customers = new List<string> { newtext + tenkhachhang + "\n" };
                Helper.writetext("customers.txt", customers);
            }
            
            string path1 = "tongtien.txt";
            //FileStream fs = File.Create(path1);
            int newmoney = Form6.sumMoney + int.Parse(Helper.readtext2(path1));
            List <string> tongtienn = new List<string> { newmoney.ToString() };
            Helper.writetext(path1, tongtienn);
            string path2 = "/thanhtoan/tongtien" + tenkhachhang + ".txt";
            if (File.Exists(path2))
            {
                int newmoney2 = Form6.sumMoney + int.Parse(Helper.readtext2(path2));
                FileStream fs = File.Create(path2);
                fs.Close();
                File.WriteAllText(path2, "0");
                fs.Close();

                File.WriteAllText(path2, newmoney2.ToString());

                fs.Close();
            }
            else
            {
                FileStream fs = File.Create(path2);
                fs.Close();
                File.WriteAllText(path2, Form6.sumMoney.ToString());
                fs.Close();
            }

            //    int newmoney2 = Form6.sumMoney + int.Parse(Helper.readtext2(path2));
            //List<string> tongtiennn = new List<string> { newmoney2.ToString() };
            //using (StreamWriter sw = new StreamWriter(path2))
            //{
               
            //    foreach (string s in tongtiennn)
            //    {
            //        sw.WriteLine(s);
            //    }
            //}
            diemtichluy = int.Parse(Helper.readtext2(path2)) / 1000;
            if ( diemtichluy <= 100)
            {
                MessageBox.Show("Điểm tích lũy của bạn: "+diemtichluy+"\n"+"Bạn là thành viên thông thường\n"+"Chưa đủ điều kiện để nhận ưu đãi");
            }
            else
            {
                MessageBox.Show("Điểm tích lũy của bạn: " + diemtichluy + "\n" + "Bạn là thành viên VIP\n" + "Được hưởng 10% ưu đãi");
            }
            //System.IO.File.WriteAllLines(path1, tongtienn);

            // Helper.CreateFolder(path);
            this.Hide();
            Form5 f = new Form5();
            f.ShowDialog();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
