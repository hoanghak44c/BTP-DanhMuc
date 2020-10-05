using QLBH.Core.Form;
namespace QLBanHang.Modules.DanhMuc
{
    partial class frmDM_DongBo
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
            if (disposing && (components != null)) {
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDeleteData = new System.Windows.Forms.CheckBox();
            this.chkUseForAll = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtDonViTinh = new QLBH.Core.Form.GtidTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDVT = new QLBH.Core.Form.GtidButton();
            this.btnTaxCode = new QLBH.Core.Form.GtidButton();
            this.btnNhanVien = new QLBH.Core.Form.GtidButton();
            this.btnPayment = new QLBH.Core.Form.GtidButton();
            this.btnOrderType = new QLBH.Core.Form.GtidButton();
            this.btnSanPham = new QLBH.Core.Form.GtidButton();
            this.btnKhachHang = new QLBH.Core.Form.GtidButton();
            this.btnChonTrungTam = new QLBH.Core.Form.GtidButton();
            this.btnKho = new QLBH.Core.Form.GtidButton();
            this.txtTaxCode = new QLBH.Core.Form.GtidTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNhanVien = new QLBH.Core.Form.GtidTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPayment = new QLBH.Core.Form.GtidTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderType = new QLBH.Core.Form.GtidTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSanPham = new QLBH.Core.Form.GtidTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKhachHang = new QLBH.Core.Form.GtidTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrungTam = new QLBH.Core.Form.GtidTextBox();
            this.txtKho = new QLBH.Core.Form.GtidTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChapNhan = new QLBH.Core.Form.GtidButton();
            this.btnHuyBo = new QLBH.Core.Form.GtidButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTieuDe.Location = new System.Drawing.Point(140, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(204, 24);
            this.lblTieuDe.TabIndex = 46;
            this.lblTieuDe.Text = "ĐỒNG BỘ DANH MỤC";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDeleteData);
            this.groupBox1.Controls.Add(this.chkUseForAll);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.txtDonViTinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnDVT);
            this.groupBox1.Controls.Add(this.btnTaxCode);
            this.groupBox1.Controls.Add(this.btnNhanVien);
            this.groupBox1.Controls.Add(this.btnPayment);
            this.groupBox1.Controls.Add(this.btnOrderType);
            this.groupBox1.Controls.Add(this.btnSanPham);
            this.groupBox1.Controls.Add(this.btnKhachHang);
            this.groupBox1.Controls.Add(this.btnChonTrungTam);
            this.groupBox1.Controls.Add(this.btnKho);
            this.groupBox1.Controls.Add(this.txtTaxCode);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPayment);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtOrderType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSanPham);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKhachHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTrungTam);
            this.groupBox1.Controls.Add(this.txtKho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 352);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // chkDeleteData
            // 
            this.chkDeleteData.AutoSize = true;
            this.chkDeleteData.Location = new System.Drawing.Point(371, 40);
            this.chkDeleteData.Name = "chkDeleteData";
            this.chkDeleteData.Size = new System.Drawing.Size(94, 17);
            this.chkDeleteData.TabIndex = 7;
            this.chkDeleteData.Text = "Xóa dữ liệu cũ";
            this.chkDeleteData.UseVisualStyleBackColor = true;
            // 
            // chkUseForAll
            // 
            this.chkUseForAll.AutoSize = true;
            this.chkUseForAll.Location = new System.Drawing.Point(20, 41);
            this.chkUseForAll.Name = "chkUseForAll";
            this.chkUseForAll.Size = new System.Drawing.Size(210, 17);
            this.chkUseForAll.TabIndex = 6;
            this.chkUseForAll.Text = "Dùng một file cho tất cả các danh mục";
            this.chkUseForAll.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 305);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 323);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(448, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.Color.White;
            this.txtDonViTinh.Location = new System.Drawing.Point(136, 143);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(247, 20);
            this.txtDonViTinh.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khởi tạo dữ liệu nguồn bằng cách chọn các file excell tương ứng với các danh mục " +
                "dưới đây.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Danh mục đơn vị tính";
            // 
            // btnDVT
            // 
            this.btnDVT.Location = new System.Drawing.Point(389, 143);
            this.btnDVT.Name = "btnDVT";
            this.btnDVT.Size = new System.Drawing.Size(75, 23);
            this.btnDVT.TabIndex = 2;
            this.btnDVT.Text = "Chọn file";
            this.btnDVT.UseVisualStyleBackColor = true;
            this.btnDVT.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnTaxCode
            // 
            this.btnTaxCode.Location = new System.Drawing.Point(389, 273);
            this.btnTaxCode.Name = "btnTaxCode";
            this.btnTaxCode.Size = new System.Drawing.Size(75, 23);
            this.btnTaxCode.TabIndex = 2;
            this.btnTaxCode.Text = "Chọn file";
            this.btnTaxCode.UseVisualStyleBackColor = true;
            this.btnTaxCode.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(389, 247);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Chọn file";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(389, 221);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Chọn file";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnOrderType
            // 
            this.btnOrderType.Location = new System.Drawing.Point(389, 195);
            this.btnOrderType.Name = "btnOrderType";
            this.btnOrderType.Size = new System.Drawing.Size(75, 23);
            this.btnOrderType.TabIndex = 2;
            this.btnOrderType.Text = "Chọn file";
            this.btnOrderType.UseVisualStyleBackColor = true;
            this.btnOrderType.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Location = new System.Drawing.Point(389, 169);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(75, 23);
            this.btnSanPham.TabIndex = 2;
            this.btnSanPham.Text = "Chọn file";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(389, 117);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btnKhachHang.TabIndex = 2;
            this.btnKhachHang.Text = "Chọn file";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnChonTrungTam
            // 
            this.btnChonTrungTam.Location = new System.Drawing.Point(389, 65);
            this.btnChonTrungTam.Name = "btnChonTrungTam";
            this.btnChonTrungTam.Size = new System.Drawing.Size(75, 23);
            this.btnChonTrungTam.TabIndex = 2;
            this.btnChonTrungTam.Text = "Chọn file";
            this.btnChonTrungTam.UseVisualStyleBackColor = true;
            this.btnChonTrungTam.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // btnKho
            // 
            this.btnKho.Location = new System.Drawing.Point(389, 91);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(75, 23);
            this.btnKho.TabIndex = 2;
            this.btnKho.Text = "Chọn file";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.BackColor = System.Drawing.Color.White;
            this.txtTaxCode.Location = new System.Drawing.Point(136, 273);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.ReadOnly = true;
            this.txtTaxCode.Size = new System.Drawing.Size(247, 20);
            this.txtTaxCode.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Danh mục tax code";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.BackColor = System.Drawing.Color.White;
            this.txtNhanVien.Location = new System.Drawing.Point(136, 247);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(247, 20);
            this.txtNhanVien.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Danh mục nhân viên";
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.Color.White;
            this.txtPayment.Location = new System.Drawing.Point(136, 221);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(247, 20);
            this.txtPayment.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Danh mục Payment";
            // 
            // txtOrderType
            // 
            this.txtOrderType.BackColor = System.Drawing.Color.White;
            this.txtOrderType.Location = new System.Drawing.Point(136, 195);
            this.txtOrderType.Name = "txtOrderType";
            this.txtOrderType.ReadOnly = true;
            this.txtOrderType.Size = new System.Drawing.Size(247, 20);
            this.txtOrderType.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Danh mục OrderType";
            // 
            // txtSanPham
            // 
            this.txtSanPham.BackColor = System.Drawing.Color.White;
            this.txtSanPham.Location = new System.Drawing.Point(136, 169);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.ReadOnly = true;
            this.txtSanPham.Size = new System.Drawing.Size(247, 20);
            this.txtSanPham.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục sản phẩm";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.BackColor = System.Drawing.Color.White;
            this.txtKhachHang.Location = new System.Drawing.Point(136, 117);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(247, 20);
            this.txtKhachHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh mục khách hàng";
            // 
            // txtTrungTam
            // 
            this.txtTrungTam.BackColor = System.Drawing.Color.White;
            this.txtTrungTam.Location = new System.Drawing.Point(136, 65);
            this.txtTrungTam.Name = "txtTrungTam";
            this.txtTrungTam.ReadOnly = true;
            this.txtTrungTam.Size = new System.Drawing.Size(247, 20);
            this.txtTrungTam.TabIndex = 1;
            // 
            // txtKho
            // 
            this.txtKho.BackColor = System.Drawing.Color.White;
            this.txtKho.Location = new System.Drawing.Point(136, 91);
            this.txtKho.Name = "txtKho";
            this.txtKho.ReadOnly = true;
            this.txtKho.Size = new System.Drawing.Size(247, 20);
            this.txtKho.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh mục trung tâm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục kho";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChapNhan);
            this.groupBox2.Controls.Add(this.btnHuyBo);
            this.groupBox2.Location = new System.Drawing.Point(12, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 57);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.Location = new System.Drawing.Point(260, 19);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(85, 25);
            this.btnChapNhan.TabIndex = 0;
            this.btnChapNhan.Text = "Chấp nhận";
            this.btnChapNhan.UseVisualStyleBackColor = true;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(162, 19);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(85, 25);
            this.btnHuyBo.TabIndex = 0;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDM_DongBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDM_DongBo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồng bộ dữ liệu";
            this.Load += new System.EventHandler(this.frmDM_DongBo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox chkUseForAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkDeleteData;
        private GtidButton btnSanPham;
        private GtidButton btnKhachHang;
        private GtidButton btnKho;
        private GtidTextBox txtSanPham;
        private GtidTextBox txtKhachHang;
        private GtidTextBox txtKho;
        private GtidButton btnChapNhan;
        private GtidButton btnHuyBo;
        private GtidButton btnPayment;
        private GtidButton btnOrderType;
        private GtidButton btnChonTrungTam;
        private GtidTextBox txtPayment;
        private GtidTextBox txtOrderType;
        private GtidTextBox txtTrungTam;
        private GtidButton btnTaxCode;
        private GtidButton btnNhanVien;
        private GtidButton btnDVT;
        private GtidTextBox txtTaxCode;
        private GtidTextBox txtNhanVien;
        private GtidTextBox txtDonViTinh;
    }
}