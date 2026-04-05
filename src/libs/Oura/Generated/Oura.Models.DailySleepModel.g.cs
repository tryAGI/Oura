
#nullable enable

namespace Oura
{
    /// <summary>
    /// Object defining daily sleep.
    /// </summary>
    public sealed partial class DailySleepModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object defining sleep score contributors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contributors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Oura.SleepContributors Contributors { get; set; }

        /// <summary>
        /// Day that the daily sleep belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Day { get; set; }

        /// <summary>
        /// Daily sleep score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public int? Score { get; set; }

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
        /// Initializes a new instance of the <see cref="DailySleepModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="contributors">
        /// Object defining sleep score contributors.
        /// </param>
        /// <param name="day">
        /// Day that the daily sleep belongs to.
        /// </param>
        /// <param name="timestamp"></param>
        /// <param name="score">
        /// Daily sleep score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailySleepModel(
            string id,
            global::Oura.SleepContributors contributors,
            global::System.DateTime day,
            string timestamp,
            int? score)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Contributors = contributors ?? throw new global::System.ArgumentNullException(nameof(contributors));
            this.Day = day;
            this.Score = score;
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailySleepModel" /> class.
        /// </summary>
        public DailySleepModel()
        {
        }
    }
}