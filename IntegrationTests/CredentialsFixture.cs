using System;
using FluentAssertions;
using Xunit;

namespace IntegrationTests
{
    public class CredentialsFixture
    {
        public string ApiKey { get; }
        public string ApiSecret { get; }

        public CredentialsFixture()
        {
            ApiKey = Environment.GetEnvironmentVariable("GETTY_IMAGES_API_API_KEY");
            ApiSecret = Environment.GetEnvironmentVariable("GETTY_IMAGES_API_API_SECRET");
        }
    }
}