using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DanhMuc.Base;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmChiTiet_LoaiSanPham : ChiTietLoaiSanPhamTranAnhController
    {
        private System.Windows.Forms.Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DevExpress.XtraEditors.ButtonEdit bteLoai;
        private DevExpress.XtraEditors.ButtonEdit bteLinhVuc;
        private DevExpress.XtraEditors.ButtonEdit bteHang;
        private DevExpress.XtraEditors.ButtonEdit bteChung;
        private DevExpress.XtraEditors.ButtonEdit bteNganh;
        private DevExpress.XtraEditors.ButtonEdit bteModel;
        private DevExpress.XtraEditors.ButtonEdit bteNhom;
        private System.Windows.Forms.ComboBox cbNhomCha;
        private void InitializeComponent()
        {
            this.cbNhomCha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bteLinhVuc = new DevExpress.XtraEditors.ButtonEdit();
            this.bteLoai = new DevExpress.XtraEditors.ButtonEdit();
            this.bteNhom = new DevExpress.XtraEditors.ButtonEdit();
            this.bteModel = new DevExpress.XtraEditors.ButtonEdit();
            this.bteNganh = new DevExpress.XtraEditors.ButtonEdit();
            this.bteChung = new DevExpress.XtraEditors.ButtonEdit();
            this.bteHang = new DevExpress.XtraEditors.ButtonEdit();
            this.groupBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteLinhVuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteChung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Location = new System.Drawing.Point(323, 14);
            this.lblTieuDe.Size = new System.Drawing.Size(96, 22);
            this.lblTieuDe.Text = "CHI TIẾT LOẠI SẢN PHẨM";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.bteHang);
            this.groupBoxList.Controls.Add(this.bteChung);
            this.groupBoxList.Controls.Add(this.bteNganh);
            this.groupBoxList.Controls.Add(this.bteModel);
            this.groupBoxList.Controls.Add(this.bteNhom);
            this.groupBoxList.Controls.Add(this.bteLoai);
            this.groupBoxList.Controls.Add(this.bteLinhVuc);
            this.groupBoxList.Controls.Add(this.label8);
            this.groupBoxList.Controls.Add(this.label7);
            this.groupBoxList.Controls.Add(this.label6);
            this.groupBoxList.Controls.Add(this.label5);
            this.groupBoxList.Controls.Add(this.label4);
            this.groupBoxList.Controls.Add(this.label3);
            this.groupBoxList.Controls.Add(this.label2);
            this.groupBoxList.Controls.Add(this.cbNhomCha);
            this.groupBoxList.Controls.Add(this.label1);
            this.groupBoxList.Size = new System.Drawing.Size(743, 297);
            this.groupBoxList.Controls.SetChildIndex(this.lblSuDung, 0);
            this.groupBoxList.Controls.SetChildIndex(this.chkSuDung, 0);
            this.groupBoxList.Controls.SetChildIndex(this.txtMoTa, 0);
            this.groupBoxList.Controls.SetChildIndex(this.lblMoTa, 0);
            this.groupBoxList.Controls.SetChildIndex(this.label1, 0);
            this.groupBoxList.Controls.SetChildIndex(this.cbNhomCha, 0);
            this.groupBoxList.Controls.SetChildIndex(this.lblMa, 0);
            this.groupBoxList.Controls.SetChildIndex(this.lblTen, 0);
            this.groupBoxList.Controls.SetChildIndex(this.txtMa, 0);
            this.groupBoxList.Controls.SetChildIndex(this.txtTen, 0);
            this.groupBoxList.Controls.SetChildIndex(this.label2, 0);
            this.groupBoxList.Controls.SetChildIndex(this.label3, 0);
            this.groupBoxList.Controls.SetChildIndex(this.label4, 0);
            this.groupBoxList.Controls.SetChildIndex(this.label5, 0);
            this.groupBoxList.Controls.SetChildIndex(this.label6, 0);
            this.groupBoxList.Controls.SetChildIndex(this.label7, 0);
            this.groupBoxList.Controls.SetChildIndex(this.label8, 0);
            this.groupBoxList.Controls.SetChildIndex(this.bteLinhVuc, 0);
            this.groupBoxList.Controls.SetChildIndex(this.bteLoai, 0);
            this.groupBoxList.Controls.SetChildIndex(this.bteNhom, 0);
            this.groupBoxList.Controls.SetChildIndex(this.bteModel, 0);
            this.groupBoxList.Controls.SetChildIndex(this.bteNganh, 0);
            this.groupBoxList.Controls.SetChildIndex(this.bteChung, 0);
            this.groupBoxList.Controls.SetChildIndex(this.bteHang, 0);
            // 
            // chkSuDung
            // 
            this.chkSuDung.Location = new System.Drawing.Point(76, 263);
            this.chkSuDung.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkSuDung.TabIndex = 11;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(78, 188);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtMoTa.Size = new System.Drawing.Size(658, 67);
            this.txtMoTa.TabIndex = 10;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(78, 58);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtTen.Size = new System.Drawing.Size(258, 22);
            this.txtTen.TabIndex = 2;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(78, 25);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtMa.Size = new System.Drawing.Size(258, 22);
            // 
            // lblSuDung
            // 
            this.lblSuDung.Location = new System.Drawing.Point(6, 264);
            this.lblSuDung.Size = new System.Drawing.Size(64, 25);
            this.lblSuDung.TabIndex = 23;
            // 
            // lblMoTa
            // 
            this.lblMoTa.Location = new System.Drawing.Point(6, 192);
            this.lblMoTa.Size = new System.Drawing.Size(58, 25);
            this.lblMoTa.TabIndex = 22;
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(6, 61);
            this.lblTen.Size = new System.Drawing.Size(58, 25);
            this.lblTen.TabIndex = 14;
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(6, 28);
            this.lblMa.Size = new System.Drawing.Size(58, 25);
            this.lblMa.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(2, 359);
            this.groupBox1.Size = new System.Drawing.Size(743, 63);
            // 
            // cbNhomCha
            // 
            this.cbNhomCha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhomCha.FormattingEnabled = true;
            this.cbNhomCha.Location = new System.Drawing.Point(461, 25);
            this.cbNhomCha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNhomCha.Name = "cbNhomCha";
            this.cbNhomCha.Size = new System.Drawing.Size(275, 24);
            this.cbNhomCha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(372, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nhóm cha";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(372, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Lĩnh vực";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ngành";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(372, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Chủng";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(372, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nhóm ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Hãng";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(372, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Model";
            // 
            // bteLinhVuc
            // 
            this.bteLinhVuc.Location = new System.Drawing.Point(461, 60);
            this.bteLinhVuc.Name = "bteLinhVuc";
            this.bteLinhVuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteLinhVuc.Size = new System.Drawing.Size(276, 20);
            this.bteLinhVuc.TabIndex = 24;
            this.bteLinhVuc.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteLinhVuc_ButtonClick);
            this.bteLinhVuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteLinhVuc_KeyDown);
            this.bteLinhVuc.TextChanged += new System.EventHandler(this.bteLinhVuc_TextChanged);
            // 
            // bteLoai
            // 
            this.bteLoai.Location = new System.Drawing.Point(461, 89);
            this.bteLoai.Name = "bteLoai";
            this.bteLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteLoai.Size = new System.Drawing.Size(276, 20);
            this.bteLoai.TabIndex = 25;
            this.bteLoai.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteLoai_ButtonClick);
            this.bteLoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteLoai_KeyDown);
            this.bteLoai.TextChanged += new System.EventHandler(this.bteLoai_TextChanged);
            // 
            // bteNhom
            // 
            this.bteNhom.Location = new System.Drawing.Point(461, 122);
            this.bteNhom.Name = "bteNhom";
            this.bteNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteNhom.Size = new System.Drawing.Size(276, 20);
            this.bteNhom.TabIndex = 26;
            this.bteNhom.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteNhom_ButtonClick);
            this.bteNhom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteNhom_KeyDown);
            this.bteNhom.TextChanged += new System.EventHandler(this.bteNhom_TextChanged);
            // 
            // bteModel
            // 
            this.bteModel.Location = new System.Drawing.Point(461, 151);
            this.bteModel.Name = "bteModel";
            this.bteModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteModel.Size = new System.Drawing.Size(276, 20);
            this.bteModel.TabIndex = 27;
            this.bteModel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteModel_ButtonClick);
            this.bteModel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteModel_KeyDown);
            this.bteModel.TextChanged += new System.EventHandler(this.bteModel_TextChanged);
            // 
            // bteNganh
            // 
            this.bteNganh.Location = new System.Drawing.Point(78, 89);
            this.bteNganh.Name = "bteNganh";
            this.bteNganh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteNganh.Size = new System.Drawing.Size(258, 20);
            this.bteNganh.TabIndex = 28;
            this.bteNganh.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteNganh_ButtonClick);
            this.bteNganh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteNganh_KeyDown);
            this.bteNganh.TextChanged += new System.EventHandler(this.bteNganh_TextChanged);
            // 
            // bteChung
            // 
            this.bteChung.Location = new System.Drawing.Point(78, 122);
            this.bteChung.Name = "bteChung";
            this.bteChung.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteChung.Size = new System.Drawing.Size(258, 20);
            this.bteChung.TabIndex = 29;
            this.bteChung.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteChung_ButtonClick);
            this.bteChung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteChung_KeyDown);
            this.bteChung.TextChanged += new System.EventHandler(this.bteChung_TextChanged);
            // 
            // bteHang
            // 
            this.bteHang.Location = new System.Drawing.Point(78, 151);
            this.bteHang.Name = "bteHang";
            this.bteHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.bteHang.Size = new System.Drawing.Size(258, 20);
            this.bteHang.TabIndex = 30;
            this.bteHang.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteHang_ButtonClick);
            this.bteHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bteHang_KeyDown);
            this.bteHang.TextChanged += new System.EventHandler(this.bteHang_TextChanged);
            // 
            // frmChiTiet_LoaiSanPham
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(747, 438);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmChiTiet_LoaiSanPham";
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bteLinhVuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteNganh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteChung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bteHang.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        public frmChiTiet_LoaiSanPham()
        {
            InitializeComponent();
            //lblTieuDe.Text = "CHI TIẾT LOẠI SẢN PHẨM";
        }

        public frmChiTiet_LoaiSanPham(frmDM_LoaiSanPham frm)
        {
            groupBoxList.Text = "Nội dung chi tiết";
            InitializeComponent();
            this.frmList = frm;
            this.Provider = DMLoaiSanPhamDataProvider.Instance;
            lblTieuDe.Text = "CHI TIẾT LOẠI SẢN PHẨM";
        }

        #region Action

        #region LoadData
        protected override void LoadData()
        {
            base.LoadData();
            LoadNhomCha();
            if (!frmList.isAdd)
            {
                txtMa.Enabled = false;
                dm = DMLoaiSanPhamDataProvider.Instance.GetFullInfoByKey(frmList.Oid);
                txtMa.Text = dm.MaLoaiSP;
                txtTen.Text = dm.TenLoaiSP;
                txtMoTa.Text = dm.GhiChu;
                chkSuDung.Checked = dm.SuDung == 1;
                cbNhomCha.SelectedValue = dm.NhomCha;
                bteLinhVuc.Tag = DmLinhVucDataProvider.Instance.GetFullInfoByKey(dm.LinhVuc);
                bteLinhVuc.Text = ((SegmentInfo) bteLinhVuc.Tag).Ten;
                bteHang.Tag = DmHangDataProvider.Instance.GetFullInfoByKey(dm.Hang);
                bteHang.Text = ((SegmentInfo)bteHang.Tag).Ten;
                bteNganh.Tag = DmNganhDataProvider.Instance.GetFullInfoByKey(dm.Nganh);
                bteNganh.Text = ((SegmentChildInfo)bteNganh.Tag).Ten;
                bteLoai.Tag = DmLoaiDataProvider.Instance.GetFullInfoByKey(dm.Loai);
                bteLoai.Text = ((SegmentChildInfo)bteLoai.Tag).Ten;
                bteChung.Tag = DmChungDataProvider.Instance.GetFullInfoByKey(dm.Chung);
                bteChung.Text = ((SegmentChildInfo)bteChung.Tag).Ten;
                bteNhom.Tag = DmNhomDataProvider.Instance.GetFullInfoByKey(dm.Nhom);
                bteNhom.Text = ((SegmentChildInfo)bteNhom.Tag).Ten;
                bteModel.Tag = DmModelDataProvider.Instance.GetFullInfoByKey(dm.Model);
                bteModel.Text = ((SegmentChildInfo)bteModel.Tag).Ten;
            }
        }
        #endregion

        #region LoadNhomCha
        private void LoadNhomCha()
        {
            cbNhomCha.DataSource = DMLoaiSanPhamDataProvider.GetLoaiSPPairInfor();
            cbNhomCha.DisplayMember = "TenLoaiSP";
            cbNhomCha.ValueMember = "IdLoaiSP";
        }
        #endregion

        #region SetLoaiSPInfo
        protected override DMLoaiSanPhamInfo GetFormInfo()
        {
            return new DMLoaiSanPhamInfo
                       {
                           GhiChu = txtMoTa.Text.Trim(),
                           MaLoaiSP = txtMa.Text.Trim(),
                           TenLoaiSP = txtTen.Text.Trim(),
                           SuDung = Convert.ToInt32(chkSuDung.Checked),
                           NhomCha = Convert.ToInt32(cbNhomCha.SelectedValue),
                           IdLoaiSP = frmList.Oid,
                           Hang = ((SegmentInfo)bteHang.Tag).Ma,
                           LinhVuc = ((SegmentInfo)bteLinhVuc.Tag).Ma,
                           Chung = ((SegmentChildInfo)bteChung.Tag).Ma,
                           Loai = ((SegmentChildInfo)bteLoai.Tag).Ma,
                           Model = ((SegmentChildInfo)bteModel.Tag).Ma,
                           Nganh = ((SegmentChildInfo)bteNganh.Tag).Ma,
                           Nhom = ((SegmentChildInfo)bteNhom.Tag).Ma
               };
        }
        #endregion

        #region TestUnit
        public void SetInput(string sTen, string sMa, string sMota, int iSudung, int LoaiSP)
        {
#if DEBUG
            txtTen.Text = sTen;
            txtMa.Text = sMa;
            txtMoTa.Text = sMota;
            chkSuDung.Checked = iSudung == 1;
            cbNhomCha.SelectedValue = LoaiSP;
#endif
        }

        #endregion

        #endregion

        private void bteLinhVuc_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_LinhVuc frmLookUp = new frmLookUp_LinhVuc(String.Format("%{0}%", bteLinhVuc.Text));
            if (frmLookUp.ShowDialog(this) == DialogResult.OK)
            {
                bteLinhVuc.Text = frmLookUp.SelectedItem.Ten;
                bteLinhVuc.Tag = frmLookUp.SelectedItem;
            }
        }

        private void bteLinhVuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_LinhVuc frmLookUp = new frmLookUp_LinhVuc(String.Format("%{0}%", bteLinhVuc.Text));
                if (frmLookUp.ShowDialog(this) == DialogResult.OK)
                {
                    bteLinhVuc.Text = frmLookUp.SelectedItem.Ten;
                    bteLinhVuc.Tag = frmLookUp.SelectedItem;
                }
            }
        }

        private void bteLoai_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_Loai frmLookUp = new frmLookUp_Loai(String.Format("%{0}%", bteLoai.Text));
            if (frmLookUp.ShowDialog(this) == DialogResult.OK)
            {
                bteLoai.Text = frmLookUp.SelectedItem.Ten;
                bteLoai.Tag = frmLookUp.SelectedItem;
            }
        }

        private void bteLoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_Loai frmLookUp = new frmLookUp_Loai(String.Format("%{0}%", bteLoai.Text));
                if (frmLookUp.ShowDialog(this) == DialogResult.OK)
                {
                    bteLoai.Text = frmLookUp.SelectedItem.Ten;
                    bteLoai.Tag = frmLookUp.SelectedItem;
                }
            }
        }

        private void bteNhom_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_Nhom frmLookUp = new frmLookUp_Nhom(String.Format("%{0}%", bteNhom.Text));
            if (frmLookUp.ShowDialog(this) == DialogResult.OK)
            {
                bteNhom.Text = frmLookUp.SelectedItem.Ten;
                bteNhom.Tag = frmLookUp.SelectedItem;
            }
        }

        private void bteNhom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_Nhom frmLookUp = new frmLookUp_Nhom(String.Format("%{0}%", bteNhom.Text));
                if (frmLookUp.ShowDialog(this) == DialogResult.OK)
                {
                    bteNhom.Text = frmLookUp.SelectedItem.Ten;
                    bteNhom.Tag = frmLookUp.SelectedItem;
                }
            }
        }

        private void bteModel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_Model frmLookUp = new frmLookUp_Model(String.Format("%{0}%", bteModel.Text));
            if (frmLookUp.ShowDialog(this) == DialogResult.OK)
            {
                bteModel.Text = frmLookUp.SelectedItem.Ten;
                bteModel.Tag = frmLookUp.SelectedItem;
            }
        }

        private void bteModel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_Model frmLookUp = new frmLookUp_Model(String.Format("%{0}%", bteModel.Text));
                if (frmLookUp.ShowDialog(this) == DialogResult.OK)
                {
                    bteModel.Text = frmLookUp.SelectedItem.Ten;
                    bteModel.Tag = frmLookUp.SelectedItem;
                }
            }
        }
        
        private void bteNganh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_Nganh frmLookUp = new frmLookUp_Nganh(String.Format("%{0}%", bteNganh.Text));
            if (frmLookUp.ShowDialog(this) == DialogResult.OK)
            {
                bteNganh.Text = frmLookUp.SelectedItem.Ten;
                bteNganh.Tag = frmLookUp.SelectedItem;
            }
        }

        private void bteNganh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_Nganh frmLookUp = new frmLookUp_Nganh(String.Format("%{0}%", bteNganh.Text));
                if (frmLookUp.ShowDialog(this) == DialogResult.OK)
                {
                    bteNganh.Text = frmLookUp.SelectedItem.Ten;
                    bteNganh.Tag = frmLookUp.SelectedItem;
                }
            }
        }

        private void bteChung_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_Chung frmLookUp = new frmLookUp_Chung(String.Format("%{0}%", bteChung.Text));
            if (frmLookUp.ShowDialog(this) == DialogResult.OK)
            {
                bteChung.Text = frmLookUp.SelectedItem.Ten;
                bteChung.Tag = frmLookUp.SelectedItem;
            }
        }

        private void bteChung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_Chung frmLookUp = new frmLookUp_Chung(String.Format("%{0}%", bteChung.Text));
                if (frmLookUp.ShowDialog(this) == DialogResult.OK)
                {
                    bteChung.Text = frmLookUp.SelectedItem.Ten;
                    bteChung.Tag = frmLookUp.SelectedItem;
                }
            }
        }

        private void bteHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_Hang frmLookUp = new frmLookUp_Hang(String.Format("%{0}%", bteHang.Text));
            if (frmLookUp.ShowDialog(this) == DialogResult.OK)
            {
                bteHang.Text = frmLookUp.SelectedItem.Ten;
                bteHang.Tag = frmLookUp.SelectedItem;
            }
        }

        private void bteHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_Hang frmLookUp = new frmLookUp_Hang(String.Format("%{0}%", bteHang.Text));
                if (frmLookUp.ShowDialog(this) == DialogResult.OK)
                {
                    bteHang.Text = frmLookUp.SelectedItem.Ten;
                    bteHang.Tag = frmLookUp.SelectedItem;
                }
            }
        }

        private void bteNganh_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(bteNganh.Text)) bteNganh.Tag = null;
        }

        private void bteChung_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteChung.Text)) bteChung.Tag = null;
        }

        private void bteHang_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteHang.Text)) bteHang.Tag = null;
        }

        private void bteLinhVuc_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteLinhVuc.Text)) bteLinhVuc.Tag = null;
        }

        private void bteLoai_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteLoai.Text)) bteLoai.Tag = null;
        }

        private void bteNhom_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteNhom.Text)) bteNhom.Tag = null;
        }

        private void bteModel_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteModel.Text)) bteModel.Tag = null;
        }

    }
}
