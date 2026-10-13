namespace PaymentService.Api.Domain;

public class Payment
{
    public Guid Id { get; private set; }
    public Guid OrderId { get; private set; }
    public Guid UserId { get; private set; }
    public decimal TotalAmount { get; private set; }
    public string Currency { get; private set; } = default!;
    public PaymentStatus Status { get; private set; }
    public string? FailureReason { get; private set; }
    public string? ProviderProviderTransactionId { get; private set; }
    public string ItemsJson { get; private set; } = "[]";
    public int RetryCount { get; private set; }
    public DateTime LastAttemptAt { get; private set; }
    public uint RowVersion { get; private set; }
    public DateTime CreatedAt { get; private set; }
}
