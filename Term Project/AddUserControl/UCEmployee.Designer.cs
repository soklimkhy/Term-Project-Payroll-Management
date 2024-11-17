namespace Term_Project.AddUserControl
{
    partial class UCEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Employee = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstNametxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNametxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PositionCmb = new System.Windows.Forms.ComboBox();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.DateOfBirthDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateOfJoiningDtp = new System.Windows.Forms.DateTimePicker();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchTxb = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.GenSortCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PositionSortCmb = new System.Windows.Forms.ComboBox();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfJoiningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(17, 15);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(96, 24);
            this.Employee.TabIndex = 2;
            this.Employee.Text = "Employee";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.dateOfJoiningDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.updatedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 389);
            this.dataGridView1.TabIndex = 3;
            // 
            // FirstNametxb
            // 
            this.FirstNametxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FirstNametxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNametxb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FirstName", true));
            this.FirstNametxb.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.FirstNametxb.Location = new System.Drawing.Point(474, 20);
            this.FirstNametxb.Name = "FirstNametxb";
            this.FirstNametxb.Size = new System.Drawing.Size(460, 22);
            this.FirstNametxb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label2.Location = new System.Drawing.Point(315, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // LastNametxb
            // 
            this.LastNametxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LastNametxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNametxb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "LastName", true));
            this.LastNametxb.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.LastNametxb.Location = new System.Drawing.Point(474, 61);
            this.LastNametxb.Name = "LastNametxb";
            this.LastNametxb.Size = new System.Drawing.Size(460, 22);
            this.LastNametxb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label3.Location = new System.Drawing.Point(315, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Position";
            // 
            // PositionCmb
            // 
            this.PositionCmb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PositionCmb.BackColor = System.Drawing.Color.White;
            this.PositionCmb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Position", true));
            this.PositionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionCmb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PositionCmb.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.PositionCmb.FormattingEnabled = true;
            this.PositionCmb.Items.AddRange(new object[] {
            "UX/UI Designer",
            "Blockchain Developer",
            "AI Engineer",
            "Cybersecurity Analyst",
            "DevOps Engineer",
            "Cloud Engineer",
            "Data Scientist",
            "Machine Learning Engineer",
            "Mobile App Developer",
            "Fullstack Developer",
            "Software Developer",
            "IoT Engineer"});
            this.PositionCmb.Location = new System.Drawing.Point(474, 101);
            this.PositionCmb.Name = "PositionCmb";
            this.PositionCmb.Size = new System.Drawing.Size(460, 23);
            this.PositionCmb.TabIndex = 9;
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.AddEmployeeBtn.Location = new System.Drawing.Point(119, 16);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(88, 23);
            this.AddEmployeeBtn.TabIndex = 11;
            this.AddEmployeeBtn.Text = "Add";
            this.AddEmployeeBtn.UseVisualStyleBackColor = true;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // DateOfBirthDtp
            // 
            this.DateOfBirthDtp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateOfBirthDtp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "DateOfBirth", true));
            this.DateOfBirthDtp.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.DateOfBirthDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthDtp.Location = new System.Drawing.Point(474, 137);
            this.DateOfBirthDtp.Name = "DateOfBirthDtp";
            this.DateOfBirthDtp.Size = new System.Drawing.Size(460, 22);
            this.DateOfBirthDtp.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label4.Location = new System.Drawing.Point(315, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label5.Location = new System.Drawing.Point(315, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date of Joining";
            // 
            // DateOfJoiningDtp
            // 
            this.DateOfJoiningDtp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateOfJoiningDtp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeeBindingSource, "DateOfJoining", true));
            this.DateOfJoiningDtp.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.DateOfJoiningDtp.Location = new System.Drawing.Point(474, 179);
            this.DateOfJoiningDtp.Name = "DateOfJoiningDtp";
            this.DateOfJoiningDtp.Size = new System.Drawing.Size(460, 22);
            this.DateOfJoiningDtp.TabIndex = 15;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.DeleteBtn.Location = new System.Drawing.Point(785, 229);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(305, 37);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreshbtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.Refreshbtn.Location = new System.Drawing.Point(474, 229);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(305, 37);
            this.Refreshbtn.TabIndex = 17;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.SaveBtn.Location = new System.Drawing.Point(163, 229);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(305, 37);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FirstNametxb);
            this.panel1.Controls.Add(this.Refreshbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.LastNametxb);
            this.panel1.Controls.Add(this.DateOfJoiningDtp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PositionCmb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DateOfBirthDtp);
            this.panel1.Location = new System.Drawing.Point(20, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 277);
            this.panel1.TabIndex = 20;
            // 
            // SearchTxb
            // 
            this.SearchTxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTxb.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.SearchTxb.Location = new System.Drawing.Point(996, 16);
            this.SearchTxb.Name = "SearchTxb";
            this.SearchTxb.Size = new System.Drawing.Size(185, 22);
            this.SearchTxb.TabIndex = 21;
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.SearchBtn.Location = new System.Drawing.Point(1187, 16);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(88, 23);
            this.SearchBtn.TabIndex = 22;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // GenSortCmb
            // 
            this.GenSortCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenSortCmb.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.GenSortCmb.FormattingEnabled = true;
            this.GenSortCmb.Items.AddRange(new object[] {
            "Default",
            "No ( Ascending )",
            "No ( Descending )",
            "First Name ( A-Z )",
            "First Name ( Z-A )",
            "Last Name ( A-Z )",
            "Last Name ( Z-A )"});
            this.GenSortCmb.Location = new System.Drawing.Point(324, 16);
            this.GenSortCmb.Name = "GenSortCmb";
            this.GenSortCmb.Size = new System.Drawing.Size(192, 23);
            this.GenSortCmb.TabIndex = 24;
            this.GenSortCmb.SelectedIndexChanged += new System.EventHandler(this.GenSortCmb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sort";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(577, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Position";
            // 
            // PositionSortCmb
            // 
            this.PositionSortCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionSortCmb.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.PositionSortCmb.FormattingEnabled = true;
            this.PositionSortCmb.Items.AddRange(new object[] {
            "UX/UI Designer",
            "Blockchain Developer",
            "AI Engineer",
            "Cybersecurity Analyst",
            "DevOps Engineer",
            "Cloud Engineer",
            "Data Scientist",
            "Machine Learning Engineer",
            "Mobile App Developer",
            "Fullstack Developer",
            "Software Developer",
            "IoT Engineer"});
            this.PositionSortCmb.Location = new System.Drawing.Point(661, 16);
            this.PositionSortCmb.Name = "PositionSortCmb";
            this.PositionSortCmb.Size = new System.Drawing.Size(214, 23);
            this.PositionSortCmb.TabIndex = 26;
            this.PositionSortCmb.SelectedIndexChanged += new System.EventHandler(this.PositionSortCmb_SelectedIndexChanged);
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "No";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 170;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 210;
            // 
            // dateOfJoiningDataGridViewTextBoxColumn
            // 
            this.dateOfJoiningDataGridViewTextBoxColumn.DataPropertyName = "DateOfJoining";
            this.dateOfJoiningDataGridViewTextBoxColumn.HeaderText = "Date Of Joining";
            this.dateOfJoiningDataGridViewTextBoxColumn.Name = "dateOfJoiningDataGridViewTextBoxColumn";
            this.dateOfJoiningDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfJoiningDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDataGridViewTextBoxColumn.Width = 150;
            // 
            // updatedDataGridViewTextBoxColumn
            // 
            this.updatedDataGridViewTextBoxColumn.DataPropertyName = "Updated";
            this.updatedDataGridViewTextBoxColumn.HeaderText = "Updated";
            this.updatedDataGridViewTextBoxColumn.Name = "updatedDataGridViewTextBoxColumn";
            this.updatedDataGridViewTextBoxColumn.ReadOnly = true;
            this.updatedDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Term_Project.Employee);
            // 
            // UCEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PositionSortCmb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GenSortCmb);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTxb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Name = "UCEmployee";
            this.Size = new System.Drawing.Size(1295, 753);
            this.Load += new System.EventHandler(this.UCEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox FirstNametxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNametxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PositionCmb;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.DateTimePicker DateOfBirthDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateOfJoiningDtp;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfJoiningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox SearchTxb;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ComboBox GenSortCmb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PositionSortCmb;
    }
}
