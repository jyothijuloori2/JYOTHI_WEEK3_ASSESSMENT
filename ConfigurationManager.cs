using System;

public sealed class ConfigurationManager
{
    private static ConfigurationManager _instance;
    private static readonly object _lock = new object();

    private ConfigurationManager()
    {
        Console.WriteLine("ConfigurationManager Initialized.");
    }


    public static ConfigurationManager Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationManager();
                    }
                }
            }
            return _instance;
        }
    }


    public string GetConfigValue(string key)
    {
        return $"Value for {key}";
    }
}
