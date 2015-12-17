using FluentAssertions;
using NUnit.Framework;

namespace ConfigSettingsHelper.Test
{
    [TestFixture]
    public class SettingsTest
    {
        [Test]
        public void ShouldReturnCorrectValueFromAppSettings()
        {
            const int expectedValue = 0;
            const string key = "MinScore";
            var settings = new Settings();

            var actualValue = settings.Get<int>(key);

            actualValue.Should().Be(expectedValue);
        }

        [Test]
        public void ShouldReturnCorrectValueFromConfigSection()
        {
            const string expectedValue = "http://10.55.109.95:9020";
            const string key = "XpertHR_SearchService";

            var settings = new Settings("idolSettings");
            var actualValue = settings.Get<string>(key);

            actualValue.Should().Be(expectedValue);
        }
    }
}
