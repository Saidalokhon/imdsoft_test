namespace iMDSoft
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reportData_lvw = new ListView();
            reportPatientId = new ColumnHeader();
            reportPatientName = new ColumnHeader();
            reportTotalTests = new ColumnHeader();
            reportTestsWithThr = new ColumnHeader();
            SuspendLayout();
            // 
            // reportData_lvw
            // 
            reportData_lvw.Columns.AddRange(new ColumnHeader[] { reportPatientId, reportPatientName, reportTotalTests, reportTestsWithThr });
            reportData_lvw.FullRowSelect = true;
            reportData_lvw.GridLines = true;
            reportData_lvw.Location = new Point(0, 0);
            reportData_lvw.Name = "reportData_lvw";
            reportData_lvw.Size = new Size(801, 449);
            reportData_lvw.TabIndex = 0;
            reportData_lvw.UseCompatibleStateImageBehavior = false;
            reportData_lvw.View = View.Details;
            // 
            // reportPatientId
            // 
            reportPatientId.Text = "Patient ID";
            reportPatientId.Width = 100;
            // 
            // reportPatientName
            // 
            reportPatientName.Text = "Patient name";
            reportPatientName.TextAlign = HorizontalAlignment.Center;
            reportPatientName.Width = 200;
            // 
            // reportTotalTests
            // 
            reportTotalTests.Text = "Total number of tests";
            reportTotalTests.TextAlign = HorizontalAlignment.Center;
            reportTotalTests.Width = 250;
            // 
            // reportTestsWithThr
            // 
            reportTestsWithThr.Text = "Tests within threshold percentage";
            reportTestsWithThr.Width = 247;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportData_lvw);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportForm";
            Text = "ReportForm";
            Load += ReportForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView reportData_lvw;
        private ColumnHeader reportPatientId;
        private ColumnHeader reportPatientName;
        private ColumnHeader reportTotalTests;
        private ColumnHeader reportTestsWithThr;
    }
}