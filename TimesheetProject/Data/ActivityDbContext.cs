using Microsoft.EntityFrameworkCore;
using TimesheetProject.Model;

namespace TimesheetProject.Data
{
    public class ActivityDbContext : DbContext
    {
        public string ConnectionString { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SubProject> SubProjects { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public ActivityDbContext()
        {
            ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TimesheetsDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
