using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace chatgpt_app.service
{
    public class AppDbContext
    {
        private readonly ChatService _chatService;
        public AppDbContext()
        {
            var httpClient = new HttpClient();
            var apiUrl = "https://chatgpt-backend-ao6m.onrender.com/api/";

            _chatService = new ChatService(httpClient, apiUrl);
        }

        public async Task<string> SendMessage(string message, bool gptOrGemini)
        {
            return await _chatService.SendMessageAsync(message, gptOrGemini);
        }
    }
}
