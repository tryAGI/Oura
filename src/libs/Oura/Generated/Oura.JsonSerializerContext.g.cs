
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Oura
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Oura.JsonConverters.DailyStressSummaryJsonConverter),

            typeof(global::Oura.JsonConverters.DailyStressSummaryNullableJsonConverter),

            typeof(global::Oura.JsonConverters.ExtApiV2DataTypeJsonConverter),

            typeof(global::Oura.JsonConverters.ExtApiV2DataTypeNullableJsonConverter),

            typeof(global::Oura.JsonConverters.HeartRateSourceJsonConverter),

            typeof(global::Oura.JsonConverters.HeartRateSourceNullableJsonConverter),

            typeof(global::Oura.JsonConverters.LongTermResilienceLevelJsonConverter),

            typeof(global::Oura.JsonConverters.LongTermResilienceLevelNullableJsonConverter),

            typeof(global::Oura.JsonConverters.MomentMoodJsonConverter),

            typeof(global::Oura.JsonConverters.MomentMoodNullableJsonConverter),

            typeof(global::Oura.JsonConverters.MomentTypeJsonConverter),

            typeof(global::Oura.JsonConverters.MomentTypeNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicWorkoutIntensityJsonConverter),

            typeof(global::Oura.JsonConverters.PublicWorkoutIntensityNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicWorkoutSourceJsonConverter),

            typeof(global::Oura.JsonConverters.PublicWorkoutSourceNullableJsonConverter),

            typeof(global::Oura.JsonConverters.RingColorJsonConverter),

            typeof(global::Oura.JsonConverters.RingColorNullableJsonConverter),

            typeof(global::Oura.JsonConverters.RingDesignJsonConverter),

            typeof(global::Oura.JsonConverters.RingDesignNullableJsonConverter),

            typeof(global::Oura.JsonConverters.RingHardwareTypeJsonConverter),

            typeof(global::Oura.JsonConverters.RingHardwareTypeNullableJsonConverter),

            typeof(global::Oura.JsonConverters.SleepAlgorithmVersionJsonConverter),

            typeof(global::Oura.JsonConverters.SleepAlgorithmVersionNullableJsonConverter),

            typeof(global::Oura.JsonConverters.SleepAnalysisReasonJsonConverter),

            typeof(global::Oura.JsonConverters.SleepAnalysisReasonNullableJsonConverter),

            typeof(global::Oura.JsonConverters.SleepTimeRecommendationJsonConverter),

            typeof(global::Oura.JsonConverters.SleepTimeRecommendationNullableJsonConverter),

            typeof(global::Oura.JsonConverters.SleepTimeStatusJsonConverter),

            typeof(global::Oura.JsonConverters.SleepTimeStatusNullableJsonConverter),

            typeof(global::Oura.JsonConverters.SleepTypeJsonConverter),

            typeof(global::Oura.JsonConverters.SleepTypeNullableJsonConverter),

            typeof(global::Oura.JsonConverters.WebhookOperationJsonConverter),

            typeof(global::Oura.JsonConverters.WebhookOperationNullableJsonConverter),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Oura.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.ActivityContributors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.CreateWebhookSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.WebhookOperation), TypeInfoPropertyName = "WebhookOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.ExtApiV2DataType), TypeInfoPropertyName = "ExtApiV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.DailyActivityModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.SampleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.DailyCardiovascularAgeModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.DailyReadinessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.ReadinessContributors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.DailyResilienceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.ResilienceContributors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.LongTermResilienceLevel), TypeInfoPropertyName = "LongTermResilienceLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.DailySleepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.SleepContributors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.DailySpO2AggregatedValuesModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.DailySpO2Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.DailyStressModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.DailyStressSummary), TypeInfoPropertyName = "DailyStressSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.EnhancedTagModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.HeartRateModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.HeartRateSource), TypeInfoPropertyName = "HeartRateSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MomentMood), TypeInfoPropertyName = "MomentMood2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MomentType), TypeInfoPropertyName = "MomentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseDailyActivityModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.DailyActivityModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseDailyCardiovascularAgeModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.DailyCardiovascularAgeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseDailyReadinessModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.DailyReadinessModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseDailyResilienceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.DailyResilienceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseDailySleepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.DailySleepModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseDailySpO2Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.DailySpO2Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseDailyStressModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.DailyStressModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseEnhancedTagModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.EnhancedTagModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicWorkout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicWorkout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicWorkout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseRestModePeriodModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.RestModePeriodModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.RestModePeriodModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseRingConfigurationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.RingConfigurationModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.RingConfigurationModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseSessionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.SessionModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.SessionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseSleepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.SleepModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.SleepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseSleepTimeModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.SleepTimeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.SleepTimeModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseTagModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.TagModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.TagModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseVO2MaxModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.VO2MaxModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.VO2MaxModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PersonalInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicWorkoutIntensity), TypeInfoPropertyName = "PublicWorkoutIntensity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicWorkoutSource), TypeInfoPropertyName = "PublicWorkoutSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.ReadinessSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.RestModeEpisode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.RestModeEpisode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.RingColor), TypeInfoPropertyName = "RingColor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.RingDesign), TypeInfoPropertyName = "RingDesign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.RingHardwareType), TypeInfoPropertyName = "RingHardwareType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.SleepAlgorithmVersion), TypeInfoPropertyName = "SleepAlgorithmVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.SleepAnalysisReason), TypeInfoPropertyName = "SleepAnalysisReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.SleepType), TypeInfoPropertyName = "SleepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.SleepTimeWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.SleepTimeRecommendation), TypeInfoPropertyName = "SleepTimeRecommendation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.SleepTimeStatus), TypeInfoPropertyName = "SleepTimeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.TimeSeriesResponseHeartRateModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.HeartRateModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.UpdateWebhookSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.WebhookSubscriptionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.WebhookSubscriptionModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.DailyActivityModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.DailyCardiovascularAgeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.DailyReadinessModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.DailyResilienceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.DailySleepModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.DailySpO2Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.DailyStressModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.EnhancedTagModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicWorkout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.RestModePeriodModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.RingConfigurationModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.SessionModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.SleepModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.SleepTimeModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.TagModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.VO2MaxModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.RestModeEpisode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.HeartRateModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.WebhookSubscriptionModel>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}