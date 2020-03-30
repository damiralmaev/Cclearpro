using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Cclearpro.Other.Class
{
    public class UpdateManager
    {
        private string PathFile { get; set; }

        public UpdateManager(string pathFile = "UpdateCclearpro") => PathFile = pathFile;

        public bool Check()//Есть обновление?
        {
            using (WebClient web = new WebClient())
            {
                string ver = web.DownloadString(Data.CheckUpdate);

                if (ver == Data.CheckUpdate)
                    goto link1;
                else
                    goto link2;
            }

        link1:
            return false;

        link2:
            return true;
        }

        public async void Download(WebClient web)//Скачать сам файл
        {
            /* WebClient нужен был чтобы изменять progressbar! */

            await web.DownloadDataTaskAsync(Data.CheckUpdateFile);
            //web.Proxy Потом сделаю прокси!
        }
    }
}
