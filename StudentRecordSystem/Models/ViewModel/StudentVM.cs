using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentRecordSystem.Models.ViewModel
{
    public class StudentVM
    {
        public Student? Student { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? UniversityList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? FacultyList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? SchoolList { get; set; }
    }
}
