namespace project_programming_2
{
    partial class Manage_Doctors
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
            grd_Doctos = new DataGridView();
            tbc_AddandRemovedoctor = new TabControl();
            tbc_AddDoctor = new TabPage();
            cmb_id_depatment = new ComboBox();
            lbl_id_department = new Label();
            txt_id_doctor = new TextBox();
            lbl_id_doctor = new Label();
            btn_back = new Button();
            btn_add_doctor = new Button();
            txt_yearexperience = new TextBox();
            txt_salary = new TextBox();
            lbl_yearexperience = new Label();
            lbl_salary = new Label();
            cmb_Typedoctor = new ComboBox();
            lbl_type_doctor = new Label();
            txt_Name_doctor = new TextBox();
            lbl_name_doctor = new Label();
            tbc_RemovDoctor = new TabPage();
            btn_removedoctor = new Button();
            txt_id_toremove = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)grd_Doctos).BeginInit();
            tbc_AddandRemovedoctor.SuspendLayout();
            tbc_AddDoctor.SuspendLayout();
            tbc_RemovDoctor.SuspendLayout();
            SuspendLayout();
            // 
            // grd_Doctos
            // 
            grd_Doctos.AllowUserToAddRows = false;
            grd_Doctos.AllowUserToDeleteRows = false;
            grd_Doctos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_Doctos.BackgroundColor = Color.WhiteSmoke;
            grd_Doctos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_Doctos.Location = new Point(607, 5);
            grd_Doctos.Name = "grd_Doctos";
            grd_Doctos.ReadOnly = true;
            grd_Doctos.RowHeadersWidth = 51;
            grd_Doctos.Size = new Size(611, 611);
            grd_Doctos.TabIndex = 5;
            grd_Doctos.CellClick += grd_Doctos_CellClick;
            // 
            // tbc_AddandRemovedoctor
            // 
            tbc_AddandRemovedoctor.Controls.Add(tbc_AddDoctor);
            tbc_AddandRemovedoctor.Controls.Add(tbc_RemovDoctor);
            tbc_AddandRemovedoctor.Location = new Point(4, 5);
            tbc_AddandRemovedoctor.Name = "tbc_AddandRemovedoctor";
            tbc_AddandRemovedoctor.SelectedIndex = 0;
            tbc_AddandRemovedoctor.Size = new Size(601, 611);
            tbc_AddandRemovedoctor.TabIndex = 4;
            // 
            // tbc_AddDoctor
            // 
            tbc_AddDoctor.BackColor = Color.Silver;
            tbc_AddDoctor.Controls.Add(cmb_id_depatment);
            tbc_AddDoctor.Controls.Add(lbl_id_department);
            tbc_AddDoctor.Controls.Add(txt_id_doctor);
            tbc_AddDoctor.Controls.Add(lbl_id_doctor);
            tbc_AddDoctor.Controls.Add(btn_back);
            tbc_AddDoctor.Controls.Add(btn_add_doctor);
            tbc_AddDoctor.Controls.Add(txt_yearexperience);
            tbc_AddDoctor.Controls.Add(txt_salary);
            tbc_AddDoctor.Controls.Add(lbl_yearexperience);
            tbc_AddDoctor.Controls.Add(lbl_salary);
            tbc_AddDoctor.Controls.Add(cmb_Typedoctor);
            tbc_AddDoctor.Controls.Add(lbl_type_doctor);
            tbc_AddDoctor.Controls.Add(txt_Name_doctor);
            tbc_AddDoctor.Controls.Add(lbl_name_doctor);
            tbc_AddDoctor.Location = new Point(4, 29);
            tbc_AddDoctor.Name = "tbc_AddDoctor";
            tbc_AddDoctor.Padding = new Padding(3);
            tbc_AddDoctor.Size = new Size(593, 578);
            tbc_AddDoctor.TabIndex = 0;
            tbc_AddDoctor.Text = "Add Doctor";
            // 
            // cmb_id_depatment
            // 
            cmb_id_depatment.FormattingEnabled = true;
            cmb_id_depatment.Location = new Point(293, 342);
            cmb_id_depatment.Name = "cmb_id_depatment";
            cmb_id_depatment.Size = new Size(168, 28);
            cmb_id_depatment.TabIndex = 13;
            // 
            // lbl_id_department
            // 
            lbl_id_department.Location = new Point(151, 339);
            lbl_id_department.Name = "lbl_id_department";
            lbl_id_department.Size = new Size(120, 35);
            lbl_id_department.TabIndex = 12;
            lbl_id_department.Text = " Department";
            lbl_id_department.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_id_doctor
            // 
            txt_id_doctor.Location = new Point(293, 9);
            txt_id_doctor.Name = "txt_id_doctor";
            txt_id_doctor.Size = new Size(168, 27);
            txt_id_doctor.TabIndex = 11;
            // 
            // lbl_id_doctor
            // 
            lbl_id_doctor.Location = new Point(156, 3);
            lbl_id_doctor.Name = "lbl_id_doctor";
            lbl_id_doctor.Size = new Size(120, 35);
            lbl_id_doctor.TabIndex = 10;
            lbl_id_doctor.Text = "ID";
            lbl_id_doctor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Gainsboro;
            btn_back.Location = new Point(190, 507);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(188, 40);
            btn_back.TabIndex = 9;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_add_doctor
            // 
            btn_add_doctor.BackColor = Color.Gainsboro;
            btn_add_doctor.Location = new Point(190, 427);
            btn_add_doctor.Name = "btn_add_doctor";
            btn_add_doctor.Size = new Size(188, 42);
            btn_add_doctor.TabIndex = 8;
            btn_add_doctor.Text = "Add Doctor";
            btn_add_doctor.UseVisualStyleBackColor = false;
            btn_add_doctor.Click += btn_add_doctor_Click;
            // 
            // txt_yearexperience
            // 
            txt_yearexperience.Location = new Point(293, 195);
            txt_yearexperience.Name = "txt_yearexperience";
            txt_yearexperience.Size = new Size(168, 27);
            txt_yearexperience.TabIndex = 7;
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(293, 265);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(168, 27);
            txt_salary.TabIndex = 6;
            // 
            // lbl_yearexperience
            // 
            lbl_yearexperience.Location = new Point(151, 191);
            lbl_yearexperience.Name = "lbl_yearexperience";
            lbl_yearexperience.Size = new Size(120, 36);
            lbl_yearexperience.TabIndex = 5;
            lbl_yearexperience.Text = "Year Experience";
            lbl_yearexperience.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_salary
            // 
            lbl_salary.Location = new Point(151, 265);
            lbl_salary.Name = "lbl_salary";
            lbl_salary.Size = new Size(120, 35);
            lbl_salary.TabIndex = 4;
            lbl_salary.Text = "Salary";
            lbl_salary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmb_Typedoctor
            // 
            cmb_Typedoctor.FormattingEnabled = true;
            cmb_Typedoctor.Items.AddRange(new object[] { "Contract", "Staff", "Trainee" });
            cmb_Typedoctor.Location = new Point(293, 126);
            cmb_Typedoctor.Name = "cmb_Typedoctor";
            cmb_Typedoctor.Size = new Size(168, 28);
            cmb_Typedoctor.TabIndex = 3;
            cmb_Typedoctor.SelectedIndexChanged += cmb_Typedoctor_SelectedIndexChanged;
            // 
            // lbl_type_doctor
            // 
            lbl_type_doctor.Location = new Point(151, 123);
            lbl_type_doctor.Name = "lbl_type_doctor";
            lbl_type_doctor.Size = new Size(120, 35);
            lbl_type_doctor.TabIndex = 2;
            lbl_type_doctor.Text = "Type";
            lbl_type_doctor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Name_doctor
            // 
            txt_Name_doctor.Location = new Point(293, 63);
            txt_Name_doctor.Name = "txt_Name_doctor";
            txt_Name_doctor.Size = new Size(168, 27);
            txt_Name_doctor.TabIndex = 1;
            // 
            // lbl_name_doctor
            // 
            lbl_name_doctor.Location = new Point(151, 60);
            lbl_name_doctor.Name = "lbl_name_doctor";
            lbl_name_doctor.Size = new Size(120, 35);
            lbl_name_doctor.TabIndex = 0;
            lbl_name_doctor.Text = "Name";
            lbl_name_doctor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbc_RemovDoctor
            // 
            tbc_RemovDoctor.BackColor = Color.Silver;
            tbc_RemovDoctor.Controls.Add(btn_removedoctor);
            tbc_RemovDoctor.Controls.Add(txt_id_toremove);
            tbc_RemovDoctor.Controls.Add(label6);
            tbc_RemovDoctor.Location = new Point(4, 29);
            tbc_RemovDoctor.Name = "tbc_RemovDoctor";
            tbc_RemovDoctor.Padding = new Padding(3);
            tbc_RemovDoctor.Size = new Size(593, 578);
            tbc_RemovDoctor.TabIndex = 1;
            tbc_RemovDoctor.Text = "Remove Doctor";
            // 
            // btn_removedoctor
            // 
            btn_removedoctor.BackColor = Color.Gainsboro;
            btn_removedoctor.Location = new Point(182, 278);
            btn_removedoctor.Name = "btn_removedoctor";
            btn_removedoctor.Size = new Size(188, 51);
            btn_removedoctor.TabIndex = 2;
            btn_removedoctor.Text = "Remove";
            btn_removedoctor.UseVisualStyleBackColor = false;
            btn_removedoctor.Click += btn_removedoctor_Click;
            // 
            // txt_id_toremove
            // 
            txt_id_toremove.Location = new Point(199, 139);
            txt_id_toremove.Name = "txt_id_toremove";
            txt_id_toremove.Size = new Size(171, 27);
            txt_id_toremove.TabIndex = 1;
            // 
            // label6
            // 
            label6.Location = new Point(190, 46);
            label6.Name = "label6";
            label6.Size = new Size(180, 37);
            label6.TabIndex = 0;
            label6.Text = "Enter ID To Remove ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Manage_Doctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 629);
            Controls.Add(grd_Doctos);
            Controls.Add(tbc_AddandRemovedoctor);
            Name = "Manage_Doctors";
            Text = "Manage_Doctors";
            Load += Manage_Doctors_Load;
            ((System.ComponentModel.ISupportInitialize)grd_Doctos).EndInit();
            tbc_AddandRemovedoctor.ResumeLayout(false);
            tbc_AddDoctor.ResumeLayout(false);
            tbc_AddDoctor.PerformLayout();
            tbc_RemovDoctor.ResumeLayout(false);
            tbc_RemovDoctor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grd_Doctos;
        private TabControl tbc_AddandRemovedoctor;
        private TabPage tbc_AddDoctor;
        private TextBox txt_id_doctor;
        private Label lbl_id_doctor;
        private Button btn_add_doctor;
        private TextBox txt_yearexperience;
        private TextBox txt_salary;
        private Label lbl_yearexperience;
        private Label lbl_salary;
        private ComboBox cmb_Typedoctor;
        private Label lbl_type_doctor;
        private TextBox txt_Name_doctor;
        private Label lbl_name_doctor;
        private TabPage tbc_RemovDoctor;
        private Button btn_removedoctor;
        private TextBox txt_id_toremove;
        private Label label6;
        private ComboBox cmb_id_depatment;
        private Label lbl_id_department;
        private Button btn_back;
    }
}