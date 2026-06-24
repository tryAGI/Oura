#nullable enable

namespace Oura.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublicDailyStressSummaryJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Oura.PublicDailyStressSummary>
    {
        /// <inheritdoc />
        public override global::Oura.PublicDailyStressSummary Read(
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
                        return global::Oura.PublicDailyStressSummaryExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Oura.PublicDailyStressSummary)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Oura.PublicDailyStressSummary);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Oura.PublicDailyStressSummary value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Oura.PublicDailyStressSummaryExtensions.ToValueString(value));
        }
    }
}
