namespace CollegeAdmissionSystem.Screens
{
    partial class CoursePortal
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
            this.edtCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.edtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dateCombo = new MetroFramework.Controls.MetroDateTime();
            this.cboxAPS = new MaterialSkin.Controls.MaterialCheckBox();
            this.cboxSubject = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.edtAps = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(59, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(143, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Add Course/Subject";
            // 
            // edtCode
            // 
            this.edtCode.Depth = 0;
            this.edtCode.Hint = "Course/Subject Code";
            this.edtCode.Location = new System.Drawing.Point(63, 160);
            this.edtCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.edtCode.Name = "edtCode";
            this.edtCode.PasswordChar = '\0';
            this.edtCode.SelectedText = "";
            this.edtCode.SelectionLength = 0;
            this.edtCode.SelectionStart = 0;
            this.edtCode.Size = new System.Drawing.Size(441, 23);
            this.edtCode.TabIndex = 1;
            this.edtCode.UseSystemPasswordChar = false;
            // 
            // edtName
            // 
            this.edtName.Depth = 0;
            this.edtName.Hint = "Course/Subject Name";
            this.edtName.Location = new System.Drawing.Point(63, 212);
            this.edtName.MouseState = MaterialSkin.MouseState.HOVER;
            this.edtName.Name = "edtName";
            this.edtName.PasswordChar = '\0';
            this.edtName.SelectedText = "";
            this.edtName.SelectionLength = 0;
            this.edtName.SelectionStart = 0;
            this.edtName.Size = new System.Drawing.Size(441, 23);
            this.edtName.TabIndex = 1;
            this.edtName.UseSystemPasswordChar = false;
            // 
            // dateCombo
            // 
            this.dateCombo.Location = new System.Drawing.Point(180, 282);
            this.dateCombo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateCombo.Name = "dateCombo";
            this.dateCombo.Size = new System.Drawing.Size(324, 29);
            this.dateCombo.TabIndex = 2;
            // 
            // cboxAPS
            // 
            this.cboxAPS.AutoSize = true;
            this.cboxAPS.Depth = 0;
            this.cboxAPS.Font = new System.Drawing.Font("Roboto", 10F);
            this.cboxAPS.Location = new System.Drawing.Point(77, 356);
            this.cboxAPS.Margin = new System.Windows.Forms.Padding(0);
            this.cboxAPS.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxAPS.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxAPS.Name = "cboxAPS";
            this.cboxAPS.Ripple = true;
            this.cboxAPS.Size = new System.Drawing.Size(120, 30);
            this.cboxAPS.TabIndex = 3;
            this.cboxAPS.Text = "Add as Course";
            this.cboxAPS.UseVisualStyleBackColor = true;
            this.cboxAPS.CheckedChanged += new System.EventHandler(this.cboxAPS_CheckedChanged);
            // 
            // cboxSubject
            // 
            this.cboxSubject.AutoSize = true;
            this.cboxSubject.Depth = 0;
            this.cboxSubject.Font = new System.Drawing.Font("Roboto", 10F);
            this.cboxSubject.Location = new System.Drawing.Point(77, 397);
            this.cboxSubject.Margin = new System.Windows.Forms.Padding(0);
            this.cboxSubject.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cboxSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.cboxSubject.Name = "cboxSubject";
            this.cboxSubject.Ripple = true;
            this.cboxSubject.Size = new System.Drawing.Size(122, 30);
            this.cboxSubject.TabIndex = 3;
            this.cboxSubject.Text = "Add as Subject";
            this.cboxSubject.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(59, 288);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(118, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Date of Addition";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(127, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(338, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(200, 360);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(152, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "(As a college course)";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(202, 401);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(209, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "(As a School Leaving Subject)";
            // 
            // edtAps
            // 
            this.edtAps.Depth = 0;
            this.edtAps.Hint = "Enter Course APS";
            this.edtAps.Location = new System.Drawing.Point(401, 356);
            this.edtAps.MouseState = MaterialSkin.MouseState.HOVER;
            this.edtAps.Name = "edtAps";
            this.edtAps.PasswordChar = '\0';
            this.edtAps.SelectedText = "";
            this.edtAps.SelectionLength = 0;
            this.edtAps.SelectionStart = 0;
            this.edtAps.Size = new System.Drawing.Size(124, 23);
            this.edtAps.TabIndex = 1;
            this.edtAps.UseSystemPasswordChar = false;
            // 
            // CoursePortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(617, 505);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboxSubject);
            this.Controls.Add(this.cboxAPS);
            this.Controls.Add(this.dateCombo);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.edtAps);
            this.Controls.Add(this.edtCode);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "CoursePortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Portal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CoursePortal_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField edtCode;
        private MaterialSkin.Controls.MaterialSingleLineTextField edtName;
        private MetroFramework.Controls.MetroDateTime dateCombo;
        private MaterialSkin.Controls.MaterialCheckBox cboxAPS;
        private MaterialSkin.Controls.MaterialCheckBox cboxSubject;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button btnAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField edtAps;
    }
}