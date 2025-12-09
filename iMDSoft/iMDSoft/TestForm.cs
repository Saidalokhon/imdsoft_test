using BL.Models;
using BL.Services;
using BL.Services.TestsService;
using System.ComponentModel;

namespace iMDSoft
{
    public partial class TestForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Test Test { get; set; }

        IBaseService<DAL.Entities.Test, BL.Models.Test, TestsService> _testsService;

        public TestForm(
            IBaseService<DAL.Entities.Test, BL.Models.Test, TestsService> testsService)
        {
            _testsService = testsService;

            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            testId_tbx.Text = Test.Id.ToString();
            testPatientId_tbx.Text = Test.Patient.Id.ToString();
            testName_tbx.Text = Test.TestName;
            testDate_dtp.Value = Test.TestDate;
            testResult_nud.Text = Test.Result.ToString();
            isWithinThreshold_cbx.Checked = Test.IsWithinThreshold;
        }

        private async void testSave_btn_Click(object sender, EventArgs e)
        {
            var validationResult = await _testsService.Validate(Test);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(validationResult.Errors.First().ErrorMessage);
            }
            else
            {
                try
                {
                    if (IsNewTest())
                    {
                        await _testsService.Add(Test);
                        MessageBox.Show($"Test {Test.TestName} added successfully!");
                    }
                    else
                    {
                        await _testsService.Update(Test, Test.Id);
                        MessageBox.Show($"Test with ID {Test.Id} updated successfully!");
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured during saveing the test: {ex.Message}");
                }
            }
        }

        private void testName_tbx_TextChanged(object sender, EventArgs e)
        {
            Test.TestName = testName_tbx.Text;
        }

        private void testDate_dtp_ValueChanged(object sender, EventArgs e)
        {
            Test.TestDate = testDate_dtp.Value;
        }

        private void testResult_nud_ValueChanged(object sender, EventArgs e)
        {
            Test.Result = testResult_nud.Value;
        }

        private void isWithinThreshold_cbx_CheckedChanged(object sender, EventArgs e)
        {
            Test.IsWithinThreshold = isWithinThreshold_cbx.Checked;
        }

        private void TestForm_Activated(object sender, EventArgs e)
        {
            if (IsNewTest())
            {
                testDelete_btn.Enabled = false;
            }
            else
            {
                testDelete_btn.Enabled = true;
            }
        }

        private async void testDelete_btn_Click(object sender, EventArgs e)
        {
            if (IsNewTest())
            {
                MessageBox.Show("Cannot delete a test that hasn't been saved yet.");
                return;
            }
            else
            {
                try
                {
                    await _testsService.Delete(Test.Id);
                    MessageBox.Show($"Test with ID {Test.Id} deleted successfully!");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured during deleting the test with ID {Test.Id}: {ex.Message}");
                }
            }
        }

        private bool IsNewTest()
        {
            return Test.Id == 0;
        }
    }
}
