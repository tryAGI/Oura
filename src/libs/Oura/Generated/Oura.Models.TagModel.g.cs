
#nullable enable

namespace Oura
{
    /// <summary>
    /// A TagModel maps to an ASSANote. An ASSANote in ExtAPIV2 is called a Tag<br/>
    /// A TagModel will be populated by data from an ASSANote<br/>
    /// The fields in the TagModel map to fields in an ASSANote
    /// </summary>
    public sealed partial class TagModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Day that the note belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// Textual contents of the note.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Selected tags for the tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="day">
        /// Day that the note belongs to.
        /// </param>
        /// <param name="timestamp"></param>
        /// <param name="tags">
        /// Selected tags for the tag.
        /// </param>
        /// <param name="text">
        /// Textual contents of the note.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TagModel(
            string id,
            global::System.DateTime day,
            string timestamp,
            global::System.Collections.Generic.IList<string> tags,
            string? text)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Day = day;
            this.Text = text;
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagModel" /> class.
        /// </summary>
        public TagModel()
        {
        }

    }
}