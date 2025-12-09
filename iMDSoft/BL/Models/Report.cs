namespace BL.Models
{
    public class Report
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; } = string.Empty;
        public int TotalTests { get; set; }
        public decimal GoodThresholdPercentage { get; set; }
    }
}
