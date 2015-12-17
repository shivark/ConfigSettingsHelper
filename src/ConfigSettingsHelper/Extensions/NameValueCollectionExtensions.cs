using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

namespace ConfigSettingsHelper.Extensions
{
    public static class NameValueCollectionExtensions
    {
        public static T GetValue<T>(this NameValueCollection collection, string key)
        {
            if (!collection.AllKeys.Contains(key))
                throw new ConfigurationErrorsException(String.Format("{0} does not exist.", key));

            var value = collection.Get(key);
            return (T)Convert.ChangeType(value, typeof (T));
        }
    }
}
