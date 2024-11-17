namespace Term_Project
{
    partial class Login
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
            this.LoginGp = new System.Windows.Forms.GroupBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginGp.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGp
            // 
            this.LoginGp.BackColor = System.Drawing.Color.White;
            this.LoginGp.Controls.Add(this.LoginBtn);
            this.LoginGp.Controls.Add(this.PasswordTxb);
            this.LoginGp.Controls.Add(this.label2);
            this.LoginGp.Controls.Add(this.UsernameTxb);
            this.LoginGp.Controls.Add(this.label1);
            this.LoginGp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginGp.ForeColor = System.Drawing.Color.White;
            this.LoginGp.Location = new System.Drawing.Point(12, 12);
            this.LoginGp.Name = "LoginGp";
            this.LoginGp.Size = new System.Drawing.Size(240, 181);
            this.LoginGp.TabIndex = 0;
            this.LoginGp.TabStop = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.Black;
            this.LoginBtn.Location = new System.Drawing.Point(19, 124);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(201, 35);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordTxb
            // 
            this.PasswordTxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxb.Location = new System.Drawing.Point(19, 83);
            this.PasswordTxb.Name = "PasswordTxb";
            this.PasswordTxb.Size = new System.Drawing.Size(201, 21);
            this.PasswordTxb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password : ";
            // 
            // UsernameTxb
            // 
            this.UsernameTxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxb.Location = new System.Drawing.Point(19, 31);
            this.UsernameTxb.Name = "UsernameTxb";
            this.UsernameTxb.Size = new System.Drawing.Size(201, 21);
            this.UsernameTxb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username : ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(265, 204);
            this.Controls.Add(this.LoginGp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.ShowIcon = false;
            this.LoginGp.ResumeLayout(false);
            this.LoginGp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGp;
        private System.Windows.Forms.TextBox PasswordTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoginBtn;
    }
}

