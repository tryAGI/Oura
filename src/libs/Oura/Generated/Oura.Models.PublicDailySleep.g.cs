
#nullable enable

namespace Oura
{
    /// <summary>
    /// Public object defining daily sleep.
    /// </summary>
    public sealed partial class PublicDailySleep
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
        /// Object defining sleep score contributors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.PublicSleepContributors Contributors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        /// Daily sleep score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailySleep" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
        /// <param name="meta">
        /// Object defining the metadata of a collection model instance.
        /// </param>
        /// <param name="contributors">
        /// Object defining sleep score contributors.
        /// </param>
        /// <param name="day"></param>
        /// <param name="timestamp"></param>
        /// <param name="score">
        /// Daily sleep score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicDailySleep(
            string id,
            global::Oura.Metadata meta,
            global::Oura.PublicSleepContributors contributors,
            string day,
            string timestamp,
            int? score)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Contributors = contributors ?? throw new global::System.ArgumentNullException(nameof(contributors));
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.Score = score;
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailySleep" /> class.
        /// </summary>
        public PublicDailySleep()
        {
        }

    }
}