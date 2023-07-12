using ChatApp.Blazor.Shared.Models;
using System.Net.Http.Json;

namespace ChatApp.Blazor.Client.Manager;

public class ChatManager : IChatManager
{
    private readonly HttpClient _httpClient;

    public ChatManager(HttpClient httpClient)
        => _httpClient = httpClient;

    public async Task<List<ChatMessage>> GetConversationAsync(string contactId)
    {
        var chatMessages = await _httpClient.GetFromJsonAsync<List<ChatMessage>>($"api/chat/{contactId}");
        return chatMessages!;
    }

    public async Task<List<ApplicationUser>> GetUsersAsync()
    {
        var yusers = await _httpClient.GetFromJsonAsync<List<ApplicationUser>>($"api/chat/users");
        return yusers!;
    }

    public async Task<ApplicationUser> GetUserDetailsAsync(string userId)
    {
        var yuser = await _httpClient.GetFromJsonAsync<ApplicationUser>($"api/chat/users/{userId}");
        return yuser!;
    }

    public async Task SavaChangesAsync(ChatMessage message)
    {
        await _httpClient.PostAsJsonAsync("api/chat", message);
    }
}
