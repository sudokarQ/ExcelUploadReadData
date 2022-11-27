using ExcelUploadReadDataSaveExampleCore.Models;
using Microsoft.EntityFrameworkCore;

namespace ExcelUploadReadDataSaveExampleCore.Context
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = string.Format(@"Data Source=DESKTOP-3PRI8TC\SQLEXPRESS;Initial Catalog=SchoolDB;Integrated Security=True");
            options.UseSqlServer(connectionString);
        }
        public DbSet<Student> Students { get; set; }
    }
}
