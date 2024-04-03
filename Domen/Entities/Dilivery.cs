using Domain.Enum;
namespace Domain.Entities
{
    public class Dilivery
    {
        public Guid Id { get; set; }
        public DateTime DateDilivery { get; set; }
        public DiliveryStatus StatusDilivery { get; set; }
        public MethodDilivery DiliveryMethod { get; set; }
        public Order Order { get; set; }
    }
}
