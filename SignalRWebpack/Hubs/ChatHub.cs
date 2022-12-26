using Microsoft.AspNetCore.SignalR;

namespace SignalRWebpack.Hubs
{
    public class ChatHub : Hub
    {
        public async Task NewMessage(long user, string message) =>
            await Clients.All.SendAsync("messageReceived", user, message);
    }
}
