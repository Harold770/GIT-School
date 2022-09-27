using System.ComponentModel.DataAnnotations;

namespace GIT_School.Models
{
    public class StudentsModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Grade { get; set; }
        [Required]
        public string? Group { get; set; }
        [Required]
        public string? Age { get; set; }
    }
}
