namespace Term_Project.AddUserControl
{
    partial class UCPayroll
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
            this.Dashboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeIdTxt = new System.Windows.Forms.TextBox();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PaymentDateDtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddPayrollBtn = new System.Windows.Forms.Button();
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Location = new System.Drawing.Point(19, 15);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(66, 24);
            this.Dashboard.TabIndex = 1;
            this.Dashboard.Text = "Payroll";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EmployeeIdTxt);
            this.panel1.Controls.Add(this.Refreshbtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PaymentDateDtp);
            this.panel1.Location = new System.Drawing.Point(20, 569);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 167);
            this.panel1.TabIndex = 29;
        
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.SaveBtn.Location = new System.Drawing.Point(172, 113);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(305, 37);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "EmployeeId";
            // 
            // EmployeeIdTxt
            // 
            this.EmployeeIdTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmployeeIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeIdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollBindingSource, "EmployeeId", true));
            this.EmployeeIdTxt.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.EmployeeIdTxt.Location = new System.Drawing.Point(474, 23);
            this.EmployeeIdTxt.Name = "EmployeeIdTxt";
            this.EmployeeIdTxt.Size = new System.Drawing.Size(460, 22);
            this.EmployeeIdTxt.TabIndex = 4;
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refreshbtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.Refreshbtn.Location = new System.Drawing.Point(483, 113);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(305, 37);
            this.Refreshbtn.TabIndex = 17;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.DeleteBtn.Location = new System.Drawing.Point(794, 113);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(305, 37);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label3.Location = new System.Drawing.Point(315, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Payment Date";
            // 
            // PaymentDateDtp
            // 
            this.PaymentDateDtp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PaymentDateDtp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payrollBindingSource, "PaymentDate", true));
            this.PaymentDateDtp.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.PaymentDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PaymentDateDtp.Location = new System.Drawing.Point(474, 66);
            this.PaymentDateDtp.Name = "PaymentDateDtp";
            this.PaymentDateDtp.Size = new System.Drawing.Size(460, 22);
            this.PaymentDateDtp.TabIndex = 12;
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
            this.payrollIdDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn,
            this.netSalaryDataGridViewTextBoxColumn,
            this.basicSalaryDataGridViewTextBoxColumn,
            this.bonusAmountDataGridViewTextBoxColumn,
            this.deductionAmountDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.updatedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.payrollBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1255, 497);
            this.dataGridView1.TabIndex = 28;
            // 
            // AddPayrollBtn
            // 
            this.AddPayrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPayrollBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.AddPayrollBtn.Location = new System.Drawing.Point(105, 15);
            this.AddPayrollBtn.Name = "AddPayrollBtn";
            this.AddPayrollBtn.Size = new System.Drawing.Size(88, 23);
            this.AddPayrollBtn.TabIndex = 27;
            this.AddPayrollBtn.Text = "Add";
            this.AddPayrollBtn.UseVisualStyleBackColor = true;
            this.AddPayrollBtn.Click += new System.EventHandler(this.AddPayrollBtn_Click);
            // 
            // payrollBindingSource
            // 
            this.payrollBindingSource.DataSource = typeof(Term_Project.Payroll);
            // 
            // payrollIdDataGridViewTextBoxColumn
            // 
            this.payrollIdDataGridViewTextBoxColumn.DataPropertyName = "PayrollId";
            this.payrollIdDataGridViewTextBoxColumn.HeaderText = "PayrollId";
            this.payrollIdDataGridViewTextBoxColumn.Name = "payrollIdDataGridViewTextBoxColumn";
            // 
            // employeeLastNameDataGridViewTextBoxColumn
            // 
            this.employeeLastNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.employeeLastNameDataGridViewTextBoxColumn.Name = "employeeLastNameDataGridViewTextBoxColumn";
            this.employeeLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeLastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // netSalaryDataGridViewTextBoxColumn
            // 
            this.netSalaryDataGridViewTextBoxColumn.DataPropertyName = "NetSalary";
            this.netSalaryDataGridViewTextBoxColumn.HeaderText = "NetSalary";
            this.netSalaryDataGridViewTextBoxColumn.Name = "netSalaryDataGridViewTextBoxColumn";
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            this.basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.HeaderText = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            this.basicSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bonusAmountDataGridViewTextBoxColumn
            // 
            this.bonusAmountDataGridViewTextBoxColumn.DataPropertyName = "BonusAmount";
            this.bonusAmountDataGridViewTextBoxColumn.HeaderText = "BonusAmount";
            this.bonusAmountDataGridViewTextBoxColumn.Name = "bonusAmountDataGridViewTextBoxColumn";
            this.bonusAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deductionAmountDataGridViewTextBoxColumn
            // 
            this.deductionAmountDataGridViewTextBoxColumn.DataPropertyName = "DeductionAmount";
            this.deductionAmountDataGridViewTextBoxColumn.HeaderText = "DeductionAmount";
            this.deductionAmountDataGridViewTextBoxColumn.Name = "deductionAmountDataGridViewTextBoxColumn";
            this.deductionAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            // 
            // updatedDataGridViewTextBoxColumn
            // 
            this.updatedDataGridViewTextBoxColumn.DataPropertyName = "Updated";
            this.updatedDataGridViewTextBoxColumn.HeaderText = "Updated";
            this.updatedDataGridViewTextBoxColumn.Name = "updatedDataGridViewTextBoxColumn";
            // 
            // UCPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddPayrollBtn);
            this.Controls.Add(this.Dashboard);
            this.Name = "UCPayroll";
            this.Size = new System.Drawing.Size(1295, 753);
            this.Load += new System.EventHandler(this.UCPayroll_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeIdTxt;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker PaymentDateDtp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private System.Windows.Forms.Button AddPayrollBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payrollIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDataGridViewTextBoxColumn;
    }
}
