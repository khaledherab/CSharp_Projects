using System.Text.RegularExpressions;
namespace project_programming_2
{
    public partial class ffrm_Main : Form
    {
        public ffrm_Main()
        {
            InitializeComponent();
        }

        private void btn_doctors_Click(object sender, EventArgs e)
        {
            Manage_Doctors frmdoctor = new Manage_Doctors();
            frmdoctor.Show();
        }

        private void btn_patients_Click(object sender, EventArgs e)
        {
            frm_Manage_patient frmpatient = new frm_Manage_patient();
            frmpatient.Show();
        }

        private void btn_treatments_Click(object sender, EventArgs e)
        {
            Treatment_Manage frmTreatment = new Treatment_Manage();
            frmTreatment.Show();
        }
    }
}
