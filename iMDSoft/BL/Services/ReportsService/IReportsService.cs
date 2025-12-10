using BL.Models;

namespace BL.Services.ReportService
{
    public interface IReportsService
    {
        Task<ICollection<Report>> GetReportAsync(ReportPeriod reportPeriod);
        Task ExportReportToCsvAsync(ICollection<Report> report, string filePath);
        Task<FluentValidation.Results.ValidationResult> ValidatePeriodAsync(ReportPeriod reportPeriod);
    }
}
