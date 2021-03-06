using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBH.Core;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Providers;

// <Remarks>
// Tạo DMLoaiItem
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 05/03/2012
// Người sửa cuối:
// </remarks>
//Note :@HanhBD frmDM_LoaiItem
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_LoaiItem_Old : DevExpress.XtraEditors.XtraForm
    {
        #region Valiables
            //private DataTable _listItem;
            //private Utils ut = new Utils();
            //private ItemBaoHanh _itemBaoHanh;
            //private string _btSelected;
        #endregion

        private int idloaiitem = 0;
        public frmDM_LoaiItem_Old()
        {
            InitializeComponent();
            ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmLoaiItem);
            //Common.LoadStyle(this);
        }

        private void frmDM_LoaiItem_Load(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = DMLoaiItemDataProvider.GetListItemInfor();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                this.Dispose();
            }
        }
        private DMLoaiItemInfor getinfor()
        {
            DMLoaiItemInfor dmLoaiItemInfor = new DMLoaiItemInfor();
            dmLoaiItemInfor.MaLoaiItem = txtMaLoaiItem.Text;
            dmLoaiItemInfor.TenLoaiItem = txtTenLoaiItem.Text;
            dmLoaiItemInfor.GhiChu = txtGhiChu.Text;
            dmLoaiItemInfor.SuDung = Convert.ToInt32(cbSuDung.Checked);
            dmLoaiItemInfor.IdLoaiItem = Convert.ToInt32(getValue("clIdLoaiItem"));
            return dmLoaiItemInfor;
        }

        private void ucActions1_OnAdd(object obj)
        {
            DMLoaiItemDataProvider.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
            dgvList.DataSource = DMLoaiItemDataProvider.GetListItemInfor();
        }

        private void ucActions1_OnClose()
        {
            this.Close();
        }

        private void ucActions1_OnDelete(object obj)
        {
            //DMLoaiItemInfor khaibao = new DMLoaiItemInfor();
            //khaibao.MaLoaiItem = Convert.ToString(getValue("clMaLoaiItem"));
            DMLoaiItemDataProvider.Delete(new DMLoaiItemInfor{IdLoaiItem = Convert.ToInt32(getValue("clIdLoaiItem"))});
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvList.DataSource = DMLoaiItemDataProvider.GetListItemInfor();
        }

        private object getValue(string colName)
        {
            if (dgvList.CurrentRow != null && !dgvList.CurrentRow.IsNewRow)
                return dgvList.CurrentRow.Cells[colName].Value;
            return null;
        }

        private void ucActions1_OnDisableEditor()
        {
            txtMaLoaiItem.Enabled = false;
            txtTenLoaiItem.Enabled = false;
            txtGhiChu.Enabled = false;
            cbSuDung.Enabled = false;
        }

        private void ucActions1_OnEnableEditor()
        {
            txtMaLoaiItem.Enabled = true;
            txtTenLoaiItem.Enabled = true;
            txtGhiChu.Enabled = true;
            cbSuDung.Enabled = true;
        }

        private void ucActions1_OnLoadEditor(object obj)
        {
            if (obj != null)
            {
                txtMaLoaiItem.Text = Convert.ToString(getValue("clMaLoaiItem"));
                txtTenLoaiItem.Text = Convert.ToString(getValue("clTenLoaiItem"));
                txtGhiChu.Text = Convert.ToString(getValue("clGhiChu"));
                cbSuDung.Checked = Convert.ToInt32(getValue("clSuDung")) == 1;
                return;
            }
            txtMaLoaiItem.Text = String.Empty;
            txtTenLoaiItem.Text = String.Empty;
            txtGhiChu.Text = String.Empty;
            cbSuDung.Checked = false;
        }

        private void ucActions1_OnUpdate(object obj)
        {
            DMLoaiItemDataProvider.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
            dgvList.DataSource = DMLoaiItemDataProvider.GetListItemInfor();
        }

        private void ucActions1_OnValidate(object obj, QLBH.Core.ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    idloaiitem = getEditId(obj);
                    if (txtMaLoaiItem.Text == String.Empty)
                    {
                        throw new Exception("Mã Loại Item không Được Để Trống!");
                    }
                    if (DMLoaiItemDataProvider.Kiemtra(new DMLoaiItemInfor{IdLoaiItem = idloaiitem,TenLoaiItem = txtTenLoaiItem.Text}))
                    {
                        throw new Exception("Mã Loại Item Đã Tồn Tại!");
                    }
                    break;
            }
        }
        private int getEditId(object obj)
        {
            DataGridViewRow dr = obj as DataGridViewRow;
            if (dr == null) return 0;
            return Convert.ToInt32(dr.Cells["clIdLoaiItem"].Value);
        }
        private bool Exist(DMLoaiItemInfor dmLoaiItemInfor)
        {
            return dmLoaiItemInfor.MaLoaiItem.ToLower() == txtMaLoaiItem.Text.Trim().ToLower();
        }

        private bool Search(DMLoaiItemInfor dmLoaiItemInfor)
        {
            return ((txtTenLoiSearch.Text.Trim() == String.Empty || (txtTenLoiSearch.Text.Trim() != String.Empty &&
                    dmLoaiItemInfor.MaLoaiItem.ToLower().Contains(txtTenLoiSearch.Text.Trim().ToLower()))));
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            DMLoaiItemInfor dmLoaiItemInfor = new DMLoaiItemInfor();
            dmLoaiItemInfor.TenLoaiItem = txtTenLoaiItem.Text;
            dgvList.DataSource = DMLoaiItemDataProvider.Search(dmLoaiItemInfor);
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvList.Rows[e.RowIndex].IsNewRow)
                ucActions1.LoadEditor(dgvList.Rows[e.RowIndex]);
            else
                ucActions1.LoadEditor(null);
        }

        private void ucActions1_OnSynchronize()
        {
            throw new NotImplementedException("Synchronize function is not implemented.");
        }

        #region OLD EVEN

//        private void frmDanhMucCauHinh_Load(object sender, EventArgs e)
//        {
//            string strSql = "Select * from tbl_DM_LoaiItem";// where sudung=1";
//            _listItem = ut.getDataTable(strSql);
//            dgvList.AutoGenerateColumns = false;
//            dgvList.DataSource = _listItem;
//        }

//        private void dgvList_CurrentCellChanged(object sender, EventArgs e)
//        {
//            try
//            {
//                int rowIndex = dgvList.CurrentRow.Index;
//                txtMaLoaiItem.Text = dgvList["MaLoaiItem", rowIndex].Value.ToString();
//                txtTenLoaiItem.Text = dgvList["TenLoaiItem", rowIndex].Value.ToString();
//                txtGhiChu.Text = dgvList["GhiChu", rowIndex].Value.ToString();
//                cbSuDung.Checked =(bool)dgvList["SuDung", rowIndex].Value;
//                //this.Text = "Hệ thống quản lý bán lẻ - [Phân công bảo hành]";
//                //this.Text += "- Số phiếu[" + dgvList["SoPhieu", rowIndex].Value.ToString() + "]";
//                //this.Text += "- Tình trạng[" + dgvList["TenTrangThai", rowIndex].Value.ToString() + "]";
//            }
//            catch
//            { }
//        }

//        private void btTimKiem_Click(object sender, EventArgs e)
//        {
//            //try
//            //{
//                string strSql = " Select * from tbl_DM_LoaiItem where sudung=1";
                
//                if (!String.IsNullOrEmpty(txtTenLoiSearch.Text))
//                {
//                    //strSql += " and TenCauHinh_ThietBi ";
//                    strSql += " and TenLoaiItem like '%" + txtTenLoiSearch.Text + "%'";
//                }
//                _listItem = ut.getDataTable(strSql);
//                dgvList.DataSource = _listItem;
//            //}
//            //catch (Exception ex)
//            //{
//            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            //}
//        }
//        private void FormRefresh()
//        {
//            txtTenLoaiItem.Text = "";
//            txtGhiChu.Text = "";
//            cbSuDung.Checked = false;
//            this.txtTenLoaiItem.Focus();
//        }
//        private void btThem_Click(object sender, EventArgs e)
//        {            
//            FormRefresh();
//            btThem.Enabled = false;
//        }
//        private bool KiemtraMaloaiItem(DataTable list, string ma)
//        {
//            if (list.Rows.Count == 0)
//            {
//                return true;
//            }
//            for (int i = 0; i < list.Rows.Count; i++)
//            {
//                if (list.Rows[i]["MaLoaiItem"].ToString().Trim() == ma && this.btThem.Enabled == false)
//                {
//                    return false;
//                }
//                else if (list.Rows[i]["MaLoaiItem"].ToString().Trim() == ma && (int)list.Rows[i]["IdLoaiItem"] != (int)dgvList["IdLoaiItem", dgvList.CurrentRow.Index].Value)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//        private void btCapNhat_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (txtMaLoaiItem.Text.Trim() == "")
//                {
//                    MessageBox.Show("Mã loại Item không được để trống!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return;
//                }
//                if (txtTenLoaiItem.Text.Trim() == "")
//                {
//                    MessageBox.Show("Tên loại Item không được để trống!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return;
//                }
//                if (KiemtraMaloaiItem(_listItem, txtMaLoaiItem.Text.Trim()) == true)
//                {
//                    if (btThem.Enabled == false)
//                    {
//                        GtidCommand SqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
//                        SqlCmd.CommandText = "sp_DM_LoaiItem_Insert";
//                        SqlCmd.CommandType = CommandType.StoredProcedure;
//                        SqlCmd.Parameters.AddWithValue("@MaLoaiItem", txtMaLoaiItem.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@TenLoaiItem", txtTenLoaiItem.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@SuDung", cbSuDung.Checked).Direction = ParameterDirection.Input;
//                        SqlCmd.ExecuteNonQuery();

//                        MessageBox.Show("Cập nhật danh mục thành công!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                    else
//                    {
//                        int rowIndex = dgvList.CurrentRow.Index;

//                        GtidCommand SqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
//                        SqlCmd.CommandText = "sp_DM_LoaiItem_Update";
//                        SqlCmd.CommandType = CommandType.StoredProcedure;
//                        SqlCmd.Parameters.AddWithValue("@MaLoaiItem", txtMaLoaiItem.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@IdLoaiItem", (int)dgvList["IdLoaiItem", rowIndex].Value).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@TenLoaiItem", txtTenLoaiItem.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@SuDung", cbSuDung.Checked).Direction = ParameterDirection.Input;
//                        SqlCmd.ExecuteNonQuery();

//                        MessageBox.Show("Cập nhật danh mục thành công!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                    string strSql = "Select * from tbl_DM_LoaiItem";
//                    _listItem = ut.getDataTable(strSql);
//                    dgvList.AutoGenerateColumns = false;
//                    dgvList.DataSource = _listItem;
//                    btThem.Enabled = true;
//                }
//                else
//                {
//                    MessageBox.Show("Mã loại Item này đã được sử dụng", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Question);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btXoa_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (MessageBox.Show(Declare.msgRemoveData, Declare.titleNotice, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//                {
//                    //int rowIndex = dgvList.CurrentRow.Index;

//                    object obj = DBTools.ExecuteQuery("Delete From tbl_DM_LoaiItem Where IdLoaiItem = " + Common.IntValue(_listItem.Rows[_listItem.Rows.Count - 1]["IdLoaiItem"]), CommandType.Text);
//                    if (obj == null)
//                        MessageBox.Show(Declare.msgDeleteErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    else
//                    {
//                        string strSql = "Select * from tbl_DM_LoaiItem where sudung=1";
//                        _listItem = ut.getDataTable(strSql);
//                        dgvList.AutoGenerateColumns = false;
//                        dgvList.DataSource = _listItem;
//                        MessageBox.Show(Declare.msgDeleteSucc, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                }
//            }
//            catch (System.Exception ex)
//            {
//#if DEBUG
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#else
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#endif
//            }
//        }
//        private void btThoat_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void txtTenLoiSearch_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if (e.KeyChar == 13)
//            {
//                btTimKiem_Click(sender, e);
//            }
//        }
        #endregion
    }
}