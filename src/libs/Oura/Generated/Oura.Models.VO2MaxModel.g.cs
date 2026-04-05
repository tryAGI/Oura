
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VO2MaxModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Day that the estimate belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// VO2 max value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vo2_max")]
        public double? Vo2Max { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VO2MaxModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="day">
        /// Day that the estimate belongs to.
        /// </param>
        /// <param name="timestamp"></param>
        /// <param name="vo2Max">
        /// VO2 max value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VO2MaxModel(
            string id,
            global::System.DateTime day,
            string timestamp,
            double? vo2Max)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Day = day;
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Vo2Max = vo2Max;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VO2MaxModel" /> class.
        /// </summary>
        public VO2MaxModel()
        {
        }
    }
}