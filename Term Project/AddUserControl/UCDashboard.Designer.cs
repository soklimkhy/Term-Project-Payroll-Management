namespace Term_Project.AddUserControl
{
    partial class UCDashboard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salaryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bonusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.payrollIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSalaryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.deductionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SalaSortCmb = new System.Windows.Forms.ComboBox();
            this.BonusSortCmb = new System.Windows.Forms.ComboBox();
            this.DeductionSortCmb = new System.Windows.Forms.ComboBox();
            this.PayrollSortCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deductionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Location = new System.Drawing.Point(19, 15);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(102, 24);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salaryIdDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn,
            this.basicSalaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salaryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 336);
            this.dataGridView1.TabIndex = 1;
            // 
            // salaryIdDataGridViewTextBoxColumn
            // 
            this.salaryIdDataGridViewTextBoxColumn.DataPropertyName = "SalaryId";
            this.salaryIdDataGridViewTextBoxColumn.HeaderText = "No";
            this.salaryIdDataGridViewTextBoxColumn.Name = "salaryIdDataGridViewTextBoxColumn";
            this.salaryIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // employeeLastNameDataGridViewTextBoxColumn
            // 
            this.employeeLastNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.employeeLastNameDataGridViewTextBoxColumn.Name = "employeeLastNameDataGridViewTextBoxColumn";
            this.employeeLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeLastNameDataGridViewTextBoxColumn.Width = 135;
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            this.basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.HeaderText = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataSource = typeof(Term_Project.Model.Salary);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bonusIdDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bonusBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(385, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(453, 336);
            this.dataGridView2.TabIndex = 2;
            // 
            // bonusIdDataGridViewTextBoxColumn
            // 
            this.bonusIdDataGridViewTextBoxColumn.DataPropertyName = "BonusId";
            this.bonusIdDataGridViewTextBoxColumn.HeaderText = "No";
            this.bonusIdDataGridViewTextBoxColumn.Name = "bonusIdDataGridViewTextBoxColumn";
            // 
            // employeeLastNameDataGridViewTextBoxColumn1
            // 
            this.employeeLastNameDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn1.HeaderText = "Employee Name";
            this.employeeLastNameDataGridViewTextBoxColumn1.Name = "employeeLastNameDataGridViewTextBoxColumn1";
            this.employeeLastNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.employeeLastNameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // bonusBindingSource
            // 
            this.bonusBindingSource.DataSource = typeof(Term_Project.Model.Bonus);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payrollIdDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn3,
            this.netSalaryDataGridViewTextBoxColumn,
            this.basicSalaryDataGridViewTextBoxColumn1,
            this.bonusAmountDataGridViewTextBoxColumn,
            this.deductionAmountDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.payrollBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(26, 439);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1242, 290);
            this.dataGridView3.TabIndex = 3;
            // 
            // payrollIdDataGridViewTextBoxColumn
            // 
            this.payrollIdDataGridViewTextBoxColumn.DataPropertyName = "PayrollId";
            this.payrollIdDataGridViewTextBoxColumn.HeaderText = "No";
            this.payrollIdDataGridViewTextBoxColumn.Name = "payrollIdDataGridViewTextBoxColumn";
            this.payrollIdDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeeLastNameDataGridViewTextBoxColumn3
            // 
            this.employeeLastNameDataGridViewTextBoxColumn3.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn3.HeaderText = "Employee Name";
            this.employeeLastNameDataGridViewTextBoxColumn3.Name = "employeeLastNameDataGridViewTextBoxColumn3";
            this.employeeLastNameDataGridViewTextBoxColumn3.ReadOnly = true;
            this.employeeLastNameDataGridViewTextBoxColumn3.Width = 250;
            // 
            // netSalaryDataGridViewTextBoxColumn
            // 
            this.netSalaryDataGridViewTextBoxColumn.DataPropertyName = "NetSalary";
            this.netSalaryDataGridViewTextBoxColumn.HeaderText = "Net Salary";
            this.netSalaryDataGridViewTextBoxColumn.Name = "netSalaryDataGridViewTextBoxColumn";
            this.netSalaryDataGridViewTextBoxColumn.Width = 200;
            // 
            // basicSalaryDataGridViewTextBoxColumn1
            // 
            this.basicSalaryDataGridViewTextBoxColumn1.DataPropertyName = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn1.HeaderText = "Basic Salary";
            this.basicSalaryDataGridViewTextBoxColumn1.Name = "basicSalaryDataGridViewTextBoxColumn1";
            this.basicSalaryDataGridViewTextBoxColumn1.ReadOnly = true;
            this.basicSalaryDataGridViewTextBoxColumn1.Width = 200;
            // 
            // bonusAmountDataGridViewTextBoxColumn
            // 
            this.bonusAmountDataGridViewTextBoxColumn.DataPropertyName = "BonusAmount";
            this.bonusAmountDataGridViewTextBoxColumn.HeaderText = "Bonus Amount";
            this.bonusAmountDataGridViewTextBoxColumn.Name = "bonusAmountDataGridViewTextBoxColumn";
            this.bonusAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.bonusAmountDataGridViewTextBoxColumn.Width = 200;
            // 
            // deductionAmountDataGridViewTextBoxColumn
            // 
            this.deductionAmountDataGridViewTextBoxColumn.DataPropertyName = "DeductionAmount";
            this.deductionAmountDataGridViewTextBoxColumn.HeaderText = "Deduction Amount";
            this.deductionAmountDataGridViewTextBoxColumn.Name = "deductionAmountDataGridViewTextBoxColumn";
            this.deductionAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.deductionAmountDataGridViewTextBoxColumn.Width = 220;
            // 
            // payrollBindingSource
            // 
            this.payrollBindingSource.DataSource = typeof(Term_Project.Payroll);
            // 
            // dataGridView4
            // 
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deductionIdDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn2,
            this.amountDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.deductionBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(856, 68);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(412, 336);
            this.dataGridView4.TabIndex = 4;
            // 
            // deductionIdDataGridViewTextBoxColumn
            // 
            this.deductionIdDataGridViewTextBoxColumn.DataPropertyName = "DeductionId";
            this.deductionIdDataGridViewTextBoxColumn.HeaderText = "No";
            this.deductionIdDataGridViewTextBoxColumn.Name = "deductionIdDataGridViewTextBoxColumn";
            this.deductionIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // employeeLastNameDataGridViewTextBoxColumn2
            // 
            this.employeeLastNameDataGridViewTextBoxColumn2.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn2.HeaderText = "Employee Name";
            this.employeeLastNameDataGridViewTextBoxColumn2.Name = "employeeLastNameDataGridViewTextBoxColumn2";
            this.employeeLastNameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.employeeLastNameDataGridViewTextBoxColumn2.Width = 180;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // deductionBindingSource
            // 
            this.deductionBindingSource.DataSource = typeof(Term_Project.Model.Deduction);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Earners";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(385, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bonus Earners";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(856, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deduction Earners";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(26, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Payrolls";
            // 
            // SalaSortCmb
            // 
            this.SalaSortCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SalaSortCmb.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaSortCmb.FormattingEnabled = true;
            this.SalaSortCmb.Items.AddRange(new object[] {
            "Default",
            "Highest",
            "Lowest"});
            this.SalaSortCmb.Location = new System.Drawing.Point(207, 48);
            this.SalaSortCmb.Name = "SalaSortCmb";
            this.SalaSortCmb.Size = new System.Drawing.Size(161, 20);
            this.SalaSortCmb.TabIndex = 25;
            // 
            // BonusSortCmb
            // 
            this.BonusSortCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BonusSortCmb.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonusSortCmb.FormattingEnabled = true;
            this.BonusSortCmb.Items.AddRange(new object[] {
            "Default",
            "Highest",
            "Lowest"});
            this.BonusSortCmb.Location = new System.Drawing.Point(677, 48);
            this.BonusSortCmb.Name = "BonusSortCmb";
            this.BonusSortCmb.Size = new System.Drawing.Size(161, 20);
            this.BonusSortCmb.TabIndex = 26;
            // 
            // DeductionSortCmb
            // 
            this.DeductionSortCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeductionSortCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeductionSortCmb.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeductionSortCmb.FormattingEnabled = true;
            this.DeductionSortCmb.Items.AddRange(new object[] {
            "Default",
            "Highest",
            "Lowest"});
            this.DeductionSortCmb.Location = new System.Drawing.Point(1107, 48);
            this.DeductionSortCmb.Name = "DeductionSortCmb";
            this.DeductionSortCmb.Size = new System.Drawing.Size(161, 20);
            this.DeductionSortCmb.TabIndex = 27;
            // 
            // PayrollSortCmb
            // 
            this.PayrollSortCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PayrollSortCmb.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayrollSortCmb.FormattingEnabled = true;
            this.PayrollSortCmb.Items.AddRange(new object[] {
            "Default",
            "Highest",
            "Lowest"});
            this.PayrollSortCmb.Location = new System.Drawing.Point(1107, 419);
            this.PayrollSortCmb.Name = "PayrollSortCmb";
            this.PayrollSortCmb.Size = new System.Drawing.Size(161, 20);
            this.PayrollSortCmb.TabIndex = 28;
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PayrollSortCmb);
            this.Controls.Add(this.DeductionSortCmb);
            this.Controls.Add(this.BonusSortCmb);
            this.Controls.Add(this.SalaSortCmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Dashboard);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(1295, 753);
            this.Load += new System.EventHandler(this.UCDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deductionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private System.Windows.Forms.BindingSource bonusBindingSource;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource deductionBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn payrollIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn netSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox SalaSortCmb;
        private System.Windows.Forms.ComboBox BonusSortCmb;
        private System.Windows.Forms.ComboBox DeductionSortCmb;
        private System.Windows.Forms.ComboBox PayrollSortCmb;
    }
}
