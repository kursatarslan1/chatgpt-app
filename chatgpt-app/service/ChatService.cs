using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json; // JSON serileştirmek için Newtonsoft.Json kütüphanesini kullanabilirsiniz

namespace chatgpt_app.service
{
    public class ChatService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public ChatService(HttpClient httpClient, string apiUrl)
        {
            _httpClient = httpClient;
            _apiUrl = apiUrl;
        }

        public async Task<string> SendMessageAsync(string userMessage)
        {
            var requestBody = new
            {
                message = userMessage
            };

            var json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try { 
                var response = await _httpClient.PostAsync(_apiUrl + "chat", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseData);
                    return jsonResponse.reply;
                }
                else
                {
                    throw new Exception("API isteği başarısız oldu: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                return null;
            }
        }
    }
}
