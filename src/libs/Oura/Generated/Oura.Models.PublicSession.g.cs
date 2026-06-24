
#nullable enable

namespace Oura
{
    /// <summary>
    /// Public model defining a recorded Session.
    /// </summary>
    public sealed partial class PublicSession
    {
        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_datetime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndDatetime { get; set; }

        /// <summary>
        /// Recorded heart rate samples during the Moment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate")]
        public global::Oura.PublicSample? HeartRate { get; set; }

        /// <summary>
        /// Recorded heart rate variability samples during the Moment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_variability")]
        public global::Oura.PublicSample? HeartRateVariability { get; set; }

        /// <summary>
        /// User-selected mood for the Moment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mood")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.PublicMomentMoodJsonConverter))]
        public global::Oura.PublicMomentMood? Mood { get; set; }

        /// <summary>
        /// Recorded motion count samples during the Moment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motion_count")]
        public global::Oura.PublicSample? MotionCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_datetime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartDatetime { get; set; }

        /// <summary>
        /// Possible Moment types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.PublicMomentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.PublicMomentType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSession" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
        /// <param name="day"></param>
        /// <param name="endDatetime"></param>
        /// <param name="startDatetime"></param>
        /// <param name="type">
        /// Possible Moment types.
        /// </param>
        /// <param name="heartRate">
        /// Recorded heart rate samples during the Moment.
        /// </param>
        /// <param name="heartRateVariability">
        /// Recorded heart rate variability samples during the Moment.
        /// </param>
        /// <param name="mood">
        /// User-selected mood for the Moment.
        /// </param>
        /// <param name="motionCount">
        /// Recorded motion count samples during the Moment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicSession(
            string id,
            string day,
            string endDatetime,
            string startDatetime,
            global::Oura.PublicMomentType type,
            global::Oura.PublicSample? heartRate,
            global::Oura.PublicSample? heartRateVariability,
            global::Oura.PublicMomentMood? mood,
            global::Oura.PublicSample? motionCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.EndDatetime = endDatetime ?? throw new global::System.ArgumentNullException(nameof(endDatetime));
            this.HeartRate = heartRate;
            this.HeartRateVariability = heartRateVariability;
            this.Mood = mood;
            this.MotionCount = motionCount;
            this.StartDatetime = startDatetime ?? throw new global::System.ArgumentNullException(nameof(startDatetime));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSession" /> class.
        /// </summary>
        public PublicSession()
        {
        }

    }
}