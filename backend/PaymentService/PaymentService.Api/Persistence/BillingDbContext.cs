using Microsoft.EntityFrameworkCore;
using PaymentService.Api.Domain;

namespace PaymentService.Api.Persistence;

public class BillingDbContext(DbContextOptions<BillingDbContext> options) : DbContext(options)
{
    public DbSet<Payment> Payments => Set<Payment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Payment>(e =>
        {
            e.ToTable("Payments");
            e.HasKey(x => x.Id);
            e.Property(x => x.Amount).HasPrecision(18, 2);
            e.Property(x => x.Currency).HasMaxLength(3).IsFixedLength();
            e.Property(x => x.FailureReason).HasMaxLength(50);
            e.Property(x => x.ProviderTransactionId).HasMaxLength(64);
            e.Property(x => x.RowVersion).IsRowVersion();
            e.HasIndex(x => x.OrderId).IsUnique();
            e.HasIndex(x => new { x.UserId, x.CreatedAt }).IsDescending(false, true);
            e.HasIndex(x => new { x.Status, x.LastAttemptAt });
        });
    }
}
