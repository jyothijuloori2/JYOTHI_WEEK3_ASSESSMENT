public class ErrorCategoryDecorator : LoggerDecorator
{
    private string _category;

    public ErrorCategoryDecorator(ILogger logger, string category) : base(logger)
    {
        _category = category;
    }

    public override void Log(string message)
    {
        string categorizedMessage = $"[{_category}] {message}";
        base.Log(categorizedMessage);
    }
}