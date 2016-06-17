namespace Digital_Attendance
{
    partial class Add_Course
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valmsgC_Type = new System.Windows.Forms.Label();
            this.combocourseType = new System.Windows.Forms.ComboBox();
            this.coursetype = new System.Windows.Forms.Label();
            this.isoptional = new System.Windows.Forms.CheckBox();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.valmsgC_Code = new System.Windows.Forms.Label();
            this.valmsgC_Name = new System.Windows.Forms.Label();
            this.course_name = new System.Windows.Forms.Label();
            this.tbCourseCode = new System.Windows.Forms.TextBox();
            this.coursecode = new System.Windows.Forms.Label();
            this.is_optional = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valmsgC_Type);
            this.groupBox1.Controls.Add(this.combocourseType);
            this.groupBox1.Controls.Add(this.coursetype);
            this.groupBox1.Controls.Add(this.isoptional);
            this.groupBox1.Controls.Add(this.tbCourseName);
            this.groupBox1.Controls.Add(this.valmsgC_Code);
            this.groupBox1.Controls.Add(this.valmsgC_Name);
            this.groupBox1.Controls.Add(this.course_name);
            this.groupBox1.Controls.Add(this.tbCourseCode);
            this.groupBox1.Controls.Add(this.coursecode);
            this.groupBox1.Controls.Add(this.is_optional);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 321);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Course";
            // 
            // valmsgC_Type
            // 
            this.valmsgC_Type.AutoSize = true;
            this.valmsgC_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valmsgC_Type.ForeColor = System.Drawing.Color.Red;
            this.valmsgC_Type.Location = new System.Drawing.Point(244, 174);
            this.valmsgC_Type.Name = "valmsgC_Type";
            this.valmsgC_Type.Size = new System.Drawing.Size(98, 13);
            this.valmsgC_Type.TabIndex = 6;
            this.valmsgC_Type.Text = "This Field Required";
            this.valmsgC_Type.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // combocourseType
            // 
            this.combocourseType.FormattingEnabled = true;
            this.combocourseType.Location = new System.Drawing.Point(204, 147);
            this.combocourseType.Name = "combocourseType";
            this.combocourseType.Size = new System.Drawing.Size(97, 24);
            this.combocourseType.TabIndex = 5;
            this.combocourseType.SelectedIndexChanged += new System.EventHandler(this.combocourseType_SelectedIndexChanged);
            // 
            // coursetype
            // 
            this.coursetype.AutoSize = true;
            this.coursetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursetype.Location = new System.Drawing.Point(48, 147);
            this.coursetype.Name = "coursetype";
            this.coursetype.Size = new System.Drawing.Size(89, 17);
            this.coursetype.TabIndex = 4;
            this.coursetype.Text = "Course Type";
            // 
            // isoptional
            // 
            this.isoptional.AutoSize = true;
            this.isoptional.Location = new System.Drawing.Point(204, 201);
            this.isoptional.Name = "isoptional";
            this.isoptional.Size = new System.Drawing.Size(15, 14);
            this.isoptional.TabIndex = 3;
            this.isoptional.UseVisualStyleBackColor = true;
            this.isoptional.CheckedChanged += new System.EventHandler(this.isoptional_CheckedChanged);
            // 
            // tbCourseName
            // 
            this.tbCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCourseName.Location = new System.Drawing.Point(204, 30);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(183, 23);
            this.tbCourseName.TabIndex = 1;
            // 
            // valmsgC_Code
            // 
            this.valmsgC_Code.AutoSize = true;
            this.valmsgC_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valmsgC_Code.ForeColor = System.Drawing.Color.Red;
            this.valmsgC_Code.Location = new System.Drawing.Point(244, 116);
            this.valmsgC_Code.Name = "valmsgC_Code";
            this.valmsgC_Code.Size = new System.Drawing.Size(98, 13);
            this.valmsgC_Code.TabIndex = 0;
            this.valmsgC_Code.Text = "This Field Required";
            this.valmsgC_Code.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // valmsgC_Name
            // 
            this.valmsgC_Name.AutoSize = true;
            this.valmsgC_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valmsgC_Name.ForeColor = System.Drawing.Color.Red;
            this.valmsgC_Name.Location = new System.Drawing.Point(244, 56);
            this.valmsgC_Name.Name = "valmsgC_Name";
            this.valmsgC_Name.Size = new System.Drawing.Size(98, 13);
            this.valmsgC_Name.TabIndex = 0;
            this.valmsgC_Name.Text = "This Field Required";
            // 
            // course_name
            // 
            this.course_name.AutoSize = true;
            this.course_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_name.Location = new System.Drawing.Point(48, 33);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(94, 17);
            this.course_name.TabIndex = 0;
            this.course_name.Text = "Course Name";
            // 
            // tbCourseCode
            // 
            this.tbCourseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCourseCode.Location = new System.Drawing.Point(204, 90);
            this.tbCourseCode.MaxLength = 4;
            this.tbCourseCode.Name = "tbCourseCode";
            this.tbCourseCode.Size = new System.Drawing.Size(183, 23);
            this.tbCourseCode.TabIndex = 2;
            // 
            // coursecode
            // 
            this.coursecode.AutoSize = true;
            this.coursecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursecode.Location = new System.Drawing.Point(48, 93);
            this.coursecode.Name = "coursecode";
            this.coursecode.Size = new System.Drawing.Size(90, 17);
            this.coursecode.TabIndex = 0;
            this.coursecode.Text = "Course Code";
            // 
            // is_optional
            // 
            this.is_optional.AutoSize = true;
            this.is_optional.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.is_optional.Location = new System.Drawing.Point(48, 201);
            this.is_optional.Name = "is_optional";
            this.is_optional.Size = new System.Drawing.Size(75, 17);
            this.is_optional.TabIndex = 0;
            this.is_optional.Text = "Is Optional";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddCourse.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(0, 339);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(468, 42);
            this.btnAddCourse.TabIndex = 10;
            this.btnAddCourse.Text = "Done";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 381);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_Course";
            this.Text = "Add Course";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Label valmsgC_Code;
        private System.Windows.Forms.Label valmsgC_Name;
        private System.Windows.Forms.Label course_name;
        private System.Windows.Forms.TextBox tbCourseCode;
        private System.Windows.Forms.Label coursecode;
        private System.Windows.Forms.Label is_optional;
        private System.Windows.Forms.CheckBox isoptional;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ComboBox combocourseType;
        private System.Windows.Forms.Label coursetype;
        private System.Windows.Forms.Label valmsgC_Type;
    }
}