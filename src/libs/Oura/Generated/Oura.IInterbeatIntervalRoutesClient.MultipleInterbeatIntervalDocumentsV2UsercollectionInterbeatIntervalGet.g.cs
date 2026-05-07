#nullable enable

namespace Oura
{
    public partial interface IInterbeatIntervalRoutesClient
    {
        /// <summary>
        /// Multiple Interbeat Interval Documents
        /// </summary>
        /// <param name="startDatetime"></param>
        /// <param name="endDatetime"></param>
        /// <param name="nextToken"></param>
        /// <param name="latest"></param>
        /// <param name="fields">
        /// Comma-separated list of fields to include in the response, in addition to the always returned fields. Defaults to all fields if not provided.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// # The '+' symbol in the timezone must be escaped to `%2B` if included. <br/>
        /// curl --location --request GET 'https://api.ouraring.com/v2/usercollection/interbeat_interval?start_datetime=2021-11-01T00:00:00-08:00&amp;end_datetime=2021-12-01T00:00:00-08:00&amp;fields=timestamp,bpm' \ <br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.AnyOf<global::Oura.TimeSeriesResponsePublicInterbeatIntervalRow, global::Oura.TimeSeriesResponseDict>> MultipleInterbeatIntervalDocumentsV2UsercollectionInterbeatIntervalGetAsync(
            global::System.DateTime? startDatetime = default,
            global::System.DateTime? endDatetime = default,
            string? nextToken = default,
            bool? latest = default,
            string? fields = default,
            global::Oura.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Multiple Interbeat Interval Documents
        /// </summary>
        /// <param name="startDatetime"></param>
        /// <param name="endDatetime"></param>
        /// <param name="nextToken"></param>
        /// <param name="latest"></param>
        /// <param name="fields">
        /// Comma-separated list of fields to include in the response, in addition to the always returned fields. Defaults to all fields if not provided.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// # The '+' symbol in the timezone must be escaped to `%2B` if included. <br/>
        /// curl --location --request GET 'https://api.ouraring.com/v2/usercollection/interbeat_interval?start_datetime=2021-11-01T00:00:00-08:00&amp;end_datetime=2021-12-01T00:00:00-08:00&amp;fields=timestamp,bpm' \ <br/>
        /// --header 'Authorization: Bearer &lt;token&gt;'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.AutoSDKHttpResponse<global::Oura.AnyOf<global::Oura.TimeSeriesResponsePublicInterbeatIntervalRow, global::Oura.TimeSeriesResponseDict>>> MultipleInterbeatIntervalDocumentsV2UsercollectionInterbeatIntervalGetAsResponseAsync(
            global::System.DateTime? startDatetime = default,
            global::System.DateTime? endDatetime = default,
            string? nextToken = default,
            bool? latest = default,
            string? fields = default,
            global::Oura.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}