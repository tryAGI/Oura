#nullable enable

namespace Oura
{
    public partial interface IRingConfigurationRoutesClient
    {
        /// <summary>
        /// Multiple Ring Configuration Documents
        /// </summary>
        /// <param name="fields">
        /// Comma-separated list of fields to include in the response, in addition to the always returned fields. Defaults to all fields if not provided.
        /// </param>
        /// <param name="nextToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/usercollection/ring_configuration?fields=day,score' \<br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicRingConfiguration, global::Oura.MultiDocumentResponseDict>> MultipleRingConfigurationDocumentsV2UsercollectionRingConfigurationGetAsync(
            string? fields = default,
            string? nextToken = default,
            global::Oura.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Multiple Ring Configuration Documents
        /// </summary>
        /// <param name="fields">
        /// Comma-separated list of fields to include in the response, in addition to the always returned fields. Defaults to all fields if not provided.
        /// </param>
        /// <param name="nextToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/usercollection/ring_configuration?fields=day,score' \<br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.AutoSDKHttpResponse<global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicRingConfiguration, global::Oura.MultiDocumentResponseDict>>> MultipleRingConfigurationDocumentsV2UsercollectionRingConfigurationGetAsResponseAsync(
            string? fields = default,
            string? nextToken = default,
            global::Oura.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}