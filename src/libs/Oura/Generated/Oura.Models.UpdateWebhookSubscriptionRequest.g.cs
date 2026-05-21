
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWebhookSubscriptionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VerificationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.WebhookOperationJsonConverter))]
        public global::Oura.WebhookOperation? EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.ExtApiV2DataTypeJsonConverter))]
        public global::Oura.ExtApiV2DataType? DataType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="verificationToken"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="eventType"></param>
        /// <param name="dataType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWebhookSubscriptionRequest(
            string verificationToken,
            string? callbackUrl,
            global::Oura.WebhookOperation? eventType,
            global::Oura.ExtApiV2DataType? dataType)
        {
            this.VerificationToken = verificationToken ?? throw new global::System.ArgumentNullException(nameof(verificationToken));
            this.CallbackUrl = callbackUrl;
            this.EventType = eventType;
            this.DataType = dataType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookSubscriptionRequest" /> class.
        /// </summary>
        public UpdateWebhookSubscriptionRequest()
        {
        }

    }
}