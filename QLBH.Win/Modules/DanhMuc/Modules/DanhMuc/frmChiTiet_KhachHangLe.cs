using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBH.Core.Data;

// <Remarks>
// form frmChiTiet_KhachHangLe
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 23/05/2012
// Ngày sửa cuối:
// </remarks>
//Note:@HanhBD frmChiTiet_KhachHangLe
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_KhachHangLe : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        frmDM_KhachHangLe frmKHL;
        List<DMDoiTuongPairInfo> liKhachHang = new List<DMDoiTuongPairInfo>();
        List<DmLoaiDoiTuongInfor> liLoaiDoiTuong = new List<DmLoaiDoiTuongInfor>();
        List<DMOrderTypePairInfor> litype = new List<DMOrderTypePairInfor>();
        List<MaVungInfo> liMaVung = new List<MaVungInfo>();
        DMDoiTuongInfo dm = new DMDoiTuongInfo();
        //DmLoaiDoiTuongInfor oj = new DmLoaiDoiTuongInfor();
        List<DoiTuong_DiaChiInfo> liDoiTuong = new List<DoiTuong_DiaChiInfo>();

        private NguoiDungInfor nguoiDung = Declare.USER_INFOR != null
                                               ? (NguoiDungInfor)Declare.USER_INFOR
                                               : new NguoiDungInfor();

        #endregion
        public frmChiTiet_KhachHangLe()
        {
            InitializeComponent();
        }

        public frmChiTiet_KhachHangLe(frmDM_KhachHangLe frm)
        {
            InitializeComponent();
            this.frmKHL = frm;
        }

        #region Action

        #region LoadNhomCha
        private void LoadNhomCha()
        {
            liLoaiDoiTuong = DmLoaiDoiTuongDataProvider.GetListLoaiDoiTuongInfor();
            if (liLoaiDoiTuong.Count > 0)
            {
                cboNhomCha.DataSource = liLoaiDoiTuong;
                cboNhomCha.DisplayMember = "TenLoaiDT";
                cboNhomCha.ValueMember = "IdLoaiDT";
            }
            else
            {
                cboNhomCha.DataSource = null;
            }
        }
        #endregion
        #region LoadDoiTuongCha
        private void LoadDoiTuongCha()
        {
            DMDoiTuongInfo dmDoiTuongInfo = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(dm.IdCha);
            bteDoiTuongCha.Tag = dmDoiTuongInfo;
            bteDoiTuongCha.Text = dmDoiTuongInfo.TenDoiTuong;
            txtMa.Text = dmDoiTuongInfo.MaDoiTuong;
        }
        #endregion

        #region LoadOderType
        private void LoadOderType()
        {
            litype = DMOrderTypeProvider.GetListOrderTypepairInfor();
            if (litype.Count > 0)
            {
                cboOrderType.DataSource = litype;
                cboOrderType.DisplayMember = "Name";
                cboOrderType.ValueMember = "IdOrderType";
            }
            else
            {
                cboOrderType.DataSource = null;
            }
        }
        #endregion

        #region LoadMaVung
        private void LoadMaVung()
        {
            liMaVung = MaVungDataProvider.GetListDMMaVungInfo();
            if (liMaVung.Count > 0)
            {
                clMaVung.DataSource = liMaVung;
                clMaVung.DisplayMember = "TenVung";
                clMaVung.ValueMember = "MaVung";
            }
            else
            {
                clMaVung.DataSource = null;
            }
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            if ((frmKHL != null && frmKHL.isAdd) || frmKHL == null)
            {
                btnXoa.Enabled = false;
                txtTen.Text = String.Empty;
                txtOrderType.Text = String.Empty;
                txtNguoiLienLac.Text = String.Empty;
                txtMaSoThue.Text = String.Empty;
                txtMa.Text = String.Empty;
                txtDiaChi.Text = String.Empty;
                txtFax.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtDienThoai.Text = String.Empty;
                txtMaRieng.Text = String.Empty;
                txtSoCMND.Text = String.Empty;
                dgvDiaChi.DataSource = new BindingList<DoiTuong_DiaChiInfo>(liDoiTuong) { AllowNew = true, AllowEdit = true, AllowRemove = true };
                txtMa.Enabled = true;
                txtHanMucTinDung.Text = String.Empty;
                txtHanMucTDConLai.Text = String.Empty;
                txtCongNoKhachHang.Text = String.Empty;
                txtGiaTriDaMua.Text = String.Empty;
            }
            else
            {
                btnXoa.Enabled = false;
                txtMa.Enabled = false;
                dm = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(frmKHL.Oid);
                liDoiTuong = DoiTuong_DiaChiDataProvider.GetListDoiTuongDiaChiInfoFromIdDoiTuong(frmKHL.Oid);
                txtTen.Text = dm.TenDoiTuong;
                txtNguoiLienLac.Text = dm.NguoiLienLac;
                txtMaSoThue.Text = dm.MaSoThue;
                txtMa.Text = dm.MaDoiTuong;
                txtDiaChi.Text = dm.DiaChi;
                txtFax.Text = dm.Fax;
                txtEmail.Text = dm.Email;
                txtDienThoai.Text = dm.DienThoai;
                txtMaRieng.Text = dm.MaRieng;
                txtSoCMND.Text = dm.SoCMND;
                txtNgaySinh.Text = Convert.ToString(dm.NgaySinh);
                chkSuDung.Checked = dm.SuDung == 1;
                cboGioiTinh.SelectedIndex = dm.GioiTinh > 2 ? 0 : dm.GioiTinh;
                cboNhomCha.SelectedValue = dm.IdLoaiDoiTuong;
                //cboType.SelectedIndex = dm.Type;
                txtHanMucTinDung.Text = Common.Double2Str(dm.HanMucTinDung);
                txtHanMucTDConLai.Text = Common.Double2Str(dm.HanMucTDConLai);
                txtCongNoKhachHang.Text = Common.Double2Str(dm.CongNoKhachHang);
                txtGiaTriDaMua.Text = Common.Double2Str(dm.GiaTriMuaHang);

                DMDoiTuongInfo dmDoiTuongInfo = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(dm.IdCha);
                bteDoiTuongCha.Tag = dmDoiTuongInfo;
                bteDoiTuongCha.Text = dmDoiTuongInfo.TenDoiTuong;
                cboOrderType.SelectedValue = dm.IdOrderType;
                dgvDiaChi.DataSource = new BindingList<DoiTuong_DiaChiInfo>(liDoiTuong) { AllowNew = true, AllowEdit = true, AllowRemove = true };
            }
            txtHanMucTinDung.Enabled = nguoiDung.SupperUser == 1;
            txtHanTra.Enabled = nguoiDung.SupperUser == 1;
            txtCongNoKhachHang.Enabled = nguoiDung.SupperUser == 1;
        }
        #endregion

        #region SaveDiaChi
        private void SaveDiaChi(int OidDoiTuong)
        {
            DoiTuong_DiaChiInfo dt = new DoiTuong_DiaChiInfo();
            dt.IdDoiTuong = OidDoiTuong;
            DoiTuong_DiaChiDataProvider.Delete(dt);
            if (liDoiTuong.Count > 0)
            {
                for (int i = 0; i < liDoiTuong.Count; i++)
                {
                    dt.IdDoiTuong = OidDoiTuong;
                    dt.MaVung = liDoiTuong[i].MaVung;
                    dt.DiaChi = liDoiTuong[i].DiaChi;
                    dt.SiteNumber = liDoiTuong[i].SiteNumber;
                    DoiTuong_DiaChiDataProvider.Insert(dt);
                }
            }
        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMa.Text))
            {
                txtMa.Focus();
                throw new InvalidOperationException("Mã khách hàng không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTen.Text))
            {
                txtTen.Focus();
                throw new InvalidOperationException("Tên khách hàng không được để trống !");
            }

            if (Equals(cboGioiTinh.SelectedItem, String.Empty))
            {
                cboGioiTinh.Focus();
                throw new InvalidOperationException("Bạn chưa chọn giới tính !");
            }
            if (txtEmail.Text.Trim().Length > 0 && Common.ValidEmail(txtEmail.Text.Trim()) == false)
            {
                txtEmail.Focus();
                throw new InvalidExpressionException("Email chưa đúng định dạng!");
            }
            //if (Equals(cboType.SelectedItem, String.Empty))
            //{
            //    cboType.Focus();
            //    throw new InvalidOperationException("bạn chưa chọn loại đối tượng !");
            //}
            if (Equals(cboOrderType.SelectedItem, String.Empty))
            {
                cboOrderType.Focus();
                throw new InvalidOperationException("Bạn chưa chọn OrderType !");
            }
            if (Equals(bteDoiTuongCha.Tag, null))
            {
                bteDoiTuongCha.Focus();
                throw new InvalidOperationException("Bạn chưa chọn đối tượng cha !");
            }
            if (String.IsNullOrEmpty(txtMaRieng.Text))
            {
                txtMaRieng.Focus();
                throw new InvalidOperationException("Mã riêng không được để trống !");
            }
            //if (Common.DoubleValue(txtCongNoKhachHang.Text) < 0)
            //{
            //    txtCongNoKhachHang.Focus();
            //    throw new InvalidOperationException("Công nợ khách hàng không thể âm !");
            //}
            if (DmDoiTuongProvider.KiemTraLe(new DMDoiTuongInfo {IdDoiTuong = frmKHL == null ? 0 : frmKHL.Oid, MaRieng = txtMaRieng.Text.Trim()}))
            {
                txtMaRieng.Focus();
                throw new InvalidOperationException("Mã riêng đã tồn tại trong hệ thống !");
            }
            return true;
        }
        #endregion

        #region SetKhachHang
        private DMDoiTuongInfo SetKhachHangInfo()
        {
            //oj.IdLoaiDT = Convert.ToInt32(cboNhomCha.SelectedValue);
            //return new DMDoiTuongInfo
            //   {
            //       IdCha = Convert.ToInt32(cboCha.SelectedValue),
            //       IdOrderType = Convert.ToInt32(cboOrderType.SelectedValue),
            //       MaDoiTuong = txtMa.Text.Trim(),
            //       TenDoiTuong = txtTen.Text.Trim(),
            //       MaSoThue = txtMaSoThue.Text.Trim(),
            //       NguoiLienLac = txtNguoiLienLac.Text.Trim(),
            //       NgaySinh = txtNgaySinh.Value,
            //       Fax = txtFax.Text.Trim(),
            //       Email = txtEmail.Text.Trim(),
            //       DienThoai = txtDienThoai.Text.Trim(),
            //       SuDung = Convert.ToInt32(chkSuDung.Checked),
            //       DiaChi = txtDiaChi.Text.Trim(),
            //       GioiTinh = (cboGioiTinh.SelectedIndex + 1)%3 - 1,
            //       Type = cboType.SelectedIndex,
            //       MaRieng = txtMaRieng.Text.Trim(),
            //       SoCMND = txtSoCMND.Text.Trim()
            //   };
            DMDoiTuongInfo dm = new DMDoiTuongInfo();
            dm.IdCha = ((DMDoiTuongInfo)bteDoiTuongCha.Tag).IdDoiTuong;
            dm.IdLoaiDoiTuong = Convert.ToInt32(cboNhomCha.SelectedValue);
            dm.IdOrderType = Convert.ToInt32(cboOrderType.SelectedValue);
            dm.MaDoiTuong = txtMa.Text.Trim();
            dm.TenDoiTuong = txtTen.Text.Trim();
            dm.MaSoThue = txtMaSoThue.Text.Trim();
            dm.NguoiLienLac = txtNguoiLienLac.Text.Trim();
            dm.NgaySinh = txtNgaySinh.Value;
            dm.Fax = txtFax.Text.Trim();
            dm.Email = txtEmail.Text.Trim();
            dm.DienThoai = txtDienThoai.Text.Trim();
            dm.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dm.DiaChi = txtDiaChi.Text.Trim();
            dm.GioiTinh = cboGioiTinh.SelectedIndex;// (cboGioiTinh.SelectedIndex + 1) % 3 - 1;
            dm.Type = 1;//cboType.SelectedIndex;
            dm.MaRieng = txtMaRieng.Text.Trim();
            dm.SoCMND = txtSoCMND.Text.Trim();
            dm.BillTo = ((DMDoiTuongInfo) bteDoiTuongCha.Tag).BillTo;
            dm.ShipTo = ((DMDoiTuongInfo) bteDoiTuongCha.Tag).ShipTo;
            dm.HanMucTinDung = Common.DoubleValue(txtHanMucTinDung.Text);
            dm.HanMucTDConLai = Common.DoubleValue(txtHanMucTDConLai.Text);
            dm.CongNoKhachHang = Common.DoubleValue(txtCongNoKhachHang.Text);
            dm.GiaTriMuaHang = Common.DoubleValue(txtGiaTriDaMua.Text);
            return dm;
        }
        #endregion

        #region SaveDoiTuong
        private void SaveDoiTuong()
        {
            if (Check())
            {
                try
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    if ((frmKHL != null && frmKHL.isAdd) || frmKHL == null)
                    {
                        int oid = DmDoiTuongProvider.Insert(SetKhachHangInfo());
                        SaveDiaChi(oid);
                    }
                    else
                    {
                        DMDoiTuongInfo info = SetKhachHangInfo();
                        info.IdDoiTuong = frmKHL.Oid;
                        DmDoiTuongProvider.Update(info);
                        SaveDiaChi(info.IdDoiTuong);
                    }
                    ConnectionUtil.Instance.CommitTransaction();
                }
                catch (Exception)
                {
                    ConnectionUtil.Instance.RollbackTransaction();
                    throw;
                }
            }
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (frmKHL.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            DmDoiTuongProvider.Delete(new DMDoiTuongInfo { IdDoiTuong = frmKHL.Oid });
        }
        #endregion

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDoiTuong();
                if (frmKHL == null || frmKHL.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                if (frmKHL != null)
                {
                    frmKHL.ReLoad();
                    frmKHL.SetControl(false);                    
                }
                this.Close();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        #endregion

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
                MessageBox.Show("Xóa thành công bản ghi!");
                if (frmKHL != null)
                {
                    frmKHL.ReLoad();
                    frmKHL.SetControl(false);
                }
                this.Close();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTiet_KhachHangLe_Load(object sender, EventArgs e)
        {
            LoadNhomCha();
            //LoadDoiTuongCha();
            LoadMaVung();
            LoadOderType();
            LoadData();
            txtMa.Enabled = false;
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDienThoai.Text != "")
                    Convert.ToInt32(txtDienThoai.Text);
            }
            catch
            {
                MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtDienThoai.SelectAll();
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
                MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtFax.SelectAll();
            }
        }

        private void txtSoCMND_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoCMND.Text != "")
                    Convert.ToInt32(txtSoCMND.Text);
            }
            catch
            {
                MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtSoCMND.SelectAll();
            }
        }

        private void bteDoiTuongCha_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_KhachHang frmLookUp = new frmLookUp_KhachHang(String.Format("%{0}%", bteDoiTuongCha.Text));
            if(frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteDoiTuongCha.Tag = frmLookUp.SelectedItem;
                bteDoiTuongCha.Text = frmLookUp.SelectedItem.TenDoiTuong;
                txtMa.Text = frmLookUp.SelectedItem.MaDoiTuong;
            }
        }

        private void bteDoiTuongCha_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(bteDoiTuongCha.Text))
            {
                bteDoiTuongCha.Tag = null;
                txtMa.Text = String.Empty;
            }
        }

        private void bteDoiTuongCha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                frmLookUp_KhachHang frmLookUp = new frmLookUp_KhachHang(String.Format("%{0}%", bteDoiTuongCha.Text));
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteDoiTuongCha.Tag = frmLookUp.SelectedItem;
                    bteDoiTuongCha.Text = frmLookUp.SelectedItem.TenDoiTuong;
                    txtMa.Text = frmLookUp.SelectedItem.MaDoiTuong;
                }
            }
        }

        private void bteDoiTuongCha_DoubleClick(object sender, EventArgs e)
        {
            frmLookUp_KhachHang frmLookUp = new frmLookUp_KhachHang(String.Format("%{0}%", bteDoiTuongCha.Text));
            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteDoiTuongCha.Tag = frmLookUp.SelectedItem;
                bteDoiTuongCha.Text = frmLookUp.SelectedItem.TenDoiTuong;
                txtMa.Text = frmLookUp.SelectedItem.MaDoiTuong;
            }
        }

        private void txtHanMucTinDung_TextChanged(object sender, EventArgs e)
        {
            double hanMucTDConNo = Common.DoubleValue(txtHanMucTinDung.Text) - Common.DoubleValue(txtCongNoKhachHang.Text);
            txtHanMucTDConLai.Text = Common.Double2Str(hanMucTDConNo);
        }

        private void txtCongNoKhachHang_TextChanged(object sender, EventArgs e)
        {
            txtHanMucTinDung_TextChanged(sender, e);
        }
    }
}