
#nullable enable

namespace Oura
{
    /// <summary>
    /// An EnhancedTagModel maps an ASSATag. An ASSATag in ExtAPIV2 is called a EnhancedTag<br/>
    /// An EnhancedTagModel will be populated by data from an ASSATag<br/>
    /// The fields in the EnhancedTagModel map to fields in an ASSATag
    /// </summary>
    public sealed partial class EnhancedTagModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique code of the selected tag type, `NULL` for text-only tags, or `custom` for custom tag types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_type_code")]
        public string? TagTypeCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTime { get; set; }

        /// <summary>
        /// Timestamp of the tag's end for events with duration or `NULL` if there is no duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Day of the tag (if no duration) or the start day of the tag (with duration).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDay { get; set; }

        /// <summary>
        /// Day of the tag's end for events with duration or `NULL` if there is no duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_day")]
        public global::System.DateTime? EndDay { get; set; }

        /// <summary>
        /// Additional freeform text on the tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// The name of the tag if the tag_type_code is `custom`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_name")]
        public string? CustomName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancedTagModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="startTime"></param>
        /// <param name="startDay">
        /// Day of the tag (if no duration) or the start day of the tag (with duration).
        /// </param>
        /// <param name="tagTypeCode">
        /// The unique code of the selected tag type, `NULL` for text-only tags, or `custom` for custom tag types.
        /// </param>
        /// <param name="endTime">
        /// Timestamp of the tag's end for events with duration or `NULL` if there is no duration.
        /// </param>
        /// <param name="endDay">
        /// Day of the tag's end for events with duration or `NULL` if there is no duration.
        /// </param>
        /// <param name="comment">
        /// Additional freeform text on the tag.
        /// </param>
        /// <param name="customName">
        /// The name of the tag if the tag_type_code is `custom`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnhancedTagModel(
            string id,
            string startTime,
            global::System.DateTime startDay,
            string? tagTypeCode,
            string? endTime,
            global::System.DateTime? endDay,
            string? comment,
            string? customName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TagTypeCode = tagTypeCode;
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.EndTime = endTime;
            this.StartDay = startDay;
            this.EndDay = endDay;
            this.Comment = comment;
            this.CustomName = customName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnhancedTagModel" /> class.
        /// </summary>
        public EnhancedTagModel()
        {
        }
    }
}