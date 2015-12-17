using FluentAssertions;
using NUnit.Framework;

namespace ConfigSettingsHelper.Test
{
    [TestFixture]
    public class Settings2Test
    {
        [Test]
        public void ShouldReturnCorrectValueFromAppSettings()
        {
            const int expectedValue = 0;
            const string key = "MinScore";

            var actualValue = Settings2.Get<int>(key);

            actualValue.Should().Be(expectedValue);
        }

        [Test]
        public void ShouldReturnCorrectValueFromConfigSection()
        {
            const string expectedValue = "http://10.55.109.95:9020";
            const string key = "XpertHR_SearchService";
            const string sectionName = "idolSettings";

            var actualValue = Settings2.Get<string>(key,sectionName);

            actualValue.Should().Be(expectedValue);
        }
    }
}
