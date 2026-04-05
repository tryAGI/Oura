#nullable enable

namespace Oura
{
    public partial interface IWebhookSubscriptionRoutesClient
    {
        /// <summary>
        /// Update Webhook Subscription
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request PUT 'https://api.ouraring.com/v2/webhook/subscription/5d3fe17b-f880-4d93-b9b6-afbfb76c1e78' --header 'x-client-id: client-id' --header 'x-client-secret: client-secret' --header 'Content-Type: application/json' --data-raw '{<br/>
        ///     "callback_url": "https://my-api/oura/tag/delete",<br/>
        ///     "verification_token": "123",<br/>
        ///     "event_type": "delete",<br/>
        ///     "data_type": "tag"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.WebhookSubscriptionModel> UpdateWebhookSubscriptionV2WebhookSubscriptionIdPutAsync(
            string id,

            global::Oura.UpdateWebhookSubscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Webhook Subscription
        /// </summary>
        /// <param name="id"></param>
        /// <param name="verificationToken"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="eventType"></param>
        /// <param name="dataType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Oura.WebhookSubscriptionModel> UpdateWebhookSubscriptionV2WebhookSubscriptionIdPutAsync(
            string id,
            string verificationToken,
            string? callbackUrl = default,
            global::Oura.WebhookOperation? eventType = default,
            global::Oura.ExtApiV2DataType? dataType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}