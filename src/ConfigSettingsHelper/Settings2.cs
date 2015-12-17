using System.Collections.Specialized;
using System.Configuration;
using ConfigSettingsHelper.Extensions;

namespace ConfigSettingsHelper
{
    public static class Settings2
    {
        public static T Get<T>(string key)
        {
            return ConfigurationManager.AppSettings.GetValue<T>(key);
        }

        public static T Get<T>(string key, string sectionName)
        {
            return (ConfigurationManager.GetSection(sectionName) as NameValueCollection ?? new NameValueCollection()).GetValue<T>(key);
        }
    }
}