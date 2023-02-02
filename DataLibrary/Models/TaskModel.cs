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
    public class TaskModel
    {
        [Key]
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonPropertyName("title")]
        [Required]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        [Required]
        public string Description { get; set; }

        [JsonPropertyName("completed")]
        public bool Completed { get; set; } = false;

        [JsonPropertyName("priority")]
        [Required]
        public Priority? Priority { get; set; }

        [JsonPropertyName("dateCreated")]
        public DateTime DateCreated { get; init; } = DateTime.Now;

        [JsonPropertyName("sortSubTasks")]
        public SortSubTasks SortSubTasks { get; set; } = SortSubTasks.New;

        [ForeignKey("TaskId")]
        [JsonPropertyName("subTasks")]
        public ICollection<SubTaskModel> SubTasks { get; set; }

        [JsonPropertyName("taskListId")]
        public Guid TaskListId { get; set; }

        public TaskModel()
        {
            SubTasks = new List<SubTaskModel>();
        }
    }
}
