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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lusername_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public static string staffname = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            //string printbill = "Thoi gian: " + DateTime.UtcNow + Constants.endline + fDrinklist.sanPhamBuill + Constants.endline + "So tien tich luy: " + fDrinklist.sum + "->Diem tich luy: " + Constants.endline + fDrinklist.sumMoney;
            ////Helper.CreateFolder(Form3.textBox1);
            //var arrayPrintBill = new List<string>
            //{
            //    printbill,
            //};
            //var path = Helper.writeonfile("091232323", "leee", arrayPrintBill);




            //Helper.writetext(path, arrayPrintBill);
           
            string username = tbUsername.Text;
            string password = tbpassword.Text;
            bool a = Helper.Checkstaff(username, password);
            if (a == true)
            {
                string loichao1 = "You are now login as staff ";
                staffname = Helper.Checkstaffname(username, password);
                MessageBox.Show(loichao1+ "\nWelcome "+ staffname);
                string textt = Helper.readtext("quanlynhanvien.txt");
                List<string> newstaffname = new List<string> { textt+"\n" +staffname+":\n Bat dau lam viec: " + DateTime.Now+"\n Ket thuc:" };
                Helper.writetext("quanlynhanvien.txt", newstaffname);
                Form6 f = new Form6();
                this.Hide();
                f.ShowDialog();



            }
            else
            {   
                if (username == "ticklabcoffee" && password == "ticklabcoffee")
                {
                    string loichao2 = "You are now login as admin ";
                    MessageBox.Show(loichao2 + "\nWelcome ticklabcoffee");
                    Form8 f = new Form8();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                MessageBox.Show("I am sorry, your username and password are incorrect");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
