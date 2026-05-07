
#nullable enable

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExtApiV2DataType
    {
        /// <summary>
        /// 
        /// </summary>
        ActivationStatus,
        /// <summary>
        /// 
        /// </summary>
        BloodGlucose,
        /// <summary>
        /// 
        /// </summary>
        DailyActivity,
        /// <summary>
        /// 
        /// </summary>
        DailyCardiovascularAge,
        /// <summary>
        /// 
        /// </summary>
        DailyCyclePhases,
        /// <summary>
        /// 
        /// </summary>
        DailyReadiness,
        /// <summary>
        /// 
        /// </summary>
        DailyResilience,
        /// <summary>
        /// 
        /// </summary>
        DailySleep,
        /// <summary>
        /// 
        /// </summary>
        DailySpo2,
        /// <summary>
        /// 
        /// </summary>
        DailyStress,
        /// <summary>
        /// 
        /// </summary>
        EnhancedTag,
        /// <summary>
        /// 
        /// </summary>
        FertileWindow,
        /// <summary>
        /// 
        /// </summary>
        OvulationConfirmed,
        /// <summary>
        /// 
        /// </summary>
        PeriodStart,
        /// <summary>
        /// 
        /// </summary>
        Pregnancy,
        /// <summary>
        /// 
        /// </summary>
        RestModePeriod,
        /// <summary>
        /// 
        /// </summary>
        RingConfiguration,
        /// <summary>
        /// 
        /// </summary>
        Session,
        /// <summary>
        /// 
        /// </summary>
        Sleep,
        /// <summary>
        /// 
        /// </summary>
        SleepTime,
        /// <summary>
        /// 
        /// </summary>
        Tag,
        /// <summary>
        /// 
        /// </summary>
        Vo2Max,
        /// <summary>
        /// 
        /// </summary>
        Workout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtApiV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtApiV2DataType value)
        {
            return value switch
            {
                ExtApiV2DataType.ActivationStatus => "activation_status",
                ExtApiV2DataType.BloodGlucose => "blood_glucose",
                ExtApiV2DataType.DailyActivity => "daily_activity",
                ExtApiV2DataType.DailyCardiovascularAge => "daily_cardiovascular_age",
                ExtApiV2DataType.DailyCyclePhases => "daily_cycle_phases",
                ExtApiV2DataType.DailyReadiness => "daily_readiness",
                ExtApiV2DataType.DailyResilience => "daily_resilience",
                ExtApiV2DataType.DailySleep => "daily_sleep",
                ExtApiV2DataType.DailySpo2 => "daily_spo2",
                ExtApiV2DataType.DailyStress => "daily_stress",
                ExtApiV2DataType.EnhancedTag => "enhanced_tag",
                ExtApiV2DataType.FertileWindow => "fertile_window",
                ExtApiV2DataType.OvulationConfirmed => "ovulation_confirmed",
                ExtApiV2DataType.PeriodStart => "period_start",
                ExtApiV2DataType.Pregnancy => "pregnancy",
                ExtApiV2DataType.RestModePeriod => "rest_mode_period",
                ExtApiV2DataType.RingConfiguration => "ring_configuration",
                ExtApiV2DataType.Session => "session",
                ExtApiV2DataType.Sleep => "sleep",
                ExtApiV2DataType.SleepTime => "sleep_time",
                ExtApiV2DataType.Tag => "tag",
                ExtApiV2DataType.Vo2Max => "vo2_max",
                ExtApiV2DataType.Workout => "workout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtApiV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "activation_status" => ExtApiV2DataType.ActivationStatus,
                "blood_glucose" => ExtApiV2DataType.BloodGlucose,
                "daily_activity" => ExtApiV2DataType.DailyActivity,
                "daily_cardiovascular_age" => ExtApiV2DataType.DailyCardiovascularAge,
                "daily_cycle_phases" => ExtApiV2DataType.DailyCyclePhases,
                "daily_readiness" => ExtApiV2DataType.DailyReadiness,
                "daily_resilience" => ExtApiV2DataType.DailyResilience,
                "daily_sleep" => ExtApiV2DataType.DailySleep,
                "daily_spo2" => ExtApiV2DataType.DailySpo2,
                "daily_stress" => ExtApiV2DataType.DailyStress,
                "enhanced_tag" => ExtApiV2DataType.EnhancedTag,
                "fertile_window" => ExtApiV2DataType.FertileWindow,
                "ovulation_confirmed" => ExtApiV2DataType.OvulationConfirmed,
                "period_start" => ExtApiV2DataType.PeriodStart,
                "pregnancy" => ExtApiV2DataType.Pregnancy,
                "rest_mode_period" => ExtApiV2DataType.RestModePeriod,
                "ring_configuration" => ExtApiV2DataType.RingConfiguration,
                "session" => ExtApiV2DataType.Session,
                "sleep" => ExtApiV2DataType.Sleep,
                "sleep_time" => ExtApiV2DataType.SleepTime,
                "tag" => ExtApiV2DataType.Tag,
                "vo2_max" => ExtApiV2DataType.Vo2Max,
                "workout" => ExtApiV2DataType.Workout,
                _ => null,
            };
        }
    }
}