namespace Term_Project.AddUserControl
{
    partial class UCDeduction
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
            this.AddDeductionBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeIdTxt = new System.Windows.Forms.TextBox();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.DeductionAmountTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeductionDateDtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ReasonTxt = new System.Windows.Forms.TextBox();
            this.deductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deductionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deductionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deductionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Location = new System.Drawing.Point(17, 15);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(96, 24);
            this.Dashboard.TabIndex = 1;
            this.Dashboard.Text = "Deduction";
            // 
            // AddDeductionBtn
            // 
            this.AddDeductionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDeductionBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.AddDeductionBtn.Location = new System.Drawing.Point(119, 15);
            this.AddDeductionBtn.Name = "AddDeductionBtn";
            this.AddDeductionBtn.Size = new System.Drawing.Size(88, 23);
            this.AddDeductionBtn.TabIndex = 12;
            this.AddDeductionBtn.Text = "Add";
            this.AddDeductionBtn.UseVisualStyleBackColor = true;
            this.AddDeductionBtn.Click += new System.EventHandler(this.AddDeductionBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ReasonTxt);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EmployeeIdTxt);
            this.panel1.Controls.Add(this.Refreshbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.DeductionAmountTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DeductionDateDtp);
            this.panel1.Location = new System.Drawing.Point(20, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 253);
            this.panel1.TabIndex = 26;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.SaveBtn.Location = new System.Drawing.Point(172, 196);
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
            this.EmployeeIdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deductionBindingSource, "EmployeeId", true));
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
            this.Refreshbtn.Location = new System.Drawing.Point(483, 196);
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
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.DeleteBtn.Location = new System.Drawing.Point(794, 196);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(305, 37);
            this.DeleteBtn.TabIndex = 16;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DeductionAmountTxt
            // 
            this.DeductionAmountTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeductionAmountTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeductionAmountTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deductionBindingSource, "Amount", true));
            this.DeductionAmountTxt.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.DeductionAmountTxt.Location = new System.Drawing.Point(474, 64);
            this.DeductionAmountTxt.Name = "DeductionAmountTxt";
            this.DeductionAmountTxt.Size = new System.Drawing.Size(460, 22);
            this.DeductionAmountTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label3.Location = new System.Drawing.Point(315, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deduction Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DeductionDateDtp
            // 
            this.DeductionDateDtp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeductionDateDtp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deductionBindingSource, "DeductionDate", true));
            this.DeductionDateDtp.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.DeductionDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DeductionDateDtp.Location = new System.Drawing.Point(474, 149);
            this.DeductionDateDtp.Name = "DeductionDateDtp";
            this.DeductionDateDtp.Size = new System.Drawing.Size(460, 22);
            this.DeductionDateDtp.TabIndex = 12;
            this.DeductionDateDtp.ValueChanged += new System.EventHandler(this.DeductionDateDtp_ValueChanged);
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
            this.deductionIdDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.deductionDateDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.updatedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deductionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1255, 415);
            this.dataGridView1.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label4.Location = new System.Drawing.Point(315, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Reason";
            // 
            // ReasonTxt
            // 
            this.ReasonTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReasonTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReasonTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deductionBindingSource, "Reason", true));
            this.ReasonTxt.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.ReasonTxt.Location = new System.Drawing.Point(474, 104);
            this.ReasonTxt.Name = "ReasonTxt";
            this.ReasonTxt.Size = new System.Drawing.Size(460, 22);
            this.ReasonTxt.TabIndex = 21;
            this.ReasonTxt.TextChanged += new System.EventHandler(this.ReasonTxt_TextChanged);
            // 
            // deductionBindingSource
            // 
            this.deductionBindingSource.DataSource = typeof(Term_Project.Model.Deduction);
            // 
            // deductionIdDataGridViewTextBoxColumn
            // 
            this.deductionIdDataGridViewTextBoxColumn.DataPropertyName = "DeductionId";
            this.deductionIdDataGridViewTextBoxColumn.HeaderText = "DeductionId";
            this.deductionIdDataGridViewTextBoxColumn.Name = "deductionIdDataGridViewTextBoxColumn";
            // 
            // employeeLastNameDataGridViewTextBoxColumn
            // 
            this.employeeLastNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.employeeLastNameDataGridViewTextBoxColumn.Name = "employeeLastNameDataGridViewTextBoxColumn";
            this.employeeLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeLastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.Width = 200;
            // 
            // deductionDateDataGridViewTextBoxColumn
            // 
            this.deductionDateDataGridViewTextBoxColumn.DataPropertyName = "DeductionDate";
            this.deductionDateDataGridViewTextBoxColumn.HeaderText = "DeductionDate";
            this.deductionDateDataGridViewTextBoxColumn.Name = "deductionDateDataGridViewTextBoxColumn";
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
            // UCDeduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddDeductionBtn);
            this.Controls.Add(this.Dashboard);
            this.Name = "UCDeduction";
            this.Size = new System.Drawing.Size(1295, 753);
            this.Load += new System.EventHandler(this.UCDeduction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deductionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.Button AddDeductionBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeIdTxt;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox DeductionAmountTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DeductionDateDtp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource deductionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deductionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReasonTxt;
    }
}
