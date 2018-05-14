using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;

namespace FunnelBud.ConfigurationManagement
{
    public static class ConfigManager
    {
        public static double VATPercentageIncrement
        {
            get
            {
                return double.Parse(GetAppSetting("VATPercentageIncrement", string.Empty, throwExpIfNotFound: true), CultureInfo.InvariantCulture); ;
            }
        }

        private static T GetAppSetting<T>(string key, T defaultValue, bool throwExpIfNotFound)
        {
            string appSettingsValue = ConfigurationManager.AppSettings[key];
            if (!string.IsNullOrWhiteSpace(appSettingsValue))
            {
                var theType = typeof(T);
                if (theType.IsEnum)
                    return (T)Enum.Parse(theType, appSettingsValue, true);
                else
                    return (T)Convert.ChangeType(appSettingsValue, theType);
            }
            else if (throwExpIfNotFound)
                throw new ArgumentException("Setting not found. key: " + key);
            else
                return defaultValue;
        }
    }
}