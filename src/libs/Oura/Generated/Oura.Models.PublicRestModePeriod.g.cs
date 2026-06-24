
#nullable enable

namespace Oura
{
    /// <summary>
    /// Rest mode episode information.
    /// </summary>
    public sealed partial class PublicRestModePeriod
    {
        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// End date of rest mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_day")]
        public string? EndDay { get; set; }

        /// <summary>
        /// Timestamp when rest mode ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Collection of episodes during rest mode, consisting of tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("episodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Oura.PublicRestModeEpisode> Episodes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartDay { get; set; }

        /// <summary>
        /// Timestamp when rest mode ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicRestModePeriod" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
        /// <param name="episodes">
        /// Collection of episodes during rest mode, consisting of tags.
        /// </param>
        /// <param name="startDay"></param>
        /// <param name="endDay">
        /// End date of rest mode.
        /// </param>
        /// <param name="endTime">
        /// Timestamp when rest mode ended.
        /// </param>
        /// <param name="startTime">
        /// Timestamp when rest mode ended.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicRestModePeriod(
            string id,
            global::System.Collections.Generic.IList<global::Oura.PublicRestModeEpisode> episodes,
            string startDay,
            string? endDay,
            string? endTime,
            string? startTime)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EndDay = endDay;
            this.EndTime = endTime;
            this.Episodes = episodes ?? throw new global::System.ArgumentNullException(nameof(episodes));
            this.StartDay = startDay ?? throw new global::System.ArgumentNullException(nameof(startDay));
            this.StartTime = startTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicRestModePeriod" /> class.
        /// </summary>
        public PublicRestModePeriod()
        {
        }

    }
}