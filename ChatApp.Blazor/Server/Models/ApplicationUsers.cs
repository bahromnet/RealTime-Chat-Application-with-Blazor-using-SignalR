using ChatApp.Blazor.Shared.Models;
using Microsoft.AspNetCore.Identity;

namespace ChatApp.Blazor.Server.Models;

public class ApplicationUsers : IdentityUser
{
    public virtual ICollection<ChatMessage> ChatMessagesFromUser { get; set; }
    public virtual ICollection<ChatMessage> ChatMessagesToUser { get; set; }

    public ApplicationUsers()
    {
        ChatMessagesFromUser = new HashSet<ChatMessage>();
        ChatMessagesToUser = new HashSet<ChatMessage>();
    }
}
