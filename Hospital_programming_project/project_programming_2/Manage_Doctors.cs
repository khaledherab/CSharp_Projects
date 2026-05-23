using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing.Text;

namespace project_programming_2
{
    public enum Doctortype
    {
       Contract,
       Staff,
       Trainee,
    }
    public partial class Manage_Doctors : Form
    {
        public Manage_Doctors()
        {
            InitializeComponent();
        }

        private void cmb_Typedoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Typedoctor.SelectedItem == null)
            {
                return;
            }
            string selecttype = cmb_Typedoctor.SelectedItem.ToString();

            if (selecttype == "Contract")
            {
                txt_salary.Visible = false;
                txt_yearexperience.Visible = false;

                lbl_salary.Visible = false;
                lbl_yearexperience.Visible = false;
            }
            else if (selecttype == "Staff")
            {
                txt_yearexperience.Visible = false;
                lbl_yearexperience.Visible = false;
                lbl_salary.Visible = true;
                txt_salary.Visible = true;
            }
            else
            {
                txt_salary.Visible = true;
                txt_yearexperience.Visible = true;

                lbl_salary.Visible = true;
                lbl_yearexperience.Visible = true;
            }
        }

        private void btn_add_doctor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_doctor.Text) || string.IsNullOrEmpty(txt_Name_doctor.Text))
            {
                MessageBox.Show("Warning ", "Enter all information first", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                try
                {
                    string query = "INSERT INTO Doctors(Doc_ID,Dept_ID,Doc_Name,Doc_Type,Years_Experience,Salary,Birth_Date) VALUES(@iddoc,@iddept,@namedoc,@typedoc,@yeardoc,@salarydoc,@datedoc)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@iddoc", int.Parse(txt_id_doctor.Text));
                    cmd.Parameters.AddWithValue("@iddept", cmb_id_depatment.SelectedValue);
                    cmd.Parameters.AddWithValue("@namedoc", txt_Name_doctor.Text);
                    cmd.Parameters.AddWithValue("@typedoc", cmb_Typedoctor.SelectedItem?.ToString());
                    int exp = 0;
                    int sal = 0;
                    int.TryParse(txt_yearexperience.Text, out exp);
                    int.TryParse(txt_salary.Text, out sal);

                    cmd.Parameters.AddWithValue("@yeardoc", exp);
                    cmd.Parameters.AddWithValue("@salarydoc", sal);
                    cmd.Parameters.AddWithValue("@datedoc", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    LoadDataDoctor();

                    MessageBox.Show("the doctor was successfully added", "success", MessageBoxButtons.OK);
                    txt_id_doctor.Clear();
                    txt_Name_doctor.Clear();
                    txt_salary.Clear();
                    txt_yearexperience.Clear();
                    cmb_id_depatment.SelectedIndex = -1;
                    cmb_Typedoctor.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Database Doctors " + ex.Message);
                }
            }


        }
        private void LoadDataDoctor()
        {
            using (SqlConnection connect = DataBaseHelper.GetConnection())
            {
                try
                {
                    string query = "select * from Doctors";
                    SqlDataAdapter readdata = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    readdata.Fill(dataTable);
                    grd_Doctos.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in Loading Doctors " + ex.Message);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_removedoctor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id_toremove.Text))
            {
                MessageBox.Show("you must enter the doctor's id", "warning");
                return;
            }

            DialogResult result = MessageBox.Show("are you sure the doctor deleted it ?", "confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = DataBaseHelper.GetConnection())
                {
                    try
                    {
                        string query = "delete from Doctors where Doc_ID=@id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", txt_id_toremove.Text);

                        conn.Open();
                        int rowaffected = cmd.ExecuteNonQuery();
                        if (rowaffected > 0)
                        {
                            MessageBox.Show("Deleted Was Successfully ");
                            LoadDataDoctor();
                            txt_id_toremove.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No Doctor Was Found", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                        }
                    }
                    catch (SqlException ex1)
                    {
                        MessageBox.Show("Cannot delete this doctor because they have patients assigned to them" + ex1.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot be Deleted", "Error DataBase Connection ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Manage_Doctors_Load(object sender, EventArgs e)
        {
            cmb_Typedoctor.DataSource = Enum.GetValues(typeof(Doctortype));

            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                try
                {
                    string query = "SELECT Dept_ID, Dept_Name FROM Departments";
                    SqlDataAdapter data = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    data.Fill(dt);

                    cmb_id_depatment.DataSource = dt;
                    cmb_id_depatment.DisplayMember = "Dept_Name";
                    cmb_id_depatment.ValueMember = "Dept_ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading departments: " + ex.Message);
                }
            }
            LoadDataDoctor();
        }

        private void grd_Doctos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if(tbc_AddandRemovedoctor.SelectedTab == tbc_RemovDoctor)
                {
                    txt_id_toremove.Text = grd_Doctos.Rows[e.RowIndex].Cells["Doc_ID"].Value.ToString();
                }
                grd_Doctos.DefaultCellStyle.SelectionBackColor = Color.Blue;
            }
        }
    }
}
