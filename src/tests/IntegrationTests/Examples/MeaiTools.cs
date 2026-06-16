/*
order: 20
title: MEAI Tools
slug: meai-tools

Example showing how to use Oura Ring data as AIFunction tools with any IChatClient.
*/

namespace Oura.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_MeaiTools()
    {
        //// Create an Oura client with your API key.
        using var client = GetAuthenticatedClient();

        //// Get all tools using the aggregate method.
        var tools = client.AsTools();
        tools.Should().BeEmpty();

        //// These tools can be passed to any IChatClient for function calling:
        //// var chatResponse = await chatClient.GetResponseAsync(
        ////     "How did I sleep last night?",
        ////     new() { Tools = [getDailySleepTool, getSleepDataTool] });
    }
}
