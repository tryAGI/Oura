
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible ring designs.
    /// </summary>
    public enum PublicRingDesign
    {
        /// <summary>
        /// 
        /// </summary>
        Balance,
        /// <summary>
        /// 
        /// </summary>
        BalanceDiamond,
        /// <summary>
        /// 
        /// </summary>
        Ceramic,
        /// <summary>
        /// 
        /// </summary>
        Heritage,
        /// <summary>
        /// 
        /// </summary>
        Horizon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicRingDesignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicRingDesign value)
        {
            return value switch
            {
                PublicRingDesign.Balance => "balance",
                PublicRingDesign.BalanceDiamond => "balance_diamond",
                PublicRingDesign.Ceramic => "ceramic",
                PublicRingDesign.Heritage => "heritage",
                PublicRingDesign.Horizon => "horizon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicRingDesign? ToEnum(string value)
        {
            return value switch
            {
                "balance" => PublicRingDesign.Balance,
                "balance_diamond" => PublicRingDesign.BalanceDiamond,
                "ceramic" => PublicRingDesign.Ceramic,
                "heritage" => PublicRingDesign.Heritage,
                "horizon" => PublicRingDesign.Horizon,
                _ => null,
            };
        }
    }
}