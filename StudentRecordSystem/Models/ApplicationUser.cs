using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace StudentRecordSystem.Models
{
    public class ApplicationUser:IdentityUser
    {
        public bool Create { get; set; }
    }
}
