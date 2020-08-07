using DataAccessLibrary;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeAdmissionSystem.Screens
{
    public partial class ViewCoursesForm : MaterialSkin.Controls.MaterialForm
    {
        public ViewCoursesForm()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500,
            Primary.Pink500, Accent.Pink400, TextShade.WHITE);

            

        }

        private void ViewCoursesForm_Load(object sender, EventArgs e)
        {
            GetAllCourses();        
            Essentials.StyleDataGridView(ViewCourseDataGridView, "Tahoma", 18, FontStyle.Bold);

        }



        private void GetAllCourses()
        {
            string selectQuery =string.Format("SELECT name,code,credits,aps,faculty FROM Course");

            try
            {
                using (SqlConnection conn = new SqlConnection(Connectivity.ConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(selectQuery, conn))
                    {
                        command.CommandType = CommandType.Text;
                        DataTable dt = new DataTable();
                        conn.Open();
                        SqlDataReader sdr = command.ExecuteReader();
                        dt.Load(sdr);
                        conn.Close();
                        ViewCourseDataGridView.DataSource = dt;
                    }
                }

            }
            catch (Exception ex)
            {
                Essentials.SetErrorMessage(ex.Message, "Error");
            }
        }

        private void edtSearch_Leave(object sender, EventArgs e)
        {
            if (Essentials.IsInputEmptyOrNull((Essentials.RetrieveInputText(edtSearch)))){

                (ViewCourseDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (ViewCourseDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("name = '{0}'", edtSearch.Text);
            }
        }

        private void edtSearch_TextChanged(object sender, EventArgs e)
        {           

            if (Essentials.IsInputEmptyOrNull((Essentials.RetrieveInputText(edtSearch))))
            {

                (ViewCourseDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            }
            else
            {
                (ViewCourseDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", edtSearch.Text);
            }

        }

        private void ViewCoursesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }
    }
}
