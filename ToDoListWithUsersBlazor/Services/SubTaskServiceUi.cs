using DataLibrary.Models;
using System.Text;
using System.Text.Json;

namespace ToDoListWithUsersBlazor.Services
{
    public class SubTaskServiceUi
    {
        private readonly ApiService _apiService;

        public SubTaskServiceUi(ApiService apiService)
        {
            _apiService = apiService;
        }

        public Task<List<SubTaskModel>> GetSubTasks()
        {
            return _apiService.GetAsync<List<SubTaskModel>>($"/SubTask/CurrentTaskSubTasks");
        }

        public Task<SubTaskModel> GetSubTask(Guid subTaskId)
        {
            var stringContent = JsonSerializer.Serialize(subTaskId);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<SubTaskModel>($"/SubTask/SubTask", data);
        }

        public Task<SubTaskModel> CreateSubTask(SubTaskModel subTask)
        {
            var stringContent = JsonSerializer.Serialize(subTask);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PostAsync<SubTaskModel>($"/SubTask/Create", data);
        }

        public Task<SubTaskModel> EditSubTask(SubTaskModel subTask)
        {
            var stringContent = JsonSerializer.Serialize(subTask);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<SubTaskModel>($"/SubTask/Edit", data);
        }

        public Task<SubTaskModel> DeleteSubTask(SubTaskModel subTask)
        {
            var stringContent = JsonSerializer.Serialize(subTask);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<SubTaskModel>($"/SubTask/Delete", data);
        }
    }
}
