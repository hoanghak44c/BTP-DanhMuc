using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBH.Core;
using QLBH.Core.Data;

// <Remarks>
// Tạo form danh mục loại dịch vụ
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 03/03/2012
// Người sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_LoaiDichVu_Old : DevExpress.XtraEditors.XtraForm
    {
        #region Valiables
            //private DataTable _listItem;
            //private Utils ut = new Utils();
            //private ItemBaoHanh _itemBaoHanh;
            //private string _btSelected;
        #endregion

        private int iddichvu = 0;
        public frmDM_LoaiDichVu_Old()
        {
            InitializeComponent();
            ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmLoaiDichVu);
            //Common.LoadStyle(this);
        }

        private void frmDM_LoaiDichVu_Load(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = DMLoaiDichVuDataProvider.GetListDichVuInfo();
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

        private void ucActions1_OnAdd(object obj)
        {
            DMLoaiDichVuInfor dmLoaiDichVuInfor = new DMLoaiDichVuInfor();
            dmLoaiDichVuInfor.MaLoaiDichVu = txtMaLoaiDichVu.Text;
            dmLoaiDichVuInfor.TenDichVu = txtTenLoaiDichVu.Text;
            dmLoaiDichVuInfor.GhiChu = txtGhiChu.Text;
            dmLoaiDichVuInfor.SuDung = Convert.ToInt32(cbSuDung.Checked);
            DMLoaiDichVuDataProvider.Insert(dmLoaiDichVuInfor);
            MessageBox.Show("Thêm bảng thành công!");
            dgvList.DataSource = DMLoaiDichVuDataProvider.GetListDichVuInfo();
        }

        private void ucActions1_OnClose()
        {
            this.Close();
        }

        private void ucActions1_OnDelete(object obj)
        {
            //DMLoaiDichVuInfor khaibao = new DMLoaiDichVuInfor();
            //khaibao.IdLoaiDichVu = Convert.ToInt32(getValue("clIdLoaiDichVu"));
            DMLoaiDichVuDataProvider.Delete(new DMLoaiDichVuInfor{IdLoaiDichVu = Convert.ToInt32(getValue("clIdLoaiDichVu"))});
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvList.DataSource = DMLoaiDichVuDataProvider.GetListDichVuInfo();
        }

        private object getValue(string colName)
        {
            if (dgvList.CurrentRow != null && !dgvList.CurrentRow.IsNewRow)
                return dgvList.CurrentRow.Cells[colName].Value;
            return null;
        }


        private void ucActions1_OnDisableEditor()
        {
            txtMaLoaiDichVu.Enabled = false;
            txtTenLoaiDichVu.Enabled = false;
            txtGhiChu.Enabled = false;
            cbSuDung.Enabled = false;
        }

        private void ucActions1_OnEnableEditor()
        {
            txtMaLoaiDichVu.Enabled = true;
            txtTenLoaiDichVu.Enabled = true;
            txtGhiChu.Enabled = true;
            cbSuDung.Enabled = true;
        }

        private void ucActions1_OnLoadEditor(object obj)
        {
            if (obj != null)
            {
                txtMaLoaiDichVu.Text = Convert.ToString(getValue("clMaLoaiDichVu"));
                txtTenLoaiDichVu.Text = Convert.ToString(getValue("clTenDichVu"));
                txtGhiChu.Text = Convert.ToString(getValue("clGhiChu"));
                cbSuDung.Text = Convert.ToString(getValue("clSuDung"));
                return;
            }
            txtMaLoaiDichVu.Text = String.Empty;
            txtTenLoaiDichVu.Text = String.Empty;
            txtGhiChu.Text = String.Empty;
            cbSuDung.Text = String.Empty;
        }

        private void ucActions1_OnUpdate(object obj)
        {
            DMLoaiDichVuInfor dmLoaiDichVuInfor = new DMLoaiDichVuInfor();
            dmLoaiDichVuInfor.MaLoaiDichVu = txtMaLoaiDichVu.Text;
            dmLoaiDichVuInfor.TenDichVu = txtTenLoaiDichVu.Text;
            dmLoaiDichVuInfor.GhiChu = txtGhiChu.Text;
            dmLoaiDichVuInfor.SuDung = Convert.ToInt32(cbSuDung.Checked);
            DMLoaiDichVuDataProvider.Update(dmLoaiDichVuInfor);
            MessageBox.Show("Sửa bảng thành công!");
            dgvList.DataSource = DMLoaiDichVuDataProvider.GetListDichVuInfo();
        }

        private void ucActions1_OnValidate(object obj, QLBH.Core.ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    iddichvu = getEditId(obj);
                    if (txtMaLoaiDichVu.Text == String.Empty)
                    {
                        throw new Exception("Mã dịch vụ không Được Để Trống!");
                    }
                    if (DMLoaiDichVuDataProvider.Kiemtra(new DMLoaiDichVuInfor{IdLoaiDichVu = iddichvu,TenDichVu = txtTenLoaiDichVu.Text}))
                    {
                        throw new Exception("Mã dịch vụ Đã Tồn Tại!");
                    }
                    break;
            }
        }
        private int getEditId(object obj)
        {
            DataGridViewRow dr = obj as DataGridViewRow;
            if (dr == null) return 0;
            return Convert.ToInt32(dr.Cells["clIdLoaiDichVu"].Value);
        }

        private bool Exist(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            return dmLoaiDichVuInfor.MaLoaiDichVu != null&& dmLoaiDichVuInfor.MaLoaiDichVu.ToLower() == txtMaLoaiDichVu.Text.Trim().ToLower();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && !dgvList.Rows[e.RowIndex].IsNewRow)
                ucActions1.LoadEditor(dgvList.Rows[e.RowIndex]);
            else
            {
                ucActions1.LoadEditor(null);
            }
            //ucActions1.LoadEditor(dgvList.Rows[e.RowIndex].IsNewRow ? null : dgvList.Rows[e.RowIndex]);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            DMLoaiDichVuInfor dmLoaiDichVuInfor = new DMLoaiDichVuInfor();
            dmLoaiDichVuInfor.TenDichVu = txtTenLoaiDichVu.Text;
            dgvList.DataSource = DMLoaiDichVuDataProvider.Search(dmLoaiDichVuInfor);
        }
        private bool timkiem(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            return (txtTenLoaiDichVuSearch.Text.Trim() == String.Empty || (txtTenLoaiDichVuSearch.Text.Trim() != String.Empty &&
                    dmLoaiDichVuInfor.TenDichVu.ToLower().Contains(txtTenLoaiDichVuSearch.Text.Trim().ToLower())));
        }

        private void ucActions1_OnSynchronize()
        {
            throw new NotImplementedException("Synchronize function is not implemented.");
        }


        #region OLD EVEN
//        private void frmDanhMucCauHinh_Load(object sender, EventArgs e)
//        {
//            string strSql = "Select * from tbl_DM_LoaiDichVu";
//            _listItem = ut.getDataTable(strSql);
//            dgvList.AutoGenerateColumns = false;
//            dgvList.DataSource = _listItem;
//        }

//        private void dgvList_CurrentCellChanged(object sender, EventArgs e)
//        {
//            try
//            {
//                int rowIndex = dgvList.CurrentRow.Index;
//                txtTenLoaiDichVu.Text = dgvList["TenDichVu", rowIndex].Value.ToString();
//                txtMaLoaiDichVu.Text = dgvList["MaLoaiDichVu", rowIndex].Value.ToString();
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
//            string strSql = " Select * from tbl_DM_LoaiDichVu";
                
//                if (!String.IsNullOrEmpty(txtTenLoaiDichVuSearch.Text))
//                {
//                    //strSql += " and TenCauHinh_ThietBi ";
//                    strSql += " and TenDichVu like '%" + txtTenLoaiDichVuSearch.Text + "%'";
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
//            txtMaLoaiDichVu.Text = "";
//            txtTenLoaiDichVu.Text = "";
//            txtGhiChu.Text = "";
//            cbSuDung.Checked = false;
//            this.txtTenLoaiDichVu.Focus();
//        }
//        private void btThem_Click(object sender, EventArgs e)
//        {            
//            FormRefresh();
//            btThem.Enabled = false;
//        }
//        private bool KiemtraMaloaiDV(DataTable list, string ma)
//        {
//            if (list.Rows.Count == 0)
//            {
//                return true;
//            }
//            for (int i = 0; i < list.Rows.Count; i++)
//            {
//                if (list.Rows[i]["MaLoaiDichVu"].ToString().Trim() == ma && this.btThem.Enabled == false)
//                {
//                    return false;
//                }
//                else if (list.Rows[i]["MaLoaiDichVu"].ToString().Trim() == ma && (int)list.Rows[i]["IdLoaiDichVu"] != (int)dgvList["IdLoaiDichVu", dgvList.CurrentRow.Index].Value)
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

//                if (txtMaLoaiDichVu.Text.Trim() == "")
//                {
//                    MessageBox.Show("Mã loại dịch vụ không được để trống!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return;
//                }
//                if (txtTenLoaiDichVu.Text.Trim() == "")
//                {
//                    MessageBox.Show("Tên dịch vụ không được để trống!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return;
//                }
//                if (KiemtraMaloaiDV(_listItem, txtMaLoaiDichVu.Text.Trim()) == true)
//                {
//                    if (btThem.Enabled == false)
//                    {
//                        GtidCommand SqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
//                        SqlCmd.CommandText = "sp_DM_LoaiDichVu_Insert";
//                        SqlCmd.CommandType = CommandType.StoredProcedure;
//                        SqlCmd.Parameters.AddWithValue("@MaLoaiDichVu", txtMaLoaiDichVu.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@TenDichVu", txtTenLoaiDichVu.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@SuDung", cbSuDung.Checked).Direction = ParameterDirection.Input;
//                        SqlCmd.ExecuteNonQuery();

//                        MessageBox.Show("Cập nhật danh mục thành công!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                    else
//                    {
//                        int rowIndex = dgvList.CurrentRow.Index;

//                        GtidCommand SqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
//                        SqlCmd.CommandText = "sp_DM_LoaiDichVu_Update";
//                        SqlCmd.CommandType = CommandType.StoredProcedure;
//                        SqlCmd.Parameters.AddWithValue("@IdLoaiDichVu", (int)dgvList["IdLoaiDichVu", rowIndex].Value).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@MaLoaiDichVu", txtMaLoaiDichVu.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@TenDichVu", txtTenLoaiDichVu.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@SuDung", cbSuDung.Checked).Direction = ParameterDirection.Input;
//                        SqlCmd.ExecuteNonQuery();

//                        MessageBox.Show("Cập nhật danh mục thành công!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                    string strSql = "Select * from tbl_DM_LoaiDichVu";
//                    _listItem = ut.getDataTable(strSql);
//                    dgvList.AutoGenerateColumns = false;
//                    dgvList.DataSource = _listItem;
//                    btThem.Enabled = true;
//                }
//                else
//                {
//                    MessageBox.Show("Mã loại dịch vụ này đã được sử dụng", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Question);
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

//                    object obj = DBTools.ExecuteQuery("Delete From tbl_DM_LoaiDichVu Where IdLoaiDichVu = " + Common.IntValue(_listItem.Rows[_listItem.Rows.Count - 1]["IdLoaiDichVu"]), CommandType.Text);
//                    if (obj == null)
//                        MessageBox.Show(Declare.msgDeleteErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    else
//                    {
//                        string strSql = "Select * from tbl_DM_LoaiDichVu";
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