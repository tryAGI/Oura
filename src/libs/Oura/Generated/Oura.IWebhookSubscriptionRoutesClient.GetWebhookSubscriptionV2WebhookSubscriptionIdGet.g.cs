#nullable enable

namespace Oura
{
    public partial interface IWebhookSubscriptionRoutesClient
    {
        /// <summary>
        /// Get Webhook Subscription
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/webhook/subscription/5d3fe17b-f880-4d93-b9b6-afbfb76c1e78' --header 'x-client-id: client-id' --header 'x-client-secret: client-secret'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.WebhookSubscriptionModel> GetWebhookSubscriptionV2WebhookSubscriptionIdGetAsync(
            string id,
            global::Oura.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Webhook Subscription
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request GET 'https://api.ouraring.com/v2/webhook/subscription/5d3fe17b-f880-4d93-b9b6-afbfb76c1e78' --header 'x-client-id: client-id' --header 'x-client-secret: client-secret'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.AutoSDKHttpResponse<global::Oura.WebhookSubscriptionModel>> GetWebhookSubscriptionV2WebhookSubscriptionIdGetAsResponseAsync(
            string id,
            global::Oura.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}