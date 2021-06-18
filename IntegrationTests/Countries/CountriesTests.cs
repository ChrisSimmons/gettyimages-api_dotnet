using System.Threading.Tasks;
using FluentAssertions;
using GettyImages.Api;
using Newtonsoft.Json.Linq;
using Xunit;

namespace IntegrationTests.Countries
{
    public class GetCountries : IAsyncLifetime
    {
        private readonly ApiClient _apiClient;
        private dynamic _countriesResponse;
        private JArray _getCountriesResponse;

        public GetCountries()
        {
            _apiClient = ApiClient.GetApiClientWithClientCredentials(ApiCredentials.ApiKey, ApiCredentials.ApiSecret);
        }

        public async Task InitializeAsync()
        {
            _countriesResponse = await _apiClient
                .Countries()
                .ExecuteAsync();

            _getCountriesResponse = _countriesResponse.countries as JArray;
        }
        
        [Fact]
        public void ShouldNotBeNull()
        {
            _getCountriesResponse.Should().NotBeNull();
        }
        
        [Fact]
        public void ShouldHaveMultipleEntries()
        {
            _getCountriesResponse.Should().HaveCountGreaterThan(1);
        }

        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
