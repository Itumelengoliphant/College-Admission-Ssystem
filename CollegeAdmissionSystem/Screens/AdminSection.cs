using CollegeAdmissionSystem.Screens;
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

namespace CollegeAdmissionSystem
{
    public partial class AdminSection : MaterialSkin.Controls.MaterialForm
    {
        public AdminSection()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500, Primary.Pink500, Accent.LightBlue200, TextShade.WHITE);

            Essentials.HideControls(menuBox2);
        }

        private void imgLogout_Click(object sender, EventArgs e)
        {
            Essentials.DisplayForm(new DashBoard());
            this.Hide();
        }

        private void imgCoursePortal_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            Permissions permit = new Permissions();
            permit.ShowDialog();
            


        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Essentials.DisplayFormDialog(new AddCourseForm());
            
        }
    }
}
