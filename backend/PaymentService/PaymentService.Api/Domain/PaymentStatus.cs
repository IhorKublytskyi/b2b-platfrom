namespace PaymentService.Api.Domain;

public enum PaymentStatus
{
    Pending = 0, 
    Processing = 1,
    Succeeded = 2, 
    Failed = 3
}
