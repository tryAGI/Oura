
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible ring colors.
    /// </summary>
    public enum PublicRingColor
    {
        /// <summary>
        /// 
        /// </summary>
        BrushedSilver,
        /// <summary>
        /// 
        /// </summary>
        Cloud,
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
        Midnight,
        /// <summary>
        /// 
        /// </summary>
        Petal,
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
        Tide,
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
    public static class PublicRingColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicRingColor value)
        {
            return value switch
            {
                PublicRingColor.BrushedSilver => "brushed_silver",
                PublicRingColor.Cloud => "cloud",
                PublicRingColor.GlossyBlack => "glossy_black",
                PublicRingColor.GlossyGold => "glossy_gold",
                PublicRingColor.GlossyWhite => "glossy_white",
                PublicRingColor.Gucci => "gucci",
                PublicRingColor.MattGold => "matt_gold",
                PublicRingColor.Midnight => "midnight",
                PublicRingColor.Petal => "petal",
                PublicRingColor.Rose => "rose",
                PublicRingColor.Silver => "silver",
                PublicRingColor.StealthBlack => "stealth_black",
                PublicRingColor.Tide => "tide",
                PublicRingColor.Titanium => "titanium",
                PublicRingColor.TitaniumAndGold => "titanium_and_gold",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicRingColor? ToEnum(string value)
        {
            return value switch
            {
                "brushed_silver" => PublicRingColor.BrushedSilver,
                "cloud" => PublicRingColor.Cloud,
                "glossy_black" => PublicRingColor.GlossyBlack,
                "glossy_gold" => PublicRingColor.GlossyGold,
                "glossy_white" => PublicRingColor.GlossyWhite,
                "gucci" => PublicRingColor.Gucci,
                "matt_gold" => PublicRingColor.MattGold,
                "midnight" => PublicRingColor.Midnight,
                "petal" => PublicRingColor.Petal,
                "rose" => PublicRingColor.Rose,
                "silver" => PublicRingColor.Silver,
                "stealth_black" => PublicRingColor.StealthBlack,
                "tide" => PublicRingColor.Tide,
                "titanium" => PublicRingColor.Titanium,
                "titanium_and_gold" => PublicRingColor.TitaniumAndGold,
                _ => null,
            };
        }
    }
}