
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailyResilienceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Day when the resilience record was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.ResilienceContributors Contributors { get; set; }

        /// <summary>
        /// Possible long term resilience level values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.LongTermResilienceLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.LongTermResilienceLevel Level { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyResilienceModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="day">
        /// Day when the resilience record was recorded.
        /// </param>
        /// <param name="contributors"></param>
        /// <param name="level">
        /// Possible long term resilience level values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyResilienceModel(
            string id,
            global::System.DateTime day,
            global::Oura.ResilienceContributors contributors,
            global::Oura.LongTermResilienceLevel level)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Day = day;
            this.Contributors = contributors ?? throw new global::System.ArgumentNullException(nameof(contributors));
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyResilienceModel" /> class.
        /// </summary>
        public DailyResilienceModel()
        {
        }

    }
}