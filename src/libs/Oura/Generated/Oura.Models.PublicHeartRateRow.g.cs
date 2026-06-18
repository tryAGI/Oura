
#nullable enable

namespace Oura
{
    /// <summary>
    /// Heart rate sample
    /// </summary>
    public sealed partial class PublicHeartRateRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Timestamp of the discrete sample as unix time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TimestampUnix { get; set; }

        /// <summary>
        /// Heart rate as beats per minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Bpm { get; set; }

        /// <summary>
        /// Possible heart rate sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.PublicHeartRateSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.PublicHeartRateSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicHeartRateRow" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="timestampUnix">
        /// Timestamp of the discrete sample as unix time in milliseconds.
        /// </param>
        /// <param name="bpm">
        /// Heart rate as beats per minute.
        /// </param>
        /// <param name="source">
        /// Possible heart rate sources.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicHeartRateRow(
            string timestamp,
            long timestampUnix,
            int bpm,
            global::Oura.PublicHeartRateSource source)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.TimestampUnix = timestampUnix;
            this.Bpm = bpm;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicHeartRateRow" /> class.
        /// </summary>
        public PublicHeartRateRow()
        {
        }

    }
}