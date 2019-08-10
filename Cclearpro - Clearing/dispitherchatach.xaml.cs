using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

//Что я добавил

using System.Diagnostics;//для процессто
using System.Threading;//для потоков

namespace CclearPro
{
    /// <summary>
    /// Логика взаимодействия для dispitherchatach.xaml
    /// </summary>
    public partial class dispitherchatach : Window
    {
        //переменные

        public Process[] process;//процессы
        public long i;//для сцета новый процессов
        
        public dispitherchatach()
        {
            InitializeComponent();
            Thread h = new Thread(new ThreadStart(update));
            h.Start();
        }

        private void Btkillprocess_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = "";
                name = lsprocess.SelectedItem.ToString();

                ProcessKiller.Proces.Kill(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Описание ошибки: " + ex.Message, this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void update()
        {
            while (true)
            {
                Task.Delay(10).Wait();
                process = Process.GetProcesses();
                if (process.Length > i || process.Length < i)
                {
                    this.Dispatcher.Invoke(new Action(() => lsprocess.Items.Clear()));
                    foreach (Process name in process)
                    {
                        this.Dispatcher.Invoke(new Action(() => lsprocess.Items.Add(name.ProcessName)));
                    }

                    i = process.Length;
                }
            }
        }
    }
}
