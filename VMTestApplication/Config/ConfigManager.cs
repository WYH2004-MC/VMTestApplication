using System;
using System.IO;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace VMTestApplication.Config
{
    public class ConfigManager<T> where T : new()
    {
        private readonly string _configPath;
        private T _config;
        
        public ConfigManager(string configPath = "config.yml")
        {
            _configPath = configPath;
            InitConfig();
        }

        private void InitConfig()
        {
            try
            {
                if (!File.Exists(_configPath))
                {
                    _config = new T();
                    SaveConfig();
                    Console.WriteLine($@"Config file not found. Creating new config file at {_configPath}");
                    return;
                }

                LoadConfig();
            }
            catch (Exception ex)
            {
                Console.WriteLine($@"Error loading config: {ex.Message}");
                throw;
            }
        }

        public T GetConfig()
        {
            if (_config == null)
            {
                throw new InvalidOperationException("Configuration is not initialized.");
            }
            return _config;
        }

        private void SaveConfig()
        {
            var directory = Path.GetDirectoryName(_configPath);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            
            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            var yaml = serializer.Serialize(_config);
            File.WriteAllText(_configPath, yaml);
        }

        
        private void LoadConfig()
        {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            var yaml = File.ReadAllText(_configPath);
            _config = deserializer.Deserialize<T>(yaml);
        }
    }
}