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

using System.Diagnostics;//для процессов

namespace CclearPro
{
    /// <summary>
    /// Логика взаимодействия для ytilites.xaml
    /// </summary>
    public partial class ytilites : Window
    {
        public ytilites()
        {
            InitializeComponent();
        }

        private void Btdispithers_Click(object sender, RoutedEventArgs e)//Диспечер задач
        {
            dispitherchatach l = new dispitherchatach();
            l.Show();
        }

        private void Btsystemmonutor_Click(object sender, RoutedEventArgs e)//системный монитор
        {
            Process.Start("perfmon");
        }

        private void Btinternet_Click(object sender, RoutedEventArgs e)//свойство интернета
        {
            Process.Start("inetcpl.cpl");
        }

        private void Btsystemgood_Click(object sender, RoutedEventArgs e)//сведение о системы
        {
            try
            {
                Process.Start("msinfo32");
            }
            catch
            {
                Process.Start("msinfo64");
            }
        }

        private void Btlooksovetets_Click(object sender, RoutedEventArgs e)//просмотр событий
        {
            Process.Start("eventvwr");
        }

        private void Btsystemswindows_Click(object sender, RoutedEventArgs e)//Версия Windows
        {
            Process.Start("winver");
        }
    }
}
