
#nullable enable

namespace Oura
{
    /// <summary>
    /// Daily Cardiovascular Age.
    /// </summary>
    public sealed partial class PublicDailyCardiovascularAge
    {
        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Day { get; set; }

        /// <summary>
        /// Pulse wave velocity (m/s), derived from vascular age, with possible offset added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulse_wave_velocity")]
        public double? PulseWaveVelocity { get; set; }

        /// <summary>
        /// Predicted vascular age in range [18, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vascular_age")]
        public int? VascularAge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailyCardiovascularAge" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
        /// <param name="day"></param>
        /// <param name="pulseWaveVelocity">
        /// Pulse wave velocity (m/s), derived from vascular age, with possible offset added.
        /// </param>
        /// <param name="vascularAge">
        /// Predicted vascular age in range [18, 100].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicDailyCardiovascularAge(
            string id,
            string day,
            double? pulseWaveVelocity,
            int? vascularAge)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Day = day ?? throw new global::System.ArgumentNullException(nameof(day));
            this.PulseWaveVelocity = pulseWaveVelocity;
            this.VascularAge = vascularAge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicDailyCardiovascularAge" /> class.
        /// </summary>
        public PublicDailyCardiovascularAge()
        {
        }

    }
}