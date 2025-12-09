namespace iMDSoft
{
    partial class TestForm
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
            testId_lbl = new Label();
            testPatientId_lbl = new Label();
            testName_lbl = new Label();
            testDate_lbl = new Label();
            testResult_lbl = new Label();
            isWithinThreshold_cbx = new CheckBox();
            testResult_nud = new NumericUpDown();
            testId_tbx = new TextBox();
            testPatientId_tbx = new TextBox();
            testName_tbx = new TextBox();
            testDate_dtp = new DateTimePicker();
            testSave_btn = new Button();
            testDelete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)testResult_nud).BeginInit();
            SuspendLayout();
            // 
            // testId_lbl
            // 
            testId_lbl.AutoSize = true;
            testId_lbl.Location = new Point(12, 9);
            testId_lbl.Name = "testId_lbl";
            testId_lbl.Size = new Size(24, 20);
            testId_lbl.TabIndex = 0;
            testId_lbl.Text = "ID";
            // 
            // testPatientId_lbl
            // 
            testPatientId_lbl.AutoSize = true;
            testPatientId_lbl.Location = new Point(12, 42);
            testPatientId_lbl.Name = "testPatientId_lbl";
            testPatientId_lbl.Size = new Size(73, 20);
            testPatientId_lbl.TabIndex = 1;
            testPatientId_lbl.Text = "Patient ID";
            // 
            // testName_lbl
            // 
            testName_lbl.AutoSize = true;
            testName_lbl.Location = new Point(12, 75);
            testName_lbl.Name = "testName_lbl";
            testName_lbl.Size = new Size(79, 20);
            testName_lbl.TabIndex = 2;
            testName_lbl.Text = "Test Name";
            // 
            // testDate_lbl
            // 
            testDate_lbl.AutoSize = true;
            testDate_lbl.Location = new Point(12, 110);
            testDate_lbl.Name = "testDate_lbl";
            testDate_lbl.Size = new Size(71, 20);
            testDate_lbl.TabIndex = 3;
            testDate_lbl.Text = "Test Date";
            // 
            // testResult_lbl
            // 
            testResult_lbl.AutoSize = true;
            testResult_lbl.Location = new Point(12, 140);
            testResult_lbl.Name = "testResult_lbl";
            testResult_lbl.Size = new Size(79, 20);
            testResult_lbl.TabIndex = 4;
            testResult_lbl.Text = "Test Result";
            // 
            // isWithinThreshold_cbx
            // 
            isWithinThreshold_cbx.AutoSize = true;
            isWithinThreshold_cbx.Location = new Point(12, 171);
            isWithinThreshold_cbx.Name = "isWithinThreshold_cbx";
            isWithinThreshold_cbx.Size = new Size(157, 24);
            isWithinThreshold_cbx.TabIndex = 6;
            isWithinThreshold_cbx.Text = "Is Within Threshold";
            isWithinThreshold_cbx.UseVisualStyleBackColor = true;
            isWithinThreshold_cbx.CheckedChanged += isWithinThreshold_cbx_CheckedChanged;
            // 
            // testResult_nud
            // 
            testResult_nud.DecimalPlaces = 2;
            testResult_nud.Location = new Point(125, 138);
            testResult_nud.Name = "testResult_nud";
            testResult_nud.Size = new Size(177, 27);
            testResult_nud.TabIndex = 7;
            testResult_nud.ValueChanged += testResult_nud_ValueChanged;
            // 
            // testId_tbx
            // 
            testId_tbx.Enabled = false;
            testId_tbx.Location = new Point(125, 6);
            testId_tbx.Name = "testId_tbx";
            testId_tbx.ReadOnly = true;
            testId_tbx.Size = new Size(177, 27);
            testId_tbx.TabIndex = 8;
            // 
            // testPatientId_tbx
            // 
            testPatientId_tbx.Enabled = false;
            testPatientId_tbx.Location = new Point(125, 39);
            testPatientId_tbx.Name = "testPatientId_tbx";
            testPatientId_tbx.ReadOnly = true;
            testPatientId_tbx.Size = new Size(177, 27);
            testPatientId_tbx.TabIndex = 9;
            // 
            // testName_tbx
            // 
            testName_tbx.Location = new Point(125, 72);
            testName_tbx.Name = "testName_tbx";
            testName_tbx.Size = new Size(177, 27);
            testName_tbx.TabIndex = 10;
            testName_tbx.TextChanged += testName_tbx_TextChanged;
            // 
            // testDate_dtp
            // 
            testDate_dtp.Location = new Point(125, 105);
            testDate_dtp.Name = "testDate_dtp";
            testDate_dtp.Size = new Size(177, 27);
            testDate_dtp.TabIndex = 11;
            testDate_dtp.ValueChanged += testDate_dtp_ValueChanged;
            // 
            // testSave_btn
            // 
            testSave_btn.BackColor = Color.Ivory;
            testSave_btn.ForeColor = Color.Lime;
            testSave_btn.Location = new Point(44, 211);
            testSave_btn.Name = "testSave_btn";
            testSave_btn.Size = new Size(94, 29);
            testSave_btn.TabIndex = 12;
            testSave_btn.Text = "Save";
            testSave_btn.UseVisualStyleBackColor = false;
            testSave_btn.Click += testSave_btn_Click;
            // 
            // testDelete_btn
            // 
            testDelete_btn.BackColor = Color.Ivory;
            testDelete_btn.ForeColor = Color.Red;
            testDelete_btn.Location = new Point(186, 211);
            testDelete_btn.Name = "testDelete_btn";
            testDelete_btn.Size = new Size(94, 29);
            testDelete_btn.TabIndex = 13;
            testDelete_btn.Text = "Delete";
            testDelete_btn.UseVisualStyleBackColor = false;
            testDelete_btn.Click += testDelete_btn_Click;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 252);
            Controls.Add(testDelete_btn);
            Controls.Add(testSave_btn);
            Controls.Add(testDate_dtp);
            Controls.Add(testName_tbx);
            Controls.Add(testPatientId_tbx);
            Controls.Add(testId_tbx);
            Controls.Add(testResult_nud);
            Controls.Add(isWithinThreshold_cbx);
            Controls.Add(testResult_lbl);
            Controls.Add(testDate_lbl);
            Controls.Add(testName_lbl);
            Controls.Add(testPatientId_lbl);
            Controls.Add(testId_lbl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "TestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TestForm";
            Activated += TestForm_Activated;
            Load += TestForm_Load;
            ((System.ComponentModel.ISupportInitialize)testResult_nud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label testId_lbl;
        private Label testPatientId_lbl;
        private Label testName_lbl;
        private Label testDate_lbl;
        private Label testResult_lbl;
        private CheckBox isWithinThreshold_cbx;
        private NumericUpDown testResult_nud;
        private TextBox testId_tbx;
        private TextBox testPatientId_tbx;
        private TextBox testName_tbx;
        private DateTimePicker testDate_dtp;
        private Button testSave_btn;
        private Button testDelete_btn;
    }
}