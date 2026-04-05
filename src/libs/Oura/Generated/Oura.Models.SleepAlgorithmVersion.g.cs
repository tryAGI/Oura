
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public enum SleepAlgorithmVersion
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
    public static class SleepAlgorithmVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SleepAlgorithmVersion value)
        {
            return value switch
            {
                SleepAlgorithmVersion.V1 => "v1",
                SleepAlgorithmVersion.V2 => "v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SleepAlgorithmVersion? ToEnum(string value)
        {
            return value switch
            {
                "v1" => SleepAlgorithmVersion.V1,
                "v2" => SleepAlgorithmVersion.V2,
                _ => null,
            };
        }
    }
}