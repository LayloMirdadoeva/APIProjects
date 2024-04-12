namespace Domain.Entities
{
    public class Cart : BaseEntity
    {
        public int Number { get; set; }
        public DateTime ValidityPeriod { get; set; }
        public string CodeCVV { get; set; } = string.Empty;
    }
}
