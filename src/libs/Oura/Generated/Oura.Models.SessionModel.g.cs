
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The date when the session occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_datetime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartDatetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_datetime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndDatetime { get; set; }

        /// <summary>
        /// Possible Moment types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.MomentTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.MomentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate")]
        public global::Oura.SampleModel? HeartRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("heart_rate_variability")]
        public global::Oura.SampleModel? HeartRateVariability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mood")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.MomentMoodJsonConverter))]
        public global::Oura.MomentMood? Mood { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("motion_count")]
        public global::Oura.SampleModel? MotionCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="day">
        /// The date when the session occurred.
        /// </param>
        /// <param name="startDatetime"></param>
        /// <param name="endDatetime"></param>
        /// <param name="type">
        /// Possible Moment types.
        /// </param>
        /// <param name="heartRate"></param>
        /// <param name="heartRateVariability"></param>
        /// <param name="mood"></param>
        /// <param name="motionCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionModel(
            string id,
            global::System.DateTime day,
            string startDatetime,
            string endDatetime,
            global::Oura.MomentType type,
            global::Oura.SampleModel? heartRate,
            global::Oura.SampleModel? heartRateVariability,
            global::Oura.MomentMood? mood,
            global::Oura.SampleModel? motionCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Day = day;
            this.StartDatetime = startDatetime ?? throw new global::System.ArgumentNullException(nameof(startDatetime));
            this.EndDatetime = endDatetime ?? throw new global::System.ArgumentNullException(nameof(endDatetime));
            this.Type = type;
            this.HeartRate = heartRate;
            this.HeartRateVariability = heartRateVariability;
            this.Mood = mood;
            this.MotionCount = motionCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionModel" /> class.
        /// </summary>
        public SessionModel()
        {
        }
    }
}