using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MetroFramework.Controls;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLibrary
{
    public class Essentials
    {


        public static bool ContainsTexts(params TextBox[] txtBox)
        {
            int errorCount = 0;

            try
            {
                foreach (TextBox box in txtBox)
                {
                    if (GetInputText(box).Length == 0)
                    {
                        ++errorCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return errorCount == 0;
        }

        public static bool ContainsText(params MaterialSingleLineTextField[] txtBox)
        {
            int errorCount = 0;

            try
            {
                foreach (MaterialSingleLineTextField box in txtBox)
                {
                    if (RetrieveInputText(box).Length == 0)
                    {
                        ++errorCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return errorCount == 0;
        }

        public static string SetErrorMessage(string errorMessage, string errorMessageHeader)
        {
            return MessageBox.Show(errorMessage, errorMessageHeader, MessageBoxButtons.OK, MessageBoxIcon.Error).ToString();
        }

        public static string DisplayMessage(string message, string messageHeader)
        {
            return MessageBox.Show(message, messageHeader, MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
        }

        public static string GetInputText(TextBox box)
        {
            return box.Text.Trim();
        }

        public static string GetAllInputText(Control c)
        {
            if(c is RichTextBox)
            {
                return (c as RichTextBox).Text.Trim();
            }
            else if (c is TextBox)
            {
                return (c as TextBox).Text.Trim();
            }
            else if(c is MaterialSingleLineTextField)
            {
                return (c as MaterialSingleLineTextField).Text.Trim();
            }

            return c.Text;
        }

        public static string RetrieveInputText(MaterialSingleLineTextField box)
        {
            return box.Text.Trim();
        }

        public static void DisplayForm(Form form)
        {
            if (form != null)
            {
                form.Show();
            }
        }

        public static void DisplayFormDialog(Form form)
        {
            if (form != null)
            {
                form.ShowDialog();
            }
        }

        public static void DisposeForm(Form form)
        {
            if (form != null)
            {
                form.Hide();
            }
        }

        public static void ResetControls(params Control[] cotrolls)

        {
            foreach (Control component in cotrolls)
            {
                if (component != null)
                {
                    if (component is MaterialSingleLineTextField)
                    {
                        (component as MaterialSingleLineTextField).Clear();

                    }
                    else if (component is TextBox)
                    {
                        (component as TextBox).Clear();
                    }
                    else if (component is MaterialRadioButton)
                    {
                        (component as MaterialRadioButton).Enabled = false;
                    }
                    else if (component is MaterialLabel)
                    {
                        (component as MaterialLabel).Text = "";
                    }
                    else if (component is MaterialCheckBox)
                    {
                        (component as MaterialCheckBox).Checked = false;
                    }
                    else if (component is RichTextBox)
                    {
                        (component as RichTextBox).Clear();
                    }
                }
            }
        }

        public static void HideControls(params Control[] controls)
        {
            if (controls != null)
            {
                foreach (Control c in controls)
                {
                    c.Visible = false;
                }
            }
        }

        public static void ShowControls(params Control[] controls)
        {
            if (controls != null)
            {
                foreach (Control c in controls)
                {
                    c.Visible = true;
                }
            }
        }

        public static void SetComboToFirstIndex(params MetroComboBox[] combo)
        {
            if (combo != null)
            {
                foreach (MetroComboBox cbo in combo)
                {
                    cbo.SelectedIndex = 0;
                }
            }
        }

        public static bool IsInputEmptyOrNull(string input)
        {
            return string.IsNullOrEmpty(input);
        }

        public static void ConfirmationDialog()
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Confirm operation", "Book System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        public static void StyleDataGridView(DataGridView grid, string family, float emSize, FontStyle style)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(family, emSize, style);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Pink;
            grid.EnableHeadersVisualStyles = false;
        }

        public static void PopulateComboBox(string query, MetroComboBox combo, string tblName, string memberName, string memberId)
        {
            string conn = Connectivity.ConnectionString();

            using (SqlConnection connection = new SqlConnection(conn))
            {
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    connection.Open();
                    DataSet ds = new DataSet();

                    sda.Fill(ds, tblName);
                    combo.DisplayMember = memberName;
                    combo.ValueMember = memberId;
                    combo.DataSource = ds.Tables[tblName];

                }
                catch (Exception ex)
                {
                    SetErrorMessage(ex.Message, "Error");
                }

            }


        }

        public static bool IsValidNamesInput(string input)
        {
           const string REGEX = "[A-Z][a-zA-Z]*";

            return Regex.IsMatch(input, REGEX);
        }

        public static bool IsValidMail(string emailString)
        {
            return Regex.IsMatch(emailString, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
            RegexOptions.IgnoreCase);
        }

        public static bool IsValidPassword(string password)
        {
            const int MIN_LENGTH = 8;
            const int MAX_LENGTH = 15;

            if (password == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }

            bool isValid = meetsLengthRequirements
                        && hasUpperCaseLetter
                        && hasLowerCaseLetter
                        && hasDecimalDigit
                        ;
            return isValid;

        }

        public static bool IsNumbersOnlyEnforced(string message, KeyPressEventArgs e)
        {

            bool isNumbersOnly = false;

            int code = Convert.ToInt32(e.KeyChar);
            if (code != 8)
            {
                if (code >= 48 && code <= 57)
                {
                    e.Handled = false;
                    isNumbersOnly = false;
                }
                else
                {
                    SetErrorMessage(message, "Error!");
                    e.Handled = true;
                    isNumbersOnly = true;
                }
            }

            return isNumbersOnly;

        }

        public static void ResizeForm(Form form,int width,int height)
        {
            if (form != null)
            {
                form.Size = new Size(width, height);
            }
        }

        
    }

}


