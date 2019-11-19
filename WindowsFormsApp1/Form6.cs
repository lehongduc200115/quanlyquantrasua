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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            textBox1.Text = Login.staffname;
            newlistview();
           // Refresh();
            
        }
        

        public static int sum = 0;

        public static string sanPhamBuill = string.Empty;
        public static int sumMoney = 0;

        public static int lengthoftext = 0;
        private int counting = 0;
        void Readtext(int a)
        {

            String[] Lines;
            Lines = File.ReadAllLines(@"E:\dataforexercise\Drinklist1.txt");
            for (int i = 0; i < Lines.Length; i++)
            {
                Console.WriteLine();
            }

            Console.ReadLine();

            txbtrasua.Text += "<" + counting + ">";
            txbtrasua.Text += String.Concat(Lines[3 * a]);
            txbtrasua.Text += "\r\n";
            txbtrasua.Text += String.Concat(Lines[3 * a + 1]);
            txbtrasua.Text += "\r\n";
            sum += Helper.locso(Lines[3 * a + 1]);

        }

        static List<string> lines = new List<string>();
        // public static string[] lines;
        public static void readtext(string path)
        {
            string text = string.Empty;


            string[] Lines;
            Lines = File.ReadAllLines(path);
            lengthoftext = Lines.Length;
            for (int i = 0; i < Lines.Length; i++)
            { lines.Add(Lines[i]); }


            Console.ReadLine();
        }
        void newlistview()
        {

            //ListView myListView = new ListView();   // Khai báo một ListView control.
            //myListView.Size = new System.Drawing.Size(700, 500);   // Kích thước hiển thị
            //this.Controls.Add(myListView);          // Add ListView control vừa khai báo vào Form
            myListView.View = View.LargeIcon;
            string path = "/dataforexercise/Drinklist1.txt";
            readtext(path);
            for (int n = 1; n <= (int)(lengthoftext / 3); n++)
            {
                imageList2.Images.Add(Image.FromFile(lines[3 * n - 1]));
                myListView.Items.Add(lines[3 * n - 3], n - 1);
            }
            myListView.LargeImageList = imageList2;
            myListView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            this.Hide();
            f.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbthanhtoan.Text = (sum.ToString());
            sanPhamBuill = txbtrasua.Text;
            sumMoney = int.Parse(txbthanhtoan.Text);
            // string path = tenkhachhang;
           
            MessageBox.Show("Tổng số tiền: " + txbthanhtoan.Text);
            this.Hide();
            Helper.Membershipconfirmation();


        }

        private void myListView_ItemActivate(object sender, EventArgs e)
        {
            counting += 1;
            int i = myListView.SelectedIndices[0];
            Readtext(i);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txbthanhtoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txbthanhtoan.Text = null;
            txbtrasua.Text = null;
            counting = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            List<string> newstaffname = new List<string> { Helper.readtext("quanlynhanvien.txt") + DateTime.Now +"\n"};
            Helper.writetext("quanlynhanvien.txt", newstaffname);
            this.Hide();
            f.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            this.Hide();
            f.ShowDialog();
        }
    }
}

