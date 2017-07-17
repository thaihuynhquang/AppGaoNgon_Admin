namespace Winform_ShopGao
{
    partial class NewSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSupplierForm));
            this.btn_themNCC = new System.Windows.Forms.Button();
            this.txtB_TenNCC = new System.Windows.Forms.TextBox();
            this.txtB_emailNCC = new System.Windows.Forms.TextBox();
            this.txtB_DiaChiNCC = new System.Windows.Forms.TextBox();
            this.txtB_SđtNCC = new System.Windows.Forms.TextBox();
            this.btn_exitNCC = new System.Windows.Forms.Button();
            this.lb_TenNCC = new System.Windows.Forms.Label();
            this.lb_DiaChiNCC = new System.Windows.Forms.Label();
            this.lb_EmailNCC = new System.Windows.Forms.Label();
            this.lb_SdtNCC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_themNCC
            // 
            this.btn_themNCC.Image = ((System.Drawing.Image)(resources.GetObject("btn_themNCC.Image")));
            this.btn_themNCC.Location = new System.Drawing.Point(67, 233);
            this.btn_themNCC.Name = "btn_themNCC";
            this.btn_themNCC.Size = new System.Drawing.Size(180, 50);
            this.btn_themNCC.TabIndex = 0;
            this.btn_themNCC.Text = "Thêm nhà cung cấp";
            this.btn_themNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_themNCC.UseVisualStyleBackColor = true;
            this.btn_themNCC.Click += new System.EventHandler(this.btn_themNCC_Click);
            // 
            // txtB_TenNCC
            // 
            this.txtB_TenNCC.Location = new System.Drawing.Point(159, 30);
            this.txtB_TenNCC.Name = "txtB_TenNCC";
            this.txtB_TenNCC.Size = new System.Drawing.Size(223, 20);
            this.txtB_TenNCC.TabIndex = 1;
            // 
            // txtB_emailNCC
            // 
            this.txtB_emailNCC.Location = new System.Drawing.Point(159, 76);
            this.txtB_emailNCC.Name = "txtB_emailNCC";
            this.txtB_emailNCC.Size = new System.Drawing.Size(223, 20);
            this.txtB_emailNCC.TabIndex = 2;
            // 
            // txtB_DiaChiNCC
            // 
            this.txtB_DiaChiNCC.Location = new System.Drawing.Point(159, 121);
            this.txtB_DiaChiNCC.Name = "txtB_DiaChiNCC";
            this.txtB_DiaChiNCC.Size = new System.Drawing.Size(223, 20);
            this.txtB_DiaChiNCC.TabIndex = 3;
            // 
            // txtB_SđtNCC
            // 
            this.txtB_SđtNCC.Location = new System.Drawing.Point(159, 164);
            this.txtB_SđtNCC.Name = "txtB_SđtNCC";
            this.txtB_SđtNCC.Size = new System.Drawing.Size(223, 20);
            this.txtB_SđtNCC.TabIndex = 5;
            // 
            // btn_exitNCC
            // 
            this.btn_exitNCC.Image = ((System.Drawing.Image)(resources.GetObject("btn_exitNCC.Image")));
            this.btn_exitNCC.Location = new System.Drawing.Point(290, 233);
            this.btn_exitNCC.Name = "btn_exitNCC";
            this.btn_exitNCC.Size = new System.Drawing.Size(130, 50);
            this.btn_exitNCC.TabIndex = 6;
            this.btn_exitNCC.Text = "Thoát";
            this.btn_exitNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exitNCC.UseVisualStyleBackColor = true;
            this.btn_exitNCC.Click += new System.EventHandler(this.btn_exitNCC_Click);
            // 
            // lb_TenNCC
            // 
            this.lb_TenNCC.AutoSize = true;
            this.lb_TenNCC.Location = new System.Drawing.Point(39, 30);
            this.lb_TenNCC.Name = "lb_TenNCC";
            this.lb_TenNCC.Size = new System.Drawing.Size(98, 13);
            this.lb_TenNCC.TabIndex = 7;
            this.lb_TenNCC.Text = "Tên nhà cung cấp:";
            // 
            // lb_DiaChiNCC
            // 
            this.lb_DiaChiNCC.AutoSize = true;
            this.lb_DiaChiNCC.Location = new System.Drawing.Point(94, 124);
            this.lb_DiaChiNCC.Name = "lb_DiaChiNCC";
            this.lb_DiaChiNCC.Size = new System.Drawing.Size(43, 13);
            this.lb_DiaChiNCC.TabIndex = 8;
            this.lb_DiaChiNCC.Text = "Địa chỉ:";
            // 
            // lb_EmailNCC
            // 
            this.lb_EmailNCC.AutoSize = true;
            this.lb_EmailNCC.Location = new System.Drawing.Point(102, 79);
            this.lb_EmailNCC.Name = "lb_EmailNCC";
            this.lb_EmailNCC.Size = new System.Drawing.Size(35, 13);
            this.lb_EmailNCC.TabIndex = 9;
            this.lb_EmailNCC.Text = "Email:";
            // 
            // lb_SdtNCC
            // 
            this.lb_SdtNCC.AutoSize = true;
            this.lb_SdtNCC.Location = new System.Drawing.Point(64, 167);
            this.lb_SdtNCC.Name = "lb_SdtNCC";
            this.lb_SdtNCC.Size = new System.Drawing.Size(73, 13);
            this.lb_SdtNCC.TabIndex = 10;
            this.lb_SdtNCC.Text = "Số điện thoại:";
            // 
            // NewSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 331);
            this.Controls.Add(this.lb_SdtNCC);
            this.Controls.Add(this.lb_EmailNCC);
            this.Controls.Add(this.lb_DiaChiNCC);
            this.Controls.Add(this.lb_TenNCC);
            this.Controls.Add(this.btn_exitNCC);
            this.Controls.Add(this.txtB_SđtNCC);
            this.Controls.Add(this.txtB_DiaChiNCC);
            this.Controls.Add(this.txtB_emailNCC);
            this.Controls.Add(this.txtB_TenNCC);
            this.Controls.Add(this.btn_themNCC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewSupplierForm";
            this.Text = "Quản lý nhà cung cấp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_themNCC;
        private System.Windows.Forms.TextBox txtB_TenNCC;
        private System.Windows.Forms.TextBox txtB_emailNCC;
        private System.Windows.Forms.TextBox txtB_DiaChiNCC;
        private System.Windows.Forms.TextBox txtB_SđtNCC;
        private System.Windows.Forms.Button btn_exitNCC;
        private System.Windows.Forms.Label lb_TenNCC;
        private System.Windows.Forms.Label lb_DiaChiNCC;
        private System.Windows.Forms.Label lb_EmailNCC;
        private System.Windows.Forms.Label lb_SdtNCC;
    }
}