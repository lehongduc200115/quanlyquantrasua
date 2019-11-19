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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static string tenkhachhang = Form3.tenkhachhang;
        string sodienthoai = Form3.sodienthoai;
        static string khongcogi = string.Empty;
        public static string checker = "0";
        public int counter = 0;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int phantram = 0;
            if (Form3.diemtichluy > 100)
            {
                phantram = 10;
            }
            string pathh = "/thanhtoan/tongtien" + tenkhachhang + ".txt";
            int canhan = int.Parse(Helper.readtext2(pathh));
            int thuctra = Form6.sum * (100 - phantram) / 100;
            string printbill = "TICKLAB COFFEE"+"."+Constants.endline+"Thoi gian: " + DateTime.Now+"." + Constants.endline + Constants.trangtri+"." +Form6.sanPhamBuill +"."+ Constants.endline + "So tien tich luy: " + Form6.sumMoney + "->Diem tich luy: "+ Form6.sumMoney / 1000 +"."+ Constants.endline+"Giảm giá thành viên:"+phantram+"%."+Constants.endline+"Số tiền thực trả:"+thuctra+"."+Constants.endline +"You spent " +canhan+"d at Ticklab Coffee"+"." +Constants.endline+"Cam on va hen gap lai" + "." + Constants.endline+ Constants.trangtri ;
            //Helper.CreateFolder(Form3.textBox1);
            var arrayPrintBill = new List<string>
            {
                printbill,
            };
            string duongdantenkhachhang =   tenkhachhang + "/";
            var path = Helper.writeonfile(duongdantenkhachhang, tenkhachhang,  "__" + Helper.checkexisten(@"E://users//lenovo//documents//visual studio 2017//ProjectTicklab//WindowsFormsApp1//WindowsFormsApp1//bin//Debug//" + "order/" + duongdantenkhachhang + DateTime.UtcNow.AddHours(7).ToShortDateString().Replace("/", "_") + "/" + tenkhachhang + "___"), arrayPrintBill);

           
            //In text vao file .txt cua khach hang
            //Helper.writetext(path, arrayPrintBill);
            //Hien Bill tren textbox
            textBox1.Text = Helper.readtext(path).Replace(".", Constants.endline);
            //checker = null;
            Form6.sum = 0;

            DialogResult dr = MessageBox.Show("Your bill was printed successfully!\n Do you want to leave respone? ","Thank you!", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Form9 f = new Form9();
                    this.Hide();
                    f.ShowDialog();
                    break;
                case DialogResult.No:
                    this.Hide();
                    Form6 g = new Form6();
                    g.ShowDialog();
                    break;
            }
            this.Hide();


        }
    }
}
