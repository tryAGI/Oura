
#nullable enable

namespace Oura
{
    /// <summary>
    /// Oura Sleep Staging Algorithms.<br/>
    /// v1 = original aka legacy aka OSSA 1.0,<br/>
    /// v2 = latest sleep algorithm
    /// </summary>
    public enum PublicSleepAlgorithmVersion
    {
        /// <summary>
        ///
        /// </summary>
        V1,
        /// <summary>
        ///
        /// </summary>
        V2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicSleepAlgorithmVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicSleepAlgorithmVersion value)
        {
            return value switch
            {
                PublicSleepAlgorithmVersion.V1 => "v1",
                PublicSleepAlgorithmVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicSleepAlgorithmVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => PublicSleepAlgorithmVersion.V1,
                "v2" => PublicSleepAlgorithmVersion.V2,
                _ => null,
            };
        }
    }
}