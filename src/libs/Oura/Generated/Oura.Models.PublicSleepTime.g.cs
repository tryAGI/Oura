
#nullable enable

namespace Oura
{
    /// <summary>
    /// Suggested bedtime for the user.
    /// </summary>
    public sealed partial class PublicSleepTime
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        /// Optimal bedtime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimal_bedtime")]
        public global::Oura.PublicSleepTimeWindow? OptimalBedtime { get; set; }

        /// <summary>
        /// Recommended action for bedtime.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.PublicSleepTimeRecommendationJsonConverter))]
        public global::Oura.PublicSleepTimeRecommendation? Recommendation { get; set; }

        /// <summary>
        /// Sleep time status; used to inform sleep time recommendation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.PublicSleepTimeStatusJsonConverter))]
        public global::Oura.PublicSleepTimeStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSleepTime" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
        /// <param name="meta">
        /// Object defining the metadata of a collection model instance.
        /// </param>
        /// <param name="day"></param>
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
        public PublicSleepTime(
            string id,
            global::Oura.Metadata meta,
            string day,
            global::Oura.PublicSleepTimeWindow? optimalBedtime,
            global::Oura.PublicSleepTimeRecommendation? recommendation,
            global::Oura.PublicSleepTimeStatus? status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.OptimalBedtime = optimalBedtime;
            this.Recommendation = recommendation;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSleepTime" /> class.
        /// </summary>
        public PublicSleepTime()
        {
        }
    }
}