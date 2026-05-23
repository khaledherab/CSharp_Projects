using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace project_programming_2
{
    public partial class frm_Manage_patient : Form
    {
        public frm_Manage_patient()
        {
            InitializeComponent();
        }

        private void frm_Manage_patient_Load(object sender, EventArgs e)
        {
            LoadDataPatients();
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                try
                {

                    string query = "SELECT Doc_ID, (Doc_Name + ' - ' + Doc_Type) AS DoctorInfo FROM Doctors";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    cmb_selectdoctor.DataSource = dt;
                    cmb_selectdoctor.DisplayMember = "DoctorInfo";
                    cmb_selectdoctor.ValueMember = "Doc_ID";


                    cmb_selectdoctor.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Loading Doctors " + ex.Message);
                }
            }
        }
        private void btn_add_patient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_patient.Text) || string.IsNullOrEmpty(txt_name_patient.Text) || string.IsNullOrEmpty(txt_address.Text) || string.IsNullOrEmpty(txt_birthdate.Text))
            {
                MessageBox.Show(" Enter All Information First ", "Warning ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                try
                {
                    string Query = "INSERT INTO Patients(Pat_ID,Pat_Name,Address,Birth_Date,Doc_ID,Patient_Type,isDischarged) VALUES(@id,@name,@address,@birth_date,@id_doctor,@type,@isdischarged)";

                    SqlCommand cmd = new SqlCommand(Query, conn);

                    cmd.Parameters.AddWithValue("@id", int.Parse(txt_id_patient.Text));
                    cmd.Parameters.AddWithValue("@name", txt_name_patient.Text);
                    cmd.Parameters.AddWithValue("@address", txt_address.Text);
                    cmd.Parameters.AddWithValue("@birth_date", txt_birthdate.Text);
                    cmd.Parameters.AddWithValue("@id_doctor", cmb_selectdoctor.SelectedValue);
                    cmd.Parameters.AddWithValue("@type", cmb_type_patient.SelectedItem?.ToString());
                    cmd.Parameters.AddWithValue("@isdischarged", false);
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    LoadDataPatients();

                    MessageBox.Show("the patient was successfully added ", "success", MessageBoxButtons.OK);


                    txt_id_patient.Clear();
                    txt_name_patient.Clear();
                    txt_address.Clear();
                    txt_birthdate.Clear();
                    cmb_selectdoctor.SelectedIndex = -1;
                    cmb_type_patient.SelectedIndex = -1;


                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error DataBase Connection " + ex.Message);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("Error in database patient" + ex2.Message);
                }
            }


        }
        private void LoadDataPatients()
        {
            using (SqlConnection connect = DataBaseHelper.GetConnection())
            {
                string query = "select * from Patients";
                SqlDataAdapter readdata = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                readdata.Fill(dt);

                grd_Patients.DataSource = dt;
            }
        }

        private void btn_discharge_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_patientfordischarge.Text))
            {
                MessageBox.Show("please enter id patient ");
                return;
            }
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                try
                {
                    string query = "update Patients set isdischarged = @discharged where Pat_ID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@discharged", true);
                    cmd.Parameters.AddWithValue("@id", txt_id_patientfordischarge.Text);

                    conn.Open();
                    int rowaffected = cmd.ExecuteNonQuery();
                    if (rowaffected > 0)
                    {
                        LoadDataPatients();
                        MessageBox.Show("the patient was discharged successfully");
                        txt_id_patientfordischarge.Clear();
                    }
                    else
                    {
                        MessageBox.Show("the patient not found ", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error database Connection " + ex.Message);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("Error in database patient" + ex1.Message);
                }
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
