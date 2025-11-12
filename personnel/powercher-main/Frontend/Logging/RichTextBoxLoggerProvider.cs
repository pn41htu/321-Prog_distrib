using Microsoft.Extensions.Logging;
namespace Frontend.Logging;

public class RichTextBoxLoggerProvider : ILoggerProvider
{
    private readonly RichTextBox _richTextBox;

    public RichTextBoxLoggerProvider(RichTextBox richTextBox)
    {
        _richTextBox = richTextBox;
    }

    public ILogger CreateLogger(string categoryName)
    {
        return new RichTextBoxLogger(categoryName, _richTextBox);
    }

    public void Dispose()
    {
        // Clean up resources if necessary
    }
}