#nullable enable

namespace Oura
{
    public partial interface IDailyCardiovascularAgeRoutesClient
    {
        /// <summary>
        /// Multiple Daily Cardiovascular Age Documents
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="nextToken"></param>
        /// <param name="fields">
        /// Comma-separated list of fields to include in the response, in addition to the always returned fields. Defaults to all fields if not provided.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/usercollection/daily_cardiovascular_age?start_date=2021-11-01&amp;end_date=2021-12-01&amp;fields=day,score' \<br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicDailyCardiovascularAge, global::Oura.MultiDocumentResponseDict>> MultipleDailyCardiovascularAgeDocumentsV2UsercollectionDailyCardiovascularAgeGetAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string? nextToken = default,
            string? fields = default,
            global::Oura.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Multiple Daily Cardiovascular Age Documents
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="nextToken"></param>
        /// <param name="fields">
        /// Comma-separated list of fields to include in the response, in addition to the always returned fields. Defaults to all fields if not provided.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/usercollection/daily_cardiovascular_age?start_date=2021-11-01&amp;end_date=2021-12-01&amp;fields=day,score' \<br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.AutoSDKHttpResponse<global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicDailyCardiovascularAge, global::Oura.MultiDocumentResponseDict>>> MultipleDailyCardiovascularAgeDocumentsV2UsercollectionDailyCardiovascularAgeGetAsResponseAsync(
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string? nextToken = default,
            string? fields = default,
            global::Oura.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}