using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {}

        public DbSet<Transaction> TBL_TRANSACTIONS { get; set; }
        public DbSet<Category> TBL_CATEGORIES { get; set; }
    }
}
