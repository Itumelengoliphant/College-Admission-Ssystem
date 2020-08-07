using CollegeAdmissionSystem.Screens;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeAdmissionSystem
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
       private SqlConnection conn = new SqlConnection(Connectivity.ConnectionString());

        public Login()
        {

            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500, Primary.Pink500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Essentials.ContainsTexts(edtUsername, edtPassword))
            {
                string sql = "Select name, password,role from ApplicationInfotbl";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;

                User user = new User();

                conn.Open();

                int log = 1;

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {

                        if (sdr.GetString(0).Equals(edtUsername.Text) && sdr.GetString(1).Equals(edtPassword.Text))
                        {

                            user = new User(sdr["name"].ToString(),sdr["password"].ToString(),sdr["role"].ToString());     
                            user.Role = sdr["role"].ToString();
                            log = 0;

                        }

                    }
                    if (log == 0)
                    {

                        switch (user.Role)
                        {
                            case "student":

                                Essentials.DisplayForm(new StudentLandingPage());
                                this.Hide();
       
                                break;

                            case "admin":

                                Essentials.DisplayForm(new AdminSection());
                                this.Hide();

                                break;

                            case "NONE":

                                MessageBox.Show("No access.....Ask for admin for a role");

                                break;


                            default:
                                MessageBox.Show("unrecognised user...");
                                break;
                        }
                       // Essentials.DisplayMessage($"Logged in Successfully as {edtUsername.Text} role is {user.Role}", "Login");
                    }
                    else
                    {
                        Essentials.SetErrorMessage($"Error: Wrong login credential(s)", "Login Error");
                    }
                }
                else
                {
                    Essentials.SetErrorMessage($"Error: Wrong login credential(s)", "Login Error");
                }

                sdr.Close();
                conn.Close();
            }

            else
            {
                Essentials.SetErrorMessage($"Error: All fields required!", "Empty Field(s)");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Essentials.DisposeForm(this);
        }
    }
}
