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

//Note:@HanhBD frmDM_MaLoi 
// <Remarks>
// tạo form danh mục Mã lỗi
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 02/03/2012
// Người sửa cuối:02/03/2012
// </remarks>
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_MaLoi_Old : DevExpress.XtraEditors.XtraForm
    {
        private int idMaLoi = 0;
        public frmDM_MaLoi_Old()
        {
            InitializeComponent();
            ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmMaLoi);
            //Common.LoadStyle(this);
        }

        private void frmDM_MaLoi_Load(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = DMMaLoiDataProvider.GetListMaLoiInfor();
            }
            catch
            {
//#if DEBUG
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#else
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#endif
//                this.Dispose();
            }
        }
        private DMMaLoiInfor getinfor()
        {
            DMMaLoiInfor dmMaLoiInfor = new DMMaLoiInfor();
            dmMaLoiInfor.MaLoi = txtMaLoi.Text;
            dmMaLoiInfor.TenLoi = txtTenLoi.Text;
            dmMaLoiInfor.GhiChu = txtGhiChu.Text;
            dmMaLoiInfor.SuDung = Convert.ToInt32(cbSuDung.Checked);
            dmMaLoiInfor.IdMaLoi = Convert.ToInt32(getValue("IdMaLoi"));
            return dmMaLoiInfor;
        }

        private void ucActions1_OnAdd(object obj)
        {
            DMMaLoiDataProvider.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
            dgvList.DataSource = DMMaLoiDataProvider.GetListMaLoiInfor();
        }

        private void ucActions1_OnClose()
        {
            this.Close();
        }

        private void ucActions1_OnDelete(object obj)
        {
            //DMMaLoiInfor khaibao = new DMMaLoiInfor();
            //khaibao.IdMaLoi = Convert.ToInt32(getValue("IdMaLoi"));
            DMMaLoiDataProvider.Delete(new DMMaLoiInfor{IdMaLoi = Convert.ToInt32(getValue("IdMaLoi"))});
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvList.DataSource = DMMaLoiDataProvider.GetListMaLoiInfor();
        }

        private object getValue(string colName)
        {
            if (dgvList.CurrentRow != null && !dgvList.CurrentRow.IsNewRow)
                return dgvList.CurrentRow.Cells[colName].Value;
            return null;
        }

        private void ucActions1_OnDisableEditor()
        {
            txtMaLoi.Enabled = false;
            txtTenLoi.Enabled = false;
            txtGhiChu.Enabled = false;
            cbSuDung.Enabled = false;
            cboLoaiItem.Enabled = false;
        }

        private void ucActions1_OnEnableEditor()
        {
            txtMaLoi.Enabled = true;
            txtTenLoi.Enabled = true;
            txtGhiChu.Enabled = true;
            cbSuDung.Enabled = true;
            cboLoaiItem.Enabled = true;
        }

        private void ucActions1_OnLoadEditor(object obj)
        {
            if (obj != null)
            {
                txtMaLoi.Text = Convert.ToString(getValue("MaLoi"));
                txtTenLoi.Text = Convert.ToString(getValue("TenLoi"));
                txtGhiChu.Text = Convert.ToString(getValue("GhiChu"));
                cbSuDung.Checked= Convert.ToInt32(getValue("SuDung"))==1;
                cboLoaiItem.SelectedIndex = Convert.ToInt32("TenLoaiItem");
                return;
            }
            txtMaLoi.Text = String.Empty;
            txtTenLoi.Text = String.Empty;
            txtGhiChu.Text = String.Empty;
            cbSuDung.Checked = false;
            cboLoaiItem.Text = String.Empty;
        }

        private void ucActions1_OnUpdate(object obj)
        {
            DMMaLoiDataProvider.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
            dgvList.DataSource = DMMaLoiDataProvider.GetListMaLoiInfor();
        }

        private void ucActions1_OnValidate(object obj, ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    idMaLoi = getEditId(obj);
                    if (txtMaLoi.Text == String.Empty)
                    {
                        throw new Exception("Mã Lỗi Không Được Để Trống!");
                    }
                    if (DMMaLoiDataProvider.Kiemtra(new DMMaLoiInfor{IdMaLoi = idMaLoi,TenLoi = txtTenLoi.Text}))
                    {
                        //với trường hợp update, delete thì thì phải check xem là đã có bảng nào tham chiếu đến chưa. 
                        //Nếu có thì không xóa mà warning người dùng và cập nhật lại sudung=0, và phải warning nếu update.
                        throw new Exception("Mã Lỗi Đã Tồn Tại!");
                    }
                    break;
            }     
        }

        private int getEditId(object obj)
        {
            DataGridViewRow dr = obj as DataGridViewRow;
            if (dr == null) return 0;
            return Convert.ToInt32(dr.Cells["IdMaLoi"].Value);
        }

        private bool Exist(DMMaLoiInfor dmMaLoiInfor)
        {
            return dmMaLoiInfor.IdMaLoi != idMaLoi &&
                dmMaLoiInfor.MaLoi.ToLower() == txtMaLoi.Text.Trim().ToLower();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            //dgvList.DataSource = DMMaLoiDataProvider.Search(Search);
            DMMaLoiInfor dmMaLoiInfor = new DMMaLoiInfor();
            dmMaLoiInfor.TenLoi = txtTenLoiSearch.Text;
            dmMaLoiInfor.IdLoaiItem = cboLoaiItemSearch.SelectedIndex;
            //dgvList.DataSource = DMMaLoiDataProvider.Search(dmMaLoiInfor);
        }
         
        private bool Search(DMMaLoiInfor dmMaLoiInfor)
        {
            return (cboLoaiItemSearch.Text.Trim() == String.Empty || (cboLoaiItemSearch.Text.Trim() != String.Empty &&
                    dmMaLoiInfor.MaLoi.ToLower().Contains(cboLoaiItemSearch.Text.Trim().ToLower())))
                   && (txtTenLoiSearch.Text.Trim() == String.Empty || (txtTenLoiSearch.Text.Trim() != String.Empty &&
                       dmMaLoiInfor.TenLoi.ToLower().Contains(txtTenLoiSearch.Text.Trim().ToLower())));

        }

        private void ucActions1_OnSynchronize()
        {
            throw new NotImplementedException("Synchronize function is not implemented.");
        }

        #region OLD EVEN
//        private void frmDanhMucCauHinh_Load(object sender, EventArgs e)
//        {            
//            ut.LoadComboBox(cboLoaiItem, "Select IdLoaiItem,TenLoaiItem from tbl_DM_LoaiItem where sudung=1");
//            ut.LoadComboBox(cboLoaiItemSearch, "Select IdLoaiItem,TenLoaiItem from tbl_DM_LoaiItem where sudung=1", -1, "");
//            string strSql = "Select ml.*,li.* from tbl_DM_MaLoi ml inner join tbl_DM_LoaiItem li on ml.IdLoaiItem=li.IdLoaiItem";
//            _listItem = ut.getDataTable(strSql);
//            dgvList.AutoGenerateColumns = false;
//            dgvList.DataSource = _listItem;
//            //dgvList.Rows[0].me
//        }

//        private void dgvList_CurrentCellChanged(object sender, EventArgs e)
//        {
//            try
//            {
//                int rowIndex = dgvList.CurrentRow.Index;
//                cboLoaiItem.SelectedValue = dgvList["IdLoaiItem", rowIndex].Value;
//                txtMaLoi.Text = dgvList["MaLoi", rowIndex].Value.ToString();
//                txtTenLoi.Text = dgvList["TenLoi", rowIndex].Value.ToString();
//                txtGhiChu.Text = dgvList["GhiChu", rowIndex].Value.ToString();
//                cbSuDung.Checked =(bool)dgvList["SuDung", rowIndex].Value;
//                //this.Text = "Hệ thống quản lý bán lẻ - [Phân công bảo hành]";
//                //this.Text += "- Số phiếu[" + dgvList["SoPhieu", rowIndex].Value.ToString() + "]";
//                //this.Text += "- Tình trạng[" + dgvList["TenTrangThai", rowIndex].Value.ToString() + "]";
//            }
//            catch
//            { }
//        }
//        private bool KiemtraMaloi(DataTable list,string maloi)
//        {
//            if (list.Rows.Count == 0)
//            {
//                return true;
//            }
//            for (int i = 0; i < list.Rows.Count; i++)
//            {

//                if (list.Rows[i]["MaLoi"].ToString().Trim() == maloi && this.btThem.Enabled == false && dgvList["TenLoaiItem", dgvList.CurrentRow.Index].Value.ToString()==cboLoaiItem.SelectedValue.ToString())
//                {
//                    return false;
//                }
//                else if (list.Rows[i]["MaLoi"].ToString().Trim() == maloi && (int)dgvList["IdMaLoi", dgvList.CurrentRow.Index].Value != (int)list.Rows[i]["IdMaLoi"] && dgvList["TenLoaiItem", dgvList.CurrentRow.Index].Value.ToString() == cboLoaiItem.SelectedValue.ToString())
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//        private void btTimKiem_Click(object sender, EventArgs e)
//        {
//            //try
//            //{
//                string strSql = " Select ml.*,li.* from tbl_DM_MaLoi ml inner join tbl_DM_LoaiItem li on ml.IdLoaiItem=li.IdLoaiItem";
//                //string dk = "1=1";
//                if (cboLoaiItemSearch.SelectedIndex != 0)
//                {
//                    strSql += " and ml.IdLoaiItem=" + cboLoaiItemSearch.SelectedValue;
//                }
//                if (!String.IsNullOrEmpty(txtTenLoiSearch.Text))
//                {
//                    //strSql += " and TenCauHinh_ThietBi ";
//                    strSql += " and ml.TenLoi like '%" + txtTenLoiSearch.Text + "%'";
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
//            this.cboLoaiItem.SelectedIndex = 0;
//            txtTenLoi.Text = "";
//            txtGhiChu.Text = "";
//            txtMaLoi.Text = "";
//            cbSuDung.Checked = false;
//            this.txtTenLoi.Focus();
//        }
//        private void btThem_Click(object sender, EventArgs e)
//        {            
//            FormRefresh();
//            btThem.Enabled = false;
//        }

//        private void btCapNhat_Click(object sender, EventArgs e)
//        {
//            try
//            {

//                if (txtMaLoi.Text.Trim() == "")
//                {
//                    MessageBox.Show("Mã lỗi hình không được để trống!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return;
//                }
//                if (txtTenLoi.Text.Trim() == "")
//                {
//                    MessageBox.Show("Tên lỗi không được để trống!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return;
//                }
//                if (KiemtraMaloi(_listItem, txtMaLoi.Text.Trim()) == true)
//                {


//                    if (btThem.Enabled == false)
//                    {
//                        GtidCommand SqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
//                        SqlCmd.CommandText = "sp_DM_MaLoi_Insert";
//                        SqlCmd.CommandType = CommandType.StoredProcedure;
//                        SqlCmd.Parameters.AddWithValue("@IdLoaiItem", cboLoaiItem.SelectedValue).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@MaLoi", txtMaLoi.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@TenLoi", txtTenLoi.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@SuDung", cbSuDung.Checked).Direction = ParameterDirection.Input;
//                        SqlCmd.ExecuteNonQuery();

//                        MessageBox.Show("Cập nhật danh mục thành công!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                    else
//                    {
//                        int rowIndex = dgvList.CurrentRow.Index;

//                        GtidCommand SqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
//                        SqlCmd.CommandText = "sp_DM_MaLoi_Update";
//                        SqlCmd.CommandType = CommandType.StoredProcedure;
//                        SqlCmd.Parameters.AddWithValue("@IdMaLoi", (int)dgvList["IdMaLoi", rowIndex].Value).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@MaLoi", txtMaLoi.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@IdLoaiItem", cboLoaiItem.SelectedValue).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@TenLoi", txtTenLoi.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@SuDung", cbSuDung.Checked).Direction = ParameterDirection.Input;
//                        SqlCmd.ExecuteNonQuery();

//                        MessageBox.Show("Cập nhật danh mục thành công!", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                    string strSql = "Select ml.*,li.* from tbl_DM_MaLoi ml inner join tbl_DM_LoaiItem li on ml.IdLoaiItem=li.IdLoaiItem";
//                    _listItem = ut.getDataTable(strSql);
//                    dgvList.AutoGenerateColumns = false;
//                    dgvList.DataSource = _listItem;
//                    btThem.Enabled = true;
//                }
//                else
//                {
//                    MessageBox.Show("Mã lỗi này đã được sử dụng", Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Question);
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

//                    object obj = DBTools.ExecuteQuery("Delete From tbl_DM_MaLoi Where IdMaLoi = " + Common.IntValue(_listItem.Rows[_listItem.Rows.Count - 1]["IdMaLoi"]), CommandType.Text);
//                    if (obj == null)
//                        MessageBox.Show(Declare.msgDeleteErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    else
//                    {
//                        string strSql = "Select ml.*,li.* from tbl_DM_MaLoi ml inner join tbl_DM_LoaiItem li on ml.IdLoaiItem=li.IdLoaiItem";
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