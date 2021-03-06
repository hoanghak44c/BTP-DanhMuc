using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH.Common;
using System.Collections;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Data;

//Note:@CuongTT frmChiTiet_MatHang
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_MatHang : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        frmDM_HangHoa frmMH;
        public int IdLoaiSanPham;
        DMSanPhamInfo dm = new DMSanPhamInfo();
        DMLoaiSanPhamInfo md = new DMLoaiSanPhamInfo();
        #endregion

        #region frmChiTiet_MatHang
        public frmChiTiet_MatHang()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frmChiTiet_MatHang(frmDM_HangHoa frm)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.frmMH = frm;
        }
        #endregion

        #region Action

        #region LoadDonViTinh
        private void LoadDonViTinh()
        {
            cboDonViTinh.DataSource = DmDonViTinhProvider.Instance.GetCboDonViTinhInfo();
            cboDonViTinh.DisplayMember = "TenDonViTinh";
            cboDonViTinh.ValueMember = "IdDonViTinh";
        }
        #endregion

        #region LoadTyLeVAT
        private void LoadTyLeVAT()
        {
            cbTyLeVAT.DataSource = DMTaxCodeDataProvider.GetListTaxCodeInfor();
            cbTyLeVAT.DisplayMember = "Code";
            cbTyLeVAT.ValueMember = "IdTaxCode";
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            if (frmMH.isAdd)
            {
                txtMaSanPham.Enabled = true;
                txtMaSanPham.Focus();
                txtTenTat.Text = "";
                txtTenSanPham.Text = "";
                txtMoTa.Text = "";
                txtMaVach.Text = "";
                txtMaSanPham.Text = "";
                txtGiaNhap.Text = "0";
                txtBaoHanhHang.Text = "0";
                txtBaohanhKhach.Text = "0";
                txtMaSanPham.Focus();
                btnXoa.Enabled = false;
            }
            else
            {
                txtMaSanPham.Enabled = false;
                dm = DmSanPhamProvider.GetSanPhamById(frmMH.Oid);

                txtTenTat.Text = dm.TenVietTat;
                txtTenSanPham.Text = dm.TenSanPham;
                txtMoTa.Text = dm.MoTa;
                txtMaVach.Text = dm.MaVach;
                txtMaSanPham.Text = dm.MaSanPham;
                txtGiaNhap.Text = Convert.ToString(dm.GiaNhap);
                txtBaoHanhHang.Text = Convert.ToString(dm.BaoHanhHang);
                txtBaohanhKhach.Text = Convert.ToString(dm.BaoHanhKhach);
                cboDonViTinh.SelectedValue = dm.IdDonViTinh;
                cbTyLeVAT.SelectedValue = dm.TyLeVAT;
                bteLoaiSanPham.Tag = DMLoaiSanPhamDataProvider.Instance.GetFullInfoByKey(dm.IdCha);
                if (bteLoaiSanPham.Tag != null)
                    bteLoaiSanPham.Text = ((DMLoaiSanPhamInfo)bteLoaiSanPham.Tag).TenLoaiSP;
                chkSuDung.Checked = dm.SuDung ==1 ;
                chkTrungMaVach.Checked = dm.TrungMaVach == 1;
                chkChietKhau.Checked = dm.ChietKhau == 1;
            }
            if (frmMH.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMaSanPham.Enabled = false;
                txtMaVach.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        private bool Exist(DMSanPhamInfo dmOrderTypeInfor)
        {
            return dmOrderTypeInfor.IdSanPham == frmMH.Oid;
        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMaSanPham.Text))
            {
                txtMaSanPham.Focus();
                throw new InvalidOperationException("Mã sản phẩm không được để trống !");
            }
            //if (String.IsNullOrEmpty(txtTenTat.Text))
            //{
            //    txtTenTat.Focus();
            //    throw new InvalidOperationException("Tên viết tắt không được để trống !");
            //}
            //if (String.IsNullOrEmpty(txtTenSanPham.Text))
            //{
            //    txtTenSanPham.Focus();
            //    throw new InvalidOperationException("Tên sản phẩm không được để trống !");
            //}
            //if (String.IsNullOrEmpty(txtGiaNhap.Text))
            //{
            //    txtGiaNhap.Focus();
            //    throw new InvalidOperationException("Giá nhập không được để trống !");
            //}
            if (frmMH.IsSync)
            {
                //if (txtMaVach.Text != dm.MaVach)
                //{
                //    throw new InvalidOperationException("Mã vạch đã bị thay đổi !");
                //}
                //if (txtMaSanPham.Text != dm.MaSanPham)
                //{
                //    throw new InvalidOperationException("Mã sản phẩm đã bị thay đổi !");
                //}
            }

            if (DmSanPhamProvider.KiemTra(new DMSanPhamInfo { IdSanPham = frmMH.Oid,MaSanPham = txtMaSanPham.Text.Trim()}))
            {
                throw new InvalidOperationException("Mã sản phẩm đã tồn tại trong hệ thống !");
            }
            return true;
        }
        #endregion

        #region SetMatHang
        private DMSanPhamInfo SetMatHang()
        {
            DMSanPhamInfo dm = new DMSanPhamInfo();
            dm.TenSanPham = txtTenSanPham.Text.Trim();
            dm.TenVietTat = txtTenTat.Text.Trim();
            dm.MaSanPham = txtMaSanPham.Text.Trim();
            dm.MaVach = txtMaVach.Text.Trim();
            dm.MoTa = txtMoTa.Text.Trim();
            dm.GiaNhap = Convert.ToInt32(txtGiaNhap.Text.Trim());
            dm.BaoHanhHang = Convert.ToInt32(txtBaoHanhHang.Text.Trim());
            dm.BaoHanhKhach = Convert.ToInt32(txtBaohanhKhach.Text.Trim());
            dm.IdDonViTinh = Convert.ToInt32(cboDonViTinh.SelectedValue);
            dm.TyLeVAT = Convert.ToInt32(cbTyLeVAT.SelectedValue);
            dm.IdCha = ((DMLoaiSanPhamInfo)bteLoaiSanPham.Tag).IdLoaiSP;
            dm.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dm.ChietKhau = Convert.ToInt32(chkChietKhau.Checked);
            dm.TrungMaVach = Convert.ToInt32(chkTrungMaVach.Checked);
            dm.IdSanPham = frmMH.Oid;
            return dm;
        }
        #endregion

        #region SaveMatHang
        private void SaveMatHang()
        {
            if (Check())
            {
                try
                {
                    ConnectionUtil.Instance.BeginTransaction();
                    if (frmMH.isAdd)
                    {
                        DmSanPhamProvider.Insert(SetMatHang());
                        ConnectionUtil.Instance.CommitTransaction();
                    }
                    else
                    {
                        dm.IdSanPham = frmMH.Oid;
                        DmSanPhamProvider.Update(SetMatHang());
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

        #region LoadLoaiHang
        //private void LoadLoaiHang()
        //{
            //todo: @HanhBD (DONE) su dung loai san pham
            //cboLoaiMatHang.DataSource = DMLoaiSanPhamDataProvider.GetLoaiSPPairInfor();
            //cboLoaiMatHang.DisplayMember = "TenLoaiSP";
            //cboLoaiMatHang.ValueMember = "IdLoaiSP";
        //}
        #endregion

        #region Delete
        private void Delete()
        {
            if (frmMH.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới !");
            }
            if (frmMH.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            DmSanPhamProvider.Delete(new DMSanPhamInfo { IdSanPham = frmMH.Oid });
        }
        #endregion

        #endregion

        #region Event
        private void frmChiTiet_MatHang_Load(object sender, EventArgs e)
        {
            LoadDonViTinh();
            LoadTyLeVAT();
            LoadData();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                SaveMatHang();
                if(frmMH.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                this.Close();
                frmMH.ReLoad();
                frmMH.SetControl(false);
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
                this.Close();
                frmMH.ReLoad();
                frmMH.SetControl(false);
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

        private void bteLoaiSanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_LoaiSanPham frm = new frmLookUp_LoaiSanPham(false, "%" + bteLoaiSanPham.Text.Trim() + "%");
            frm.ShowDialog();
            if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                bteLoaiSanPham.Text = frm.SelectedItem.TenLoaiSP;
                bteLoaiSanPham.Tag = frm.SelectedItem;
            }
        }

        private void bteLoaiSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_LoaiSanPham frm = new frmLookUp_LoaiSanPham(false, "%" + bteLoaiSanPham.Text.Trim() + "%");
                frm.ShowDialog();
                if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    bteLoaiSanPham.Text = frm.SelectedItem.TenLoaiSP;
                    bteLoaiSanPham.Tag = frm.SelectedItem;
                }
            }
        }

        private void bteLoaiSanPham_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteLoaiSanPham.Text)) bteLoaiSanPham.Tag = null;
        }
    }
}