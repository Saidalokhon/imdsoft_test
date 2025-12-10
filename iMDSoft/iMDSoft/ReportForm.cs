using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iMDSoft
{
    public partial class ReportForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ICollection<BL.Models.Report> Report { get; set; }

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            reportData_lvw.BeginUpdate();
            reportData_lvw.Items.Clear();

            foreach (var data in Report)
            {
                var item = new ListViewItem(data.PatientId.ToString());
                item.SubItems.Add(data.PatientName);
                item.SubItems.Add(data.TotalTestsCount.ToString());
                item.SubItems.Add(data.SuccessTestsPercentage.ToString());

                item.Tag = data;

                reportData_lvw.Items.Add(item);
            }

            reportData_lvw.EndUpdate();
        }
    }
}
