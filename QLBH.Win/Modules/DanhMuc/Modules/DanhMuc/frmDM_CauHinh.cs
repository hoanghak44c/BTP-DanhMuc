using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBH.Core.Data;

namespace QLBanHang.Modules
{
    public partial class frmDM_CauHinh : Form
    {
        #region Valiables
            private DataTable _listItem;
            private Utils ut = new Utils();
            private ItemBaoHanh _itemBaoHanh;
            private string _btSelected;
        #endregion


        public frmDM_CauHinh()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        

        private void frmDanhMucCauHinh_Load(object sender, EventArgs e)
        {
            ut.LoadComboBox(cboLoaiItem, "Select IdLoaiItem,TenLoaiItem from tbl_DM_LoaiItem where sudung=1");
            ut.LoadComboBox(cboLoaiItemSearch, "Select IdLoaiItem,TenLoaiItem from tbl_DM_LoaiItem where sudung=1", -1, "");
            string strSql = "Select tb.*,li.* from tbl_DM_CauHinh tb inner join tbl_DM_LoaiItem li on tb.IdLoaiItem=li.IdLoaiItem";
            _listItem = ut.getDataTable(strSql);
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = _listItem;
        }

        private void dgvList_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            try
            {

                string strSql = " Select tb.*,li.* from tbl_DM_CauHinh tb inner join tbl_DM_LoaiItem li on tb.IdLoaiItem=li.IdLoaiItem where tb.sudung=1";
                //string dk = "1=1";
                if (cboLoaiItemSearch.SelectedIndex != 0)
                {
                    strSql += " and tb.IdLoaiItem=" + cboLoaiItemSearch.SelectedValue;
                }
                if (!String.IsNullOrEmpty(txtTenCauHinhSearch.Text))
                {
                    //strSql += " and TenCauHinh_ThietBi ";
                    strSql += " and tb.TenCauHinh_ThietBi like '%" + txtTenCauHinhSearch.Text + "%'";
                }
                _listItem = ut.getDataTable(strSql);
                dgvList.DataSource = _listItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormRefresh()
        {
            this.cboLoaiItem.SelectedIndex = 0;
            txtMaCauHinh.Text = "";
            txtCauHinh.Text = "";
            txtGhiChu.Text = "";
            cbSuDung.Checked = false;
            this.txtCauHinh.Focus();
        }
        private void btThem_Click(object sender, EventArgs e)
        {            
            FormRefresh();
            btThem.Enabled = false;
        }
        private bool KiemtraMaCauhinh(DataTable list, string ma)
        {
            if (list.Rows.Count == 0)
            {
                return true;
            }
            for (int i = 0; i < list.Rows.Count; i++)
            {

                if (list.Rows[i]["MaCauhinh"].ToString().Trim() == ma && this.btThem.Enabled == false)
                {
                    return false;
                }
                else if (list.Rows[i]["MaCauhinh"].ToString().Trim() == ma && (int)list.Rows[i]["IdCauHinh_ThietBi"] != (int)dgvList["IdCauHinh_ThietBi", dgvList.CurrentRow.Index].Value)
                {
                    return false;
                }
            }
            return true;
        }
        
        private void btCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaCauHinh.Text.Trim() == "")
                {
                    MessageBox.Show("Mã loại cấu hình không được để trống!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtCauHinh.Text.Trim() == "")
                {
                    MessageBox.Show("Tên cấu hình không được để trống!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (KiemtraMaCauhinh(_listItem, txtMaCauHinh.Text.Trim()) == true)
                {
                    if (btThem.Enabled == false)
                    {
                        GtidCommand SqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
                        SqlCmd.CommandText = "sp_DM_CauHinh_Insert";
                        SqlCmd.CommandType = CommandType.StoredProcedure;
                        SqlCmd.Parameters.AddWithValue("@MaCauHinh", txtMaCauHinh.Text).Direction = ParameterDirection.Input;
                        SqlCmd.Parameters.AddWithValue("@IdLoaiItem", cboLoaiItem.SelectedValue).Direction = ParameterDirection.Input;
                        SqlCmd.Parameters.AddWithValue("@TenCauHinh_ThietBi", txtCauHinh.Text).Direction = ParameterDirection.Input;
                        SqlCmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text).Direction = ParameterDirection.Input;
                        SqlCmd.Parameters.AddWithValue("@SuDung", cbSuDung.Checked).Direction = ParameterDirection.Input;
                        SqlCmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật danh mục thành công!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        int rowIndex = dgvList.CurrentRow.Index;

                        GtidCommand SqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
                        SqlCmd.CommandText = "sp_DM_CauHinh_Update";
                        SqlCmd.CommandType = CommandType.StoredProcedure;
                        SqlCmd.Parameters.AddWithValue("@MaCauHinh", txtMaCauHinh.Text).Direction = ParameterDirection.Input;
                        SqlCmd.Parameters.AddWithValue("@IdCauHinh_ThietBi", (int)dgvList["IdCauHinh_ThietBi", rowIndex].Value).Direction = ParameterDirection.Input;
                        SqlCmd.Parameters.AddWithValue("@IdLoaiItem", cboLoaiItem.SelectedValue).Direction = ParameterDirection.Input;
                        SqlCmd.Parameters.AddWithValue("@TenCauHinh_ThietBi", txtCauHinh.Text).Direction = ParameterDirection.Input;
                        SqlCmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text).Direction = ParameterDirection.Input;
                        SqlCmd.Parameters.AddWithValue("@SuDung", cbSuDung.Checked).Direction = ParameterDirection.Input;
                        SqlCmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật danh mục thành công!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    string strSql = "Select tb.*,li.* from tbl_DM_CauHinh tb inner join tbl_DM_LoaiItem li on tb.IdLoaiItem=li.IdLoaiItem";
                    _listItem = ut.getDataTable(strSql);
                    dgvList.AutoGenerateColumns = false;
                    dgvList.DataSource = _listItem;
                    btThem.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Mã loại cấu hình này đã được sử dụng", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(Declare.msgRemoveData, Declare.titleNotice, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //int rowIndex = dgvList.CurrentRow.Index;

                    object obj = DBTools.ExecuteQuery("Delete From tbl_DM_CauHinh Where IdCauHinh_ThietBi = " + Common.IntValue(_listItem.Rows[_listItem.Rows.Count - 1]["IdCauHinh_ThietBi"]), CommandType.Text);
                    if (obj == null)
                        MessageBox.Show(Declare.msgDeleteErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        string strSql = "Select tb.*,li.* from tbl_DM_CauHinh tb inner join tbl_DM_LoaiItem li on tb.IdLoaiItem=li.IdLoaiItem where tb.sudung=1";
                        _listItem = ut.getDataTable(strSql);
                        dgvList.AutoGenerateColumns = false;
                        dgvList.DataSource = _listItem;
                        MessageBox.Show(Declare.msgDeleteSucc, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenCauHinhSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btTimKiem_Click(sender, e);
            }
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dgvList.CurrentRow.Index;
                cboLoaiItem.SelectedValue = dgvList["IdLoaiItem", rowIndex].Value;
                txtCauHinh.Text = dgvList["TenCauHinh_ThietBi", rowIndex].Value.ToString();
                txtGhiChu.Text = dgvList["GhiChu", rowIndex].Value.ToString();
                txtMaCauHinh.Text = dgvList["MaCauHinh", rowIndex].Value.ToString();
                cbSuDung.Checked = (bool)dgvList["SuDung", rowIndex].Value;
                //this.Text = "Hệ thống quản lý bán lẻ - [Phân công bảo hành]";
                //this.Text += "- Số phiếu[" + dgvList["SoPhieu", rowIndex].Value.ToString() + "]";
                //this.Text += "- Tình trạng[" + dgvList["TenTrangThai", rowIndex].Value.ToString() + "]";
            }
            catch
            { }
        }
        
    }
}