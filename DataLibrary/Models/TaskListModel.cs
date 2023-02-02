using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DataLibrary.Enums;

namespace DataLibrary.Models
{
    public class TaskListModel
    {
        [Key]
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonPropertyName("title")]
        [Required]
        public string Title { get; set; }

        [JsonPropertyName("categoryId")]
        public Guid? CategoryId { get; set; }

        [JsonPropertyName("dateCreated")]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [JsonPropertyName("sortTasks")]
        public SortTasks SortTasks { get; set; } = SortTasks.New;

        [ForeignKey("TaskListId")]
        [JsonPropertyName("tasks")]
        public ICollection<TaskModel> Tasks { get; set; }

        [JsonPropertyName("userId")]
        public Guid UserId { get; set; }

        public TaskListModel()
        {
            Tasks = new List<TaskModel>();
        }
    }
}
