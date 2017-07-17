namespace Winform_ShopGao
{
    partial class BillDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillDetailForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_UpdateNote = new System.Windows.Forms.Button();
            this.rTxtB_Note = new System.Windows.Forms.RichTextBox();
            this.txtB_city = new System.Windows.Forms.TextBox();
            this.txtB_Dis = new System.Windows.Forms.TextBox();
            this.txtB_Addr = new System.Windows.Forms.TextBox();
            this.txtB_NameCus = new System.Windows.Forms.TextBox();
            this.txtB_TotalMoney = new System.Windows.Forms.TextBox();
            this.txtB_DateOrder = new System.Windows.Forms.TextBox();
            this.txtB_BillStatus = new System.Windows.Forms.TextBox();
            this.txtB_BillId = new System.Windows.Forms.TextBox();
            this.lb_Note = new System.Windows.Forms.Label();
            this.lb_TotalMoney = new System.Windows.Forms.Label();
            this.lb_city = new System.Windows.Forms.Label();
            this.lb_Dis = new System.Windows.Forms.Label();
            this.lb_Addr = new System.Windows.Forms.Label();
            this.lb_NameCus = new System.Windows.Forms.Label();
            this.lb_DateOrder = new System.Windows.Forms.Label();
            this.lb_BillStatus = new System.Windows.Forms.Label();
            this.lb_BillID = new System.Windows.Forms.Label();
            this.lb_InfoBill = new System.Windows.Forms.Label();
            this.GridView_BillDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_UpdateShipperForBill = new System.Windows.Forms.Button();
            this.txtB_ShipperPhone = new System.Windows.Forms.TextBox();
            this.txtB_ShipperEmail = new System.Windows.Forms.TextBox();
            this.txtB_ShiperName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Shipper = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_ShipperEmail = new System.Windows.Forms.Label();
            this.lb_ShipperPhone = new System.Windows.Forms.Label();
            this.lb_ShipperName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Note = new System.Windows.Forms.Button();
            this.btn_ChangeBillStatus = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Shipper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BillDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Location = new System.Drawing.Point(1, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer1.Panel2.Controls.Add(this.btn_UpdateShipperForBill);
            this.splitContainer1.Panel2.Controls.Add(this.txtB_ShipperPhone);
            this.splitContainer1.Panel2.Controls.Add(this.txtB_ShipperEmail);
            this.splitContainer1.Panel2.Controls.Add(this.txtB_ShiperName);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.cmb_Shipper);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.lb_ShipperEmail);
            this.splitContainer1.Panel2.Controls.Add(this.lb_ShipperPhone);
            this.splitContainer1.Panel2.Controls.Add(this.lb_ShipperName);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1250, 384);
            this.splitContainer1.SplitterDistance = 1006;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer2.Panel1.Controls.Add(this.btn_UpdateNote);
            this.splitContainer2.Panel1.Controls.Add(this.rTxtB_Note);
            this.splitContainer2.Panel1.Controls.Add(this.txtB_city);
            this.splitContainer2.Panel1.Controls.Add(this.txtB_Dis);
            this.splitContainer2.Panel1.Controls.Add(this.txtB_Addr);
            this.splitContainer2.Panel1.Controls.Add(this.txtB_NameCus);
            this.splitContainer2.Panel1.Controls.Add(this.txtB_TotalMoney);
            this.splitContainer2.Panel1.Controls.Add(this.txtB_DateOrder);
            this.splitContainer2.Panel1.Controls.Add(this.txtB_BillStatus);
            this.splitContainer2.Panel1.Controls.Add(this.txtB_BillId);
            this.splitContainer2.Panel1.Controls.Add(this.lb_Note);
            this.splitContainer2.Panel1.Controls.Add(this.lb_TotalMoney);
            this.splitContainer2.Panel1.Controls.Add(this.lb_city);
            this.splitContainer2.Panel1.Controls.Add(this.lb_Dis);
            this.splitContainer2.Panel1.Controls.Add(this.lb_Addr);
            this.splitContainer2.Panel1.Controls.Add(this.lb_NameCus);
            this.splitContainer2.Panel1.Controls.Add(this.lb_DateOrder);
            this.splitContainer2.Panel1.Controls.Add(this.lb_BillStatus);
            this.splitContainer2.Panel1.Controls.Add(this.lb_BillID);
            this.splitContainer2.Panel1.Controls.Add(this.lb_InfoBill);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer2.Panel2.Controls.Add(this.GridView_BillDetails);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(1006, 384);
            this.splitContainer2.SplitterDistance = 587;
            this.splitContainer2.TabIndex = 0;
            // 
            // btn_UpdateNote
            // 
            this.btn_UpdateNote.Image = ((System.Drawing.Image)(resources.GetObject("btn_UpdateNote.Image")));
            this.btn_UpdateNote.Location = new System.Drawing.Point(473, 332);
            this.btn_UpdateNote.Name = "btn_UpdateNote";
            this.btn_UpdateNote.Size = new System.Drawing.Size(100, 40);
            this.btn_UpdateNote.TabIndex = 19;
            this.btn_UpdateNote.Text = "Lưu";
            this.btn_UpdateNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_UpdateNote.UseVisualStyleBackColor = true;
            this.btn_UpdateNote.Click += new System.EventHandler(this.btn_UpdateNote_Click);
            // 
            // rTxtB_Note
            // 
            this.rTxtB_Note.Location = new System.Drawing.Point(25, 199);
            this.rTxtB_Note.Name = "rTxtB_Note";
            this.rTxtB_Note.Size = new System.Drawing.Size(548, 118);
            this.rTxtB_Note.TabIndex = 18;
            this.rTxtB_Note.Text = "";
            // 
            // txtB_city
            // 
            this.txtB_city.Enabled = false;
            this.txtB_city.Location = new System.Drawing.Point(383, 139);
            this.txtB_city.Name = "txtB_city";
            this.txtB_city.Size = new System.Drawing.Size(190, 20);
            this.txtB_city.TabIndex = 17;
            // 
            // txtB_Dis
            // 
            this.txtB_Dis.Enabled = false;
            this.txtB_Dis.Location = new System.Drawing.Point(383, 104);
            this.txtB_Dis.Name = "txtB_Dis";
            this.txtB_Dis.Size = new System.Drawing.Size(190, 20);
            this.txtB_Dis.TabIndex = 16;
            // 
            // txtB_Addr
            // 
            this.txtB_Addr.Enabled = false;
            this.txtB_Addr.Location = new System.Drawing.Point(383, 74);
            this.txtB_Addr.Name = "txtB_Addr";
            this.txtB_Addr.Size = new System.Drawing.Size(190, 20);
            this.txtB_Addr.TabIndex = 15;
            // 
            // txtB_NameCus
            // 
            this.txtB_NameCus.Enabled = false;
            this.txtB_NameCus.Location = new System.Drawing.Point(383, 45);
            this.txtB_NameCus.Name = "txtB_NameCus";
            this.txtB_NameCus.Size = new System.Drawing.Size(190, 20);
            this.txtB_NameCus.TabIndex = 14;
            // 
            // txtB_TotalMoney
            // 
            this.txtB_TotalMoney.Enabled = false;
            this.txtB_TotalMoney.Location = new System.Drawing.Point(142, 139);
            this.txtB_TotalMoney.Name = "txtB_TotalMoney";
            this.txtB_TotalMoney.Size = new System.Drawing.Size(100, 20);
            this.txtB_TotalMoney.TabIndex = 13;
            // 
            // txtB_DateOrder
            // 
            this.txtB_DateOrder.Enabled = false;
            this.txtB_DateOrder.Location = new System.Drawing.Point(142, 107);
            this.txtB_DateOrder.Name = "txtB_DateOrder";
            this.txtB_DateOrder.Size = new System.Drawing.Size(100, 20);
            this.txtB_DateOrder.TabIndex = 12;
            // 
            // txtB_BillStatus
            // 
            this.txtB_BillStatus.Enabled = false;
            this.txtB_BillStatus.Location = new System.Drawing.Point(142, 74);
            this.txtB_BillStatus.Name = "txtB_BillStatus";
            this.txtB_BillStatus.Size = new System.Drawing.Size(100, 20);
            this.txtB_BillStatus.TabIndex = 11;
            // 
            // txtB_BillId
            // 
            this.txtB_BillId.Enabled = false;
            this.txtB_BillId.Location = new System.Drawing.Point(142, 42);
            this.txtB_BillId.Name = "txtB_BillId";
            this.txtB_BillId.Size = new System.Drawing.Size(100, 20);
            this.txtB_BillId.TabIndex = 10;
            // 
            // lb_Note
            // 
            this.lb_Note.AutoSize = true;
            this.lb_Note.Location = new System.Drawing.Point(22, 183);
            this.lb_Note.Name = "lb_Note";
            this.lb_Note.Size = new System.Drawing.Size(47, 13);
            this.lb_Note.TabIndex = 9;
            this.lb_Note.Text = "Ghi chú:";
            // 
            // lb_TotalMoney
            // 
            this.lb_TotalMoney.AutoSize = true;
            this.lb_TotalMoney.Location = new System.Drawing.Point(22, 139);
            this.lb_TotalMoney.Name = "lb_TotalMoney";
            this.lb_TotalMoney.Size = new System.Drawing.Size(55, 13);
            this.lb_TotalMoney.TabIndex = 8;
            this.lb_TotalMoney.Text = "Tổng tiền:";
            // 
            // lb_city
            // 
            this.lb_city.AutoSize = true;
            this.lb_city.Location = new System.Drawing.Point(288, 139);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(85, 13);
            this.lb_city.TabIndex = 7;
            this.lb_city.Text = "Tỉnh/Thành phố";
            // 
            // lb_Dis
            // 
            this.lb_Dis.AutoSize = true;
            this.lb_Dis.Location = new System.Drawing.Point(288, 107);
            this.lb_Dis.Name = "lb_Dis";
            this.lb_Dis.Size = new System.Drawing.Size(36, 13);
            this.lb_Dis.TabIndex = 6;
            this.lb_Dis.Text = "Quận:";
            // 
            // lb_Addr
            // 
            this.lb_Addr.AutoSize = true;
            this.lb_Addr.Location = new System.Drawing.Point(288, 74);
            this.lb_Addr.Name = "lb_Addr";
            this.lb_Addr.Size = new System.Drawing.Size(81, 13);
            this.lb_Addr.TabIndex = 5;
            this.lb_Addr.Text = "Số nhà/Đường:";
            // 
            // lb_NameCus
            // 
            this.lb_NameCus.AutoSize = true;
            this.lb_NameCus.Location = new System.Drawing.Point(288, 48);
            this.lb_NameCus.Name = "lb_NameCus";
            this.lb_NameCus.Size = new System.Drawing.Size(68, 13);
            this.lb_NameCus.TabIndex = 4;
            this.lb_NameCus.Text = "Khách hàng:";
            // 
            // lb_DateOrder
            // 
            this.lb_DateOrder.AutoSize = true;
            this.lb_DateOrder.Location = new System.Drawing.Point(22, 107);
            this.lb_DateOrder.Name = "lb_DateOrder";
            this.lb_DateOrder.Size = new System.Drawing.Size(81, 13);
            this.lb_DateOrder.TabIndex = 3;
            this.lb_DateOrder.Text = "Ngày đặt hàng:";
            // 
            // lb_BillStatus
            // 
            this.lb_BillStatus.AutoSize = true;
            this.lb_BillStatus.Location = new System.Drawing.Point(22, 74);
            this.lb_BillStatus.Name = "lb_BillStatus";
            this.lb_BillStatus.Size = new System.Drawing.Size(107, 13);
            this.lb_BillStatus.TabIndex = 2;
            this.lb_BillStatus.Text = "Trạng thái đơn hàng:";
            // 
            // lb_BillID
            // 
            this.lb_BillID.AutoSize = true;
            this.lb_BillID.Location = new System.Drawing.Point(23, 45);
            this.lb_BillID.Name = "lb_BillID";
            this.lb_BillID.Size = new System.Drawing.Size(74, 13);
            this.lb_BillID.TabIndex = 1;
            this.lb_BillID.Text = "Mã đơn hàng:";
            // 
            // lb_InfoBill
            // 
            this.lb_InfoBill.AutoSize = true;
            this.lb_InfoBill.Location = new System.Drawing.Point(11, 9);
            this.lb_InfoBill.Name = "lb_InfoBill";
            this.lb_InfoBill.Size = new System.Drawing.Size(104, 13);
            this.lb_InfoBill.TabIndex = 0;
            this.lb_InfoBill.Text = "Thông tin đơn hàng:";
            // 
            // GridView_BillDetails
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView_BillDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridView_BillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView_BillDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridView_BillDetails.Location = new System.Drawing.Point(16, 42);
            this.GridView_BillDetails.Name = "GridView_BillDetails";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView_BillDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridView_BillDetails.Size = new System.Drawing.Size(381, 323);
            this.GridView_BillDetails.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin sản phẩm:";
            // 
            // btn_UpdateShipperForBill
            // 
            this.btn_UpdateShipperForBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_UpdateShipperForBill.Image")));
            this.btn_UpdateShipperForBill.Location = new System.Drawing.Point(129, 332);
            this.btn_UpdateShipperForBill.Name = "btn_UpdateShipperForBill";
            this.btn_UpdateShipperForBill.Size = new System.Drawing.Size(100, 40);
            this.btn_UpdateShipperForBill.TabIndex = 20;
            this.btn_UpdateShipperForBill.Text = "Lưu";
            this.btn_UpdateShipperForBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_UpdateShipperForBill.UseVisualStyleBackColor = true;
            this.btn_UpdateShipperForBill.Click += new System.EventHandler(this.btn_UpdateShipperForBill_Click);
            // 
            // txtB_ShipperPhone
            // 
            this.txtB_ShipperPhone.Enabled = false;
            this.txtB_ShipperPhone.Location = new System.Drawing.Point(98, 269);
            this.txtB_ShipperPhone.Name = "txtB_ShipperPhone";
            this.txtB_ShipperPhone.Size = new System.Drawing.Size(131, 20);
            this.txtB_ShipperPhone.TabIndex = 11;
            // 
            // txtB_ShipperEmail
            // 
            this.txtB_ShipperEmail.Enabled = false;
            this.txtB_ShipperEmail.Location = new System.Drawing.Point(98, 233);
            this.txtB_ShipperEmail.Name = "txtB_ShipperEmail";
            this.txtB_ShipperEmail.Size = new System.Drawing.Size(131, 20);
            this.txtB_ShipperEmail.TabIndex = 11;
            // 
            // txtB_ShiperName
            // 
            this.txtB_ShiperName.Enabled = false;
            this.txtB_ShiperName.Location = new System.Drawing.Point(98, 199);
            this.txtB_ShiperName.Name = "txtB_ShiperName";
            this.txtB_ShiperName.Size = new System.Drawing.Size(131, 20);
            this.txtB_ShiperName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Thông tin nhân viên:";
            // 
            // cmb_Shipper
            // 
            this.cmb_Shipper.FormattingEnabled = true;
            this.cmb_Shipper.Location = new System.Drawing.Point(15, 65);
            this.cmb_Shipper.Name = "cmb_Shipper";
            this.cmb_Shipper.Size = new System.Drawing.Size(214, 21);
            this.cmb_Shipper.TabIndex = 8;
            this.cmb_Shipper.SelectedIndexChanged += new System.EventHandler(this.cmb_Shipper_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn nhân viên giao hàng.";
            // 
            // lb_ShipperEmail
            // 
            this.lb_ShipperEmail.AutoSize = true;
            this.lb_ShipperEmail.Location = new System.Drawing.Point(12, 236);
            this.lb_ShipperEmail.Name = "lb_ShipperEmail";
            this.lb_ShipperEmail.Size = new System.Drawing.Size(35, 13);
            this.lb_ShipperEmail.TabIndex = 6;
            this.lb_ShipperEmail.Text = "Email:";
            // 
            // lb_ShipperPhone
            // 
            this.lb_ShipperPhone.AutoSize = true;
            this.lb_ShipperPhone.Location = new System.Drawing.Point(12, 272);
            this.lb_ShipperPhone.Name = "lb_ShipperPhone";
            this.lb_ShipperPhone.Size = new System.Drawing.Size(73, 13);
            this.lb_ShipperPhone.TabIndex = 5;
            this.lb_ShipperPhone.Text = "Số điện thoại:";
            // 
            // lb_ShipperName
            // 
            this.lb_ShipperName.AutoSize = true;
            this.lb_ShipperName.Location = new System.Drawing.Point(12, 202);
            this.lb_ShipperName.Name = "lb_ShipperName";
            this.lb_ShipperName.Size = new System.Drawing.Size(42, 13);
            this.lb_ShipperName.TabIndex = 4;
            this.lb_ShipperName.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhân viên giao hàng:";
            // 
            // btn_Note
            // 
            this.btn_Note.Image = ((System.Drawing.Image)(resources.GetObject("btn_Note.Image")));
            this.btn_Note.Location = new System.Drawing.Point(507, 427);
            this.btn_Note.Name = "btn_Note";
            this.btn_Note.Size = new System.Drawing.Size(130, 50);
            this.btn_Note.TabIndex = 1;
            this.btn_Note.Text = "Ghi Chú";
            this.btn_Note.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Note.UseVisualStyleBackColor = true;
            this.btn_Note.Click += new System.EventHandler(this.btn_Note_Click);
            // 
            // btn_ChangeBillStatus
            // 
            this.btn_ChangeBillStatus.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChangeBillStatus.Image")));
            this.btn_ChangeBillStatus.Location = new System.Drawing.Point(654, 427);
            this.btn_ChangeBillStatus.Name = "btn_ChangeBillStatus";
            this.btn_ChangeBillStatus.Size = new System.Drawing.Size(200, 50);
            this.btn_ChangeBillStatus.TabIndex = 2;
            this.btn_ChangeBillStatus.Text = "Thay đổi trạng thái đơn hàng";
            this.btn_ChangeBillStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChangeBillStatus.UseVisualStyleBackColor = true;
            this.btn_ChangeBillStatus.Click += new System.EventHandler(this.btn_ChangeBillStatus_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(1096, 427);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(130, 50);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Shipper
            // 
            this.btn_Shipper.Image = ((System.Drawing.Image)(resources.GetObject("btn_Shipper.Image")));
            this.btn_Shipper.Location = new System.Drawing.Point(875, 427);
            this.btn_Shipper.Name = "btn_Shipper";
            this.btn_Shipper.Size = new System.Drawing.Size(200, 50);
            this.btn_Shipper.TabIndex = 4;
            this.btn_Shipper.Text = "Chọn nhân viên giao hàng";
            this.btn_Shipper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Shipper.UseVisualStyleBackColor = true;
            this.btn_Shipper.Click += new System.EventHandler(this.btn_Shipper_Click);
            // 
            // BillDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1252, 508);
            this.Controls.Add(this.btn_Shipper);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ChangeBillStatus);
            this.Controls.Add(this.btn_Note);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BillDetailForm";
            this.Text = "Quản lý đơn hàng";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_BillDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_UpdateNote;
        private System.Windows.Forms.RichTextBox rTxtB_Note;
        private System.Windows.Forms.TextBox txtB_city;
        private System.Windows.Forms.TextBox txtB_Dis;
        private System.Windows.Forms.TextBox txtB_Addr;
        private System.Windows.Forms.TextBox txtB_NameCus;
        private System.Windows.Forms.TextBox txtB_TotalMoney;
        private System.Windows.Forms.TextBox txtB_DateOrder;
        private System.Windows.Forms.TextBox txtB_BillStatus;
        private System.Windows.Forms.TextBox txtB_BillId;
        private System.Windows.Forms.Label lb_Note;
        private System.Windows.Forms.Label lb_TotalMoney;
        private System.Windows.Forms.Label lb_city;
        private System.Windows.Forms.Label lb_Dis;
        private System.Windows.Forms.Label lb_Addr;
        private System.Windows.Forms.Label lb_NameCus;
        private System.Windows.Forms.Label lb_DateOrder;
        private System.Windows.Forms.Label lb_BillStatus;
        private System.Windows.Forms.Label lb_BillID;
        private System.Windows.Forms.Label lb_InfoBill;
        private System.Windows.Forms.DataGridView GridView_BillDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Note;
        private System.Windows.Forms.Button btn_ChangeBillStatus;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txtB_ShipperPhone;
        private System.Windows.Forms.TextBox txtB_ShipperEmail;
        private System.Windows.Forms.TextBox txtB_ShiperName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Shipper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_ShipperEmail;
        private System.Windows.Forms.Label lb_ShipperPhone;
        private System.Windows.Forms.Label lb_ShipperName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_UpdateShipperForBill;
        private System.Windows.Forms.Button btn_Shipper;
    }
}