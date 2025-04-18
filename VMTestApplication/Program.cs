using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VM.Core;
using VM.PlatformSDKCS;
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
            Init();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
            try
            {
                if (MainConfig.AutoLoad.Enable)
                {
                    VmSolution.Load(MainConfig.AutoLoad.FilePath);
                }
            }
            catch (VmException exception)
            {
                MessageBox.Show($"VM SDK异常：{exception.Message}", "VM SDK异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"异常：{exception.Message}", "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        
        private static void Init()
        {
            try
            {
                _mainConfigManager = new ConfigManager<MainConfig>("./Config.yml");
                MainConfig = _mainConfigManager.GetConfig();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            VM_EnvironmentCheck();
            Console.WriteLine("程序初始化完成");
        }
        
        private static bool VM_EnvironmentCheck()
        {
            var vmProcesses = new List<string> { "VisionMaster", "VisionMasterServerApp","VmModuleProxy" };
            var runningProcesses = vmProcesses
                .SelectMany(Process.GetProcessesByName)
                .ToList();

            if (runningProcesses.Count <= 0) return true;
    
            if(!MainConfig.KillVmServiceWithStartUp){
                var result = MessageBox.Show(
                @"检测到VisionMaster相关进程正在运行，是否将其关闭？", 
                @"进程提醒", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning
                );
                if (result == DialogResult.No)
                {
                    Application.Exit();
                    return false;
                }
            }
            
            foreach (var process in runningProcesses)
            {
                try
                {
                    process.Kill();
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"终止进程 {process.ProcessName} 失败：{ex.Message}");
                    throw;
                    return false;
                }
            }
            return true;
        }
    }
}