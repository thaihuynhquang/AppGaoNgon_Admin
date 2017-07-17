namespace Winform_ShopGao
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPaneMainForm = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNaviPage_NhaCungCap = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_clearSupplier = new System.Windows.Forms.Button();
            this.btn_SearchSupplier = new System.Windows.Forms.Button();
            this.txtB_SearchSupplier = new System.Windows.Forms.TextBox();
            this.btn_RefreshDataSupplier = new System.Windows.Forms.Button();
            this.btt_EditSupplier = new System.Windows.Forms.Button();
            this.btt_newSupplier = new System.Windows.Forms.Button();
            this.supplierGridControl = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_SanPham = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_RefreshDataProduct = new System.Windows.Forms.Button();
            this.btn_ClearProduct = new System.Windows.Forms.Button();
            this.txtB_SearchProduct = new System.Windows.Forms.TextBox();
            this.btn_SearchProduct = new System.Windows.Forms.Button();
            this.btt_EditProduct = new System.Windows.Forms.Button();
            this.btt_newProduct = new System.Windows.Forms.Button();
            this.productGridControl = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_KhachHang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_ClearCustomer = new System.Windows.Forms.Button();
            this.btn_SearchCustomer = new System.Windows.Forms.Button();
            this.txtB_SearchCus = new System.Windows.Forms.TextBox();
            this.btn_RefreshDataCustomer = new System.Windows.Forms.Button();
            this.userGridControl = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_DonHang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_ClearBill = new System.Windows.Forms.Button();
            this.btn_RefreshDataBIll = new System.Windows.Forms.Button();
            this.txtB_SearchBill = new System.Windows.Forms.TextBox();
            this.btn_SearchBill = new System.Windows.Forms.Button();
            this.btn_newBill = new System.Windows.Forms.Button();
            this.billGridControl = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_NhapHang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_EditImportProduct = new System.Windows.Forms.Button();
            this.btn_ClearImport = new System.Windows.Forms.Button();
            this.btn_SearchImport = new System.Windows.Forms.Button();
            this.txtB_SearchImport = new System.Windows.Forms.TextBox();
            this.btn_RefreshDataImport = new System.Windows.Forms.Button();
            this.btn_importProduct = new System.Windows.Forms.Button();
            this.importGridControl = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_GiaoHang = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_ClearShipper = new System.Windows.Forms.Button();
            this.btn_SearchShipper = new System.Windows.Forms.Button();
            this.txtB_SearchShipper = new System.Windows.Forms.TextBox();
            this.btn_RefreshDataShipper = new System.Windows.Forms.Button();
            this.btn_EditShipper = new System.Windows.Forms.Button();
            this.btn_InsertShipper = new System.Windows.Forms.Button();
            this.shippersGridControl = new System.Windows.Forms.DataGridView();
            this.tabNaviPage_LoaiSanPham = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_ClearProductType = new System.Windows.Forms.Button();
            this.btn_SearchProductType = new System.Windows.Forms.Button();
            this.txtB_SearchProductType = new System.Windows.Forms.TextBox();
            this.btn_RefreshDataProductType = new System.Windows.Forms.Button();
            this.btn_EditProductType = new System.Windows.Forms.Button();
            this.btn_InsertProductType = new System.Windows.Forms.Button();
            this.productTypeGridControl = new System.Windows.Forms.DataGridView();
            this.btn_ChangePass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneMainForm)).BeginInit();
            this.tabPaneMainForm.SuspendLayout();
            this.tabNaviPage_NhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridControl)).BeginInit();
            this.tabNaviPage_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            this.tabNaviPage_KhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).BeginInit();
            this.tabNaviPage_DonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billGridControl)).BeginInit();
            this.tabNaviPage_NhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importGridControl)).BeginInit();
            this.tabNaviPage_GiaoHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shippersGridControl)).BeginInit();
            this.tabNaviPage_LoaiSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPaneMainForm
            // 
            this.tabPaneMainForm.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.tabPaneMainForm.Appearance.Options.UseBackColor = true;
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_NhaCungCap);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_SanPham);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_KhachHang);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_DonHang);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_NhapHang);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_GiaoHang);
            this.tabPaneMainForm.Controls.Add(this.tabNaviPage_LoaiSanPham);
            this.tabPaneMainForm.Location = new System.Drawing.Point(2, 1);
            this.tabPaneMainForm.Name = "tabPaneMainForm";
            this.tabPaneMainForm.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.tabPaneMainForm.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabPaneMainForm.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNaviPage_NhaCungCap,
            this.tabNaviPage_NhapHang,
            this.tabNaviPage_SanPham,
            this.tabNaviPage_LoaiSanPham,
            this.tabNaviPage_DonHang,
            this.tabNaviPage_GiaoHang,
            this.tabNaviPage_KhachHang});
            this.tabPaneMainForm.RegularSize = new System.Drawing.Size(995, 527);
            this.tabPaneMainForm.SelectedPage = this.tabNaviPage_NhaCungCap;
            this.tabPaneMainForm.Size = new System.Drawing.Size(995, 527);
            this.tabPaneMainForm.TabIndex = 0;
            this.tabPaneMainForm.Text = "asdas";
            // 
            // tabNaviPage_NhaCungCap
            // 
            this.tabNaviPage_NhaCungCap.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.tabNaviPage_NhaCungCap.Appearance.Options.UseBackColor = true;
            this.tabNaviPage_NhaCungCap.Caption = "NHÀ CUNG CẤP";
            this.tabNaviPage_NhaCungCap.Controls.Add(this.btn_clearSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.btn_SearchSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.txtB_SearchSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.btn_RefreshDataSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.btt_EditSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.btt_newSupplier);
            this.tabNaviPage_NhaCungCap.Controls.Add(this.supplierGridControl);
            this.tabNaviPage_NhaCungCap.Name = "tabNaviPage_NhaCungCap";
            this.tabNaviPage_NhaCungCap.Size = new System.Drawing.Size(977, 482);
            this.tabNaviPage_NhaCungCap.VisibleChanged += new System.EventHandler(this.tabNaviPage_NhaCungCap_VisibleChanged);
            // 
            // btn_clearSupplier
            // 
            this.btn_clearSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btn_clearSupplier.Image")));
            this.btn_clearSupplier.Location = new System.Drawing.Point(516, 15);
            this.btn_clearSupplier.Name = "btn_clearSupplier";
            this.btn_clearSupplier.Size = new System.Drawing.Size(60, 30);
            this.btn_clearSupplier.TabIndex = 5;
            this.btn_clearSupplier.Text = "Xóa";
            this.btn_clearSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_clearSupplier.UseVisualStyleBackColor = true;
            this.btn_clearSupplier.Click += new System.EventHandler(this.btn_clearSupplier_Click);
            // 
            // btn_SearchSupplier
            // 
            this.btn_SearchSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchSupplier.Image")));
            this.btn_SearchSupplier.Location = new System.Drawing.Point(410, 15);
            this.btn_SearchSupplier.Name = "btn_SearchSupplier";
            this.btn_SearchSupplier.Size = new System.Drawing.Size(100, 30);
            this.btn_SearchSupplier.TabIndex = 4;
            this.btn_SearchSupplier.Text = "Tìm kiếm";
            this.btn_SearchSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SearchSupplier.UseVisualStyleBackColor = true;
            this.btn_SearchSupplier.Click += new System.EventHandler(this.btn_SearchSupplier_Click);
            // 
            // txtB_SearchSupplier
            // 
            this.txtB_SearchSupplier.Location = new System.Drawing.Point(4, 21);
            this.txtB_SearchSupplier.Name = "txtB_SearchSupplier";
            this.txtB_SearchSupplier.Size = new System.Drawing.Size(400, 20);
            this.txtB_SearchSupplier.TabIndex = 3;
            this.txtB_SearchSupplier.Text = "Tìm kiếm theo mã/tên nhà cung cấp, email, điện thoại, địa chỉ";
            this.txtB_SearchSupplier.Enter += new System.EventHandler(this.txtB_SearchSupplier_Enter);
            this.txtB_SearchSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_SearchSupplier_KeyPress);
            // 
            // btn_RefreshDataSupplier
            // 
            this.btn_RefreshDataSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshDataSupplier.Image")));
            this.btn_RefreshDataSupplier.Location = new System.Drawing.Point(410, 405);
            this.btn_RefreshDataSupplier.Name = "btn_RefreshDataSupplier";
            this.btn_RefreshDataSupplier.Size = new System.Drawing.Size(130, 50);
            this.btn_RefreshDataSupplier.TabIndex = 2;
            this.btn_RefreshDataSupplier.Text = "Tải lại dữ liệu";
            this.btn_RefreshDataSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RefreshDataSupplier.UseVisualStyleBackColor = true;
            this.btn_RefreshDataSupplier.Click += new System.EventHandler(this.btn_RefreshDataSupplier_Click);
            // 
            // btt_EditSupplier
            // 
            this.btt_EditSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btt_EditSupplier.Image")));
            this.btt_EditSupplier.Location = new System.Drawing.Point(760, 405);
            this.btt_EditSupplier.Name = "btt_EditSupplier";
            this.btt_EditSupplier.Size = new System.Drawing.Size(180, 50);
            this.btt_EditSupplier.TabIndex = 2;
            this.btt_EditSupplier.Text = "Thay đổi thông tin";
            this.btt_EditSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btt_EditSupplier.UseVisualStyleBackColor = true;
            this.btt_EditSupplier.Click += new System.EventHandler(this.btt_EditSupplier_Click);
            // 
            // btt_newSupplier
            // 
            this.btt_newSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btt_newSupplier.Image")));
            this.btt_newSupplier.Location = new System.Drawing.Point(560, 405);
            this.btt_newSupplier.Name = "btt_newSupplier";
            this.btt_newSupplier.Size = new System.Drawing.Size(180, 50);
            this.btt_newSupplier.TabIndex = 1;
            this.btt_newSupplier.Text = "Thêm nhà cung cấp";
            this.btt_newSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btt_newSupplier.UseVisualStyleBackColor = true;
            this.btt_newSupplier.Click += new System.EventHandler(this.newSupp_Click);
            // 
            // supplierGridControl
            // 
            this.supplierGridControl.AllowUserToAddRows = false;
            this.supplierGridControl.AllowUserToDeleteRows = false;
            this.supplierGridControl.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.supplierGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGridControl.Location = new System.Drawing.Point(4, 55);
            this.supplierGridControl.MultiSelect = false;
            this.supplierGridControl.Name = "supplierGridControl";
            this.supplierGridControl.ReadOnly = true;
            this.supplierGridControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierGridControl.Size = new System.Drawing.Size(946, 340);
            this.supplierGridControl.TabIndex = 0;
            // 
            // tabNaviPage_SanPham
            // 
            this.tabNaviPage_SanPham.Caption = "SẢN PHẨM";
            this.tabNaviPage_SanPham.Controls.Add(this.btn_RefreshDataProduct);
            this.tabNaviPage_SanPham.Controls.Add(this.btn_ClearProduct);
            this.tabNaviPage_SanPham.Controls.Add(this.txtB_SearchProduct);
            this.tabNaviPage_SanPham.Controls.Add(this.btn_SearchProduct);
            this.tabNaviPage_SanPham.Controls.Add(this.btt_EditProduct);
            this.tabNaviPage_SanPham.Controls.Add(this.btt_newProduct);
            this.tabNaviPage_SanPham.Controls.Add(this.productGridControl);
            this.tabNaviPage_SanPham.Name = "tabNaviPage_SanPham";
            this.tabNaviPage_SanPham.Size = new System.Drawing.Size(977, 482);
            this.tabNaviPage_SanPham.VisibleChanged += new System.EventHandler(this.tabNaviPage_SanPham_VisibleChanged);
            // 
            // btn_RefreshDataProduct
            // 
            this.btn_RefreshDataProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshDataProduct.Image")));
            this.btn_RefreshDataProduct.Location = new System.Drawing.Point(410, 405);
            this.btn_RefreshDataProduct.Name = "btn_RefreshDataProduct";
            this.btn_RefreshDataProduct.Size = new System.Drawing.Size(130, 50);
            this.btn_RefreshDataProduct.TabIndex = 6;
            this.btn_RefreshDataProduct.Text = "Tải lại dữ liệu";
            this.btn_RefreshDataProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RefreshDataProduct.UseVisualStyleBackColor = true;
            this.btn_RefreshDataProduct.Click += new System.EventHandler(this.btn_RefreshDataProduct_Click);
            // 
            // btn_ClearProduct
            // 
            this.btn_ClearProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClearProduct.Image")));
            this.btn_ClearProduct.Location = new System.Drawing.Point(516, 15);
            this.btn_ClearProduct.Name = "btn_ClearProduct";
            this.btn_ClearProduct.Size = new System.Drawing.Size(60, 30);
            this.btn_ClearProduct.TabIndex = 5;
            this.btn_ClearProduct.Text = "Xóa";
            this.btn_ClearProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ClearProduct.UseVisualStyleBackColor = true;
            this.btn_ClearProduct.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txtB_SearchProduct
            // 
            this.txtB_SearchProduct.Location = new System.Drawing.Point(4, 21);
            this.txtB_SearchProduct.Name = "txtB_SearchProduct";
            this.txtB_SearchProduct.Size = new System.Drawing.Size(400, 20);
            this.txtB_SearchProduct.TabIndex = 4;
            this.txtB_SearchProduct.Text = "Tìm kiếm theo mã/tên sản phẩm, mã loại sản phẩm";
            this.txtB_SearchProduct.Enter += new System.EventHandler(this.txtB_SearchProduct_Enter);
            this.txtB_SearchProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_SearchProduct_KeyPress);
            // 
            // btn_SearchProduct
            // 
            this.btn_SearchProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchProduct.Image")));
            this.btn_SearchProduct.Location = new System.Drawing.Point(410, 15);
            this.btn_SearchProduct.Name = "btn_SearchProduct";
            this.btn_SearchProduct.Size = new System.Drawing.Size(100, 30);
            this.btn_SearchProduct.TabIndex = 3;
            this.btn_SearchProduct.Text = "Tìm kiếm";
            this.btn_SearchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SearchProduct.UseVisualStyleBackColor = true;
            this.btn_SearchProduct.Click += new System.EventHandler(this.btn_SearchProduct_Click);
            // 
            // btt_EditProduct
            // 
            this.btt_EditProduct.Image = ((System.Drawing.Image)(resources.GetObject("btt_EditProduct.Image")));
            this.btt_EditProduct.Location = new System.Drawing.Point(760, 405);
            this.btt_EditProduct.Name = "btt_EditProduct";
            this.btt_EditProduct.Size = new System.Drawing.Size(180, 50);
            this.btt_EditProduct.TabIndex = 2;
            this.btt_EditProduct.Text = "Thay đổi thông tin";
            this.btt_EditProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btt_EditProduct.UseVisualStyleBackColor = true;
            this.btt_EditProduct.Click += new System.EventHandler(this.btt_EditProduct_Click);
            // 
            // btt_newProduct
            // 
            this.btt_newProduct.Image = ((System.Drawing.Image)(resources.GetObject("btt_newProduct.Image")));
            this.btt_newProduct.Location = new System.Drawing.Point(560, 405);
            this.btt_newProduct.Name = "btt_newProduct";
            this.btt_newProduct.Size = new System.Drawing.Size(180, 50);
            this.btt_newProduct.TabIndex = 1;
            this.btt_newProduct.Text = "Thêm sản phẩm mới";
            this.btt_newProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btt_newProduct.UseVisualStyleBackColor = true;
            this.btt_newProduct.Click += new System.EventHandler(this.btt_newProduct_Click);
            // 
            // productGridControl
            // 
            this.productGridControl.AllowUserToAddRows = false;
            this.productGridControl.AllowUserToDeleteRows = false;
            this.productGridControl.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.productGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridControl.Location = new System.Drawing.Point(4, 55);
            this.productGridControl.MultiSelect = false;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.ReadOnly = true;
            this.productGridControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridControl.Size = new System.Drawing.Size(946, 340);
            this.productGridControl.TabIndex = 0;
            // 
            // tabNaviPage_KhachHang
            // 
            this.tabNaviPage_KhachHang.Caption = "KHÁCH HÀNG";
            this.tabNaviPage_KhachHang.Controls.Add(this.btn_ClearCustomer);
            this.tabNaviPage_KhachHang.Controls.Add(this.btn_SearchCustomer);
            this.tabNaviPage_KhachHang.Controls.Add(this.txtB_SearchCus);
            this.tabNaviPage_KhachHang.Controls.Add(this.btn_RefreshDataCustomer);
            this.tabNaviPage_KhachHang.Controls.Add(this.userGridControl);
            this.tabNaviPage_KhachHang.Name = "tabNaviPage_KhachHang";
            this.tabNaviPage_KhachHang.Size = new System.Drawing.Size(979, 557);
            this.tabNaviPage_KhachHang.VisibleChanged += new System.EventHandler(this.tabNaviPage_KhachHang_VisibleChanged);
            // 
            // btn_ClearCustomer
            // 
            this.btn_ClearCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClearCustomer.Image")));
            this.btn_ClearCustomer.Location = new System.Drawing.Point(516, 15);
            this.btn_ClearCustomer.Name = "btn_ClearCustomer";
            this.btn_ClearCustomer.Size = new System.Drawing.Size(60, 30);
            this.btn_ClearCustomer.TabIndex = 4;
            this.btn_ClearCustomer.Text = "Xóa";
            this.btn_ClearCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ClearCustomer.UseVisualStyleBackColor = true;
            this.btn_ClearCustomer.Click += new System.EventHandler(this.btn_ClearCustomer_Click);
            // 
            // btn_SearchCustomer
            // 
            this.btn_SearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchCustomer.Image")));
            this.btn_SearchCustomer.Location = new System.Drawing.Point(410, 15);
            this.btn_SearchCustomer.Name = "btn_SearchCustomer";
            this.btn_SearchCustomer.Size = new System.Drawing.Size(100, 30);
            this.btn_SearchCustomer.TabIndex = 3;
            this.btn_SearchCustomer.Text = "Tìm kiếm";
            this.btn_SearchCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SearchCustomer.UseVisualStyleBackColor = true;
            this.btn_SearchCustomer.Click += new System.EventHandler(this.btn_SearchCustomer_Click);
            // 
            // txtB_SearchCus
            // 
            this.txtB_SearchCus.Location = new System.Drawing.Point(4, 21);
            this.txtB_SearchCus.Name = "txtB_SearchCus";
            this.txtB_SearchCus.Size = new System.Drawing.Size(400, 20);
            this.txtB_SearchCus.TabIndex = 2;
            this.txtB_SearchCus.Text = "Tìm kiếm theo mã/tên khách hàng, email, điện thoai";
            this.txtB_SearchCus.Enter += new System.EventHandler(this.txtB_SearchCus_Enter);
            this.txtB_SearchCus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_SearchCus_KeyPress);
            // 
            // btn_RefreshDataCustomer
            // 
            this.btn_RefreshDataCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshDataCustomer.Image")));
            this.btn_RefreshDataCustomer.Location = new System.Drawing.Point(811, 405);
            this.btn_RefreshDataCustomer.Name = "btn_RefreshDataCustomer";
            this.btn_RefreshDataCustomer.Size = new System.Drawing.Size(130, 50);
            this.btn_RefreshDataCustomer.TabIndex = 1;
            this.btn_RefreshDataCustomer.Text = "Tải lại dữ liệu";
            this.btn_RefreshDataCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RefreshDataCustomer.UseVisualStyleBackColor = true;
            this.btn_RefreshDataCustomer.Click += new System.EventHandler(this.btn_RefreshDataCustomer_Click);
            // 
            // userGridControl
            // 
            this.userGridControl.AllowUserToAddRows = false;
            this.userGridControl.AllowUserToDeleteRows = false;
            this.userGridControl.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.userGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridControl.Location = new System.Drawing.Point(4, 55);
            this.userGridControl.MultiSelect = false;
            this.userGridControl.Name = "userGridControl";
            this.userGridControl.ReadOnly = true;
            this.userGridControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGridControl.Size = new System.Drawing.Size(946, 340);
            this.userGridControl.TabIndex = 0;
            // 
            // tabNaviPage_DonHang
            // 
            this.tabNaviPage_DonHang.Caption = "ĐƠN HÀNG";
            this.tabNaviPage_DonHang.Controls.Add(this.btn_ClearBill);
            this.tabNaviPage_DonHang.Controls.Add(this.btn_RefreshDataBIll);
            this.tabNaviPage_DonHang.Controls.Add(this.txtB_SearchBill);
            this.tabNaviPage_DonHang.Controls.Add(this.btn_SearchBill);
            this.tabNaviPage_DonHang.Controls.Add(this.btn_newBill);
            this.tabNaviPage_DonHang.Controls.Add(this.billGridControl);
            this.tabNaviPage_DonHang.Name = "tabNaviPage_DonHang";
            this.tabNaviPage_DonHang.Size = new System.Drawing.Size(979, 554);
            this.tabNaviPage_DonHang.VisibleChanged += new System.EventHandler(this.tabNaviPage_DonHang_VisibleChanged);
            // 
            // btn_ClearBill
            // 
            this.btn_ClearBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClearBill.Image")));
            this.btn_ClearBill.Location = new System.Drawing.Point(516, 15);
            this.btn_ClearBill.Name = "btn_ClearBill";
            this.btn_ClearBill.Size = new System.Drawing.Size(60, 30);
            this.btn_ClearBill.TabIndex = 5;
            this.btn_ClearBill.Text = "Xóa";
            this.btn_ClearBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ClearBill.UseVisualStyleBackColor = true;
            this.btn_ClearBill.Click += new System.EventHandler(this.btn_ClearBill_Click);
            // 
            // btn_RefreshDataBIll
            // 
            this.btn_RefreshDataBIll.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshDataBIll.Image")));
            this.btn_RefreshDataBIll.Location = new System.Drawing.Point(610, 405);
            this.btn_RefreshDataBIll.Name = "btn_RefreshDataBIll";
            this.btn_RefreshDataBIll.Size = new System.Drawing.Size(130, 50);
            this.btn_RefreshDataBIll.TabIndex = 4;
            this.btn_RefreshDataBIll.Text = "Tải lại dữ liệu";
            this.btn_RefreshDataBIll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RefreshDataBIll.UseVisualStyleBackColor = true;
            this.btn_RefreshDataBIll.Click += new System.EventHandler(this.btn_RefreshDataBIll_Click);
            // 
            // txtB_SearchBill
            // 
            this.txtB_SearchBill.Location = new System.Drawing.Point(4, 21);
            this.txtB_SearchBill.Name = "txtB_SearchBill";
            this.txtB_SearchBill.Size = new System.Drawing.Size(400, 20);
            this.txtB_SearchBill.TabIndex = 3;
            this.txtB_SearchBill.Text = "Tìm kiếm theo mã đơn hàng, mã khách hàng, mã nhân viên giao hàng";
            this.txtB_SearchBill.Enter += new System.EventHandler(this.txtB_SearchBill_Enter);
            this.txtB_SearchBill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_SearchBill_KeyPress);
            // 
            // btn_SearchBill
            // 
            this.btn_SearchBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchBill.Image")));
            this.btn_SearchBill.Location = new System.Drawing.Point(410, 15);
            this.btn_SearchBill.Name = "btn_SearchBill";
            this.btn_SearchBill.Size = new System.Drawing.Size(100, 30);
            this.btn_SearchBill.TabIndex = 2;
            this.btn_SearchBill.Text = "Tìm kiếm";
            this.btn_SearchBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SearchBill.UseVisualStyleBackColor = true;
            this.btn_SearchBill.Click += new System.EventHandler(this.btn_SearchBill_Click);
            // 
            // btn_newBill
            // 
            this.btn_newBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_newBill.Image")));
            this.btn_newBill.Location = new System.Drawing.Point(760, 405);
            this.btn_newBill.Name = "btn_newBill";
            this.btn_newBill.Size = new System.Drawing.Size(180, 50);
            this.btn_newBill.TabIndex = 1;
            this.btn_newBill.Text = "Chi tiết đơn hàng";
            this.btn_newBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_newBill.UseVisualStyleBackColor = true;
            this.btn_newBill.Click += new System.EventHandler(this.btn_newBill_Click);
            // 
            // billGridControl
            // 
            this.billGridControl.AllowUserToAddRows = false;
            this.billGridControl.AllowUserToDeleteRows = false;
            this.billGridControl.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.billGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billGridControl.Location = new System.Drawing.Point(4, 55);
            this.billGridControl.MultiSelect = false;
            this.billGridControl.Name = "billGridControl";
            this.billGridControl.ReadOnly = true;
            this.billGridControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billGridControl.Size = new System.Drawing.Size(946, 340);
            this.billGridControl.TabIndex = 0;
            // 
            // tabNaviPage_NhapHang
            // 
            this.tabNaviPage_NhapHang.Caption = "NHẬP HÀNG";
            this.tabNaviPage_NhapHang.Controls.Add(this.btn_EditImportProduct);
            this.tabNaviPage_NhapHang.Controls.Add(this.btn_ClearImport);
            this.tabNaviPage_NhapHang.Controls.Add(this.btn_SearchImport);
            this.tabNaviPage_NhapHang.Controls.Add(this.txtB_SearchImport);
            this.tabNaviPage_NhapHang.Controls.Add(this.btn_RefreshDataImport);
            this.tabNaviPage_NhapHang.Controls.Add(this.btn_importProduct);
            this.tabNaviPage_NhapHang.Controls.Add(this.importGridControl);
            this.tabNaviPage_NhapHang.Name = "tabNaviPage_NhapHang";
            this.tabNaviPage_NhapHang.Size = new System.Drawing.Size(977, 482);
            this.tabNaviPage_NhapHang.VisibleChanged += new System.EventHandler(this.tabNaviPage_NhapHang_VisibleChanged);
            // 
            // btn_EditImportProduct
            // 
            this.btn_EditImportProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditImportProduct.Image")));
            this.btn_EditImportProduct.Location = new System.Drawing.Point(760, 405);
            this.btn_EditImportProduct.Name = "btn_EditImportProduct";
            this.btn_EditImportProduct.Size = new System.Drawing.Size(180, 50);
            this.btn_EditImportProduct.TabIndex = 6;
            this.btn_EditImportProduct.Text = "Thay đổi thông tin";
            this.btn_EditImportProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditImportProduct.UseVisualStyleBackColor = true;
            this.btn_EditImportProduct.Click += new System.EventHandler(this.btn_EditImportProduct_Click);
            // 
            // btn_ClearImport
            // 
            this.btn_ClearImport.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClearImport.Image")));
            this.btn_ClearImport.Location = new System.Drawing.Point(516, 15);
            this.btn_ClearImport.Name = "btn_ClearImport";
            this.btn_ClearImport.Size = new System.Drawing.Size(60, 30);
            this.btn_ClearImport.TabIndex = 5;
            this.btn_ClearImport.Text = "Xóa";
            this.btn_ClearImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ClearImport.UseVisualStyleBackColor = true;
            this.btn_ClearImport.Click += new System.EventHandler(this.btn_ClearImport_Click);
            // 
            // btn_SearchImport
            // 
            this.btn_SearchImport.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchImport.Image")));
            this.btn_SearchImport.Location = new System.Drawing.Point(410, 15);
            this.btn_SearchImport.Name = "btn_SearchImport";
            this.btn_SearchImport.Size = new System.Drawing.Size(100, 30);
            this.btn_SearchImport.TabIndex = 4;
            this.btn_SearchImport.Text = "Tìm kiếm";
            this.btn_SearchImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SearchImport.UseVisualStyleBackColor = true;
            this.btn_SearchImport.Click += new System.EventHandler(this.btn_SearchImport_Click);
            // 
            // txtB_SearchImport
            // 
            this.txtB_SearchImport.Location = new System.Drawing.Point(4, 21);
            this.txtB_SearchImport.Name = "txtB_SearchImport";
            this.txtB_SearchImport.Size = new System.Drawing.Size(400, 20);
            this.txtB_SearchImport.TabIndex = 3;
            this.txtB_SearchImport.Text = "Tìm kiếm theo mã/tên nhà cung cấp, mã/tên sản phẩm";
            this.txtB_SearchImport.Enter += new System.EventHandler(this.txtB_SearchImport_Enter);
            this.txtB_SearchImport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_SearchImport_KeyPress);
            // 
            // btn_RefreshDataImport
            // 
            this.btn_RefreshDataImport.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshDataImport.Image")));
            this.btn_RefreshDataImport.Location = new System.Drawing.Point(460, 405);
            this.btn_RefreshDataImport.Name = "btn_RefreshDataImport";
            this.btn_RefreshDataImport.Size = new System.Drawing.Size(130, 50);
            this.btn_RefreshDataImport.TabIndex = 2;
            this.btn_RefreshDataImport.Text = "Tải lại dữ liệu";
            this.btn_RefreshDataImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RefreshDataImport.UseVisualStyleBackColor = true;
            this.btn_RefreshDataImport.Click += new System.EventHandler(this.btn_RefreshDataImport_Click);
            // 
            // btn_importProduct
            // 
            this.btn_importProduct.Image = ((System.Drawing.Image)(resources.GetObject("btn_importProduct.Image")));
            this.btn_importProduct.Location = new System.Drawing.Point(610, 405);
            this.btn_importProduct.Name = "btn_importProduct";
            this.btn_importProduct.Size = new System.Drawing.Size(130, 50);
            this.btn_importProduct.TabIndex = 1;
            this.btn_importProduct.Text = "Nhập hàng";
            this.btn_importProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_importProduct.UseVisualStyleBackColor = true;
            this.btn_importProduct.Click += new System.EventHandler(this.btn_importProduct_Click);
            // 
            // importGridControl
            // 
            this.importGridControl.AllowUserToAddRows = false;
            this.importGridControl.AllowUserToDeleteRows = false;
            this.importGridControl.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.importGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importGridControl.Location = new System.Drawing.Point(4, 55);
            this.importGridControl.MultiSelect = false;
            this.importGridControl.Name = "importGridControl";
            this.importGridControl.ReadOnly = true;
            this.importGridControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.importGridControl.Size = new System.Drawing.Size(946, 340);
            this.importGridControl.TabIndex = 0;
            // 
            // tabNaviPage_GiaoHang
            // 
            this.tabNaviPage_GiaoHang.Caption = "NHÂN VIÊN GIAO HÀNG";
            this.tabNaviPage_GiaoHang.Controls.Add(this.btn_ClearShipper);
            this.tabNaviPage_GiaoHang.Controls.Add(this.btn_SearchShipper);
            this.tabNaviPage_GiaoHang.Controls.Add(this.txtB_SearchShipper);
            this.tabNaviPage_GiaoHang.Controls.Add(this.btn_RefreshDataShipper);
            this.tabNaviPage_GiaoHang.Controls.Add(this.btn_EditShipper);
            this.tabNaviPage_GiaoHang.Controls.Add(this.btn_InsertShipper);
            this.tabNaviPage_GiaoHang.Controls.Add(this.shippersGridControl);
            this.tabNaviPage_GiaoHang.Name = "tabNaviPage_GiaoHang";
            this.tabNaviPage_GiaoHang.Size = new System.Drawing.Size(979, 554);
            this.tabNaviPage_GiaoHang.VisibleChanged += new System.EventHandler(this.tabNaviPage_Shipper_VisibleChanged);
            // 
            // btn_ClearShipper
            // 
            this.btn_ClearShipper.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClearShipper.Image")));
            this.btn_ClearShipper.Location = new System.Drawing.Point(516, 15);
            this.btn_ClearShipper.Name = "btn_ClearShipper";
            this.btn_ClearShipper.Size = new System.Drawing.Size(60, 30);
            this.btn_ClearShipper.TabIndex = 6;
            this.btn_ClearShipper.Text = "Xóa";
            this.btn_ClearShipper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ClearShipper.UseVisualStyleBackColor = true;
            this.btn_ClearShipper.Click += new System.EventHandler(this.btn_ClearShipper_Click);
            // 
            // btn_SearchShipper
            // 
            this.btn_SearchShipper.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchShipper.Image")));
            this.btn_SearchShipper.Location = new System.Drawing.Point(410, 15);
            this.btn_SearchShipper.Name = "btn_SearchShipper";
            this.btn_SearchShipper.Size = new System.Drawing.Size(100, 30);
            this.btn_SearchShipper.TabIndex = 5;
            this.btn_SearchShipper.Text = "Tìm kiếm";
            this.btn_SearchShipper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SearchShipper.UseVisualStyleBackColor = true;
            this.btn_SearchShipper.Click += new System.EventHandler(this.btn_SearchShipper_Click);
            // 
            // txtB_SearchShipper
            // 
            this.txtB_SearchShipper.Location = new System.Drawing.Point(4, 21);
            this.txtB_SearchShipper.Name = "txtB_SearchShipper";
            this.txtB_SearchShipper.Size = new System.Drawing.Size(400, 20);
            this.txtB_SearchShipper.TabIndex = 4;
            this.txtB_SearchShipper.Text = "Tìm kiếm theo mã/tên nhân viên, email, điiện thoại";
            this.txtB_SearchShipper.Enter += new System.EventHandler(this.txtB_SearchShipper_Enter);
            this.txtB_SearchShipper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_SearchShipper_KeyPress);
            // 
            // btn_RefreshDataShipper
            // 
            this.btn_RefreshDataShipper.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshDataShipper.Image")));
            this.btn_RefreshDataShipper.Location = new System.Drawing.Point(410, 405);
            this.btn_RefreshDataShipper.Name = "btn_RefreshDataShipper";
            this.btn_RefreshDataShipper.Size = new System.Drawing.Size(130, 50);
            this.btn_RefreshDataShipper.TabIndex = 3;
            this.btn_RefreshDataShipper.Text = "Tải lại dữ liệu";
            this.btn_RefreshDataShipper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RefreshDataShipper.UseVisualStyleBackColor = true;
            this.btn_RefreshDataShipper.Click += new System.EventHandler(this.btn_RefreshDataShipper_Click);
            // 
            // btn_EditShipper
            // 
            this.btn_EditShipper.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditShipper.Image")));
            this.btn_EditShipper.Location = new System.Drawing.Point(760, 405);
            this.btn_EditShipper.Name = "btn_EditShipper";
            this.btn_EditShipper.Size = new System.Drawing.Size(180, 50);
            this.btn_EditShipper.TabIndex = 2;
            this.btn_EditShipper.Text = "Thay đổi thông tin";
            this.btn_EditShipper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditShipper.UseVisualStyleBackColor = true;
            this.btn_EditShipper.Click += new System.EventHandler(this.btn_EditShipper_Click);
            // 
            // btn_InsertShipper
            // 
            this.btn_InsertShipper.Image = ((System.Drawing.Image)(resources.GetObject("btn_InsertShipper.Image")));
            this.btn_InsertShipper.Location = new System.Drawing.Point(560, 405);
            this.btn_InsertShipper.Name = "btn_InsertShipper";
            this.btn_InsertShipper.Size = new System.Drawing.Size(180, 50);
            this.btn_InsertShipper.TabIndex = 1;
            this.btn_InsertShipper.Text = "Thêm nhân viên giao hàng";
            this.btn_InsertShipper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_InsertShipper.UseVisualStyleBackColor = true;
            this.btn_InsertShipper.Click += new System.EventHandler(this.btn_InsertShipper_Click);
            // 
            // shippersGridControl
            // 
            this.shippersGridControl.AllowUserToAddRows = false;
            this.shippersGridControl.AllowUserToDeleteRows = false;
            this.shippersGridControl.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.shippersGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shippersGridControl.Location = new System.Drawing.Point(4, 55);
            this.shippersGridControl.MultiSelect = false;
            this.shippersGridControl.Name = "shippersGridControl";
            this.shippersGridControl.ReadOnly = true;
            this.shippersGridControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.shippersGridControl.Size = new System.Drawing.Size(946, 340);
            this.shippersGridControl.TabIndex = 0;
            // 
            // tabNaviPage_LoaiSanPham
            // 
            this.tabNaviPage_LoaiSanPham.Caption = "LOẠI SẢN PHẨM";
            this.tabNaviPage_LoaiSanPham.Controls.Add(this.btn_ClearProductType);
            this.tabNaviPage_LoaiSanPham.Controls.Add(this.btn_SearchProductType);
            this.tabNaviPage_LoaiSanPham.Controls.Add(this.txtB_SearchProductType);
            this.tabNaviPage_LoaiSanPham.Controls.Add(this.btn_RefreshDataProductType);
            this.tabNaviPage_LoaiSanPham.Controls.Add(this.btn_EditProductType);
            this.tabNaviPage_LoaiSanPham.Controls.Add(this.btn_InsertProductType);
            this.tabNaviPage_LoaiSanPham.Controls.Add(this.productTypeGridControl);
            this.tabNaviPage_LoaiSanPham.Name = "tabNaviPage_LoaiSanPham";
            this.tabNaviPage_LoaiSanPham.Size = new System.Drawing.Size(979, 554);
            this.tabNaviPage_LoaiSanPham.VisibleChanged += new System.EventHandler(this.tabNaviPage_ProductType_VisibleChanged);
            // 
            // btn_ClearProductType
            // 
            this.btn_ClearProductType.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClearProductType.Image")));
            this.btn_ClearProductType.Location = new System.Drawing.Point(516, 15);
            this.btn_ClearProductType.Name = "btn_ClearProductType";
            this.btn_ClearProductType.Size = new System.Drawing.Size(60, 30);
            this.btn_ClearProductType.TabIndex = 6;
            this.btn_ClearProductType.Text = "Xóa";
            this.btn_ClearProductType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ClearProductType.UseVisualStyleBackColor = true;
            this.btn_ClearProductType.Click += new System.EventHandler(this.btn_ClearProductType_Click);
            // 
            // btn_SearchProductType
            // 
            this.btn_SearchProductType.Image = ((System.Drawing.Image)(resources.GetObject("btn_SearchProductType.Image")));
            this.btn_SearchProductType.Location = new System.Drawing.Point(410, 15);
            this.btn_SearchProductType.Name = "btn_SearchProductType";
            this.btn_SearchProductType.Size = new System.Drawing.Size(100, 30);
            this.btn_SearchProductType.TabIndex = 5;
            this.btn_SearchProductType.Text = "Tìm kiếm";
            this.btn_SearchProductType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SearchProductType.UseVisualStyleBackColor = true;
            this.btn_SearchProductType.Click += new System.EventHandler(this.btn_SearchProductType_Click);
            // 
            // txtB_SearchProductType
            // 
            this.txtB_SearchProductType.Location = new System.Drawing.Point(4, 21);
            this.txtB_SearchProductType.Name = "txtB_SearchProductType";
            this.txtB_SearchProductType.Size = new System.Drawing.Size(400, 20);
            this.txtB_SearchProductType.TabIndex = 4;
            this.txtB_SearchProductType.Text = "Tìm kiếm theo mã/tên loại sản phẩm";
            this.txtB_SearchProductType.Enter += new System.EventHandler(this.txtB_SearchProductType_Enter);
            this.txtB_SearchProductType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_SearchProductType_KeyPress);
            // 
            // btn_RefreshDataProductType
            // 
            this.btn_RefreshDataProductType.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshDataProductType.Image")));
            this.btn_RefreshDataProductType.Location = new System.Drawing.Point(410, 405);
            this.btn_RefreshDataProductType.Name = "btn_RefreshDataProductType";
            this.btn_RefreshDataProductType.Size = new System.Drawing.Size(130, 50);
            this.btn_RefreshDataProductType.TabIndex = 3;
            this.btn_RefreshDataProductType.Text = "Tải lại dữ liệu";
            this.btn_RefreshDataProductType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RefreshDataProductType.UseVisualStyleBackColor = true;
            this.btn_RefreshDataProductType.Click += new System.EventHandler(this.btn_RefreshDataProductType_Click);
            // 
            // btn_EditProductType
            // 
            this.btn_EditProductType.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditProductType.Image")));
            this.btn_EditProductType.Location = new System.Drawing.Point(760, 405);
            this.btn_EditProductType.Name = "btn_EditProductType";
            this.btn_EditProductType.Size = new System.Drawing.Size(180, 50);
            this.btn_EditProductType.TabIndex = 2;
            this.btn_EditProductType.Text = "Thay đổi thông tin";
            this.btn_EditProductType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditProductType.UseVisualStyleBackColor = true;
            this.btn_EditProductType.Click += new System.EventHandler(this.btn_EditProductType_Click);
            // 
            // btn_InsertProductType
            // 
            this.btn_InsertProductType.Image = ((System.Drawing.Image)(resources.GetObject("btn_InsertProductType.Image")));
            this.btn_InsertProductType.Location = new System.Drawing.Point(560, 405);
            this.btn_InsertProductType.Name = "btn_InsertProductType";
            this.btn_InsertProductType.Size = new System.Drawing.Size(180, 50);
            this.btn_InsertProductType.TabIndex = 1;
            this.btn_InsertProductType.Text = "Thêm loại sản phẩm mới";
            this.btn_InsertProductType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_InsertProductType.UseVisualStyleBackColor = true;
            this.btn_InsertProductType.Click += new System.EventHandler(this.btn_InsertProductType_Click);
            // 
            // productTypeGridControl
            // 
            this.productTypeGridControl.AllowUserToAddRows = false;
            this.productTypeGridControl.AllowUserToDeleteRows = false;
            this.productTypeGridControl.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.productTypeGridControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTypeGridControl.Location = new System.Drawing.Point(4, 55);
            this.productTypeGridControl.MultiSelect = false;
            this.productTypeGridControl.Name = "productTypeGridControl";
            this.productTypeGridControl.ReadOnly = true;
            this.productTypeGridControl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productTypeGridControl.Size = new System.Drawing.Size(946, 340);
            this.productTypeGridControl.TabIndex = 0;
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChangePass.Image")));
            this.btn_ChangePass.Location = new System.Drawing.Point(12, 529);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(180, 50);
            this.btn_ChangePass.TabIndex = 1;
            this.btn_ChangePass.Text = "Thay đổi mật khẩu";
            this.btn_ChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChangePass.UseVisualStyleBackColor = true;
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 602);
            this.Controls.Add(this.btn_ChangePass);
            this.Controls.Add(this.tabPaneMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gạo Ngon và Rẻ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneMainForm)).EndInit();
            this.tabPaneMainForm.ResumeLayout(false);
            this.tabNaviPage_NhaCungCap.ResumeLayout(false);
            this.tabNaviPage_NhaCungCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridControl)).EndInit();
            this.tabNaviPage_SanPham.ResumeLayout(false);
            this.tabNaviPage_SanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            this.tabNaviPage_KhachHang.ResumeLayout(false);
            this.tabNaviPage_KhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridControl)).EndInit();
            this.tabNaviPage_DonHang.ResumeLayout(false);
            this.tabNaviPage_DonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billGridControl)).EndInit();
            this.tabNaviPage_NhapHang.ResumeLayout(false);
            this.tabNaviPage_NhapHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importGridControl)).EndInit();
            this.tabNaviPage_GiaoHang.ResumeLayout(false);
            this.tabNaviPage_GiaoHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shippersGridControl)).EndInit();
            this.tabNaviPage_LoaiSanPham.ResumeLayout(false);
            this.tabNaviPage_LoaiSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPaneMainForm;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_NhaCungCap;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_SanPham;
        private System.Windows.Forms.DataGridView supplierGridControl;
        private System.Windows.Forms.Button btt_EditSupplier;
        private System.Windows.Forms.Button btt_newSupplier;
        private System.Windows.Forms.DataGridView productGridControl;
        private System.Windows.Forms.Button btt_newProduct;
        private System.Windows.Forms.Button btt_EditProduct;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_KhachHang;
        private System.Windows.Forms.DataGridView userGridControl;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_DonHang;
        private System.Windows.Forms.DataGridView billGridControl;
        private System.Windows.Forms.Button btn_newBill;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_NhapHang;
        private System.Windows.Forms.DataGridView importGridControl;
        private System.Windows.Forms.Button btn_importProduct;
        private System.Windows.Forms.Button btn_ChangePass;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_GiaoHang;
        private System.Windows.Forms.Button btn_EditShipper;
        private System.Windows.Forms.Button btn_InsertShipper;
        private System.Windows.Forms.DataGridView shippersGridControl;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNaviPage_LoaiSanPham;
        private System.Windows.Forms.Button btn_EditProductType;
        private System.Windows.Forms.Button btn_InsertProductType;
        private System.Windows.Forms.DataGridView productTypeGridControl;
        private System.Windows.Forms.Button btn_RefreshDataSupplier;
        private System.Windows.Forms.TextBox txtB_SearchProduct;
        private System.Windows.Forms.Button btn_SearchProduct;
        private System.Windows.Forms.TextBox txtB_SearchBill;
        private System.Windows.Forms.Button btn_SearchBill;
        private System.Windows.Forms.Button btn_ClearProduct;
        private System.Windows.Forms.Button btn_RefreshDataImport;
        private System.Windows.Forms.Button btn_RefreshDataProduct;
        private System.Windows.Forms.Button btn_RefreshDataProductType;
        private System.Windows.Forms.Button btn_RefreshDataBIll;
        private System.Windows.Forms.Button btn_RefreshDataShipper;
        private System.Windows.Forms.Button btn_RefreshDataCustomer;
        private System.Windows.Forms.Button btn_ClearProductType;
        private System.Windows.Forms.Button btn_SearchProductType;
        private System.Windows.Forms.TextBox txtB_SearchProductType;
        private System.Windows.Forms.Button btn_clearSupplier;
        private System.Windows.Forms.Button btn_SearchSupplier;
        private System.Windows.Forms.TextBox txtB_SearchSupplier;
        private System.Windows.Forms.Button btn_ClearShipper;
        private System.Windows.Forms.Button btn_SearchShipper;
        private System.Windows.Forms.TextBox txtB_SearchShipper;
        private System.Windows.Forms.Button btn_ClearCustomer;
        private System.Windows.Forms.Button btn_SearchCustomer;
        private System.Windows.Forms.TextBox txtB_SearchCus;
        private System.Windows.Forms.Button btn_ClearImport;
        private System.Windows.Forms.Button btn_SearchImport;
        private System.Windows.Forms.TextBox txtB_SearchImport;
        private System.Windows.Forms.Button btn_ClearBill;
        private System.Windows.Forms.Button btn_EditImportProduct;
    }
}