namespace DAL.Entities
{
    public class Test
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public DateTime TestDate { get; set; }
        public decimal Result { get; set; }
        public bool IsWithinThreshold { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
