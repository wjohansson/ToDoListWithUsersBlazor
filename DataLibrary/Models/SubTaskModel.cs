using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class SubTaskModel
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

        [JsonPropertyName("dateCreated")]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [JsonPropertyName("taskId")]
        public Guid TaskId { get; set; }
    }
}
