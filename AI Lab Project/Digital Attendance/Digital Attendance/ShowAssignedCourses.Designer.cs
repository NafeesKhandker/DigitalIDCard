namespace Digital_Attendance
{
    partial class ShowAssignedCourses
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
            this.dbGridAssignedCrs = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.cmbBoxStdID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridAssignedCrs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbGridAssignedCrs
            // 
            this.dbGridAssignedCrs.AllowUserToAddRows = false;
            this.dbGridAssignedCrs.BackgroundColor = System.Drawing.Color.Silver;
            this.dbGridAssignedCrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridAssignedCrs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dbGridAssignedCrs.Location = new System.Drawing.Point(-2, -1);
            this.dbGridAssignedCrs.Name = "dbGridAssignedCrs";
            this.dbGridAssignedCrs.Size = new System.Drawing.Size(485, 384);
            this.dbGridAssignedCrs.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Student ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Course Code";
            this.Column3.Name = "Column3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.cmbBoxStdID);
            this.panel1.Location = new System.Drawing.Point(481, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 384);
            this.panel1.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Teal;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(29, 164);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 36);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // cmbBoxStdID
            // 
            this.cmbBoxStdID.BackColor = System.Drawing.Color.White;
            this.cmbBoxStdID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBoxStdID.FormattingEnabled = true;
            this.cmbBoxStdID.Location = new System.Drawing.Point(29, 109);
            this.cmbBoxStdID.Name = "cmbBoxStdID";
            this.cmbBoxStdID.Size = new System.Drawing.Size(200, 21);
            this.cmbBoxStdID.TabIndex = 2;
            this.cmbBoxStdID.SelectedValueChanged += new System.EventHandler(this.cmbBoxStdID_SelectedValueChanged);
            // 
            // ShowAssignedCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dbGridAssignedCrs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ShowAssignedCourses";
            this.Text = "Assigned Courses";
            ((System.ComponentModel.ISupportInitialize)(this.dbGridAssignedCrs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGridAssignedCrs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbBoxStdID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}