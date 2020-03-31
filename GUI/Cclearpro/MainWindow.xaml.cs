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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using Cclearpro.Other.Pages;
using Cclearpro.Other.Class;

namespace Cclearpro
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Прочее
        object page = null;//Страница

        private void CheckUpdate()
        {
            try
            {
                UpdateManager updatemng = new UpdateManager();

                if (updatemng.Check())
                {
                    MessageBoxResult result =
                        MessageBox.Show("Найдено новое обновление! Обновить?", "Cclearpro: Главное меню",
                        MessageBoxButton.YesNo, MessageBoxImage.Question);

                    if (result == MessageBoxResult.Yes)
                    {
                        //TODO: Добавить форму
                    }
                }
            }
            catch { }
        }
        
        //Основное
        public MainWindow()
        {
            InitializeComponent();

            //Загрузка страницы
            page = new MainMenuClear();
            frame.Navigate(page);

            //Поток для update
            Thread thread = new Thread(new ThreadStart(CheckUpdate));
            thread.IsBackground = true;
            thread.Start();
        }
    }
}
