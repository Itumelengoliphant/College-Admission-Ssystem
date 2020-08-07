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
    public partial class CoursePortal : MaterialSkin.Controls.MaterialForm, IInsertData
    {
    

        public CoursePortal()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500, Primary.Pink500,
            Accent.Pink400, TextShade.WHITE);

            Essentials.HideControls(edtAps);
        }

        private string name, code, type,date;
        private int aps;
        int courseAps;

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!Essentials.ContainsText(edtName, edtCode) && edtAps.Visible)
            {
                Essentials.SetErrorMessage($"Error field(s) cannot be empty!", "Empty field(s)");
            }
            else
            {

                string courseName = Essentials.RetrieveInputText(edtName);
                string courseCode = Essentials.RetrieveInputText(edtCode);
                string courseType = "";
                DialogResult dialog;
                string dateOfCourseAddition = dateCombo.Value.ToString("yyyy-MM-dd");
                this.name = courseName;
                this.code = courseCode;
                
                this.aps = courseAps;
                this.date = dateOfCourseAddition;

                if (cboxAPS.Checked)
                {
                    courseType = "Course";
                }
                else if (cboxSubject.Checked)
                {
                    courseType = "Subject";
                }
                this.type = courseType;


                if (edtAps.Visible && (!Essentials.IsInputEmptyOrNull(Essentials.RetrieveInputText(edtAps))))
                {
                    courseAps = Convert.ToInt16(Essentials.RetrieveInputText(edtAps));
                }
                else if(edtAps.Visible && Essentials.IsInputEmptyOrNull(Essentials.RetrieveInputText(edtAps)))
                {
                    Essentials.SetErrorMessage($"Please supply course APS!", "APS Required");
                }

                dialog = MessageBox.Show($"Confirm your data input:\nCourse Name {courseName} \nCourse Code {courseCode} \n" +
                $"Course Type {type} \nDate of Entry {dateOfCourseAddition}",
                "Data Entry Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {

                    if (edtAps.Visible && courseType== "Course")
                    {
                        string num = Essentials.RetrieveInputText(edtAps);

                        if (Convert.ToInt16(num) > 0)
                        {
                            InsertData();          
                        }
                        else
                        {
                            Essentials.SetErrorMessage("Error: APS cannot be 0 or less", "APS Error");
                            Essentials.ResetControls(edtAps);
                        }
                    }else if(courseType == "Subject")
                    {
                        InsertData();
                    }                  
                }
                else
                {
                }
            }
        }

        public void InsertData()
        {
            using (SqlConnection connection = new SqlConnection(Connectivity.ConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertCourse", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@courseName", name);
                    cmd.Parameters.AddWithValue("@courseCode", code);
                    cmd.Parameters.AddWithValue("@courseType", type);
                    cmd.Parameters.AddWithValue("@dateOfAddition", date);
                    cmd.Parameters.AddWithValue("@courseAps", aps);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    Essentials.DisplayMessage("Course/Subject Successfully Added", "Course Addition");
                    Essentials.ResetControls(edtName, edtCode, cboxAPS, cboxSubject,edtAps);
                    Essentials.HideControls(edtAps);
                }

            }
        }
        private void CoursePortal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Essentials.DisplayForm(new AdminSection());
            Essentials.DisposeForm(this);
        }

        private void cboxAPS_CheckedChanged(object sender, EventArgs e)
        {
            Essentials.ShowControls(edtAps);
            type = "Subject";
        }
    }
}
