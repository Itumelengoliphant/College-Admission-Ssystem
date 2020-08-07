using DataAccessLibrary;
using MaterialSkin;
using MetroFramework.Controls;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeAdmissionSystem
{
    public partial class ApplicationsScreen : MaterialSkin.Controls.MaterialForm
    {

        public ApplicationsScreen()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500,
            Primary.Pink500, Accent.Pink100, TextShade.WHITE);

            Essentials.SetComboToFirstIndex(cboExaminingBody, cboPercentage1, cboResults1, cboHighestGrade,
                                            cboPercentage2, cboPercentage3, cboPercentage4, cboPercentage5,
                                            cboPercentage6, cboPercentage7, cboResults2, cboResults3, cboResults4,
                                            cboResults5, cboResults6, cboResults7, cboGender, cboSubject1,
                                            cboSubject2, cboSubject3);

            SetUpCboBoxes();
        }

        public void SetUpCboBoxes()
        {
            //const string selectQuery = "Select courseName From tblCourse WHERE courseType='subject'";

            //Essentials.PopulateComboBox(selectQuery, cboSubject4, "tblCourse", "courseName", "courseId");
            //Essentials.PopulateComboBox(selectQuery, cboSubject5, "tblCourse", "courseName", "courseId");
            //Essentials.PopulateComboBox(selectQuery, cboSubject6, "tblCourse", "courseName", "courseId");
            //Essentials.PopulateComboBox(selectQuery, cboSubject7, "tblCourse", "courseName", "courseId");
        }

        private void metroComboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string name, lastName, applicationStatus = "Submitted",role = "NONE",
                   id, address, phoneNumber, gender, emailAddress,
                   highestGrade, nameOfSchool, schoolLeavingDate, password = "123", studentNumber;

            DateTime applicationDate;

            string subject1, subject2, subject3, subject4,
                   subject5, subject6, subject7;

            const int idNumberLength = 13;

            int year = DateTime.Today.Year;

            int apsSum = 0;


            if (!Essentials.ContainsText(edtName, edtLastName, edtMail, edtID, edtAddress, edtPhoneNumber, edtSchoolName))
            {
                Essentials.SetErrorMessage("Error: Input Field(s) cannot be empty,please fill in all fields", "Error: Empty Field(s)");

            }
            else
            {
                name = Essentials.RetrieveInputText(edtName);
                lastName = Essentials.RetrieveInputText(edtLastName);
                id = Essentials.RetrieveInputText(edtID);
                address = Essentials.RetrieveInputText(edtAddress);
                phoneNumber = Essentials.RetrieveInputText(edtPhoneNumber);
                emailAddress = Essentials.RetrieveInputText(edtMail);
                nameOfSchool = Essentials.RetrieveInputText(edtSchoolName);

                Student student;

                studentNumber = GenerateStudNum().Substring(0, 5).Insert(0, $"{year}");

                applicationDate = DateTime.Now;

                gender = cboGender.Text;
                highestGrade = cboHighestGrade.Text;

                schoolLeavingDate = cndarSchoolLeaving.Value.ToString();

                subject1 = cboSubject1.Text;
                subject2 = cboSubject2.Text;
                subject3 = cboSubject3.Text;
                subject4 = cboSubject4.Text;
                subject5 = cboSubject5.Text;
                subject6 = cboSubject6.Text;
                subject7 = cboSubject7.Text;

                apsSum = ComputeApplicantAPS(cboPercentage1) + ComputeApplicantAPS(cboPercentage2) + ComputeApplicantAPS(cboPercentage3)
                         + ComputeApplicantAPS(cboPercentage4) + ComputeApplicantAPS(cboPercentage5) + ComputeApplicantAPS(cboPercentage6)
                         + ComputeApplicantAPS(cboPercentage7);

                if (InspectComboValidity(cboSubject1, cboSubject3, cboSubject4,
                                         cboSubject5, cboSubject6, cboSubject7))
                {
                    if (Essentials.IsValidNamesInput(Essentials.RetrieveInputText(edtName)))
                    {
                        if (Essentials.IsValidMail(Essentials.RetrieveInputText(edtMail)))
                        {
                            if (edtID.Text.Length == idNumberLength)
                            {
                                using (SqlConnection connection = new SqlConnection(Connectivity.ConnectionString()))
                                {
                                    using (SqlCommand cmd = new SqlCommand("sp_Insert_ApplicantInfo", connection))
                                    {
                                        cmd.CommandType = CommandType.StoredProcedure;

                                        cmd.Parameters.AddWithValue("@name", name);
                                        cmd.Parameters.AddWithValue("@lastName", lastName);
                                        cmd.Parameters.AddWithValue("@identityNum", id);
                                        cmd.Parameters.AddWithValue("@address", address);
                                        cmd.Parameters.AddWithValue("@phone", phoneNumber);
                                        cmd.Parameters.AddWithValue("@email", emailAddress);
                                        cmd.Parameters.AddWithValue("@school", nameOfSchool);
                                        cmd.Parameters.AddWithValue("@applicationDate", applicationDate);
                                        cmd.Parameters.AddWithValue("@gender", gender);
                                        cmd.Parameters.AddWithValue("@highestGrade", highestGrade);

                                        cmd.Parameters.AddWithValue("@sub1", subject1);
                                        cmd.Parameters.AddWithValue("@sub2", subject2);
                                        cmd.Parameters.AddWithValue("@sub3", subject3);
                                        cmd.Parameters.AddWithValue("@sub4", subject4);
                                        cmd.Parameters.AddWithValue("@sub5", subject5);
                                        cmd.Parameters.AddWithValue("@sub6", subject6);
                                        cmd.Parameters.AddWithValue("@sub7", subject7);

                                        cmd.Parameters.AddWithValue("@appStatus", applicationStatus);
                                        cmd.Parameters.AddWithValue("@password", password);
                                        cmd.Parameters.AddWithValue("@studNum", studentNumber);
                                        cmd.Parameters.AddWithValue("@aps", apsSum);

                                        cmd.Parameters.AddWithValue("@role", role);

                                        connection.Open();
                                        cmd.ExecuteNonQuery();
                                        connection.Close();

                                        Essentials.DisplayMessage($"Application successfully submitted\nStudent Number {studentNumber}", $"Application");

                                        Essentials.ResetControls(edtName, edtLastName, edtMail, edtID, edtAddress, edtSchoolName,
                                        edtPhoneNumber, cboxGoodHealth, cboxPoorHealth, cboxYesDisabled, cboxNoDisabled);
                                    }
                                }
                            }
                            else
                            {
                                Essentials.SetErrorMessage($"Error: Invalid Identity number", $"Invalid ID");
                            }
                        }
                        else
                        {
                            Essentials.SetErrorMessage($"Error: Invalid Email address", $"EMail Invalid");
                        }
                    }
                    else
                    {
                        Essentials.SetErrorMessage($"Error: Name supplied is not valid", $"Invalid name");
                    }
                }
                else
                {
                    Essentials.SetErrorMessage($"Error: Please select all subjects", $"Subject(s) missing");
                }
            }
        }


        private bool InspectComboValidity(params MetroComboBox[] combos)
        {
            bool isValid = false;

            foreach (MetroComboBox c in combos)
            {
                if (c.SelectedIndex > 0)
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        private void materialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Please provide more info dialog here");
        }

        private void materialCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Please provide more info dialog here");
        }

        private string GenerateStudNum()
        {

            string randomsSelection = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            while (sb.Length < 18)
            {

                int index = (int)(random.NextDouble() * randomsSelection.Length);
                sb.Append(randomsSelection[index]);
            }

            string studNumber = sb.ToString();
            return studNumber;
        }

        private int ComputeApplicantAPS(MetroComboBox input)
        {
            int index = 0;

            if (input != null)
            {
                switch (input.SelectedIndex)
                {
                    case 0:
                        index = 0;
                        break;

                    case 1:
                        index = 1;
                        break;

                    case 2:
                        index = 2;
                        break;

                    case 3:
                        index = 3;
                        break;

                    case 4:
                        index = 4;
                        break;

                    case 5:
                        index = 5;
                        break;

                    case 6:
                        index = 6;
                        break;


                    case 7:
                        index = 7;
                        break;

                    case 8:
                        index = 8;
                        break;

                    default:
                        Essentials.SetErrorMessage("Error: System error", "System error");
                        break;
                }

            }
               
                return index;
            }

        private void ApplicationsScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DashBoard db = new DashBoard();
            SplashScreen sc = new SplashScreen();
            db.Show();
            sc.Hide();
            this.Hide();
        }

        //private void edtID_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if(e.KeyChar >='0' && e.KeyChar <= '9')
        //    {
        //        e.Handled = false;
        //    }else
        //    {
        //        e.Handled = true;
        //    }
        //}
    }


    }

