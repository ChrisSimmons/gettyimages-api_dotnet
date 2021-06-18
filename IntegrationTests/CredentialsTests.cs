using FluentAssertions;
using Xunit;

namespace IntegrationTests
{
    public class CredentialsTests
    {

        [Fact]
        public void ApiSecretEnvironmentVariableMustBePresent()
        {
            ApiCredentials.ApiSecret.Should().NotBeNull(
                "GETTY_IMAGES_API_API_SECRET must be defined as an environment variable");
        }

        [Fact]
        public void ApiKeyEnvironmentVariableMustBePresent()
        {
            ApiCredentials.ApiKey.Should().NotBeNull(
                "GETTY_IMAGES_API_API_KEY must be defined as an environment variable");
        }
    }
}