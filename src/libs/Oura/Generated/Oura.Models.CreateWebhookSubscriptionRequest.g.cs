
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebhookSubscriptionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VerificationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.WebhookOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.WebhookOperation EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.ExtApiV2DataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.ExtApiV2DataType DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="callbackUrl"></param>
        /// <param name="verificationToken"></param>
        /// <param name="eventType"></param>
        /// <param name="dataType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebhookSubscriptionRequest(
            string callbackUrl,
            string verificationToken,
            global::Oura.WebhookOperation eventType,
            global::Oura.ExtApiV2DataType dataType)
        {
            this.CallbackUrl = callbackUrl ?? throw new global::System.ArgumentNullException(nameof(callbackUrl));
            this.VerificationToken = verificationToken ?? throw new global::System.ArgumentNullException(nameof(verificationToken));
            this.EventType = eventType;
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookSubscriptionRequest" /> class.
        /// </summary>
        public CreateWebhookSubscriptionRequest()
        {
        }

    }
}