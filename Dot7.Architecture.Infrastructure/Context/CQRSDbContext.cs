namespace Dot7.Architecture.Infrastructure.Context;

public class CQRSDbContext : DbContext, ICQRSDbContext
{
    public CQRSDbContext(DbContextOptions<CQRSDbContext> options) : base(options)
    { }

    public DbSet<StudentDetails> StudentDetails { get; set; }
    public async Task<int> SaveToDbAsync()
    {
        return await SaveChangesAsync();
    }
}
