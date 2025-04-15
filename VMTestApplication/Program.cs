using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMTestApplication.Config;

namespace VMTestApplication
{
    static class Program
    {
        private static ConfigManager<MainConfig> _mainConfigManager;
        public static MainConfig MainConfig;
        
        [STAThread]
        static void Main()
        {
            try
            {
                _mainConfigManager = new ConfigManager<MainConfig>("Config.yml");
                MainConfig = _mainConfigManager.GetConfig();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}