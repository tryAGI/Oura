
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible long term resilience level values.
    /// </summary>
    public enum LongTermResilienceLevel
    {
        /// <summary>
        ///
        /// </summary>
        Adequate,
        /// <summary>
        ///
        /// </summary>
        Exceptional,
        /// <summary>
        ///
        /// </summary>
        Limited,
        /// <summary>
        ///
        /// </summary>
        Solid,
        /// <summary>
        ///
        /// </summary>
        Strong,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LongTermResilienceLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LongTermResilienceLevel value)
        {
            return value switch
            {
                LongTermResilienceLevel.Adequate => "adequate",
                LongTermResilienceLevel.Exceptional => "exceptional",
                LongTermResilienceLevel.Limited => "limited",
                LongTermResilienceLevel.Solid => "solid",
                LongTermResilienceLevel.Strong => "strong",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LongTermResilienceLevel? ToEnum(string value)
        {
            return value switch
            {
                "adequate" => LongTermResilienceLevel.Adequate,
                "exceptional" => LongTermResilienceLevel.Exceptional,
                "limited" => LongTermResilienceLevel.Limited,
                "solid" => LongTermResilienceLevel.Solid,
                "strong" => LongTermResilienceLevel.Strong,
                _ => null,
            };
        }
    }
}