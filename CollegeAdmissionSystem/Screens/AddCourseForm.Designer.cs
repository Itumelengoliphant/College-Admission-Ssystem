namespace CollegeAdmissionSystem.Screens
{
    partial class AddCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.edtCourseCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboFaculty = new MetroFramework.Controls.MetroComboBox();
            this.edtCourseName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxDescribtion = new System.Windows.Forms.RichTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.edtAPSPoint = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSave = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.edtCredits = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(58, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(182, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Institution Based Courses";
            // 
            // edtCourseCode
            // 
            this.edtCourseCode.Depth = 0;
            this.edtCourseCode.Hint = "Course Code";
            this.edtCourseCode.Location = new System.Drawing.Point(62, 160);
            this.edtCourseCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.edtCourseCode.Name = "edtCourseCode";
            this.edtCourseCode.PasswordChar = '\0';
            this.edtCourseCode.SelectedText = "";
            this.edtCourseCode.SelectionLength = 0;
            this.edtCourseCode.SelectionStart = 0;
            this.edtCourseCode.Size = new System.Drawing.Size(283, 23);
            this.edtCourseCode.TabIndex = 3;
            this.edtCourseCode.UseSystemPasswordChar = false;
            // 
            // cboFaculty
            // 
            this.cboFaculty.FormattingEnabled = true;
            this.cboFaculty.ItemHeight = 23;
            this.cboFaculty.Items.AddRange(new object[] {
            "Faculty of Education",
            "Faculty of Economic Management Science",
            "Faculty of Engineering",
            "Faculty of Humanities",
            "Faculty of Health",
            "Faculty of Arts"});
            this.cboFaculty.Location = new System.Drawing.Point(62, 310);
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Size = new System.Drawing.Size(283, 29);
            this.cboFaculty.TabIndex = 4;
            this.cboFaculty.UseSelectable = true;
            // 
            // edtCourseName
            // 
            this.edtCourseName.Depth = 0;
            this.edtCourseName.Hint = "Course Name";
            this.edtCourseName.Location = new System.Drawing.Point(62, 228);
            this.edtCourseName.MouseState = MaterialSkin.MouseState.HOVER;
            this.edtCourseName.Name = "edtCourseName";
            this.edtCourseName.PasswordChar = '\0';
            this.edtCourseName.SelectedText = "";
            this.edtCourseName.SelectionLength = 0;
            this.edtCourseName.SelectionStart = 0;
            this.edtCourseName.Size = new System.Drawing.Size(283, 23);
            this.edtCourseName.TabIndex = 3;
            this.edtCourseName.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(67, 288);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Faculty";
            // 
            // txtBoxDescribtion
            // 
            this.txtBoxDescribtion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescribtion.Location = new System.Drawing.Point(440, 133);
            this.txtBoxDescribtion.Name = "txtBoxDescribtion";
            this.txtBoxDescribtion.Size = new System.Drawing.Size(333, 136);
            this.txtBoxDescribtion.TabIndex = 5;
            this.txtBoxDescribtion.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(533, 97);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(86, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Description";
            // 
            // edtAPSPoint
            // 
            this.edtAPSPoint.Depth = 0;
            this.edtAPSPoint.Hint = "Course APS";
            this.edtAPSPoint.Location = new System.Drawing.Point(440, 316);
            this.edtAPSPoint.MouseState = MaterialSkin.MouseState.HOVER;
            this.edtAPSPoint.Name = "edtAPSPoint";
            this.edtAPSPoint.PasswordChar = '\0';
            this.edtAPSPoint.SelectedText = "";
            this.edtAPSPoint.SelectionLength = 0;
            this.edtAPSPoint.SelectionStart = 0;
            this.edtAPSPoint.Size = new System.Drawing.Size(333, 23);
            this.edtAPSPoint.TabIndex = 3;
            this.edtAPSPoint.UseSystemPasswordChar = false;
            this.edtAPSPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtAPSPoint_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Depth = 0;
            this.btnSave.Location = new System.Drawing.Point(440, 372);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Primary = true;
            this.btnSave.Size = new System.Drawing.Size(160, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(606, 372);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = true;
            this.btnClear.Size = new System.Drawing.Size(160, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // edtCredits
            // 
            this.edtCredits.Depth = 0;
            this.edtCredits.Hint = "(NQF) Credits";
            this.edtCredits.Location = new System.Drawing.Point(62, 372);
            this.edtCredits.MouseState = MaterialSkin.MouseState.HOVER;
            this.edtCredits.Name = "edtCredits";
            this.edtCredits.PasswordChar = '\0';
            this.edtCredits.SelectedText = "";
            this.edtCredits.SelectionLength = 0;
            this.edtCredits.SelectionStart = 0;
            this.edtCredits.Size = new System.Drawing.Size(283, 23);
            this.edtCredits.TabIndex = 3;
            this.edtCredits.UseSystemPasswordChar = false;
            this.edtCredits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtCredits_KeyPress);
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(803, 442);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxDescribtion);
            this.Controls.Add(this.cboFaculty);
            this.Controls.Add(this.edtCredits);
            this.Controls.Add(this.edtCourseName);
            this.Controls.Add(this.edtAPSPoint);
            this.Controls.Add(this.edtCourseCode);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField edtCourseCode;
        private MetroFramework.Controls.MetroComboBox cboFaculty;
        private MaterialSkin.Controls.MaterialSingleLineTextField edtCourseName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.RichTextBox txtBoxDescribtion;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField edtAPSPoint;
        private MaterialSkin.Controls.MaterialRaisedButton btnSave;
        private MaterialSkin.Controls.MaterialRaisedButton btnClear;
        private MaterialSkin.Controls.MaterialSingleLineTextField edtCredits;
    }
}