namespace CollegeAdmissionSystem.Screens
{
    partial class ViewCoursesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ViewCourseDataGridView = new System.Windows.Forms.DataGridView();
            this.CourseDataGridView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCourseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter by:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Rockwell Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(140, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 25);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Faculty";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Rockwell Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(140, 118);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 25);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "APS Score";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CollegeAdmissionSystem.Properties.Resources.search_2_48;
            this.pictureBox1.Location = new System.Drawing.Point(546, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // edtSearch
            // 
            this.edtSearch.Depth = 0;
            this.edtSearch.Hint = "Search For Course";
            this.edtSearch.Location = new System.Drawing.Point(621, 128);
            this.edtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.edtSearch.Name = "edtSearch";
            this.edtSearch.PasswordChar = '\0';
            this.edtSearch.SelectedText = "";
            this.edtSearch.SelectionLength = 0;
            this.edtSearch.SelectionStart = 0;
            this.edtSearch.Size = new System.Drawing.Size(242, 23);
            this.edtSearch.TabIndex = 4;
            this.edtSearch.UseSystemPasswordChar = false;
            this.edtSearch.Leave += new System.EventHandler(this.edtSearch_Leave);
            this.edtSearch.TextChanged += new System.EventHandler(this.edtSearch_TextChanged);
            // 
            // ViewCourseDataGridView
            // 
            this.ViewCourseDataGridView.AllowUserToAddRows = false;
            this.ViewCourseDataGridView.AllowUserToDeleteRows = false;
            this.ViewCourseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewCourseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewCourseDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ViewCourseDataGridView.Location = new System.Drawing.Point(12, 186);
            this.ViewCourseDataGridView.Name = "ViewCourseDataGridView";
            this.ViewCourseDataGridView.ReadOnly = true;
            this.ViewCourseDataGridView.Size = new System.Drawing.Size(851, 267);
            this.ViewCourseDataGridView.TabIndex = 5;
            // 
            // CourseDataGridView
            // 
            this.CourseDataGridView.AutoSize = true;
            this.CourseDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseDataGridView.Location = new System.Drawing.Point(12, 500);
            this.CourseDataGridView.Name = "CourseDataGridView";
            this.CourseDataGridView.Size = new System.Drawing.Size(549, 20);
            this.CourseDataGridView.TabIndex = 6;
            this.CourseDataGridView.Text = "Can\'t find what you are looking for, Contact Leponesa: 0733873387";
            // 
            // ViewCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 537);
            this.Controls.Add(this.CourseDataGridView);
            this.Controls.Add(this.ViewCourseDataGridView);
            this.Controls.Add(this.edtSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "ViewCoursesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewCoursesForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewCoursesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCourseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField edtSearch;
        private System.Windows.Forms.DataGridView ViewCourseDataGridView;
        private System.Windows.Forms.Label CourseDataGridView;
    }
}