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
    public partial class AddCourseForm : MaterialSkin.Controls.MaterialForm,IInsertData
    {
        public AddCourseForm()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500,
            Primary.Pink500, Accent.Pink100, TextShade.WHITE);
        }

        private string name, code, description, date, getFaculty;
        private int aps,credits;
        int courseAps = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Essentials.ContainsText(edtCourseCode,edtCourseName,edtAPSPoint,edtCredits) || txtBoxDescribtion.Text == "")
            {
                Essentials.SetErrorMessage("Error Field(s) cannot be left empty", "Empty Field(s)");
            }
            else
            {
                if (Convert.ToInt32(Essentials.GetAllInputText(edtAPSPoint)) <= 0)
                {
                    Essentials.SetErrorMessage("APS Score cannot be 0 or less", "Admission Point Score Error");
                }
                else
                {
                    string courseName = Essentials.GetAllInputText(edtCourseName);
                    string courseCode = Essentials.GetAllInputText(edtCourseCode);
                    int courseAPS = Convert.ToInt32(Essentials.GetAllInputText(edtAPSPoint));
                    string description = Essentials.GetAllInputText(txtBoxDescribtion);
                    int credits = Convert.ToInt32(Essentials.GetAllInputText(edtCredits));

                    DialogResult dialog;

                    string faculty = cboFaculty.Text;
                    string dateOfCourseAddition = DateTime.Now.ToString("yyyy-MM-dd");

                    this.name = courseName;
                    this.code = courseCode;
                    this.courseAps = courseAPS;
                    this.date = dateOfCourseAddition;
                    this.credits = credits;
                    this.description = description;
                    this.getFaculty = faculty;


                    dialog = MessageBox.Show($"<<Confirm your data input:>>\n\nCourse Name:\t {courseName} \nCourse Code:\t {courseCode} \n" +
                    $"Course APS:\t {courseAPS} \nDate of Entry:\t {dateOfCourseAddition} \nDescribtion:\t {description}\nCredits:\t\t {credits}\n" +
                    $"Faculty:\t\t {faculty}",
                    "Data Entry Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {
                        InsertData();

                    }else { }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Essentials.ResetControls(edtAPSPoint, edtCourseCode, edtCourseName, txtBoxDescribtion,edtCredits);
        }

        private void edtAPSPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            Essentials.IsNumbersOnlyEnforced("Only Numbers required as input!",e);
        }

        private void edtCredits_KeyPress(object sender, KeyPressEventArgs e)
        {
            Essentials.IsNumbersOnlyEnforced("Only Numbers required as input!", e);
        }

        public void InsertData()
        {
            using (SqlConnection connection = new SqlConnection(Connectivity.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_AddCourse", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@courseName", name);
                    cmd.Parameters.AddWithValue("@courseCode", code);
                    cmd.Parameters.AddWithValue("@credits", credits);
                    cmd.Parameters.AddWithValue("@faculty", getFaculty);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@dateOfAddition", date);
                    cmd.Parameters.AddWithValue("@courseAps", courseAps);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    

                    Essentials.DisplayMessage("Course Successfully Added", "Course Addition");
                    Essentials.ResetControls(edtAPSPoint, edtCourseCode, edtCourseName, edtCredits, txtBoxDescribtion);

                    connection.Close();
                }

            }
        }
    }
}
