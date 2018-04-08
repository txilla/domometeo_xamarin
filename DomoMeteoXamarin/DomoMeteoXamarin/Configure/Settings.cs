using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomoMeteoXamarin.Configure
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get { return CrossSettings.Current; }
        }

        public static string Address
        {
            get => AppSettings.GetValueOrDefault(nameof(Address), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Address), value);
        }

        public static string Port
        {
            get => AppSettings.GetValueOrDefault(nameof(Port), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Port), value);
        }
    }
}

