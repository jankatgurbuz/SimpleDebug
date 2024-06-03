namespace SP.Core
{
    public class LogSettings
    {
        public LogSettings(bool italic, int size)
        {
            Italic = italic;
            Size = size;
        }

        public bool Italic { get; }
        public int Size { get; }
    }

    public class LogHelper
    {
        public static string ApplyLogSettings(string message, LogSettings settings)
        {
            if (settings == null)
            {
                return message;
            }

            if (settings.Italic)
            {
                message = $"<i>{message}</i>";
            }

            if (settings.Size > 0)
            {
                message = $"<size={settings.Size}>{message}</size>";
            }

            return message;
        }
    }
}