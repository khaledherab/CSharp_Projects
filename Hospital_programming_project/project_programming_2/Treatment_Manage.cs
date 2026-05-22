using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace project_programming_2
{
    public partial class Treatment_Manage : Form
    {
        public Treatment_Manage()
        {
            InitializeComponent();
        }

        private void cmb_typetreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_typetreatment.SelectedItem == null) return;

            string typetreatment = cmb_typetreatment.SelectedItem.ToString();


            lbl_idclinic.Visible = true;
            txt_idclinic.Visible = true;
            lbl_iddepartment.Visible = true;
            cmb_dept.Visible = true;

            if (typetreatment == "Internal")
            {
                lbl_idclinic.Visible = false;
                txt_idclinic.Visible = false;
            }
            else if (typetreatment == "External")
            {
                lbl_iddepartment.Visible = false;
                cmb_dept.Visible = false;
            }
        }

        private void btn_addtreatment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_treatment.Text))
            {
                MessageBox.Show("please enter all information", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                try
                {
                    string query = "INSERT INTO Treatments(Treat_ID,Pat_ID,Doc_ID,Stay_Type,Dept_ID,Clinic_ID,Treat_Cost,Treat_Date) VALUES(@id_treat, @id_pat, @id_doc, @type_treat, @id_dept, @id_clinic,@treatcost,@datetreat)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id_treat", txt_id_treatment.Text);
                    cmd.Parameters.AddWithValue("@id_pat", cmb_patient.SelectedValue);
                    cmd.Parameters.AddWithValue("@id_doc", cmb_doctor.SelectedValue);
                    cmd.Parameters.AddWithValue("@type_treat", cmb_typetreatment.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@id_dept", cmb_dept.SelectedValue);
                    cmd.Parameters.AddWithValue("@id_clinic", txt_idclinic.Text);
                    cmd.Parameters.AddWithValue("@treatcost", txt_treatcost.Text);
                    cmd.Parameters.AddWithValue("@datetreat", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LoadDataTreatment();

                    MessageBox.Show("Treatment record added successfully");


                    txt_id_treatment.Clear();
                    txt_idclinic.Clear();
                    cmb_patient.SelectedIndex = -1;
                    cmb_doctor.SelectedIndex = -1;
                    cmb_typetreatment.SelectedIndex = -1;
                    cmb_dept.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Check if Patient/Doctor IDs exist", ex.Message);
                }
            }

        }
        private void LoadDataTreatment()
        {
            using (SqlConnection connect = DataBaseHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Treatments";
                    SqlDataAdapter data = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    data.Fill(dataTable);
                    grd_Treatment.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Loading Data " + ex.Message);
                }
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Treatment_Manage_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();

                    SqlDataAdapter dataPat = new SqlDataAdapter("SELECT Pat_ID, Pat_Name FROM Patients", conn);
                    DataTable tablePat = new DataTable();
                    dataPat.Fill(tablePat);
                    cmb_patient.DataSource = tablePat;
                    cmb_patient.DisplayMember = "Pat_Name";
                    cmb_patient.ValueMember = "Pat_ID";

                    SqlDataAdapter dataDoc = new SqlDataAdapter("SELECT Doc_ID, Doc_Name FROM Doctors", conn);
                    DataTable tableDoc = new DataTable();
                    dataDoc.Fill(tableDoc);
                    cmb_doctor.DataSource = tableDoc;
                    cmb_doctor.DisplayMember = "Doc_Name";
                    cmb_doctor.ValueMember = "Doc_ID";

                    SqlDataAdapter dataDept = new SqlDataAdapter("SELECT Dept_ID, Dept_Name FROM Departments", conn);
                    DataTable tableDept = new DataTable();
                    dataDept.Fill(tableDept);
                    cmb_dept.DataSource = tableDept;
                    cmb_dept.DisplayMember = "Dept_Name";
                    cmb_dept.ValueMember = "Dept_ID";

                    LoadDataTreatment();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data Loading Error" + ex.Message);
                }
            }
        }

        private void btn_showdetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_patforviewdetails.Text))
            {
                MessageBox.Show("Please enter the Patient ID first");
                return;
            }
            using(SqlConnection conn = DataBaseHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT * FROM Treatments where Pat_ID=@patientid";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@patientid",txt_id_patforviewdetails.Text);
                    SqlDataAdapter data = new SqlDataAdapter(cmd);
                    DataTable tableDept = new DataTable();
                    data.Fill(tableDept);

                    if(tableDept.Rows.Count > 0)
                    {
                        grd_Treatment.DataSource = tableDept;
                    }
                    else
                    {
                        grd_Treatment.DataSource = null;
                        MessageBox.Show("No treatments found for this Patient ID");
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Error while fetching data: " + ex.Message);
                }
            }
        }
    }
}
