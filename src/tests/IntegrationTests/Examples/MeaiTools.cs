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

        //// Create AIFunction tools for use with any IChatClient.
        var getDailySleepTool = client.AsGetDailySleepTool();
        getDailySleepTool.Should().NotBeNull();
        getDailySleepTool.Name.Should().Be("Oura_GetDailySleep");

        var getDailyActivityTool = client.AsGetDailyActivityTool();
        getDailyActivityTool.Should().NotBeNull();
        getDailyActivityTool.Name.Should().Be("Oura_GetDailyActivity");

        var getDailyReadinessTool = client.AsGetDailyReadinessTool();
        getDailyReadinessTool.Should().NotBeNull();
        getDailyReadinessTool.Name.Should().Be("Oura_GetDailyReadiness");

        var getHeartRateTool = client.AsGetHeartRateTool();
        getHeartRateTool.Should().NotBeNull();
        getHeartRateTool.Name.Should().Be("Oura_GetHeartRate");

        var getSleepDataTool = client.AsGetSleepDataTool();
        getSleepDataTool.Should().NotBeNull();
        getSleepDataTool.Name.Should().Be("Oura_GetSleepData");

        //// Or get all tools at once using the aggregate method.
        var tools = client.AsTools();
        tools.Count.Should().Be(5);

        //// These tools can be passed to any IChatClient for function calling:
        //// var chatResponse = await chatClient.GetResponseAsync(
        ////     "How did I sleep last night?",
        ////     new() { Tools = [getDailySleepTool, getSleepDataTool] });
    }
}
