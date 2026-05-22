namespace project_programming_2
{
    partial class frm_Manage_patient
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
            tbc_addAnddischargePatient = new TabControl();
            tb_Add_patient = new TabPage();
            cmb_selectdoctor = new ComboBox();
            txt_birthdate = new TextBox();
            txt_address = new TextBox();
            lbl_address = new Label();
            lbl_birth_date = new Label();
            btn_back = new Button();
            btn_add_patient = new Button();
            cmb_type_patient = new ComboBox();
            txt_name_patient = new TextBox();
            txt_id_patient = new TextBox();
            lbl_id_doctorwithpatient = new Label();
            lbl_type_patient = new Label();
            lbl_name_patient = new Label();
            lbl_Id_patient = new Label();
            tb_discharge = new TabPage();
            btn_discharge = new Button();
            txt_id_patientfordischarge = new TextBox();
            lbl_discharge_patient = new Label();
            grd_Patients = new DataGridView();
            tbc_addAnddischargePatient.SuspendLayout();
            tb_Add_patient.SuspendLayout();
            tb_discharge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_Patients).BeginInit();
            SuspendLayout();
            // 
            // tbc_addAnddischargePatient
            // 
            tbc_addAnddischargePatient.Controls.Add(tb_Add_patient);
            tbc_addAnddischargePatient.Controls.Add(tb_discharge);
            tbc_addAnddischargePatient.Location = new Point(1, 2);
            tbc_addAnddischargePatient.Name = "tbc_addAnddischargePatient";
            tbc_addAnddischargePatient.SelectedIndex = 0;
            tbc_addAnddischargePatient.Size = new Size(475, 609);
            tbc_addAnddischargePatient.TabIndex = 0;
            // 
            // tb_Add_patient
            // 
            tb_Add_patient.BackColor = Color.Silver;
            tb_Add_patient.Controls.Add(cmb_selectdoctor);
            tb_Add_patient.Controls.Add(txt_birthdate);
            tb_Add_patient.Controls.Add(txt_address);
            tb_Add_patient.Controls.Add(lbl_address);
            tb_Add_patient.Controls.Add(lbl_birth_date);
            tb_Add_patient.Controls.Add(btn_back);
            tb_Add_patient.Controls.Add(btn_add_patient);
            tb_Add_patient.Controls.Add(cmb_type_patient);
            tb_Add_patient.Controls.Add(txt_name_patient);
            tb_Add_patient.Controls.Add(txt_id_patient);
            tb_Add_patient.Controls.Add(lbl_id_doctorwithpatient);
            tb_Add_patient.Controls.Add(lbl_type_patient);
            tb_Add_patient.Controls.Add(lbl_name_patient);
            tb_Add_patient.Controls.Add(lbl_Id_patient);
            tb_Add_patient.Location = new Point(4, 29);
            tb_Add_patient.Name = "tb_Add_patient";
            tb_Add_patient.Padding = new Padding(3);
            tb_Add_patient.Size = new Size(467, 576);
            tb_Add_patient.TabIndex = 0;
            tb_Add_patient.Text = "Add Patient";
            // 
            // cmb_selectdoctor
            // 
            cmb_selectdoctor.FormattingEnabled = true;
            cmb_selectdoctor.Items.AddRange(new object[] { "External", "Internal" });
            cmb_selectdoctor.Location = new Point(226, 251);
            cmb_selectdoctor.Name = "cmb_selectdoctor";
            cmb_selectdoctor.Size = new Size(169, 28);
            cmb_selectdoctor.TabIndex = 14;
            // 
            // txt_birthdate
            // 
            txt_birthdate.Location = new Point(225, 184);
            txt_birthdate.Name = "txt_birthdate";
            txt_birthdate.Size = new Size(169, 27);
            txt_birthdate.TabIndex = 13;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(225, 123);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(169, 27);
            txt_address.TabIndex = 12;
            // 
            // lbl_address
            // 
            lbl_address.Location = new Point(83, 125);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(115, 25);
            lbl_address.TabIndex = 11;
            lbl_address.Text = "Address";
            lbl_address.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_birth_date
            // 
            lbl_birth_date.Location = new Point(83, 185);
            lbl_birth_date.Name = "lbl_birth_date";
            lbl_birth_date.Size = new Size(115, 25);
            lbl_birth_date.TabIndex = 10;
            lbl_birth_date.Text = "Birth Date";
            lbl_birth_date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Gainsboro;
            btn_back.Location = new Point(107, 483);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(212, 54);
            btn_back.TabIndex = 9;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_add_patient
            // 
            btn_add_patient.BackColor = Color.Gainsboro;
            btn_add_patient.Location = new Point(107, 400);
            btn_add_patient.Name = "btn_add_patient";
            btn_add_patient.Size = new Size(212, 54);
            btn_add_patient.TabIndex = 8;
            btn_add_patient.Text = "Add Patient";
            btn_add_patient.UseVisualStyleBackColor = false;
            btn_add_patient.Click += btn_add_patient_Click;
            // 
            // cmb_type_patient
            // 
            cmb_type_patient.FormattingEnabled = true;
            cmb_type_patient.Items.AddRange(new object[] { "External", "Internal" });
            cmb_type_patient.Location = new Point(225, 315);
            cmb_type_patient.Name = "cmb_type_patient";
            cmb_type_patient.Size = new Size(169, 28);
            cmb_type_patient.TabIndex = 7;
            // 
            // txt_name_patient
            // 
            txt_name_patient.Location = new Point(225, 68);
            txt_name_patient.Name = "txt_name_patient";
            txt_name_patient.Size = new Size(169, 27);
            txt_name_patient.TabIndex = 6;
            // 
            // txt_id_patient
            // 
            txt_id_patient.Location = new Point(225, 19);
            txt_id_patient.Name = "txt_id_patient";
            txt_id_patient.Size = new Size(169, 27);
            txt_id_patient.TabIndex = 4;
            // 
            // lbl_id_doctorwithpatient
            // 
            lbl_id_doctorwithpatient.Location = new Point(83, 252);
            lbl_id_doctorwithpatient.Name = "lbl_id_doctorwithpatient";
            lbl_id_doctorwithpatient.Size = new Size(115, 25);
            lbl_id_doctorwithpatient.TabIndex = 3;
            lbl_id_doctorwithpatient.Text = " Doctor";
            lbl_id_doctorwithpatient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_type_patient
            // 
            lbl_type_patient.Location = new Point(83, 318);
            lbl_type_patient.Name = "lbl_type_patient";
            lbl_type_patient.Size = new Size(115, 25);
            lbl_type_patient.TabIndex = 2;
            lbl_type_patient.Text = "Type";
            lbl_type_patient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_name_patient
            // 
            lbl_name_patient.Location = new Point(83, 69);
            lbl_name_patient.Name = "lbl_name_patient";
            lbl_name_patient.Size = new Size(115, 25);
            lbl_name_patient.TabIndex = 1;
            lbl_name_patient.Text = "Name";
            lbl_name_patient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Id_patient
            // 
            lbl_Id_patient.Location = new Point(83, 19);
            lbl_Id_patient.Name = "lbl_Id_patient";
            lbl_Id_patient.Size = new Size(115, 25);
            lbl_Id_patient.TabIndex = 0;
            lbl_Id_patient.Text = "ID";
            lbl_Id_patient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_discharge
            // 
            tb_discharge.BackColor = Color.Silver;
            tb_discharge.Controls.Add(btn_discharge);
            tb_discharge.Controls.Add(txt_id_patientfordischarge);
            tb_discharge.Controls.Add(lbl_discharge_patient);
            tb_discharge.Location = new Point(4, 29);
            tb_discharge.Name = "tb_discharge";
            tb_discharge.Padding = new Padding(3);
            tb_discharge.Size = new Size(467, 576);
            tb_discharge.TabIndex = 1;
            tb_discharge.Text = "Discharge and view";
            // 
            // btn_discharge
            // 
            btn_discharge.Location = new Point(116, 229);
            btn_discharge.Name = "btn_discharge";
            btn_discharge.Size = new Size(181, 48);
            btn_discharge.TabIndex = 2;
            btn_discharge.Text = "Discharge";
            btn_discharge.UseVisualStyleBackColor = true;
            btn_discharge.Click += btn_discharge_Click;
            // 
            // txt_id_patientfordischarge
            // 
            txt_id_patientfordischarge.Location = new Point(126, 141);
            txt_id_patientfordischarge.Name = "txt_id_patientfordischarge";
            txt_id_patientfordischarge.Size = new Size(155, 27);
            txt_id_patientfordischarge.TabIndex = 1;
            // 
            // lbl_discharge_patient
            // 
            lbl_discharge_patient.Location = new Point(78, 42);
            lbl_discharge_patient.Name = "lbl_discharge_patient";
            lbl_discharge_patient.Size = new Size(244, 55);
            lbl_discharge_patient.TabIndex = 0;
            lbl_discharge_patient.Text = "Enter ID Patient for Discharge";
            lbl_discharge_patient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grd_Patients
            // 
            grd_Patients.AllowUserToAddRows = false;
            grd_Patients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_Patients.BackgroundColor = Color.WhiteSmoke;
            grd_Patients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_Patients.Location = new Point(482, 2);
            grd_Patients.Name = "grd_Patients";
            grd_Patients.ReadOnly = true;
            grd_Patients.RowHeadersWidth = 51;
            grd_Patients.Size = new Size(815, 605);
            grd_Patients.TabIndex = 1;
            // 
            // frm_Manage_patient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 609);
            Controls.Add(grd_Patients);
            Controls.Add(tbc_addAnddischargePatient);
            Name = "frm_Manage_patient";
            Text = "Manage_patient";
            Load += frm_Manage_patient_Load;
            tbc_addAnddischargePatient.ResumeLayout(false);
            tb_Add_patient.ResumeLayout(false);
            tb_Add_patient.PerformLayout();
            tb_discharge.ResumeLayout(false);
            tb_discharge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd_Patients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbc_addAnddischargePatient;
        private TabPage tb_Add_patient;
        private TabPage tb_discharge;
        private Label lbl_Id_patient;
        private TextBox txt_id_patient;
        private Label lbl_id_doctorwithpatient;
        private Label lbl_type_patient;
        private Label lbl_name_patient;
        private ComboBox cmb_type_patient;
        private TextBox txt_name_patient;
        private Button btn_add_patient;
        private TextBox txt_id_patientfordischarge;
        private Label lbl_discharge_patient;
        private DataGridView grd_Patients;
        private Button btn_back;
        private TextBox txt_birthdate;
        private TextBox txt_address;
        private Label lbl_address;
        private Label lbl_birth_date;
        private Button btn_discharge;
        private ComboBox cmb_selectdoctor;
    }
}