namespace GUI.Nghiepvu
{
    partial class frmLapdonhang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapdonhang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbdonhangchiphi = new System.Windows.Forms.RadioButton();
            this.rdbdonhangTC = new System.Windows.Forms.RadioButton();
            this.panelThongtin = new System.Windows.Forms.Panel();
            this.grCTHD = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnolai = new System.Windows.Forms.TextBox();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.txtKHduatruoc = new System.Windows.Forms.TextBox();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.cbosoluong = new System.Windows.Forms.NumericUpDown();
            this.cbomathang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbodanhmuc = new System.Windows.Forms.ComboBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtNgaythang = new System.Windows.Forms.DateTimePicker();
            this.panelList = new System.Windows.Forms.Panel();
            this.dgCTHD = new System.Windows.Forms.DataGridView();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.btnthemmoi = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.btnxuatphieu = new System.Windows.Forms.ToolStripButton();
            this.cbotenKH = new System.Windows.Forms.ComboBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.errorBatloi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panelThongtin.SuspendLayout();
            this.grCTHD.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbosoluong)).BeginInit();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCTHD)).BeginInit();
            this.tsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorBatloi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbdonhangchiphi);
            this.groupBox1.Controls.Add(this.rdbdonhangTC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdbdonhangchiphi
            // 
            this.rdbdonhangchiphi.AutoSize = true;
            this.rdbdonhangchiphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdonhangchiphi.ForeColor = System.Drawing.Color.Red;
            this.rdbdonhangchiphi.Location = new System.Drawing.Point(186, 14);
            this.rdbdonhangchiphi.Name = "rdbdonhangchiphi";
            this.rdbdonhangchiphi.Size = new System.Drawing.Size(124, 17);
            this.rdbdonhangchiphi.TabIndex = 0;
            this.rdbdonhangchiphi.Text = "Đơn hàng chi phí";
            this.rdbdonhangchiphi.UseVisualStyleBackColor = true;
            this.rdbdonhangchiphi.CheckedChanged += new System.EventHandler(this.rdbdonhangchiphi_CheckedChanged);
            // 
            // rdbdonhangTC
            // 
            this.rdbdonhangTC.AutoSize = true;
            this.rdbdonhangTC.Checked = true;
            this.rdbdonhangTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdonhangTC.ForeColor = System.Drawing.Color.Red;
            this.rdbdonhangTC.Location = new System.Drawing.Point(12, 14);
            this.rdbdonhangTC.Name = "rdbdonhangTC";
            this.rdbdonhangTC.Size = new System.Drawing.Size(144, 17);
            this.rdbdonhangTC.TabIndex = 0;
            this.rdbdonhangTC.TabStop = true;
            this.rdbdonhangTC.Text = "Đơn hàng tiêu chuẩn";
            this.rdbdonhangTC.UseVisualStyleBackColor = true;
            this.rdbdonhangTC.CheckedChanged += new System.EventHandler(this.rdbThuno_CheckedChanged);
            // 
            // panelThongtin
            // 
            this.panelThongtin.Controls.Add(this.grCTHD);
            this.panelThongtin.Controls.Add(this.label6);
            this.panelThongtin.Controls.Add(this.label2);
            this.panelThongtin.Controls.Add(this.label5);
            this.panelThongtin.Controls.Add(this.label1);
            this.panelThongtin.Controls.Add(this.textBox6);
            this.panelThongtin.Controls.Add(this.textBox2);
            this.panelThongtin.Controls.Add(this.textBox1);
            this.panelThongtin.Controls.Add(this.dtNgaythang);
            this.panelThongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongtin.Location = new System.Drawing.Point(0, 40);
            this.panelThongtin.Name = "panelThongtin";
            this.panelThongtin.Size = new System.Drawing.Size(814, 135);
            this.panelThongtin.TabIndex = 1;
            // 
            // grCTHD
            // 
            this.grCTHD.Controls.Add(this.groupBox2);
            this.grCTHD.Controls.Add(this.lblthanhtien);
            this.grCTHD.Controls.Add(this.cbosoluong);
            this.grCTHD.Controls.Add(this.cbomathang);
            this.grCTHD.Controls.Add(this.label4);
            this.grCTHD.Controls.Add(this.cbodanhmuc);
            this.grCTHD.Controls.Add(this.txtdongia);
            this.grCTHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grCTHD.Location = new System.Drawing.Point(0, 45);
            this.grCTHD.Name = "grCTHD";
            this.grCTHD.Size = new System.Drawing.Size(814, 90);
            this.grCTHD.TabIndex = 5;
            this.grCTHD.TabStop = false;
            this.grCTHD.Text = "Chi tiết hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtnolai);
            this.groupBox2.Controls.Add(this.cbostatus);
            this.groupBox2.Controls.Add(this.txtKHduatruoc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 40);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "KH đưa trước";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(357, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nợ lại";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtnolai
            // 
            this.txtnolai.Location = new System.Drawing.Point(409, 13);
            this.txtnolai.Name = "txtnolai";
            this.txtnolai.Size = new System.Drawing.Size(184, 20);
            this.txtnolai.TabIndex = 3;
            // 
            // cbostatus
            // 
            this.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán",
            "Thanh toán 1 phần"});
            this.cbostatus.Location = new System.Drawing.Point(599, 13);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(124, 21);
            this.cbostatus.TabIndex = 2;
            // 
            // txtKHduatruoc
            // 
            this.txtKHduatruoc.Location = new System.Drawing.Point(114, 13);
            this.txtKHduatruoc.Name = "txtKHduatruoc";
            this.txtKHduatruoc.Size = new System.Drawing.Size(231, 20);
            this.txtKHduatruoc.TabIndex = 3;
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthanhtien.Location = new System.Drawing.Point(605, 23);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(124, 19);
            this.lblthanhtien.TabIndex = 5;
            this.lblthanhtien.Text = "Thành tiền";
            this.lblthanhtien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbosoluong
            // 
            this.cbosoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosoluong.Location = new System.Drawing.Point(361, 22);
            this.cbosoluong.Name = "cbosoluong";
            this.cbosoluong.Size = new System.Drawing.Size(46, 20);
            this.cbosoluong.TabIndex = 4;
            // 
            // cbomathang
            // 
            this.cbomathang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomathang.FormattingEnabled = true;
            this.cbomathang.Location = new System.Drawing.Point(120, 22);
            this.cbomathang.Name = "cbomathang";
            this.cbomathang.Size = new System.Drawing.Size(231, 21);
            this.cbomathang.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đơn giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbodanhmuc
            // 
            this.cbodanhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbodanhmuc.FormattingEnabled = true;
            this.cbodanhmuc.Location = new System.Drawing.Point(12, 22);
            this.cbodanhmuc.Name = "cbodanhmuc";
            this.cbodanhmuc.Size = new System.Drawing.Size(100, 21);
            this.cbodanhmuc.TabIndex = 2;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(459, 22);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(140, 20);
            this.txtdongia.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(679, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ghi chú";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(371, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chi phí phát sinh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày lập đơn hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã số hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(732, 117);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(274, 21);
            this.textBox6.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(481, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dtNgaythang
            // 
            this.dtNgaythang.AllowDrop = true;
            this.dtNgaythang.CustomFormat = "yyyy-MM-dd";
            this.dtNgaythang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaythang.Location = new System.Drawing.Point(120, 14);
            this.dtNgaythang.Name = "dtNgaythang";
            this.dtNgaythang.Size = new System.Drawing.Size(98, 20);
            this.dtNgaythang.TabIndex = 1;
            this.dtNgaythang.Value = new System.DateTime(2014, 10, 26, 0, 0, 0, 0);
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.dgCTHD);
            this.panelList.Controls.Add(this.tsControl);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(0, 175);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(814, 266);
            this.panelList.TabIndex = 2;
            // 
            // dgCTHD
            // 
            this.dgCTHD.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCTHD.Location = new System.Drawing.Point(0, 25);
            this.dgCTHD.Name = "dgCTHD";
            this.dgCTHD.Size = new System.Drawing.Size(814, 241);
            this.dgCTHD.TabIndex = 0;
            // 
            // tsControl
            // 
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthemmoi,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.btnxuatphieu});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.Size = new System.Drawing.Size(814, 25);
            this.tsControl.TabIndex = 0;
            this.tsControl.Text = "toolStrip1";
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnthemmoi.Image")));
            this.btnthemmoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(74, 22);
            this.btnthemmoi.Text = "Thêm MH";
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton2.Text = "Xóa dòng";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(94, 22);
            this.toolStripButton3.Text = "Lưu đơn hàng";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton4.Text = "Kết xuất Excel";
            // 
            // btnxuatphieu
            // 
            this.btnxuatphieu.Image = ((System.Drawing.Image)(resources.GetObject("btnxuatphieu.Image")));
            this.btnxuatphieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxuatphieu.Name = "btnxuatphieu";
            this.btnxuatphieu.Size = new System.Drawing.Size(126, 22);
            this.btnxuatphieu.Text = "Xuất phiếu bán hàng";
            // 
            // cbotenKH
            // 
            this.cbotenKH.AllowDrop = true;
            this.cbotenKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotenKH.FormattingEnabled = true;
            this.cbotenKH.Location = new System.Drawing.Point(7, 45);
            this.cbotenKH.Name = "cbotenKH";
            this.cbotenKH.Size = new System.Drawing.Size(210, 21);
            this.cbotenKH.TabIndex = 2;
            this.cbotenKH.SelectedIndexChanged += new System.EventHandler(this.cbotenKH_SelectedIndexChanged);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(7, 106);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(210, 20);
            this.txtdiachi.TabIndex = 3;
            this.txtdiachi.Text = "Địa chỉ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaKH);
            this.splitContainer1.Panel1.Controls.Add(this.cbotenKH);
            this.splitContainer1.Panel1.Controls.Add(this.textBox9);
            this.splitContainer1.Panel1.Controls.Add(this.textBox3);
            this.splitContainer1.Panel1.Controls.Add(this.textBox8);
            this.splitContainer1.Panel1.Controls.Add(this.textBox10);
            this.splitContainer1.Panel1.Controls.Add(this.txtdiachi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelList);
            this.splitContainer1.Panel2.Controls.Add(this.panelThongtin);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1047, 443);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mã khách hàng";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(101, 15);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(116, 20);
            this.txtMaKH.TabIndex = 0;
            this.txtMaKH.Leave += new System.EventHandler(this.txtMaKH_Leave);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(7, 196);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(210, 20);
            this.textBox9.TabIndex = 3;
            this.textBox9.Text = "Fax";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Mail";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(7, 136);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(210, 20);
            this.textBox8.TabIndex = 3;
            this.textBox8.Text = "Số ĐT";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(7, 76);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(210, 20);
            this.textBox10.TabIndex = 3;
            this.textBox10.Text = "Ngày sinh";
            // 
            // errorBatloi
            // 
            this.errorBatloi.ContainerControl = this;
            // 
            // frmLapdonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 443);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLapdonhang";
            this.Text = "Lập đơn hàng Thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLaphoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelThongtin.ResumeLayout(false);
            this.panelThongtin.PerformLayout();
            this.grCTHD.ResumeLayout(false);
            this.grCTHD.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbosoluong)).EndInit();
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCTHD)).EndInit();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorBatloi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbdonhangchiphi;
        private System.Windows.Forms.RadioButton rdbdonhangTC;
        private System.Windows.Forms.Panel panelThongtin;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton btnthemmoi;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.DataGridView dgCTHD;
        private System.Windows.Forms.DateTimePicker dtNgaythang;
        private System.Windows.Forms.ComboBox cbotenKH;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grCTHD;
        private System.Windows.Forms.NumericUpDown cbosoluong;
        private System.Windows.Forms.ComboBox cbomathang;
        private System.Windows.Forms.ComboBox cbodanhmuc;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton btnxuatphieu;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorBatloi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKHduatruoc;
        private System.Windows.Forms.TextBox txtnolai;
        private System.Windows.Forms.ComboBox cbostatus;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}