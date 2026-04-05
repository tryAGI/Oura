
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining daily stress.
    /// </summary>
    public sealed partial class DailyStressModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Day that the daily stress belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// Time (in seconds) spent in a high stress zone (top quartile data)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stress_high")]
        public int? StressHigh { get; set; }

        /// <summary>
        /// Time (in seconds) spent in a high recovery zone (bottom quartile data)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recovery_high")]
        public int? RecoveryHigh { get; set; }

        /// <summary>
        /// Stress summary of full day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.DailyStressSummaryJsonConverter))]
        public global::Oura.DailyStressSummary? DaySummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyStressModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="day">
        /// Day that the daily stress belongs to.
        /// </param>
        /// <param name="stressHigh">
        /// Time (in seconds) spent in a high stress zone (top quartile data)
        /// </param>
        /// <param name="recoveryHigh">
        /// Time (in seconds) spent in a high recovery zone (bottom quartile data)
        /// </param>
        /// <param name="daySummary">
        /// Stress summary of full day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyStressModel(
            string id,
            global::System.DateTime day,
            int? stressHigh,
            int? recoveryHigh,
            global::Oura.DailyStressSummary? daySummary)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Day = day;
            this.StressHigh = stressHigh;
            this.RecoveryHigh = recoveryHigh;
            this.DaySummary = daySummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyStressModel" /> class.
        /// </summary>
        public DailyStressModel()
        {
        }
    }
}