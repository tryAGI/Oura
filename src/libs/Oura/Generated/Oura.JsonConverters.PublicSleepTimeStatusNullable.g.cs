#nullable enable

namespace Oura.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublicSleepTimeStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Oura.PublicSleepTimeStatus?>
    {
        /// <inheritdoc />
        public override global::Oura.PublicSleepTimeStatus? Read(
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
                        return global::Oura.PublicSleepTimeStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Oura.PublicSleepTimeStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Oura.PublicSleepTimeStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Oura.PublicSleepTimeStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Oura.PublicSleepTimeStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
