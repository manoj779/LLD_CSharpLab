using System;
using System.Collections.Generic;
using System.Threading;

namespace SingletonPatternExample
{
    // ConfigurationManager Singleton class
    public class ConfigurationManager
    {
        // Private static variable to hold the single instance
        private static ConfigurationManager _instance;
        
        // Lock object for thread safety
        private static readonly object _lock = new object();

        // Dictionary to hold configuration settings
        private readonly Dictionary<string, string> _settings;

        // Private constructor to prevent instantiation
        private ConfigurationManager()
        {
            _settings = LoadConfiguration();
        }

        // Public static method to get the single instance (Lazy Initialization)
        public static ConfigurationManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock) // Ensuring only one thread can enter this block at a time
                    {
                        if (_instance == null) // Double-checked locking
                        {
                            _instance = new ConfigurationManager();
                        }
                    }
                }
                return _instance;
            }
        }

        // Method to load configuration settings (simulates reading from a database or file)
        private Dictionary<string, string> LoadConfiguration()
        {
            Console.WriteLine("Loading configuration from database...");
            return new Dictionary<string, string>
            {
                { "API_KEY", "abc123" },
                { "SERVICE_URL", "https://api.example.com" },
                { "MAX_RETRIES", "10" }
            };
        }

        // Method to get a specific configuration setting
        public string GetSetting(string key)
        {
            _settings.TryGetValue(key, out var value);
            return value;
        }
    }

    // Test class to demonstrate the Singleton
    class Program
    {
        static void Main(string[] args)
        {
            // Fetching configuration setting using the Singleton instance
            var configManager = ConfigurationManager.Instance;

            Console.WriteLine("API_KEY: " + configManager.GetSetting("API_KEY"));
            Console.WriteLine("SERVICE_URL: " + configManager.GetSetting("SERVICE_URL"));
            Console.WriteLine("MAX_RETRIES: " + configManager.GetSetting("MAX_RETRIES"));

            // Demonstrating Singleton behavior
            var anotherConfigManager = ConfigurationManager.Instance;
            Console.WriteLine("Both instances are the same: " + (configManager == anotherConfigManager));
        }
    }
}
