namespace Winform_ShopGao
{
    partial class ChangePassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassForm));
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.txtB_ChangePass = new System.Windows.Forms.TextBox();
            this.lb_ChangePass = new System.Windows.Forms.Label();
            this.lb_rePass = new System.Windows.Forms.Label();
            this.txtB_rePass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChangePass.Image")));
            this.btn_ChangePass.Location = new System.Drawing.Point(82, 133);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(180, 50);
            this.btn_ChangePass.TabIndex = 0;
            this.btn_ChangePass.Text = "Thay đổi mật khẩu";
            this.btn_ChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChangePass.UseVisualStyleBackColor = true;
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // txtB_ChangePass
            // 
            this.txtB_ChangePass.Location = new System.Drawing.Point(143, 38);
            this.txtB_ChangePass.Name = "txtB_ChangePass";
            this.txtB_ChangePass.PasswordChar = '*';
            this.txtB_ChangePass.Size = new System.Drawing.Size(156, 20);
            this.txtB_ChangePass.TabIndex = 1;
            // 
            // lb_ChangePass
            // 
            this.lb_ChangePass.AutoSize = true;
            this.lb_ChangePass.Location = new System.Drawing.Point(45, 41);
            this.lb_ChangePass.Name = "lb_ChangePass";
            this.lb_ChangePass.Size = new System.Drawing.Size(74, 13);
            this.lb_ChangePass.TabIndex = 2;
            this.lb_ChangePass.Text = "Mật khẩu mới:";
            // 
            // lb_rePass
            // 
            this.lb_rePass.AutoSize = true;
            this.lb_rePass.Location = new System.Drawing.Point(23, 77);
            this.lb_rePass.Name = "lb_rePass";
            this.lb_rePass.Size = new System.Drawing.Size(96, 13);
            this.lb_rePass.TabIndex = 3;
            this.lb_rePass.Text = "Nhập lại mật khẩu:";
            // 
            // txtB_rePass
            // 
            this.txtB_rePass.Location = new System.Drawing.Point(143, 74);
            this.txtB_rePass.Name = "txtB_rePass";
            this.txtB_rePass.PasswordChar = '*';
            this.txtB_rePass.Size = new System.Drawing.Size(156, 20);
            this.txtB_rePass.TabIndex = 4;
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 218);
            this.Controls.Add(this.txtB_rePass);
            this.Controls.Add(this.lb_rePass);
            this.Controls.Add(this.lb_ChangePass);
            this.Controls.Add(this.txtB_ChangePass);
            this.Controls.Add(this.btn_ChangePass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChangePassForm";
            this.Text = "Thay đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangePass;
        private System.Windows.Forms.TextBox txtB_ChangePass;
        private System.Windows.Forms.Label lb_ChangePass;
        private System.Windows.Forms.Label lb_rePass;
        private System.Windows.Forms.TextBox txtB_rePass;
    }
}