
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public enum RingDesign
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
        Heritage,
        /// <summary>
        /// 
        /// </summary>
        Horizon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RingDesignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RingDesign value)
        {
            return value switch
            {
                RingDesign.Balance => "balance",
                RingDesign.BalanceDiamond => "balance_diamond",
                RingDesign.Heritage => "heritage",
                RingDesign.Horizon => "horizon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RingDesign? ToEnum(string value)
        {
            return value switch
            {
                "balance" => RingDesign.Balance,
                "balance_diamond" => RingDesign.BalanceDiamond,
                "heritage" => RingDesign.Heritage,
                "horizon" => RingDesign.Horizon,
                _ => null,
            };
        }
    }
}