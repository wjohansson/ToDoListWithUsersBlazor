using System.Text;
using System.Text.Json;
using DataLibrary.Models;
using ToDoListWithUsersApi;

namespace ToDoListWithUsersBlazor.Services
{
    public class UserServiceUi
    {
        private readonly ApiService _apiService;

        public UserServiceUi(ApiService apiService)
        {
            _apiService = apiService;
        }

        public Task<List<UserModel>> GetUsers()
        {
            return _apiService.GetAsync<List<UserModel>>($"/User/AllUsers");
        }

        public Task<UserModel> GetUser()
        {
            return _apiService.GetAsync<UserModel>($"/User/User");
        }

        //public Task<List<UserModel>> GetUsers()
        //{
        //    return _apiService.GetAsync<List<UserModel>>($"/User/AllUsers");
        //}

        public Task<UserModel> CreateUser(UserModel user)
        {
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PostAsync<UserModel>($"/User/Create", data);
        }

        public Task<UserModel> Login(UserModel user)
        {
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PostAsync<UserModel>("/User/Login", data);
        }

        public Task<UserModel> Logout()
        {
            return _apiService.GetAsync<UserModel>($"/User/Logout");
        }

        public Task<UserModel> EditUser(UserModel user)
        {
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<UserModel>($"/User/Edit", data);
        }

        public Task<UserModel> ChangePassword(UserModel user)
        {
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<UserModel>($"/User/ChangePassword", data);
        }

        public Task<UserModel> ChangeOtherPassword(UserModel user)
        {
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<UserModel>($"/User/ChangeOtherPassword", data);
        }

        public Task<UserModel> DeleteUser(UserModel user)
        {
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<UserModel>($"/User/Delete", data);
        }

        public Task<UserModel> DeleteAnotherUser(UserModel user)
        {
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<UserModel>($"/User/DeleteAnother", data);
        }

        public Task<UserModel> UpdateSort(UserModel user)
        {
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<UserModel>($"/User/SortListsBy", data);
        }

        public Task<UserModel> PromoteUser(UserModel user)
        {
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<UserModel>($"/User/Promote", data);
        }

        public Task<UserModel> DemoteUser(UserModel user)
        {
            var stringContent = JsonSerializer.Serialize(user);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<UserModel>($"/User/Demote", data);
        }
    }
}
