using BL.Services.ReportService;

namespace iMDSoft
{
    public partial class ReportDialog : Form
    {
        private IReportsService _reportService;
        private ReportForm _reportForm;
        private BL.Models.ReportPeriod ReportPeriod { get; set; } = new BL.Models.ReportPeriod();

        public ReportDialog(IReportsService reportService, ReportForm reportForm)
        {
            _reportService = reportService;
            _reportForm = reportForm;

            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ReportDialog_Load(object sender, EventArgs e)
        {
            fromDate_dtp.MaxDate = DateTime.Now;
            toDate_dtp.MaxDate = DateTime.Now;

            ReportPeriod.FromDate = fromDate_dtp.Value;
            ReportPeriod.ToDate = toDate_dtp.Value;
        }

        private async void confirm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var validation = await _reportService.ValidatePeriodAsync(ReportPeriod);
                if (!validation.IsValid)
                {
                    MessageBox.Show($"Invalid report period: {validation.Errors.First().ErrorMessage}");
                    return;
                }

                var report = await _reportService.GetReportAsync(ReportPeriod);

                bool isCsv = generateCsv_cbx.Checked;
                if (isCsv)
                {
                    using var dialog = new SaveFileDialog()
                    {
                        Title = "Save report",
                        Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                        FileName = $"patient_report_{ReportPeriod.FromDate.ToString("yyyy-MM-dd")}_{ReportPeriod.ToDate.ToString("yyyy-MM-dd")}.csv"
                    };

                    if (dialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    await _reportService.ExportReportToCsvAsync(report, dialog.FileName);

                    MessageBox.Show($"Report saved successfully to {dialog.FileName}");
                }
                else
                {
                    _reportForm.Report = report;
                    _reportForm.Show();
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured during report generation: {ex.Message}");
            }
        }

        private void fromDate_dtp_ValueChanged(object sender, EventArgs e)
        {
            ReportPeriod.FromDate = fromDate_dtp.Value;
        }

        private void toDate_dtp_ValueChanged(object sender, EventArgs e)
        {
            ReportPeriod.ToDate = toDate_dtp.Value;
        }
    }
}
