using DataAccessLibrary;
using MaterialSkin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CollegeAdmissionSystem.Screens
{
    public partial class ViewAdmissionStatusForm : MaterialSkin.Controls.MaterialForm
    {
        public ViewAdmissionStatusForm()
        {
            InitializeComponent();

            MaterialSkinManager materialSkin = MaterialSkinManager.Instance;
            materialSkin.AddFormToManage(this);
            materialSkin.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkin.ColorScheme = new ColorScheme(Primary.Pink400, Primary.Pink500,
            Primary.Pink500, Accent.Pink100, TextShade.WHITE);

            this.Size = new Size(680, 245);
            Essentials.HideControls(statusGroupBox, btnReset);

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            if (Essentials.ContainsText(edtIdNum))
            {
                if (Essentials.GetAllInputText(edtIdNum).Length == 13)
                {

                    string id = Essentials.GetAllInputText(edtIdNum);
                    int log = 1;   

                    string selectQuery = string.Format("SELECT name,lastName,appStatus,studNum,identityNum From ApplicationInfotbl");

                    try
                    {
                        using (SqlConnection conn = new SqlConnection(Connectivity.ConnectionString()))
                        {
                            using (SqlCommand command = new SqlCommand(selectQuery, conn))
                            {
                                command.CommandType = CommandType.Text;
                                conn.Open();

                                SqlDataReader sdr = command.ExecuteReader();

                                if (sdr.HasRows)
                                {
                                    while (sdr.Read())
                                    {
                                        if (sdr["identityNum"].ToString().Equals(id))
                                        {
                                            this.Size = new Size(680, 472);
                                            Essentials.ShowControls(statusGroupBox, btnReset);

                                            lblStudNum.Text = sdr["studNum"].ToString();
                                            lblName.Text = sdr["name"].ToString();
                                            lblLastName.Text = sdr["lastName"].ToString();
                                            lblStatus.Text = sdr["appStatus"].ToString();

                                            log = 0;

                                        }

                                    }
                                    if (log != 0)
                                    {
                                        Essentials.SetErrorMessage($"No record found for: {id}", " Id record not found");
                                    }

                                }

                                conn.Close();
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Essentials.SetErrorMessage(ex.Message, "Id Error");
                    }
                }else
                {
                    Essentials.SetErrorMessage("Error: ID number provided is invalid", "Invalid ID");
                }
            }else
            {
                Essentials.SetErrorMessage("Error: ID number is required!", "Empty ID field");
            }
        }

        private void edtIdNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            Essentials.IsNumbersOnlyEnforced("Error: Only numbers required!", e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Size = new Size(680, 245);
            Essentials.HideControls(statusGroupBox, btnReset);
            Essentials.ResetControls(edtIdNum);
        }

        private void ViewAdmissionStatusForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Essentials.DisposeForm(this);
        }
    }
}
