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
            this.comboBoxStdID = new System.Windows.Forms.ComboBox();
            this.labelStdID = new System.Windows.Forms.Label();
            this.labelCrsCode = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.valmsgStdID = new System.Windows.Forms.Label();
            this.valmsgCourseCode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCourseName
            // 
            this.comboBoxCourseName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCourseName.FormattingEnabled = true;
            this.comboBoxCourseName.Location = new System.Drawing.Point(111, 136);
            this.comboBoxCourseName.Name = "comboBoxCourseName";
            this.comboBoxCourseName.Size = new System.Drawing.Size(176, 21);
            this.comboBoxCourseName.TabIndex = 3;
            this.comboBoxCourseName.SelectedValueChanged += new System.EventHandler(this.comboBoxCourseName_SelectedValueChanged);
            // 
            // comboBoxStdID
            // 
            this.comboBoxStdID.BackColor = System.Drawing.Color.White;
            this.comboBoxStdID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStdID.FormattingEnabled = true;
            this.comboBoxStdID.Location = new System.Drawing.Point(109, 81);
            this.comboBoxStdID.Name = "comboBoxStdID";
            this.comboBoxStdID.Size = new System.Drawing.Size(176, 21);
            this.comboBoxStdID.TabIndex = 2;
            this.comboBoxStdID.SelectedValueChanged += new System.EventHandler(this.comboBoxStdID_SelectedValueChanged);
            // 
            // labelStdID
            // 
            this.labelStdID.AutoSize = true;
            this.labelStdID.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStdID.Location = new System.Drawing.Point(18, 83);
            this.labelStdID.Name = "labelStdID";
            this.labelStdID.Size = new System.Drawing.Size(69, 15);
            this.labelStdID.TabIndex = 2;
            this.labelStdID.Text = "Student ID";
            // 
            // labelCrsCode
            // 
            this.labelCrsCode.AutoSize = true;
            this.labelCrsCode.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrsCode.Location = new System.Drawing.Point(18, 140);
            this.labelCrsCode.Name = "labelCrsCode";
            this.labelCrsCode.Size = new System.Drawing.Size(86, 15);
            this.labelCrsCode.TabIndex = 3;
            this.labelCrsCode.Text = "Course Code";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonShow);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(313, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 261);
            this.panel1.TabIndex = 4;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.White;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShow.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.Color.Teal;
            this.buttonShow.Location = new System.Drawing.Point(24, 127);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(138, 36);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Teal;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(24, 72);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 36);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // valmsgStdID
            // 
            this.valmsgStdID.AutoSize = true;
            this.valmsgStdID.ForeColor = System.Drawing.Color.Red;
            this.valmsgStdID.Location = new System.Drawing.Point(143, 105);
            this.valmsgStdID.Name = "valmsgStdID";
            this.valmsgStdID.Size = new System.Drawing.Size(108, 13);
            this.valmsgStdID.TabIndex = 5;
            this.valmsgStdID.Text = "This Field is Required";
            // 
            // valmsgCourseCode
            // 
            this.valmsgCourseCode.AutoSize = true;
            this.valmsgCourseCode.ForeColor = System.Drawing.Color.Red;
            this.valmsgCourseCode.Location = new System.Drawing.Point(143, 160);
            this.valmsgCourseCode.Name = "valmsgCourseCode";
            this.valmsgCourseCode.Size = new System.Drawing.Size(108, 13);
            this.valmsgCourseCode.TabIndex = 6;
            this.valmsgCourseCode.Text = "This Field is Required";
            // 
            // AssignCourse
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(503, 261);
            this.Controls.Add(this.valmsgCourseCode);
            this.Controls.Add(this.valmsgStdID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCrsCode);
            this.Controls.Add(this.labelStdID);
            this.Controls.Add(this.comboBoxStdID);
            this.Controls.Add(this.comboBoxCourseName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AssignCourse";
            this.Text = "Assign Courses";
            this.Load += new System.EventHandler(this.AssignCourse_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.ComboBox comboBoxStudentID;
        private System.Windows.Forms.ComboBox comboBoxCourseName;
        private System.Windows.Forms.ComboBox comboBoxStdID;
        private System.Windows.Forms.Label labelStdID;
        private System.Windows.Forms.Label labelCrsCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label valmsgStdID;
        private System.Windows.Forms.Label valmsgCourseCode;
    }
}