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
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_MaLoi : DevExpress.XtraEditors.XtraForm
    {
        private frmDM_MaLoi frm;
        private DMMaLoiInfor dm;
        private int IdLoaiSanPham;

        #region TestUnit Function

        public void SetInput(string sTen, string sMa, string sMota, int iSudung)
        {
#if DEBUG
            txtTenLoi.Text = sTen;
            txtMaLoi.Text = sMa;
            txtGhiChu.Text = sMota;
            cbSuDung.Checked = iSudung == 1;
#endif
        }

        public void TestSave()
        {
#if DEBUG
            Save();
#endif
        }

        public void TestDelete()
        {
#if DEBUG
            Delete();
#endif
        }

        #endregion
        public frmChiTiet_MaLoi()
        {
            InitializeComponent();
        }
        public frmChiTiet_MaLoi(frmDM_MaLoi frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        #region Action

        #region Reset
        private void Reset()
        {
            txtTenLoi.Text = "";
            txtMaLoi.Text = "";
            txtGhiChu.Text = "";
            txtMaLoi.Focus();
            cbSuDung.Checked = false;
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            if (frm.isAdd)
            {
                Reset();
            }
            else
            {
                dm = DMMaLoiDataProvider.GetLoaiItemByIdInfo(frm.Oid);

                txtMaLoi.Text = dm.MaLoi;
                txtTenLoi.Text = dm.TenLoi;
                txtGhiChu.Text = dm.GhiChu;
                cbSuDung.Checked = dm.SuDung == 1;
                txtLoaiSanPham.Text = dm.TenLoaiSP;
            }
        }
        #endregion

        #region LoadLoaiItem
        private void LoadLoaiItem()
        {
            //cboLoaiItem.DataSource = DMLoaiItemDataProvider.GetListItemInfor();
            //cboLoaiItem.DisplayMember = "TenLoaiItem";
            //cboLoaiItem.ValueMember = "IdLoaiItem";
        }
        #endregion

        #region SetMaLoiInfo
        private DMMaLoiInfor SetMaLoiInfo()
        {
            DMMaLoiInfor dm = new DMMaLoiInfor();
            dm.MaLoi = txtMaLoi.Text.Trim();
            dm.TenLoi = txtTenLoi.Text.Trim();
            dm.GhiChu = txtGhiChu.Text.Trim();
            dm.SuDung = Convert.ToInt32(cbSuDung.Checked);
            dm.IdLoaiItem = IdLoaiSanPham;
            dm.IdMaLoi = frm.Oid;
            return dm;
        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMaLoi.Text))
            {
                txtMaLoi.Focus();
                throw new InvalidOperationException("Mã Lỗi không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTenLoi.Text))
            {
                txtTenLoi.Focus();
                throw new InvalidOperationException("Tên Lỗi không được để trống !");
            }
            if (DMMaLoiDataProvider.Kiemtra(new DMMaLoiInfor {IdMaLoi = frm.Oid,MaLoi = txtMaLoi.Text.Trim() }))
            {
                throw new InvalidOperationException("Mã Lỗi đã tồn tại trong hệ thống!");
            }
            return true;
        }
        #endregion
        #region Save
        private void Save()
        {
            if(Check())
            {
                if (frm.isAdd)
                {
                    DMMaLoiDataProvider.Insert(SetMaLoiInfo());
                }
                else
                {
                    DMMaLoiDataProvider.Update(SetMaLoiInfo());
                }
            }
        }
        #endregion

        #region Delete
        private void  Delete()
        {
            if (frm.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            DMMaLoiDataProvider.Delete(new DMMaLoiInfor { IdMaLoi = frm.Oid });
        }
        #endregion

        #endregion

        private void frmChiTiet_MaLoi_Load(object sender, EventArgs e)
        {
            LoadLoaiItem();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                if(frm.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công !");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                this.Close();
                frm.ReLoad();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
                MessageBox.Show("Xóa bản ghi thành công !");
                this.Close();
                frm.ReLoad();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLoaiSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                frmLookUp_LoaiSanPham frm = new frmLookUp_LoaiSanPham(false, "%" + txtLoaiSanPham.Text.Trim() + "%");
                frm.ShowDialog();
                if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    txtLoaiSanPham.Text = frm.SelectedItem.TenLoaiSP;
                    IdLoaiSanPham = frm.SelectedItem.IdLoaiSP;
                }
            }
        }
    }
}