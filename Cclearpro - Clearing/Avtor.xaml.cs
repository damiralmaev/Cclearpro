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

namespace CclearPro
{
    /// <summary>
    /// Логика взаимодействия для Avtor.xaml
    /// </summary>
    public partial class Avtor : Window
    {
        public Avtor()
        {
            InitializeComponent();
        }

        private void Btsclose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }
    }
}
