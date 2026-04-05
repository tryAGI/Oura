
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object contains suggested bedtime for the user.
    /// </summary>
    public sealed partial class SleepTimeModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Corresponding day for the sleep time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// Optimal bedtime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimal_bedtime")]
        public global::Oura.SleepTimeWindow? OptimalBedtime { get; set; }

        /// <summary>
        /// Recommended action for bedtime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.SleepTimeRecommendationJsonConverter))]
        public global::Oura.SleepTimeRecommendation? Recommendation { get; set; }

        /// <summary>
        /// Sleep time status; used to inform sleep time recommendation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.SleepTimeStatusJsonConverter))]
        public global::Oura.SleepTimeStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepTimeModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="day">
        /// Corresponding day for the sleep time.
        /// </param>
        /// <param name="optimalBedtime">
        /// Optimal bedtime.
        /// </param>
        /// <param name="recommendation">
        /// Recommended action for bedtime.
        /// </param>
        /// <param name="status">
        /// Sleep time status; used to inform sleep time recommendation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SleepTimeModel(
            string id,
            global::System.DateTime day,
            global::Oura.SleepTimeWindow? optimalBedtime,
            global::Oura.SleepTimeRecommendation? recommendation,
            global::Oura.SleepTimeStatus? status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Day = day;
            this.OptimalBedtime = optimalBedtime;
            this.Recommendation = recommendation;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SleepTimeModel" /> class.
        /// </summary>
        public SleepTimeModel()
        {
        }
    }
}