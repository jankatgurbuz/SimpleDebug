namespace SP.Core
{
    public class LogMessage
    {
        public object Message { get; }
        public LogColors LogColors { get; }
        public LogSettings LogSettings { get; }

        public LogMessage(object message, LogColors logColors, LogSettings logSettings = null)
        {
            Message = message;
            LogColors = logColors;
            LogSettings = logSettings;
        }
    }

    public static class LogMessageExtensions
    {
        public static object[] GetMessages(this LogMessage[] logMessages)
        {
            var messages = new object[logMessages.Length];
            for (int i = 0; i < logMessages.Length; i++)
            {
                messages[i] = logMessages[i].Message;
            }

            return messages;
        }
    }
}