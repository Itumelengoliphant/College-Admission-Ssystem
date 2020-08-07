namespace CollegeAdmissionSystem
{
    partial class SplashScreen
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
            this.splashProgress = new MetroFramework.Controls.MetroProgressBar();
            this.CollegePicBox = new System.Windows.Forms.PictureBox();
            this.lblCollege = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CollegePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splashProgress
            // 
            this.splashProgress.Location = new System.Drawing.Point(52, 291);
            this.splashProgress.Name = "splashProgress";
            this.splashProgress.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.splashProgress.Size = new System.Drawing.Size(418, 23);
            this.splashProgress.TabIndex = 0;
            // 
            // CollegePicBox
            // 
            this.CollegePicBox.Image = global::CollegeAdmissionSystem.Properties.Resources.school_management_icon_300x300;
            this.CollegePicBox.Location = new System.Drawing.Point(106, 25);
            this.CollegePicBox.Name = "CollegePicBox";
            this.CollegePicBox.Size = new System.Drawing.Size(293, 218);
            this.CollegePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CollegePicBox.TabIndex = 1;
            this.CollegePicBox.TabStop = false;
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollege.Location = new System.Drawing.Point(139, 255);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(207, 23);
            this.lblCollege.TabIndex = 2;
            this.lblCollege.Text = "College Admission System";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 347);
            this.ControlBox = false;
            this.Controls.Add(this.lblCollege);
            this.Controls.Add(this.CollegePicBox);
            this.Controls.Add(this.splashProgress);
            this.Name = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.CollegePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar splashProgress;
        private System.Windows.Forms.PictureBox CollegePicBox;
        private System.Windows.Forms.Label lblCollege;
    }
}

