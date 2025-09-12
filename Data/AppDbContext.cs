using Microsoft.EntityFrameworkCore;
using Notes_To_Do_App.Models;

namespace Notes_To_Do_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}
