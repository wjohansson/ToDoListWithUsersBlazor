using DataLibrary.Models;
using System.Text;
using System.Text.Json;

namespace ToDoListWithUsersBlazor.Services
{
    public class CategoryServiceUi
    {
        private readonly ApiService _apiService;

        public CategoryServiceUi(ApiService apiService)
        {
            _apiService = apiService;
        }

        public Task<List<CategoryModel>> GetCategories()
        {
            return _apiService.GetAsync<List<CategoryModel>>($"/Category/CurrentUserCategories");
        }

        public Task<CategoryModel> GetCategory(CategoryModel category)
        {
            var stringContent = JsonSerializer.Serialize(category);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<CategoryModel>($"/Category/Category", data);
        }

        public Task<CategoryModel> CreateCategory(CategoryModel category)
        {
            var stringContent = JsonSerializer.Serialize(category);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PostAsync<CategoryModel>($"/Category/Create", data);
        }

        public Task<CategoryModel> DeleteCategory(CategoryModel category)
        {
            var stringContent = JsonSerializer.Serialize(category);
            var data = new StringContent(stringContent, Encoding.UTF8, "application/json");
            return _apiService.PutAsync<CategoryModel>($"/Category/Delete", data);
        }
    }
}
