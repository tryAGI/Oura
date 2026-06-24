
#nullable enable

namespace Oura
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookOperation
    {
        /// <summary>
        ///
        /// </summary>
        Create,
        /// <summary>
        ///
        /// </summary>
        Delete,
        /// <summary>
        ///
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookOperation value)
        {
            return value switch
            {
                WebhookOperation.Create => "create",
                WebhookOperation.Delete => "delete",
                WebhookOperation.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookOperation? ToEnum(string value)
        {
            return value switch
            {
                "create" => WebhookOperation.Create,
                "delete" => WebhookOperation.Delete,
                "update" => WebhookOperation.Update,
                _ => null,
            };
        }
    }
}