namespace VMTestApplication.Config
{
    public class MainConfig
    {
        public bool KillVmServiceWithStartUp { get; set; } = false;
        public AutoLoadConfig AutoLoad { get; set; } = new AutoLoadConfig();
        
        
        public class AutoLoadConfig
        {
            public bool Enable { get; set; } = false;
            public string FilePath { get; set; } = "";
        }
    }
}