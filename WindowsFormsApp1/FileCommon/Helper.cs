using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.FileCommon
{
    public static class Helper
    {
        public static string CreateFolder(string path)
        {
            // If the directory doesn't exist, create it.
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }
        public static void Membershipconfirmation()
        {
            var result = MessageBox.Show("Have you been a membership?", "More detail", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("please enter your name and your phone number");
                Form3 f = new Form3();
                f.ShowDialog();
            }
            else
            {
                Form4 f = new Form4();
                f.ShowDialog();
            }
        }
        public static int locso(string a)
        {
            string chuoiso;
            chuoiso = "0";
            int i = 1;
            int length = a.Length;

            for (int j = 1; j < (a.Length); j = j + 1)
            {
                if (Char.IsDigit(a[j]))
                {
                    chuoiso += a[j];

                }
            }
            i = int.Parse(chuoiso);

            return i;

        }
        public static string readtext(string path)
        {
            string text = string.Empty;

            String[] Lines;
            Lines = File.ReadAllLines(path);
            for (int i = 0; i < Lines.Length - 1; i++)
            {
                text += Lines[i] + "\n";
            }
            text += Lines[Lines.Length - 1];
            Console.ReadLine();



            return text;
        }
        public static string writetext(string path, List<string> details)
        {
            //using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            //{
            // Keep existing attributes, and set ReadOnly attribute.

            //File.SetAttributes(path, FileAttributes.Normal);
            //var test = HasWritePermissionOnDir(path);

            using (StreamWriter sw = new StreamWriter(path))
            {

                foreach (string s in details)
                {
                    sw.WriteLine(s);
                }
            }
            return path;
            //Console.ReadKey();
            //}

        }


        public static string writeonfile(string duongdantenkhachhang, string sdt_khach, string ten_khach, List<string> details)
        {

            //Create folder and its file tẽt
            var path = Helper.CreateFolder(Constants.orderBillPath + duongdantenkhachhang + DateTime.UtcNow.AddHours(7).ToShortDateString().Replace("/", "_"))  ;
            var newfile = File.CreateText(path+"/" +sdt_khach + "_" + ten_khach + ".txt");
            newfile.Close();
            string path2 = path + "/" + sdt_khach + "_" + ten_khach + ".txt";



            //Write on file in that folder
            using (StreamWriter sw = new StreamWriter(path2))
            {

                foreach (string s in details)
                {
                    sw.WriteLine(s);
                }
            }
            //  Console.ReadKey();
            // public override void Close();

            return path2;

        }
        public static string readtext2(string path)
        {
            string text = string.Empty;

            String[] Lines;
            Lines = File.ReadAllLines(path);
            //for (int i = 0; i < Lines.Length - 1; i++)
            //{
            //    text += Lines[i];
            //}
            return Lines[0];
            // public override void Close(string duongdan);




        }
        public static Boolean Checkstaff(string Username, string Password)
        {
            bool check = false;
            String[] Lines;
            Lines = File.ReadAllLines("staff.txt");
            for (int i = 0; i < (Lines.Length)/3; i++)
            {
                if (Username == Lines[3*i] && Password == Lines[3*i+1])
                {
                    //staffname = Lines[2 * i + 2];
                    check = true;
                }
            }
            return check;
        
        }
        public static string Checkstaffname(string Username, string Password)
        {
            //bool check = false;
            string staffname = string.Empty;
            String[] Lines;
            Lines = File.ReadAllLines("staff.txt");
            for (int i = 0; i < ((Lines.Length )/3); i++)
            {
                if (Username == Lines[3 * i] && Password == Lines[3 * i + 1])
                {
                    //check = true
                    staffname = Lines[3 * i + 2];
                }
            }
            return staffname;
        }
            public static string kiemtrattontai(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            
            return path;
        }
        public static int checkexisten(string path)
        {
            int counterr = 0;
            string pathhh = string.Empty;
            for (int i = 0; i < 9; i++)
            {
                pathhh = path+ i + ".txt";
            if (File.Exists(pathhh))

                counterr++;
           
        }
            return counterr;
        }
       

    }
}
