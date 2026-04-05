# CLAUDE.md -- Oura SDK

## Overview

Auto-generated C# SDK for [Oura Ring](https://ouraring.com/) -- health wearable API for sleep, activity, readiness, heart rate, HRV, SpO2, stress, and more.
OpenAPI spec from `https://cloud.ouraring.com/v2/static/json/openapi-1.28.json` (OpenAPI 3.1.0, downgraded to 3.0.3 by `generate.sh`).

## Build & Test

```bash
dotnet build Oura.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Standard Bearer token auth (OAuth2 / Personal Access Token):

```csharp
var client = new OuraClient(apiKey); // OURA_API_KEY env var
```

## Key Files

- `src/libs/Oura/openapi.json` -- OpenAPI spec (downloaded + converted from 3.1.0 to 3.0.3)
- `src/libs/Oura/generate.sh` -- Downloads spec, converts 3.1->3.0.3 (nullable anyOf, server URL), runs autosdk
- `src/libs/Oura/Generated/` -- **Never edit** -- auto-generated code (~349 files)
- `src/libs/Oura/Extensions/OuraClientExtensions.AIFunctions.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

**OpenAPI 3.1.0 -> 3.0.3 conversion:** The Oura spec uses 3.1 features (anyOf nullable patterns, `examples` keyword). `generate.sh` converts these to 3.0.3 equivalents:
- `anyOf: [{type: X}, {type: null}]` -> `type: X, nullable: true`
- `anyOf: [{$ref: ...}, {type: null}]` -> `allOf: [{$ref: ...}], nullable: true`
- Multi-type anyOf with null -> removes null, adds `nullable: true`
- `examples` array -> `example` (first item)

**Server URL fix:** Spec has `https://api.None` -- fixed to `https://api.ouraring.com`.

## Sub-client Pattern

```csharp
var client = new OuraClient(apiKey);

// Daily summaries
client.DailySleepRoutes.*       // Daily sleep scores
client.DailyActivityRoutes.*    // Daily activity (steps, calories, MET)
client.DailyReadinessRoutes.*   // Daily readiness scores
client.DailyStressRoutes.*      // Daily stress data
client.DailySpo2Routes.*        // Daily SpO2 (blood oxygen)
client.DailyResilienceRoutes.*  // Daily resilience
client.DailyCardiovascularAgeRoutes.* // Cardiovascular age

// Detailed data
client.SleepRoutes.*            // Detailed sleep periods (stages, HRV, HR)
client.HeartRateRoutes.*        // Heart rate time series
client.SessionRoutes.*          // Guided/unguided sessions
client.WorkoutRoutes.*          // Workout data

// Other
client.PersonalInfoRoutes.*     // User personal info
client.RingConfigurationRoutes.* // Ring info (model, size, color)
client.TagRoutes.*              // Tags (deprecated, use EnhancedTag)
client.EnhancedTagRoutes.*      // Enhanced tags
client.SleepTimeRoutes.*        // Optimal bedtime recommendations
client.Vo2MaxRoutes.*           // VO2 Max / Cardio Capacity
client.RestModePeriodRoutes.*   // Rest mode periods
client.WebhookSubscriptionRoutes.* // Webhook management
client.SandboxRoutes.*          // Sandbox/test data
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsGetDailySleepTool()` -- Get daily sleep scores for a date range
- `AsGetDailyActivityTool()` -- Get daily activity metrics (steps, calories, etc.)
- `AsGetDailyReadinessTool()` -- Get daily readiness scores
- `AsGetHeartRateTool()` -- Get heart rate time-series data
- `AsGetSleepDataTool()` -- Get detailed sleep periods (stages, HRV, HR, breathing)
- `AsTools()` -- Get all 5 tools as a list
