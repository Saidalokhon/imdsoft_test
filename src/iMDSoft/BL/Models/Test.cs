namespace BL.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string TestName { get; set; } = String.Empty;
        public DateTime TestDate { get; set; } = new DateTime(1900, 1, 1);
        public decimal Result { get; set; }
        public bool IsWithinThreshold { get; set; }
        public Patient Patient { get; set; } = new Patient();
    }
}
