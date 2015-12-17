using System.Collections.Specialized;
using System.Configuration;
using ConfigSettingsHelper.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace ConfigSettingsHelper.Test.Extensions
{
    [TestFixture]
    public class NameValueCollectionExtensionsTest
    {
        [Test]
        public void ShouldReturnCorrectValue()
        {
            const string key = "key";
            const string value = "1";
            var nameValueCollection = new NameValueCollection { { key, value } };

            var actualValue = nameValueCollection.GetValue<int>(key);

            actualValue.Should().Be(int.Parse(value));
        }

        [Test]
        [ExpectedException(typeof(ConfigurationErrorsException), ExpectedMessage = "key does not exist.")]
        public void ShouldThrowAnExceptionWhenKeyDoesNotExist()
        {
            var nameValueCollection = new NameValueCollection();

            nameValueCollection.GetValue<int>("key");
        }
    }
}
