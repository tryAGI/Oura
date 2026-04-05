#nullable enable

namespace Oura
{
    public partial interface ISandboxRoutesClient
    {
        /// <summary>
        /// Sandbox - Multiple Ring Configuration Documents
        /// </summary>
        /// <param name="nextToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/sandbox/usercollection/ring_configuration' \<br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.MultiDocumentResponseRingConfigurationModel> SandboxMultipleRingConfigurationDocumentsV2SandboxUsercollectionRingConfigurationGetAsync(
            string? nextToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}