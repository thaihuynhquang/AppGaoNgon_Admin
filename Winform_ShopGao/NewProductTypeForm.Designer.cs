namespace Winform_ShopGao
{
    partial class NewProductTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductTypeForm));
            this.txtB_NameProductType = new System.Windows.Forms.TextBox();
            this.picBox_ImageProductType = new System.Windows.Forms.PictureBox();
            this.btn_chooseImage = new System.Windows.Forms.Button();
            this.btn_InsertProductType = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lb_NameProductType = new System.Windows.Forms.Label();
            this.lb_ChooseImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ImageProductType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtB_NameProductType
            // 
            this.txtB_NameProductType.Location = new System.Drawing.Point(172, 43);
            this.txtB_NameProductType.Name = "txtB_NameProductType";
            this.txtB_NameProductType.Size = new System.Drawing.Size(192, 20);
            this.txtB_NameProductType.TabIndex = 0;
            // 
            // picBox_ImageProductType
            // 
            this.picBox_ImageProductType.BackColor = System.Drawing.SystemColors.Control;
            this.picBox_ImageProductType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_ImageProductType.Image = ((System.Drawing.Image)(resources.GetObject("picBox_ImageProductType.Image")));
            this.picBox_ImageProductType.Location = new System.Drawing.Point(59, 123);
            this.picBox_ImageProductType.Name = "picBox_ImageProductType";
            this.picBox_ImageProductType.Size = new System.Drawing.Size(359, 193);
            this.picBox_ImageProductType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_ImageProductType.TabIndex = 1;
            this.picBox_ImageProductType.TabStop = false;
            // 
            // btn_chooseImage
            // 
            this.btn_chooseImage.Image = ((System.Drawing.Image)(resources.GetObject("btn_chooseImage.Image")));
            this.btn_chooseImage.Location = new System.Drawing.Point(308, 322);
            this.btn_chooseImage.Name = "btn_chooseImage";
            this.btn_chooseImage.Size = new System.Drawing.Size(100, 40);
            this.btn_chooseImage.TabIndex = 2;
            this.btn_chooseImage.Text = "Tải lên";
            this.btn_chooseImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_chooseImage.UseVisualStyleBackColor = true;
            this.btn_chooseImage.Click += new System.EventHandler(this.btn_chooseImage_Click);
            // 
            // btn_InsertProductType
            // 
            this.btn_InsertProductType.Image = ((System.Drawing.Image)(resources.GetObject("btn_InsertProductType.Image")));
            this.btn_InsertProductType.Location = new System.Drawing.Point(91, 397);
            this.btn_InsertProductType.Name = "btn_InsertProductType";
            this.btn_InsertProductType.Size = new System.Drawing.Size(130, 50);
            this.btn_InsertProductType.TabIndex = 3;
            this.btn_InsertProductType.Text = "Tạo";
            this.btn_InsertProductType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_InsertProductType.UseVisualStyleBackColor = true;
            this.btn_InsertProductType.Click += new System.EventHandler(this.btn_InsertProductType_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(257, 397);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(130, 50);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lb_NameProductType
            // 
            this.lb_NameProductType.AutoSize = true;
            this.lb_NameProductType.Location = new System.Drawing.Point(56, 46);
            this.lb_NameProductType.Name = "lb_NameProductType";
            this.lb_NameProductType.Size = new System.Drawing.Size(97, 13);
            this.lb_NameProductType.TabIndex = 5;
            this.lb_NameProductType.Text = "Tên loại sản phẩm:";
            // 
            // lb_ChooseImage
            // 
            this.lb_ChooseImage.AutoSize = true;
            this.lb_ChooseImage.Location = new System.Drawing.Point(169, 97);
            this.lb_ChooseImage.Name = "lb_ChooseImage";
            this.lb_ChooseImage.Size = new System.Drawing.Size(127, 13);
            this.lb_ChooseImage.TabIndex = 6;
            this.lb_ChooseImage.Text = "Hình minh họa sản phẩm:";
            // 
            // NewProductTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 480);
            this.Controls.Add(this.lb_ChooseImage);
            this.Controls.Add(this.lb_NameProductType);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_InsertProductType);
            this.Controls.Add(this.btn_chooseImage);
            this.Controls.Add(this.picBox_ImageProductType);
            this.Controls.Add(this.txtB_NameProductType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewProductTypeForm";
            this.Text = "Quản lý loại sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ImageProductType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_NameProductType;
        private System.Windows.Forms.PictureBox picBox_ImageProductType;
        private System.Windows.Forms.Button btn_chooseImage;
        private System.Windows.Forms.Button btn_InsertProductType;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lb_NameProductType;
        private System.Windows.Forms.Label lb_ChooseImage;
    }
}