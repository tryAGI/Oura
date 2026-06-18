
#nullable enable

namespace Oura
{
    /// <summary>
    /// Ring configuration.
    /// </summary>
    public sealed partial class PublicRingConfiguration
    {
        /// <summary>
        /// Unique identifier of the object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Color of the ring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.PublicRingColorJsonConverter))]
        public global::Oura.PublicRingColor? Color { get; set; }

        /// <summary>
        /// Design of the ring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("design")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.PublicRingDesignJsonConverter))]
        public global::Oura.PublicRingDesign? Design { get; set; }

        /// <summary>
        /// Firmware version of the ring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firmware_version")]
        public string? FirmwareVersion { get; set; }

        /// <summary>
        /// Hardware type of the ring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Oura.JsonConverters.PublicRingHardwareTypeJsonConverter))]
        public global::Oura.PublicRingHardwareType? HardwareType { get; set; }

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
        /// Initializes a new instance of the <see cref="PublicRingConfiguration" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the object.
        /// </param>
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
        public PublicRingConfiguration(
            string id,
            global::Oura.PublicRingColor? color,
            global::Oura.PublicRingDesign? design,
            string? firmwareVersion,
            global::Oura.PublicRingHardwareType? hardwareType,
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
        /// Initializes a new instance of the <see cref="PublicRingConfiguration" /> class.
        /// </summary>
        public PublicRingConfiguration()
        {
        }

    }
}