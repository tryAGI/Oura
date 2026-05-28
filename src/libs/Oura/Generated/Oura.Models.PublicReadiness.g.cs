
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining readiness.
    /// </summary>
    public sealed partial class PublicReadiness
    {
        /// <summary>
        /// Object defining readiness score contributors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.PublicReadinessContributors Contributors { get; set; }

        /// <summary>
        /// Readiness score in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

        /// <summary>
        /// Temperature deviation in degrees Celsius.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature_deviation")]
        public double? TemperatureDeviation { get; set; }

        /// <summary>
        /// Temperature trend deviation in degrees Celsius.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature_trend_deviation")]
        public double? TemperatureTrendDeviation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicReadiness" /> class.
        /// </summary>
        /// <param name="contributors">
        /// Object defining readiness score contributors.
        /// </param>
        /// <param name="score">
        /// Readiness score in range [1, 100].
        /// </param>
        /// <param name="temperatureDeviation">
        /// Temperature deviation in degrees Celsius.
        /// </param>
        /// <param name="temperatureTrendDeviation">
        /// Temperature trend deviation in degrees Celsius.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicReadiness(
            global::Oura.PublicReadinessContributors contributors,
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
        /// Initializes a new instance of the <see cref="PublicReadiness" /> class.
        /// </summary>
        public PublicReadiness()
        {
        }

    }
}