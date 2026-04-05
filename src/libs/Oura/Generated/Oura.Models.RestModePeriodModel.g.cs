
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object contains information about rest mode episode.
    /// </summary>
    public sealed partial class RestModePeriodModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// End date of rest mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_day")]
        public global::System.DateTime? EndDay { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Oura.RestModeEpisode> Episodes { get; set; }

        /// <summary>
        /// Start date of rest mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDay { get; set; }

        /// <summary>
        /// Timestamp when rest mode started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestModePeriodModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="episodes">
        /// Collection of episodes during rest mode, consisting of tags.
        /// </param>
        /// <param name="startDay">
        /// Start date of rest mode.
        /// </param>
        /// <param name="endDay">
        /// End date of rest mode.
        /// </param>
        /// <param name="endTime">
        /// Timestamp when rest mode ended.
        /// </param>
        /// <param name="startTime">
        /// Timestamp when rest mode started.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestModePeriodModel(
            string id,
            global::System.Collections.Generic.IList<global::Oura.RestModeEpisode> episodes,
            global::System.DateTime startDay,
            global::System.DateTime? endDay,
            string? endTime,
            string? startTime)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EndDay = endDay;
            this.EndTime = endTime;
            this.Episodes = episodes ?? throw new global::System.ArgumentNullException(nameof(episodes));
            this.StartDay = startDay;
            this.StartTime = startTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestModePeriodModel" /> class.
        /// </summary>
        public RestModePeriodModel()
        {
        }
    }
}