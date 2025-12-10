namespace DAL.Repositories.ReportsRepository
{
    public interface IReportsRepository
    {
        Task<ICollection<DAL.Entities.Report>> GetReportAsync(DateTime fromDate, DateTime toDate);
    }
}
