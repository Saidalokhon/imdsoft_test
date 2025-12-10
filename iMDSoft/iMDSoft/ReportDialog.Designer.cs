namespace iMDSoft
{
    partial class ReportDialog
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
            fromDate_lbl = new Label();
            fromDate_dtp = new DateTimePicker();
            toDate_lbl = new Label();
            toDate_dtp = new DateTimePicker();
            generateCsv_cbx = new CheckBox();
            confirm_btn = new Button();
            cancel_btn = new Button();
            SuspendLayout();
            // 
            // fromDate_lbl
            // 
            fromDate_lbl.AutoSize = true;
            fromDate_lbl.Location = new Point(12, 14);
            fromDate_lbl.Name = "fromDate_lbl";
            fromDate_lbl.Size = new Size(77, 20);
            fromDate_lbl.TabIndex = 0;
            fromDate_lbl.Text = "From date";
            // 
            // fromDate_dtp
            // 
            fromDate_dtp.Location = new Point(107, 9);
            fromDate_dtp.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            fromDate_dtp.Name = "fromDate_dtp";
            fromDate_dtp.Size = new Size(164, 27);
            fromDate_dtp.TabIndex = 1;
            fromDate_dtp.ValueChanged += fromDate_dtp_ValueChanged;
            // 
            // toDate_lbl
            // 
            toDate_lbl.AutoSize = true;
            toDate_lbl.Location = new Point(12, 47);
            toDate_lbl.Name = "toDate_lbl";
            toDate_lbl.Size = new Size(59, 20);
            toDate_lbl.TabIndex = 2;
            toDate_lbl.Text = "To date";
            // 
            // toDate_dtp
            // 
            toDate_dtp.Location = new Point(107, 42);
            toDate_dtp.Name = "toDate_dtp";
            toDate_dtp.Size = new Size(164, 27);
            toDate_dtp.TabIndex = 3;
            toDate_dtp.ValueChanged += toDate_dtp_ValueChanged;
            // 
            // generateCsv_cbx
            // 
            generateCsv_cbx.AutoSize = true;
            generateCsv_cbx.Location = new Point(18, 75);
            generateCsv_cbx.Name = "generateCsv_cbx";
            generateCsv_cbx.Size = new Size(121, 24);
            generateCsv_cbx.TabIndex = 4;
            generateCsv_cbx.Text = "Generate CSV";
            generateCsv_cbx.UseVisualStyleBackColor = true;
            // 
            // confirm_btn
            // 
            confirm_btn.Location = new Point(27, 105);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(94, 29);
            confirm_btn.TabIndex = 5;
            confirm_btn.Text = "Confirm";
            confirm_btn.UseVisualStyleBackColor = true;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.Location = new Point(146, 105);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(94, 29);
            cancel_btn.TabIndex = 6;
            cancel_btn.Text = "Cancel";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // ReportDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 146);
            Controls.Add(cancel_btn);
            Controls.Add(confirm_btn);
            Controls.Add(generateCsv_cbx);
            Controls.Add(toDate_dtp);
            Controls.Add(toDate_lbl);
            Controls.Add(fromDate_dtp);
            Controls.Add(fromDate_lbl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportDialog";
            Load += ReportDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fromDate_lbl;
        private DateTimePicker fromDate_dtp;
        private Label toDate_lbl;
        private DateTimePicker toDate_dtp;
        private CheckBox generateCsv_cbx;
        private Button confirm_btn;
        private Button cancel_btn;
    }
}