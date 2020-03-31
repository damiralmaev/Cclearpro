using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media;

namespace Cclearpro.Other.Class
{
    public class Settings//Сами настройки
    {
        [JsonProperty("checkUpdate")]
        public bool CheckUpdate { get; set; }//Проверять обновление?

        [JsonProperty("typeCheckUpdate")]
        public Data.TypeCheckUpdate TypeCheckUpdate { get; set; }//Тип проверки обновлений

        [JsonProperty("settingsUpdate")]
        public Data.SettingsCheckUpdate SettingsUpdate { get; set; }//Настройки пользовательский обновлений
    }

    public class SettingsManager//Он управляет классом Settings
    {
        private Settings Settings { get; set; } = new Settings();//Cами настройки
        private string SavePath { get; set; }//Куда и где настройки?

        public SettingsManager(object setting, string savepath = "Settings.json")
        { 
            Settings = (Settings)setting;
            SavePath = savepath;
        }

        public object Load()
        {
            if (!File.Exists(SavePath))
            {
                var set = new Settings()
                {
                    CheckUpdate = true,
                    TypeCheckUpdate = Data.TypeCheckUpdate.Normal,
                    SettingsUpdate = new Data.SettingsCheckUpdate() { URLFILE = "", URLVER = "" }
                };
                Settings = set;
                Save();
                return set;
            }
            else
            {
                return JsonConvert.DeserializeObject<Settings>(SavePath);
            }
        }

        public void Save()
        {
            File.WriteAllText(SavePath, JsonConvert.SerializeObject(Settings));
        }
    }
}
