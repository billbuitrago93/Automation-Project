using RestSharp;
using System.Text.Json;

namespace SapConcurApiClient.Api
{
    internal static class ConcurApiOAuthService
    {
        public static string GetAuthToken(string clientId, string clientSecret, string username, string password)
        {
            return MakeRequest(
                $"client_id={clientId}&" +
                $"client_secret={clientSecret}&" +
                $"grant_type=password&" +
                $"username={username}&" +
                $"password={password}");
        }

        public static string GetAuthToken(string clientId, string clientSecret)
        {
            return MakeRequest(
                 $"client_id={clientId}&" +
                 $"client_secret={clientSecret}&" +
                 $"grant_type=client_credentials");
        }

        private static string MakeRequest(string requestBody)
        {
            var client = new RestClient("https://us.api.concursolutions.com/oauth2/v0/token");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", requestBody, ParameterType.RequestBody);
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic? content = JsonSerializer.Deserialize<dynamic>(response.Content);
                if (content?.ContainsKey("access_token"))
                {
                    return content.access_token;
                }
            }
            throw new Exception(response.Content);
        }
    }
}
