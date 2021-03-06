using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong;
using QLBanHang.Modules.HeThong.Infors;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common.Providers;
using QLBH.Core.Data;
using QLBH.Core.Providers;


//Note:@CuongTT frmChiTiet_NhanVien
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        private frmDM_NhanVien frmNV ;
        private objGridMarkSelection selector = new objGridMarkSelection();
        private DMNhanVienInfo dm = null;
        #endregion

        #region frmChiTiet_NhanVien
        public frmChiTiet_NhanVien()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmChiTiet_NhanVien(frmDM_NhanVien frm)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.frmNV = frm;
        }
        #endregion

        #region Action

        #region LoadPhongBan
        private void LoadPhongBan()
        {
            cboPhongBan.DataSource = DMPhongBanDataProvider.Instance.GetListPhongBanPairInfo();
            cboPhongBan.DisplayMember = "TenPhongBan";
            cboPhongBan.ValueMember = "IdPhongBan";
        }
        #endregion
        
        #region LoadChucVu
        private  void LoadChucVu()
        {
            cboChucVu.DataSource = DMChucVuDataProvider.GetListChucVuPairInfo();
            cboChucVu.DisplayMember = "TenChucVu";
            cboChucVu.ValueMember = "IdChucVu";
        }
        #endregion

        private void LoadTrungTam(int idTrungTam)
        {
            DMTrungTamInfor tt = DMTrungTamDataProvider.GetTrungTamByIdInfo(idTrungTam);
            if (tt != null)
            {
                bteTrungTam.Tag = tt;
                bteTrungTam.Text = tt.TenTrungTam;
            }
        }

        private void LoadQLTrucTiep(int idQLTrucTiep)
        {
            DMNhanVienInfo nv = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(idQLTrucTiep);
            if (nv != null)
            {
                bteQLTrucTiep.Text = nv.HoTen;
                bteQLTrucTiep.Tag = nv;
            }
        }

        #region LoadKho
        private void LoadAllKho()
        {
            List<DMKhoCBOLoadInfo> liKho = DMKhoDataProvider.GetCboDMKhoInfo();
            gKhoXuat.DataSource = new BindingList<DMKhoCBOLoadInfo>(liKho);
            gvKhoXuat.ExpandAllGroups();
            selector.View = gvKhoXuat;
        }
        private void LoadKhoXuat(int idNhanVien)
        {
            List<DMKhoCBOLoadInfo> ar = DmNhanVienDataProvider.Instance.GetListKhoCBOLoadInfor(idNhanVien);

            selector.ClearSelection();
            foreach (DMKhoCBOLoadInfo pt in ar)
            {
                for (int i = 0; i < gvKhoXuat.RowCount; i++)
                {
                    DMKhoCBOLoadInfo kho = (DMKhoCBOLoadInfo)gvKhoXuat.GetRow(i);
                    if (kho != null && kho.IdKho == pt.IdKho)
                    {
                        selector.SelectRow(i, true); // dánh dấu trạng thái
                        break;
                    }
                }
            }
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            if (frmNV.isAdd)
            {
                btnXoa.Enabled = false;
                txtMaNhanVien.Text = "";
                txtHoTen.Text = "";
                //txtNgaySinh.Text = "";
                txtDiaChi.Text = "";
                txtDienThoai.Text = "";
                txtEmail.Text = "";
                txtGhiChu.Text = "";
                chkSuDung.Checked = false;
                chkPhuTrach.Checked = false;
                optNam.Checked = true;
                btnXoa.Enabled = false;
                gKhoXuat.DataSource = new BindingList<DMKhoCBOLoadInfo>();                
            }
            else
            {
                btnXoa.Enabled = false;
                txtMaNhanVien.Enabled = false;
                dm = DmNhanVienDataProvider.GetListDmNhanVienInfoFromOid(frmNV.Oid);
                txtMaNhanVien.Text = dm.MaNhanVien;
                txtHoTen.Text = dm.HoTen;
                //tao ma vach tu ma nhan vien
                txtMaVach.Text = String.IsNullOrEmpty(dm.MaVach)
                                     ? GtidCryptionEx.EncryptEx(txtMaNhanVien.Text.Trim(), true)
                                     : dm.MaVach;
                try
                {
                    mstNgaySinh.Value = dm.NgaySinh;
                }
                catch
                {
                    mstNgaySinh.Value = CommonProvider.Instance.GetSysDate();
                }
                
                txtDiaChi.Text = dm.DiaChi;
                txtDienThoai.Text = dm.DienThoai;
                txtEmail.Text = dm.Email;
                txtGhiChu.Text = dm.GhiChu;

                chkSuDung.Checked = dm.SuDung == 1;
                chkPhuTrach.Checked = dm.PhuTrachCSKH == 1;
                optNam.Checked = dm.GioiTinh == 1;
                optNu.Checked = dm.GioiTinh == 0;
                cboPhongBan.SelectedValue = Convert.ToInt32(dm.IdPhongBan);
                cboChucVu.SelectedValue = Convert.ToInt32(dm.IdChucVu);

                LoadQLTrucTiep(dm.IdQuanLyTrucTiep);
                LoadTrungTam(dm.IdTrungTamHachToan);
                LoadKhoXuat(frmNV.Oid);                
            }
            if (frmNV.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMaNhanVien.Enabled = false;
                txtHoTen.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                txtMaNhanVien.Focus();
                throw new InvalidOperationException("Mã nhân viên không được để trống !");
            }
            if (String.IsNullOrEmpty(txtHoTen.Text))
            {
                txtHoTen.Focus();
                throw new InvalidOperationException("Tên nhân viên không được để trống !");
            }
            if (cboPhongBan.Text.Trim().Length == 0)
            {
                cboPhongBan.Focus();
                throw new InvalidOperationException("Phòng ban chưa được chọn!");
            }
            if (cboChucVu.Text.Trim().Length == 0)
            {
                cboChucVu.Focus();
                throw new InvalidOperationException("Chức vụ chưa được chọn!");
            }
            if (this.txtEmail.Text.Trim().Length > 0 && Common.ValidEmail(this.txtEmail.Text.Trim()) == false)
            {
                this.txtEmail.Focus();
                throw new InvalidOperationException("Email chưa đúng định dạng!");
            }
            if (bteTrungTam.Tag == null)
            {
                this.txtEmail.Focus();
                throw new InvalidOperationException("Chưa chọn trung tâm của nhân viên!");                
            }
            if (frmNV.IsSync)
            {
                if (txtHoTen.Text != dm.HoTen)
                {
                    throw new InvalidOperationException("Tên nhân viên đã bị thay đổi !");
                }
                if (txtMaNhanVien.Text != dm.MaNhanVien)
                {
                    throw new InvalidOperationException("Mã nhân viên đã bị thay đổi !");
                }
            }


            if (DmNhanVienDataProvider.KiemTra(new DMNhanVienInfo { IdNhanVien = frmNV.Oid, MaNhanVien = txtMaNhanVien.Text.Trim() }))
            {
                throw new InvalidOperationException("Mã nhân viên đã tồn tại trong hệ thống !"); 
            }
            return true;
        }
        #endregion

        #region SetNhanVien
        private DMNhanVienInfo SetNhanVien()
        {
            DMNhanVienInfo dm = new DMNhanVienInfo();
            dm.HoTen = txtHoTen.Text.Trim();
            dm.MaNhanVien = txtMaNhanVien.Text.Trim();
            dm.NgaySinh = mstNgaySinh.Value;
            dm.DiaChi = txtDiaChi.Text.Trim();
            dm.DienThoai = txtDienThoai.Text.Trim();
            dm.Email = txtEmail.Text.Trim();
            dm.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dm.GhiChu = txtGhiChu.Text.Trim();
            dm.GioiTinh= Convert.ToInt32(optNam.Checked);
            dm.IdChucVu = Convert.ToInt32(cboChucVu.SelectedValue);
            dm.IdPhongBan = Convert.ToInt32(cboPhongBan.SelectedValue);
            dm.IdNhanVien = Convert.ToInt32(frmNV.Oid);
            dm.IdTrungTamHachToan = ((DMTrungTamInfor) bteTrungTam.Tag).IdTrungTam;
            dm.IdQuanLyTrucTiep = bteQLTrucTiep.Tag != null ? ((DMNhanVienInfo) bteQLTrucTiep.Tag).IdNhanVien : 0;
            dm.PhuTrachCSKH = Common.Bool2Int(chkPhuTrach.Checked);
            dm.MaVach = txtMaVach.Text;
            return dm;
        }
        #endregion

        #region SaveNhanVien
        private void SaveNhanVien()
        {
            if (Check())
            {
                try
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    if (frmNV.isAdd)
                    {
                        //tao ma vach tu ma nhan vien
                        txtMaVach.Text = GtidCryptionEx.EncryptEx(txtMaNhanVien.Text.Trim(), true);

                        int Oid = DmNhanVienDataProvider.Insert(SetNhanVien());
                        SaveKhoNhanVien(Oid);
                        //note: @All các transaction đòi hỏi phải giải phóng nhanh nên commit hay rollback phải đặt trước các lệnh làm pendding nó
                        ConnectionUtil.Instance.CommitTransaction();
                    }
                    else
                    {
                        dm.IdNhanVien = frmNV.Oid;
                        DmNhanVienDataProvider.Update(SetNhanVien());
                        SaveKhoNhanVien(frmNV.Oid);
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

        #region SaveKhoNhanVien
        private void SaveKhoNhanVien(int oid)
        {
            Kho_NhanvienInfo dmkho = new Kho_NhanvienInfo();
            dmkho.IdNhanVien = oid;
            DmNhanVienDataProvider.Instance.RemoveKho(dmkho);
            foreach (DMKhoCBOLoadInfo kho in selector.selection)
            {
                Kho_NhanvienInfo knv = new Kho_NhanvienInfo();
                knv.IdKho = kho.IdKho;
                knv.IdNhanVien = oid;
                DmNhanVienDataProvider.Instance.AddKho(knv);
            }
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (frmNV.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới !");
            }
            if (frmNV.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            DmNhanVienDataProvider.Delete(new DMNhanVienInfo { IdNhanVien = frmNV.Oid });
        }
        #endregion

        #endregion

        #region Event
        private void frmChiTiet_NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                LoadChucVu();
                LoadPhongBan();
                LoadAllKho();
                LoadData();
            }
            catch (Exception ex)
            {
                EventLogProvider.Instance.WriteLog(ex.ToString(), "frmChiTiet_NhanVien_Load");
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                SaveNhanVien();
                if(frmNV.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công !");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                this.Close();
                frmNV.ReLoad();
                frmNV.SetControl(false);
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
                frmNV.ReLoad();
                frmNV.SetControl(false);
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

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDienThoai.Text != "")
                    Convert.ToInt32(txtDienThoai.Text);
            }
            catch
            {
                MessageBox.Show("Bạn chỉ có thể nhập số!");
                txtDienThoai.Text = "";
            }
        }

        private void chkChon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChon.Checked == true)
            {
                selector.SelectAll();
            }
            else
            {
                selector.ClearSelection();
            }
        }

        private void bteTrungTam_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteTrungTam_ButtonClick(sender, e, bteTrungTam, -1);
        }

        private void bteTrungTam_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteTrungTam_KeyDown(sender, e, bteTrungTam, 1);
        }

        private void bteTrungTam_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }

        private void bteQLTrucTiep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UtilFunctions.bteNhanVien_ButtonClick(sender, e, bteQLTrucTiep, -1);
        }

        private void bteQLTrucTiep_KeyDown(object sender, KeyEventArgs e)
        {
            UtilFunctions.bteNhanVien_KeyDown(sender, e, bteQLTrucTiep, -1);
        }

        private void bteQLTrucTiep_TextChanged(object sender, EventArgs e)
        {
            UtilFunctions.bteItem_TextChanged(sender, e, bteTrungTam);
        }
    }
}