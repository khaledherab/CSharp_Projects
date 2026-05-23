namespace project_programming_2
{
    partial class Treatment_Manage
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
            tbc_treatment = new TabControl();
            tp_addtreatment = new TabPage();
            txt_treatcost = new TextBox();
            lbl_treatcost = new Label();
            cmb_patient = new ComboBox();
            cmb_doctor = new ComboBox();
            cmb_dept = new ComboBox();
            btn_back = new Button();
            btn_addtreatment = new Button();
            cmb_typetreatment = new ComboBox();
            txt_idclinic = new TextBox();
            txt_id_treatment = new TextBox();
            lbl_idclinic = new Label();
            lbl_iddepartment = new Label();
            lbl_typetreatment = new Label();
            lbl_iddoctor = new Label();
            lbl_idpatient = new Label();
            lbl_idtraetment = new Label();
            tp_view = new TabPage();
            btn_showdetails = new Button();
            txt_id_patforviewdetails = new TextBox();
            lbl_searchpatient = new Label();
            grd_Treatment = new DataGridView();
            tbc_treatment.SuspendLayout();
            tp_addtreatment.SuspendLayout();
            tp_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_Treatment).BeginInit();
            SuspendLayout();
            // 
            // tbc_treatment
            // 
            tbc_treatment.Controls.Add(tp_addtreatment);
            tbc_treatment.Controls.Add(tp_view);
            tbc_treatment.Location = new Point(1, 0);
            tbc_treatment.Name = "tbc_treatment";
            tbc_treatment.SelectedIndex = 0;
            tbc_treatment.Size = new Size(516, 657);
            tbc_treatment.TabIndex = 0;
            // 
            // tp_addtreatment
            // 
            tp_addtreatment.BackColor = Color.Silver;
            tp_addtreatment.Controls.Add(txt_treatcost);
            tp_addtreatment.Controls.Add(lbl_treatcost);
            tp_addtreatment.Controls.Add(cmb_patient);
            tp_addtreatment.Controls.Add(cmb_doctor);
            tp_addtreatment.Controls.Add(cmb_dept);
            tp_addtreatment.Controls.Add(btn_back);
            tp_addtreatment.Controls.Add(btn_addtreatment);
            tp_addtreatment.Controls.Add(cmb_typetreatment);
            tp_addtreatment.Controls.Add(txt_idclinic);
            tp_addtreatment.Controls.Add(txt_id_treatment);
            tp_addtreatment.Controls.Add(lbl_idclinic);
            tp_addtreatment.Controls.Add(lbl_iddepartment);
            tp_addtreatment.Controls.Add(lbl_typetreatment);
            tp_addtreatment.Controls.Add(lbl_iddoctor);
            tp_addtreatment.Controls.Add(lbl_idpatient);
            tp_addtreatment.Controls.Add(lbl_idtraetment);
            tp_addtreatment.Location = new Point(4, 29);
            tp_addtreatment.Name = "tp_addtreatment";
            tp_addtreatment.Padding = new Padding(3);
            tp_addtreatment.Size = new Size(508, 624);
            tp_addtreatment.TabIndex = 0;
            tp_addtreatment.Text = "Add Treatment";
            // 
            // txt_treatcost
            // 
            txt_treatcost.Location = new Point(275, 348);
            txt_treatcost.Name = "txt_treatcost";
            txt_treatcost.Size = new Size(143, 27);
            txt_treatcost.TabIndex = 18;
            // 
            // lbl_treatcost
            // 
            lbl_treatcost.Location = new Point(111, 342);
            lbl_treatcost.Name = "lbl_treatcost";
            lbl_treatcost.Size = new Size(146, 38);
            lbl_treatcost.TabIndex = 17;
            lbl_treatcost.Text = "Cost";
            lbl_treatcost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmb_patient
            // 
            cmb_patient.FormattingEnabled = true;
            cmb_patient.Items.AddRange(new object[] { "External", "Internal" });
            cmb_patient.Location = new Point(275, 93);
            cmb_patient.Name = "cmb_patient";
            cmb_patient.Size = new Size(143, 28);
            cmb_patient.TabIndex = 16;
            // 
            // cmb_doctor
            // 
            cmb_doctor.FormattingEnabled = true;
            cmb_doctor.Items.AddRange(new object[] { "External", "Internal" });
            cmb_doctor.Location = new Point(275, 148);
            cmb_doctor.Name = "cmb_doctor";
            cmb_doctor.Size = new Size(143, 28);
            cmb_doctor.TabIndex = 15;
            // 
            // cmb_dept
            // 
            cmb_dept.FormattingEnabled = true;
            cmb_dept.Items.AddRange(new object[] { "External", "Internal" });
            cmb_dept.Location = new Point(275, 257);
            cmb_dept.Name = "cmb_dept";
            cmb_dept.Size = new Size(143, 28);
            cmb_dept.TabIndex = 14;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Gainsboro;
            btn_back.Location = new Point(203, 538);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(147, 52);
            btn_back.TabIndex = 13;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_addtreatment
            // 
            btn_addtreatment.BackColor = Color.Gainsboro;
            btn_addtreatment.Location = new Point(203, 465);
            btn_addtreatment.Name = "btn_addtreatment";
            btn_addtreatment.Size = new Size(147, 52);
            btn_addtreatment.TabIndex = 12;
            btn_addtreatment.Text = "Add";
            btn_addtreatment.UseVisualStyleBackColor = false;
            btn_addtreatment.Click += btn_addtreatment_Click;
            // 
            // cmb_typetreatment
            // 
            cmb_typetreatment.FormattingEnabled = true;
            cmb_typetreatment.Items.AddRange(new object[] { "External", "Internal" });
            cmb_typetreatment.Location = new Point(275, 207);
            cmb_typetreatment.Name = "cmb_typetreatment";
            cmb_typetreatment.Size = new Size(143, 28);
            cmb_typetreatment.TabIndex = 11;
            cmb_typetreatment.SelectedIndexChanged += cmb_typetreatment_SelectedIndexChanged;
            // 
            // txt_idclinic
            // 
            txt_idclinic.Location = new Point(275, 295);
            txt_idclinic.Name = "txt_idclinic";
            txt_idclinic.Size = new Size(143, 27);
            txt_idclinic.TabIndex = 10;
            // 
            // txt_id_treatment
            // 
            txt_id_treatment.Location = new Point(275, 27);
            txt_id_treatment.Name = "txt_id_treatment";
            txt_id_treatment.Size = new Size(143, 27);
            txt_id_treatment.TabIndex = 6;
            // 
            // lbl_idclinic
            // 
            lbl_idclinic.Location = new Point(111, 289);
            lbl_idclinic.Name = "lbl_idclinic";
            lbl_idclinic.Size = new Size(146, 38);
            lbl_idclinic.TabIndex = 5;
            lbl_idclinic.Text = "ID Clinic";
            lbl_idclinic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_iddepartment
            // 
            lbl_iddepartment.Location = new Point(111, 251);
            lbl_iddepartment.Name = "lbl_iddepartment";
            lbl_iddepartment.Size = new Size(146, 38);
            lbl_iddepartment.TabIndex = 4;
            lbl_iddepartment.Text = " Department";
            lbl_iddepartment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_typetreatment
            // 
            lbl_typetreatment.Location = new Point(111, 201);
            lbl_typetreatment.Name = "lbl_typetreatment";
            lbl_typetreatment.Size = new Size(146, 38);
            lbl_typetreatment.TabIndex = 3;
            lbl_typetreatment.Text = "Type Treatment";
            lbl_typetreatment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_iddoctor
            // 
            lbl_iddoctor.Location = new Point(111, 142);
            lbl_iddoctor.Name = "lbl_iddoctor";
            lbl_iddoctor.Size = new Size(146, 38);
            lbl_iddoctor.TabIndex = 2;
            lbl_iddoctor.Text = "Doctor";
            lbl_iddoctor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_idpatient
            // 
            lbl_idpatient.Location = new Point(111, 87);
            lbl_idpatient.Name = "lbl_idpatient";
            lbl_idpatient.Size = new Size(146, 38);
            lbl_idpatient.TabIndex = 1;
            lbl_idpatient.Text = "Patient";
            lbl_idpatient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_idtraetment
            // 
            lbl_idtraetment.Location = new Point(111, 21);
            lbl_idtraetment.Name = "lbl_idtraetment";
            lbl_idtraetment.Size = new Size(146, 38);
            lbl_idtraetment.TabIndex = 0;
            lbl_idtraetment.Text = "ID Treatment";
            lbl_idtraetment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tp_view
            // 
            tp_view.BackColor = Color.Silver;
            tp_view.Controls.Add(btn_showdetails);
            tp_view.Controls.Add(txt_id_patforviewdetails);
            tp_view.Controls.Add(lbl_searchpatient);
            tp_view.Location = new Point(4, 29);
            tp_view.Name = "tp_view";
            tp_view.Padding = new Padding(3);
            tp_view.Size = new Size(508, 624);
            tp_view.TabIndex = 1;
            tp_view.Text = "view details";
            // 
            // btn_showdetails
            // 
            btn_showdetails.BackColor = Color.Gainsboro;
            btn_showdetails.Location = new Point(161, 316);
            btn_showdetails.Name = "btn_showdetails";
            btn_showdetails.Size = new Size(165, 43);
            btn_showdetails.TabIndex = 2;
            btn_showdetails.Text = "Show";
            btn_showdetails.UseVisualStyleBackColor = false;
            btn_showdetails.Click += btn_showdetails_Click;
            // 
            // txt_id_patforviewdetails
            // 
            txt_id_patforviewdetails.Location = new Point(140, 169);
            txt_id_patforviewdetails.Name = "txt_id_patforviewdetails";
            txt_id_patforviewdetails.Size = new Size(208, 27);
            txt_id_patforviewdetails.TabIndex = 1;
            // 
            // lbl_searchpatient
            // 
            lbl_searchpatient.Location = new Point(103, 51);
            lbl_searchpatient.Name = "lbl_searchpatient";
            lbl_searchpatient.Size = new Size(274, 49);
            lbl_searchpatient.TabIndex = 0;
            lbl_searchpatient.Text = "Enter The Patient ID To View All Athier Treatments";
            lbl_searchpatient.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grd_Treatment
            // 
            grd_Treatment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_Treatment.BackgroundColor = Color.WhiteSmoke;
            grd_Treatment.ColumnHeadersHeight = 29;
            grd_Treatment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grd_Treatment.Location = new Point(523, 12);
            grd_Treatment.Name = "grd_Treatment";
            grd_Treatment.RowHeadersWidth = 51;
            grd_Treatment.Size = new Size(690, 641);
            grd_Treatment.TabIndex = 1;
            // 
            // Treatment_Manage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 659);
            Controls.Add(grd_Treatment);
            Controls.Add(tbc_treatment);
            Name = "Treatment_Manage";
            Text = "Treatment_Manage";
            Load += Treatment_Manage_Load;
            tbc_treatment.ResumeLayout(false);
            tp_addtreatment.ResumeLayout(false);
            tp_addtreatment.PerformLayout();
            tp_view.ResumeLayout(false);
            tp_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd_Treatment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbc_treatment;
        private TabPage tp_addtreatment;
        private TabPage tp_view;
        private Label lbl_idtraetment;
        private Label lbl_idclinic;
        private Label lbl_iddepartment;
        private Label lbl_typetreatment;
        private Label lbl_iddoctor;
        private Label lbl_idpatient;
        private TextBox txt_id_treatment;
        private ComboBox cmb_typetreatment;
        private TextBox txt_idclinic;
        private Button btn_back;
        private Button btn_addtreatment;
        private DataGridView grd_Treatment;
        private Label lbl_searchpatient;
        private TextBox txt_id_patforviewdetails;
        private ComboBox cmb_patient;
        private ComboBox cmb_doctor;
        private ComboBox cmb_dept;
        private TextBox txt_treatcost;
        private Label lbl_treatcost;
        private Button btn_showdetails;
    }
}