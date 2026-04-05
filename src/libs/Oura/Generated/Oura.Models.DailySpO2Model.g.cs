
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailySpO2Model
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// The SpO2 percentage value aggregated over a single day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spo2_percentage")]
        public global::Oura.DailySpO2AggregatedValuesModel? Spo2Percentage { get; set; }

        /// <summary>
        /// Breathing Disturbance Index (BDI) calculated using detected SpO2 drops from timeseries. Values should be in range [0, 100]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breathing_disturbance_index")]
        public int? BreathingDisturbanceIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailySpO2Model" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="day"></param>
        /// <param name="spo2Percentage">
        /// The SpO2 percentage value aggregated over a single day.
        /// </param>
        /// <param name="breathingDisturbanceIndex">
        /// Breathing Disturbance Index (BDI) calculated using detected SpO2 drops from timeseries. Values should be in range [0, 100]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailySpO2Model(
            string id,
            global::System.DateTime day,
            global::Oura.DailySpO2AggregatedValuesModel? spo2Percentage,
            int? breathingDisturbanceIndex)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Day = day;
            this.Spo2Percentage = spo2Percentage;
            this.BreathingDisturbanceIndex = breathingDisturbanceIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailySpO2Model" /> class.
        /// </summary>
        public DailySpO2Model()
        {
        }
    }
}