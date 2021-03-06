using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc
{
    //Note:@CuongTT frmChiTiet_The
    public partial class frmChiTiet_The : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        frmDM_The frmThe;
        List<DMSanPhamPairInfo> liSP = new List<DMSanPhamPairInfo>();
        DMLoaiTheKhachHangInfo dm = new DMLoaiTheKhachHangInfo();
        List<DmLoaiTheQuyenLoiInfo> dmtheQL = new List<DmLoaiTheQuyenLoiInfo>();
        List<DmLoaiTheUuDaiInfo> dmTheUD = new List<DmLoaiTheUuDaiInfo>();
        #endregion

        #region frmChiTiet_The
        public frmChiTiet_The()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmChiTiet_The(frmDM_The frm)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.frmThe = frm;
        }
        #endregion

        #region Action

        #region LoadSanPhamAll
        private  void LoadSanPhamAll()
        {
            liSP = DmSanPhamProvider.GetCboDmSanPhamInfo();
            chkLstSanPham.DataSource = liSP;
            chkLstSanPham.DisplayMember = "TenSanPham";
            chkLstSanPham.ValueMember = "IdSanPham";
            colSanPham.DataSource = liSP;
            colSanPham.DisplayMember = "TenSanPham";
            colSanPham.ValueMember = "IdSanPham";
        }
        private bool Select(DMSanPhamInfo dmSanPhamInfo)
        {
            return (dmSanPhamInfo.IdCha == 0 || dmSanPhamInfo.IdCha.ToString() == string.Empty);
        }
        #endregion

        #region LoadDoUuTien
        private void LoadDoUuTien()
        {
            List<int> liDoUuTien = new List<int>();
            for (int i = 1; i < 10; i++)
            {
                liDoUuTien.Add(i);
            }
            cboDoUuTien.DataSource = liDoUuTien;
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            if (frmThe.isAdd)
            {
                txtBaoLuuDiem.Text = "";
                txtTinhNangKhac.Text = "";
                txtTichLuyTu.Text = "";
                txtTichLuyDen.Text = "";
                txtTenThe.Text = "";
                txtMaThe.Text = "";
                txtHieuLuc.Text = "";
                txtGiaTriMuaLanDau.Text = "";
                txtMaThe.Focus();
                btnXoa.Enabled = false;
            }
            else
            {
                dm = DmLoaitheKhachHangProvider.GetListDmLoaiTheInfoFromIdLoaiThe(frmThe.Oid);
                dmtheQL = DmLoaitheQuyenLoiProvider.GetListLoaiTheQuyenLoiInfoFromOid(frmThe.Oid);
                dmTheUD = DmLoaitheUuDaiProvider.GetListDmLoaiTheUuDaiInfoFromOid(frmThe.Oid);

                txtMaThe.Text = dm.MaThe;
                txtTenThe.Text = dm.TenThe;
                txtTinhNangKhac.Text = dm.GhiChu;
                txtTichLuyTu.Text = dm.DK_GT_TichLuy_Tu.ToString();
                txtTichLuyDen.Text = dm.DK_GT_TichLuy_Den.ToString();
                txtHieuLuc.Text = dm.ThoiGianHieuLuc.ToString();
                txtGiaTriMuaLanDau.Text = dm.DK_GT_LanDau.ToString();
                txtBaoLuuDiem.Text = dm.BaoLuuDiem.ToString();
                cboDoUuTien.SelectedItem = dm.DoUuTien;
                if (dm.DK_SP_KemTheo != null )
                {
                    string[] sp = dm.DK_SP_KemTheo.Split(',');
                    for (int i = 0; i < sp.Length; i++)
                    {
                        for (int j = 0; j < liSP.Count; j++)
                        {
                            if (sp[i].ToString().ToUpper() == liSP[j].TenSanPham.ToUpper())
                            {
                                chkLstSanPham.SetItemChecked(j, true);
                            }
                        }
                    }
                }
                chkBaoHanhVang.Checked = dm.IsBHVang == 1;
                chkThamGiaDaoTao.Checked = dm.IsJointCourse == 1;
                chkSuDung.Checked = dm.SuDung == 1;                
                chkDuocTuVanHoTro.Checked = dm.IsSupport == 1;
                chkTangQuaSinhNhat.Checked = dm.IsTangQuaSN == 1;
                chkThamGiaDaoTao.Checked = dm.IsJointCourse == 1;
                chkBaoHanhVang.Checked = dm.IsBHVang == 1;
                chkCapNhatThongTinSanPhamMoi.Checked = dm.IsUpdateSPNew == 1;
                dgvQuyenLoi.DataSource = new BindingList<DmLoaiTheQuyenLoiInfo>(dmtheQL) { AllowNew = true, AllowEdit = true, AllowRemove = true };
                dgvUuDai.DataSource = new BindingList<DmLoaiTheUuDaiInfo>(dmTheUD) { AllowNew = true, AllowEdit = true, AllowRemove = true };

            }
            if (frmThe.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMaThe.Enabled = false;
                txtTenThe.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        #endregion

        #region SaveQuyenLoi
        private void SaveQuyenLoi(int OidLoaiThe)
        {
            DmLoaiTheQuyenLoiInfo dm = new DmLoaiTheQuyenLoiInfo();
            dm.IdLoaiThe = OidLoaiThe;
            DmLoaitheQuyenLoiProvider.Delete(dm);
            for (int i = 0; i < dmtheQL.Count; i++)
            {
                dm.IdSanPham = dmtheQL[i].IdSanPham;
                dm.TyLeGiam = dmtheQL[i].TyLeGiam;
                dm.GhiChu = dmtheQL[i].GhiChu;
                DmLoaitheQuyenLoiProvider.Insert(dm);
            }
        }
        #endregion

        #region SaveUuDai
        private void SaveUuDai(int OidLoaiThe)
        {
            DmLoaiTheUuDaiInfo dm = new DmLoaiTheUuDaiInfo();
            dm.IdLoaiThe = OidLoaiThe;
            DmLoaitheUuDaiProvider.Delete(dm);
            for (int i = 0; i < dmTheUD.Count; i++)
            {
                dm.DichVu = dmTheUD[i].DichVu;
                dm.UuDai = dmTheUD[i].UuDai;
                DmLoaitheUuDaiProvider.Insert(dm);
            }
        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMaThe.Text))
            {
                txtMaThe.Focus();
                throw new InvalidOperationException("Mã thẻ không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTenThe.Text))
            {
                txtTenThe.Focus();
                throw new InvalidOperationException("Tên thẻ không được để trống !");                
            }
            if (String.IsNullOrEmpty(txtHieuLuc.Text))
            {
                txtHieuLuc.Focus();
                throw new InvalidOperationException("Hiệu lực không được để trống !");                
            }
            if (String.IsNullOrEmpty(txtGiaTriMuaLanDau.Text))
            {
                txtGiaTriMuaLanDau.Focus();
                throw new InvalidOperationException("Giá trị mua lần đầu không được để trống !");                
            }
            if (String.IsNullOrEmpty(txtTichLuyTu.Text))
            {
                txtTichLuyTu.Focus();
                throw new InvalidOperationException("Tích lũy tư không được để trống !");                
            }
            if (String.IsNullOrEmpty(txtTichLuyDen.Text))
            {
                txtTichLuyDen.Focus();
                throw new InvalidOperationException("Tích lũy điểm không được để trống !");                
            }
            if (String.IsNullOrEmpty(txtBaoLuuDiem.Text))
            {
                txtBaoLuuDiem.Focus();
                throw new InvalidOperationException("Bảo lưu điểm không được để trống !");
            }
            if (frmThe.IsSync)
            {
                if (txtTenThe.Text != dm.TenThe)
                {
                    throw new InvalidOperationException("Tên thẻ đã bị thay đổi !");
                }
                if (txtMaThe.Text != dm.MaThe)
                {
                    throw new InvalidOperationException("Mã thẻ đã bị thay đổi !");
                }
            }
            if (DmLoaitheKhachHangProvider.KiemTra(new DMLoaiTheKhachHangInfo { IdLoaiThe = frmThe.Oid,MaThe = txtMaThe.Text.Trim()}))
            {
                throw new InvalidOperationException("Mã thẻ đã tồn tại trong hệ thống !");
            }
            return true;
        }
        #endregion

        #region SaveLoaiThe
        private void SaveLoaiThe()
        {
            if (Check())
            {
                try
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    if (frmThe.isAdd)
                    {
                        int OidLoaiThe = DmLoaitheKhachHangProvider.Insert(SetLoaiThe());
                        SaveQuyenLoi(OidLoaiThe);
                        SaveUuDai(OidLoaiThe);
                        ConnectionUtil.Instance.CommitTransaction();
                    }
                    else
                    { 
                        //dm = new DMLoaiTheKhachHangInfo();
                        //dm = SetLoaiThe();
                        //dm.IdLoaiThe = frmThe.Oid;
                        DmLoaitheKhachHangProvider.Update(SetLoaiThe());
                        SaveQuyenLoi(frmThe.Oid);
                        SaveUuDai(frmThe.Oid);
                        ConnectionUtil.Instance.CommitTransaction();
                    }
                }
                catch (Exception)
                {
                  ConnectionUtil.Instance.RollbackTransaction();
                  throw;
                }
               
                //this.Close();
                //frmThe.ReLoad(); 
                //frmThe.SetControl(false);
            }
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (frmThe.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            if (frmThe.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            DmLoaitheKhachHangProvider.Delete(new DMLoaiTheKhachHangInfo { IdLoaiThe = frmThe.Oid });
        }
        #endregion

        #region SetLoaiThe
        private DMLoaiTheKhachHangInfo SetLoaiThe()
        {
            DMLoaiTheKhachHangInfo dm = new DMLoaiTheKhachHangInfo();
            dm.GhiChu = txtTinhNangKhac.Text.Trim();
            dm.MaThe = txtMaThe.Text.Trim();
            dm.TenThe = txtTenThe.Text.Trim();
            dm.ThoiGianHieuLuc = Convert.ToInt32(txtHieuLuc.Text.Trim());
            dm.IsBHVang = Convert.ToInt32(chkBaoHanhVang.Checked);
            dm.IsJointCourse = Convert.ToInt32(chkThamGiaDaoTao.Checked);
            dm.IsSupport = Convert.ToInt32(chkDuocTuVanHoTro.Checked);
            dm.IsTangQuaSN = Convert.ToInt32(chkTangQuaSinhNhat.Checked);
            dm.IsUpdateSPNew = Convert.ToInt32(chkCapNhatThongTinSanPhamMoi.Checked);
            dm.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dm.DK_GT_LanDau = Convert.ToInt32(txtGiaTriMuaLanDau.Text.Trim());
            dm.DK_GT_TichLuy_Tu = Convert.ToInt32(txtTichLuyTu.Text.Trim());
            dm.DK_GT_TichLuy_Den = Convert.ToInt32(txtTichLuyDen.Text.Trim());
            string sp = "";
            for (int i = 0; i < chkLstSanPham.Items.Count; i++)
            {
                if(chkLstSanPham.GetItemChecked(i))
                {
                    if (sp == "" || i == chkLstSanPham.Items.Count)
                    {
                        sp += ((DMSanPhamInfo) chkLstSanPham.Items[i]).TenSanPham;
                    }
                    else
                    {
                        sp += ((DMSanPhamInfo)chkLstSanPham.Items[i]).TenSanPham + ",";
                    }
                }
            }
            dm.DK_SP_KemTheo = sp;
            dm.BaoLuuDiem = Convert.ToInt32(txtBaoLuuDiem.Text.Trim());
            dm.DoUuTien = Convert.ToInt32(cboDoUuTien.SelectedValue);
            dm.ThoiGianHieuLuc = Convert.ToInt32(txtHieuLuc.Text.Trim());
            return dm;
        }
        #endregion

        #endregion

        #region Event
        private void frmChiTiet_The_Load(object sender, EventArgs e)
        {
            LoadSanPhamAll();
            LoadDoUuTien();
            LoadData();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                SaveLoaiThe();
                if(frmThe.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                this.Close();
                frmThe.ReLoad();
                frmThe.SetControl(false);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
                MessageBox.Show("Xóa thành công bản ghi!");
                this.Close();
                frmThe.ReLoad();
                frmThe.SetControl(false);
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
        #endregion

        private void dgvQuyenLoi_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show(e.ToString());
        }

        
    }
}