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

//Note:@CuongTT frmChiTiet_KhachHang
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_KhachHang : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        frmDM_KhachHang frmKH;
        List<DmLoaiDoiTuongInfor> liKhachHang = new List<DmLoaiDoiTuongInfor>();
        List<DMOrderTypePairInfor> litype = new List<DMOrderTypePairInfor>();
        List<MaVungInfo> liMaVung = new List<MaVungInfo>();
        DMDoiTuongInfo dm = new DMDoiTuongInfo();
        DmLoaiDoiTuongInfor ob = new DmLoaiDoiTuongInfor();
        List<DoiTuong_DiaChiInfo> liDoiTuong = new List<DoiTuong_DiaChiInfo>();
        #endregion

        #region frmChiTiet_KhachHang
        public frmChiTiet_KhachHang()
        {
            InitializeComponent();
        }
        public frmChiTiet_KhachHang(frmDM_KhachHang frm)
        {
            InitializeComponent();
            this.frmKH = frm;
        }
        //public frmChiTiet_KhachHang(frmDM_KhachHangLe frm)
        //{
        //    InitializeComponent();
        //    this.frmKHL = frm;
        //}
        #endregion

        #region Action

        #region LoadLoaiDoiTuong
        private void LoadLoaiDoiTuong()
        {
            liKhachHang = DmLoaiDoiTuongDataProvider.GetListLoaiDoiTuongInfor();
            if (liKhachHang.Count > 0)
            {
                cboLoaiDoiTuong.DataSource = liKhachHang;
                cboLoaiDoiTuong.DisplayMember = "TenLoaiDT";
                cboLoaiDoiTuong.ValueMember = "IdLoaiDT";
            }
            else
            {
                cboLoaiDoiTuong.DataSource = null;
            }
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

        //#region Test
        //public void Test(bool var)
        //{
        //    txtMaRieng.Enabled = var;
        //    txtSoCMND.Enabled = var;
        //}
        //#endregion

        #region LoadData
        private void LoadData()
        {
            if (frmKH.isAdd)
            {
                txtTen.Text = String.Empty;
                txtOrderType.Text = String.Empty;
                txtNguoiLienLac.Text = String.Empty;
                txtMaSoThue.Text = String.Empty;
                txtMa.Text = String.Empty;
                txtGhiChu.Text = String.Empty;
                txtFax.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtDienThoai.Text = String.Empty;
                dgvDiaChi.DataSource = new BindingList<DoiTuong_DiaChiInfo>(liDoiTuong) { AllowNew = true, AllowEdit = true, AllowRemove = true };
                btnXoa.Enabled = false;
            }
            else
            {
                txtMa.Enabled = false;
                dm = DmDoiTuongProvider.GetDmDoiTuongInfoFromOid(frmKH.Oid);
                liDoiTuong = DoiTuong_DiaChiDataProvider.GetListDoiTuongDiaChiInfoFromIdDoiTuong(frmKH.Oid);
                btnXoa.Enabled = false;
                txtTen.Text = dm.TenDoiTuong;
                txtNguoiLienLac.Text = dm.NguoiLienLac;
                txtMaSoThue.Text = dm.MaSoThue;
                txtMa.Text = dm.MaDoiTuong;
                txtGhiChu.Text = dm.DiaChi;
                txtFax.Text = dm.Fax;
                txtEmail.Text = dm.Email;
                txtDienThoai.Text = dm.DienThoai;
                txtNgaySinh.Text = Convert.ToString(dm.NgaySinh);
                chkSuDung.Checked = dm.SuDung == 1;
                cboGioiTinh.SelectedIndex = dm.GioiTinh;
                cboType.SelectedIndex = dm.Type;
                cboLoaiDoiTuong.SelectedValue = ob.IdLoaiDT;
                cboOrderType.SelectedValue = dm.IdOrderType;
                dgvDiaChi.DataSource = new BindingList<DoiTuong_DiaChiInfo>(liDoiTuong) { AllowNew = true, AllowEdit = true, AllowRemove = true };
            }
            if (frmKH.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMa.Enabled = false;
                txtMaSoThue.Enabled = false;
                btnXoa.Enabled = false;
            }

        }

        private bool Exist(DMDoiTuongInfo dmOrderTypeInfor)
        {
            return dmOrderTypeInfor.IdDoiTuong == frmKH.Oid;
        }

        private bool DoiTuongDiaChi(DoiTuong_DiaChiInfo dmOrderTypeInfor)
        {
            return dmOrderTypeInfor.IdDoiTuong == frmKH.Oid;
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
                    dt.SiteNumber =liDoiTuong[i].SiteNumber;
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
                throw new InvalidOperationException("Giới tính không được để trống !");
            }
            if (Equals(cboType.SelectedItem , String.Empty))
            {
                cboType.Focus();
                throw new InvalidOperationException("Chưa chọn kiểu !");
            }
            if (Equals(cboOrderType.SelectedItem , String.Empty))
            {
                cboOrderType.Focus();
                throw new InvalidOperationException("Chưa chọn OrderType !");
            }
            if (Equals(cboLoaiDoiTuong.SelectedItem , String.Empty))
            {
                cboLoaiDoiTuong.Focus();
                throw new InvalidOperationException("Chưa chọn Loại đối tượng !");
            }
            if (frmKH.IsSync)
            {
                if (txtMa.Text != dm.MaDoiTuong)
                {
                    throw new InvalidOperationException("Mã khách hàng đã bị thay đổi !");
                }
                if (txtMaSoThue.Text != dm.MaSoThue)
                {
                    throw new InvalidOperationException("Mã số thuế  đã bị thay đổi !");
                }
            }

            if (DmDoiTuongProvider.KiemTra(new DMDoiTuongInfo { IdDoiTuong = frmKH.Oid, MaDoiTuong = txtMa.Text.Trim()}))
            {
                throw new InvalidOperationException("Mã khách hàng đã tồn tại trong hệ thống !");
            }
            return true;
        }
        #endregion

        #region SetKhachHang
        private DMDoiTuongInfo SetKhachHangInfo()
        {
            DMDoiTuongInfo dm = new DMDoiTuongInfo();
            ob.IdLoaiDT = Convert.ToInt32(cboLoaiDoiTuong.SelectedValue);
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
            dm.GioiTinh = (cboGioiTinh.SelectedIndex + 1) % 3 - 1;
            dm.Type = cboType.SelectedIndex;
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
                    if (frmKH.isAdd)
                    {
                        int oid = DmDoiTuongProvider.Insert(SetKhachHangInfo());
                        SaveDiaChi(oid);
                        ConnectionUtil.Instance.CommitTransaction();
                    }
                    else
                    {
                        DMDoiTuongInfo info = SetKhachHangInfo();
                        info.IdDoiTuong = frmKH.Oid;
                        DmDoiTuongProvider.Update(info);
                        SaveDiaChi(info.IdDoiTuong);
                        ConnectionUtil.Instance.CommitTransaction();
                    }
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
            if (frmKH.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            if (frmKH.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            DmDoiTuongProvider.Delete(new DMDoiTuongInfo { IdDoiTuong = frmKH.Oid });
        }
        #endregion

        #endregion

        #region Event
        private void frmChiTiet_KhachHang_Load(object sender, EventArgs e)
        {
            LoadLoaiDoiTuong();
            LoadMaVung();
            LoadOderType();
            LoadData();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cboOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (litype.Count > 0)
            {
                txtOrderType.Text = ((DMOrderTypePairInfor)cboOrderType.SelectedItem).OrderType;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDoiTuong();
                if(frmKH.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công !");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                frmKH.ReLoad();
                frmKH.SetControl(false);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
                MessageBox.Show("Xóa thành công bản ghi !");
                frmKH.ReLoad();
                frmKH.SetControl(false);
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

        private void dgvDiaChi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ////if (((DoiTuong_DiaChiInfo)liDoiTuong[e.RowIndex]).SiteNumber != String.Empty)
            ////{
            //    dgvDiaChi.AutoGenerateColumns = false;
            //    liDoiTuong.Add(new DoiTuong_DiaChiInfo());
            ////}
            //dgvDiaChi.DataSource = null;
            //dgvDiaChi.DataSource = liDoiTuong;
        }

        private void dgvDiaChi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //dgvDiaChi.AutoGenerateColumns = false;
            //liDoiTuong.Add(new DoiTuong_DiaChiInfo());
            //dgvDiaChi.DataSource = null;
            //dgvDiaChi.DataSource = liDoiTuong;
        }
    }
}