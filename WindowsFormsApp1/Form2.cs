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
    public partial class fDrinklist : Form
    {
        public fDrinklist()
        {
            InitializeComponent();
        }
    
        public static int sum = 0;

        public static string sanPhamBuill = string.Empty;
        public static int sumMoney = 0;
       
       
        
       
        void Readtext(int a)
        {
            
            String[] Lines;
            Lines = File.ReadAllLines(@"E:\dataforexercise\Drinklist1.txt");
            for (int i=0; i<Lines.Length; i++)
            {
                Console.WriteLine();
            }
           
            Console.ReadLine();


            txbtrasua.Text += String.Concat(Lines[2*a-2]);
            txbtrasua.Text  +="\r\n";
            txbtrasua.Text += String.Concat(Lines[2*a-1]);
            txbtrasua.Text += "\r\n";
            sum += Helper.locso(Lines[2 * a - 1]);

        }
       
      


        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void trasua_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Readtext(3);
        }

        private void lbtrasuatruyenthong_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Readtext(1);
            
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Readtext(2);
            
            

        }

        private void txbtrasua_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {



            
            txbthanhtoan.Text = (sum.ToString());
            sanPhamBuill = txbtrasua.Text ;
            sumMoney += int.Parse(txbthanhtoan.Text);
            Helper.Membershipconfirmation();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Readtext(4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Readtext(5);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Readtext(6);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Readtext(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Readtext(8);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Readtext(9);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Readtext(10);
        }

        private void txbdelete_Click(object sender, EventArgs e)
        {
            sum = 0;
            txbtrasua.Text = null;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        
    }
}
