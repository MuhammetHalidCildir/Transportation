namespace Base.Models
{
    public class BaseCard
    {
        public int Id { get; set; }
        public double CardId { get; set; }
        public decimal Money { get; set; }
        public bool SpecialDiscount { get; set; } = true;
    }
}
