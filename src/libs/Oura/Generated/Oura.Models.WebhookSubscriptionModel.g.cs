
#nullable enable

namespace Oura
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookSubscriptionModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallbackUrl { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpirationTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscriptionModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="eventType"></param>
        /// <param name="dataType"></param>
        /// <param name="expirationTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookSubscriptionModel(
            string id,
            string callbackUrl,
            global::Oura.WebhookOperation eventType,
            global::Oura.ExtApiV2DataType dataType,
            global::System.DateTime expirationTime)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CallbackUrl = callbackUrl ?? throw new global::System.ArgumentNullException(nameof(callbackUrl));
            this.EventType = eventType;
            this.DataType = dataType;
            this.ExpirationTime = expirationTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscriptionModel" /> class.
        /// </summary>
        public WebhookSubscriptionModel()
        {
        }

    }
}