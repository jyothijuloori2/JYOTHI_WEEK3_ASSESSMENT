using System;

public class TimestampDecorator : LoggerDecorator
{
    public TimestampDecorator(ILogger logger) : base(logger) { }

    public override void Log(string message)
    {
        string timestampMessage = $"{DateTime.Now}: {message}";
        base.Log(timestampMessage);
    }
}