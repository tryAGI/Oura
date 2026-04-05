namespace Oura.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static OuraClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OURA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("OURA_API_KEY environment variable is not found.");

        var client = new OuraClient(apiKey);
        
        return client;
    }
}
