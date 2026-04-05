
#nullable enable

namespace Oura
{
    /// <summary>
    /// Possible sleep period types.<br/>
    /// 'deleted' = deleted sleep by user.<br/>
    /// 'sleep' = user confirmed sleep / nap, min 15 minutes, max 3 hours, contributes to daily scores<br/>
    /// 'late_nap' = user confirmed sleep / nap, min 15 minutes, ended after sleep day change (6 pm), contributes to next days daily scores<br/>
    /// 'long_sleep' = sleep that is long enough (&gt;3h) to automatically contribute to daily scores<br/>
    /// 'rest' = Falsely detected sleep / nap, rejected in confirm prompt by user
    /// </summary>
    public enum SleepType
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        LateNap,
        /// <summary>
        /// 
        /// </summary>
        LongSleep,
        /// <summary>
        /// 
        /// </summary>
        Rest,
        /// <summary>
        /// 
        /// </summary>
        Sleep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SleepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SleepType value)
        {
            return value switch
            {
                SleepType.Deleted => "deleted",
                SleepType.LateNap => "late_nap",
                SleepType.LongSleep => "long_sleep",
                SleepType.Rest => "rest",
                SleepType.Sleep => "sleep",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SleepType? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => SleepType.Deleted,
                "late_nap" => SleepType.LateNap,
                "long_sleep" => SleepType.LongSleep,
                "rest" => SleepType.Rest,
                "sleep" => SleepType.Sleep,
                _ => null,
            };
        }
    }
}