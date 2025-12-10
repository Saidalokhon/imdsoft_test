using BL.Services;
using BL.Services.PatientsService;
using BL.Services.TestsService;

namespace iMDSoft
{
    public partial class MainForm : Form
    {
        private readonly IBaseService<DAL.Entities.Patient, BL.Models.Patient, PatientsService> _patientsService;
        private readonly IBaseService<DAL.Entities.Test, BL.Models.Test, TestsService> _testsService;

        private readonly PatientForm _patientForm;
        private readonly TestForm _testForm;
        private readonly ReportDialog _reportDialog;

        public MainForm(
            IBaseService<DAL.Entities.Patient, BL.Models.Patient, PatientsService> patientsService,
            IBaseService<DAL.Entities.Test, BL.Models.Test, TestsService> testsService,
            PatientForm patientForm,
            TestForm testForm,
            ReportDialog reportDialog)
        {
            _patientsService = patientsService;
            _testsService = testsService;
            _patientForm = patientForm;
            _testForm = testForm;
            _reportDialog = reportDialog;

            InitializeComponent();
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            await UpdatePatientsAsync();
        }

        private async void addPatient_btn_Click(object sender, EventArgs e)
        {
            _patientForm.Patient = new BL.Models.Patient();
            var dialogResult = _patientForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                await UpdatePatientsAsync();
            }
        }

        private async void profiles_lvw_DoubleClick(object sender, EventArgs e)
        {
            var selectedItems = profiles_lvw.SelectedItems;
            if (selectedItems.Count < 1) return;

            int patientId = int.Parse(selectedItems[0].SubItems[0].Text);
            try
            {
                var patient = await _patientsService.GetByIdAsync(patientId);
                _patientForm.Patient = patient;
                var dialogResult = _patientForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    await UpdatePatientsAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured during loading the patient: {ex.Message}");
            }
        }

        private async void profiles_lvw_Click(object sender, EventArgs e)
        {
            if (profiles_lvw.SelectedItems.Count == 1)
            {
                await UpdateTestsAsync(int.Parse(profiles_lvw.SelectedItems[0].SubItems[0].Text));
                addTest_btn.Enabled = true;
            }
        }

        private void profiles_lvw_MouseCaptureChanged(object sender, EventArgs e)
        {
            addTest_btn.Enabled = false;
        }

        private async void addTest_btn_Click(object sender, EventArgs e)
        {
            int patientId = int.Parse(profiles_lvw.SelectedItems[0].SubItems[0].Text);

            _testForm.Test = new BL.Models.Test();
            _testForm.Test.Patient = new BL.Models.Patient();
            _testForm.Test.Patient.Id = patientId;

            var dialogResult = _testForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                await UpdateTestsAsync(patientId);
            }
        }

        private async void tests_lvw_DoubleClick(object sender, EventArgs e)
        {
            var selectedItems = tests_lvw.SelectedItems;
            if (selectedItems.Count < 1) return;

            int testId = int.Parse(selectedItems[0].SubItems[0].Text);
            try
            {
                var test = await _testsService.GetByIdAsync(testId);
                _testForm.Test = test;
                var dialogResult = _testForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    await UpdateTestsAsync(test.Patient.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured during loading the patient: {ex.Message}");
            }
        }

        private async Task UpdatePatientsAsync()
        {
            var patients = await _patientsService.GetAllAsync();

            profiles_lvw.BeginUpdate();
            profiles_lvw.Items.Clear();

            foreach (var patient in patients)
            {
                var item = new ListViewItem(patient.Id.ToString());
                item.SubItems.Add(patient.Name);
                item.SubItems.Add(patient.DateOfBirth.ToShortDateString());
                item.SubItems.Add(patient.Gender);

                item.Tag = patient;

                profiles_lvw.Items.Add(item);
            }

            profiles_lvw.EndUpdate();
        }

        private async Task UpdateTestsAsync(int patientId)
        {
            try
            {
                var patient = await _patientsService.GetByIdAsync(patientId);
                var tests = patient.Tests;

                tests_lvw.BeginUpdate();
                tests_lvw.Items.Clear();

                foreach (var test in tests)
                {
                    var item = new ListViewItem(test.Id.ToString());
                    item.SubItems.Add(test.Patient.Id.ToString());
                    item.SubItems.Add(test.TestName);
                    item.SubItems.Add(test.TestDate.ToString("yyyy-MM-dd HH:mm"));
                    item.SubItems.Add(test.Result.ToString());
                    item.SubItems.Add(test.IsWithinThreshold ? "Yes" : "No");

                    item.Tag = test;

                    tests_lvw.Items.Add(item);
                }

                tests_lvw.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn't update tests for patient with ID {patientId}. Error: {ex.Message}");
            }
        }

        private void generateReport_btn_Click(object sender, EventArgs e)
        {
            _reportDialog.ShowDialog();
        }
    }
}
