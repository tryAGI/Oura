
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible ring hardware types.
    /// </summary>
    public enum PublicRingHardwareType
    {
        /// <summary>
        /// 
        /// </summary>
        Gen1,
        /// <summary>
        /// 
        /// </summary>
        Gen2,
        /// <summary>
        /// 
        /// </summary>
        Gen2m,
        /// <summary>
        /// 
        /// </summary>
        Gen3,
        /// <summary>
        /// 
        /// </summary>
        Gen4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicRingHardwareTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicRingHardwareType value)
        {
            return value switch
            {
                PublicRingHardwareType.Gen1 => "gen1",
                PublicRingHardwareType.Gen2 => "gen2",
                PublicRingHardwareType.Gen2m => "gen2m",
                PublicRingHardwareType.Gen3 => "gen3",
                PublicRingHardwareType.Gen4 => "gen4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicRingHardwareType? ToEnum(string value)
        {
            return value switch
            {
                "gen1" => PublicRingHardwareType.Gen1,
                "gen2" => PublicRingHardwareType.Gen2,
                "gen2m" => PublicRingHardwareType.Gen2m,
                "gen3" => PublicRingHardwareType.Gen3,
                "gen4" => PublicRingHardwareType.Gen4,
                _ => null,
            };
        }
    }
}