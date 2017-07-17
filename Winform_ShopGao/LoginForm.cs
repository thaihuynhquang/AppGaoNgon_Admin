using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using DAO;

namespace Winform_ShopGao
{
    public partial class LoginForm : Form
    {
        private string username;
        private string password;
        private readonly AdminDataAccessLayer _adminDataAccessLayer;
        public LoginForm()
        {
            InitializeComponent();
            _adminDataAccessLayer = new AdminDataAccessLayer();
        }
        
        private void btt_SignIn_Click(object sender, EventArgs e)
        {
            username = txtB_Username.Text.Trim();
            password = txtB_Password.Text.Trim();
            if(username == "" || password == "")
            {
                MessageBox.Show("Vui lòng không để trống tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var  success = _adminDataAccessLayer.Login(username, password);
            if (!success)
            {
                MessageBox.Show("Đăng nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
