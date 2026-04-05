
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultiDocumentResponseSleepModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Oura.SleepModel> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_token")]
        public string? NextToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiDocumentResponseSleepModel" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="nextToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiDocumentResponseSleepModel(
            global::System.Collections.Generic.IList<global::Oura.SleepModel> data,
            string? nextToken)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextToken = nextToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiDocumentResponseSleepModel" /> class.
        /// </summary>
        public MultiDocumentResponseSleepModel()
        {
        }
    }
}