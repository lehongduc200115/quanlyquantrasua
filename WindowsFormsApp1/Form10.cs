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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> sodienthoai= new List<string>();
            List<string> money = new List<string>();
            string text = string.Empty;

            String[] Lines;
            Lines = File.ReadAllLines("customers.txt");
            for (int i = 0; i < 5; i++)
            {
                sodienthoai.Add(Lines[i]);
                money.Add(Helper.readtext2("E:\\thanhtoan\\tongtien" + sodienthoai[i] + ".txt"));

            }
           // money.Add("tongtien"+sodienthoai[1])
           

            for (int i = 0; i < 5; i++)
            {
                this.chart1.Series["Series1"].Points.AddXY(sodienthoai[i], int.Parse(money[i])/1000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            this.Hide();
            f.ShowDialog();
        }
    }
}
