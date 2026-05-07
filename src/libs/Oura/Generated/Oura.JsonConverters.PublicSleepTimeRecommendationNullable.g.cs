#nullable enable

namespace Oura.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublicSleepTimeRecommendationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Oura.PublicSleepTimeRecommendation?>
    {
        /// <inheritdoc />
        public override global::Oura.PublicSleepTimeRecommendation? Read(
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
                        return global::Oura.PublicSleepTimeRecommendationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Oura.PublicSleepTimeRecommendation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Oura.PublicSleepTimeRecommendation?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Oura.PublicSleepTimeRecommendation? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Oura.PublicSleepTimeRecommendationExtensions.ToValueString(value.Value));
            }
        }
    }
}
