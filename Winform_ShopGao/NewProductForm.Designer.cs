namespace Winform_ShopGao
{
    partial class NewProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductForm));
            this.txtB_ProductName = new System.Windows.Forms.TextBox();
            this.txtB_ProductPrice = new System.Windows.Forms.TextBox();
            this.rTxtB_DescriptionProduct = new System.Windows.Forms.RichTextBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.chB_TopProduct = new System.Windows.Forms.CheckBox();
            this.btn_NewProduct = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.picB_ImageProduct = new System.Windows.Forms.PictureBox();
            this.btn_UploadImage = new System.Windows.Forms.Button();
            this.btn_taoLoaiSP = new System.Windows.Forms.Button();
            this.lb_LoaiSP = new System.Windows.Forms.Label();
            this.lb_TenSP = new System.Windows.Forms.Label();
            this.lb_DonGia = new System.Windows.Forms.Label();
            this.lb_MieuTaSP = new System.Windows.Forms.Label();
            this.lb_HinhSP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picB_ImageProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtB_ProductName
            // 
            this.txtB_ProductName.Location = new System.Drawing.Point(155, 20);
            this.txtB_ProductName.Name = "txtB_ProductName";
            this.txtB_ProductName.Size = new System.Drawing.Size(190, 20);
            this.txtB_ProductName.TabIndex = 0;
            // 
            // txtB_ProductPrice
            // 
            this.txtB_ProductPrice.Location = new System.Drawing.Point(155, 102);
            this.txtB_ProductPrice.Name = "txtB_ProductPrice";
            this.txtB_ProductPrice.Size = new System.Drawing.Size(190, 20);
            this.txtB_ProductPrice.TabIndex = 1;
            this.txtB_ProductPrice.Leave += new System.EventHandler(this.txtB_ProductPrice_Leave);
            // 
            // rTxtB_DescriptionProduct
            // 
            this.rTxtB_DescriptionProduct.Location = new System.Drawing.Point(45, 174);
            this.rTxtB_DescriptionProduct.Name = "rTxtB_DescriptionProduct";
            this.rTxtB_DescriptionProduct.Size = new System.Drawing.Size(485, 192);
            this.rTxtB_DescriptionProduct.TabIndex = 2;
            this.rTxtB_DescriptionProduct.Text = "viết miêu tả ở đây";
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(155, 62);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(190, 21);
            this.cmbProductType.TabIndex = 3;
            // 
            // chB_TopProduct
            // 
            this.chB_TopProduct.AutoSize = true;
            this.chB_TopProduct.Location = new System.Drawing.Point(370, 22);
            this.chB_TopProduct.Name = "chB_TopProduct";
            this.chB_TopProduct.Size = new System.Drawing.Size(180, 17);
            this.chB_TopProduct.TabIndex = 4;
            this.chB_TopProduct.Text = "Đưa sản phẩm này lên trang chủ";
            this.chB_TopProduct.UseVisualStyleBackColor = true;
            // 
            // btn_NewProduct
            // 
            this.btn_NewProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_NewProduct.Image")));
            this.btn_NewProduct.Location = new System.Drawing.Point(553, 431);
            this.btn_NewProduct.Name = "btn_NewProduct";
            this.btn_NewProduct.Size = new System.Drawing.Size(180, 50);
            this.btn_NewProduct.TabIndex = 6;
            this.btn_NewProduct.Text = "Thêm sản phẩm mới";
            this.btn_NewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NewProduct.UseVisualStyleBackColor = true;
            this.btn_NewProduct.Click += new System.EventHandler(this.btn_NewProduct_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(763, 431);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(130, 50);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // picB_ImageProduct
            // 
            this.picB_ImageProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picB_ImageProduct.BackColor = System.Drawing.SystemColors.Control;
            this.picB_ImageProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picB_ImageProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picB_ImageProduct.Image = ((System.Drawing.Image)(resources.GetObject("picB_ImageProduct.Image")));
            this.picB_ImageProduct.Location = new System.Drawing.Point(567, 51);
            this.picB_ImageProduct.Name = "picB_ImageProduct";
            this.picB_ImageProduct.Size = new System.Drawing.Size(303, 277);
            this.picB_ImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picB_ImageProduct.TabIndex = 8;
            this.picB_ImageProduct.TabStop = false;
            // 
            // btn_UploadImage
            // 
            this.btn_UploadImage.Image = ((System.Drawing.Image)(resources.GetObject("btn_UploadImage.Image")));
            this.btn_UploadImage.Location = new System.Drawing.Point(669, 343);
            this.btn_UploadImage.Name = "btn_UploadImage";
            this.btn_UploadImage.Size = new System.Drawing.Size(100, 40);
            this.btn_UploadImage.TabIndex = 9;
            this.btn_UploadImage.Text = "Tải lên";
            this.btn_UploadImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_UploadImage.UseVisualStyleBackColor = true;
            this.btn_UploadImage.Click += new System.EventHandler(this.btn_UploadImage_Click);
            // 
            // btn_taoLoaiSP
            // 
            this.btn_taoLoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_taoLoaiSP.Image")));
            this.btn_taoLoaiSP.Location = new System.Drawing.Point(370, 51);
            this.btn_taoLoaiSP.Name = "btn_taoLoaiSP";
            this.btn_taoLoaiSP.Size = new System.Drawing.Size(160, 40);
            this.btn_taoLoaiSP.TabIndex = 10;
            this.btn_taoLoaiSP.Text = "Tạo loại sản phẩm mới";
            this.btn_taoLoaiSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_taoLoaiSP.UseVisualStyleBackColor = true;
            this.btn_taoLoaiSP.Click += new System.EventHandler(this.btn_taoLoaiSP_Click);
            // 
            // lb_LoaiSP
            // 
            this.lb_LoaiSP.AutoSize = true;
            this.lb_LoaiSP.Location = new System.Drawing.Point(60, 65);
            this.lb_LoaiSP.Name = "lb_LoaiSP";
            this.lb_LoaiSP.Size = new System.Drawing.Size(79, 13);
            this.lb_LoaiSP.TabIndex = 11;
            this.lb_LoaiSP.Text = "Loại sản phẩm:";
            // 
            // lb_TenSP
            // 
            this.lb_TenSP.AutoSize = true;
            this.lb_TenSP.Location = new System.Drawing.Point(61, 23);
            this.lb_TenSP.Name = "lb_TenSP";
            this.lb_TenSP.Size = new System.Drawing.Size(78, 13);
            this.lb_TenSP.TabIndex = 12;
            this.lb_TenSP.Text = "Tên sản phẩm:";
            // 
            // lb_DonGia
            // 
            this.lb_DonGia.AutoSize = true;
            this.lb_DonGia.Location = new System.Drawing.Point(36, 105);
            this.lb_DonGia.Name = "lb_DonGia";
            this.lb_DonGia.Size = new System.Drawing.Size(103, 13);
            this.lb_DonGia.TabIndex = 13;
            this.lb_DonGia.Text = "Giá bán 1 kg (VNĐ):";
            // 
            // lb_MieuTaSP
            // 
            this.lb_MieuTaSP.AutoSize = true;
            this.lb_MieuTaSP.Location = new System.Drawing.Point(45, 149);
            this.lb_MieuTaSP.Name = "lb_MieuTaSP";
            this.lb_MieuTaSP.Size = new System.Drawing.Size(94, 13);
            this.lb_MieuTaSP.TabIndex = 14;
            this.lb_MieuTaSP.Text = "Miêu tả sản phẩm:";
            // 
            // lb_HinhSP
            // 
            this.lb_HinhSP.AutoSize = true;
            this.lb_HinhSP.Location = new System.Drawing.Point(638, 27);
            this.lb_HinhSP.Name = "lb_HinhSP";
            this.lb_HinhSP.Size = new System.Drawing.Size(148, 13);
            this.lb_HinhSP.TabIndex = 15;
            this.lb_HinhSP.Text = "Hình minh họa cho sản phẩm:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lb_TenSP);
            this.panel1.Controls.Add(this.picB_ImageProduct);
            this.panel1.Controls.Add(this.btn_UploadImage);
            this.panel1.Controls.Add(this.lb_HinhSP);
            this.panel1.Controls.Add(this.lb_LoaiSP);
            this.panel1.Controls.Add(this.btn_taoLoaiSP);
            this.panel1.Controls.Add(this.lb_MieuTaSP);
            this.panel1.Controls.Add(this.lb_DonGia);
            this.panel1.Controls.Add(this.rTxtB_DescriptionProduct);
            this.panel1.Controls.Add(this.chB_TopProduct);
            this.panel1.Controls.Add(this.txtB_ProductName);
            this.panel1.Controls.Add(this.cmbProductType);
            this.panel1.Controls.Add(this.txtB_ProductPrice);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 403);
            this.panel1.TabIndex = 16;
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_NewProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewProductForm";
            this.Text = "Quản lý sản phẩm";
            this.VisibleChanged += new System.EventHandler(this.NewProductForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picB_ImageProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtB_ProductName;
        private System.Windows.Forms.TextBox txtB_ProductPrice;
        private System.Windows.Forms.RichTextBox rTxtB_DescriptionProduct;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.CheckBox chB_TopProduct;
        private System.Windows.Forms.Button btn_NewProduct;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox picB_ImageProduct;
        private System.Windows.Forms.Button btn_UploadImage;
        private System.Windows.Forms.Button btn_taoLoaiSP;
        private System.Windows.Forms.Label lb_LoaiSP;
        private System.Windows.Forms.Label lb_TenSP;
        private System.Windows.Forms.Label lb_DonGia;
        private System.Windows.Forms.Label lb_MieuTaSP;
        private System.Windows.Forms.Label lb_HinhSP;
        private System.Windows.Forms.Panel panel1;
    }
}