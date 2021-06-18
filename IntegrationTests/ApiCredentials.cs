using System;
using FluentAssertions;
using Xunit;

namespace IntegrationTests
{
    public static class ApiCredentials
    {
        public static string ApiKey { get; }
        public static string ApiSecret { get; }

        static ApiCredentials()
        {
            ApiKey = Environment.GetEnvironmentVariable("GETTY_IMAGES_API_API_KEY");
            ApiSecret = Environment.GetEnvironmentVariable("GETTY_IMAGES_API_API_SECRET");
        }
    }
}