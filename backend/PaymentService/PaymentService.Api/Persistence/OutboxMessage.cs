using System.Text.Json;
using Shared.Contracts;

namespace PaymentService.Api.Persistence;

public class OutboxMessage
{
    public Guid Id { get; set; }
    public string Type { get; set; } = default!;
    public string RoutingKey { get; set; } = default!;
    public string Body { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public DateTime? ProcessedAt { get; set; }
    public int RetryCount { get; set; }
    public DateTime? NextRetryAt { get; set; }
    public string? LastError { get; set; }

    public static OutboxMessage Create<T>(string routingKey, string type, T payload, DateTime now)
    {
        var id = Guid.NewGuid();
        return new OutboxMessage
        {
            Id = id,
            Type = type,
            RoutingKey = routingKey,
            CreatedAt = now,
            Body = JsonSerializer.Serialize(payload, JsonDefaults.Options),
        };
    }
}
