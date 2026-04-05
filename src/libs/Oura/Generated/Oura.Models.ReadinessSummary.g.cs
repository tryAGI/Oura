
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadinessSummary
    {
        /// <summary>
        /// Object defining readiness score contributors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.ReadinessContributors Contributors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature_deviation")]
        public double? TemperatureDeviation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature_trend_deviation")]
        public double? TemperatureTrendDeviation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadinessSummary" /> class.
        /// </summary>
        /// <param name="contributors">
        /// Object defining readiness score contributors.
        /// </param>
        /// <param name="score"></param>
        /// <param name="temperatureDeviation"></param>
        /// <param name="temperatureTrendDeviation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadinessSummary(
            global::Oura.ReadinessContributors contributors,
            int? score,
            double? temperatureDeviation,
            double? temperatureTrendDeviation)
        {
            this.Contributors = contributors ?? throw new global::System.ArgumentNullException(nameof(contributors));
            this.Score = score;
            this.TemperatureDeviation = temperatureDeviation;
            this.TemperatureTrendDeviation = temperatureTrendDeviation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadinessSummary" /> class.
        /// </summary>
        public ReadinessSummary()
        {
        }
    }
}