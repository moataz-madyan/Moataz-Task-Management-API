
using System.ComponentModel.DataAnnotations;

namespace TaskManagementAPI.DTOs
{
    public class UpdateTaskDto
    {
        [Required(ErrorMessage = "Task title is required.")]
        [MinLength(3, ErrorMessage = "Title must be at least 3 characters.")]
        [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }

        public bool IsCompleted { get; set; }
    }
}
