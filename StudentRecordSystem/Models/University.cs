using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRecordSystem.Models
{
    public class University
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Location { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? EstablishmentDate { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
    }
}
