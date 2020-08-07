using DataAccessLibrary;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace CollegeAdmissionSystem.Screens
{
    public partial class CalculateAPSForm : MaterialSkin.Controls.MaterialForm
    {
        public CalculateAPSForm()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500, 
            Primary.Pink500, Accent.Pink400, TextShade.WHITE);

            SetUpCboBoxes();

            Essentials.HideControls(btnViewCourseAPS, lblAps,edtAPS);
            //Essentials.ResizeForm(this, 914, 489);
            edtAPS.ReadOnly = true;

            Essentials.SetComboToFirstIndex(cboPercentage1, cboPercentage2, cboPercentage3, cboPercentage4,
            cboPercentage5, cboPercentage6, cboPercentage7,cboResults1, cboResults2, cboResults3, cboResults4,
            cboResults5, cboResults6, cboResults7);

        }


        private void SetUpCboBoxes()
        {
           
            /* populating the commented combo boxes in this fashion is a bit controversial
             * especially considering the fact we still have to make a determinination of
             * whether this subjects should be on the database/not
             *  */
            
            
            
            //const string selectQuery = "Select courseName From tblCourse WHERE courseType='subject'";

            //Essentials.PopulateComboBox(selectQuery, cboSubject4, "tblCourse", "courseName", "courseId");
            //Essentials.PopulateComboBox(selectQuery, cboSubject5, "tblCourse", "courseName", "courseId");
            //Essentials.PopulateComboBox(selectQuery, cboSubject6, "tblCourse", "courseName", "courseId");
            //Essentials.PopulateComboBox(selectQuery, cboSubject7, "tblCourse", "courseName", "courseId");

            cboSubject1.SelectedIndex = 1;
            cboSubject2.SelectedIndex = 0;
            cboSubject3.SelectedIndex = 1;
            cboSubject4.SelectedIndex = 1;
            cboSubject5.SelectedIndex = 1;
            cboSubject6.SelectedIndex = 1;
            cboSubject7.SelectedIndex = 1;
            
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

        private void CalculateAPSForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        int sum = 0;

        private void btnCalculate_Click(object sender, EventArgs e)
        {

             sum = ComputeApplicantAPS(cboPercentage1) + ComputeApplicantAPS(cboPercentage2) + ComputeApplicantAPS(cboPercentage3)
                      + ComputeApplicantAPS(cboPercentage4) + ComputeApplicantAPS(cboPercentage5) + ComputeApplicantAPS(cboPercentage6)
                      + ComputeApplicantAPS(cboPercentage7);

            Essentials.ShowControls(edtAPS, lblAps,btnViewCourseAPS);

            edtAPS.Text = string.Format($"{sum} points");

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Essentials.SetComboToFirstIndex(cboPercentage1, cboPercentage2, cboPercentage3, cboPercentage4,
            cboPercentage5, cboPercentage6, cboPercentage7, cboResults1, cboResults2, cboResults3, cboResults4,
            cboResults5, cboResults6, cboResults7);

            Essentials.HideControls(edtAPS, lblAps, btnViewCourseAPS);
        }

        private void btnViewCourseAPS_Click(object sender, EventArgs e)
        {
            APSCorrespondingForm apsForm = new APSCorrespondingForm(sum);
            apsForm.ShowDialog();
        }
    }
}
