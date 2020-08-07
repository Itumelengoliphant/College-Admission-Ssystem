using DataAccessLibrary;
using MaterialSkin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace CollegeAdmissionSystem.Screens
{
    public partial class APSCorrespondingForm : MaterialSkin.Controls.MaterialForm
    {
        int apsScore = 0;
        public APSCorrespondingForm(int apsSsum)
        {
            InitializeComponent();

            this.apsScore = apsSsum;

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500,
            Primary.Pink500, Accent.Pink400, TextShade.WHITE);

            this.Text = "Course(s) corresponding to your APS/Course(s) you qualify for";
            lblAPS.Text = $"Your APS is {apsSsum}";

        }

        private void GetAllCourses()
        {
            string selectQuery = string.Format("SELECT name,code,credits,aps,faculty FROM Course WHERE aps<=@aps");

            try
            {
                using (SqlConnection conn = new SqlConnection(Connectivity.ConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(selectQuery, conn))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@aps", apsScore);
                        DataTable dt = new DataTable();
                        conn.Open();
                        SqlDataReader sdr = command.ExecuteReader();
                        dt.Load(sdr);
                        conn.Close();
                        UserAPSDataGridView.DataSource = dt;
                    }
                }

            }
            catch (Exception ex)
            {
                Essentials.SetErrorMessage(ex.Message, "Error");
            }
        }

        private void APSCorrespondingForm_Load(object sender, EventArgs e)
        {
            GetAllCourses();
            Essentials.StyleDataGridView(UserAPSDataGridView, "Tahoma", 18, FontStyle.Bold);
        }
    }
}
