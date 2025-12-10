namespace BL.Models
{
    public class Report
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public int TotalTestsCount { get; set; }
        public decimal SuccessTestsPercentage { get; set; }
    }

    public class ReportPeriod
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
