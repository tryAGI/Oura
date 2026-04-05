#nullable enable

namespace Oura
{
    public partial interface IWebhookSubscriptionRoutesClient
    {
        /// <summary>
        /// Create Webhook Subscription
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Oura.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST 'https://api.ouraring.com/v2/webhook/subscription' --header 'x-client-id: client-id' --header 'x-client-secret: client-secret' --header 'Content-Type: application/json' --data-raw '{<br/>
        ///     "callback_url": "https://my-api/oura/tag/delete",<br/>
        ///     "verification_token": "123",<br/>
        ///     "event_type": "delete",<br/>
        ///     "data_type": "tag"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Oura.WebhookSubscriptionModel> CreateWebhookSubscriptionV2WebhookSubscriptionPostAsync(

            global::Oura.CreateWebhookSubscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Webhook Subscription
        /// </summary>
        /// <param name="callbackUrl"></param>
        /// <param name="verificationToken"></param>
        /// <param name="eventType"></param>
        /// <param name="dataType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Oura.WebhookSubscriptionModel> CreateWebhookSubscriptionV2WebhookSubscriptionPostAsync(
            string callbackUrl,
            string verificationToken,
            global::Oura.WebhookOperation eventType,
            global::Oura.ExtApiV2DataType dataType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}