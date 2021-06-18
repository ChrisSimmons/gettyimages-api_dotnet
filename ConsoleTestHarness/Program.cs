using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleTestHarness
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddApiClientWithClientCredentials( apiKey: "API_KEY", apiSecret: "API_SECRET");
            serviceCollection.AddApiClientWithResourceOwnerCredentials(
                apiKey: "API_KEY", apiSecret: "API_SECRET",
                userName: "USERNAME", userPassword: "USER_PASSWORD");
            
            // TODO - This needs some thought.  How would you expect to set this up?
            serviceCollection.AddApiClientWithRefreshToken(
                apiKey: "API_KEY", apiSecret: "API_SECRET",
                refreshToken: "REFRESH_TOKEN");

            // TODO - This is a likely arrangement, with username and password coming during runtime
            serviceCollection.AddGettyApiClient(apiKey: "API_KEY", apiSecret: "API_SECRET");
            
            Console.WriteLine("Hello World!");
        }
    }

    public class GettyApiProviderThing
    {
        public GettyApiProviderThing(IGettyApiClientFactory gettyApiClientFactory)
        {
            var client = gettyApiClientFactory.CreateClient();
        }
    }
}