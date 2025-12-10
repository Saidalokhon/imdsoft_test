using AutoMapper;
using BL.Models;
using CsvHelper;
using DAL.Repositories.ReportsRepository;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace BL.Services.ReportService
{
    public class ReportsService : IReportsService
    {
        private readonly IReportsRepository _reportsRepository;
        private readonly ILogger<ReportsService> _logger;
        private readonly IMapper _mapper;
        private readonly IValidator<ReportPeriod> _validator;

        public ReportsService(IReportsRepository reportsRepository, ILogger<ReportsService> logger, IMapper mapper, IValidator<ReportPeriod> validator)
        {
            _reportsRepository = reportsRepository;
            _logger = logger;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<ICollection<Report>> GetReportAsync(ReportPeriod reportPeriod)
        {
            try
            {
                _logger.LogInformation("Generating report from {FromDate} to {ToDate}", reportPeriod.FromDate, reportPeriod.ToDate);
                var report = await _reportsRepository.GetReportAsync(reportPeriod.FromDate, reportPeriod.ToDate);

                return _mapper.Map<ICollection<Report>>(report);
            }
            catch (Exception ex) 
            { 
                _logger.LogError(ex, "Error generating report from {FromDate} to {ToDate}. Error message: {ErrorMessage}", reportPeriod.FromDate, reportPeriod.ToDate, ex.Message);
                throw;
            }
        }

        public async Task ExportReportToCsvAsync(ICollection<Report> report, string FilePath)
        {
            using var writer = new StreamWriter(FilePath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteHeader<Report>();
            csv.NextRecord();
            csv.WriteRecords(report);
        }

        public async Task<ValidationResult> ValidatePeriodAsync(ReportPeriod reportPeriod)
        {
            _logger.LogInformation("Validating the report period.");
            return await _validator.ValidateAsync(reportPeriod);
        }
    }
}
