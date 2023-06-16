using System.ComponentModel.DataAnnotations;

namespace StudentRecordSystem.Models
{
    public class School
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Type { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        public string? City { get; set; }
    }
}
