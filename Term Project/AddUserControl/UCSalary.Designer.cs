namespace Term_Project.AddUserControl
{
    partial class UCSalary
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
            this.Salary = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SalaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.SalaEmployeeIdTxt = new System.Windows.Forms.TextBox();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.BasicSalaryTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentDateDtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(19, 15);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(61, 24);
            this.Salary.TabIndex = 1;
            this.Salary.Text = "Salary";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalaryId,
            this.dataGridViewTextBoxColumn2,
            this.employeeLastNameDataGridViewTextBoxColumn,
            this.BasicSalary,
            this.PaymentDate});
            this.dataGridView1.DataSource = this.salaryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1255, 462);
            this.dataGridView1.TabIndex = 2;
            // 
            // SalaryId
            // 
            this.SalaryId.DataPropertyName = "SalaryId";
            this.SalaryId.HeaderText = "SalaryId";
            this.SalaryId.Name = "SalaryId";
            this.SalaryId.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmployeeId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // BasicSalary
            // 
            this.BasicSalary.DataPropertyName = "BasicSalary";
            this.BasicSalary.HeaderText = "BasicSalary";
            this.BasicSalary.Name = "BasicSalary";
            this.BasicSalary.Width = 250;
            // 
            // PaymentDate
            // 
            this.PaymentDate.DataPropertyName = "PaymentDate";
            this.PaymentDate.HeaderText = "PaymentDate";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Width = 250;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.EmployeeID);
            this.panel1.Controls.Add(this.SalaEmployeeIdTxt);
            this.panel1.Controls.Add(this.Refreshbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.BasicSalaryTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PaymentDateDtp);
            this.panel1.Location = new System.Drawing.Point(20, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 201);
            this.panel1.TabIndex = 21;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.SaveBtn.Location = new System.Drawing.Point(163, 147);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(305, 37);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // EmployeeID
            // 
            this.EmployeeID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID.Location = new System.Drawing.Point(315, 30);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(97, 15);
            this.EmployeeID.TabIndex = 5;
            this.EmployeeID.Text = "EmployeeId";
            // 
            // SalaEmployeeIdTxt
            // 
            this.SalaEmployeeIdTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SalaEmployeeIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalaEmployeeIdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryBindingSource, "EmployeeId", true));
            this.SalaEmployeeIdTxt.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.SalaEmployeeIdTxt.Location = new System.Drawing.Point(474, 23);
            this.SalaEmployeeIdTxt.Name = "SalaEmployeeIdTxt";
            this.SalaEmployeeIdTxt.Size = new System.Drawing.Size(460, 22);
            this.SalaEmployeeIdTxt.TabIndex = 4;
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreshbtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.Refreshbtn.Location = new System.Drawing.Point(474, 147);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(305, 37);
            this.Refreshbtn.TabIndex = 17;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label2.Location = new System.Drawing.Point(315, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Basic Salary";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.DeleteBtn.Location = new System.Drawing.Point(785, 147);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(305, 37);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // BasicSalaryTxt
            // 
            this.BasicSalaryTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BasicSalaryTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BasicSalaryTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salaryBindingSource, "BasicSalary", true));
            this.BasicSalaryTxt.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.BasicSalaryTxt.Location = new System.Drawing.Point(474, 64);
            this.BasicSalaryTxt.Name = "BasicSalaryTxt";
            this.BasicSalaryTxt.Size = new System.Drawing.Size(460, 22);
            this.BasicSalaryTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label3.Location = new System.Drawing.Point(315, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Payment Date";
            // 
            // PaymentDateDtp
            // 
            this.PaymentDateDtp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PaymentDateDtp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salaryBindingSource, "PaymentDate", true));
            this.PaymentDateDtp.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.PaymentDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PaymentDateDtp.Location = new System.Drawing.Point(474, 105);
            this.PaymentDateDtp.Name = "PaymentDateDtp";
            this.PaymentDateDtp.Size = new System.Drawing.Size(460, 22);
            this.PaymentDateDtp.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Employee";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.AddEmployeeBtn.Location = new System.Drawing.Point(86, 18);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(88, 23);
            this.AddEmployeeBtn.TabIndex = 22;
            this.AddEmployeeBtn.Text = "Add";
            this.AddEmployeeBtn.UseVisualStyleBackColor = true;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Employee";
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // employeeLastNameDataGridViewTextBoxColumn
            // 
            this.employeeLastNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.employeeLastNameDataGridViewTextBoxColumn.Name = "employeeLastNameDataGridViewTextBoxColumn";
            this.employeeLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeLastNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataSource = typeof(Term_Project.Model.Salary);
            // 
            // UCSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Salary);
            this.Name = "UCSalary";
            this.Size = new System.Drawing.Size(1295, 753);
            this.Load += new System.EventHandler(this.UCSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.TextBox SalaEmployeeIdTxt;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox BasicSalaryTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker PaymentDateDtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
    }
}
