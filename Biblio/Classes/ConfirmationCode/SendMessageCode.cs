using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Biblio.Classes.ConfirmationCode
{
    internal class SendMessageCode
    {
        private const string Url = "http://192.168.234.155/api.php";

        public async Task<PostResult> SendPostRequest(string email, string code)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Host = new Uri(Url).Host;

                var data = new Dictionary<string, string>
                {
                    { "send_email", email },
                    { "code", code }
                };

                var content = new FormUrlEncodedContent(data);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                content.Headers.ContentType.CharSet = "utf-8";

                try
                {
                    HttpResponseMessage response = await client.PostAsync(Url, content);

                    string responseBody = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        return new PostResult
                        {
                            IsSuccess = true,
                            StatusCode = (int)response.StatusCode,
                            ResponseContent = responseBody
                        };
                    }
                    else
                    {
                        return new PostResult
                        {
                            IsSuccess = false,
                            StatusCode = (int)response.StatusCode,
                            ErrorMessage = $"Request failed with status code: {(int)response.StatusCode}. Response: {responseBody}"
                        };
                    }
                }
                catch (HttpRequestException ex)
                {
                    return new PostResult
                    {
                        IsSuccess = false,
                        ErrorMessage = $"HTTP Request Error: {ex.Message}"
                    };
                }
                catch (JsonException ex)
                {
                    return new PostResult
                    {
                        IsSuccess = false,
                        ErrorMessage = $"JSON Deserialization Error: {ex.Message}"
                    };
                }
                catch (Exception ex)
                {
                    return new PostResult
                    {
                        IsSuccess = false,
                        ErrorMessage = $"An unexpected error occurred: {ex.Message}"
                    };
                }
            }
        }
    }

    public class PostResult
    {
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        public string ResponseContent { get; set; }
        public string ErrorMessage { get; set; }
    }
}
