using Microsoft.JSInterop;
using System.Text.Json;

namespace PearlBookstore.WEB.Client.Services
{
    public class CurrentUser(IJSRuntime jsRuntime)
    {
        private const string UserStateKey = "userState";

        public async Task SetUserStateAsync(UserState state)
        {
            var stateJson = JsonSerializer.Serialize(state);
            await jsRuntime.InvokeVoidAsync("localStorage.setItem", UserStateKey, stateJson);
        }

        public async Task<UserState?> GetUserStateAsync()
        {
            var stateJson = await jsRuntime.InvokeAsync<string>("localStorage.getItem", UserStateKey);
            return stateJson == null ? new UserState() : JsonSerializer.Deserialize<UserState>(stateJson);
        }

        public async Task ClearUserStateAsync()
        {
            await jsRuntime.InvokeVoidAsync("localStorage.removeItem", UserStateKey);
        }
    }

    public class UserState
    {
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public string Initials { get; set; } = string.Empty;

        public int RoleID { get; set; }

        public string RoleName { get; set; } = string.Empty;

        public bool IsLogged { get; set; } = false;
    }
}
