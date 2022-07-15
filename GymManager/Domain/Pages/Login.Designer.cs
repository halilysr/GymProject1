
namespace GymManager.Domain.Pages
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWarn = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCustUsername = new System.Windows.Forms.TextBox();
            this.txtCustPassword = new System.Windows.Forms.TextBox();
            this.btnCustLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(24, 52);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(321, 23);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(24, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(321, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(24, 178);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(321, 41);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblWarn
            // 
            this.lblWarn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWarn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWarn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblWarn.Location = new System.Drawing.Point(40, 495);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(971, 60);
            this.lblWarn.TabIndex = 3;
            this.lblWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHome.Location = new System.Drawing.Point(423, 33);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(219, 45);
            this.lblHome.TabIndex = 4;
            this.lblHome.Text = "Gym Manager";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(40, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 279);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Login";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCustUsername);
            this.groupBox2.Controls.Add(this.txtCustPassword);
            this.groupBox2.Controls.Add(this.btnCustLogin);
            this.groupBox2.Location = new System.Drawing.Point(614, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 279);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Login";
            // 
            // txtCustUsername
            // 
            this.txtCustUsername.Location = new System.Drawing.Point(24, 52);
            this.txtCustUsername.Name = "txtCustUsername";
            this.txtCustUsername.Size = new System.Drawing.Size(321, 23);
            this.txtCustUsername.TabIndex = 0;
            // 
            // txtCustPassword
            // 
            this.txtCustPassword.Location = new System.Drawing.Point(24, 120);
            this.txtCustPassword.Name = "txtCustPassword";
            this.txtCustPassword.Size = new System.Drawing.Size(321, 23);
            this.txtCustPassword.TabIndex = 1;
            // 
            // btnCustLogin
            // 
            this.btnCustLogin.Location = new System.Drawing.Point(24, 178);
            this.btnCustLogin.Name = "btnCustLogin";
            this.btnCustLogin.Size = new System.Drawing.Size(321, 41);
            this.btnCustLogin.TabIndex = 2;
            this.btnCustLogin.Text = "Login";
            this.btnCustLogin.UseVisualStyleBackColor = true;
            this.btnCustLogin.Click += new System.EventHandler(this.btnCustLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 624);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblWarn);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCustUsername;
        private System.Windows.Forms.TextBox txtCustPassword;
        private System.Windows.Forms.Button btnCustLogin;
    }
}