using DataLibrary.Models;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ToDoListWithUsersBlazor.Services
{
    public class TaskListServiceUi
    {
        private readonly ApiService _apiService;

        public TaskListServiceUi(ApiService apiService)
        {
            _apiService = apiService;
        }

        public Task<List<TaskListModel>> GetLists()
        {
            return _apiService.GetAsync<List<TaskListModel>>($"/TaskList/YourLists");
        }
        
        public Task<TaskListModel> GetList(Guid listId)
        {
            var stringContent = JsonSerializer.Serialize(listId);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<TaskListModel>($"/TaskList/List", data);
        }

        public Task<TaskListModel> CreateList(TaskListModel list)
        {
            var stringContent = JsonSerializer.Serialize(list);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PostAsync<TaskListModel>($"/TaskList/Create", data);
        }

        public Task<TaskListModel> EditList(TaskListModel list)
        {
            var stringContent = JsonSerializer.Serialize(list);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<TaskListModel>($"/TaskList/Edit", data);
        }

        public Task<TaskListModel> DeleteList(TaskListModel taskList)
        {
            var stringContent = JsonSerializer.Serialize(taskList);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<TaskListModel>($"/TaskList/Delete", data);
        }

        public Task<TaskListModel> UpdateSort(TaskListModel list)
        {
            var stringContent = JsonSerializer.Serialize(list);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<TaskListModel>($"/TaskList/SortTasksBy", data);
        }
    }
}
