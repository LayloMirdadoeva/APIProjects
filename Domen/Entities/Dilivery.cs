using Domain.Enum;
namespace Domain.Entities
{
    public class Dilivery: BaseEntity
    {
        public DateTime Date { get; set; }
        public DiliveryStatus Status { get; set; }
        public MethodDilivery Method { get; set; }
        public Order? Order { get; set; }
    }
}
