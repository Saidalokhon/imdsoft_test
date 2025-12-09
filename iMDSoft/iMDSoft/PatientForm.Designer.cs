namespace iMDSoft
{
    partial class PatientForm
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
            patientId_lbl = new Label();
            patientName_lbl = new Label();
            patientDateOfBirth_lbl = new Label();
            patientGender_lbl = new Label();
            patientSave_btn = new Button();
            patientDelete_btn = new Button();
            patientGender_tbx = new TextBox();
            patientName_tbx = new TextBox();
            patientId_tbx = new TextBox();
            patientDob_dtp = new DateTimePicker();
            SuspendLayout();
            // 
            // patientId_lbl
            // 
            patientId_lbl.AutoSize = true;
            patientId_lbl.Location = new Point(12, 9);
            patientId_lbl.Name = "patientId_lbl";
            patientId_lbl.Size = new Size(24, 20);
            patientId_lbl.TabIndex = 0;
            patientId_lbl.Text = "ID";
            // 
            // patientName_lbl
            // 
            patientName_lbl.AutoSize = true;
            patientName_lbl.Location = new Point(12, 42);
            patientName_lbl.Name = "patientName_lbl";
            patientName_lbl.Size = new Size(49, 20);
            patientName_lbl.TabIndex = 1;
            patientName_lbl.Text = "Name";
            // 
            // patientDateOfBirth_lbl
            // 
            patientDateOfBirth_lbl.AutoSize = true;
            patientDateOfBirth_lbl.Location = new Point(12, 75);
            patientDateOfBirth_lbl.Name = "patientDateOfBirth_lbl";
            patientDateOfBirth_lbl.Size = new Size(94, 20);
            patientDateOfBirth_lbl.TabIndex = 2;
            patientDateOfBirth_lbl.Text = "Date of Birth";
            // 
            // patientGender_lbl
            // 
            patientGender_lbl.AutoSize = true;
            patientGender_lbl.Location = new Point(12, 108);
            patientGender_lbl.Name = "patientGender_lbl";
            patientGender_lbl.Size = new Size(57, 20);
            patientGender_lbl.TabIndex = 3;
            patientGender_lbl.Text = "Gender";
            // 
            // patientSave_btn
            // 
            patientSave_btn.BackColor = Color.Ivory;
            patientSave_btn.ForeColor = Color.Lime;
            patientSave_btn.Location = new Point(29, 138);
            patientSave_btn.Name = "patientSave_btn";
            patientSave_btn.Size = new Size(94, 29);
            patientSave_btn.TabIndex = 4;
            patientSave_btn.Text = "Save";
            patientSave_btn.UseVisualStyleBackColor = false;
            patientSave_btn.Click += patientSave_btn_Click;
            // 
            // patientDelete_btn
            // 
            patientDelete_btn.BackColor = Color.Ivory;
            patientDelete_btn.ForeColor = Color.Red;
            patientDelete_btn.Location = new Point(148, 138);
            patientDelete_btn.Name = "patientDelete_btn";
            patientDelete_btn.Size = new Size(94, 29);
            patientDelete_btn.TabIndex = 5;
            patientDelete_btn.Text = "Delete";
            patientDelete_btn.UseVisualStyleBackColor = false;
            patientDelete_btn.Click += patientDelete_btn_Click;
            // 
            // patientGender_tbx
            // 
            patientGender_tbx.Location = new Point(112, 105);
            patientGender_tbx.MaxLength = 50;
            patientGender_tbx.Name = "patientGender_tbx";
            patientGender_tbx.PlaceholderText = "ex. Female";
            patientGender_tbx.Size = new Size(154, 27);
            patientGender_tbx.TabIndex = 7;
            patientGender_tbx.TextChanged += patientGender_tbx_TextChanged;
            // 
            // patientName_tbx
            // 
            patientName_tbx.Location = new Point(112, 39);
            patientName_tbx.MaxLength = 50;
            patientName_tbx.Name = "patientName_tbx";
            patientName_tbx.PlaceholderText = "ex. John Doe";
            patientName_tbx.Size = new Size(154, 27);
            patientName_tbx.TabIndex = 8;
            patientName_tbx.TextChanged += patientName_tbx_TextChanged;
            // 
            // patientId_tbx
            // 
            patientId_tbx.AccessibleDescription = "";
            patientId_tbx.Enabled = false;
            patientId_tbx.Location = new Point(112, 6);
            patientId_tbx.Name = "patientId_tbx";
            patientId_tbx.PlaceholderText = "ex. 3245";
            patientId_tbx.ReadOnly = true;
            patientId_tbx.Size = new Size(154, 27);
            patientId_tbx.TabIndex = 9;
            // 
            // patientDob_dtp
            // 
            patientDob_dtp.Location = new Point(112, 70);
            patientDob_dtp.Name = "patientDob_dtp";
            patientDob_dtp.Size = new Size(154, 27);
            patientDob_dtp.TabIndex = 10;
            patientDob_dtp.ValueChanged += patientDob_dtp_ValueChanged;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 176);
            Controls.Add(patientDob_dtp);
            Controls.Add(patientId_tbx);
            Controls.Add(patientName_tbx);
            Controls.Add(patientGender_tbx);
            Controls.Add(patientDelete_btn);
            Controls.Add(patientSave_btn);
            Controls.Add(patientGender_lbl);
            Controls.Add(patientDateOfBirth_lbl);
            Controls.Add(patientName_lbl);
            Controls.Add(patientId_lbl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientForm";
            Activated += PatientForm_Activated;
            Load += PatientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label patientId_lbl;
        private Label patientName_lbl;
        private Label patientDateOfBirth_lbl;
        private Label patientGender_lbl;
        private Button patientSave_btn;
        private Button patientDelete_btn;
        private TextBox patientGender_tbx;
        private TextBox patientName_tbx;
        private TextBox patientId_tbx;
        private DateTimePicker patientDob_dtp;
    }
}