
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining a ring battery level event.
    /// </summary>
    public sealed partial class PublicRingBatteryLevelRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Timestamp of the discrete sample as unix time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TimestampUnix { get; set; }

        /// <summary>
        /// Flag indicating if the ring was charging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charging")]
        public bool? Charging { get; set; }

        /// <summary>
        /// Flag indicating if the ring was in charger.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_charger")]
        public bool? InCharger { get; set; }

        /// <summary>
        /// Ring battery level percentage. These values are within [0, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Level { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicRingBatteryLevelRow" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="timestampUnix">
        /// Timestamp of the discrete sample as unix time in milliseconds.
        /// </param>
        /// <param name="level">
        /// Ring battery level percentage. These values are within [0, 100].
        /// </param>
        /// <param name="charging">
        /// Flag indicating if the ring was charging.
        /// </param>
        /// <param name="inCharger">
        /// Flag indicating if the ring was in charger.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicRingBatteryLevelRow(
            string timestamp,
            long timestampUnix,
            int level,
            bool? charging,
            bool? inCharger)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.TimestampUnix = timestampUnix;
            this.Charging = charging;
            this.InCharger = inCharger;
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicRingBatteryLevelRow" /> class.
        /// </summary>
        public PublicRingBatteryLevelRow()
        {
        }

    }
}