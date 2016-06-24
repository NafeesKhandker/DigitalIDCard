namespace Digital_Attendance
{
    partial class Add_Student
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gender = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.tbStudentId = new System.Windows.Forms.TextBox();
            this.valmsgLastName = new System.Windows.Forms.Label();
            this.valmsgFirstName = new System.Windows.Forms.Label();
            this.valmsgRFID = new System.Windows.Forms.Label();
            this.valmsgSID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRfid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Teal;
            this.btnAddStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddStudent.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(0, 478);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(468, 35);
            this.btnAddStudent.TabIndex = 9;
            this.btnAddStudent.Text = "Done";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbContact);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.tbStudentId);
            this.groupBox1.Controls.Add(this.valmsgLastName);
            this.groupBox1.Controls.Add(this.valmsgFirstName);
            this.groupBox1.Controls.Add(this.valmsgRFID);
            this.groupBox1.Controls.Add(this.valmsgSID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbRfid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 427);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.Gray;
            this.gender.Location = new System.Drawing.Point(48, 256);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(0, 15);
            this.gender.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(190, 269);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(183, 23);
            this.tbEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(48, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // tbContact
            // 
            this.tbContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContact.Location = new System.Drawing.Point(190, 330);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(183, 23);
            this.tbContact.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(48, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact No";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(190, 205);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(183, 23);
            this.tbLastName.TabIndex = 4;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.Gray;
            this.lastName.Location = new System.Drawing.Point(48, 208);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(69, 15);
            this.lastName.TabIndex = 0;
            this.lastName.Text = "Last Name";
            // 
            // tbStudentId
            // 
            this.tbStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStudentId.Location = new System.Drawing.Point(190, 35);
            this.tbStudentId.MaxLength = 6;
            this.tbStudentId.Name = "tbStudentId";
            this.tbStudentId.Size = new System.Drawing.Size(183, 23);
            this.tbStudentId.TabIndex = 1;
            this.tbStudentId.TextChanged += new System.EventHandler(this.tbStudentId_TextChanged);
            this.tbStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStudentId_KeyPress);
            // 
            // valmsgLastName
            // 
            this.valmsgLastName.AutoSize = true;
            this.valmsgLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valmsgLastName.ForeColor = System.Drawing.Color.Red;
            this.valmsgLastName.Location = new System.Drawing.Point(230, 231);
            this.valmsgLastName.Name = "valmsgLastName";
            this.valmsgLastName.Size = new System.Drawing.Size(98, 13);
            this.valmsgLastName.TabIndex = 0;
            this.valmsgLastName.Text = "This Field Required";
            this.valmsgLastName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valmsgFirstName
            // 
            this.valmsgFirstName.AutoSize = true;
            this.valmsgFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valmsgFirstName.ForeColor = System.Drawing.Color.Red;
            this.valmsgFirstName.Location = new System.Drawing.Point(230, 173);
            this.valmsgFirstName.Name = "valmsgFirstName";
            this.valmsgFirstName.Size = new System.Drawing.Size(98, 13);
            this.valmsgFirstName.TabIndex = 0;
            this.valmsgFirstName.Text = "This Field Required";
            this.valmsgFirstName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valmsgRFID
            // 
            this.valmsgRFID.AutoSize = true;
            this.valmsgRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valmsgRFID.ForeColor = System.Drawing.Color.Red;
            this.valmsgRFID.Location = new System.Drawing.Point(230, 121);
            this.valmsgRFID.Name = "valmsgRFID";
            this.valmsgRFID.Size = new System.Drawing.Size(98, 13);
            this.valmsgRFID.TabIndex = 0;
            this.valmsgRFID.Text = "This Field Required";
            this.valmsgRFID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valmsgSID
            // 
            this.valmsgSID.AutoSize = true;
            this.valmsgSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valmsgSID.ForeColor = System.Drawing.Color.Red;
            this.valmsgSID.Location = new System.Drawing.Point(230, 61);
            this.valmsgSID.Name = "valmsgSID";
            this.valmsgSID.Size = new System.Drawing.Size(98, 13);
            this.valmsgSID.TabIndex = 0;
            this.valmsgSID.Text = "This Field Required";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(48, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student ID";
            // 
            // tbRfid
            // 
            this.tbRfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRfid.Location = new System.Drawing.Point(190, 95);
            this.tbRfid.Name = "tbRfid";
            this.tbRfid.Size = new System.Drawing.Size(183, 23);
            this.tbRfid.TabIndex = 2;
            this.tbRfid.TextChanged += new System.EventHandler(this.tbRfid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(48, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "RFID";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(190, 147);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(183, 23);
            this.tbFirstName.TabIndex = 3;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.ForeColor = System.Drawing.Color.Gray;
            this.firstName.Location = new System.Drawing.Point(48, 150);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(71, 15);
            this.firstName.TabIndex = 0;
            this.firstName.Text = "First Name";
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(468, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "Add_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.Add_Student_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbStudentId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRfid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label valmsgLastName;
        private System.Windows.Forms.Label valmsgFirstName;
        private System.Windows.Forms.Label valmsgRFID;
        private System.Windows.Forms.Label valmsgSID;
    }
}

