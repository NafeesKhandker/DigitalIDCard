namespace Digital_Attendance
{
    partial class AssignCourse
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
            this.comboBoxCourseName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxCourseName
            // 
            this.comboBoxCourseName.FormattingEnabled = true;
            this.comboBoxCourseName.Location = new System.Drawing.Point(12, 43);
            this.comboBoxCourseName.Name = "comboBoxCourseName";
            this.comboBoxCourseName.Size = new System.Drawing.Size(289, 21);
            this.comboBoxCourseName.TabIndex = 0;
            // 
            // AssignCourse
            // 
            this.ClientSize = new System.Drawing.Size(503, 261);
            this.Controls.Add(this.comboBoxCourseName);
            this.Name = "AssignCourse";
            this.Load += new System.EventHandler(this.AssignCourse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.ComboBox comboBoxStudentID;
        private System.Windows.Forms.ComboBox comboBoxCourseName;
    }
}