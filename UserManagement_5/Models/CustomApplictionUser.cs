using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserManagement_5.Models
{
    public class CustomApplictionUser:IdentityUser
    {
        [Required, MaxLength(100)]
        public string FirstName { get; set; }
        [Required, MaxLength(100)]
        public string SecoundName { get; set; }
        public byte[] ImageBinary { get; set; }
    }
}
