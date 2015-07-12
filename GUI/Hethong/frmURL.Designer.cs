namespace GUI.Hethong
{
    partial class frmURL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmURL));
            this.label1 = new System.Windows.Forms.Label();
            this.cboauthen = new System.Windows.Forms.ComboBox();
            this.btnok = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthientai = new System.Windows.Forms.TextBox();
            this.txtservername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorKiemtra = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorKiemtra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server name";
            // 
            // cboauthen
            // 
            this.cboauthen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboauthen.FormattingEnabled = true;
            this.cboauthen.Items.AddRange(new object[] {
            "SQL Server Authentication",
            "Windows Authentication"});
            this.cboauthen.Location = new System.Drawing.Point(100, 146);
            this.cboauthen.Name = "cboauthen";
            this.cboauthen.Size = new System.Drawing.Size(216, 21);
            this.cboauthen.TabIndex = 2;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(100, 248);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(100, 209);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(216, 20);
            this.txtpass.TabIndex = 4;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(241, 248);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Hủy";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(100, 178);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(216, 20);
            this.txtlogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Authentication";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Database";
            // 
            // txtdatabase
            // 
            this.txtdatabase.Location = new System.Drawing.Point(100, 115);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(216, 20);
            this.txtdatabase.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Login";
            // 
            // txthientai
            // 
            this.txthientai.Location = new System.Drawing.Point(23, 19);
            this.txthientai.Multiline = true;
            this.txthientai.Name = "txthientai";
            this.txthientai.ReadOnly = true;
            this.txthientai.Size = new System.Drawing.Size(293, 50);
            this.txthientai.TabIndex = 7;
            // 
            // txtservername
            // 
            this.txtservername.Location = new System.Drawing.Point(100, 85);
            this.txtservername.Name = "txtservername";
            this.txtservername.Size = new System.Drawing.Size(216, 20);
            this.txtservername.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboauthen);
            this.groupBox1.Controls.Add(this.btnok);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.txtlogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdatabase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txthientai);
            this.groupBox1.Controls.Add(this.txtservername);
            this.groupBox1.Location = new System.Drawing.Point(22, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 285);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // errorKiemtra
            // 
            this.errorKiemtra.ContainerControl = this;
            // 
            // frmURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 317);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmURL";
            this.Text = "Thông tin kết nối";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorKiemtra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboauthen;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthientai;
        private System.Windows.Forms.TextBox txtservername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorKiemtra;
    }
}