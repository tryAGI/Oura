
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining public spo2 aggregated values.
    /// </summary>
    public sealed partial class PublicSpo2AggregatedValues
    {
        /// <summary>
        /// Average of spo2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Average { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSpo2AggregatedValues" /> class.
        /// </summary>
        /// <param name="average">
        /// Average of spo2.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicSpo2AggregatedValues(
            double average)
        {
            this.Average = average;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSpo2AggregatedValues" /> class.
        /// </summary>
        public PublicSpo2AggregatedValues()
        {
        }

    }
}