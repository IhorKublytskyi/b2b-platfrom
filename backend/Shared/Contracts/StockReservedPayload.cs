namespace Shared.Contracts;

public sealed record StockReservedPayload(Guid OrderId, Guid UserId, 
    decimal TotalAmount, string Currency, List<StockItem> Items); // Приклад

public sealed record StockItem(Guid ProductId, int Quantity);