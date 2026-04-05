
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public enum RingHardwareType
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
    public static class RingHardwareTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RingHardwareType value)
        {
            return value switch
            {
                RingHardwareType.Gen1 => "gen1",
                RingHardwareType.Gen2 => "gen2",
                RingHardwareType.Gen2m => "gen2m",
                RingHardwareType.Gen3 => "gen3",
                RingHardwareType.Gen4 => "gen4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RingHardwareType? ToEnum(string value)
        {
            return value switch
            {
                "gen1" => RingHardwareType.Gen1,
                "gen2" => RingHardwareType.Gen2,
                "gen2m" => RingHardwareType.Gen2m,
                "gen3" => RingHardwareType.Gen3,
                "gen4" => RingHardwareType.Gen4,
                _ => null,
            };
        }
    }
}