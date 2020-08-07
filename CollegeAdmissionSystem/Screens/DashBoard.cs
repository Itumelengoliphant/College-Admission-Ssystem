using CollegeAdmissionSystem.Screens;
using DataAccessLibrary;
using MaterialSkin;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CollegeAdmissionSystem
{
    public partial class DashBoard : MaterialSkin.Controls.MaterialForm
    {
        public DashBoard()
        {
          
            Thread thread = new Thread(new ThreadStart(LoadSplash));
            thread.Start();

            InitializeComponent();

            for (int i = 0; i <= 1000; i++)
            {
                Thread.Sleep(10);
            }
            thread.Abort();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500,
            Primary.Pink500, Accent.LightBlue200, TextShade.WHITE);

            Essentials.HideControls(menuPic2);
        }

        private void LoadSplash()
        {
            SplashScreen screen = new SplashScreen();
            Application.Run(screen);

        }

        private void menuPic_Click(object sender, EventArgs e)
        {

            bool menuDisplay = false;

            menuDisplay = !menuDisplay;

            if (menuDisplay)
            {
                Essentials.HideControls(menuPic,btnLogin, btnApply, btnAboutUs, btnAps, btnContact, btnViewCourse, btnRegister, btnStatus, btnExit);
                menuGroupBox.Size = new Size(42, 481);
                Essentials.ShowControls(menuPic2);

            }

        }

        private void menuPic2_Click(object sender, EventArgs e)
        {
            Essentials.ShowControls(menuPic, btnLogin, btnApply, btnAboutUs, btnAps, btnContact, btnViewCourse, btnRegister, btnStatus, btnExit);
            menuGroupBox.Size = new Size(198, 481);
            Essentials.HideControls(menuPic2);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Essentials.DisplayForm(new ApplicationsScreen());
            this.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Essentials.DisplayForm(new Login());
            this.Hide();
            
        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            Essentials.DisplayFormDialog(new ViewCoursesForm());
            
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            ViewAdmissionStatusForm vas = new ViewAdmissionStatusForm();
            vas.ShowDialog();
            
        }

        private void btnAps_Click(object sender, EventArgs e)
        {
            CalculateAPSForm ca = new Screens.CalculateAPSForm();
            ca.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Confirm Application Exit?", "College Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }


        }
    }
}
