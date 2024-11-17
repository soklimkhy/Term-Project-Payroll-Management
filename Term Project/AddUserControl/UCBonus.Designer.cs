namespace Term_Project.AddUserControl
{
    partial class UCBonus
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
            this.AddBonusBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeIdTxt = new System.Windows.Forms.TextBox();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.BonusAmountTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BonusDateDtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bonusIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Location = new System.Drawing.Point(19, 15);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(64, 24);
            this.Dashboard.TabIndex = 1;
            this.Dashboard.Text = "Bonus";
            // 
            // AddBonusBtn
            // 
            this.AddBonusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBonusBtn.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.AddBonusBtn.Location = new System.Drawing.Point(86, 16);
            this.AddBonusBtn.Name = "AddBonusBtn";
            this.AddBonusBtn.Size = new System.Drawing.Size(88, 23);
            this.AddBonusBtn.TabIndex = 25;
            this.AddBonusBtn.Text = "Add";
            this.AddBonusBtn.UseVisualStyleBackColor = true;
            this.AddBonusBtn.Click += new System.EventHandler(this.AddBonusBtn_Click);
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.BonusAmountTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BonusDateDtp);
            this.panel1.Location = new System.Drawing.Point(20, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 201);
            this.panel1.TabIndex = 24;
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
            this.EmployeeIdTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bonusBindingSource, "EmployeeId", true));
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
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount";
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
            // BonusAmountTxt
            // 
            this.BonusAmountTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BonusAmountTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BonusAmountTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bonusBindingSource, "Amount", true));
            this.BonusAmountTxt.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.BonusAmountTxt.Location = new System.Drawing.Point(474, 64);
            this.BonusAmountTxt.Name = "BonusAmountTxt";
            this.BonusAmountTxt.Size = new System.Drawing.Size(460, 22);
            this.BonusAmountTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.label3.Location = new System.Drawing.Point(315, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bonus Date";
            // 
            // BonusDateDtp
            // 
            this.BonusDateDtp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BonusDateDtp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bonusBindingSource, "BonusDate", true));
            this.BonusDateDtp.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.BonusDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BonusDateDtp.Location = new System.Drawing.Point(474, 105);
            this.BonusDateDtp.Name = "BonusDateDtp";
            this.BonusDateDtp.Size = new System.Drawing.Size(460, 22);
            this.BonusDateDtp.TabIndex = 12;
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
            this.bonusIdDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.amountDataGridViewTextBoxColumn,
            this.bonusDateDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.updatedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bonusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1255, 462);
            this.dataGridView1.TabIndex = 23;
            // 
            // bonusBindingSource
            // 
            this.bonusBindingSource.DataSource = typeof(Term_Project.Model.Bonus);
            // 
            // bonusIdDataGridViewTextBoxColumn
            // 
            this.bonusIdDataGridViewTextBoxColumn.DataPropertyName = "BonusId";
            this.bonusIdDataGridViewTextBoxColumn.HeaderText = "BonusId";
            this.bonusIdDataGridViewTextBoxColumn.Name = "bonusIdDataGridViewTextBoxColumn";
            // 
            // employeeLastNameDataGridViewTextBoxColumn
            // 
            this.employeeLastNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.employeeLastNameDataGridViewTextBoxColumn.Name = "employeeLastNameDataGridViewTextBoxColumn";
            this.employeeLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeLastNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumn2.HeaderText = "EmployeeId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // bonusDateDataGridViewTextBoxColumn
            // 
            this.bonusDateDataGridViewTextBoxColumn.DataPropertyName = "BonusDate";
            this.bonusDateDataGridViewTextBoxColumn.HeaderText = "BonusDate";
            this.bonusDateDataGridViewTextBoxColumn.Name = "bonusDateDataGridViewTextBoxColumn";
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
            // UCBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddBonusBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Dashboard);
            this.Name = "UCBonus";
            this.Size = new System.Drawing.Size(1295, 753);
            this.Load += new System.EventHandler(this.UCBonus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.Button AddBonusBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmployeeIdTxt;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox BonusAmountTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker BonusDateDtp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bonusBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDataGridViewTextBoxColumn;
    }
}
