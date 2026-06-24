
#nullable enable

namespace Oura
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResilienceContributors
    {
        /// <summary>
        /// Sleep recovery contributor to the resilience score. Range: [0, 100]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleep_recovery")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SleepRecovery { get; set; }

        /// <summary>
        /// Daytime recovery contributor to the resilience score. Range: [0, 100]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daytime_recovery")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DaytimeRecovery { get; set; }

        /// <summary>
        /// Stress contributor to the resilience score. Range: [0, 100]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Stress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResilienceContributors" /> class.
        /// </summary>
        /// <param name="sleepRecovery">
        /// Sleep recovery contributor to the resilience score. Range: [0, 100]
        /// </param>
        /// <param name="daytimeRecovery">
        /// Daytime recovery contributor to the resilience score. Range: [0, 100]
        /// </param>
        /// <param name="stress">
        /// Stress contributor to the resilience score. Range: [0, 100]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResilienceContributors(
            double sleepRecovery,
            double daytimeRecovery,
            double stress)
        {
            this.SleepRecovery = sleepRecovery;
            this.DaytimeRecovery = daytimeRecovery;
            this.Stress = stress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResilienceContributors" /> class.
        /// </summary>
        public ResilienceContributors()
        {
        }

    }
}