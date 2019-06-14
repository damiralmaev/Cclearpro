using System;
using System.Windows.Forms;

//что я добавил

using System.IO;//для очистки
using System.Net;//Для проверки обновлений
using System.Diagnostics;//для процессов

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
            listBox1.Items.Clear();
        }

        //начать очистку

        private async void Btstart_Click(object sender, EventArgs e)
        {


            if (checkTemp.Checked == true)
            {
                try
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
                catch (Exception ex)
                {
                    listBox1.Items.Add($"Ошибка при очистки папки Temp: {ex.Message}");
                }

                //await Task.Run(() =>
                //{ });

                string[] filess = Directory.GetDirectories(@"C:\Windows\Temp");

                try
                {
                    foreach (string name in filess)
                    {
                        try
                        {
                            Directory.Delete(name, true);
                        }
                        catch
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add($"Ошибка при очистки папки Temp: {ex.Message}");
                }
            }

            if (checkDown.Checked == true)
            {
                string[] filess = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\Downloads");

                try
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
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add($"Ошибка при очистки папки Downloads: {ex.Message}");
                }

                string[] filesss = Directory.GetDirectories($"C:\\Users\\{Environment.UserName}\\Downloads");

                try
                {
                    foreach (string name in filesss)
                    {
                        try
                        {
                            Directory.Delete(name, true);
                        }
                        catch
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add($"Ошибка при очистки папки Downloads: {ex.Message}");
                }
            }

            if (checkAppData.Checked == true)
            {
                try
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
                catch (Exception ex)
                {
                    listBox1.Items.Add($"Ошибка при очистки папки AppData: {ex.Message}");
                }

                string[] filessss = Directory.GetDirectories($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Temp");

                try
                {
                    foreach (string name in filessss)
                    {
                        try
                        {
                            Directory.Delete(name, true);
                        }
                        catch
                        {

                        }
                    }
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add($"Ошибка при очистки папки AppData: {ex.Message}");
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
                catch (Exception ex)
                {
                    listBox1.Items.Add($"Ошибка при очистки папки Chrome: {ex.Message}");
                }
                try
                {

                    string[] filessss = Directory.GetDirectories($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache");

                    foreach (string name in filessss)
                    {
                        Directory.Delete(name, true);
                    }
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add($"Ошибка при очистки папки Chrome: {ex.Message}");
                }
            }

            listBox1.Items.Add("Лучший канал - Клан [SOR]");
            listBox1.Items.Add("https://www.youtube.com/channel/UC_ZGV3eMzk8MF4Gp8nkh23g");

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

            try
            {
                string[] files = Directory.GetFiles(@"C:\Windows\Temp");

                foreach (string name in files)
                {
                    FileInfo f = new FileInfo(name);
                    temp = (temp + f.Length);
                }

                label1.Text = ($"Всего весит {temp} байт");
            }
            catch
            {
                label1.Text = "Ошибка вычесление";
            }

            try
            {
                string[] filess = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\Downloads");

                foreach (string name in filess)
                {
                    FileInfo f = new FileInfo(name);
                    Down = Down + f.Length;
                }

                label2.Text = ($"Всего весит {Down} байт");
            }
            catch
            {
                label2.Text = "Ошибка вычесление";
            }

            try
            {

                string[] filesss = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\AppData\\Local\\Temp");

                foreach (string name in filesss)
                {
                    FileInfo f = new FileInfo(name);
                    app = app + f.Length;
                }

                label3.Text = ($"Всего весит {app} байт");
            }
            catch
            {
                label3.Text = "Ошибка вычесление";
            }

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
            MessageBox.Show("Автор программы: Дамир Алмаев Маратович. Спонсор - Дима Петров Версия программа 1.3", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Обновление программа

        private void ОбновлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uri l = new Uri("https://raw.githubusercontent.com/damiralmaev/Cclearpro/master/Cclearpro%20-%20Clearing/bin/Debug/Cclearpro.exe");
            try
            {
                string var = "";
                WebClient web = new WebClient();
                var = web.DownloadString("https://raw.githubusercontent.com/damiralmaev/Cclearpro/master/ver.txt");

                if (Application.ProductVersion != var)
                {
                    DialogResult lol = MessageBox.Show("Есть обновление! Обновить?", "Cclearpro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (lol == DialogResult.Yes)
                    {
                        web.DownloadFileAsync(l, $@"C:\Users\{Environment.UserName}\Desktop\Ccleapronew.exe");
                        MessageBox.Show($@"Загружено! По пути C:\Users\{Environment.UserName}\Desktop\Ccleapronew.exe", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Последняя версия!", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show($"Ошибка сети: {ex.Message}", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //мусор

        private void CheckTemp_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Что делать если есть ошибка

        private void ЧтоДелатьЕслиОшибкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Напиши-те на эл. почту или на дискорд Gladi#8400", "Cclearpro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //мусор
    }
}
