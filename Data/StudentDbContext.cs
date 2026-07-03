using Microsoft.EntityFrameworkCore;

namespace StudentApi.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
           
        }
        public DbSet<Model.Student> Students { get; set; }
    }
}
