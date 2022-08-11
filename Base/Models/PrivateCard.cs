namespace Base.Models
{
    public class PrivateCard:BaseCard
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Tc_Num { get; set; }
        public bool Is_Student { get; set; }
        public bool Is_Worker { get; set; }
        public bool Is_OlderThanSixty { get; set; }
        public bool Is_Digital { get; set; }
        public bool Is_Physical { get; set; }
    }
}
