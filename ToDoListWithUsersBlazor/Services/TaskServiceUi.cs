using DataLibrary.Models;
using System.Text;
using System.Text.Json;

namespace ToDoListWithUsersBlazor.Services
{
    public class TaskServiceUi
    {
        private readonly ApiService _apiService;

        public TaskServiceUi(ApiService apiService)
        {
            _apiService = apiService;
        }

        public Task<List<TaskModel>> GetTasks()
        {
            return _apiService.GetAsync<List<TaskModel>>($"/Task/CurrentListTasks");
        }

        public Task<TaskModel> GetTask(Guid taskId)
        {
            var stringContent = JsonSerializer.Serialize(taskId);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<TaskModel>($"/Task/Task", data);
        }

        public Task<TaskModel> CreateTask(TaskModel task)
        {
            var stringContent = JsonSerializer.Serialize(task);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PostAsync<TaskModel>($"/Task/Create", data);
        }

        public Task<TaskModel> EditTask(TaskModel task)
        {
            var stringContent = JsonSerializer.Serialize(task);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<TaskModel>($"/Task/Edit", data);
        }

        public Task<TaskModel> DeleteTask(TaskModel task)
        {
            var stringContent = JsonSerializer.Serialize(task);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<TaskModel>($"/Task/Delete", data);
        }

        public Task<TaskModel> UpdateSort(TaskModel task)
        {
            var stringContent = JsonSerializer.Serialize(task);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<TaskModel>($"/Task/SortSubTasksBy", data);
        }

        public Task<TaskModel> ToggleComplete(TaskModel task)
        {
            var stringContent = JsonSerializer.Serialize(task);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<TaskModel>($"/Task/ToggleCompletion", data);
        }
    }
}
