
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible public daily stress summary types.
    /// </summary>
    public enum PublicDailyStressSummary
    {
        /// <summary>
        ///
        /// </summary>
        Normal,
        /// <summary>
        ///
        /// </summary>
        Restored,
        /// <summary>
        ///
        /// </summary>
        Stressful,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicDailyStressSummaryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicDailyStressSummary value)
        {
            return value switch
            {
                PublicDailyStressSummary.Normal => "normal",
                PublicDailyStressSummary.Restored => "restored",
                PublicDailyStressSummary.Stressful => "stressful",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicDailyStressSummary? ToEnum(string value)
        {
            return value switch
            {
                "normal" => PublicDailyStressSummary.Normal,
                "restored" => PublicDailyStressSummary.Restored,
                "stressful" => PublicDailyStressSummary.Stressful,
                _ => null,
            };
        }
    }
}