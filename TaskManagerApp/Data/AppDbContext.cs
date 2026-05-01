using Microsoft.EntityFrameworkCore;
using TaskManagerApp.Models;


namespace TaskManagerApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {    
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }


        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Department)
                .WithMany(d => d.Users)
                .HasForeignKey(u => u.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
