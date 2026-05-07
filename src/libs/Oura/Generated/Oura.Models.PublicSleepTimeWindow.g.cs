
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining sleep time window
    /// </summary>
    public sealed partial class PublicSleepTimeWindow
    {
        /// <summary>
        /// Timezone offset in second from GMT of the day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_tz")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DayTz { get; set; }

        /// <summary>
        /// End offset from midnight in second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndOffset { get; set; }

        /// <summary>
        /// Start offset from midnight in second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartOffset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSleepTimeWindow" /> class.
        /// </summary>
        /// <param name="dayTz">
        /// Timezone offset in second from GMT of the day
        /// </param>
        /// <param name="endOffset">
        /// End offset from midnight in second
        /// </param>
        /// <param name="startOffset">
        /// Start offset from midnight in second
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicSleepTimeWindow(
            int dayTz,
            int endOffset,
            int startOffset)
        {
            this.DayTz = dayTz;
            this.EndOffset = endOffset;
            this.StartOffset = startOffset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSleepTimeWindow" /> class.
        /// </summary>
        public PublicSleepTimeWindow()
        {
        }
    }
}