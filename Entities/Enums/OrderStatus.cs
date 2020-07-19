namespace ordering_service.Entities.Enums
{
    public enum OrderStatus: int
    {
        PENDIND_PAYMENT = 0,
        PROCESSING = 2,
        SHIPPED = 3,
        DELIVERED = 4
    }
}