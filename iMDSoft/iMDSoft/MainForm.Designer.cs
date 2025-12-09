namespace iMDSoft
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addPatient_btn = new Button();
            profiles_lvw = new ListView();
            patientId = new ColumnHeader();
            patientName = new ColumnHeader();
            patientDob = new ColumnHeader();
            patientGender = new ColumnHeader();
            tests_lvw = new ListView();
            testId = new ColumnHeader();
            testParentId = new ColumnHeader();
            testName = new ColumnHeader();
            testDate = new ColumnHeader();
            testResult = new ColumnHeader();
            isWithinThreshold = new ColumnHeader();
            addTest_btn = new Button();
            SuspendLayout();
            // 
            // addPatient_btn
            // 
            addPatient_btn.Location = new Point(47, 409);
            addPatient_btn.Name = "addPatient_btn";
            addPatient_btn.Size = new Size(128, 29);
            addPatient_btn.TabIndex = 0;
            addPatient_btn.Text = "Add patient";
            addPatient_btn.UseVisualStyleBackColor = true;
            addPatient_btn.Click += addPatient_btn_Click;
            // 
            // profiles_lvw
            // 
            profiles_lvw.Columns.AddRange(new ColumnHeader[] { patientId, patientName, patientDob, patientGender });
            profiles_lvw.FullRowSelect = true;
            profiles_lvw.GridLines = true;
            profiles_lvw.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            profiles_lvw.Location = new Point(47, 12);
            profiles_lvw.Name = "profiles_lvw";
            profiles_lvw.Size = new Size(445, 391);
            profiles_lvw.TabIndex = 1;
            profiles_lvw.UseCompatibleStateImageBehavior = false;
            profiles_lvw.View = View.Details;
            profiles_lvw.Click += profiles_lvw_Click;
            profiles_lvw.DoubleClick += profiles_lvw_DoubleClick;
            profiles_lvw.MouseCaptureChanged += profiles_lvw_MouseCaptureChanged;
            // 
            // patientId
            // 
            patientId.Tag = "";
            patientId.Text = "ID";
            // 
            // patientName
            // 
            patientName.Text = "PatientName";
            patientName.TextAlign = HorizontalAlignment.Center;
            patientName.Width = 180;
            // 
            // patientDob
            // 
            patientDob.Text = "Date of Birth";
            patientDob.TextAlign = HorizontalAlignment.Center;
            patientDob.Width = 120;
            // 
            // patientGender
            // 
            patientGender.Text = "Gender";
            patientGender.TextAlign = HorizontalAlignment.Center;
            patientGender.Width = 80;
            // 
            // tests_lvw
            // 
            tests_lvw.Columns.AddRange(new ColumnHeader[] { testId, testParentId, testName, testDate, testResult, isWithinThreshold });
            tests_lvw.FullRowSelect = true;
            tests_lvw.GridLines = true;
            tests_lvw.Location = new Point(520, 12);
            tests_lvw.Name = "tests_lvw";
            tests_lvw.Size = new Size(664, 391);
            tests_lvw.TabIndex = 2;
            tests_lvw.UseCompatibleStateImageBehavior = false;
            tests_lvw.View = View.Details;
            tests_lvw.DoubleClick += tests_lvw_DoubleClick;
            // 
            // testId
            // 
            testId.Text = "ID";
            // 
            // testParentId
            // 
            testParentId.Text = "Parent ID";
            testParentId.TextAlign = HorizontalAlignment.Center;
            testParentId.Width = 80;
            // 
            // testName
            // 
            testName.Text = "Test Name";
            testName.TextAlign = HorizontalAlignment.Center;
            testName.Width = 120;
            // 
            // testDate
            // 
            testDate.Text = "Test Date";
            testDate.TextAlign = HorizontalAlignment.Center;
            testDate.Width = 120;
            // 
            // testResult
            // 
            testResult.Text = "Result";
            testResult.TextAlign = HorizontalAlignment.Center;
            testResult.Width = 100;
            // 
            // isWithinThreshold
            // 
            isWithinThreshold.Text = "Is Within Threshold ";
            isWithinThreshold.TextAlign = HorizontalAlignment.Center;
            isWithinThreshold.Width = 180;
            // 
            // addTest_btn
            // 
            addTest_btn.Enabled = false;
            addTest_btn.Location = new Point(520, 409);
            addTest_btn.Name = "addTest_btn";
            addTest_btn.Size = new Size(94, 29);
            addTest_btn.TabIndex = 3;
            addTest_btn.Text = "Add test";
            addTest_btn.UseVisualStyleBackColor = true;
            addTest_btn.Click += addTest_btn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 450);
            Controls.Add(addTest_btn);
            Controls.Add(tests_lvw);
            Controls.Add(profiles_lvw);
            Controls.Add(addPatient_btn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iMDSoft";
            Shown += MainForm_Shown;
            ResumeLayout(false);
        }

        #endregion

        private Button addPatient_btn;
        private ListView profiles_lvw;
        private ColumnHeader patientId;
        private ColumnHeader patientName;
        private ColumnHeader patientDob;
        private ColumnHeader patientGender;
        private ListView tests_lvw;
        private Button addTest_btn;
        private ColumnHeader testId;
        private ColumnHeader testParentId;
        private ColumnHeader testName;
        private ColumnHeader testDate;
        private ColumnHeader testResult;
        private ColumnHeader isWithinThreshold;
    }
}
