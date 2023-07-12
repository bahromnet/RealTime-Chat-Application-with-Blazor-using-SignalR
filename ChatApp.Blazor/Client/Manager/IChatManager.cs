using ChatApp.Blazor.Shared.Models;

namespace ChatApp.Blazor.Client.Manager;

public interface IChatManager
{
    Task<List<ApplicationUser>> GetUsersAsync();
    Task<ApplicationUser> GetUserDetailsAsync(string UserId);
    Task<List<ChatMessage>> GetConversationAsync(string contactId);
    Task SavaChangesAsync(ChatMessage message);
}
