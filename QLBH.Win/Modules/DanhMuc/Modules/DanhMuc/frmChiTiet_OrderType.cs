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

// <Remarks>
// form frmChiTiet_OrderType
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 16/04/2012
// Ngày sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_OrderType : DevExpress.XtraEditors.XtraForm
    {

        #region Declare
        frmDM_OrderType frmDMOrderType;
        DMOrderTypeInfor dm;
        #endregion

        #region TestUnit Function

        public void SetInput(string sTen, string sMa, string sMota, int iSudung,string sLine)
        {
#if DEBUG
            txtTen.Text = sTen;
            txtMa.Text = sMa;
            txtMoTa.Text = sMota;
            chkSuDung.Checked = iSudung == 1;
            txtLine.Text = sLine;
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

        #region frmChiTiet_OrderType
        public frmChiTiet_OrderType()
        {
            InitializeComponent();
        }
        public frmChiTiet_OrderType(frmDM_OrderType frm)
        {
            InitializeComponent();
            this.frmDMOrderType = frm;
        }
        #endregion

        #region LoadNganh
        private void LoadNganh()
        {
            cbNganhHang.DataSource = DmNganhDataProvider.Instance.GetListSegmentChildInfor();
            cbNganhHang.DisplayMember = "Ten";
            cbNganhHang.ValueMember = "Ma";
        }
        #endregion

        #region Action
        #region Reset
        private void Reset()
        {
            txtTen.Text = "";
            txtMa.Text = "";
            txtMoTa.Text = "";
            txtLine.Text = "";
            chkSuDung.Checked = true;
            txtMa.Focus();
        }
        #endregion
        #region LoadData
        private void Loaddata()
        {
            if (frmDMOrderType.isAdd)
            {
                Reset();
                btnDelete.Enabled = false;
            }
            else
            {
                txtMa.Enabled = false;
                dm = DMOrderTypeProvider.GetListDmOrderTypeInfoFromOid(frmDMOrderType.Oid);
                txtMa.Text = dm.OrderType;
                txtTen.Text = dm.Name;
                txtMoTa.Text = dm.GhiChu;
                txtLine.Text = dm.LineType;
                txtLineKm.Text = dm.LineKm;
                txtLineCk.Text = dm.LineCk;
                cbNganhHang.SelectedValue = dm.NganhHang;
                chkSuDung.Checked = dm.SuDung == 1;
                txtMa.Focus();

            }
            if (frmDMOrderType.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMa.Enabled = false;
                txtTen.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMa.Text))
            {
                txtMa.Focus();
                throw new InvalidOperationException("Mã OrderType không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTen.Text))
            {
                txtTen.Focus();
                throw new InvalidOperationException("Tên OrderType không được để trống !");
            }
            if (frmDMOrderType.IsSync)
            {
                if (txtTen.Text != dm.Name)
                {
                    throw new InvalidOperationException("Tên OrderType đã bị thay đổi !");
                }
                if (txtMa.Text != dm.OrderType)
                {
                    throw new InvalidOperationException("Mã OrderType đã bị thay đổi !");
                }
            }
            if (frmDMOrderType.isAdd && DMOrderTypeProvider.KiemTra(new DMOrderTypeInfor {IdOrderType = frmDMOrderType.Oid,OrderType = txtMa.Text.Trim() }))
            {
                throw new InvalidOperationException("Mã OrderType đã tồn tại trong hệ thống!");
            }
            return true;
        }
        #endregion
        #region Delete
        private void Delete()
        {
            if (frmDMOrderType.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            if (frmDMOrderType.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }

            DMOrderTypeProvider.Delete(new DMOrderTypeInfor { IdOrderType = frmDMOrderType.Oid });
        }
        #endregion
        #region SaveDoiTuong
        private void SaveDoiTuong()
        {
            if(Check())
            {
                if (frmDMOrderType.isAdd)
                {
                    DMOrderTypeProvider.Insert(SetDanhMuc());
                }
                else
                {
                    DMOrderTypeProvider.Update(SetDanhMuc());
                }
            }
        }
        #endregion

        #region SetDanhMuc
        private DMOrderTypeInfor SetDanhMuc()
        {
            DMOrderTypeInfor dm = new DMOrderTypeInfor();
            dm.Name = txtTen.Text.Trim();
            dm.OrderType = txtMa.Text.Trim();
            dm.GhiChu = txtMoTa.Text.Trim();
            dm.LineType = txtLine.Text.Trim();
            dm.LineKm = txtLineKm.Text.Trim();
            dm.LineCk = txtLineCk.Text.Trim();
            dm.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dm.IdOrderType = Convert.ToInt32(frmDMOrderType.Oid);
            dm.NganhHang = Convert.ToString(cbNganhHang.SelectedValue);
            return dm;
        }
        #endregion
        #endregion
        #region Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDoiTuong();
                if(frmDMOrderType.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công !");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                this.Close();
                frmDMOrderType.ReLoad();
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
                MessageBox.Show("Xóa thành công bản ghi!");
                this.Close();
                frmDMOrderType.ReLoad();
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

        private void frmChiTiet_OrderType_Load(object sender, EventArgs e)
        {
            LoadNganh();
            Loaddata();
        }
        #endregion

        private void txtLine_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtLine.Text != "")
            //        Convert.ToInt32(txtLine.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Bạn chỉ có thể nhập số !");
            //    txtLine.Text = "";
            //}
        }
    }
}