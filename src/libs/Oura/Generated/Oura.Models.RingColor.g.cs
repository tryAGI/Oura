
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public enum RingColor
    {
        /// <summary>
        /// 
        /// </summary>
        BrushedSilver,
        /// <summary>
        /// 
        /// </summary>
        GlossyBlack,
        /// <summary>
        /// 
        /// </summary>
        GlossyGold,
        /// <summary>
        /// 
        /// </summary>
        GlossyWhite,
        /// <summary>
        /// 
        /// </summary>
        Gucci,
        /// <summary>
        /// 
        /// </summary>
        MattGold,
        /// <summary>
        /// 
        /// </summary>
        Rose,
        /// <summary>
        /// 
        /// </summary>
        Silver,
        /// <summary>
        /// 
        /// </summary>
        StealthBlack,
        /// <summary>
        /// 
        /// </summary>
        Titanium,
        /// <summary>
        /// 
        /// </summary>
        TitaniumAndGold,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RingColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RingColor value)
        {
            return value switch
            {
                RingColor.BrushedSilver => "brushed_silver",
                RingColor.GlossyBlack => "glossy_black",
                RingColor.GlossyGold => "glossy_gold",
                RingColor.GlossyWhite => "glossy_white",
                RingColor.Gucci => "gucci",
                RingColor.MattGold => "matt_gold",
                RingColor.Rose => "rose",
                RingColor.Silver => "silver",
                RingColor.StealthBlack => "stealth_black",
                RingColor.Titanium => "titanium",
                RingColor.TitaniumAndGold => "titanium_and_gold",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RingColor? ToEnum(string value)
        {
            return value switch
            {
                "brushed_silver" => RingColor.BrushedSilver,
                "glossy_black" => RingColor.GlossyBlack,
                "glossy_gold" => RingColor.GlossyGold,
                "glossy_white" => RingColor.GlossyWhite,
                "gucci" => RingColor.Gucci,
                "matt_gold" => RingColor.MattGold,
                "rose" => RingColor.Rose,
                "silver" => RingColor.Silver,
                "stealth_black" => RingColor.StealthBlack,
                "titanium" => RingColor.Titanium,
                "titanium_and_gold" => RingColor.TitaniumAndGold,
                _ => null,
            };
        }
    }
}