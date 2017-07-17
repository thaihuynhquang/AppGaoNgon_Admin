using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_ShopGao
{
    public partial class ChangePassForm : Form
    {
        public Form RefToFormMain { get; set; }
        private readonly AdminDataAccessLayer _adminDataAccessLayer;
        string newPass;
        string rePass;

        public ChangePassForm()
        {
            InitializeComponent();
            _adminDataAccessLayer = new AdminDataAccessLayer();
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            newPass = txtB_ChangePass.Text.Trim();
            rePass = txtB_rePass.Text.Trim();
            if(!newPass.Equals(rePass))
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp, hãy kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(newPass == null || newPass == "" || rePass == null || rePass == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var x = _adminDataAccessLayer.ChangePassword(newPass);
            if (!x)
            {
                MessageBox.Show("Xin lỗi, hãy thử lại sau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    RefToFormMain.Show();
                    this.Hide();
                }
            }
        }
    }
}
