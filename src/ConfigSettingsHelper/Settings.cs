using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using ConfigSettingsHelper.Extensions;

namespace ConfigSettingsHelper
{
    public class Settings
    {
        private readonly NameValueCollection valueCollection;

        public Settings()
        {
            valueCollection = ConfigurationManager.AppSettings;
        }
        public Settings(string sectionName)
        {
            valueCollection = ConfigurationManager.GetSection(sectionName) as NameValueCollection ?? new NameValueCollection();
        }

        public T Get<T>(string key)
        {
            return valueCollection.GetValue<T>(key);
        }
    }
}
