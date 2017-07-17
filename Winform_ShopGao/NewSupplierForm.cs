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
using DAO;
using DevExpress.Utils.Base;
using ValueObject;

namespace Winform_ShopGao
{
    public partial class NewSupplierForm : Form
    {
        private readonly bool _isUpdate;
        private readonly int _rowId;
        public Form RefToFormMain { get; set; }

        private readonly SupplierBusinessLogic _supplierBusinessLogic;

        public NewSupplierForm(int? rowId = null)
        {
            InitializeComponent();
            _supplierBusinessLogic = new SupplierBusinessLogic();
            if (rowId == null) return;
            btn_themNCC.Text = @"Cập nhật thay đổi";
            _isUpdate = true;
            _rowId = (int) rowId;

            var supplier = _supplierBusinessLogic.GetDetailSupplier(_rowId);
            txtB_TenNCC.Text = supplier.Name;
            txtB_DiaChiNCC.Text = supplier.Address;
            txtB_emailNCC.Text = supplier.Email;
            txtB_SđtNCC.Text = supplier.Phone;
        }

        private void btn_themNCC_Click(object sender, EventArgs e)
        {
            var name = txtB_TenNCC.Text.Trim();
            var email = txtB_emailNCC.Text.Trim();
            var phone = txtB_SđtNCC.Text.Trim();
            var addr = txtB_DiaChiNCC.Text.Trim();
            if (name == "" || email == "" || phone == "" || addr == "")
            {
                MessageBox.Show("Xin điền đầy đủ thông tin trước khi thực hiện thao tác khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var supplierValueObject = new SupplierValueObject(_isUpdate ? _rowId: 0, name, addr, email, phone);

            var success = _isUpdate ? _supplierBusinessLogic.UpdateSupplier(supplierValueObject) : _supplierBusinessLogic.CreateSupplier(supplierValueObject);

            if (success)
            {
                MessageBox.Show("Cật nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có gì đó không đúng, có thể dữ liệu đã có trong cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btn_exitNCC_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }
        
    }
}
