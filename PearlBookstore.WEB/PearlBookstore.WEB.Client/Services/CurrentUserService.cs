using Blazored.LocalStorage;
using PearlBookstore.Shared.RequestsResponses.Responses;
using PearlBookstore.WEB.Client.Models;

namespace PearlBookstore.WEB.Client.Services
{
    public class CurrentUserService(ILocalStorageService localStotage)
    {
        public async Task<bool> IsLoggedUser()
        {
            return await Task.FromResult(await localStotage.ContainKeyAsync("currentUser"));
        }

        public async Task<CurrentUser> GetCurrentUser()
        {
            return await Task.FromResult(await localStotage.GetItemAsync<CurrentUser>("currentUser"));
        }

        public async Task RemoveCurrentUser()
        {
            await localStotage.RemoveItemAsync("currentUser");
        }

        public async Task AddCurrentUser(LoginResponse response)
        {
            CurrentUser user = new()
            {
                ID = response.Id,
                Name = response.Name,
                Surname = response.Surname,
                RoleID = response.RoleId,
                RoleName = response.RoleName,
                Initials = $"{response.Name[0].ToString().ToUpper()}{response.Surname[0].ToString().ToUpper()}"
            };
            await localStotage.SetItemAsync<CurrentUser>("currentUser", user);
        }
    }
}
