namespace Dot7.Architecture.Application.Context;

public interface ICQRSDbContext
{
    DbSet<Domain.Entities.StudentDetails> StudentDetails { get; }

    Task<int> SaveToDbAsync();
}
