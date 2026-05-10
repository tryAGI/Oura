
#nullable enable

namespace Oura
{
    /// <summary>
    /// Daily stress.
    /// </summary>
    public sealed partial class PublicDailyStress
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
        /// Stress summary of full day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.PublicDailyStressSummaryJsonConverter))]
        public global::Oura.PublicDailyStressSummary? DaySummary { get; set; }

        /// <summary>
        /// Time spent in a high recovery zone (bottom quartile data) in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recovery_high")]
        public int? RecoveryHigh { get; set; }

        /// <summary>
        /// Time spent in a high stress zone (top quartile of data) in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stress_high")]
        public int? StressHigh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailyStress" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
        /// <param name="meta">
        /// Object defining the metadata of a collection model instance.
        /// </param>
        /// <param name="day"></param>
        /// <param name="daySummary">
        /// Stress summary of full day.
        /// </param>
        /// <param name="recoveryHigh">
        /// Time spent in a high recovery zone (bottom quartile data) in seconds.
        /// </param>
        /// <param name="stressHigh">
        /// Time spent in a high stress zone (top quartile of data) in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicDailyStress(
            string id,
            global::Oura.Metadata meta,
            string day,
            global::Oura.PublicDailyStressSummary? daySummary,
            int? recoveryHigh,
            int? stressHigh)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.DaySummary = daySummary;
            this.RecoveryHigh = recoveryHigh;
            this.StressHigh = stressHigh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailyStress" /> class.
        /// </summary>
        public PublicDailyStress()
        {
        }

    }
}