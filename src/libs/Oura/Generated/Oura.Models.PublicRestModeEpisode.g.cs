
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining a public Rest Mode episode.
    /// </summary>
    public sealed partial class PublicRestModeEpisode
    {
        /// <summary>
        /// Tags selected for the episode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

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
        /// Initializes a new instance of the <see cref="PublicRestModeEpisode" /> class.
        /// </summary>
        /// <param name="tags">
        /// Tags selected for the episode.
        /// </param>
        /// <param name="timestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicRestModeEpisode(
            global::System.Collections.Generic.IList<string> tags,
            string timestamp)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicRestModeEpisode" /> class.
        /// </summary>
        public PublicRestModeEpisode()
        {
        }

    }
}