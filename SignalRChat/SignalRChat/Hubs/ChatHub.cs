using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    /// <summary>
    /// ChatHub is a class that serves as a high-level pipeline that handles client-server communication
    /// It inherits from the SignalR Hub class and the Hub class manages connections, groups, and messaging.
    /// </summary>
    public class ChatHub :Hub
    {
        /// <summary>
        /// This method is called by a connected client to send a message to all clients. 
        /// A JavaScript client code calls this method.
        /// The asynchronous SignalR code provides maximum scalability.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage",user, message);
        }
    }
}
