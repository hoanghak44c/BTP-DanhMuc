using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Data;

// <Remarks>
// form frmChiTiet_ListDM
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 13/04/2012
// Ngày sửa cuối:
// </remarks>
//Note:@HanhBD frmChiTiet_ListDM
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_ListDM : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        frmDM_ListDM frmDMList;
        DMListInfor dm;
        #endregion

        #region TestUnit Function

        public void SetInput(string sTen, string sTenTB, int iOnlyPOS)
        {
#if DEBUG
            txtTenBang.Text = sTenTB;
            txtTenDanhMuc.Text = sTen;
            chkSuDung.Checked = iOnlyPOS == 1;
#endif
        }

        public void TestSave()
        {
#if DEBUG
            SaveDoiTuong();
#endif
        }

        public void TestDelete()
        {
#if DEBUG
            Delete();
#endif
        }

        #endregion

        #region frmChiTiet_ListDM
        public frmChiTiet_ListDM()
        {
            InitializeComponent();
        }
        public frmChiTiet_ListDM(frmDM_ListDM frm)
        {
            InitializeComponent();
            this.frmDMList = frm;
        }
        #endregion

        #region Action

        #region Reset
        private void Reset()
        {
            txtTenBang.Text = "";
            txtTenDanhMuc.Text = "";
            txtTenBang.Focus();
        }
        #endregion

        #region LoadData
        private void Loaddata()
        {
            if (frmDMList.isAdd)
            {
                Reset();
            }
            else
            {
                txtTenBang.Enabled = false;
                dm = KhaiBaoDMDataProvider.GetListDMInfoFromOid(frmDMList.TblName);
                txtTenBang.Text = dm.TblName;
                txtTenDanhMuc.Text = dm.Name;
                chkSuDung.Checked = dm.OnlyPOS == 1;
                txtTenBang.Focus();
            }
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (frmDMList.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới !");
            }
            KhaiBaoDMDataProvider.Delete(new DMListInfor { TblName = frmDMList.TblName });
        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtTenDanhMuc.Text))
            {
                txtTenDanhMuc.Focus();
                throw new InvalidOperationException("Tên danh mục không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTenBang.Text))
            {
                txtTenBang.Focus();
                throw new InvalidOperationException("Tên bảng không được để trống !");
            }
            if (frmDMList.isAdd && KhaiBaoDMDataProvider.Kiemtra(new DMListInfor { TblName = txtTenBang.Text }))
            {
                throw new InvalidOperationException("Tên bảng đã tồn tại trong hệ thống !");
            }
            if (!frmDMList.isAdd && txtTenBang.Text != frmDMList.TblName)
            {
                throw new InvalidOperationException("Tên bảng cần cập nhật đã bị thay đổi !");
            }
            return true;
        }
        #endregion

        #region SaveDoiTuong
        private void SaveDoiTuong()
        {
            if(Check())
            {
                if (frmDMList.isAdd)
                {
                    KhaiBaoDMDataProvider.Insert(SetDanhMuc());
                }
                else
                {
                    KhaiBaoDMDataProvider.Update(SetDanhMuc());
                }
            }
        }
        #endregion

        #region SetDanhMuc
        private DMListInfor SetDanhMuc()
        {
            return new DMListInfor()
               {
                   Name = txtTenDanhMuc.Text.Trim(),
                   TblName = txtTenBang.Text.Trim(),
                   OnlyPOS = Convert.ToInt32(chkSuDung.Checked)
               };
        }
        #endregion
        #endregion

        #region Event
        private void frmChiTiet_ListDM_Load(object sender, EventArgs e)
        {
            Loaddata();
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
                MessageBox.Show("Xóa thành công bản ghi !");
                this.Close();
                frmDMList.ReLoad();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDoiTuong();
                if(frmDMList.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                this.Close();
                frmDMList.ReLoad();
            }
            catch(Exception ex)
            {
                #if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        #endregion


    }
}