namespace DraftKings.Services
{
    /// <summary>
    /// Client
    /// </summary>
    public static class Client
    {
        private static readonly string baseAddress = "https://jsonmock.hackerrank.com/api";

        /// <summary>
        /// Get Client.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <returns></returns>
        public static HttpClient GetClient(this HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri(baseAddress);

            return httpClient;
        }
    }
}
