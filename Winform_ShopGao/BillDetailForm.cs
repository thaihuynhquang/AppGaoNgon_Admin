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
    public partial class BillDetailForm : Form
    {
        private readonly BillBusinessLogic _billBusinessLogic;
        private readonly BillDetailBusinessLogicLayer _billDetailBusinessLogicLayer;
        private readonly ShipperBussinessLogic _shipperBussinessLogic;
        private readonly UserBusinessLogic _userBusinessLogic;
        private readonly ProductBusinessLogic _productBusinessLogic;
        private int _BillId;
        private int _CusId;
        private int _ShipperId;
        private BillValueObject bill = null;
        private ShipperValueObject shipper = null;
        private UserValueObject customer = null;

        public Form RefToFormMain { get; set; }

        public BillDetailForm(int? BillId = null, int? CusId = null, int? ShipperId = null)
        {
            InitializeComponent();
            _billBusinessLogic = new BillBusinessLogic();
            _billDetailBusinessLogicLayer = new BillDetailBusinessLogicLayer();
            _shipperBussinessLogic = new ShipperBussinessLogic();
            _userBusinessLogic = new UserBusinessLogic();
            _productBusinessLogic = new ProductBusinessLogic();

            if (BillId == null || CusId == null || ShipperId == null) return;
            _BillId = (int)BillId;
            _CusId = (int)CusId;
            _ShipperId = (int)ShipperId;

            btn_UpdateNote.Enabled = false;
            btn_UpdateShipperForBill.Enabled = false;
            rTxtB_Note.Enabled = false;

            bill = _billBusinessLogic.GetBillById(_BillId);
            txtB_BillId.Text = bill.Id.ToString();
            txtB_BillStatus.Text = bill.Status;
            txtB_DateOrder.Text = bill.DateOrder.ToString();
            txtB_TotalMoney.Text = bill.Total.ToString();
            txtB_Addr.Text = bill.Addr;
            txtB_Dis.Text = bill.Dis;
            txtB_city.Text = bill.City;
            rTxtB_Note.Text = bill.Note;

            customer = _userBusinessLogic.GetDetailUser(_CusId);
            txtB_NameCus.Text = customer.Name;

            GridView_BillDetails.DataSource = _billDetailBusinessLogicLayer.GetBillDetailsByBillId(_BillId);

            
            if (_ShipperId == 0) return;

            shipper = _shipperBussinessLogic.GetDetailShipper(_ShipperId);
            txtB_ShiperName.Text = shipper.Name;
            txtB_ShipperEmail.Text = shipper.Email;
            txtB_ShipperPhone.Text = shipper.Phone;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            RefToFormMain.Show();
            this.Close();
        }

        private void btn_UpdateNote_Click(object sender, EventArgs e)
        {
            var success = _billBusinessLogic.UpdateBillNote(_BillId, rTxtB_Note.Text);

            if (success)
            {
                MessageBox.Show("Cật nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xin lỗi, hãy thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Note_Click(object sender, EventArgs e)
        {
            btn_UpdateNote.Enabled = true;
            rTxtB_Note.Enabled = true;
        }

        private void btn_ChangeBillStatus_Click(object sender, EventArgs e)
        {
            int pending = 0;
            int complete = 1;
            var action = MessageBox.Show("Đơn hàng đã được xử lý xong?", "Thay đổi trạng thái đơn hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (action == DialogResult.Yes)
            {
                var updated = _billBusinessLogic.UpdateBillStatus(_BillId, complete);
                if(updated)
                {
                    MessageBox.Show("Đơn hàng đã hoàn thành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bill = _billBusinessLogic.GetBillById(_BillId);
                    txtB_BillStatus.Text = bill.Status;

                    var billDetails = _billDetailBusinessLogicLayer.GetBillDetailsByBillId(_BillId);
                    billDetails.ForEach(billDetail =>
                    {
                        var product = _productBusinessLogic.GetProductById(billDetail.Id);
                        var unitOnBill = (long)product.unitOnBill;
                        var unitInStock = (long)product.unitInStock;
                        unitInStock = unitInStock - billDetail.Quantity;
                        unitOnBill = unitOnBill - billDetail.Quantity;

                        if (unitInStock < 0 || unitOnBill < 0) return;
                        product.unitInStock = (uint)unitInStock;
                        product.unitOnBill = (uint)unitOnBill;
                        _productBusinessLogic.UpdateUnitInStock(product);
                        _productBusinessLogic.UpdateUnitOnBill(product);

                    });
                }
                else
                {
                    MessageBox.Show("Có lỗi, xin hãy thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            if (action == DialogResult.No)
            {
                var updated = _billBusinessLogic.UpdateBillStatus(_BillId, pending);
                if(updated)
                {
                    MessageBox.Show("Trạng thái đơn hàng đang chờ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bill = _billBusinessLogic.GetBillById(_BillId);
                    txtB_BillStatus.Text = bill.Status;

                    var billDetails = _billDetailBusinessLogicLayer.GetBillDetailsByBillId(_BillId);
                    billDetails.ForEach(billDetail =>
                    {
                        var product = _productBusinessLogic.GetProductById(billDetail.Id);
                        var unitOnBill = (long)product.unitOnBill;
                        var unitInStock = (long)product.unitInStock;
                        unitInStock = unitInStock + billDetail.Quantity;
                        unitOnBill = unitOnBill + billDetail.Quantity;
                        
                        product.unitInStock = (uint)unitInStock;
                        product.unitOnBill = (uint)unitOnBill;
                        _productBusinessLogic.UpdateUnitInStock(product);
                        _productBusinessLogic.UpdateUnitOnBill(product);

                    });
                }
                else
                {
                    MessageBox.Show("Có lỗi, xin hãy thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        private void cmb_Shipper_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ShipperId = (int)cmb_Shipper.SelectedValue;
            shipper = _shipperBussinessLogic.GetDetailShipper(_ShipperId);
            txtB_ShiperName.Text = shipper.Name;
            txtB_ShipperEmail.Text = shipper.Email;
            txtB_ShipperPhone.Text = shipper.Phone;
        }

        private void btn_UpdateShipperForBill_Click(object sender, EventArgs e)
        {
            _ShipperId = (int)cmb_Shipper.SelectedValue;
            var action = MessageBox.Show("Chọn " + txtB_ShiperName.Text + " giao hàng cho đơn hàng này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(action == DialogResult.OK)
            {
                var updated = _billBusinessLogic.UpdateBillShipper(_BillId, _ShipperId);
                if (updated)
                {
                    MessageBox.Show("Cật nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có lỗi, xin thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Shipper_Click(object sender, EventArgs e)
        {
            cmb_Shipper.DisplayMember = "Name";
            cmb_Shipper.ValueMember = "Id";
            cmb_Shipper.DataSource = _shipperBussinessLogic.GetAllShippers();
            btn_UpdateShipperForBill.Enabled = true;
        }
    }
}
