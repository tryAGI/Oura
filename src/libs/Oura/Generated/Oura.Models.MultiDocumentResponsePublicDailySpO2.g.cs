
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultiDocumentResponsePublicDailySpO2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Oura.PublicDailySpO2> Data { get; set; }

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
        /// Initializes a new instance of the <see cref="MultiDocumentResponsePublicDailySpO2" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="nextToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiDocumentResponsePublicDailySpO2(
            global::System.Collections.Generic.IList<global::Oura.PublicDailySpO2> data,
            string? nextToken)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextToken = nextToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiDocumentResponsePublicDailySpO2" /> class.
        /// </summary>
        public MultiDocumentResponsePublicDailySpO2()
        {
        }

    }
}