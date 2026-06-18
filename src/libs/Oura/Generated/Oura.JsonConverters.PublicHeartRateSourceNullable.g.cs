#nullable enable

namespace Oura.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublicHeartRateSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Oura.PublicHeartRateSource?>
    {
        /// <inheritdoc />
        public override global::Oura.PublicHeartRateSource? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Oura.PublicHeartRateSourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Oura.PublicHeartRateSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Oura.PublicHeartRateSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Oura.PublicHeartRateSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Oura.PublicHeartRateSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
