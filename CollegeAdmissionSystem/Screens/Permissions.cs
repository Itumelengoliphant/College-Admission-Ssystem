using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLibrary;
using MaterialSkin;
using System.Data.SqlClient;

namespace CollegeAdmissionSystem.Screens
{
    public partial class Permissions : MaterialSkin.Controls.MaterialForm
    {
        public Permissions()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500,
            Primary.Pink500, Accent.Pink400, TextShade.WHITE);


            PopulateUserComboBox();
        }

        private void PopulateUserComboBox()
        {
            const string selectQuery = "Select name From ApplicationInfotbl";
        
            Essentials.PopulateComboBox(selectQuery, cboUsers, "ApplicationInfotbl", "name", "id");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            const string updateQuery = "Update ApplicationInfotbl SET role=@role,appStatus=@appStatus WHERE name=@name";

            try
            {
                using (SqlConnection conn = new SqlConnection(Connectivity.ConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(updateQuery, conn))
                    {
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@role", GetRole());
                        command.Parameters.AddWithValue("@appStatus", GetAdmissionStatus());
                        command.Parameters.AddWithValue("@name", cboUsers.Text);
                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();

                        Essentials.DisplayMessage("role changed successfully", "Roles");
                        Essentials.ResetControls(rdoAdmin, rdoNoAccess, rdoStudent);

                    }
                }

            }catch(Exception ex)
            {
                Essentials.SetErrorMessage(ex.Message, "Role Update Error");
            }
        }

        private string GetRole()
        {
            string role = "";

            if (rdoAdmin.Checked)
            {
                role = "admin";
            }
            else if (rdoStudent.Checked)
            {
                role = "student";
            }
            else if(rdoNoAccess.Checked)
            {
                role = "NONE";
            }
            return role;

        }

        private string GetAdmissionStatus()
        {
            string status = "";

            if (rdoAdmin.Checked)
            {
                status = "Accepted";
            }
            else if (rdoStudent.Checked)
            {
                status = "Accepted";
            }
            else if (rdoNoAccess.Checked)
            {
                status = "NOT Accepted";
            }
            return status;

        }


    }
}
