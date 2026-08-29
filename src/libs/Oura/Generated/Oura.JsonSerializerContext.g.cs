
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
            typeof(global::Oura.JsonConverters.ExtApiV2DataTypeJsonConverter),

            typeof(global::Oura.JsonConverters.ExtApiV2DataTypeNullableJsonConverter),

            typeof(global::Oura.JsonConverters.LongTermResilienceLevelJsonConverter),

            typeof(global::Oura.JsonConverters.LongTermResilienceLevelNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicDailyStressSummaryJsonConverter),

            typeof(global::Oura.JsonConverters.PublicDailyStressSummaryNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicHeartRateSourceJsonConverter),

            typeof(global::Oura.JsonConverters.PublicHeartRateSourceNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicMomentMoodJsonConverter),

            typeof(global::Oura.JsonConverters.PublicMomentMoodNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicMomentTypeJsonConverter),

            typeof(global::Oura.JsonConverters.PublicMomentTypeNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicRingColorJsonConverter),

            typeof(global::Oura.JsonConverters.PublicRingColorNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicRingDesignJsonConverter),

            typeof(global::Oura.JsonConverters.PublicRingDesignNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicRingHardwareTypeJsonConverter),

            typeof(global::Oura.JsonConverters.PublicRingHardwareTypeNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicSleepAlgorithmVersionJsonConverter),

            typeof(global::Oura.JsonConverters.PublicSleepAlgorithmVersionNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicSleepAnalysisReasonJsonConverter),

            typeof(global::Oura.JsonConverters.PublicSleepAnalysisReasonNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicSleepTimeRecommendationJsonConverter),

            typeof(global::Oura.JsonConverters.PublicSleepTimeRecommendationNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicSleepTimeStatusJsonConverter),

            typeof(global::Oura.JsonConverters.PublicSleepTimeStatusNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicSleepTypeJsonConverter),

            typeof(global::Oura.JsonConverters.PublicSleepTypeNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicWorkoutIntensityJsonConverter),

            typeof(global::Oura.JsonConverters.PublicWorkoutIntensityNullableJsonConverter),

            typeof(global::Oura.JsonConverters.PublicWorkoutSourceJsonConverter),

            typeof(global::Oura.JsonConverters.PublicWorkoutSourceNullableJsonConverter),

            typeof(global::Oura.JsonConverters.WebhookOperationJsonConverter),

            typeof(global::Oura.JsonConverters.WebhookOperationNullableJsonConverter),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailyActivity, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailyCardiovascularAge, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailyReadiness, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponseDailyResilienceModel, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailySleep, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailySpO2, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailyStress, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponseEnhancedTagModel, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.TimeSeriesResponsePublicHeartRateRow, global::Oura.TimeSeriesResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicRestModePeriod, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.TimeSeriesResponsePublicRingBatteryLevelRow, global::Oura.TimeSeriesResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicRingConfiguration, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicSession, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicModifiedSleepModel, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicSleepTime, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponseTagModel, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicVO2Max, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicWorkout, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailyActivity, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailyCardiovascularAge, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailyReadiness, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponseDailyResilienceModel, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailySleep, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailySpO2, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicDailyStress, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponseEnhancedTagModel, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.TimeSeriesResponsePublicHeartRateRow, global::Oura.TimeSeriesResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicRestModePeriod, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.TimeSeriesResponsePublicRingBatteryLevelRow, global::Oura.TimeSeriesResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicRingConfiguration, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicSession, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicModifiedSleepModel, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicSleepTime, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponseTagModel, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicVO2Max, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.AnyOfJsonConverter<global::Oura.MultiDocumentResponsePublicWorkout, global::Oura.MultiDocumentResponseDict>),

            typeof(global::Oura.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.CreateWebhookSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.WebhookOperation), TypeInfoPropertyName = "WebhookOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.ExtApiV2DataType), TypeInfoPropertyName = "ExtApiV2DataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.DailyResilienceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.ResilienceContributors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.LongTermResilienceLevel), TypeInfoPropertyName = "LongTermResilienceLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.EnhancedTagModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseDailyResilienceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.DailyResilienceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseEnhancedTagModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.EnhancedTagModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicDailyActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicDailyActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicDailyActivity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicDailyCardiovascularAge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicDailyCardiovascularAge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicDailyCardiovascularAge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicDailyReadiness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicDailyReadiness>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicDailyReadiness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicDailySleep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicDailySleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicDailySleep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicDailySpO2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicDailySpO2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicDailySpO2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicDailyStress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicDailyStress>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicDailyStress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicModifiedSleepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicModifiedSleepModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicModifiedSleepModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicRestModePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicRestModePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRestModePeriod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicRingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicRingConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicSleepTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicSleepTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicSleepTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicVO2Max))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicVO2Max>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicVO2Max))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponsePublicWorkout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicWorkout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicWorkout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.MultiDocumentResponseTagModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.TagModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.TagModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PersonalInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicActivityContributors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicReadinessContributors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicSleepContributors))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicSpo2AggregatedValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicDailyStressSummary), TypeInfoPropertyName = "PublicDailyStressSummary2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicHeartRateRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicHeartRateSource), TypeInfoPropertyName = "PublicHeartRateSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicReadiness))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicSleepAlgorithmVersion), TypeInfoPropertyName = "PublicSleepAlgorithmVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicSleepAnalysisReason), TypeInfoPropertyName = "PublicSleepAnalysisReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicSleepType), TypeInfoPropertyName = "PublicSleepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicMomentMood), TypeInfoPropertyName = "PublicMomentMood2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicMomentType), TypeInfoPropertyName = "PublicMomentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRestModeEpisode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicRestModeEpisode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingBatteryLevelRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingColor), TypeInfoPropertyName = "PublicRingColor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingDesign), TypeInfoPropertyName = "PublicRingDesign2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicRingHardwareType), TypeInfoPropertyName = "PublicRingHardwareType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicSleepTimeWindow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicSleepTimeRecommendation), TypeInfoPropertyName = "PublicSleepTimeRecommendation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicSleepTimeStatus), TypeInfoPropertyName = "PublicSleepTimeStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicWorkoutIntensity), TypeInfoPropertyName = "PublicWorkoutIntensity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.PublicWorkoutSource), TypeInfoPropertyName = "PublicWorkoutSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.TimeSeriesResponseDict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.TimeSeriesResponsePublicHeartRateRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicHeartRateRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.TimeSeriesResponsePublicRingBatteryLevelRow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.PublicRingBatteryLevelRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.UpdateWebhookSubscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.WebhookSubscriptionModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicDailyActivity, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicDailyActivityMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicDailyCardiovascularAge, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicDailyCardiovascularAgeMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicDailyReadiness, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicDailyReadinessMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponseDailyResilienceModel, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponseDailyResilienceModelMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicDailySleep, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicDailySleepMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicDailySpO2, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicDailySpO2MultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicDailyStress, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicDailyStressMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponseEnhancedTagModel, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponseEnhancedTagModelMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.TimeSeriesResponsePublicHeartRateRow, global::Oura.TimeSeriesResponseDict>), TypeInfoPropertyName = "AnyOfTimeSeriesResponsePublicHeartRateRowTimeSeriesResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicRestModePeriod, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicRestModePeriodMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.TimeSeriesResponsePublicRingBatteryLevelRow, global::Oura.TimeSeriesResponseDict>), TypeInfoPropertyName = "AnyOfTimeSeriesResponsePublicRingBatteryLevelRowTimeSeriesResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicRingConfiguration, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicRingConfigurationMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicSession, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicSessionMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicModifiedSleepModel, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicModifiedSleepModelMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicSleepTime, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicSleepTimeMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponseTagModel, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponseTagModelMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicVO2Max, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicVO2MaxMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Oura.AnyOf<global::Oura.MultiDocumentResponsePublicWorkout, global::Oura.MultiDocumentResponseDict>), TypeInfoPropertyName = "AnyOfMultiDocumentResponsePublicWorkoutMultiDocumentResponseDict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Oura.WebhookSubscriptionModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.DailyResilienceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.EnhancedTagModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicDailyActivity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicDailyCardiovascularAge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicDailyReadiness>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicDailySleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicDailySpO2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicDailyStress>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicModifiedSleepModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicRestModePeriod>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicRingConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicSleepTime>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicVO2Max>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicWorkout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.TagModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicRestModeEpisode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicHeartRateRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.PublicRingBatteryLevelRow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Oura.WebhookSubscriptionModel>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}