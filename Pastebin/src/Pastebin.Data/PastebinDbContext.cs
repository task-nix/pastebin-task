using Microsoft.EntityFrameworkCore;

namespace Pastebin.Data
{
    public class PastebinDbContext: DbContext
    {
        private string connectionString =
            @"User ID =postgres;Password=1+1is2;Server=localhost;Port=5432;Database=PastebinDB;Integrated Security=true;Pooling=true;";

        public PastebinDbContext(DbContextOptions<PastebinDbContext> options):base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}