
#nullable enable

namespace Oura
{
    /// <summary>
    /// # Overview <br/>
    /// The Oura API allows Oura users and partner applications to improve their user experience with Oura data.<br/>
    /// This document describes the Oura API Version 2 (V2), which is the only available integration point for Oura data. The previous V1 API has been sunset.<br/>
    /// # Getting Started <br/>
    /// ## What is an API?<br/>
    /// An API (Application Programming Interface) allows different software applications to communicate with each other. The Oura API enables you to access your Oura Ring data programmatically.<br/>
    /// ## Quick Start Guide<br/>
    /// 1. Register an [API Application](https://cloud.ouraring.com/oauth/applications) and implement OAuth2<br/>
    /// 2. **Make Your First API Call**:<br/>
    ///    ```<br/>
    ///    curl -X GET https://api.ouraring.com/v2/usercollection/personal_info \<br/>
    ///    -H "Authorization: Bearer YOUR_TOKEN_HERE"<br/>
    ///    ```<br/>
    /// 3. **Explore Data Types**:<br/>
    ///    - Browse the available endpoints in this documentation to discover what data you can access<br/>
    ///    - Each endpoint includes example requests and responses<br/>
    /// 4. **Set Up Webhooks (Strongly Recommended)**:<br/>
    ///    - Webhooks are the preferred way to consume Oura data<br/>
    ///    - We have not had customers hit rate limits with webhooks properly implemented<br/>
    ///    - Make a single request for historical data when a user first connects, then use webhooks for ongoing updates<br/>
    ///    - Webhook notifications come approximately 30 seconds after data syncs from the mobile app<br/>
    ///    - [Set up webhooks](#tag/Webhook-Subscription-Routes) to receive notifications when data changes<br/>
    /// ## Common Questions<br/>
    /// - **Data Delay**: Different data types sync at different times - sleep data requires users to open the Oura app, while daily activity and stress may sync in the background<br/>
    /// # Data Access<br/>
    /// In order to access data, a registered [API Application](https://cloud.ouraring.com/oauth/applications) is required.<br/>
    ///  API Applications are limited to **10** users before requiring approval from Oura. There is no limit once an application is approved.<br/>
    ///  Additionally, Oura users **must provide consent** to share each data type an API Application has access to.<br/>
    /// All data access requests through the Oura API require [Authentication](https://cloud.ouraring.com/docs/authentication).<br/>
    /// Additionally, we recommend that Oura users keep their mobile app updated to support API access for the latest data types.<br/>
    /// # Authentication<br/>
    /// The Oura Cloud API supports authentication through the industry-standard OAuth2 protocol. For more information, see our [Authentication instructions](https://cloud.ouraring.com/docs/authentication).<br/>
    /// Access tokens must be included in the request header as follows:<br/>
    /// ```http<br/>
    /// GET /v2/usercollection/personal_info HTTP/1.1<br/>
    /// Host: api.ouraring.com<br/>
    /// Authorization: Bearer &lt;token&gt;<br/>
    /// ```<br/>
    /// Please note that personal access tokens were deprecated in December 2025 and are no longer available for use.<br/>
    /// # Oura HTTP Response Codes<br/>
    /// | Response Code                        | Description |<br/>
    /// | ------------------------------------ | - |<br/>
    /// | 200 OK                               | Successful Response         |<br/>
    /// | 400 Query Parameter Validation Error | The request contains query parameters that are invalid or incorrectly formatted. |<br/>
    /// | 401 Unauthorized                     | Invalid or expired authentication token. |<br/>
    /// | 403 Forbidden                        | The requested resource requires additional permissions or the user's Oura subscription has expired. |<br/>
    /// | 429 Too Many Requests                | Rate limit exceeded. See response headers for retry guidance. |<br/>
    /// ## Rate Limits<br/>
    /// The API enforces rate limits at two layers to ensure fair access across all applications:<br/>
    /// - a per-access-token limit, which throttles single-token floods, and<br/>
    /// - a per-application limit, which caps the aggregate traffic across all of an application's end-user tokens so one fan-out app can't dominate shared capacity.<br/>
    /// A request that trips either layer receives a `429 Too Many Requests`. The `X-RateLimit-Tier` response header identifies which layer fired.<br/>
    /// If your application regularly approaches rate limits, [webhooks](#tag/Webhook-Subscription-Routes) are strongly recommended — most applications that implement webhooks correctly do not encounter rate limit issues.<br/>
    /// [Contact us](mailto:api-support@ouraring.com) if you expect your usage to require higher limits.<br/>
    /// ## Rate Limit Response Headers<br/>
    /// When a `429 Too Many Requests` response is returned, five headers are included to guide retries. Prefer these over fixed-interval backoff:<br/>
    /// - **`Retry-After`** — integer seconds to wait before retrying. RFC 7231-compliant; safe to feed directly into your client's backoff logic.<br/>
    /// - **`X-RateLimit-Limit`** — the request ceiling for the current window.<br/>
    /// - **`X-RateLimit-Window`** — the rolling window length in seconds that the ceiling applies to.<br/>
    /// - **`X-RateLimit-Reset`** — Unix epoch (seconds) at which the window resets and quota is fully restored.<br/>
    /// - **`X-RateLimit-Tier`** — identifies which limit was exceeded, useful when contacting support.<br/>
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
        /// The Daily Activity scope includes daily activity summary values and detailed activity levels. Activity levels are expressed in [metabolic equivalent of task minutes](https://en.wikipedia.org/wiki/Metabolic_equivalent) (MET mins). Oura tracks activity based on the movement.
        /// </summary>
        public DailyActivityRoutesClient DailyActivityRoutes { get; }

        /// <summary>
        /// Cardiovascular Age is an estimate of the health of your cardiovascular system in relation to your actual age. See more details [here](https://support.ouraring.com/hc/en-us/articles/28451491040019-Cardiovascular-Age).
        /// </summary>
        public DailyCardiovascularAgeRoutesClient DailyCardiovascularAgeRoutes { get; }

        /// <summary>
        /// Readiness tells how ready you are for the day.
        /// </summary>
        public DailyReadinessRoutesClient DailyReadinessRoutes { get; }

        /// <summary>
        /// Resilience is an estimate of your ability to withstand physiological stress and recover from it over time.
        /// </summary>
        public DailyResilienceRoutesClient DailyResilienceRoutes { get; }

        /// <summary>
        /// Sleep period is a nearly continuous, longish period of time spent lying down in bed.
        /// </summary>
        public DailySleepRoutesClient DailySleepRoutes { get; }

        /// <summary>
        /// The Daily SpO2 (blood oxygenation) routes include daily SpO2 average. Data will only be available for users with a Gen 3 Oura Ring.
        /// </summary>
        public DailySpo2RoutesClient DailySpo2Routes { get; }

        /// <summary>
        /// The daily stress route includes a summary of the number of minutes the user spends in high stress and high recovery each day. This is a great way to see how your stress and recovery are trending over time. Stress and recovery are mutally exclusive. E.g. one can only be stressed or recovered at any given moement - and cannot be stressed and recovered at the same time.
        /// </summary>
        public DailyStressRoutesClient DailyStressRoutes { get; }

        /// <summary>
        /// The Enhanced Tags data scope includes tags that Oura users enter within the Oura mobile app. Enhanced Tags can be added for any lifestyle choice, habit, mood change, or environmental factor an Oura user wants to monitor the effects of. Enhanced Tags also contain context on a tag's start and end time, whether a tag repeats daily, and comments.<br/>
        /// [Learn more about how Oura users add Enhanced Tags](https://support.ouraring.com/hc/en-us/articles/360038676993-How-to-Use-Tags).
        /// </summary>
        public EnhancedTagRoutesClient EnhancedTagRoutes { get; }

        /// <summary>
        /// The Heart Rate data scope includes time-series heart rate data throughout the day and night. Heart rate is provided at 5-minute increments. For heart rate data recorded from a Session, see Sessions endpoint.
        /// </summary>
        public HeartRateRoutesClient HeartRateRoutes { get; }

        /// <summary>
        /// The Personal Info scope includes personal information (e.g. age, email, weight, and height) about the user. You can access the id on the personal_info route with any access token (no scopes are required).
        /// </summary>
        public PersonalInfoRoutesClient PersonalInfoRoutes { get; }

        /// <summary>
        /// The Rest Mode scope includes information about rest mode periods. This includes the start, end time and detaials of the rest mode period.
        /// </summary>
        public RestModePeriodRoutesClient RestModePeriodRoutes { get; }

        /// <summary>
        /// 
        /// </summary>
        public RingBatteryLevelRoutesClient RingBatteryLevelRoutes { get; }

        /// <summary>
        /// The Ring Configuration scope includes information about the user's ring(s). This includes the model, size, color, etc.
        /// </summary>
        public RingConfigurationRoutesClient RingConfigurationRoutes { get; }

        /// <summary>
        /// Fake user data that you can access without an Oura account. There is a corresponding sandbox endpoint to each available data type. This is useful for testing and development purposes. The data is not real and should not be used for any production purposes. The data is generated by Oura and is not based on any real user data. The data is not updated in real-time and is not guaranteed to be accurate. The rate limit for the sandbox endpoints is shared with your rate limit on other data endpoints.
        /// </summary>
        public SandboxRoutesClient SandboxRoutes { get; }

        /// <summary>
        /// The Sessions data scope provides information on how users engage with guided and unguided sessions in the Oura app, including the user's biometric trends during the sessions.
        /// </summary>
        public SessionRoutesClient SessionRoutes { get; }

        /// <summary>
        /// Returns Oura Sleep data for the specified Oura user within a given timeframe. A user can have multiple sleep periods per day.
        /// </summary>
        public SleepRoutesClient SleepRoutes { get; }

        /// <summary>
        /// Recommendations for the optimal bedtime window that is calculated based on sleep data.
        /// </summary>
        public SleepTimeRoutesClient SleepTimeRoutes { get; }

        /// <summary>
        /// &lt;span className='text-important'&gt;**Note:** Tag is deprecated. We recommend transitioning to [Enhanced Tag](#tag/Enhanced-Tag-Routes).&lt;/span&gt;<br/>
        /// ~~The Tags data scope includes tags that Oura users enter within the Oura mobile app. Tags are a growing list of activities, environment factors, symptoms, emotions, and other aspects that provide broader context into what's happening with users beyond the objective data generated by the Oura Ring.~~<br/>
        /// ~~[More information on tag translations](https://cloud.ouraring.com/edu/tag-translations)~~.
        /// </summary>
        public TagRoutesClient TagRoutes { get; }

        /// <summary>
        /// VO2 Max is a measure of the maximum volume of oxygen that an individual can use during intense exercise. See more details [here](https://support.ouraring.com/hc/en-us/articles/28336620578835-Cardio-Capacity-VO2-Max).
        /// </summary>
        public Vo2MaxRoutesClient Vo2MaxRoutes { get; }

        /// <summary>
        /// # Webhooks for Real-Time Data Updates<br/>
        /// ## What are Webhooks?<br/>
        /// Webhooks are a way for the Oura API to notify your application when new data is available, instead of requiring your application to constantly check for updates (polling). Think of webhooks as "reverse APIs" - instead of your application requesting data, Oura's servers send data to your application when something changes.<br/>
        /// ## Why Use Webhooks (Important!)<br/>
        /// - **RECOMMENDED APPROACH**: Webhooks are the preferred way to consume Oura data<br/>
        /// - **Avoid Rate Limits**: We have not had customers hit rate limits with webhooks properly implemented<br/>
        /// - **Near Real-Time Updates**: Webhook notifications come approximately 30 seconds after data syncs from the mobile app<br/>
        /// - **Efficient Resource Usage**: Reduces unnecessary API calls and server load<br/>
        /// - **Better User Experience**: Your application stays updated without constant polling<br/>
        /// ## How Webhooks Work with Oura<br/>
        /// 1. **You set up an endpoint**: Create a URL on your server that can receive POST requests<br/>
        /// 2. **You subscribe to events**: Tell Oura what data types and events you want to be notified about<br/>
        /// 3. **Oura verifies your endpoint**: A one-time check to ensure your endpoint is valid<br/>
        /// 4. **Oura sends notifications**: When data changes, Oura sends a POST request to your endpoint<br/>
        /// 5. **You process the event**: Your endpoint receives basic event details<br/>
        /// 6. **You fetch complete data**: Use the provided IDs to retrieve the full data via the API<br/>
        /// ## Recommended Implementation Pattern<br/>
        /// 1. **Initial Data Load**: When a user first connects, make a single API request for historical data<br/>
        /// 2. **Subscribe to Webhooks**: Set up webhook subscriptions for all data types you need<br/>
        /// 3. **Process Webhook Events**: As users sync their rings, you'll receive notifications about new data<br/>
        /// 4. **Fetch Updated Data**: Use the object_id from webhook events to fetch the specific updated data<br/>
        /// This pattern minimizes API calls while ensuring your application always has the latest data.<br/>
        /// ## Setup Guide<br/>
        /// ### Step 1: Create Your Webhook Endpoint<br/>
        /// Set up an HTTP endpoint on your server that can:<br/>
        /// - Handle both GET requests (for verification) and POST requests (for events)<br/>
        /// - Respond to verification challenges during subscription setup<br/>
        /// - Process incoming webhook events quickly (under 10 seconds)<br/>
        /// Example endpoint implementation (Node.js):<br/>
        /// ```javascript<br/>
        /// // Express.js route handlers for your webhook endpoint<br/>
        /// app.get('/oura-webhook', (req, res) =&gt; {<br/>
        ///   // Verification handler - required during subscription setup<br/>
        ///   const { verification_token, challenge } = req.query;<br/>
        ///   // Verify the token matches your expected token<br/>
        ///   if (verification_token === YOUR_VERIFICATION_TOKEN) {<br/>
        ///     // Return the challenge in the required format<br/>
        ///     return res.json({ challenge });<br/>
        ///   }<br/>
        ///   // If verification fails<br/>
        ///   return res.status(401).send('Invalid verification token');<br/>
        /// });<br/>
        /// app.post('/oura-webhook', (req, res) =&gt; {<br/>
        ///   // Event handler - processes incoming webhook events<br/>
        ///   // Always respond quickly (under 10 seconds)<br/>
        ///   // Process the event asynchronously if needed<br/>
        ///   res.status(200).send('OK');<br/>
        ///   // Then process the event data<br/>
        ///   const { event_type, data_type, object_id, user_id } = req.body;<br/>
        ///   processEventAsync(event_type, data_type, object_id, user_id);<br/>
        /// });<br/>
        /// ```<br/>
        /// ### Step 2: Create a Webhook Subscription<br/>
        /// Call the `POST /v2/webhook/subscription` endpoint to register your webhook:<br/>
        /// ```<br/>
        /// POST /v2/webhook/subscription<br/>
        /// Headers:<br/>
        ///   x-client-id: YOUR_CLIENT_ID<br/>
        ///   x-client-secret: YOUR_CLIENT_SECRET<br/>
        ///   Content-Type: application/json<br/>
        /// Body:<br/>
        /// {<br/>
        ///   "callback_url": "https://your-server.com/oura-webhook",<br/>
        ///   "verification_token": "your-secret-verification-token",<br/>
        ///   "event_type": "update",<br/>
        ///   "data_type": "sleep"<br/>
        /// }<br/>
        /// ```<br/>
        /// You need to create separate subscriptions for each combination of:<br/>
        /// - **event_type**: The type of event (create, update, delete)<br/>
        /// - **data_type**: The type of data you're interested in (sleep, activity, etc.)<br/>
        /// ### Step 3: Verification Process<br/>
        /// When you create a subscription, Oura verifies your endpoint:<br/>
        /// 1. Oura sends a GET request to your callback URL with query parameters:<br/>
        ///    ```<br/>
        ///    GET https://your-server.com/oura-webhook?verification_token=your-token&amp;challenge=random-string<br/>
        ///    ```<br/>
        /// 2. Your endpoint must verify the token and respond with the challenge:<br/>
        ///    ```json<br/>
        ///    {<br/>
        ///      "challenge": "random-string"<br/>
        ///    }<br/>
        ///    ```<br/>
        /// 3. If verification succeeds, your subscription is activated<br/>
        /// ![Verification Flow](/img/webhook-verification-flow-diagram.drawio.png)<br/>
        /// ### Step 4: Receiving and Processing Events<br/>
        /// When an event occurs (e.g., user syncs new sleep data):<br/>
        /// 1. Oura sends a POST request to your callback URL:<br/>
        ///    ```<br/>
        ///    POST https://your-server.com/oura-webhook<br/>
        ///    Headers:<br/>
        ///      x-oura-signature: HMAC_SIGNATURE<br/>
        ///      x-oura-timestamp: 1234567890<br/>
        ///    Body:<br/>
        ///    {<br/>
        ///      "event_type": "update",<br/>
        ///      "data_type": "sleep",<br/>
        ///      "object_id": "12345abc",<br/>
        ///      "event_time": "2023-01-01T08:00:00+00:00",<br/>
        ///      "user_id": "user123"<br/>
        ///    }<br/>
        ///    ```<br/>
        /// 2. Your endpoint should:<br/>
        ///    - Verify the signature for security (see below)<br/>
        ///    - Respond quickly (under 10 seconds) with a 2xx status<br/>
        ///    - Process the event asynchronously if needed<br/>
        ///    - Use the object_id to fetch the complete data via the API<br/>
        /// ## Security Best Practices<br/>
        /// ### Verify Webhook Signatures<br/>
        /// Always verify that webhook requests are actually from Oura by checking the HMAC signature:<br/>
        /// ```javascript<br/>
        /// const crypto = require('crypto');<br/>
        /// function verifySignature(headers, body, clientSecret) {<br/>
        ///   const signature = headers['x-oura-signature'];<br/>
        ///   const timestamp = headers['x-oura-timestamp'];<br/>
        ///   // Create HMAC using your client secret<br/>
        ///   const hmac = crypto.createHmac('sha256', clientSecret);<br/>
        ///   hmac.update(timestamp + JSON.stringify(body));<br/>
        ///   const calculatedSignature = hmac.digest('hex').toUpperCase();<br/>
        ///   // Compare calculated signature with received signature<br/>
        ///   return calculatedSignature === signature;<br/>
        /// }<br/>
        /// // In your webhook handler<br/>
        /// app.post('/oura-webhook', (req, res) =&gt; {<br/>
        ///   // Verify signature<br/>
        ///   if (!verifySignature(req.headers, req.body, CLIENT_SECRET)) {<br/>
        ///     return res.status(401).send('Invalid signature');<br/>
        ///   }<br/>
        ///   // Process valid webhook<br/>
        ///   res.status(200).send('OK');<br/>
        ///   // ...<br/>
        /// });<br/>
        /// ```<br/>
        /// ### Use HTTPS<br/>
        /// Always use HTTPS for your webhook endpoint to ensure data is encrypted in transit.<br/>
        /// ### Keep Your Verification Token Secret<br/>
        /// Choose a strong, random verification token and don't share it.<br/>
        /// ## Handling Webhook Failures<br/>
        /// ### Retry Mechanism<br/>
        /// Oura will retry failed webhook deliveries:<br/>
        /// - For 4xx responses: 10 retries<br/>
        /// - For 5xx responses: 10 retries<br/>
        /// - For timeouts: 10 retries<br/>
        /// ### Canceling Subscriptions<br/>
        /// If you want to cancel a subscription, you can:<br/>
        /// - Use the DELETE endpoint: `DELETE /v2/webhook/subscription/{id}`<br/>
        /// - Or respond with a 410 status code to automatically cancel<br/>
        /// ## Common Questions<br/>
        /// ### How quickly will I receive webhooks?<br/>
        /// Webhook notifications arrive approximately 30 seconds after data syncs from the mobile app. The timing depends on the data type:<br/>
        /// - **Sleep, Readiness, and other user-initiated sync data**: These only sync when the user opens the Oura app and actively syncs their ring<br/>
        /// - **Daily Activity, Daily Stress, and other background data**: These may update periodically in the background without user action<br/>
        /// ### What if my server goes down?<br/>
        /// Oura will retry webhook deliveries for about an hour if your server doesn't respond properly. However, if your server is down for an extended period, you might miss some events. It's a good practice to implement a reconciliation process that can fetch data for periods when your webhook might have been unavailable.<br/>
        /// ### How can I test webhooks locally?<br/>
        /// Use a tool like [ngrok](https://ngrok.com/) to expose your local development server to the internet with a public URL.<br/>
        /// ### Can I use the same callback URL for different subscriptions?<br/>
        /// Yes, you can use the same URL for multiple subscriptions. Your handler can differentiate between events using the `event_type` and `data_type` fields in the webhook payload.<br/>
        /// ### Will I hit rate limits using webhooks?<br/>
        /// We have not had customers hit rate limits with webhooks properly implemented. The recommended pattern is:<br/>
        /// 1. Make a single request for historical data when a user first connects<br/>
        /// 2. Use webhooks for all ongoing data updates<br/>
        /// 3. Only fetch the specific data that has changed based on webhook notifications<br/>
        /// This approach minimizes API calls while ensuring your application always has the latest data.
        /// </summary>
        public WebhookSubscriptionRoutesClient WebhookSubscriptionRoutes { get; }

        /// <summary>
        /// The Workout data scope includes information about user workouts. This is a diverse, growing list of workouts that help inform how the user is training and exercising.
        /// </summary>
        public WorkoutRoutesClient WorkoutRoutes { get; }

    }
}