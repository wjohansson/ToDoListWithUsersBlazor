using DataLibrary.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class UserModel
    {
        [Key]
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonPropertyName("username")]
        [MinLength(6, ErrorMessage = "Must be atleast 6 characters.")]
        [Required]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[^\\da-zA-Z])(.{10,})$", ErrorMessage = "Password must be atleast 10 characters, one uppercase, one lowercase, one number, and one special")]
        [Required]
        public string Password { get; set; }

        [JsonPropertyName("confirmPassword")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [JsonPropertyName("oldPssword")]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        [JsonPropertyName("passwordSalt")]
        public byte[] PasswordSalt { get; set; }

        [JsonPropertyName("firstName")]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [Required]
        public string Email { get; set; }

        [JsonPropertyName("age")]
        [Range(1, int.MaxValue, ErrorMessage = "Age must a positive number")]
        [Required]
        public int? Age { get; set; }

        [JsonPropertyName("gender")]
        [Required]
        public string Gender { get; set; }

        [JsonPropertyName("adress")]
        [Required]
        public string Adress { get; set; }

        [JsonPropertyName("permission")]
        public PermissionLevel? Permission { get; set; }

        [JsonPropertyName("dateCreated")]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [JsonPropertyName("sortLists")]
        public SortLists SortLists { get; set; } = SortLists.New;

        [JsonPropertyName("sortCategories")]
        public SortCategories SortCategories { get; set; } = SortCategories.New;

        [ForeignKey("UserId")]
        [JsonPropertyName("taskLists")]
        public ICollection<TaskListModel> TaskLists { get; set; }

        [ForeignKey("UserId")]
        [JsonPropertyName("categories")]
        public ICollection<CategoryModel> Categories { get; set; }

        public UserModel()
        {
            TaskLists = new List<TaskListModel>();
            Categories = new List<CategoryModel>();
        }
    }
}
