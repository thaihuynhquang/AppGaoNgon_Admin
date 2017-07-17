using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using ValueObject;

namespace Winform_ShopGao
{
    public partial class ImportProduct : Form
    {
        private readonly bool _isUpdate = false;
        private readonly int _rowId;
        private int _supplierId;
        private int _productId;
        private readonly SupplierBusinessLogic _supplierBusinessLogic;
        private readonly ProductBusinessLogic _productBusinessLogic;
        private readonly ImportBusinessLogic _importBusinessLogic;

        public ImportProduct(int? rowId = null, int? SupplierId = null, int? ProductId = null)
        {
            InitializeComponent();
            _supplierBusinessLogic = new SupplierBusinessLogic();
            _productBusinessLogic = new ProductBusinessLogic();
            _importBusinessLogic = new ImportBusinessLogic();

            btn_importProduct.Enabled = false;
            txtB_Quantity.Enabled = false;
            txtB_UnitPrice.Enabled = false;

            if (rowId == null || SupplierId == null || ProductId == null) return;
            btn_Unclock.Text = @"Chỉnh sửa";
            _isUpdate = true;
            _rowId = (int)rowId;
            _supplierId = (int)SupplierId;
            _productId = (int)ProductId;

            var supplier = _supplierBusinessLogic.GetDetailSupplier(_supplierId);
            txtB_SupplierName.Text = supplier.Name;
            txtB_SupplierEmail.Text = supplier.Email;
            txtB_SupplierPhone.Text = supplier.Phone;

            var product = _productBusinessLogic.GetProductById(_productId);
            txtB_ProductName.Text = product.Name;
            txtB_ProductPrice.Text = product.Price.ToString();
            txtB_UnitInStock.Text = product.unitInStock.ToString();
            txtB_UnitOnBill.Text = product.unitOnBill.ToString();
        }

        public MainForm RefToFormMain { get; set; }
        
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }

        private void txtB_Quantity_Leave(object sender, EventArgs e)
        {
            uint quantity;
            uint.TryParse(txtB_Quantity.Text.Trim(), out quantity);
            if (quantity == 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void txtB_UnitPrice_Leave(object sender, EventArgs e)
        {
            uint unitPrice;
            uint.TryParse(txtB_UnitPrice.Text.Trim(), out unitPrice);
            if (unitPrice == 0)
            {
                MessageBox.Show("Giá nhập phải là số nguyên không âm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_importProduct_Click(object sender, EventArgs e)
        {
            uint quantity;
            uint.TryParse(txtB_Quantity.Text.Trim(), out quantity);
            if (quantity == 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            uint unitPrice;
            uint.TryParse(txtB_UnitPrice.Text.Trim(), out unitPrice);
            if (unitPrice == 0)
            {
                MessageBox.Show("Giá nhập phải là số nguyên không âm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int supplierId = (int)cmb_ChooseSupplier.SelectedValue;
            int productId = (int)cmb_ChooseProduct.SelectedValue;

            var supplier = _supplierBusinessLogic.GetDetailSupplier(supplierId);
            string supplierName = supplier.Name;

            var product = _productBusinessLogic.GetProductById(productId);
            string productName = product.Name;

            var import = new ImportValueObject(_isUpdate ? _rowId : 0, supplierId, supplierName, productId, productName, quantity, unitPrice, 0);
            var success = _isUpdate ? _importBusinessLogic.UpdateImportProduct(import) : _importBusinessLogic.ImportProduct(import);
            if (success)
            {
                MessageBox.Show("Cật nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                product = _importBusinessLogic.GetUnitInStock(productId);
                if(product.unitInStock != 0)
                {
                    _productBusinessLogic.UpdateUnitInStock(product);
                }
            }
            else
            {
                MessageBox.Show("Có gì đó không đúng, có thể dữ liệu đã có trong cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void cmb_ChooseSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            _supplierId = (int)cmb_ChooseSupplier.SelectedValue;
            var supplier = _supplierBusinessLogic.GetDetailSupplier(_supplierId);
            txtB_SupplierName.Text = supplier.Name;
            txtB_SupplierEmail.Text = supplier.Email;
            txtB_SupplierPhone.Text = supplier.Phone;
        }

        private void cmn_ChooseProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            _productId = (int)cmb_ChooseProduct.SelectedValue;
            var product = _productBusinessLogic.GetProductById(_productId);
            txtB_ProductName.Text = product.Name;
            txtB_ProductPrice.Text = product.Price.ToString();
            txtB_UnitInStock.Text = product.unitInStock.ToString();
            txtB_UnitOnBill.Text = product.unitOnBill.ToString();
        }

        private void btn_Unclock_Click(object sender, EventArgs e)
        {
            // combo box nha cung cap
            cmb_ChooseSupplier.DisplayMember = "name";
            cmb_ChooseSupplier.ValueMember = "id";
            cmb_ChooseSupplier.DataSource = _supplierBusinessLogic.GetallSupplier();
            
            // combo box san pham
            cmb_ChooseProduct.DisplayMember = "name";
            cmb_ChooseProduct.ValueMember = "id";
            cmb_ChooseProduct.DataSource = _productBusinessLogic.GetAllProduct();

            btn_importProduct.Enabled = true;
            txtB_Quantity.Enabled = true;
            txtB_UnitPrice.Enabled = true;
        }

        
    }
}
