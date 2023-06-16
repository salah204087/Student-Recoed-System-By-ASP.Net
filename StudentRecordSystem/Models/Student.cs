using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRecordSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Email { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? City { get; set; }
        public int PostalCode { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string? Gender { get; set; }
        [Required]
        public string? EducationType { get; set; }
        public int? UniversityId { get; set; }
        [ForeignKey("UniversityId")]
        public University? University { get; set; }
        public int? FacultyId { get; set; }
        [ForeignKey("FacultyId")]
        public Faculty? Faculty { get; set; }
        public int? SchoolId { get; set; }
        [ForeignKey("SchoolId")]
        public School? School { get; set; }

    }
}
