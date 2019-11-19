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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public static string  tensanpham = string.Empty;
        public static string giatien = string.Empty;
        public static string linkhinhanh = string.Empty;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // private static string[] a = Form6.listView1;

        //public static object A { get => a; set => a = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            tensanpham = textBox1.Text;
            giatien = textBox3.Text;
            linkhinhanh = textBox2.Text;
            string b = Helper.readtext("/dataforexercise/Drinklist1.txt");

            string a =Constants.endline + tensanpham + Constants.endline + giatien + Constants.endline + linkhinhanh;
            List<string> details = new List<string>{b+ a};
            Helper.writetext("/dataforexercise/Drinklist1.txt", details );

            // Form6.lsvShow.Items.Add("item1");
            // var listViewItem = new ListViewItem();
            // a.Items.Add(listViewItem);
            this.Hide();
            Form6 f = new Form6();
            f.Update();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fdlg.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            this.Hide();
            f.ShowDialog();
        }
    }
}
