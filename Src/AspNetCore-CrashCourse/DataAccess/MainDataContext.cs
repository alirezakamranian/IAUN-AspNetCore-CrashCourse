using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_CrashCourse.DataAccess
{
    public class MainDataContext : IdentityDbContext<IdentityUser>
    {
        public MainDataContext(DbContextOptions<MainDataContext> options) : base(options)
        {

        }
    }
}
