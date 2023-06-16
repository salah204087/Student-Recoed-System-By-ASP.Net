using System.ComponentModel.DataAnnotations;

namespace StudentRecordSystem.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        [Range(2,7)]
        public int FacultyYears { get; set; }
    }
}
