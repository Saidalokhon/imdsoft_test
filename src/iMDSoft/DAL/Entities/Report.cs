namespace DAL.Entities
{
    public class Report
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int TotalTestsCount { get; set; }
        public decimal SuccessTestsPercentage { get; set; }
    }
}
