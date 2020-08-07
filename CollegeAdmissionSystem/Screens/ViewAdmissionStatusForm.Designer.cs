namespace CollegeAdmissionSystem.Screens
{
    partial class ViewAdmissionStatusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.edtIdNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCheck = new MaterialSkin.Controls.MaterialRaisedButton();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCampus = new System.Windows.Forms.Label();
            this.lblQualifications = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new MaterialSkin.Controls.MaterialRaisedButton();
            this.statusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Want to know your application status?";
            // 
            // edtIdNum
            // 
            this.edtIdNum.Depth = 0;
            this.edtIdNum.Hint = "Enter your ID/Passport no. below";
            this.edtIdNum.Location = new System.Drawing.Point(75, 169);
            this.edtIdNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.edtIdNum.Name = "edtIdNum";
            this.edtIdNum.PasswordChar = '\0';
            this.edtIdNum.SelectedText = "";
            this.edtIdNum.SelectionLength = 0;
            this.edtIdNum.SelectionStart = 0;
            this.edtIdNum.Size = new System.Drawing.Size(277, 23);
            this.edtIdNum.TabIndex = 2;
            this.edtIdNum.UseSystemPasswordChar = false;
            this.edtIdNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtIdNum_KeyPress);
            // 
            // btnCheck
            // 
            this.btnCheck.Depth = 0;
            this.btnCheck.Location = new System.Drawing.Point(392, 161);
            this.btnCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Primary = true;
            this.btnCheck.Size = new System.Drawing.Size(171, 31);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.label7);
            this.statusGroupBox.Controls.Add(this.label6);
            this.statusGroupBox.Controls.Add(this.label5);
            this.statusGroupBox.Controls.Add(this.label4);
            this.statusGroupBox.Controls.Add(this.label3);
            this.statusGroupBox.Controls.Add(this.lblLastName);
            this.statusGroupBox.Controls.Add(this.lblStatus);
            this.statusGroupBox.Controls.Add(this.lblCampus);
            this.statusGroupBox.Controls.Add(this.lblQualifications);
            this.statusGroupBox.Controls.Add(this.lblName);
            this.statusGroupBox.Controls.Add(this.lblStudNum);
            this.statusGroupBox.Controls.Add(this.label2);
            this.statusGroupBox.Location = new System.Drawing.Point(75, 214);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(488, 197);
            this.statusGroupBox.TabIndex = 4;
            this.statusGroupBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Admission Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Campus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Qualification:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(206, 78);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(122, 16);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Student Number:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(206, 170);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(122, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Student Number:";
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampus.Location = new System.Drawing.Point(206, 140);
            this.lblCampus.Name = "lblCampus";
            this.lblCampus.Size = new System.Drawing.Size(122, 16);
            this.lblCampus.TabIndex = 0;
            this.lblCampus.Text = "Student Number:";
            // 
            // lblQualifications
            // 
            this.lblQualifications.AutoSize = true;
            this.lblQualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualifications.Location = new System.Drawing.Point(206, 112);
            this.lblQualifications.Name = "lblQualifications";
            this.lblQualifications.Size = new System.Drawing.Size(122, 16);
            this.lblQualifications.TabIndex = 0;
            this.lblQualifications.Text = "Student Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(206, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Number:";
            // 
            // lblStudNum
            // 
            this.lblStudNum.AutoSize = true;
            this.lblStudNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudNum.Location = new System.Drawing.Point(206, 20);
            this.lblStudNum.Name = "lblStudNum";
            this.lblStudNum.Size = new System.Drawing.Size(122, 16);
            this.lblStudNum.TabIndex = 0;
            this.lblStudNum.Text = "Student Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Number:";
            // 
            // btnReset
            // 
            this.btnReset.Depth = 0;
            this.btnReset.Location = new System.Drawing.Point(392, 428);
            this.btnReset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReset.Name = "btnReset";
            this.btnReset.Primary = true;
            this.btnReset.Size = new System.Drawing.Size(171, 31);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ViewAdmissionStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(680, 472);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.edtIdNum);
            this.Controls.Add(this.label1);
            this.Name = "ViewAdmissionStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Admission Status";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAdmissionStatusForm_FormClosing);
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField edtIdNum;
        private MaterialSkin.Controls.MaterialRaisedButton btnCheck;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private MaterialSkin.Controls.MaterialRaisedButton btnReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCampus;
        private System.Windows.Forms.Label lblQualifications;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudNum;
    }
}