using System;
public sealed class SecuritySystem
{
    public string SystemName { get; set; }

    public SecuritySystem(string name)
    {
        SystemName = name;
    }

    public void PerformSecurityCheck()
    {
        Console.WriteLine($"Performing security check for {SystemName}...");
    }
}  

