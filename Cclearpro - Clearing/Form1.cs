using System;
using System.Windows.Forms;

//что я добавил

using System.IO;//для очистки
using System.Diagnostics;//для процессов
using System.Threading.Tasks;

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

        private async void Btstart_Click(object sender, EventArgs e)
        {
            if (checkTemp.Checked == true)
            {
                string[] files = Directory.GetFiles(@"C:\Windows\Temp");

                await Task.Run(() =>
                {
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
                });

                await Task.Run(() =>
                { });

                string[] filess = Directory.GetDirectories(@"C:\Windows\Temp");

                await Task.Run(() =>
                {
                    foreach (string name in filess)
                    {
                        try
                        {
                            Directory.Delete(name);
                        }
                        catch
                        {

                        }
                    }
                });
            }

            if (checkDown.Checked == true)
            {
                string[] filess = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\Downloads");

                await Task.Run(() =>
                {
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
                });

                string[] filesss = Directory.GetDirectories($"C:\\Users\\{Environment.UserName}\\Downloads");

                await Task.Run(() =>
                {
                    foreach (string name in filesss)
                    {
                        try
                        {
                            Directory.Delete(name);
                        }
                        catch
                        {

                        }
                    }
                });
            }

            if (checkAppData.Checked == true)
            {
                string[] filesss = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Temp");

                await Task.Run(() =>
                {
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
                });

                string[] filessss = Directory.GetDirectories($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Temp");

                await Task.Run(() =>
                {
                    foreach (string name in filessss)
                    {
                        try
                        {
                            Directory.Delete(name);
                        }
                        catch
                        {

                        }
                    }
                });
            }

            if (checkChomre.Checked == true)
            {
                await Task.Run(() =>
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
                });
                try
                {

                    string[] filessss = Directory.GetDirectories($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache");

                    foreach (string name in filessss)
                    {
                        Directory.Delete(name);
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
                temp = (temp + f.Length);
            }

            label1.Text = ($"Всего весит {temp / 1024} байт");

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


        //нажата ли кнопка

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //обновление

            if (e.KeyCode == Keys.F5)
                bates();

            //информация

            if (e.KeyCode == Keys.F1)
                MessageBox.Show("Автор программы: Дамир Алмаев Маратович. Версия программа 1.1", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Полная очистка

            if (e.KeyCode == Keys.F2)
            {
                checkChomre.Checked = true;
                checkTemp.Checked = true;
                checkDown.Checked = true;
                checkAppData.Checked = true;
                btstart.PerformClick();
            }

            //убрать все галочки

            if (e.KeyCode == Keys.F3)
            {
                checkChomre.Checked = false;
                checkTemp.Checked = false;
                checkDown.Checked = false;
                checkAppData.Checked = false;
            }

            //ставит все галочки

            if (e.KeyCode == Keys.F4)
            {
                checkChomre.Checked = true;
                checkTemp.Checked = true;
                checkDown.Checked = true;
                checkAppData.Checked = true;
            }

            //наш сайт

            if (e.KeyCode == Keys.F6)
            {
                Process.Start("https://damiralmaev.github.io/");
            }

            //что делает кнопка? (это бесполезно)

            if (e.KeyCode == Keys.F7)
            {
                MessageBox.Show("ГОРЯЧИЕ КЛАВИШЫ. F1 - Обновить вес всех компонетах. F2 - Полная очистка. F3 - Убрать все галочки. F4 - Ставит все галочки. F5 - Информация. F6 - Открыть наш сайт. F7 - Что делает это кнопка?", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //верния меню

        private void ОПрограммеИАвторахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы: Дамир Алмаев Маратович. Версия программа 1.1", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ПолнаяОчисткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkChomre.Checked = true;
            checkTemp.Checked = true;
            checkDown.Checked = true;
            checkAppData.Checked = true;
            btstart.PerformClick();
        }

        private void ОбновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bates();
        }

        private void УбратьВсеГалочкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkChomre.Checked = false;
            checkTemp.Checked = false;
            checkDown.Checked = false;
            checkAppData.Checked = false;
        }

        private void ЧтоДелаетКнопкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ГОРЯЧИЕ КЛАВИШЫ. F1 - Обновить вес всех компонетах. F2 - Полная очистка. F3 - Убрать все галочки. F4 - Ставит все галочки. F5 - Информация. F6 - Открыть наш сайт. F7 - Что делает это кнопка?", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void НашСайтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://damiralmaev.github.io/");
        }

        private void ПолнаяОчисткатолькоСтавитГалочкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkChomre.Checked = true;
            checkTemp.Checked = true;
            checkDown.Checked = true;
            checkAppData.Checked = true;
        }

        //системные утилиты

        //редактор реестра

        private void РедакторРеестраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("regedit");
        }

        //Диспечер задач

        private void ДиспечерЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr");
        }

        //Командная строка

        private void КоманднаяСтрокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd");
        }
    }
}
