using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DAL.Repositories.ReportsRepository
{
    public class ReportsRepository : IReportsRepository
    {
        private readonly DatabaseContext _context;

        public ReportsRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Report>> GetReportAsync(DateTime fromDate, DateTime toDate)
        {
            var reports = new List<Report>();
            var connection = _context.Database.GetDbConnection();

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    await connection.OpenAsync();
                }

                using var command = connection.CreateCommand();
                command.CommandText = $@"SELECT
                                         p.Id AS PatientId,
                                         p.Name AS PatientName,
                                         COUNT(t.Id) AS TotalTests,
                                         CASE
                                             WHEN COUNT(t.Id) = 0 THEN 0
                                             ELSE 100.0 * SUM(CASE WHEN t.IsWithinThreshold = 1 THEN 1 ELSE 0 END) / COUNT(t.Id)
                                         END AS PercentageWithinThreshold
                                     FROM Patients p
                                     LEFT JOIN Tests t ON t.PatientId = p.Id
                                         AND t.TestDate BETWEEN @fromDate AND @toDate
                                     GROUP BY p.Id, p.Name
                                     ORDER BY p.Name;";

                var pFrom = command.CreateParameter();
                pFrom.ParameterName = "@fromDate";
                pFrom.Value = fromDate;
                command.Parameters.Add(pFrom);

                var pTo = command.CreateParameter();
                pTo.ParameterName = "@toDate";
                pTo.Value = toDate;
                command.Parameters.Add(pTo);

                using var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    var report = new Report
                    {
                        PatientId = reader.GetInt32(reader.GetOrdinal("PatientId")),
                        PatientName = reader.GetString(reader.GetOrdinal("PatientName")),
                        TotalTestsCount = reader.GetInt32(reader.GetOrdinal("TotalTests")),
                        SuccessTestsPercentage = reader.GetDecimal(reader.GetOrdinal("PercentageWithinThreshold"))
                    };

                    reports.Add(report);
                }

                return reports;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close(); 
                }
            }
            

        }
    }
}
