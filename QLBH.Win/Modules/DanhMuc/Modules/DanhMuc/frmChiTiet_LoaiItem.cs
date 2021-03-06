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
    public partial class frmChiTiet_LoaiItem : DevExpress.XtraEditors.XtraForm
    {
        frmDM_LoaiItem frm;
        DMLoaiItemInfor dm;
        public frmChiTiet_LoaiItem(frmDM_LoaiItem frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        #region TestUnit Function

        public void SetInput(string sTen, string sMa, string sMota, int iSudung)
        {
#if DEBUG
            txtTenLoaiItem.Text = sTen;
            txtMaLoaiItem.Text = sMa;
            txtGhiChu.Text = sMota;
            chkSuDung.Checked = iSudung == 1;
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
        #region Action

        #region Reset
        private void Reset()
        {
            txtTenLoaiItem.Text = "";
            txtMaLoaiItem.Text = "";
            txtGhiChu.Text = "";
            chkSuDung.Checked = false;
            txtMaLoaiItem.Focus();
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            if (frm.isAdd)
            {
                Reset();
                btnXoa.Enabled = false;
            }
            else
            {
                txtMaLoaiItem.Enabled = false;
                dm = DMLoaiItemDataProvider.GetLoaiItemByIdInfo(frm.Oid);
                txtTenLoaiItem.Text = dm.TenLoaiItem;
                txtMaLoaiItem.Text = dm.MaLoaiItem;
                txtGhiChu.Text = dm.GhiChu;
                chkSuDung.Checked = dm.SuDung == 1;
                txtTenLoaiItem.Focus();
            }
            if (frm.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMaLoaiItem.Enabled = false;
                txtTenLoaiItem.Enabled = false;
                btnXoa.Enabled = false;
            }

        }
        #endregion

        #region SetLoaiItemInfo
        private DMLoaiItemInfor SetLoaiItemInfo()
        {
            return new DMLoaiItemInfor
               {
                   MaLoaiItem = txtMaLoaiItem.Text.Trim(),
                   TenLoaiItem = txtTenLoaiItem.Text.Trim(),
                   GhiChu = txtGhiChu.Text.Trim(),
                   SuDung = Convert.ToInt32(chkSuDung.Checked),
                   IdLoaiItem = frm.Oid
               };
        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMaLoaiItem.Text))
            {
                txtMaLoaiItem.Focus();
                throw new InvalidOperationException("Mã loại Item không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTenLoaiItem.Text))
            {
                txtTenLoaiItem.Focus();
                throw new InvalidOperationException("Tên loại Item không được để trống !");
            }
            if (frm.IsSync)
            {
                if (txtMaLoaiItem.Text != dm.MaLoaiItem)
                {
                    throw new InvalidOperationException("Mã Loại Item đã bị thay đổi !");
                }
                if (txtTenLoaiItem.Text != dm.TenLoaiItem)
                {
                    throw new InvalidOperationException("Tên loại Item chi đã bị thay đổi !");
                }
            }
            if (DMLoaiItemDataProvider.Kiemtra(new DMLoaiItemInfor {IdLoaiItem = frm.Oid, MaLoaiItem = txtMaLoaiItem.Text.Trim() }))
            {
                throw new InvalidOperationException("Mã loại Item đã có trong hệ thống !");
            }
            return true;
        }

        #endregion
        
        protected virtual void CheckOnSave(){}

        protected virtual void SaveInstance(){}
        #region Save
        private void Save()
        {
            if(Check())
            {
                if (frm.isAdd)
                {
                    DMLoaiItemDataProvider.Insert(SetLoaiItemInfo());
                }
                else
                {
                    DMLoaiItemDataProvider.Update(SetLoaiItemInfo());
                }
            }
            CheckOnSave();

            SaveInstance();
        }
        #endregion
        protected virtual void CheckOnDelete() { }

        protected virtual void DeleteInstance(){}
        #region Delete
        private void Delete()
        {
            CheckOnDelete();
            if (frm.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới !");
            }
            if (frm.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            DMLoaiItemDataProvider.Delete(new DMLoaiItemInfor { IdLoaiItem = frm.Oid });
            DeleteInstance();            
        }
        #endregion

        #endregion

        private void frmChiTiet_LoaiItem_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                if(frm.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
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
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
                MessageBox.Show("Xóa bản ghi thành công!");
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
    }
}