
#nullable enable

namespace Oura
{
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
    /// This approach minimizes API calls while ensuring your application always has the latest data.<br/>
    ///         <br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IWebhookSubscriptionRoutesClient : global::System.IDisposable
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


    }
}