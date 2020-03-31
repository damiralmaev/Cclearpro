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

        //Данные

        /*Ссылка для обновление проги*/

        static public string CheckUpdate { get; set; }
            = "https://raw.githubusercontent.com/damiralmaev/Cclearpro/release-3.0/Other/Update/Windows/ver.txt";//txt для проверки
        static public string CheckUpdateFile { get; set; }
            = "https://raw.githubusercontent.com/damiralmaev/Cclearpro/release-3.0/Other/Update/Windows/Cclearpro.rar";//Сам наш файл

        /*Ссылка для обновление проги*/

        static public object Settings { get; set; }//Для класса Settngs
    }
}
