using BL.Models;
using BL.Services;
using BL.Services.PatientsService;
using System.ComponentModel;

namespace iMDSoft
{
    public partial class PatientForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Patient Patient { get; set; }

        private readonly IBaseService<DAL.Entities.Patient, Patient, PatientsService> _patientsService;

        public PatientForm(
            IBaseService<DAL.Entities.Patient, Patient, PatientsService> patientService)
        {
            _patientsService = patientService;

            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            patientId_tbx.Text = Patient.Id.ToString();
            patientName_tbx.Text = Patient.Name;
            patientDob_dtp.Value = Patient.DateOfBirth;
            patientGender_tbx.Text = Patient.Gender;
        }

        private async void patientSave_btn_Click(object sender, EventArgs e)
        {
            var validationResult = await _patientsService.ValidateAsync(Patient);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(validationResult.Errors.First().ErrorMessage);
            }
            else
            {
                try
                {
                    if (IsNewPatient())
                    {
                        await _patientsService.AddAsync(Patient);
                        MessageBox.Show($"Patient {Patient.Name} added successfully!");
                    }
                    else
                    {
                        await _patientsService.UpdateAsync(Patient, Patient.Id);
                        MessageBox.Show($"Patient with ID {Patient.Id} updated successfully!");
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured during saveing the patient: {ex.Message}");
                }
            }
        }

        private void patientName_tbx_TextChanged(object sender, EventArgs e)
        {
            Patient.Name = patientName_tbx.Text;
        }

        private void patientDob_dtp_ValueChanged(object sender, EventArgs e)
        {
            Patient.DateOfBirth = patientDob_dtp.Value;
        }

        private void patientGender_tbx_TextChanged(object sender, EventArgs e)
        {
            Patient.Gender = patientGender_tbx.Text;
        }

        private void PatientForm_Activated(object sender, EventArgs e)
        {
            if (IsNewPatient())
            {
                patientDelete_btn.Enabled = false;
            }
            else
            {
                patientDelete_btn.Enabled = true;
            }
        }

        private async void patientDelete_btn_Click(object sender, EventArgs e)
        {
            if (IsNewPatient())
            {
                MessageBox.Show("Cannot delete a patient that hasn't been saved yet.");
                return;
            }
            else
            {
                try
                {
                    await _patientsService.DeleteAsync(Patient.Id);
                    MessageBox.Show($"Patient with ID {Patient.Id} deleted successfully!");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured during deleting the patient with ID {Patient.Id}: {ex.Message}");
                }
            }
        }

        private bool IsNewPatient()
        {
            return Patient.Id == 0;
        }
    }
}
