#nullable enable

namespace Oura
{
    public partial interface ISandboxRoutesClient
    {
        /// <summary>
        /// Sandbox - Single Daily Readiness Document
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/sandbox/usercollection/daily_readiness/2-5daccc095220cc5493a4e9c2b681ca941e' \<br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.DailyReadinessModel> SandboxSingleDailyReadinessDocumentV2SandboxUsercollectionDailyReadinessDocumentIdGetAsync(
            string documentId,
            global::Oura.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}