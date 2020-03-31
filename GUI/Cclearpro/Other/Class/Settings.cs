using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cclearpro.Other.Class
{
    public class Settings//Сами настройки
    {

    }

    public class SettingsManager//Он управляет классом Settings
    {
        private object Settngs { get; set; }

        public SettingsManager(object settings) => Settngs = settings;

        public void Load()
        {
            
        }

        public object Save()
        {
            return new object();
        }
    }
}
