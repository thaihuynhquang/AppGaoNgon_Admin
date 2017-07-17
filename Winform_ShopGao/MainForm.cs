using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Winform_ShopGao
{
    public partial class MainForm : Form
    {
        private readonly SupplierBusinessLogic _supplierBusinessLogic;
        private readonly ProductBusinessLogic _productBusinessLogic;
        private readonly UserBusinessLogic _userBusinessLogic;
        private readonly BillBusinessLogic _billBusinessLogic;
        private readonly ShipperBussinessLogic _shipperBusinessLogic;
        private readonly ProductTypeBusinessLogic _productTypeBusinessLogic;
        private readonly ImportBusinessLogic _importBusinessLogic;

        public MainForm()
        {
            InitializeComponent();
            _supplierBusinessLogic = new SupplierBusinessLogic();
            _productBusinessLogic = new ProductBusinessLogic();
            _userBusinessLogic = new UserBusinessLogic();
            _billBusinessLogic = new BillBusinessLogic();
            _shipperBusinessLogic = new ShipperBussinessLogic();
            _productTypeBusinessLogic = new ProductTypeBusinessLogic();
            _importBusinessLogic = new ImportBusinessLogic();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        

        //xử lý phần nhà cung cấp
        private void MainForm_Load(object sender, EventArgs e)
        {
            tabPaneMainForm.SelectedPage = tabNaviPage_NhaCungCap;
            var suppliers = _supplierBusinessLogic.GetallSupplier();
            supplierGridControl.DataSource = suppliers.ToList();
            supplierGridControl.Refresh();
        }

        private void tabNaviPage_NhaCungCap_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_NhaCungCap) return;
            supplierGridControl.DataSource = _supplierBusinessLogic.GetallSupplier();
        }

        private void newSupp_Click(object sender, EventArgs e)
        {
            var newSupplierForm = new NewSupplierForm { RefToFormMain = this };
            newSupplierForm.Show();
        }

        private void btt_EditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                var row = supplierGridControl.SelectedRows;
                var cells = row[0].Cells;
                var newSupplierForm = new NewSupplierForm(int.Parse(cells[0].Value.ToString())) { RefToFormMain = this };
                newSupplierForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn một dòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible) return;
            if (tabPaneMainForm.SelectedPage == tabNaviPage_NhaCungCap)
            {
                supplierGridControl.DataSource = _supplierBusinessLogic.GetallSupplier();
            }
        }

        //Xử lý phần sản phẩm
        private void tabNaviPage_SanPham_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_SanPham) return;
            productGridControl.DataSource = _productBusinessLogic.GetAllProduct();
        }
        
        private void btt_newProduct_Click(object sender, EventArgs e)
        {
            var newProductForm = new NewProductForm { RefToFormMain = this };
            newProductForm.Show();
        }

        private void btt_EditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var row = productGridControl.SelectedRows;
                var cells = row[0].Cells;
                var newSupplierForm = new NewProductForm(int.Parse(cells[0].Value.ToString())) { RefToFormMain = this };
                newSupplierForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn một dòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabNaviPage_KhachHang_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_KhachHang) return;
            userGridControl.DataSource = _userBusinessLogic.GetAllUser();
        }

        //xử lý phần đơn hàng
        private void tabNaviPage_DonHang_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_DonHang) return;
            billGridControl.DataSource = _billBusinessLogic.GetAllBill();
        }

        private void btn_newBill_Click(object sender, EventArgs e)
        {
            try
            {
                var row = billGridControl.SelectedRows;
                var cells = row[0].Cells;
                var billDetailForm = new BillDetailForm(int.Parse(cells[0].Value.ToString()), int.Parse(cells[1].Value.ToString()), int.Parse(cells[10].Value.ToString())) { RefToFormMain = this };
                billDetailForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn một dòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Xử lý phần nhập hàng
        private void tabNaviPage_NhapHang_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_NhapHang) return;
            importGridControl.DataSource = _importBusinessLogic.GetAllImportProducts();
        }

        private void btn_importProduct_Click(object sender, EventArgs e)
        {
            var importProduct = new ImportProduct { RefToFormMain = this };
            importProduct.Show();
        }
        
        private void btn_EditImportProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var row = importGridControl.SelectedRows;
                var cells = row[0].Cells;
                var importProduct = new ImportProduct(int.Parse(cells[0].Value.ToString()), int.Parse(cells[1].Value.ToString()), int.Parse(cells[3].Value.ToString())) { RefToFormMain = this };
                importProduct.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn một dòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //xử lý sự kiện click btn thay đổi password admin
        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            var changePassForm = new ChangePassForm { RefToFormMain = this };
            changePassForm.Show();
        }

        //xử lý phần nhân viên giao hàng
        private void tabNaviPage_Shipper_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_GiaoHang) return;
            shippersGridControl.DataSource = _shipperBusinessLogic.GetAllShippers();
        }

        private void btn_InsertShipper_Click(object sender, EventArgs e)
        {
            var newShipperForm = new NewShipperForm { RefToFormMain = this };
            newShipperForm.Show();
        }

        private void btn_EditShipper_Click(object sender, EventArgs e)
        {
            try
            {
                var row = shippersGridControl.SelectedRows;
                var cells = row[0].Cells;
                var newShipperForm = new NewShipperForm(int.Parse(cells[0].Value.ToString())) { RefToFormMain = this };
                newShipperForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn một dòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //xử lý phần loại sản phẩm
        private void tabNaviPage_ProductType_VisibleChanged(object sender, EventArgs e)
        {
            if (tabPaneMainForm.SelectedPage != tabNaviPage_LoaiSanPham) return;
            productTypeGridControl.DataSource = _productTypeBusinessLogic.GetAllProductTypes();
        }

        private void btn_InsertProductType_Click(object sender, EventArgs e)
        {
            var newProductType = new NewProductTypeForm { RefToPreForm = this };
            newProductType.Show();
        }

        private void btn_EditProductType_Click(object sender, EventArgs e)
        {
            try
            {
                var row = productTypeGridControl.SelectedRows;
                var cells = row[0].Cells;
                var newProductType = new NewProductTypeForm(int.Parse(cells[0].Value.ToString())) { RefToPreForm = this };
                newProductType.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn một dòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        //xử lý tải lại dữ liệu
        private void btn_RefreshDataImport_Click(object sender, EventArgs e)
        {
            importGridControl.DataSource = _importBusinessLogic.GetAllImportProducts();
        }

        private void btn_RefreshDataSupplier_Click(object sender, EventArgs e)
        {
            supplierGridControl.DataSource = _supplierBusinessLogic.GetallSupplier();
        }

        private void btn_RefreshDataProduct_Click(object sender, EventArgs e)
        {
            productGridControl.DataSource = _productBusinessLogic.GetAllProduct();
        }

        private void btn_RefreshDataProductType_Click(object sender, EventArgs e)
        {
            productTypeGridControl.DataSource = _productTypeBusinessLogic.GetAllProductTypes();
        }

        private void btn_RefreshDataBIll_Click(object sender, EventArgs e)
        {
            billGridControl.DataSource = _billBusinessLogic.GetAllBill();
        }

        private void btn_RefreshDataShipper_Click(object sender, EventArgs e)
        {
            shippersGridControl.DataSource = _shipperBusinessLogic.GetAllShippers();
        }

        private void btn_RefreshDataCustomer_Click(object sender, EventArgs e)
        {
            userGridControl.DataSource = _userBusinessLogic.GetAllUser();
        }


        //xử lý tìm kiếm thông tin sản phẩm
        private void btn_SearchProduct_Click(object sender, EventArgs e)
        {
            List<string> column = new List<string> { "id", "Name", "id_type" };
            String value = txtB_SearchProduct.Text.Trim();
            productGridControl.DataSource = _productBusinessLogic.Search(column, value);
        }

        private void txtB_SearchProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                List<string> column = new List<string> { "id", "Name", "id_type" };
                String value = txtB_SearchProduct.Text.Trim();
                productGridControl.DataSource = _productBusinessLogic.Search(column, value);
            }
            
        }

        private void txtB_SearchProduct_Enter(object sender, EventArgs e)
        {
            txtB_SearchProduct.Text = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtB_SearchProduct.Text = "";
        }

        //xử lý tìm kiếm thông tin đơn hàng
        private void btn_SearchBill_Click(object sender, EventArgs e)
        {
            List<string> column = new List<string> { "id", "id_customer", "id_shipper" };
            String value = txtB_SearchBill.Text.Trim();
            billGridControl.DataSource = _billBusinessLogic.Search(column, value);
        }

        private void txtB_SearchBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                List<string> column = new List<string> { "id", "id_customer", "id_shipper" };
                String value = txtB_SearchBill.Text.Trim();
                billGridControl.DataSource = _billBusinessLogic.Search(column, value);
            }
        }

        private void txtB_SearchBill_Enter(object sender, EventArgs e)
        {
            txtB_SearchBill.Text = "";
        }

        private void btn_ClearBill_Click(object sender, EventArgs e)
        {
            txtB_SearchBill.Text = "";
        }

        //xử lý tìm kiếm thông tin loại sản phẩm
        private void btn_SearchProductType_Click(object sender, EventArgs e)
        {
            List<string> column = new List<string> { "id", "Name" };
            String value = txtB_SearchProductType.Text.Trim();
            productTypeGridControl.DataSource = _productTypeBusinessLogic.Search(column, value);
        }

        private void txtB_SearchProductType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                List<string> column = new List<string> { "id", "Name" };
                String value = txtB_SearchProductType.Text.Trim();
                productTypeGridControl.DataSource = _productTypeBusinessLogic.Search(column, value);
            }
            
        }

        private void txtB_SearchProductType_Enter(object sender, EventArgs e)
        {
            txtB_SearchProductType.Text = "";
        }

        private void btn_ClearProductType_Click(object sender, EventArgs e)
        {
            txtB_SearchProductType.Text = "";
        }


        //Xử lý tìm kiếm thông tin nhà cung cấp
        private void btn_SearchSupplier_Click(object sender, EventArgs e)
        {
            List<string> column = new List<string> { "id", "Name", "email", "phone", "addr" };
            String value = txtB_SearchSupplier.Text.Trim();
            supplierGridControl.DataSource = _supplierBusinessLogic.Search(column, value);
        }

        private void txtB_SearchSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                List<string> column = new List<string> { "id", "Name", "email", "phone", "addr" };
                String value = txtB_SearchSupplier.Text.Trim();
                supplierGridControl.DataSource = _supplierBusinessLogic.Search(column, value);
            }
        }

        private void txtB_SearchSupplier_Enter(object sender, EventArgs e)
        {
            txtB_SearchSupplier.Text = "";
        }

        private void btn_clearSupplier_Click(object sender, EventArgs e)
        {
            txtB_SearchSupplier.Text = "";
        }

        //xử lý tìm kiếm thông tin nhân viên giao hàng
        private void btn_SearchShipper_Click(object sender, EventArgs e)
        {
            List<string> column = new List<string> { "id", "name", "email", "phone" };
            String value = txtB_SearchShipper.Text.Trim();
            shippersGridControl.DataSource = _shipperBusinessLogic.Search(column, value);
        }

        private void txtB_SearchShipper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                List<string> column = new List<string> { "id", "name", "email", "phone" };
                String value = txtB_SearchShipper.Text.Trim();
                shippersGridControl.DataSource = _shipperBusinessLogic.Search(column, value);
            }
        }

        private void txtB_SearchShipper_Enter(object sender, EventArgs e)
        {
            txtB_SearchShipper.Text = "";
        }

        private void btn_ClearShipper_Click(object sender, EventArgs e)
        {
            txtB_SearchShipper.Text = "";
        }

        //xử lý tìm kiếm thông tin khách hàng
        private void btn_SearchCustomer_Click(object sender, EventArgs e)
        {
            List<string> column = new List<string> { "id", "name", "email", "phone" };
            String value = txtB_SearchCus.Text.Trim();
            userGridControl.DataSource = _userBusinessLogic.Search(column, value);
        }

        private void txtB_SearchCus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                List<string> column = new List<string> { "id", "name", "email", "phone" };
                String value = txtB_SearchCus.Text.Trim();
                userGridControl.DataSource = _userBusinessLogic.Search(column, value);
            }
        }

        private void txtB_SearchCus_Enter(object sender, EventArgs e)
        {
            txtB_SearchCus.Text = "";
        }

        private void btn_ClearCustomer_Click(object sender, EventArgs e)
        {
            txtB_SearchCus.Text = "";
        }

        //xử lý tìm kiếm thông tin nhập hàng
        private void btn_SearchImport_Click(object sender, EventArgs e)
        {
            List<string> column = new List<string> { "supplierId", "supplierName", "productId", "productName" };
            String value = txtB_SearchImport.Text.Trim();
            importGridControl.DataSource = _importBusinessLogic.Search(column, value);
        }

        private void txtB_SearchImport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                List<string> column = new List<string> { "supplierId", "supplierName", "productId", "productName" };
                String value = txtB_SearchImport.Text.Trim();
                importGridControl.DataSource = _importBusinessLogic.Search(column, value);
            }
        }

        private void txtB_SearchImport_Enter(object sender, EventArgs e)
        {
            txtB_SearchImport.Text = "";
        }

        private void btn_ClearImport_Click(object sender, EventArgs e)
        {
            txtB_SearchImport.Text = "";
        }

        
    }
}
