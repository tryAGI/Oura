#nullable enable

namespace Oura
{
    public partial interface ISessionRoutesClient
    {
        /// <summary>
        /// Multiple Session Documents
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="nextToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/usercollection/session?start_date=2021-11-01&amp;end_date=2021-12-01' \<br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.MultiDocumentResponseSessionModel> MultipleSessionDocumentsV2UsercollectionSessionGetAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string? nextToken = default,
            global::Oura.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}