using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using BusinessLogicLayer;
using Newtonsoft.Json;
using ValueObject;
using System.Net;

namespace Winform_ShopGao
{
    public partial class NewProductTypeForm : Form
    {
        private string _filePath;
        private bool isUpdateImage = false;
        private bool _isUpdate = false;
        private readonly int _rowId = 0;
        private readonly ProductBusinessLogic _productBusinessLogic;
        private readonly ProductTypeBusinessLogic _productTypeBusinessLogic;
        public Form RefToPreForm { get; set; }

        public NewProductTypeForm(int? rowId = null)
        {
            InitializeComponent();
            _productBusinessLogic = new ProductBusinessLogic();
            _productTypeBusinessLogic = new ProductTypeBusinessLogic();
            if (rowId == null) return;
            btn_InsertProductType.Text = @"Cập nhật";
            _isUpdate = true;
            _rowId = (int)rowId;

            var productTpye = _productTypeBusinessLogic.GetDetailProductType(_rowId);
            txtB_NameProductType.Text = productTpye.Name;

            try
            {
                var image = GetImage(rowId);
                picBox_ImageProductType.Image = image;
                picBox_ImageProductType.SizeMode = PictureBoxSizeMode.CenterImage;
                picBox_ImageProductType.BackColor = Color.AliceBlue;
            }
            catch (Exception e)
            {
                // do not thing
            }
        }

        private void btn_chooseImage_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = @"Browse Text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "Image",
                Filter = @"Picture files (*.jpg)|*.jpg",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            _filePath = openFileDialog1.FileName;
            picBox_ImageProductType.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox_ImageProductType.Image = Image.FromFile(openFileDialog1.FileName);
            picBox_ImageProductType.BackColor = Color.White;
            isUpdateImage = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            RefToPreForm.Show();
            this.Close();
        }

        private void btn_InsertProductType_Click(object sender, EventArgs e)
        {
            var name = txtB_NameProductType.Text.Trim();
            if (name == "")
            {
                MessageBox.Show("Xin điền đầy đủ thông tin trước khi thực hiện thao tác khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var tran = new TransactionScope())
            {
                string fileNameInServer = "";
                if (isUpdateImage)
                {
                    const string actionUrl = "http://localhost:4000/api/upload_image_productType";
                    var fileStream = File.OpenRead(_filePath);
                    HttpContent fileStreamContent = new StreamContent(fileStream);
                    using (var client = new HttpClient())
                    {
                        using (var formData = new MultipartFormDataContent())
                        {
                            formData.Add(fileStreamContent, "image", "image.jpg");
                            var response = client.PostAsync(actionUrl, formData).Result;

                            var receiveStream = response.Content.ReadAsStreamAsync().Result;
                            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                            var message = readStream.ReadToEnd();
                            dynamic stuff = JsonConvert.DeserializeObject(message);
                            string mess = stuff.msg.ToString();
                            if (mess.Equals("Error"))
                            {
                                MessageBox.Show("Có lỗi tải hình lên, xin thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            fileNameInServer = stuff.link.ToString();
                        }
                    }
                }
                else
                {
                    if (_rowId == 0)//thêm mới sản phẩm
                    {
                        MessageBox.Show("Thêm mới loại sản phẩm phải có hình ảnh miêu tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                ProductTypeValueObject productTypeValueObject = new ProductTypeValueObject(_isUpdate ? _rowId : 0, name, fileNameInServer);
                var success = _isUpdate ? _productTypeBusinessLogic.UpdateProductType(productTypeValueObject) : _productTypeBusinessLogic.CreateProductType(productTypeValueObject);
                if (success)
                {
                    MessageBox.Show("Cật nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có gì đó không đúng, có thể dữ liệu đã có trong cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                tran.Complete();
            }
        }
        
        private Image GetImage(int? id)
        {
            var imageFile = _productTypeBusinessLogic.GetImageFileName(id);

            byte[] lnFile;

            var lxRequest = (HttpWebRequest)WebRequest.Create("http://localhost:4000/api/images/type/" + imageFile);
            using (var lxResponse = (HttpWebResponse)lxRequest.GetResponse())
            {
                using (var lxBr = new BinaryReader(lxResponse.GetResponseStream()))
                {
                    using (var lxMs = new MemoryStream())
                    {
                        var lnBuffer = lxBr.ReadBytes(1024);
                        while (lnBuffer.Length > 0)
                        {
                            lxMs.Write(lnBuffer, 0, lnBuffer.Length);
                            lnBuffer = lxBr.ReadBytes(1024);
                        }
                        lnFile = new byte[(int)lxMs.Length];
                        lxMs.Position = 0;
                        lxMs.Read(lnFile, 0, lnFile.Length);
                    }
                }
            }

            using (var lxFs = new FileStream("xxxx.jpg", FileMode.Create))
            {
                lxFs.Write(lnFile, 0, lnFile.Length);
            }
            using (var ms = new MemoryStream(lnFile))
            {
                return Image.FromStream(ms);
            }
        }
        
    }
}
