using Microsoft.AspNetCore.Identity;

namespace AspNetCore_CrashCourse.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
