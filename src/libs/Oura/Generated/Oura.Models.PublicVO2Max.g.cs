
#nullable enable

namespace Oura
{
    /// <summary>
    /// VO2Max estimate.
    /// </summary>
    public sealed partial class PublicVO2Max
    {
        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object defining the metadata of a collection model instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.Metadata Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// VO2 max value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vo2_max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Vo2Max { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicVO2Max" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
        /// <param name="meta">
        /// Object defining the metadata of a collection model instance.
        /// </param>
        /// <param name="day"></param>
        /// <param name="timestamp"></param>
        /// <param name="vo2Max">
        /// VO2 max value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicVO2Max(
            string id,
            global::Oura.Metadata meta,
            string day,
            string timestamp,
            int vo2Max)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Vo2Max = vo2Max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicVO2Max" /> class.
        /// </summary>
        public PublicVO2Max()
        {
        }

    }
}