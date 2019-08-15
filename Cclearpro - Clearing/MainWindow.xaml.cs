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

//Что я подключил

using System.IO;//для управлениями файломи
using System.Threading;//Для потоков
using System.Diagnostics;//для процессов
using System.Net;//для обновлений

namespace CclearPro
{

    public partial class MainWindow : Window
    {
        //переменные

        //для очистки

        public long error = 0;//считает сколько ошибок
        public long vsero = 0;//все чего надо удалить

        public string[] temps;//файлы которое надо удалить
        public string[] tempss;//папки корое надо удалить
        public string[] AppDatas;//файлы
        public string[] AppDatass;//папки
        public string[] Chromes;//файлы
        public string[] Chromess;//папки
        public string[] Firefoxs;//файлы
        public string[] Firefoxss;//папки
        public string[] Exploirers;//файлы
        public string[] Exploirerss;//папки
        public string[] Downs;//файлы
        public string[] Downss;//папки

        public bool IsClose = true;//можно закрыть программу (это при очистке)

        public bool ClearAppdata = false;//Очистка
        public bool ClearChrome = false;//Очистки
        public bool ClearFireFox;//Очистка
        public bool ClearExploirer = false;//Очистка
        public bool ClearDown = false;//очистка

        //Инфа

        public string Version = "2.1";//версия

        //разное

        StreamWriter rw = new StreamWriter(@"C:\Log Cclearpro.txt");

        public bool ClearTemp = false;

        public MainWindow()//при загрузки формы
        {
            InitializeComponent();

            //хром

            if (Directory.Exists($@"C:\Users\{Environment.UserName}\AppData\Local\Google\Chrome\User Data\Default\Cache"))
                CheckChrome.IsEnabled = true;
            else
                CheckChrome.IsEnabled = false;

            //фарефокс

            if (Directory.Exists($@"C:\Users\{Environment.UserName}\AppData\Local\Mozilla\Firefox\Profiles\6lruynl8.default-1546191072333\cache2\entries"))
                CheckFirefox.IsEnabled = true;
            else
                CheckFirefox.IsEnabled = false;

            //Браузер чтобы скачать браузер

            if (Directory.Exists($@"C:\Users\{Environment.UserName}\AppData\Local\Microsoft\Windows\Temporary Internet Files"))
                CheckInternetExplorer.IsEnabled = true;
            else
                CheckInternetExplorer.IsEnabled = false;
        }

        private void Btcheckoll_Click(object sender, RoutedEventArgs e)//Поставить все галочки
        {
            if (CheckTemp.IsEnabled == true)
                CheckTemp.IsChecked = true;
            if (CheckAppData.IsEnabled == true)
                CheckAppData.IsChecked = true;
            if (CheckChrome.IsEnabled == true)
                CheckChrome.IsChecked = true;
            if (CheckFirefox.IsEnabled == true)
                CheckFirefox.IsChecked = true;
            if (CheckInternetExplorer.IsEnabled == true)
                CheckInternetExplorer.IsChecked = true;
            if (CheckDown.IsEnabled == true)
                CheckDown.IsChecked = true;

            MessageBox.Show("Все галочки поставлены", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtStartClear_Click(object sender, RoutedEventArgs e)//Начать очистку
        {
            if (CheckTemp.IsChecked == false &&
                CheckAppData.IsChecked == false &&
                CheckChrome.IsChecked == false &&
                CheckFirefox.IsChecked == false &&
                CheckInternetExplorer.IsChecked == false)
                MessageBox.Show("Поставте хоть одну галочку", this.Title, MessageBoxButton.OK, MessageBoxImage.Exclamation);
            else
            {
                Thread l = new Thread(new ThreadStart(ClearStart));

                if (CheckTemp.IsChecked == true)
                    ClearTemp = true;
                if (CheckAppData.IsChecked == true)
                    ClearAppdata = true;
                if (CheckChrome.IsChecked == true)
                    ClearChrome = true;
                if (CheckFirefox.IsChecked == true)
                    ClearFireFox = true;
                if (CheckInternetExplorer.IsChecked == true)
                    ClearExploirer = true;
                if (CheckDown.IsChecked == true)
                    ClearDown = true;

                l.Start();
            }

            void ClearStart()//Асихронный метод очитски и новый поток
            {
                //Водим настроки и переменные

                rw.AutoFlush = true;
                IsClose = false;

                //Очистка папки Temp

                this.Dispatcher.Invoke(new Action(() => btStartClear.IsEnabled = false));
                this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Clear()));
                this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add("Запуск очитски")));
                this.Dispatcher.Invoke(new Action(() => lbstatus.Content = "Запуск очистки"));
                rw.WriteLine("Запуск очитски");

                //получение все файлов

                if (ClearTemp == true)
                {
                    //Temp

                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add("Запуск сканирование Temp")));
                    rw.WriteLine("Запуск сканирование Temp");

                    //файлы

                    temps = Directory.GetFiles(@"C:\Windows\Temp", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего файлов в папке Temp {temps.Length}")));
                    rw.WriteLine($"Всего файлов в папке Temp {temps.Length}");

                    //папки

                    tempss = Directory.GetDirectories(@"C:\Windows\Temp", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего папок в папке Temp {tempss.Length}")));
                    rw.WriteLine($"Всего папок в папке Temp {tempss.Length}");
                }

                //AppData
                if (ClearAppdata == true)
                {
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add("Запуск сканирование AppData")));
                    rw.WriteLine("Запуск сканирование AppData");

                    //файлы

                    AppDatas = Directory.GetFiles($@"C:\Users\{Environment.UserName}\AppData\Local\Temp", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего файлов в папке AppData {AppDatas.Length}")));
                    rw.WriteLine($"Всего файлов в папке AppData {AppDatas.Length}");

                    //папки

                    AppDatass = Directory.GetDirectories($@"C:\Users\{Environment.UserName}\AppData\Local\Temp", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего папок в папке AppData {AppDatass.Length}")));
                    rw.WriteLine($"Всего папок в папке AppData {AppDatass.Length}");
                }

                if (ClearChrome == true)
                {
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add("Запуск сканирование Google Chrome")));
                    rw.WriteLine("Запуск сканирование Google Chrome");

                    //файлы

                    Chromes = Directory.GetFiles($@"C:\Users\{Environment.UserName}\AppData\Local\Google\Chrome\User Data\Default\Cache", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего файлов в папке Google Chrome {Chromes.Length}")));
                    rw.WriteLine($"Всего файлов в папке Google Chrome {Chromes.Length}");

                    //папки

                    Chromess = Directory.GetDirectories($@"C:\Users\{Environment.UserName}\AppData\Local\Google\Chrome\User Data\Default\Cache", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего папок в папке Google Chrome {Chromess.Length}")));
                    rw.WriteLine($"Всего папок в папке Google Chrome {Chromess.Length}");
                }

                if (ClearFireFox == true)
                {
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add("Запуск сканирование Firefox")));
                    rw.WriteLine("Запуск сканирование Firefox");

                    //файлы

                    Firefoxs = Directory.GetFiles($@"C:\Users\{Environment.UserName}\AppData\Local\Mozilla\Firefox\Profiles\6lruynl8.default-1546191072333\cache2\entries", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего файлов в папке Firefox {Firefoxs.Length}")));
                    rw.WriteLine($"Всего файлов в папке Firefox {Firefoxs.Length}");

                    //папки

                    Firefoxss = Directory.GetDirectories($@"C:\Users\{Environment.UserName}\AppData\Local\Mozilla\Firefox\Profiles\6lruynl8.default-1546191072333\cache2\entries", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего папок в папке Firefox {Firefoxss.Length}")));
                    rw.WriteLine($"Всего папок в папке Firefox {Firefoxss.Length}");
                }

                if (ClearExploirer == true)
                {
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add("Запуск сканирование Internet Explorer")));
                    rw.WriteLine("Запуск сканирование Internet Explorer");

                    //файлы

                    Exploirers = Directory.GetFiles($@"C:\Users\{Environment.UserName}\AppData\Local\Microsoft\Windows\Temporary Internet Files", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего файлов в папке Internet Explorer {Exploirers.Length}")));
                    rw.WriteLine($"Всего файлов в папке Internet Explorer {Exploirers.Length}");

                    //папки

                    Exploirerss = Directory.GetDirectories($@"C:\Users\{Environment.UserName}\AppData\Local\Microsoft\Windows\Temporary Internet Files", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего папок в папке Internet Explorer {Exploirerss.Length}")));
                    rw.WriteLine($"Всего папок в папке Internet Explorer {Exploirerss.Length}");
                }

                if (ClearDown == true)
                {
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add("Запуск сканирование загрузки")));
                    rw.WriteLine("Запуск сканирование загрузки");

                    //файлы

                    Downs = Directory.GetFiles($@"C:\Users\{Environment.UserName}\Downloads", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего файлов в папке загрузки {Downs.Length}")));
                    rw.WriteLine($"Всего файлов в папке загрузки {Downs.Length}");

                    //папки

                    Downss = Directory.GetDirectories($@"C:\Users\{Environment.UserName}\Downloads", "*", SearchOption.AllDirectories);
                    this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего папок в папке загрузки {Downss.Length}")));
                    rw.WriteLine($"Всего папок в папке загрузки {Downss.Length}");
                }

                if (ClearTemp == true)
                {
                    vsero += temps.Length + tempss.Length;
                }

                if (ClearAppdata == true)
                {
                    vsero += AppDatas.Length + AppDatass.Length;
                }

                if (ClearChrome == true)
                {
                    vsero += Chromes.Length + Chromess.Length;
                }

                if (ClearFireFox == true)
                {
                    vsero += Firefoxs.Length + Firefoxss.Length;
                }

                if (ClearExploirer == true)
                {
                    vsero += Exploirers.Length + Exploirerss.Length;
                }

                if (ClearDown == true)
                {
                    vsero += Downs.Length + Downss.Length;
                }

                this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Всего файлов {vsero}")));
                rw.WriteLine($"Всего файлов {vsero}");

                this.Dispatcher.Invoke(new Action(() => Proggres.Maximum = vsero));
                this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"0/{vsero}")));

                //очистка файлов

                //Temp
                if (ClearTemp == true)
                {
                    //файлы

                    foreach (string name in temps)
                    {
                        try
                        {
                            File.Delete(name);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалён файл по пути: {name}")));
                            rw.WriteLine($"Удалён файл по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }

                    //папки

                    foreach (string name in tempss)
                    {
                        try
                        {
                            Directory.Delete(name, true);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалёна папка по пути: {name}")));
                            rw.WriteLine($"Удалёна папка по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }
                }

                //AppData
                if (ClearAppdata == true)
                {

                    //файлы

                    foreach (string name in AppDatas)
                    {
                        try
                        {
                            File.Delete(name);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалён файл по пути: {name}")));
                            rw.WriteLine($"Удалён файл по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }

                    //папки

                    foreach (string name in AppDatass)
                    {
                        try
                        {
                            Directory.Delete(name, true);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалёна папка по пути: {name}")));
                            rw.WriteLine($"Удалён папка по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }
                }

                if (ClearChrome == true)
                {
                    //файлы

                    foreach (string name in Chromes)
                    {
                        try
                        {
                            File.Delete(name);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалён файл по пути: {name}")));
                            rw.WriteLine($"Удалён файл по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }

                    //папки

                    foreach (string name in Chromess)
                    {
                        try
                        {
                            Directory.Delete(name, true);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалёна папка по пути: {name}")));
                            rw.WriteLine($"Удалён папка по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }
                }

                if (ClearFireFox == true)
                {
                    //файлы

                    foreach (string name in Firefoxs)
                    {
                        try
                        {
                            File.Delete(name);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалён файл по пути: {name}")));
                            rw.WriteLine($"Удалён файл по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }

                    //папки

                    foreach (string name in Firefoxss)
                    {
                        try
                        {
                            Directory.Delete(name, true);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалёна папка по пути: {name}")));
                            rw.WriteLine($"Удалён папка по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }
                }

                if (ClearExploirer == true)
                {
                    //файлы

                    foreach (string name in Exploirers)
                    {
                        try
                        {
                            File.Delete(name);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалён файл по пути: {name}")));
                            rw.WriteLine($"Удалён файл по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }

                    //папки

                    foreach (string name in Exploirerss)
                    {
                        try
                        {
                            Directory.Delete(name, true);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалёна папка по пути: {name}")));
                            rw.WriteLine($"Удалён папка по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }
                }

                if (ClearDown == true)
                {
                    //файлы

                    foreach (string name in Downs)
                    {
                        try
                        {
                            File.Delete(name);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалён файл по пути: {name}")));
                            rw.WriteLine($"Удалён файл по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления файла по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }

                    //папки

                    foreach (string name in Downss)
                    {
                        try
                        {
                            Directory.Delete(name, true);
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Удалёна папка по пути: {name}")));
                            rw.WriteLine($"Удалён папка по пути: {name}");
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                        }
                        catch (Exception ex)
                        {
                            this.Dispatcher.Invoke(new Action(() => Proggres.Value += 1));
                            this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}")));
                            rw.WriteLine($"Ошибка удаления папки по пути: {name}. Описание ошибки: {ex.Message}");
                            this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"{Proggres.Value}/{vsero}")));
                            error++;
                        }
                    }
                }

                this.Dispatcher.Invoke(new Action(() => LIstLog.Items.Add("Конец очитски")));
                rw.WriteLine("Конец очитски");

                this.Dispatcher.Invoke(new Action(() => Proggres.Value = 0));
                this.Dispatcher.Invoke(new Action(() => lbstatus.Content = ($"Нет задач")));
                rw.WriteLine($"Нет задач");
                this.Dispatcher.Invoke(new Action(() => btStartClear.IsEnabled = true));
                this.Dispatcher.Invoke(new Action(() => MessageBox.Show($"Конец очистки! Из {vsero} ошибок {error}", this.Title, MessageBoxButton.OK, MessageBoxImage.Information)));
                rw.WriteLine($"Конец очистки! Из {vsero} ошибок {error}");

                //Сброс

                IsClose = true;
                error = 0;
                ClearTemp = false;
                ClearAppdata = false;
                ClearChrome = false;
                ClearFireFox = false;
                ClearExploirer = false;
                vsero = 0;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)//При закрытие программы
        {
            if (IsClose == true)
            {
                MessageBoxResult lol = MessageBox.Show($"Вы увереные закрыть программу {this.Title}?", this.Title, MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (lol == MessageBoxResult.Yes)
                {
                    Environment.Exit(0);//Исправляет один маленький баг)))
                    e.Cancel = false;
                }
                else if (lol == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Btavtor_Click(object sender, RoutedEventArgs e)//Автор
        {
            Avtor l = new Avtor();
            l.ShowDialog();
        }

        private void Btdispithirchataz_Click(object sender, RoutedEventArgs e)//диспечер задач
        {
            Process.Start(@"taskmgr");
        }

        private void Btreestr_Click(object sender, RoutedEventArgs e)//Редактор реестра
        {
            Process.Start(@"regedit");
        }

        private void Btavtozacryska_Click(object sender, RoutedEventArgs e)//Настройка автозагрузки
        {
            Process.Start(@"msconfig");
        }

        private void Btcheckdelet_Click(object sender, RoutedEventArgs e)//Убрать все галочки
        {
            CheckTemp.IsChecked = false;
            CheckAppData.IsChecked = false;
            CheckChrome.IsChecked = false;
            CheckFirefox.IsChecked = false;
            CheckInternetExplorer.IsChecked = false;

            MessageBox.Show("Все галочки убраны", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Btytilites_Click(object sender, RoutedEventArgs e)//Мои утилиты
        {
            ytilites l = new ytilites();
            l.ShowDialog();
        }

        private void Btlog_Click(object sender, RoutedEventArgs e)//логи
        {
            if (IsClose == true)
            {
                Process.Start(@"C:\Log Cclearpro.txt");
            }
        }

        private void Btqint_Click(object sender, RoutedEventArgs e)//вопрос
        {
            MessageBox.Show($@"Файл логов находиться по пути: C:\Log Cclearpro.txt.{Environment.NewLine}Очистка браузеров очищает только кеш. И потому что ваш браузер начнёт работать быстрые!", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Btversion_Click(object sender, RoutedEventArgs e)//версия
        {
            MessageBox.Show($"Версия программы: {Version}", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Btupdate_Click(object sender, RoutedEventArgs e)//Обновление
        {
            Uri l = new Uri("https://raw.githubusercontent.com/damiralmaev/Cclearpro/master/Update/Cclearpro.exe");
            try
            {
                string var = "";
                WebClient web = new WebClient();
                var = web.DownloadString("https://raw.githubusercontent.com/damiralmaev/Cclearpro/master/ver.txt");
                if (Version != var)
                {
                    MessageBoxResult lol = MessageBox.Show("Есть обновление! Обновить?", "Cclearpro", MessageBoxButton.YesNo, MessageBoxImage.Information);
                    if (lol == MessageBoxResult.Yes)
                    {
                        web.DownloadFileAsync(l, $@"C:\Users\{Environment.UserName}\Desktop\Ccleapronew.exe");
                        MessageBox.Show($@"Загружено! По пути C:\Users\{Environment.UserName}\Desktop\Ccleapronew.exe", "Cclearpro", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Последняя версия!", "Cclearpro", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show($"Ошибка сети: {ex.Message}", "Cclearpro", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void Btsite_Click(object sender, RoutedEventArgs e)//сайт
        {
            Process.Start("https://damiralmaev.github.io/");
        }
    }
}
