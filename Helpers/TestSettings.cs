using System;

namespace TestAgSpace.Helpers
{
    public class TestSettings
    {
        public static string AgSpaceUrl { get; set; } = "https://ag-space.com";
        public static string WhatsNewUrl { get; set; } = "https://ag-space.com/whats-new/";
        public static string ContactUrl { get; set; } = "https://ag-space.com/contact/";
        public static TimeSpan TimeSpan = new TimeSpan(0, 0, 10);
        public static int ScrollDownValue = 17;
    }
}
