using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace KillChrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start(@"cmd", @"/c taskkill.exe /im:chrome.exe /f");
            try
            {
                var soundEffectPath = ConfigurationManager.AppSettings.Get("soundEffect");
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = $"{Environment.CurrentDirectory}\\{soundEffectPath}";
                player.PlaySync();
            }
            catch (Exception)
            {
                //Who cares, don't throw an error.  The job was done.
            }
        }
    }
}
