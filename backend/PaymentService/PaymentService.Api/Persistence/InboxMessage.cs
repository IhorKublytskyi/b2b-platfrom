namespace PaymentService.Api.Persistence;

public class InboxMessage
{
    public Guid Id { get; set; }
    public string Body { get; set; } = default!;
    public DateTime ReceivedAt { get; set; }
    public DateTime? ProcessedAt { get; set; }
    public int RetryCount { get; set; }
    public DateTime? NextRetryAt { get; set; }
    public string? LastError { get; set; }
}
