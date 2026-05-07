
#nullable enable

namespace Oura
{
    /// <summary>
    /// Daily SpO2 (Oxygen saturation).
    /// </summary>
    public sealed partial class PublicDailySpO2
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
        /// Breathing Disturbance Index (BDI) calculated using detected SpO2 drops from timeseries. Values should be in range [0, 100]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breathing_disturbance_index")]
        public int? BreathingDisturbanceIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        /// The daily SpO2 percentage value aggregates. Sourced from SpO2 percentage timeseries values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spo2_percentage")]
        public global::Oura.PublicSpo2AggregatedValues? Spo2Percentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailySpO2" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
        /// <param name="meta">
        /// Object defining the metadata of a collection model instance.
        /// </param>
        /// <param name="day"></param>
        /// <param name="breathingDisturbanceIndex">
        /// Breathing Disturbance Index (BDI) calculated using detected SpO2 drops from timeseries. Values should be in range [0, 100]
        /// </param>
        /// <param name="spo2Percentage">
        /// The daily SpO2 percentage value aggregates. Sourced from SpO2 percentage timeseries values.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicDailySpO2(
            string id,
            global::Oura.Metadata meta,
            string day,
            int? breathingDisturbanceIndex,
            global::Oura.PublicSpo2AggregatedValues? spo2Percentage)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.BreathingDisturbanceIndex = breathingDisturbanceIndex;
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.Spo2Percentage = spo2Percentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailySpO2" /> class.
        /// </summary>
        public PublicDailySpO2()
        {
        }
    }
}