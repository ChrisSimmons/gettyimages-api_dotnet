using FluentAssertions;
using Xunit;

namespace IntegrationTests
{
    public class UnitTest1 : IClassFixture<CredentialsFixture>
    {
        private readonly CredentialsFixture _credentialsFixture;

        public UnitTest1(CredentialsFixture credentialsFixture)
        {
            _credentialsFixture = credentialsFixture;
        }

        [Fact]
        public void ApiSecretEnvironmentVariable()
        {
            _credentialsFixture.ApiSecret.Should().NotBeNull(
                "GETTY_IMAGES_API_API_SECRET must be defined as an environment variable");
        }

        [Fact]
        public void ApiKeyEnvironmentVariable()
        {
            _credentialsFixture.ApiKey.Should().NotBeNull(
                "GETTY_IMAGES_API_API_KEY must be defined as an environment variable");
        }
    }
}