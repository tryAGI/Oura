
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining sleep score contributors.
    /// </summary>
    public sealed partial class PublicSleepContributors
    {
        /// <summary>
        /// Contribution of deep sleep in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deep_sleep")]
        public int? DeepSleep { get; set; }

        /// <summary>
        /// Contribution of sleep efficiency in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("efficiency")]
        public int? Efficiency { get; set; }

        /// <summary>
        /// Contribution of sleep latency in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public int? Latency { get; set; }

        /// <summary>
        /// Contribution of REM sleep in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rem_sleep")]
        public int? RemSleep { get; set; }

        /// <summary>
        /// Contribution of sleep restfulness in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restfulness")]
        public int? Restfulness { get; set; }

        /// <summary>
        /// Contribution of sleep timing in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timing")]
        public int? Timing { get; set; }

        /// <summary>
        /// Contribution of total sleep in range [1, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_sleep")]
        public int? TotalSleep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSleepContributors" /> class.
        /// </summary>
        /// <param name="deepSleep">
        /// Contribution of deep sleep in range [1, 100].
        /// </param>
        /// <param name="efficiency">
        /// Contribution of sleep efficiency in range [1, 100].
        /// </param>
        /// <param name="latency">
        /// Contribution of sleep latency in range [1, 100].
        /// </param>
        /// <param name="remSleep">
        /// Contribution of REM sleep in range [1, 100].
        /// </param>
        /// <param name="restfulness">
        /// Contribution of sleep restfulness in range [1, 100].
        /// </param>
        /// <param name="timing">
        /// Contribution of sleep timing in range [1, 100].
        /// </param>
        /// <param name="totalSleep">
        /// Contribution of total sleep in range [1, 100].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicSleepContributors(
            int? deepSleep,
            int? efficiency,
            int? latency,
            int? remSleep,
            int? restfulness,
            int? timing,
            int? totalSleep)
        {
            this.DeepSleep = deepSleep;
            this.Efficiency = efficiency;
            this.Latency = latency;
            this.RemSleep = remSleep;
            this.Restfulness = restfulness;
            this.Timing = timing;
            this.TotalSleep = totalSleep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSleepContributors" /> class.
        /// </summary>
        public PublicSleepContributors()
        {
        }
    }
}