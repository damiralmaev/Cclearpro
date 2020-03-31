using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cclearpro
{
    static public class Data
    {
        //Прочее

        public const string VER = "3.0";//Версия программы

        public enum TypeCheckUpdate//Тип проверки обновлений
        {
            Normal = 0,//Нормальные
            Custom = 1//Пользовательские
        }

        public struct SettingsCheckUpdate//Настройки для обновлений
        {
            public string URLFILE;//Ссылка на саму программу
            public string URLVER;//Для проверки версии
        }

        //Данные

        /*Ссылка для обновление проги*/

        //Стартард

        public const string CheckUpdate
            = "https://raw.githubusercontent.com/damiralmaev/Cclearpro/release-3.0/Other/Update/Windows/ver.txt";//txt для проверки
        public const string CheckUpdateFile
            = "https://raw.githubusercontent.com/damiralmaev/Cclearpro/release-3.0/Other/Update/Windows/Cclearpro.rar";//Сам наш файл

        /*Ссылка для обновление проги*/

        static public object Settings { get; set; }//Для класса Settngs
    }
}
