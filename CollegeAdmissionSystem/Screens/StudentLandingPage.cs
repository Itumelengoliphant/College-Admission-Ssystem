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

namespace CollegeAdmissionSystem.Screens
{
    public partial class StudentLandingPage : MaterialSkin.Controls.MaterialForm
    {
        public StudentLandingPage()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500, Primary.Pink500, Accent.LightBlue200, TextShade.WHITE);
            string date = DateTime.Now.ToString();
            dateLabel.Text = date;

            

           

            
        



        }
    }
}
