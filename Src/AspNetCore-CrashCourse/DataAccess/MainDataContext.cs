using AspNetCore_CrashCourse.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_CrashCourse.DataAccess
{
    public class MainDataContext : IdentityDbContext<ApplicationUser>
    {
        public MainDataContext(DbContextOptions<MainDataContext> options) : base(options)
        {

        }
    }
}
