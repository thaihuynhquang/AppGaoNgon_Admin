namespace Winform_ShopGao
{
    partial class NewShipperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewShipperForm));
            this.lb_NameShipper = new System.Windows.Forms.Label();
            this.lb_EmailShipper = new System.Windows.Forms.Label();
            this.lb_PhoneShipper = new System.Windows.Forms.Label();
            this.txtB_NameShipper = new System.Windows.Forms.TextBox();
            this.txtB_EmailShipper = new System.Windows.Forms.TextBox();
            this.txtB_PhoneShipper = new System.Windows.Forms.TextBox();
            this.btn_InsertShipper = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_NameShipper
            // 
            this.lb_NameShipper.AutoSize = true;
            this.lb_NameShipper.Location = new System.Drawing.Point(48, 53);
            this.lb_NameShipper.Name = "lb_NameShipper";
            this.lb_NameShipper.Size = new System.Drawing.Size(108, 13);
            this.lb_NameShipper.TabIndex = 0;
            this.lb_NameShipper.Text = "Tên người giao hàng:";
            // 
            // lb_EmailShipper
            // 
            this.lb_EmailShipper.AutoSize = true;
            this.lb_EmailShipper.Location = new System.Drawing.Point(121, 94);
            this.lb_EmailShipper.Name = "lb_EmailShipper";
            this.lb_EmailShipper.Size = new System.Drawing.Size(35, 13);
            this.lb_EmailShipper.TabIndex = 1;
            this.lb_EmailShipper.Text = "Email:";
            // 
            // lb_PhoneShipper
            // 
            this.lb_PhoneShipper.AutoSize = true;
            this.lb_PhoneShipper.Location = new System.Drawing.Point(83, 128);
            this.lb_PhoneShipper.Name = "lb_PhoneShipper";
            this.lb_PhoneShipper.Size = new System.Drawing.Size(73, 13);
            this.lb_PhoneShipper.TabIndex = 2;
            this.lb_PhoneShipper.Text = "Số điện thoại:";
            // 
            // txtB_NameShipper
            // 
            this.txtB_NameShipper.Location = new System.Drawing.Point(177, 53);
            this.txtB_NameShipper.Name = "txtB_NameShipper";
            this.txtB_NameShipper.Size = new System.Drawing.Size(168, 20);
            this.txtB_NameShipper.TabIndex = 3;
            // 
            // txtB_EmailShipper
            // 
            this.txtB_EmailShipper.Location = new System.Drawing.Point(177, 91);
            this.txtB_EmailShipper.Name = "txtB_EmailShipper";
            this.txtB_EmailShipper.Size = new System.Drawing.Size(168, 20);
            this.txtB_EmailShipper.TabIndex = 4;
            // 
            // txtB_PhoneShipper
            // 
            this.txtB_PhoneShipper.Location = new System.Drawing.Point(177, 125);
            this.txtB_PhoneShipper.Name = "txtB_PhoneShipper";
            this.txtB_PhoneShipper.Size = new System.Drawing.Size(168, 20);
            this.txtB_PhoneShipper.TabIndex = 5;
            // 
            // btn_InsertShipper
            // 
            this.btn_InsertShipper.Image = ((System.Drawing.Image)(resources.GetObject("btn_InsertShipper.Image")));
            this.btn_InsertShipper.Location = new System.Drawing.Point(74, 182);
            this.btn_InsertShipper.Name = "btn_InsertShipper";
            this.btn_InsertShipper.Size = new System.Drawing.Size(130, 50);
            this.btn_InsertShipper.TabIndex = 6;
            this.btn_InsertShipper.Text = "Tạo";
            this.btn_InsertShipper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_InsertShipper.UseVisualStyleBackColor = true;
            this.btn_InsertShipper.Click += new System.EventHandler(this.btn_InsertShipper_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(249, 182);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(130, 50);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // NewShipperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 261);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_InsertShipper);
            this.Controls.Add(this.txtB_PhoneShipper);
            this.Controls.Add(this.txtB_EmailShipper);
            this.Controls.Add(this.txtB_NameShipper);
            this.Controls.Add(this.lb_PhoneShipper);
            this.Controls.Add(this.lb_EmailShipper);
            this.Controls.Add(this.lb_NameShipper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewShipperForm";
            this.Text = "Quản lý nhân viên giao hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_NameShipper;
        private System.Windows.Forms.Label lb_EmailShipper;
        private System.Windows.Forms.Label lb_PhoneShipper;
        private System.Windows.Forms.TextBox txtB_NameShipper;
        private System.Windows.Forms.TextBox txtB_EmailShipper;
        private System.Windows.Forms.TextBox txtB_PhoneShipper;
        private System.Windows.Forms.Button btn_InsertShipper;
        private System.Windows.Forms.Button btn_Exit;
    }
}