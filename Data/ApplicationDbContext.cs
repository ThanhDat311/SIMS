using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SIMS.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Semester> Semesters { get; set; } = null;

        public DbSet<Department> Departments { get; set; } = null;

        public DbSet<Subject> Subjects { get; set; } = null;

        public DbSet<Major> Majors { get; set; } = null;

        public DbSet<Course> Courses { get; set; } = null;
    }
}
