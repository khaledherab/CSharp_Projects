namespace project_programming_2
{
    partial class ffrm_Main
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
            btn_doctors = new Button();
            btn_treatments = new Button();
            btn_patients = new Button();
            SuspendLayout();
            // 
            // btn_doctors
            // 
            btn_doctors.BackColor = Color.Gainsboro;
            btn_doctors.ForeColor = SystemColors.ActiveCaptionText;
            btn_doctors.Location = new Point(199, 77);
            btn_doctors.Name = "btn_doctors";
            btn_doctors.Size = new Size(244, 50);
            btn_doctors.TabIndex = 0;
            btn_doctors.Text = "Doctors";
            btn_doctors.UseVisualStyleBackColor = false;
            btn_doctors.Click += btn_doctors_Click;
            // 
            // btn_treatments
            // 
            btn_treatments.BackColor = Color.Gainsboro;
            btn_treatments.ForeColor = SystemColors.ActiveCaptionText;
            btn_treatments.Location = new Point(199, 244);
            btn_treatments.Name = "btn_treatments";
            btn_treatments.Size = new Size(244, 50);
            btn_treatments.TabIndex = 1;
            btn_treatments.Text = "Treatments";
            btn_treatments.UseVisualStyleBackColor = false;
            btn_treatments.Click += btn_treatments_Click;
            // 
            // btn_patients
            // 
            btn_patients.BackColor = Color.Gainsboro;
            btn_patients.ForeColor = SystemColors.ActiveCaptionText;
            btn_patients.Location = new Point(199, 163);
            btn_patients.Name = "btn_patients";
            btn_patients.Size = new Size(244, 50);
            btn_patients.TabIndex = 2;
            btn_patients.Text = "Patients";
            btn_patients.UseVisualStyleBackColor = false;
            btn_patients.Click += btn_patients_Click;
            // 
            // ffrm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(691, 609);
            Controls.Add(btn_patients);
            Controls.Add(btn_treatments);
            Controls.Add(btn_doctors);
            Name = "ffrm_Main";
            Text = "Manage System";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_doctors;
        private Button btn_treatments;
        private Button btn_patients;
    }
}
