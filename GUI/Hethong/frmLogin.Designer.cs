namespace GUI.Hethong
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txttenDN = new System.Windows.Forms.TextBox();
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkluu = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cấuHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKetnoi = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txttenDN
            // 
            this.txttenDN.Location = new System.Drawing.Point(250, 71);
            this.txttenDN.Name = "txttenDN";
            this.txttenDN.Size = new System.Drawing.Size(162, 20);
            this.txttenDN.TabIndex = 7;
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhaplai.Location = new System.Drawing.Point(337, 147);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(75, 23);
            this.btnnhaplai.TabIndex = 12;
            this.btnnhaplai.Text = "Thoát";
            this.btnnhaplai.UseVisualStyleBackColor = true;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(160, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(250, 105);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(162, 20);
            this.txtpass.TabIndex = 10;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(250, 148);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 11;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(160, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chkluu
            // 
            this.chkluu.AutoSize = true;
            this.chkluu.Checked = true;
            this.chkluu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkluu.Location = new System.Drawing.Point(160, 182);
            this.chkluu.Name = "chkluu";
            this.chkluu.Size = new System.Drawing.Size(107, 17);
            this.chkluu.TabIndex = 13;
            this.chkluu.Text = "Ghi nhớ thông tin";
            this.chkluu.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cấuHìnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cấuHìnhToolStripMenuItem
            // 
            this.cấuHìnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnKetnoi,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.cấuHìnhToolStripMenuItem.Name = "cấuHìnhToolStripMenuItem";
            this.cấuHìnhToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cấuHìnhToolStripMenuItem.Text = "Cấu hình";
            // 
            // mnKetnoi
            // 
            this.mnKetnoi.Image = ((System.Drawing.Image)(resources.GetObject("mnKetnoi.Image")));
            this.mnKetnoi.Name = "mnKetnoi";
            this.mnKetnoi.Size = new System.Drawing.Size(111, 22);
            this.mnKetnoi.Text = "Kết nối";
            this.mnKetnoi.Click += new System.EventHandler(this.mnKetnoi_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 41);
            this.label3.TabIndex = 16;
            this.label3.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("đổiMậtKhẩuToolStripMenuItem.Image")));
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 229);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttenDN);
            this.Controls.Add(this.btnnhaplai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkluu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txttenDN;
        private System.Windows.Forms.Button btnnhaplai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox chkluu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cấuHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnKetnoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}