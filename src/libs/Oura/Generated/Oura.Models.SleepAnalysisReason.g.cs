
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible sleep analysis reasons.
    /// </summary>
    public enum SleepAnalysisReason
    {
        /// <summary>
        /// 
        /// </summary>
        BedtimeEdit,
        /// <summary>
        /// 
        /// </summary>
        ForegroundSleepAnalysis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SleepAnalysisReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SleepAnalysisReason value)
        {
            return value switch
            {
                SleepAnalysisReason.BedtimeEdit => "bedtime_edit",
                SleepAnalysisReason.ForegroundSleepAnalysis => "foreground_sleep_analysis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SleepAnalysisReason? ToEnum(string value)
        {
            return value switch
            {
                "bedtime_edit" => SleepAnalysisReason.BedtimeEdit,
                "foreground_sleep_analysis" => SleepAnalysisReason.ForegroundSleepAnalysis,
                _ => null,
            };
        }
    }
}