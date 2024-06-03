namespace SP.Core
{
    public class LogColors
    {
        public static implicit operator string(LogColors color) => color.Value;

        private LogColors(string value) => Value = value;

        private string Value { get; }

        public static LogColors Aqua => new LogColors("#00FFFF");
        public static LogColors Blue => new LogColors("#0000FF");
        public static LogColors DarkBlue => new LogColors("#00008B");
        public static LogColors DarkGray => new LogColors("#A9A9A9");
        public static LogColors DarkMagenta => new LogColors("#8B008B");
        public static LogColors DarkOrange => new LogColors("#FF8C00");
        public static LogColors DarkRed => new LogColors("#8B0000");
        public static LogColors DarkPink => new LogColors("#FF1493");
        public static LogColors Gold => new LogColors("#FFD700");
        public static LogColors Gray => new LogColors("#808080");
        public static LogColors Grey => new LogColors("#808080");
        public static LogColors Pink => new LogColors("#FF69B4");
        public static LogColors Green => new LogColors("#008000");
        public static LogColors Orange => new LogColors("#FFA500");
        public static LogColors Red => new LogColors("#FF0000");
        public static LogColors White => new LogColors("#FFFFFF");
        public static LogColors Yellow => new LogColors("#FFFF00");
        public static LogColors Black => new LogColors("#000000");
        public static LogColors LightBlue => new LogColors("#ADD8E6");
        public static LogColors LightGray => new LogColors("#D3D3D3");
        public static LogColors LightGreen => new LogColors("#90EE90");
        public static LogColors LightPink => new LogColors("#FFB6C1");
        public static LogColors LightYellow => new LogColors("#FFFFE0");
        public static LogColors Maroon => new LogColors("#800000");
        public static LogColors Navy => new LogColors("#000080");
        public static LogColors Olive => new LogColors("#808000");
        public static LogColors Purple => new LogColors("#800080");
        public static LogColors Silver => new LogColors("#C0C0C0");
        public static LogColors Teal => new LogColors("#008080");
        public static LogColors Violet => new LogColors("#EE82EE");
        public static LogColors Brown => new LogColors("#A52A2A");
        public static LogColors Beige => new LogColors("#F5F5DC");
        public static LogColors Coral => new LogColors("#FF7F50");
        public static LogColors Crimson => new LogColors("#DC143C");
        public static LogColors DarkGreen => new LogColors("#006400");
        public static LogColors Indigo => new LogColors("#4B0082");
        public static LogColors Khaki => new LogColors("#F0E68C");
        public static LogColors Lavender => new LogColors("#E6E6FA");
        public static LogColors LightCoral => new LogColors("#F08080");
        public static LogColors LightSeaGreen => new LogColors("#20B2AA");
        public static LogColors LightSkyBlue => new LogColors("#87CEFA");
        public static LogColors Lime => new LogColors("#00FF00");
        public static LogColors Magenta => new LogColors("#FF00FF");
        public static LogColors MintCream => new LogColors("#F5FFFA");
        public static LogColors MistyRose => new LogColors("#FFE4E1");
        public static LogColors Orchid => new LogColors("#DA70D6");
        public static LogColors PeachPuff => new LogColors("#FFDAB9");
        public static LogColors Plum => new LogColors("#DDA0DD");
        public static LogColors RosyBrown => new LogColors("#BC8F8F");
        public static LogColors RoyalBlue => new LogColors("#4169E1");
        public static LogColors Salmon => new LogColors("#FA8072");
        public static LogColors Sienna => new LogColors("#A0522D");
        public static LogColors SkyBlue => new LogColors("#87CEEB");
        public static LogColors Snow => new LogColors("#FFFAFA");
        public static LogColors SpringGreen => new LogColors("#00FF7F");
        public static LogColors SteelBlue => new LogColors("#4682B4");
        public static LogColors Tan => new LogColors("#D2B48C");
        public static LogColors Thistle => new LogColors("#D8BFD8");
        public static LogColors Tomato => new LogColors("#FF6347");
        public static LogColors Turquoise => new LogColors("#40E0D0");
        public static LogColors Wheat => new LogColors("#F5DEB3");
    }
}