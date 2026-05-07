
#nullable enable

namespace Oura
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IOuraClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Oura.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Oura.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public DailyActivityRoutesClient DailyActivityRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public DailyCardiovascularAgeRoutesClient DailyCardiovascularAgeRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public DailyReadinessRoutesClient DailyReadinessRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public DailyResilienceRoutesClient DailyResilienceRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public DailySleepRoutesClient DailySleepRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public DailySpo2RoutesClient DailySpo2Routes { get; }

        /// <summary>
        /// 
        /// </summary>
        public DailyStressRoutesClient DailyStressRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public EnhancedTagRoutesClient EnhancedTagRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public HeartRateRoutesClient HeartRateRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public InterbeatIntervalRoutesClient InterbeatIntervalRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public PersonalInfoRoutesClient PersonalInfoRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public RestModePeriodRoutesClient RestModePeriodRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public RingBatteryLevelRoutesClient RingBatteryLevelRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public RingConfigurationRoutesClient RingConfigurationRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public SandboxRoutesClient SandboxRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public SessionRoutesClient SessionRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public SleepRoutesClient SleepRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public SleepTimeRoutesClient SleepTimeRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public TagRoutesClient TagRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public Vo2MaxRoutesClient Vo2MaxRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhookSubscriptionRoutesClient WebhookSubscriptionRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public WorkoutRoutesClient WorkoutRoutes { get; }

    }
}