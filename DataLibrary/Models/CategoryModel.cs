using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DataLibrary.Enums;

namespace DataLibrary.Models
{
    public class CategoryModel
    {
        [Key]
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonPropertyName("title")]
        [Required]
        public string Title { get; set; }

        [JsonPropertyName("dateCreated")]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [JsonPropertyName("sortLists")]
        public SortTasks SortLists { get; set; } = SortTasks.New;

        [ForeignKey("CategoryId")]
        [JsonPropertyName("taskLists")]
        public ICollection<TaskListModel> TaskLists { get; set; }

        [JsonPropertyName("userId")]
        public Guid UserId { get; set; }

        public CategoryModel()
        {
            TaskLists = new List<TaskListModel>();
        }
    }
}
