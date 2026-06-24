#nullable enable

namespace Oura.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublicWorkoutSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Oura.PublicWorkoutSource>
    {
        /// <inheritdoc />
        public override global::Oura.PublicWorkoutSource Read(
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
                        return global::Oura.PublicWorkoutSourceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Oura.PublicWorkoutSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Oura.PublicWorkoutSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Oura.PublicWorkoutSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Oura.PublicWorkoutSourceExtensions.ToValueString(value));
        }
    }
}
