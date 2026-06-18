
#nullable enable

namespace Oura
{
    /// <summary>
    /// Public object defining daily readiness.
    /// </summary>
    public sealed partial class PublicDailyReadiness
    {
        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object defining readiness score contributors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.PublicReadinessContributors Contributors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        /// Daily readiness score.
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailyReadiness" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
        /// <param name="contributors">
        /// Object defining readiness score contributors.
        /// </param>
        /// <param name="day"></param>
        /// <param name="timestamp"></param>
        /// <param name="score">
        /// Daily readiness score.
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
        public PublicDailyReadiness(
            string id,
            global::Oura.PublicReadinessContributors contributors,
            string day,
            string timestamp,
            int? score,
            double? temperatureDeviation,
            double? temperatureTrendDeviation)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Contributors = contributors ?? throw new global::System.ArgumentNullException(nameof(contributors));
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.Score = score;
            this.TemperatureDeviation = temperatureDeviation;
            this.TemperatureTrendDeviation = temperatureTrendDeviation;
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailyReadiness" /> class.
        /// </summary>
        public PublicDailyReadiness()
        {
        }

    }
}