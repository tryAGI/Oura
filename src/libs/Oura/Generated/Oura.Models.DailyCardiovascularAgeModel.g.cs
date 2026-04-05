
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailyCardiovascularAgeModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// 'Predicted vascular age in range [18, 100].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vascular_age")]
        public int? VascularAge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyCardiovascularAgeModel" /> class.
        /// </summary>
        /// <param name="day"></param>
        /// <param name="vascularAge">
        /// 'Predicted vascular age in range [18, 100].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyCardiovascularAgeModel(
            global::System.DateTime day,
            int? vascularAge)
        {
            this.Day = day;
            this.VascularAge = vascularAge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyCardiovascularAgeModel" /> class.
        /// </summary>
        public DailyCardiovascularAgeModel()
        {
        }
    }
}