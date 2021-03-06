﻿namespace Digital_Attendance
{
    partial class AdminPage
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(329, 63);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.BackColor = System.Drawing.Color.Teal;
            this.btnShowStudents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowStudents.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStudents.ForeColor = System.Drawing.Color.White;
            this.btnShowStudents.Location = new System.Drawing.Point(0, 158);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(329, 63);
            this.btnShowStudents.TabIndex = 3;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = false;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Teal;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAssign.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(0, 97);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(329, 63);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Assign Course";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.BackColor = System.Drawing.Color.White;
            this.btnAdminProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminProfile.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminProfile.ForeColor = System.Drawing.Color.Teal;
            this.btnAdminProfile.Location = new System.Drawing.Point(0, 219);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(329, 63);
            this.btnAdminProfile.TabIndex = 4;
            this.btnAdminProfile.Text = "Admin Profile";
            this.btnAdminProfile.UseVisualStyleBackColor = false;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Teal;
            this.lblAdmin.Location = new System.Drawing.Point(3, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(118, 17);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Welcome Admin";
            this.lblAdmin.Visible = false;
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.White;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAttendance.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.Color.Teal;
            this.btnAttendance.Location = new System.Drawing.Point(0, 280);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(329, 63);
            this.btnAttendance.TabIndex = 5;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.White;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCourse.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.Color.Teal;
            this.btnAddCourse.Location = new System.Drawing.Point(0, 341);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(329, 63);
            this.btnAddCourse.TabIndex = 2;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 404);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnAdminProfile);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Attendance System [Home]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnAddCourse;
    }
}