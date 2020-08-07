namespace CollegeAdmissionSystem.Screens
{
    partial class APSCorrespondingForm
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
            this.UserAPSDataGridView = new System.Windows.Forms.DataGridView();
            this.lblAPS = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.UserAPSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserAPSDataGridView
            // 
            this.UserAPSDataGridView.AllowUserToAddRows = false;
            this.UserAPSDataGridView.AllowUserToDeleteRows = false;
            this.UserAPSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserAPSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserAPSDataGridView.Location = new System.Drawing.Point(12, 138);
            this.UserAPSDataGridView.Name = "UserAPSDataGridView";
            this.UserAPSDataGridView.ReadOnly = true;
            this.UserAPSDataGridView.Size = new System.Drawing.Size(745, 226);
            this.UserAPSDataGridView.TabIndex = 0;
            // 
            // lblAPS
            // 
            this.lblAPS.AutoSize = true;
            this.lblAPS.Depth = 0;
            this.lblAPS.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAPS.Location = new System.Drawing.Point(13, 91);
            this.lblAPS.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAPS.Name = "lblAPS";
            this.lblAPS.Size = new System.Drawing.Size(108, 19);
            this.lblAPS.TabIndex = 1;
            this.lblAPS.Text = "materialLabel1";
            // 
            // APSCorrespondingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(769, 376);
            this.Controls.Add(this.lblAPS);
            this.Controls.Add(this.UserAPSDataGridView);
            this.Name = "APSCorrespondingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APSCorrespondingForm";
            this.Load += new System.EventHandler(this.APSCorrespondingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserAPSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserAPSDataGridView;
        private MaterialSkin.Controls.MaterialLabel lblAPS;
    }
}