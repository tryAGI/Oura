
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RingConfigurationModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Color of the ring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.RingColorJsonConverter))]
        public global::Oura.RingColor? Color { get; set; }

        /// <summary>
        /// Design of the ring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.RingDesignJsonConverter))]
        public global::Oura.RingDesign? Design { get; set; }

        /// <summary>
        /// Firmware version of the ring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firmware_version")]
        public string? FirmwareVersion { get; set; }

        /// <summary>
        /// Hardware type of the ring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.RingHardwareTypeJsonConverter))]
        public global::Oura.RingHardwareType? HardwareType { get; set; }

        /// <summary>
        /// UTC timestamp indicating when the ring was set up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set_up_at")]
        public string? SetUpAt { get; set; }

        /// <summary>
        /// US size of the ring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RingConfigurationModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="color">
        /// Color of the ring.
        /// </param>
        /// <param name="design">
        /// Design of the ring.
        /// </param>
        /// <param name="firmwareVersion">
        /// Firmware version of the ring.
        /// </param>
        /// <param name="hardwareType">
        /// Hardware type of the ring.
        /// </param>
        /// <param name="setUpAt">
        /// UTC timestamp indicating when the ring was set up.
        /// </param>
        /// <param name="size">
        /// US size of the ring.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RingConfigurationModel(
            string id,
            global::Oura.RingColor? color,
            global::Oura.RingDesign? design,
            string? firmwareVersion,
            global::Oura.RingHardwareType? hardwareType,
            string? setUpAt,
            int? size)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Color = color;
            this.Design = design;
            this.FirmwareVersion = firmwareVersion;
            this.HardwareType = hardwareType;
            this.SetUpAt = setUpAt;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RingConfigurationModel" /> class.
        /// </summary>
        public RingConfigurationModel()
        {
        }
    }
}