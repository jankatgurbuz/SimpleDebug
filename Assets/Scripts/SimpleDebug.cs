using System.Text;
using SP.Core;
using UnityEngine;

namespace SP
{
    public static class SimpleDebug
    {
        private static readonly StringBuilder _stringBuilder = new StringBuilder();

        public static void Log(object message, LogSettings settings = null)
        {
            Debug.Log(ProcessLog(LogColors.DarkOrange, settings, message));
        }

        public static void Log(object message, LogColors color, LogSettings settings = null)
        {
            Debug.Log(ProcessLog(color, settings, message));
        }

        public static void Log(object message, object message2, LogColors color, LogSettings settings = null)
        {
            Debug.Log(ProcessLog(color, settings, message, message2));
        }

        public static void Log(object message, object message2, object message3, LogColors color,
            LogSettings settings = null)
        {
            Debug.Log(ProcessLog(color, settings, message, message2, message3));
        }

        public static void Log(LogColors color, params object[] messages)
        {
            Debug.Log(ProcessLog(color, null, messages));
        }

        public static void Log(params LogMessage[] logMessages)
        {
            Debug.Log(ProcessLog(logMessages));
        }

        private static string ProcessLog(LogColors color, LogSettings logsettings, params object[] messages)
        {
#if UNITY_EDITOR
            return ProcessEditorLog(color, logsettings, messages);
#else
        return ProcessBuildLog(messages);
#endif
        }

        private static string ProcessLog(params LogMessage[] logMessages)
        {
#if UNITY_EDITOR
            return ProcessEditorLog(logMessages);
#else
        return ProcessBuildLog(logMessages.GetMessages());
#endif
        }

        private static string ProcessEditorLog(LogColors color, LogSettings logsettings, params object[] messages)
        {
            _stringBuilder.Clear();
            _stringBuilder.Append("<color=");
            _stringBuilder.Append(color);
            _stringBuilder.Append(">");

            foreach (var item in messages)
            {
                _stringBuilder.Append(item);
                _stringBuilder.Append(" ");
            }

            _stringBuilder.Append("</color>");

            return LogHelper.ApplyLogSettings(_stringBuilder.ToString(), logsettings);
        }

        private static string ProcessEditorLog(params LogMessage[] logMessages)
        {
            _stringBuilder.Clear();

            foreach (var item in logMessages)
            {
                _stringBuilder.Append("<color=");
                _stringBuilder.Append(item.LogColors);
                _stringBuilder.Append(">");
                _stringBuilder.Append(item.Message);
                _stringBuilder.Append("</color>");
                _stringBuilder.Append(" ");

                var formattedMessage = LogHelper.ApplyLogSettings(_stringBuilder.ToString(), item.LogSettings);
                _stringBuilder.Clear();
                _stringBuilder.Append(formattedMessage);
            }

            return _stringBuilder.ToString().Trim();
        }

        private static string ProcessBuildLog(params object[] messages)
        {
            return string.Join(" ", messages);
        }
    }
}