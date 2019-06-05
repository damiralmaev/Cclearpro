using System;
//что я добавил

using System.IO;//для очистки
using System.Windows.Forms;

namespace Cclearpro___Clearing
{
    public partial class Form1 : Form
    {

        //переменные

        //сколько весит

        public static double temp = 0;//сколько весит папка temp
        public static double Down = 0;//сколько весит папка загрузки
        public static double app = 0;//сколько весит папка appdata
        public static double chomer = 0;//сколько весит кеш chmore

        public Form1()
        {
            InitializeComponent();
        }

        //при загрузки формы

        private void Form1_Load(object sender, EventArgs e)
        {
            bates();
        }

        //начать очистку

        private void Btstart_Click(object sender, EventArgs e)
        {
            if (checkTemp.Checked == true)
            {
                string[] files = Directory.GetFiles(@"C:\Windows\Temp");

                foreach (string name in files)
                {
                    try
                    {
                        File.Delete(name);
                    }
                    catch
                    {

                    }
                }
            }

            if (checkDown.Checked == true)
            {
                string[] filess = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\Downloads");

                foreach (string name in filess)
                {
                    try
                    {
                        File.Delete(name);
                    }
                    catch
                    {

                    }
                }
            }

            if (checkAppData.Checked == true)
            {
                string[] filesss = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Temp");

                foreach (string name in filesss)
                {
                    try
                    {
                        File.Delete(name);
                    }
                    catch
                    {

                    }
                }
            }

            if (checkChomre.Checked == true)
            {
                try
                {

                    string[] filessss = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache");

                    foreach (string name in filessss)
                    {
                        File.Delete(name);
                    }
                }
                catch
                {

                }
            }

            bates();
            MessageBox.Show("Очистка выполнена", "Cclearpro - Clearing", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //узнать сколько весит все папки

        public void bates()
        {
            //узнаём сколько весит

            temp = 0;
            Down = 0;
            app = 0;
            chomer = 0;

            string[] files = Directory.GetFiles(@"C:\Windows\Temp");

            foreach (string name in files)
            {
                FileInfo f = new FileInfo(name);
                temp = temp + f.Length;
            }

            label1.Text = ($"Всего весит {temp} байт");

            string[] filess = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\Downloads");

            foreach (string name in filess)
            {
                FileInfo f = new FileInfo(name);
                Down = Down + f.Length;
            }

            label2.Text = ($"Всего весит {Down} байт");

            string[] filesss = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Temp");

            foreach (string name in filesss)
            {
                FileInfo f = new FileInfo(name);
                app = app + f.Length;
            }

            label3.Text = ($"Всего весит {app} байт");

            try
            {

                string[] filessss = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache");

                foreach (string name in filessss)
                {
                    FileInfo f = new FileInfo(name);
                    chomer = chomer + f.Length;
                }

                label4.Text = ($"Всего весит {chomer} байт");
            }
            catch
            {
                label4.Text = ($"Нет браузера");
            }
        }
    }
}
