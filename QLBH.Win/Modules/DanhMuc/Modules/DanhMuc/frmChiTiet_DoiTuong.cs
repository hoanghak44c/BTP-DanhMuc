using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_DoiTuong : frmEditBase
    {
        private int idDoiTuong;
        private List<DoiTuong_DiaChiInfo> liDoiTuong;
        private DMDoiTuongInfo dm;
        private  Common Common=new Common();
        List<MaVungInfo> liMaVung = new List<MaVungInfo>();

        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        public frmChiTiet_DoiTuong()
        {
            InitializeComponent();
            btnCapNhat.Click += new EventHandler(btnCapNhat_Click);
            btnXoa.Click += new EventHandler(btnXoa_Click);
            btnDong.Click += new EventHandler(btnDong_Click);
        }

        public frmChiTiet_DoiTuong(int idDoiTuong)
        {
            InitializeComponent();
            this.idDoiTuong = idDoiTuong;
            btnCapNhat.Click += new EventHandler(btnCapNhat_Click);
            btnXoa.Click += new EventHandler(btnXoa_Click);
            btnDong.Click += new EventHandler(btnDong_Click);
        }

        private void LoadNhomDoiTuong()
        {
            lupNhomDoiTuong.Properties.DataSource = DmLoaiDoiTuongDataProvider.GetListLoaiDoiTuongInfor();
            lupNhomDoiTuong.Properties.DisplayMember = "TenLoaiDT";
            lupNhomDoiTuong.Properties.ValueMember = "IdLoaiDT";
        }

        private void LoadDoiTuongCha()
        {
            //lupDoiTuongCha.Properties.DataSource = DmDoiTuongProvider.GetCboDmDoiTuongInfo();
            //lupDoiTuongCha.Properties.DisplayMember = "TenDoiTuong";
            //lupDoiTuongCha.Properties.ValueMember = "IdDoiTuong";
        }

        private void LoadOderType()
        {
            //lupOrderType.Properties.DataSource = DMOrderTypeProvider.GetListOrderTypepairInfor();
            //lupOrderType.Properties.DisplayMember = "Name";
            //lupOrderType.Properties.ValueMember = "IdOrderType";
        }

        private void LoadLoaiTheKhachHang()
        {
            lupLoaiThe.Properties.DataSource = DmLoaitheKhachHangProvider.GetCboDmLoaiTheInfo();
            lupLoaiThe.Properties.DisplayMember = "TenThe";
            lupLoaiThe.Properties.ValueMember = "IdLoaiThe";
        }

        private void Reset()
        {
            txtWebSite.Text = String.Empty;
            txtTyLePhat.Text = String.Empty;
            txtTinh.Text = String.Empty;
            txtThuNhap.Text = String.Empty;
            txtTenDoiTuong.Text = String.Empty;
            txtTaiKhoan.Text = String.Empty;
            txtSoLanMuaHang.Text = String.Empty;
            txtSoDKKD.Text = String.Empty;
            txtQuocGia.Text = String.Empty;
            txtPhongBan.Text = String.Empty;
            bteOrderType.Text = String.Empty;
            bteOrderType.Tag = null;
            txtNguoiLienLac.Text = String.Empty;
            txtNgheNghiep.Text = String.Empty;
            deNgaySinh.Text = String.Empty;
            deNgayCapThe.Text = String.Empty;
            txtNganHang.Text = String.Empty;
            txtMaSoThue.Text = String.Empty;
            txtMaRieng.Text = String.Empty;
            txtMaDoiTuong.Text = String.Empty;
            lupLoaiThe.Text = String.Empty;
            txtKnownFrom.Text = String.Empty;
            txtHuyen.Text = String.Empty;
            txtHanTra.Text = String.Empty;
            txtHanMucTinDung.Text = String.Empty;
            cboGioiTinh.Text = String.Empty;
            txtGiaTriMuaHang.Text = String.Empty;
            txtFax.Text = String.Empty;
            txtEmailDT.Text = String.Empty;
            txtEmailCDN.Text = String.Empty;
            txtDoTuoi.Text = String.Empty;
            txtDienThoaiNLL.Text = String.Empty;
            txtDienThoaiDT.Text = String.Empty;
            txtDienThoaiCDN.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtCMTNLL.Text = String.Empty;
            txtCMTDT.Text = String.Empty;
            txtCDN.Text = String.Empty;
            cboLoaiDoiTuong.Text = String.Empty;
            txtCongNoKhachHang.Text = String.Empty;
        }

        private void SetFormInfo(DMDoiTuongInfo doiTuongInfo)
        {
            txtWebSite.Text = doiTuongInfo.WebSite;
            txtTyLePhat.Text = Convert.ToString(doiTuongInfo.TyLePhat);
            txtTinh.Text = doiTuongInfo.Tinh;
            txtThuNhap.Text = Convert.ToString(doiTuongInfo.ThuNhap);
            txtTenDoiTuong.Text = doiTuongInfo.TenDoiTuong;
            txtTaiKhoan.Text = doiTuongInfo.TaiKhoan;
            txtSoLanMuaHang.Text = Convert.ToString(doiTuongInfo.SoLanMuaHang);
            txtSoDKKD.Text = doiTuongInfo.SoDKKD;
            txtQuocGia.Text = doiTuongInfo.QuocGia;
            txtPhongBan.Text = doiTuongInfo.PhongBan;
            //lupOrderType.EditValue = doiTuongInfo.IdOrderType;
            bteOrderType.Tag = DMOrderTypeProvider.GetListDmOrderTypeInfoFromOid(doiTuongInfo.IdOrderType);
            bteOrderType.Text = bteOrderType.Tag == null ? String.Empty : ((DMOrderTypeInfor) bteOrderType.Tag).LineType;
            txtNguoiLienLac.Text = doiTuongInfo.NguoiLienLac;
            txtNgheNghiep.Text = doiTuongInfo.NgheNghiep;
            deNgaySinh.EditValue = doiTuongInfo.NgaySinh;
            deNgayCapThe.EditValue = doiTuongInfo.NgayCapThe;
            txtNganHang.Text = doiTuongInfo.NganHang;
            txtMaSoThue.Text = doiTuongInfo.MaSoThue;
            txtMaRieng.Text = doiTuongInfo.MaRieng;
            txtMaDoiTuong.Text = doiTuongInfo.MaDoiTuong;
            lupLoaiThe.EditValue = doiTuongInfo.IdLoaiThe;
            txtKnownFrom.Text = doiTuongInfo.Biet_Ta_Tu;
            txtHuyen.Text = doiTuongInfo.Huyen;
            txtHanTra.Text = Convert.ToString(doiTuongInfo.HanTra);
            txtHanMucTinDung.Text = Common.Double2Str(doiTuongInfo.HanMucTinDung);
            txtHMTDConLai.Text = Common.Double2Str(doiTuongInfo.HanMucTDConLai);
            cboGioiTinh.SelectedIndex = doiTuongInfo.GioiTinh > 2 ? 0 : doiTuongInfo.GioiTinh;
            txtGiaTriMuaHang.Text = Common.Double2Str(doiTuongInfo.GiaTriMuaHang);
            txtFax.Text = doiTuongInfo.Fax;
            txtEmailDT.Text = doiTuongInfo.Email;
            txtEmailCDN.Text = doiTuongInfo.Email_CDN;
            txtDoTuoi.Text = Convert.ToString(doiTuongInfo.DoTuoi);
            txtDienThoaiNLL.Text = doiTuongInfo.DienThoai_NLL;
            txtDienThoaiDT.Text = doiTuongInfo.DienThoai;
            txtDienThoaiCDN.Text = doiTuongInfo.DienThoai_CDN;
            txtDiaChi.Text = doiTuongInfo.DiaChi;
            txtCMTNLL.Text = doiTuongInfo.CMND_NLL;
            txtCMTDT.Text = doiTuongInfo.SoCMND;
            txtCDN.Text = doiTuongInfo.ChuDoanhNghiep;
            cboLoaiDoiTuong.SelectedIndex = doiTuongInfo.Type;
            //lupDoiTuongCha.EditValue = doiTuongInfo.IdCha;
            bteDoiTuongCha.Tag = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(doiTuongInfo.IdCha);
            bteDoiTuongCha.Text = bteDoiTuongCha.Tag == null ? String.Empty : ((DMDoiTuongInfo)bteDoiTuongCha.Tag).TenDoiTuong;
            lupNhomDoiTuong.EditValue = doiTuongInfo.IdLoaiDoiTuong;
            txtBillTo.Text = Convert.ToString(doiTuongInfo.BillTo);
            txtShipTo.Text = Convert.ToString(doiTuongInfo.ShipTo);
            txtCongNoKhachHang.Text = Common.Double2Str(doiTuongInfo.CongNoKhachHang);
        }

        private DMDoiTuongInfo GetFormInfo()
        {
            return new DMDoiTuongInfo()
                       {
                           IdCha = bteDoiTuongCha.Tag == null ? 0 :((DMDoiTuongInfo)bteDoiTuongCha.Tag).IdDoiTuong,
                           IdLoaiDoiTuong = Convert.ToInt32(lupNhomDoiTuong.EditValue),
                           IdOrderType = bteOrderType.Tag == null ? 0 : ((DMOrderTypeInfor)bteOrderType.Tag).IdOrderType,
                           MaDoiTuong = txtMaDoiTuong.Text.Trim(),
                           TenDoiTuong = txtTenDoiTuong.Text.Trim(),
                           MaSoThue = txtMaSoThue.Text.Trim(),
                           NguoiLienLac = txtNguoiLienLac.Text.Trim(),
                           NgaySinh = Convert.ToDateTime(deNgaySinh.EditValue),
                           Fax = txtFax.Text.Trim(),
                           Email = txtEmailDT.Text.Trim(),
                           DienThoai = txtDienThoaiDT.Text.Trim(),
                           SuDung = Convert.ToInt32(chkSuDung.Checked),
                           DiaChi = txtDiaChi.Text.Trim(),
                           GioiTinh = cboGioiTinh.SelectedIndex,
                           Type = cboLoaiDoiTuong.SelectedIndex,
                           MaRieng = txtMaRieng.Text.Trim(),
                           SoCMND = txtCMTDT.Text.Trim(),
                           Biet_Ta_Tu = txtKnownFrom.Text.Trim(),
                           ChuDoanhNghiep = txtCDN.Text,
                           CMND_NLL = txtCMTNLL.Text,
                           DienThoai_CDN = txtDienThoaiCDN.Text,
                           DienThoai_NLL = txtDienThoaiNLL.Text,
                           DoTuoi = Convert.ToInt32(txtDoTuoi.Text),
                           Email_CDN = txtEmailCDN.Text,
                           GhiChu = txtGhiChu.Text,
                           GiaTriMuaHang = Common.DoubleValue(txtGiaTriMuaHang.Text),
                           HanMucTinDung = Common.DoubleValue(txtHanMucTinDung.Text),
                           HanTra = Convert.ToInt32(txtHanTra.Text),
                           Huyen = txtHuyen.Text,
                           IdLoaiThe = Convert.ToInt32(lupLoaiThe.EditValue),
                           IdDoiTuong = idDoiTuong,
                           //todo: @HAH Ma vung nay de lam gi?
                           MaVung = String.Empty,
                           NganHang = txtNganHang.Text,
                           NgayCapThe = Convert.ToDateTime(deNgayCapThe.EditValue),
                           NgheNghiep = txtNgheNghiep.Text,
                           PhongBan = txtPhongBan.Text,
                           QuocGia = txtQuocGia.Text,
                           //todo: @HAH Site number nay de lam gi?
                           SiteNumber = String.Empty,
                           SoDKKD = txtSoDKKD.Text,
                           SoLanMuaHang = Convert.ToInt32(txtSoLanMuaHang.Text),
                           TaiKhoan = txtTaiKhoan.Text,
                           ThuNhap = Convert.ToInt32(txtThuNhap.Text),
                           Tinh = txtTinh.Text,
                           TyLePhat = Convert.ToDouble(txtTyLePhat.Text),
                           WebSite = txtWebSite.Text,
                           BillTo = Convert.ToInt32(txtBillTo.Text),
                           ShipTo = Convert.ToInt32(txtShipTo.Text),
                           HanMucTDConLai = Common.DoubleValue(txtHMTDConLai.Text),
                           CongNoKhachHang = Common.DoubleValue(txtCongNoKhachHang.Text)
                       };
        }

        protected override bool IsAddMode()
        {
            return idDoiTuong == 0;
        }

        private void LoadMaVung()
        {
            liMaVung = MaVungDataProvider.GetListDMMaVungInfo();
            //if (liMaVung.Count > 0)
            //{
                repositoryItemLookUpEdit1.Properties.DataSource = liMaVung;
                repositoryItemLookUpEdit1.Properties.ValueMember = "MaVung";
                repositoryItemLookUpEdit1.Properties.DisplayMember = "TenVung";
            //}
            //else
            //{
            //    repositoryItemLookUpEdit1.Properties.DataSource = null;
            //}
        }

        protected override void LoadData()
        {
            LoadDoiTuongCha();
            LoadLoaiTheKhachHang();
            LoadOderType();
            LoadNhomDoiTuong();
            LoadMaVung();
            txtDoTuoi.Text = "0";
            txtDienThoaiDT.Text = "0";
            txtDienThoaiNLL.Text = "0";
            txtDienThoaiCDN.Text = "0";
            txtFax.Text = "0";
            txtCMTNLL.Text = "0";
            txtCMTDT.Text = "0";
            txtTyLePhat.Text = "0";
            txtThuNhap.Text = "0";
            txtSoLanMuaHang.Text = "0";
            txtHanTra.Text = "0";
            txtHanMucTinDung.Text = "0";
            txtGiaTriMuaHang.Text = "0";
            txtCongNoKhachHang.Text = "0";
            liDoiTuong = new List<DoiTuong_DiaChiInfo>();
            if (idDoiTuong == 0)
            {
                Reset();
                txtMaDoiTuong.Enabled = true;
            }
            else
            {
                dm = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(idDoiTuong);
                liDoiTuong = DoiTuong_DiaChiDataProvider.GetListDoiTuongDiaChiInfoFromIdDoiTuong(idDoiTuong);
                if(dm != null) SetFormInfo(dm);
            }
            grCtlSiteNum.DataSource = new BindingList<DoiTuong_DiaChiInfo>(liDoiTuong) { AllowNew = true, AllowEdit = true, AllowRemove = true };

            txtHanMucTinDung.Enabled = nguoiDung.SupperUser == 1;
            txtHanTra.Enabled = nguoiDung.SupperUser == 1;
            txtCongNoKhachHang.Enabled = nguoiDung.SupperUser == 1;

        }
        
        protected override void CheckOnSave()
        {
            if (String.IsNullOrEmpty(txtMaDoiTuong.Text))
            {
                txtMaDoiTuong.Focus();
                throw new InvalidOperationException("Mã khách hàng không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTenDoiTuong.Text))
            {
                txtTenDoiTuong.Focus();
                throw new InvalidOperationException("Tên khách hàng không được để trống !");
            }
            if (txtEmailCDN.Text.Trim().Length > 0 && Common.ValidEmail(txtEmailCDN.Text.Trim()) == false)
                {
                    txtEmailCDN.Focus();
                    throw new InvalidExpressionException("Email chưa đúng định dạng!");
                }
            if (txtEmailDT.Text.Trim().Length > 0 && Common.ValidEmail(txtEmailDT.Text.Trim()) == false)
                {
                    txtEmailDT.Focus();
                    throw new InvalidExpressionException("Email chưa đúng định dạng!");
                }
            if (Equals(cboGioiTinh.SelectedItem, String.Empty))
            {
                cboGioiTinh.Focus();
                throw new InvalidOperationException("Giới tính không được để trống !");
            }
            if (Equals(cboLoaiDoiTuong.SelectedItem , String.Empty))
            {
                cboLoaiDoiTuong.Focus();
                throw new InvalidOperationException("Chưa chọn kiểu !");
            }
            //if (bteOrderType.Tag == null)
            //{
            //    bteOrderType.Focus();
            //    throw new InvalidOperationException("Chưa chọn OrderType !");
            //}
            if (Equals(cboLoaiDoiTuong.SelectedItem , String.Empty))
            {
                cboLoaiDoiTuong.Focus();
                throw new InvalidOperationException("Chưa chọn Loại đối tượng !");
            }
            //if (Common.DoubleValue(txtCongNoKhachHang.Text) < 0)
            //{
            //    txtCongNoKhachHang.Focus();
            //    throw new InvalidOperationException("Công nợ khách hàng không thể âm !");
            //}
            if (DmDoiTuongProvider.Instance.IsSync())
            {
                if (txtMaDoiTuong.Text != dm.MaDoiTuong)
                {
                    throw new InvalidOperationException("Mã khách hàng đã bị thay đổi !");
                }
                //if (txtMaSoThue.Text != dm.MaSoThue)
                //{
                //    throw new InvalidOperationException("Mã số thuế  đã bị thay đổi !");
                //}
            }

            if (DmDoiTuongProvider.KiemTra(new DMDoiTuongInfo { IdDoiTuong = idDoiTuong, MaDoiTuong = txtMaDoiTuong.Text.Trim() }))
            {
                throw new InvalidOperationException("Mã khách hàng đã tồn tại trong hệ thống !");
            }
        }

        private void SaveDiaChi(int oidDoiTuong)
        {
            DoiTuong_DiaChiInfo dt = new DoiTuong_DiaChiInfo();
            dt.IdDoiTuong = oidDoiTuong;
            DoiTuong_DiaChiDataProvider.Delete(dt);
            if (liDoiTuong.Count > 0)
            {
                for (int i = 0; i < liDoiTuong.Count; i++)
                {
                    dt.IdDoiTuong = oidDoiTuong;
                    dt.MaVung = liDoiTuong[i].MaVung;
                    dt.DiaChi = liDoiTuong[i].DiaChi;
                    dt.SiteNumber = liDoiTuong[i].SiteNumber;
                    DoiTuong_DiaChiDataProvider.Insert(dt);
                }
            }
        }

        protected override void SaveInstance()
        {
            try
            {
                ConnectionUtil.Instance.BeginTransaction();
                if (IsAddMode())
                {
                    SaveDiaChi(DmDoiTuongProvider.Insert(GetFormInfo()));
                }
                else
                {
                    DmDoiTuongProvider.Update(GetFormInfo());
                    SaveDiaChi(idDoiTuong);
                }
                ConnectionUtil.Instance.CommitTransaction();
            }
            catch (Exception)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                throw;
            }
        }

        protected override void CheckOnDelete()
        {
            if (IsAddMode())
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            if (DmDoiTuongProvider.Instance.IsSync())
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
        }

        protected override void DeleteInstance()
        {
            DmDoiTuongProvider.Delete(new DMDoiTuongInfo { IdDoiTuong = idDoiTuong });
        }

        private void txtDoTuoi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDoTuoi.Text != "")
                    Convert.ToInt32(txtDoTuoi.Text);
            }
            catch
            {
                //MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtDoTuoi.SelectAll();
            }
        }

        private void txtCMTDT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCMTDT.Text != "")
                    Convert.ToInt32(txtCMTDT.Text);
            }
            catch
            {
                //MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtCMTDT.SelectAll();
            }
        }

        private void txtDienThoaiDT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDienThoaiDT.Text != "")
                    Convert.ToInt32(txtDienThoaiDT.Text);
            }
            catch
            {
                //MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtDienThoaiDT.SelectAll();
            }
        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFax.Text != "")
                    Convert.ToInt32(txtFax.Text);
            }
            catch
            {
                //MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtFax.SelectAll();
            }
        }

        private void txtDienThoaiCDN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDienThoaiCDN.Text != "")
                    Convert.ToInt32(txtDienThoaiCDN.Text);
            }
            catch
            {
                //MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtDienThoaiCDN.SelectAll();
            }
        }

        private void txtCMTNLL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCMTNLL.Text != "")
                    Convert.ToInt32(txtCMTNLL.Text);
            }
            catch
            {
                //MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtCMTNLL.SelectAll();
            }
        }

        private void txtDienThoaiNLL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDienThoaiNLL.Text != "")
                    Convert.ToInt32(txtDienThoaiNLL.Text);
            }
            catch
            {
                //MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtDienThoaiNLL.SelectAll();
            }
        }

        private void deNgaySinh_EditValueChanged(object sender, EventArgs e)
        {
            //if(deNgaySinh.Text == String.Empty)
            //    return;
            //if (Common.TestBirthDate(Convert.ToDateTime(deNgaySinh.EditValue)) == false)
            //{
            //    MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại!");
            //    deNgaySinh.Text = "";
            //}
        }

        private void txtHanMucTinDung_EditValueChanged(object sender, EventArgs e)
        {
            double hanMucTDConNo = Common.DoubleValue(txtHanMucTinDung.Text) - Common.DoubleValue(txtCongNoKhachHang.Text);
            txtHMTDConLai.Text = Common.Double2Str(hanMucTDConNo);
        }

        private void txtCongNoKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            txtHanMucTinDung_EditValueChanged(sender, e);
        }

        private void bteDoiTuongCha_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_KhachHang frmLookUpKhachHang = new frmLookUp_KhachHang("%%");
            if(frmLookUpKhachHang.ShowDialog() == DialogResult.OK)
            {
                bteDoiTuongCha.Tag = frmLookUpKhachHang.SelectedItem;
                bteDoiTuongCha.Text = frmLookUpKhachHang.SelectedItem.TenDoiTuong;
            }
        }

        private void bteDoiTuongCha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                frmLookUp_KhachHang frmLookUpKhachHang = new frmLookUp_KhachHang("%%");
                if (frmLookUpKhachHang.ShowDialog() == DialogResult.OK)
                {
                    bteDoiTuongCha.Tag = frmLookUpKhachHang.SelectedItem;
                    bteDoiTuongCha.Text = frmLookUpKhachHang.SelectedItem.TenDoiTuong;
                }                
            }
        }

        private void bteOrderType_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_OrderType frmLookUpOrderType = new frmLookUp_OrderType(String.Format("%{0}%", bteOrderType.Text));
            if (frmLookUpOrderType.ShowDialog() == DialogResult.OK)
            {
                bteOrderType.Tag = frmLookUpOrderType.SelectedItem;
                bteOrderType.Text = frmLookUpOrderType.SelectedItem.LineType;
            }
        }

        private void bteOrderType_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                frmLookUp_OrderType frmLookUpOrderType = new frmLookUp_OrderType(String.Format("%{0}%", bteOrderType.Text));
                if (frmLookUpOrderType.ShowDialog() == DialogResult.OK)
                {
                    bteOrderType.Tag = frmLookUpOrderType.SelectedItem;
                    bteOrderType.Text = frmLookUpOrderType.SelectedItem.LineType;
                }                
            }
        }

       
    }
}