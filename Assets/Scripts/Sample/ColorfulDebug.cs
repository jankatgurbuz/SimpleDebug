using System.Collections.Generic;
using SP.Core;
using UnityEngine;

namespace SP.Sample
{
    public class ColorfulDebug : MonoBehaviour
    {
        private List<LogMessage> _logMessages;

        void Start()
        {
            Debug();
        }

        private void Debug()
        {
            LogAllColors();
            
            // Only Message without specific settings
            DescriptiveMethod(15, "Only Message");
            SimpleDebug.Log("Message");
            SimpleDebug.Log("");
            
            // Only Message with Colors
            DescriptiveMethod(15, "Only Message With Colors");
            SimpleDebug.Log("Message 1", LogColors.Aqua);
            SimpleDebug.Log("Message 1", "Message 2", LogColors.LightPink);
            SimpleDebug.Log("Message 1", "Message 2", "Message 3", LogColors.LightYellow);
            SimpleDebug.Log("");

            // With LogMessage objects
            DescriptiveMethod(15, "With LogMessage");
            SimpleDebug.Log(new LogMessage("Message 1", LogColors.Blue));
            SimpleDebug.Log(
                new LogMessage("Message 1", LogColors.LightBlue),
                new LogMessage("Message 2", LogColors.DarkOrange),
                new LogMessage("Message 3", LogColors.LightPink),
                new LogMessage("Message 4", LogColors.DarkOrange));
            SimpleDebug.Log("");

            // Italic Log Messages
            DescriptiveMethod(15, "Italic");
            SimpleDebug.Log("Message 1", LogColors.LightPink, new LogSettings(true, 12));
            SimpleDebug.Log("Message 1", "Message 2", LogColors.Salmon, new LogSettings(true, 12));
            SimpleDebug.Log("Message 1", "Message 2", "Message 3", LogColors.Teal, new LogSettings(true, 12));
            SimpleDebug.Log(
                new LogMessage("Message 1", LogColors.LightCoral, new LogSettings(true, 12)),
                new LogMessage("Message 2", LogColors.DarkOrange, new LogSettings(true, 12)),
                new LogMessage("Message 3", LogColors.Coral, new LogSettings(true, 12)),
                new LogMessage("Message 4", LogColors.DarkOrange, new LogSettings(true, 12)));
            SimpleDebug.Log("");

            // Log Messages with Different Sizes
            DescriptiveMethod(15, "Size");
            SimpleDebug.Log("Message 1", LogColors.LightPink, new LogSettings(false, 6));
            SimpleDebug.Log("Message 1", "Message 2", LogColors.Pink, new LogSettings(false, 7));
            SimpleDebug.Log("Message 1", "Message 2", "Message 3", LogColors.Plum, new LogSettings(false, 8));
            SimpleDebug.Log(
                new LogMessage("Message 1", LogColors.Green, new LogSettings(false, 9)),
                new LogMessage("Message 2", LogColors.DarkOrange, new LogSettings(false, 10)),
                new LogMessage("Message 3", LogColors.Blue, new LogSettings(false, 11)),
                new LogMessage("Message 4", LogColors.Navy, new LogSettings(false, 12)),
                new LogMessage("Message 5", LogColors.Orchid, new LogSettings(false, 13)),
                new LogMessage("Message 6", LogColors.Crimson, new LogSettings(false, 14)),
                new LogMessage("Message 7", LogColors.LightCoral, new LogSettings(false, 15)));
            SimpleDebug.Log("");

            // Log All Colors
            DescriptiveMethod(15, "All Colors");
            SimpleDebug.Log(_logMessages.ToArray());
        }

        private void LogAllColors()
        {
            _logMessages = new List<LogMessage>
            {
                new LogMessage("Aqua", LogColors.Aqua),
                new LogMessage("Blue", LogColors.Blue),
                new LogMessage("DarkBlue", LogColors.DarkBlue),
                new LogMessage("DarkGray", LogColors.DarkGray),
                new LogMessage("DarkMagenta", LogColors.DarkMagenta),
                new LogMessage("DarkOrange", LogColors.DarkOrange),
                new LogMessage("DarkRed", LogColors.DarkRed),
                new LogMessage("DarkPink", LogColors.DarkPink),
                new LogMessage("Gold", LogColors.Gold),
                new LogMessage("Gray", LogColors.Gray),
                new LogMessage("Grey", LogColors.Grey),
                new LogMessage("Pink", LogColors.Pink),
                new LogMessage("Green", LogColors.Green),
                new LogMessage("Orange", LogColors.Orange),
                new LogMessage("Red", LogColors.Red),
                new LogMessage("White", LogColors.White),
                new LogMessage("Yellow", LogColors.Yellow),
                new LogMessage("Black", LogColors.Black),
                new LogMessage("LightBlue", LogColors.LightBlue),
                new LogMessage("LightGray", LogColors.LightGray),
                new LogMessage("LightGreen", LogColors.LightGreen),
                new LogMessage("LightPink", LogColors.LightPink),
                new LogMessage("LightYellow", LogColors.LightYellow),
                new LogMessage("Maroon", LogColors.Maroon),
                new LogMessage("Navy", LogColors.Navy),
                new LogMessage("Olive", LogColors.Olive),
                new LogMessage("Purple", LogColors.Purple),
                new LogMessage("Silver", LogColors.Silver),
                new LogMessage("Teal", LogColors.Teal),
                new LogMessage("Violet", LogColors.Violet),
                new LogMessage("Brown", LogColors.Brown),
                new LogMessage("Beige", LogColors.Beige),
                new LogMessage("Coral", LogColors.Coral),
                new LogMessage("Crimson", LogColors.Crimson),
                new LogMessage("DarkGreen", LogColors.DarkGreen),
                new LogMessage("Indigo", LogColors.Indigo),
                new LogMessage("Khaki", LogColors.Khaki),
                new LogMessage("Lavender", LogColors.Lavender),
                new LogMessage("LightCoral", LogColors.LightCoral),
                new LogMessage("LightSeaGreen", LogColors.LightSeaGreen),
                new LogMessage("LightSkyBlue", LogColors.LightSkyBlue),
                new LogMessage("Lime", LogColors.Lime),
                new LogMessage("Magenta", LogColors.Magenta),
                new LogMessage("MintCream", LogColors.MintCream),
                new LogMessage("MistyRose", LogColors.MistyRose),
                new LogMessage("Orchid", LogColors.Orchid),
                new LogMessage("PeachPuff", LogColors.PeachPuff),
                new LogMessage("Plum", LogColors.Plum),
                new LogMessage("RosyBrown", LogColors.RosyBrown),
                new LogMessage("RoyalBlue", LogColors.RoyalBlue),
                new LogMessage("Salmon", LogColors.Salmon),
                new LogMessage("Sienna", LogColors.Sienna),
                new LogMessage("SkyBlue", LogColors.SkyBlue),
                new LogMessage("Snow", LogColors.Snow),
                new LogMessage("SpringGreen", LogColors.SpringGreen),
                new LogMessage("SteelBlue", LogColors.SteelBlue),
                new LogMessage("Tan", LogColors.Tan),
                new LogMessage("Thistle", LogColors.Thistle),
                new LogMessage("Tomato", LogColors.Tomato),
                new LogMessage("Turquoise", LogColors.Turquoise),
                new LogMessage("Wheat", LogColors.Wheat)
            };
        }

        private void DescriptiveMethod(int length, string message)
        {
            var messages = new List<LogMessage>();
            for (int i = 0; i < length; i++)
            {
                var randomColor = _logMessages[Random.Range(0, _logMessages.Count)].LogColors;
                messages.Add(new LogMessage("_", randomColor, new LogSettings(false, 17)));
            }
            messages.Add(new LogMessage("  ", LogColors.White, new LogSettings(false, 15)));
            messages.Add(new LogMessage(message, LogColors.White, new LogSettings(false, 15)));
            messages.Add(new LogMessage("  ", LogColors.White, new LogSettings(false, 15)));
        
            for (int i = 0; i < length; i++)
            {
                var randomColor = _logMessages[Random.Range(0, _logMessages.Count)].LogColors;
                messages.Add(new LogMessage("_", randomColor, new LogSettings(false, 17)));
            }

            SimpleDebug.Log(messages.ToArray());
        }
    }
}