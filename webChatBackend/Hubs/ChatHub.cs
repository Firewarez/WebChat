using Microsoft.AspNetCore.SignalR;

namespace webChatBackend.Hubs
{
    public class ChatHub : Hub
    {
        public async Task sendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
