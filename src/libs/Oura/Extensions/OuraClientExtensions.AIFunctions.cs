#nullable enable

using System.ComponentModel;
using System.Globalization;
using Microsoft.Extensions.AI;

namespace Oura;

/// <summary>
/// MEAI AIFunction tool extensions for OuraClient.
/// </summary>
public static class OuraClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that retrieves daily sleep scores and contributor data.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsGetDailySleepTool(this OuraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("Start date in yyyy-MM-dd format (optional)")] string? startDate,
                   [Description("End date in yyyy-MM-dd format (optional)")] string? endDate,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.DailySleepRoutes.MultipleDailySleepDocumentsV2UsercollectionDailySleepGetAsync(
                    startDate: startDate is not null ? DateTime.Parse(startDate, CultureInfo.InvariantCulture) : null,
                    endDate: endDate is not null ? DateTime.Parse(endDate, CultureInfo.InvariantCulture) : null,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
                var data = response.Value1?.Data ?? [];

                return new
                {
                    count = data.Count,
                    data = data.Select(d => new
                    {
                        id = d.Id,
                        day = d.Day,
                        score = d.Score,
                        timestamp = d.Timestamp,
                    }),
                };
            },
            name: "Oura_GetDailySleep",
            description: "Get daily sleep scores from Oura Ring for a date range. Returns sleep score and contributor details for each day.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves daily activity metrics including steps, calories, and MET minutes.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsGetDailyActivityTool(this OuraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("Start date in yyyy-MM-dd format (optional)")] string? startDate,
                   [Description("End date in yyyy-MM-dd format (optional)")] string? endDate,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.DailyActivityRoutes.MultipleDailyActivityDocumentsV2UsercollectionDailyActivityGetAsync(
                    startDate: startDate is not null ? DateTime.Parse(startDate, CultureInfo.InvariantCulture) : null,
                    endDate: endDate is not null ? DateTime.Parse(endDate, CultureInfo.InvariantCulture) : null,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
                var data = response.Value1?.Data ?? [];

                return new
                {
                    count = data.Count,
                    data = data.Select(d => new
                    {
                        id = d.Id,
                        day = d.Day,
                        score = d.Score,
                        steps = d.Steps,
                        active_calories = d.ActiveCalories,
                        total_calories = d.TotalCalories,
                        equivalent_walking_distance = d.EquivalentWalkingDistance,
                        high_activity_time = d.HighActivityTime,
                        medium_activity_time = d.MediumActivityTime,
                        low_activity_time = d.LowActivityTime,
                        sedentary_time = d.SedentaryTime,
                        resting_time = d.RestingTime,
                    }),
                };
            },
            name: "Oura_GetDailyActivity",
            description: "Get daily activity metrics from Oura Ring including steps, calories, activity time, and MET minutes for a date range.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves daily readiness scores.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsGetDailyReadinessTool(this OuraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("Start date in yyyy-MM-dd format (optional)")] string? startDate,
                   [Description("End date in yyyy-MM-dd format (optional)")] string? endDate,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.DailyReadinessRoutes.MultipleDailyReadinessDocumentsV2UsercollectionDailyReadinessGetAsync(
                    startDate: startDate is not null ? DateTime.Parse(startDate, CultureInfo.InvariantCulture) : null,
                    endDate: endDate is not null ? DateTime.Parse(endDate, CultureInfo.InvariantCulture) : null,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
                var data = response.Value1?.Data ?? [];

                return new
                {
                    count = data.Count,
                    data = data.Select(d => new
                    {
                        id = d.Id,
                        day = d.Day,
                        score = d.Score,
                        temperature_deviation = d.TemperatureDeviation,
                        temperature_trend_deviation = d.TemperatureTrendDeviation,
                        timestamp = d.Timestamp,
                    }),
                };
            },
            name: "Oura_GetDailyReadiness",
            description: "Get daily readiness scores from Oura Ring for a date range. Returns how ready the user is for the day based on sleep, recovery, and other factors.");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves heart rate time-series data.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsGetHeartRateTool(this OuraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("Start datetime in ISO 8601 format, e.g. 2024-01-01T00:00:00Z (optional)")] string? startDatetime,
                   [Description("End datetime in ISO 8601 format, e.g. 2024-01-02T00:00:00Z (optional)")] string? endDatetime,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.HeartRateRoutes.MultipleHeartrateDocumentsV2UsercollectionHeartrateGetAsync(
                    startDatetime: startDatetime is not null ? DateTime.Parse(startDatetime, CultureInfo.InvariantCulture) : null,
                    endDatetime: endDatetime is not null ? DateTime.Parse(endDatetime, CultureInfo.InvariantCulture) : null,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
                var data = response.Value1?.Data ?? [];

                return new
                {
                    count = data.Count,
                    data = data.Select(d => new
                    {
                        bpm = d.Bpm,
                        source = d.Source.ToString(),
                        timestamp = d.Timestamp,
                    }),
                };
            },
            name: "Oura_GetHeartRate",
            description: "Get heart rate time-series data from Oura Ring. Returns BPM readings at 5-minute intervals with source (awake, rest, sleep, etc.).");
    }

    /// <summary>
    /// Creates an AIFunction tool that retrieves detailed sleep period data including HRV, stages, and biometrics.
    /// </summary>
    [CLSCompliant(false)]
    public static AIFunction AsGetSleepDataTool(this OuraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async ([Description("Start date in yyyy-MM-dd format (optional)")] string? startDate,
                   [Description("End date in yyyy-MM-dd format (optional)")] string? endDate,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.SleepRoutes.MultipleSleepDocumentsV2UsercollectionSleepGetAsync(
                    startDate: startDate is not null ? DateTime.Parse(startDate, CultureInfo.InvariantCulture) : null,
                    endDate: endDate is not null ? DateTime.Parse(endDate, CultureInfo.InvariantCulture) : null,
                    cancellationToken: cancellationToken).ConfigureAwait(false);
                var data = response.Value1?.Data ?? [];

                return new
                {
                    count = data.Count,
                    data = data.Select(d => new
                    {
                        id = d.Id,
                        day = d.Day,
                        type = d.Type.ToString(),
                        bedtime_start = d.BedtimeStart,
                        bedtime_end = d.BedtimeEnd,
                        total_sleep_duration = d.TotalSleepDuration,
                        deep_sleep_duration = d.DeepSleepDuration,
                        light_sleep_duration = d.LightSleepDuration,
                        rem_sleep_duration = d.RemSleepDuration,
                        awake_time = d.AwakeTime,
                        time_in_bed = d.TimeInBed,
                        efficiency = d.Efficiency,
                        average_heart_rate = d.AverageHeartRate,
                        lowest_heart_rate = d.LowestHeartRate,
                        average_hrv = d.AverageHrv,
                        average_breath = d.AverageBreath,
                        latency = d.Latency,
                        restless_periods = d.RestlessPeriods,
                    }),
                };
            },
            name: "Oura_GetSleepData",
            description: "Get detailed sleep period data from Oura Ring including sleep stages (deep, light, REM), HRV, heart rate, breathing rate, and efficiency for a date range.");
    }

    /// <summary>
    /// Returns all available AIFunction tools for the OuraClient.
    /// </summary>
    [CLSCompliant(false)]
    public static IList<AIFunction> AsTools(this OuraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return
        [
            client.AsGetDailySleepTool(),
            client.AsGetDailyActivityTool(),
            client.AsGetDailyReadinessTool(),
            client.AsGetHeartRateTool(),
            client.AsGetSleepDataTool(),
        ];
    }
}
