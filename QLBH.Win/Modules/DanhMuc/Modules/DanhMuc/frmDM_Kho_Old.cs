using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;

//Note:@CuongTT frmDM_Kho
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_Kho_Old : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biên"
        private DMKhoInfo dm = new DMKhoInfo();
        public int IdKho = 0;
        public bool isAdd;
#endregion

#region "Các phương thức khởi tạo"
        public frmDM_Kho_Old()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.Text = "Danh mục kho";
        }
#endregion

#region "Các phương thức"

        #region LoadData
        private void LoadData()
        {
            dgvList.DataSource = DMKhoDataProvider.GetListDMKhoInfo();
        }
        #endregion

        #region ReLoad
        public void Reload()
        {
            LoadData();
            dgvList.Refresh();
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi này ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DMKhoDataProvider.Delete(new DMKhoInfo{ IdKho = IdKho });
                LoadData();
                SetControl(false);
                //this.Close();
            }
        }
        #endregion

        //#region Search
        //private bool Search(DMKhoGridLoadInfo dmKHInfor)
        //{
        //    return (txtFilterMaKho.Text.Trim() == String.Empty || (txtFilterMaKho.Text.Trim() != String.Empty &&
        //            dmKHInfor.MaKho.ToLower().Contains(txtFilterMaKho.Text.Trim().ToLower())))
        //           && (txtFilterTenKho.Text.Trim() == String.Empty || (txtFilterTenKho.Text.Trim() != String.Empty &&
        //               dmKHInfor.TenKho.ToLower().Contains(txtFilterTenKho.Text.Trim().ToLower())));

        //}
        //#endregion

        //private void SetCheckList(string lstId)
        //{
        //    string []arrId = lstId.Split(",".ToCharArray());
        //    lstId = "," + lstId + ",";
        //    for (int i = 0; i < lstTrungTam.Items.Count; i++)
        //    {
        //        int data = ((ListItem)lstTrungTam.Items[i]).ItemData;
        //        if (lstId.Contains("," +data+","))
        //            lstTrungTam.SetItemChecked(i, true);
        //        else
        //            lstTrungTam.SetItemChecked(i, false);
        //    }
        //}

        //private bool Kho_SuHopLeCuaThongTin()
        //{
        //    if (this.txtMaKho.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show(Declare.msgFrmDM_Chung_MaChuaNhap, Declare.titleWarning, MessageBoxButtons.OK,MessageBoxIcon.Warning);
        //        this.txtMaKho.Focus();
        //        return false;
        //    }
        //    if (this.txtMaKhoOracle.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show(Declare.msgFrmDM_Chung_MaChuaNhap, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        this.txtMaKhoOracle.Focus();
        //        return false;
        //    }
        //    if (this.cboTrungTam.SelectedValue == null)
        //    {
        //        MessageBox.Show("Trung tâm trực thuộc chưa nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        this.cboTrungTam.Focus();
        //        return false;
        //    }
        //    string strSql = "Select * from tbl_DM_Kho where MaKho=N'" + this.txtMaKho.Text.Trim() + "' and IdTrungTam =" + this.cboTrungTam.SelectedValue.ToString();
        //    if (this.Kho_IsThemMoi)
        //    {
        //        if (DBTools.ExistData(strSql) == true)
        //        {
        //            MessageBox.Show("Mã kho này đã có." + "\n" + "-Hãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            this.txtMaKho.Focus();
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        if (string.Compare(this.txtMaKho.Text.Trim(), this.Kho_MaKho) != 0)
        //        {
        //            if (DBTools.ExistData(strSql) == true)
        //            {
        //                MessageBox.Show("Mã kho này đã có." + "\n" + "-Hãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                this.txtMaKho.Focus();
        //                return false;
        //            }
        //        }
        //    }
        //    if (this.cboMaVung.SelectedValue == null)
        //    {
        //        MessageBox.Show("Nhập vào mã vùng trung tâm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        this.cboMaVung.Focus();
        //        return false;
        //    }
        //    if (this.txtTenKho.Text.Trim().Length == 0)
        //    {
        //        MessageBox.Show("Tên kho chưa nhập.", Declare.titleWarning, MessageBoxButtons.OK,MessageBoxIcon.Warning);
        //        this.txtTenKho.Focus();
        //        return false;
        //    }

        //    string strSqlTen = "Select * from tbl_DM_Kho where TenKho=N'" + this.txtTenKho.Text.Trim() + "'";
        //    if (this.Kho_IsThemMoi)
        //    {
        //        if (DBTools.ExistData(strSqlTen) == true)
        //        {
        //            MessageBox.Show("Têm kho này đã có." + "\n" + "-Hãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            this.txtTenKho.Focus();
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        if (string.Compare(this.txtTenKho.Text.Trim(), this.Kho_TenKho) != 0)
        //        {
        //            if (DBTools.ExistData(strSqlTen) == true)
        //            {
        //                MessageBox.Show("Tên kho này đã có." + "\n" + "-Hãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                this.txtTenKho.Focus();
        //                return false;
        //            }
        //        }
        //    }

            //if (this.txtDiaChi.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("Địa chỉ kho chưa nhập.", Declare.titleWarning, MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    this.txtDiaChi.Focus();
            //    return false;
            //}

        //    if (this.txtEmail.Text.Trim().Length > 0)
        //        if (Common.ValidEmail(this.txtEmail.Text.Trim()) == false) {
        //            MessageBox.Show(Declare.msgValidateEmail, Declare.titleWarning, MessageBoxButtons.OK);
        //            this.txtEmail.Focus();
        //            return false;
        //        }

        //    if (!this.Kho_IsThemMoi)
        //    {
        //        DBTools._IsCheck IsCheck;
        //        IsCheck = DBTools.CheckExistsRecord(this.Kho_IsCheckDeleteCommand(int.Parse(this.dgvList.CurrentRow.Cells["IdKho"].Value.ToString())));
        //        if (IsCheck == DBTools._IsCheck._TRUE)
        //        {
        //            if (!this.chkSuDung.Checked)
        //            {
        //                MessageBox.Show("Dữ liệu của danh mục kho này đã được sử dụng nên trạng thái sử dụng luôn được chọn."+"\n"+"-Hãy chọn lại trạng thái sử dụng", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                this.chkSuDung.Focus();
        //                return false;
        //            }
        //        }
        //        else if (IsCheck == DBTools._IsCheck._EXCEPTION)
        //        {
        //            MessageBox.Show("Lỗi kiểm tra dữ liệu: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //private GtidCommand Kho_IsCheckDeleteCommand(int IdKho)
        //{
        //    GtidCommand sqlcmd = new GtidCommand();
        //    sqlcmd.CommandText = "sp_DM_Kho_IsCheckDelete";
        //    sqlcmd.Parameters.AddWithValue("@IdKho", IdKho).Direction = ParameterDirection.Input;
        //    sqlcmd.Parameters.AddWithValue("@IsCheck",0).Direction = ParameterDirection.Output;
        //    sqlcmd.CommandType = CommandType.StoredProcedure;
        //    return sqlcmd;
        //}
        #region SetControl
        public void SetControl(bool var)
        {
            btnXoa.Enabled = var;
            btnCapNhat.Enabled = var;
        }
        #endregion
#endregion

        #region "Các sự kiện"
        private void frmDM_Kho_Load(object sender, EventArgs e)
        {
            try
            {
                SetControl(false);
                LoadData();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //isAdd = true;
            //frmChiTiet_Kho frm = new frmChiTiet_Kho(this);
            //frm.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //isAdd = false;
            //frmChiTiet_Kho frm = new frmChiTiet_Kho(this);
            //frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                            MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void txtMaKho_KeyPress(object sender, KeyPressEventArgs e)
        { 
//            try
//            {
//                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_CHAR_A_Z_a_z_0_9);
//                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_TOUPPER);
//            }
//            catch (Exception ex)
//            {
//#if DEBUG
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#else
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#endif
//            }
//        }

//        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
//        {  
//            try
//            {
//                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_PHONE);
//            }
//            catch (Exception ex)
//            {
//#if DEBUG
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#else
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#endif
//            }
        }

        private void frmDM_Kho_KeyDown(object sender, KeyEventArgs e)
        {
//            try
//            {
//                if (e.KeyCode == Keys.Enter)
//                {
//                    if (!this.txtGhiChu.Focused)
//                        SendKeys.Send("{TAB}");
//                    e.Handled = true;
//                }
//                else if (e.KeyCode == Keys.F3)
//                {
//                    if (this.WindowState == FormWindowState.Maximized)
//                        this.WindowState = FormWindowState.Normal;
//                    else
//                        this.WindowState = FormWindowState.Maximized;
//                    e.Handled = true;
//                }
//            }
//            catch (Exception ex)
//            {
//#if DEBUG
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#else
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#endif
//            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //try {
            //    Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_NOT_SPACE);
            //}
            //catch (Exception ex) {
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = DMKhoDataProvider.Search(new DMKhoGridLoadInfo{MaKho = txtFilterMaKho.Text.Trim(),TenKho = txtFilterTenKho.Text.Trim()});
//            try {
//                string dk = "1=1";
//                if (!String.IsNullOrEmpty(txtFilterMaKho.Text)) {
//                    dk += String.Format(" and MaKho like '{0}'", txtFilterMaKho.Text.Trim());
//                }

//                if (!String.IsNullOrEmpty(txtFilterTenKho.Text)) {
//                    dk += String.Format(" and TenKho like N'{0}'", txtFilterTenKho.Text.Trim());
//                }

//                this.dtKho = (DataTable)DBTools.getData("tbl_DM_Kho", String.Format("select IdKho,IdTrungTam,MaKho,TenKho,DiaChi,DienThoai,Fax,Email,GhiChu,SuDung,MaVung,MaKhoOracle,OtherTrungTam from tbl_DM_Kho where {0}", dk)).Tables["tbl_DM_Kho"];
//                if (this.dtKho != null) {
//                    this.Kho_ThemCotSoTT();
//                    this.Kho_CapNhatSoTT(0);

//                    cm = (CurrencyManager)this.BindingContext[this.dtKho.DefaultView];
//                    cm.PositionChanged += new EventHandler(this.Position_Changed);
//                    this.Kho_HienThi(this.cm.Position);

//                    this.dgvList.DataSource = this.dtKho.DefaultView;
//                    this.dgvList.Refresh();

//                }
//                else {
//                    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//            }
//            catch (System.Exception ex) {
//#if DEBUG
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#else
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#endif
//            }
        }
#endregion

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            //isAdd = false;
            //frmChiTiet_Kho frm = new frmChiTiet_Kho(this);
            //frm.ShowDialog();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                SetControl(true);
                IdKho = ((DMKhoGridLoadInfo) dgvList.Rows[e.RowIndex].DataBoundItem).IdKho;
            }
        }

    }
}