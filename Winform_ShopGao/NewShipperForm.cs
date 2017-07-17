using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueObject;

namespace Winform_ShopGao
{
    public partial class NewShipperForm : Form
    {
        private readonly bool _isUpdate = false;
        private readonly int _rowId;
        public Form RefToFormMain { get; set; }

        private readonly ShipperBussinessLogic _shipperBussinessLogic;

        public NewShipperForm(int? rowId = null)
        {
            InitializeComponent();
            _shipperBussinessLogic = new ShipperBussinessLogic();
            if (rowId == null) return;
            btn_InsertShipper.Text = @"Cập nhật";
            _isUpdate = true;
            _rowId = (int)rowId;

            var shipper = _shipperBussinessLogic.GetDetailShipper(_rowId);
            txtB_NameShipper.Text = shipper.Name;
            txtB_EmailShipper.Text = shipper.Email;
            txtB_PhoneShipper.Text = shipper.Phone;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }

        private void btn_InsertShipper_Click(object sender, EventArgs e)
        {
            var name = txtB_NameShipper.Text.Trim();
            var email = txtB_EmailShipper.Text.Trim();
            var phone = txtB_PhoneShipper.Text.Trim();

            if (name == "" || email == "" || phone == "")
            {
                MessageBox.Show("Xin điền đầy đủ thông tin trước khi thực hiện thao tác khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var shipperValueObject = new ShipperValueObject(_isUpdate ? _rowId : 0, name, email, phone);
            var success = _isUpdate ? _shipperBussinessLogic.UpdateSupplier(shipperValueObject) : _shipperBussinessLogic.CreateShipper(shipperValueObject);

            if (success)
            {
                MessageBox.Show("Cật nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có gì đó không đúng, có thể dữ liệu đã có trong cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
