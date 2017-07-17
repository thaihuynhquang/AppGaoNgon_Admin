namespace Winform_ShopGao
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btt_SignIn = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.txtB_Username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.txtB_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btt_SignIn
            // 
            this.btt_SignIn.Image = ((System.Drawing.Image)(resources.GetObject("btt_SignIn.Image")));
            this.btt_SignIn.Location = new System.Drawing.Point(129, 150);
            this.btt_SignIn.Name = "btt_SignIn";
            this.btt_SignIn.Size = new System.Drawing.Size(130, 50);
            this.btt_SignIn.TabIndex = 0;
            this.btt_SignIn.Text = "Đăng Nhập";
            this.btt_SignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btt_SignIn.UseVisualStyleBackColor = true;
            this.btt_SignIn.Click += new System.EventHandler(this.btt_SignIn_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(48, 51);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(81, 13);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Tên đăng nhập";
            // 
            // txtB_Username
            // 
            this.txtB_Username.Location = new System.Drawing.Point(148, 48);
            this.txtB_Username.Name = "txtB_Username";
            this.txtB_Username.Size = new System.Drawing.Size(163, 20);
            this.txtB_Username.TabIndex = 2;
            this.txtB_Username.Text = "admin";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(77, 99);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(52, 13);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Mặt khẩu";
            // 
            // txtB_Password
            // 
            this.txtB_Password.Location = new System.Drawing.Point(148, 96);
            this.txtB_Password.Name = "txtB_Password";
            this.txtB_Password.PasswordChar = '*';
            this.txtB_Password.Size = new System.Drawing.Size(163, 20);
            this.txtB_Password.TabIndex = 4;
            this.txtB_Password.Text = "admin123";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 226);
            this.Controls.Add(this.txtB_Password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.txtB_Username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.btt_SignIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btt_SignIn;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox txtB_Username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox txtB_Password;
    }
}

