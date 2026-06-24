
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining a recorded sample.
    /// </summary>
    public sealed partial class PublicSample
    {
        /// <summary>
        /// Interval in seconds between the sampled items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Interval { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Items { get; set; }

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
        /// Initializes a new instance of the <see cref="PublicSample" /> class.
        /// </summary>
        /// <param name="interval">
        /// Interval in seconds between the sampled items.
        /// </param>
        /// <param name="items"></param>
        /// <param name="timestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicSample(
            double interval,
            global::System.Collections.Generic.IList<double> items,
            string timestamp)
        {
            this.Interval = interval;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSample" /> class.
        /// </summary>
        public PublicSample()
        {
        }

    }
}