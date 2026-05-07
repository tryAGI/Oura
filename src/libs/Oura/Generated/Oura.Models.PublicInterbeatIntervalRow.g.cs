
#nullable enable

namespace Oura
{
    /// <summary>
    /// Discrete interbeat interval
    /// </summary>
    public sealed partial class PublicInterbeatIntervalRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Timestamp of the discrete sample as unix time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TimestampUnix { get; set; }

        /// <summary>
        /// Time between two consecutive beats of the heart, in milliseconds. Maximum value limited to 2000ms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ibi")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Ibi { get; set; }

        /// <summary>
        /// Validation classification: 1=Good,2=Bad,3=Corrected,-1/-2=Gap, 0=Raw(Uncorrected). The validity indicates<br/>
        /// whether the data in this row is trustworthy. Gap: indicates that there was no available ppg signal in the<br/>
        /// past seconds, which makes it impossible to compute the IBI for this row. Corrected: In rare cases the ring<br/>
        /// algorithm produces artifacts that can be corrected during post-processing. An example is the ring algo<br/>
        /// generating two IBI events when there should be a single one. If the IBI value was fixed in post-processing,<br/>
        /// it will have this validity classification. If the IBI value was not fixed, it will have the Raw classification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Validity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicInterbeatIntervalRow" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="timestampUnix">
        /// Timestamp of the discrete sample as unix time in milliseconds.
        /// </param>
        /// <param name="ibi">
        /// Time between two consecutive beats of the heart, in milliseconds. Maximum value limited to 2000ms.
        /// </param>
        /// <param name="validity">
        /// Validation classification: 1=Good,2=Bad,3=Corrected,-1/-2=Gap, 0=Raw(Uncorrected). The validity indicates<br/>
        /// whether the data in this row is trustworthy. Gap: indicates that there was no available ppg signal in the<br/>
        /// past seconds, which makes it impossible to compute the IBI for this row. Corrected: In rare cases the ring<br/>
        /// algorithm produces artifacts that can be corrected during post-processing. An example is the ring algo<br/>
        /// generating two IBI events when there should be a single one. If the IBI value was fixed in post-processing,<br/>
        /// it will have this validity classification. If the IBI value was not fixed, it will have the Raw classification.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicInterbeatIntervalRow(
            string timestamp,
            long timestampUnix,
            int ibi,
            int validity)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.TimestampUnix = timestampUnix;
            this.Ibi = ibi;
            this.Validity = validity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicInterbeatIntervalRow" /> class.
        /// </summary>
        public PublicInterbeatIntervalRow()
        {
        }
    }
}