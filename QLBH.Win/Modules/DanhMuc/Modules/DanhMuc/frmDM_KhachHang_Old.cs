// <summary>
// Mô tả class: Lớp đối tượng thực hiện việc cập nhật danh mục khách hàng
// </summary>
// <remarks>
// Người tạo: Nguyễn Văn Thuấn
// Ngày tạo: 10/10/2007
// </remarks>

using System;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Data;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Infors;

//Note:@CuongTT frmDM_KhachHang 
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_KhachHang_Old : DevExpress.XtraEditors.XtraForm
    {
#region "Khai báo biến"
        List<DMDoiTuongInfo> listDoiTuong;
        public string strMaKhachHang = "";
        public int IdDoiTuong = 0;
        public bool isAdd;
        public int OidKhachHang;
#endregion

#region"Phương thức khởi tạo"
        public frmDM_KhachHang_Old()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
#endregion

#region"Các phương thức"
        #region OLD
        //private void LuoiHienThi_AnCot()
        //{
        //    this.dgvKhachHang.Columns["IdDoiTuong"].Visible = false;
        //    this.dgvKhachHang.Columns["clFax"].Visible = false;
        //    this.dgvKhachHang.Columns["clEmail"].Visible = false;
        //    this.dgvKhachHang.Columns["clType"].Visible = false;
        //    this.dgvKhachHang.Columns["clGhiChu"].Visible = false;
        //    this.dgvKhachHang.Columns["IdCha"].Visible = false;
        //    this.dgvKhachHang.Columns["clIdOrderType"].Visible = false;
        //}

        //private void LuoiHienThi_Resize()
        //{
        //    int Luoi_ChieuDai = this.dgvKhachHang.Width;
        //    int Luoi_ChieuDaiCacCot;
        //    Luoi_ChieuDaiCacCot = this.SoTT.Width +
        //        this.clSuDung.Width +
        //        this.TenKhachHang.Width +
        //        this.MaKhachHang.Width +
        //        this.clDiaChi.Width +
        //        this.clDienThoai.Width +
        //        this.dgvKhachHang.RowHeadersWidth + 2;
        //    if (Luoi_ChieuDai > Luoi_ChieuDaiCacCot)
        //        this.dgvKhachHang.Columns["clDiaChi"].Width = Luoi_ChieuDai - (this.SoTT.Width +
        //                                            this.clSuDung.Width +
        //                                            this.TenKhachHang.Width +
        //                                            this.MaKhachHang.Width +
        //                                            this.clDienThoai.Width +
        //                                            this.dgvKhachHang.RowHeadersWidth + 2);
        //    else
        //        this.dgvKhachHang.Columns["clDiaChi"].Width = 300;
        //    this.dgvKhachHang.Refresh();


        //}

        //private DoiTuongInfo GetInfor()
        //{
        //    DoiTuongInfo doiTuongInfo = new DoiTuongInfo();
        //    doiTuongInfo.IdDoiTuong = 0;
        //    doiTuongInfo.IdCha = this.cboCha.SelectedItem == null ? 0 : (this.cboCha.SelectedItem as ListItem).ItemData;
        //    doiTuongInfo.MaDoiTuong = this.txtMa.Text.Trim();
        //    doiTuongInfo.TenDoiTuong = this.txtTen.Text.Trim();
        //    doiTuongInfo.NguoiLienLac = this.txtNguoiLienLac.Text.Trim();
        //    doiTuongInfo.DienThoai = this.txtDienThoai.Text.Trim();
        //    doiTuongInfo.Fax = this.txtFax.Text.Trim();
        //    doiTuongInfo.Email = this.txtEmail.Text.Trim();
        //    doiTuongInfo.MaSoThue = this.txtMaSoThue.Text.Trim();
        //    doiTuongInfo.Type = this.cboType.SelectedIndex;
        //    doiTuongInfo.SuDung = this.chkSuDung.Checked ? 1 : 0;
        //    doiTuongInfo.GhiChu = this.txtGhiChu.Text.Trim();
        //    doiTuongInfo.GioiTinh = this.cboGioiTinh.SelectedIndex;
        //    doiTuongInfo.NgaySinh = mstNgaySinh.Value;
        //    doiTuongInfo.IdOrderType = cboOrderType.SelectedValue == null
        //                                   ? 0
        //                                   : int.Parse(cboOrderType.SelectedValue.ToString());
        //    return doiTuongInfo;
        //}
        
        //private object[] KhachHang_MangThongTin()
        //{
        //    object[] arrMang ={ 0,0,
        //                       this.cboCha.SelectedItem == null ? this.cboCha.SelectedItem : (this.cboCha.SelectedItem as ListItem).ItemData,
        //                       this.txtMa.Text.Trim(),
        //                       this.txtTen.Text.Trim(),
        //                       this.txtNguoiLienLac.Text.Trim(),
        //                       this.txtDienThoai.Text.Trim(),
        //                       this.txtFax.Text.Trim(),
        //                       this.txtEmail.Text.Trim(),
        //                       this.txtMaSoThue.Text.Trim(),
        //                       this.cboType.SelectedIndex,                               
        //                       this.chkSuDung.Checked ? 1 : 0,
        //                       this.txtGhiChu.Text.Trim(),
        //                       this.cboGioiTinh.SelectedIndex,
        //                       mstNgaySinh.Value,
        //                       this.cboOrderType.SelectedValue,//.cboOrderType.se.SelectedItem == null ? this.cboOrderType.SelectedItem : (this.cboOrderType.SelectedItem as ListItem).ItemData,
        //    };
        //    return arrMang;
        //}

        //private void KhachHang_ThemMoi()
        //{
        //    this.KhachHang_KhoiTaoGiaTri();
        //    this.KhachHang_IsThemMoi = true;
        //    this.txtMa.Focus();
        //    btnThemMoi.Enabled = false;
        //}

        //private void KhachHang_KhoiTaoGiaTri()
        //{
        //    this.KhachHang_IsThemMoi = false;
        //    this.txtMa.Text = "";
        //    this.txtTen.Text = "";
        //    this.txtNguoiLienLac.Text = "";
        //    this.txtDienThoai.Text = "";
        //    this.txtFax.Text = "";
        //    this.txtEmail.Text = "";
        //    this.txtMaSoThue.Text = String.Empty;
        //    this.cboType.SelectedValue = "Khách hàng";
        //    this.cboCha.SelectedIndex = -1;
        //    this.chkSuDung.Checked = true;
        //    this.txtGhiChu.Text = "";
        //    this.IdDoiTuong = 0;
        //    this.mstNgaySinh.Value = DateTime.Now;
        //    this.cboGioiTinh.SelectedIndex = 0;
        //    this.cboOrderType.SelectedIndex = 0;
        //    this.txtOrderType.Text = "";
        //    while(!dgvDiaChi.Rows[0].IsNewRow){
        //        dgvDiaChi.Rows.RemoveAt(0);
        //    }
        //}

        //private bool KhachHang_LayDuLieu()
        //{
        //    //string sql = "SELECT 0 as SoTT, IdDoiTuong, IdCha, MaDoiTuong, TenDoiTuong, NguoiLienLac, DienThoai,"
        //    //            + " Fax, Email, MaSoThue, Type, SuDung, GhiChu, GioiTinh, NgaySinh, IdOrderType"
        //    //            + " FROM tbl_DM_DoiTuong";
        //    //this.listDoiTuong = (DataTable)DBTools.getData("tbl_DM_DoiTuong", sql).Tables["tbl_DM_DoiTuong"];
        //    this.listDoiTuong = DoiTuongDataProvider.GetListDoiTuongInfo();
        //    if (this.listDoiTuong == null)
        //        return false;
        //    //this.KhachHang_ThemTruongSoTT();

        //    clMaVung.DataSource = MaVungDataProvider.ListMaVung();
        //    clMaVung.DisplayMember = "TenVung";
        //    clMaVung.ValueMember = "MaVung";

        //    return true;
        //}

        //private void LuoiHienThi_GanNguon()
        //{
        //    if (this.listDoiTuong != null)
        //    {
        //        this.dgvKhachHang.DataSource = this.listDoiTuong;
        //        this.dgvKhachHang.Refresh();
        //    }

        //}

        //private void ListCha_GanNguon()
        //{
        //    string sql = "Select IdDoiTuong, TenDoiTuong from tbl_DM_DoiTuong where SuDung=1";
        //    DBTools.List_LoadData(cboCha, sql, "IdDoiTuong", "TenDoiTuong", " ", 0);

        //}

        //private void ListOrderType_GanNguon()
        //{
        //    string sql = "Select IdOrderType, Code, Name from tbl_DM_OrderType where SuDung=1";
        //    //DBTools.List_LoadData(cboOrderType, sql, "IdOrderType", "Name", " ", 0);
        //    this.dtOrderType = DBTools.getData("tmp", sql).Tables["tmp"];
        //    if (this.dtOrderType != null)
        //    {
        //        DataRow r = this.dtOrderType.NewRow();
        //        r[0] = 0;
        //        r[1] = "";
        //        this.dtOrderType.Rows.InsertAt(r, 0);
        //        this.cboOrderType.DataSource = this.dtOrderType;
        //        this.cboOrderType.DisplayMember = "Name";
        //        this.cboOrderType.ValueMember = "IdOrderType";
        //        this.cboOrderType.SelectedIndex = -1;

        //        // AutoCompleteStringCollection 
        //        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
        //        for (int i = 1; i < this.dtOrderType.Rows.Count; i++)
        //        {
        //            data.Add(this.dtOrderType.Rows[i]["Code"].ToString());
        //        }

        //        txtOrderType.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //        txtOrderType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //        txtOrderType.AutoCompleteCustomSource = data;
        //    }
        //}

        //private void KhachHang_ThemTruongSoTT()
        //{
        //    //this.listDoiTuong.Columns.Add("SoTT", System.Type.GetType("System.Int16"));
        //    this.KhachHang_CapNhatSoTT(0);

        //}

        //private void KhachHang_CapNhatSoTT(int VitriRong)
        //{
        //    //for (int i = VitriRong; i <= this.listDoiTuong.DefaultView.Count - 1; i++)
        //    //{
        //    //    this.listDoiTuong.DefaultView[i]["SoTT"] = i + 1;
        //    //}
        //}

        //private void KhachHang_HienThi(int IndexRow)
        //{
        //    DoiTuongInfo doiTuongInfo = this.listDoiTuong[IndexRow];
        //    if (IndexRow >= 0) {
        //        this.IdDoiTuong = doiTuongInfo.IdDoiTuong;
        //        this.cboCha.SelectedItem = null;
        //        foreach (ListItem item in this.cboCha.Items)
        //        {
        //            if (item.ItemData == doiTuongInfo.IdCha)
        //            {
        //                this.cboCha.SelectedIndex = this.cboCha.Items.IndexOf(item);
        //                break;
        //            }
        //        }
        //        this.cboOrderType.SelectedValue = doiTuongInfo.IdOrderType;
        //        this.txtMa.Text = doiTuongInfo.MaDoiTuong;
        //        this.strMaKhachHang = this.txtMa.Text.Trim();
        //        this.txtTen.Text = doiTuongInfo.TenDoiTuong;
        //        this.txtNguoiLienLac.Text = doiTuongInfo.NguoiLienLac;
        //        this.txtDienThoai.Text = doiTuongInfo.DienThoai;
        //        this.txtFax.Text = doiTuongInfo.Fax;
        //        this.txtEmail.Text = doiTuongInfo.Email;
        //        this.txtMaSoThue.Text = doiTuongInfo.MaSoThue;
        //        this.cboType.SelectedIndex = doiTuongInfo.Type;
        //        this.chkSuDung.Checked = Equals(doiTuongInfo.SuDung, 1);
        //        this.txtGhiChu.Text = doiTuongInfo.GhiChu;
        //        this.mstNgaySinh.Value =  doiTuongInfo.NgaySinh == DateTime.MinValue ? DateTime.Now : doiTuongInfo.NgaySinh;

        //        this.cboGioiTinh.SelectedIndex = doiTuongInfo.GioiTinh;

        //        string sql = "Select IdDiaChi,IdDoiTuong,SiteNumber,DiaChi,MaVung from tbl_DM_DoiTuong_DiaChi where IdDoiTuong=" + this.IdDoiTuong;
        //        dgvDiaChi.DataSource = DBTools.getData("Temp", sql).Tables["Temp"];
        //        //dgvDiaChi.Columns["IdDiaChi"].Visible = false;
        //        //dgvDiaChi.Columns["IdDoiTuong"].Visible = false;
        //        dgvDiaChi.Refresh();
        //    }
        //    else {
        //        this.KhachHang_KhoiTaoGiaTri();
        //        this.strMaKhachHang = "";
        //    }
        //}

        //private bool KhachHang_SuHopLeCuaThongTin()
        //{
        //    string strSql;
        //    if (this.txtMa.Text.Trim().Length == 0) {
        //        MessageBox.Show("Mã khách hàng chưa nhập." + "\n" + "-Hãy nhập mã khách hàng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.txtMa.Focus();
        //        return false;
        //    }
        //    if (this.txtMa.Text.Trim().Length > 0) {
        //        strSql = "Select * from tbl_DM_DoiTuong where MaDoiTuong =N'" + this.txtMa.Text.Trim() + "'";
        //        bool blnIsCheck = DBTools.ExistData(strSql);

        //        if (this.KhachHang_IsThemMoi) {
        //            if (blnIsCheck) {
        //                MessageBox.Show("Mã khách hàng này đã có." + "\n" + "-Hãy nhập lại mã khách hàng", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                this.txtMa.Focus();
        //                return false;
        //            }
        //        }
        //        else {
        //            if (string.Compare(this.txtMa.Text.Trim().ToUpper(), this.strMaKhachHang.ToUpper()) != 0) {
        //                if (blnIsCheck) {
        //                    MessageBox.Show("Mã khách hàng này đã có." + "\n" + "-Hãy nhập lại mã khách hàng", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    this.txtMa.Focus();
        //                    return false;
        //                }
        //            }
        //        }
        //    }


        //    if (this.txtTen.Text.Trim().Length == 0) {
        //        MessageBox.Show("Tên khách hàng chưa nhập." + "\n" + "-Hãy nhập tên khách hàng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.txtTen.Focus();
        //        return false;
        //    }
        //    if(this.txtEmail.Text.Trim().Length>0)
        //        if (Common.ValidEmail(this.txtEmail.Text.Trim()) == false)
        //        {
        //            MessageBox.Show("Email không đúng định dạng"+"\n"+"-Hãy nhập lại email", Declare.titleWarning, MessageBoxButtons.OK,MessageBoxIcon.Warning);
        //            this.txtEmail.Focus();
        //            return false; 
        //        }
        //    if (!this.KhachHang_IsThemMoi) {
        //        DBTools._IsCheck IsCheck;
        //        IsCheck = DBTools.CheckExistsRecord(this.KhachHang_IsCheckDeleteCommand(int.Parse(this.dgvKhachHang.CurrentRow.Cells["IdDoiTuong"].Value.ToString())));
        //        if (IsCheck == DBTools._IsCheck._TRUE) {
        //            if (!this.chkSuDung.Checked) {
        //                MessageBox.Show("Thông tin của khách hàng này đã được sử dụng nên trạng thái sử dụng luôn được chọn" + "\n" + "-Hãy chọn lại trạng thái sử dụng", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                this.chkSuDung.Focus();
        //                return false;
        //            }
        //        }
        //        else if (IsCheck == DBTools._IsCheck._EXCEPTION) {
        //            MessageBox.Show("Lỗi ngoại lệ: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }

        //        if (Object.Equals(this.dgvKhachHang.CurrentRow.Cells["IdDoiTuong"].Value, cboCha.SelectedValue)) {
        //            MessageBox.Show("Cha không thể là chính nó", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            this.cboCha.Focus();
        //            return false;
        //        }
        //    }
        //    if (dgvDiaChi.Rows[0].IsNewRow){
        //        MessageBox.Show("Phải có ít nhất một địa chỉ SiteNumber", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }else {
        //        for (int i = 0; i < dgvDiaChi.Rows.Count - 1; i++ ) {
        //            if (!dgvDiaChi.Rows[i].IsNewRow) {
        //                if (dgvDiaChi.Rows[i].Cells["clSiteNumber"].Value == DBNull.Value) {
        //                    MessageBox.Show("Bạn vẫn chưa nhập SiteNumber", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    return false;
        //                }
        //                for (int j = i + 1; j < dgvDiaChi.Rows.Count - 1; j++) {
        //                    if (!dgvDiaChi.Rows[j].IsNewRow) {
        //                        if (Object.Equals(dgvDiaChi.Rows[j].Cells["clSiteNumber"].Value, dgvDiaChi.Rows[i].Cells["clSiteNumber"].Value)) {
        //                            MessageBox.Show("Bạn đang nhập trùng SiteNumber", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                            return false;
        //                        }
        //                    }
        //                }
        //                strSql = String.Format("select * from tbl_DM_DoiTuong_DiaChi where SiteNumber=N'{0}' and IdDoiTuong<>{1}", dgvDiaChi.Rows[i].Cells["clSiteNumber"].Value, IdDoiTuong);
        //                if(DBTools.ExecuteScalar(strSql) != null){
        //                    MessageBox.Show(String.Format("Số SiteNumber {0} đã được dùng cho khách hàng khác", dgvDiaChi.Rows[i].Cells["clSiteNumber"].Value), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    return false;
        //                }
        //            }
        //        }
        //    }
        //    return true;
        //}

        //private int KhachHang_DefaultView_Find(int Id)
        //{
        //    if (this.listDoiTuong != null) {
        //        for (int i = 0; i <= this.listDoiTuong.Count - 1; i++) {
        //            if (Equals(this.listDoiTuong[i].IdDoiTuong, Id))
        //                return i;
        //        }
        //    }
        //    return -1;
        //}

        //private void KhachHang_SuaRong(int VitriRong, Object[] arrMangGiaTri)
        //{
        //    //this.listDoiTuong.DefaultView.AllowEdit = true;
        //    //this.listDoiTuong.DefaultView.BeginInit();
        //    //for (int i = 1; i <= this.listDoiTuong.Columns.Count - 1; i++)
        //    //{
        //    //    this.listDoiTuong.DefaultView[VitriRong][i] = arrMangGiaTri[i] == null ? System.DBNull.Value : arrMangGiaTri[i];
        //    //}
        //    //this.listDoiTuong.DefaultView.EndInit();
        //}

        //private GtidCommand KhachHang_InsertCommand(DoiTuongInfo MangThongTin)
        //{
        //    GtidCommand sqlcmd = new GtidCommand();
        //    sqlcmd.CommandText = "sp_DM_DoiTuong_Insert";
        //    sqlcmd.Parameters.AddWithValue("@IdDoiTuong", MangThongTin.IdDoiTuong).Direction = ParameterDirection.Output;
        //    sqlcmd.Parameters.AddWithValue("@IdCha", MangThongTin.IdCha);
        //    sqlcmd.Parameters.AddWithValue("@MaDoiTuong", MangThongTin.MaDoiTuong);
        //    sqlcmd.Parameters.AddWithValue("@TenDoiTuong", MangThongTin.TenDoiTuong);
        //    sqlcmd.Parameters.AddWithValue("@NguoiLienLac", MangThongTin.NguoiLienLac);
        //    sqlcmd.Parameters.AddWithValue("@DienThoai", MangThongTin.DienThoai);
        //    sqlcmd.Parameters.AddWithValue("@Fax", MangThongTin.Fax);
        //    sqlcmd.Parameters.AddWithValue("@Email", MangThongTin.Email);
        //    sqlcmd.Parameters.AddWithValue("@MaSoThue", MangThongTin.MaSoThue);
        //    sqlcmd.Parameters.AddWithValue("@Type", MangThongTin.Type);
        //    sqlcmd.Parameters.AddWithValue("@SuDung", MangThongTin.SuDung);
        //    sqlcmd.Parameters.AddWithValue("@GhiChu", MangThongTin.GhiChu);
        //    sqlcmd.Parameters.AddWithValue("@GioiTinh", MangThongTin.GioiTinh);
        //    sqlcmd.Parameters.AddWithValue("@NgaySinh", MangThongTin.NgaySinh);
        //    sqlcmd.Parameters.AddWithValue("@IdOrderType", MangThongTin.IdOrderType);
        //    sqlcmd.CommandType = CommandType.StoredProcedure;
        //    return sqlcmd;
        //}

        //private GtidCommand KhachHang_UpdateCommand(DoiTuongInfo MangThongTin)
        //{
        //    GtidCommand sqlcmd = new GtidCommand();
        //    sqlcmd.CommandText = "sp_DM_DoiTuong_Update";
        //    sqlcmd.Parameters.AddWithValue("@IdDoiTuong", MangThongTin.IdDoiTuong);
        //    sqlcmd.Parameters.AddWithValue("@IdCha", MangThongTin.IdCha);
        //    sqlcmd.Parameters.AddWithValue("@MaDoiTuong", MangThongTin.MaDoiTuong);
        //    sqlcmd.Parameters.AddWithValue("@TenDoiTuong", MangThongTin.TenDoiTuong);
        //    sqlcmd.Parameters.AddWithValue("@NguoiLienLac", MangThongTin.NguoiLienLac);
        //    sqlcmd.Parameters.AddWithValue("@DienThoai", MangThongTin.DienThoai);
        //    sqlcmd.Parameters.AddWithValue("@Fax", MangThongTin.Fax);
        //    sqlcmd.Parameters.AddWithValue("@Email", MangThongTin.Email);
        //    sqlcmd.Parameters.AddWithValue("@MaSoThue", MangThongTin.MaSoThue);
        //    sqlcmd.Parameters.AddWithValue("@Type", MangThongTin.Type);
        //    sqlcmd.Parameters.AddWithValue("@SuDung", MangThongTin.SuDung);
        //    sqlcmd.Parameters.AddWithValue("@GhiChu", MangThongTin.GhiChu);
        //    sqlcmd.Parameters.AddWithValue("@GioiTinh", MangThongTin.GioiTinh);
        //    sqlcmd.Parameters.AddWithValue("@NgaySinh", MangThongTin.NgaySinh);
        //    sqlcmd.Parameters.AddWithValue("@IdOrderType", MangThongTin.IdOrderType);
        //    sqlcmd.CommandType = CommandType.StoredProcedure;
        //    return sqlcmd;
        //}

        //private GtidCommand KhachHang_DeleteCommand(int IdKhachHang)
        //{
        //    GtidCommand sqlcmd = new GtidCommand();
        //    sqlcmd.CommandText = "sp_DM_DoiTuong_Delete";
        //    sqlcmd.Parameters.AddWithValue("@IdDoiTuong", IdKhachHang).Direction = ParameterDirection.Input;
        //    sqlcmd.CommandType = CommandType.StoredProcedure;
        //    return sqlcmd;
        //}

        //private GtidCommand KhachHang_IsCheckDeleteCommand(int IdKhachHang)
        //{
        //    GtidCommand sql = new GtidCommand("sp_DM_DoiTuong_CheckDelete");
        //    sql.Parameters.AddWithValue("@IdDoiTuong", IdKhachHang).Direction = ParameterDirection.Input;
        //    sql.Parameters.AddWithValue("@IsCheck", 0).Direction = ParameterDirection.Output;
        //    sql.CommandType = CommandType.StoredProcedure;
        //    return sql;
        //}
        #endregion
        #region LoadData
        private void LoadData()
        {
            listDoiTuong = DmDoiTuongProvider.GetListDmDoiTuongInfo();
            if (listDoiTuong.Count > 0)
            {
                dgvKhachHang.DataSource = listDoiTuong;
            }
            else
            {
                dgvKhachHang.DataSource = null;
            }
        }
        #endregion

        #region Search
        private bool Search(DMDoiTuongInfo dmKHInfor)
        {
            return (txtFilterMa.Text.Trim() == String.Empty || (txtFilterMa.Text.Trim() != String.Empty &&
                    dmKHInfor.MaDoiTuong.ToLower().Contains(txtFilterMa.Text.Trim().ToLower())))
                   && (txtFilterTen.Text.Trim() == String.Empty || (txtFilterTen.Text.Trim() != String.Empty &&
                       dmKHInfor.TenDoiTuong.ToLower().Contains(txtFilterTen.Text.Trim().ToLower())));

        }
        #endregion

        #region ReLoad
        public void ReLoad()
        {
            LoadData();
            dgvKhachHang.Refresh();
        }
        #endregion

        #region SetControl
        public void SetControl(bool var)
        {
            btnXoa.Enabled = var;
            btnCapNhat.Enabled = var;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //DoiTuong_DiaChiInfo dt = new DoiTuong_DiaChiInfo();
                //dt.IdDoiTuong = OidKhachHang;
                //DoiTuong_DiaChiDataProvider.Delete(new DoiTuong_DiaChiInfo{IdDoiTuong = OidKhachHang});

                //DmKhachHangInfo kh = new DmKhachHangInfo();
                //kh.IdDoiTuong = OidKhachHang;
                DmDoiTuongProvider.Delete(new DMDoiTuongInfo{IdDoiTuong = OidKhachHang});

                MessageBox.Show("Xóa thành công !");
                LoadData();
                SetControl(false);
            }
        }
        #endregion
#endregion

        #region "Các sự kiện"
        private void frmDM_KhachHang_Load(object sender, EventArgs e)
        {
            #region Old
            //            try
//            {
//                if (!this.KhachHang_LayDuLieu())
//                {
//                    MessageBox.Show("Lỗi lấy dữ liệu: " + DBTools._LastError, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    this.Dispose();
//                }

//                this.LuoiHienThi_GanNguon();
//                this.LuoiHienThi_AnCot();
//                this.ListCha_GanNguon();
//                this.ListOrderType_GanNguon();
//                this.KhachHang_CapNhatSoTT(0);

//                cm = (CurrencyManager)this.BindingContext[this.listDoiTuong];
//                cm.PositionChanged += new EventHandler(this.Position_Changed);
//                this.KhachHang_HienThi(this.cm.Position);
//            }
//            catch (Exception ex)
//            {
//#if DEBUG
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#else
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#endif
            //            }
            #endregion
            SetControl(false);
            dgvKhachHang.RowHeadersVisible = true;
            LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            #region Old
            //try
            //{
            //    this.KhachHang_ThemMoi();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            #endregion
            //isAdd = true;
            //frmChiTiet_KhachHang frm = new frmChiTiet_KhachHang(this);
            //frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            #region Old
            //            try
//            {
//                if (this.listDoiTuong.Count > 0)
//                {
//                    DBTools._IsCheck IsCheck;
//                    IsCheck = DBTools.CheckExistsRecord(this.KhachHang_IsCheckDeleteCommand(int.Parse(this.dgvKhachHang.CurrentRow.Cells["IdDoiTuong"].Value.ToString())));
//                    if (IsCheck == DBTools._IsCheck._TRUE)
//                    {
//                        MessageBox.Show(Declare.msgfrmDM_KhachHang_KhongXoa, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                        return;
//                    }
//                    else if (IsCheck == DBTools._IsCheck._EXCEPTION)
//                    {
//                        MessageBox.Show("Lỗi ngoại lệ: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        return;
//                    }

//                    if (MessageBox.Show("Bạn có muốn xóa danh mục khách hàng này không?", Declare.titleNotice, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
//                    {
//                        int IdKhachHang=int.Parse(this.dgvKhachHang.CurrentRow.Cells["IdDoiTuong"].Value.ToString());
//                        if (DBTools.DeleteRecord(this.KhachHang_DeleteCommand(IdKhachHang)))
//                        {
//                            int Index = this.cm.Position;
//                            this.listDoiTuong.RemoveAt(Index);
//                            if (Index < this.listDoiTuong.Count)
//                            {
//                                this.KhachHang_CapNhatSoTT(Index);
//                                this.KhachHang_HienThi(this.cm.Position);
//                            }
//                            else
//                            {

//                                if (Index > 0)
//                                    this.dgvKhachHang.CurrentRow.Selected = true;
//                            }

//                            Common.LogAction("Xóa danh mục khách hàng", "IdDoiTuong " + IdKhachHang, -1);

//                            MessageBox.Show("Xóa danh mục khách hàng thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        }    
//                        else
//                        {
//                            MessageBox.Show("Lỗi xóa danh mục khách hàng: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        }
//                    }
//                }
//                else
//                {
//                    MessageBox.Show("Không có danh mục khách hàng để xóa",Declare.titleWarning,MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
            //            btnThemMoi.Enabled = true;
            #endregion

            Delete();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            #region old
            //            GtidCommand sqlcmd = null;
//            DoiTuongInfo MangThongTin;
//            try
//            {
//                if (!this.KhachHang_SuHopLeCuaThongTin())
//                    return;
//                MangThongTin = this.GetInfor();
//                if (this.KhachHang_IsThemMoi) {
//                    sqlcmd = this.KhachHang_InsertCommand(MangThongTin);
//                    if (DBTools.InsertRecord(sqlcmd) == true) {

//                        MangThongTin.IdDoiTuong = (int)sqlcmd.Parameters[0].Value;
//                        this.IdDoiTuong = MangThongTin.IdDoiTuong;
//                        this.listDoiTuong.Add(MangThongTin);
//                        CapNhatDiaChi(sqlcmd);

//                        this.dgvKhachHang.Refresh();
//                        int Index = this.KhachHang_DefaultView_Find(MangThongTin.IdDoiTuong);
//                        cm.Position = Index;
//                        this.KhachHang_CapNhatSoTT(Index);

//                        ListCha_GanNguon();
//                        this.KhachHang_HienThi(this.cm.Position);
//                        this.KhachHang_IsThemMoi = false;


//                        Common.LogAction("Thêm mới danh mục khách hàng", "IdDoiTuong " + this.IdDoiTuong, -1);

//                        MessageBox.Show("Thêm mới khách hàng thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                    else {
//                        MessageBox.Show("Lỗi thêm mới khách hàng: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK);
//                    }
//                }
//                else {
//                    MangThongTin.IdDoiTuong = int.Parse(this.dgvKhachHang.CurrentRow.Cells["IdDoiTuong"].Value.ToString());
//                    sqlcmd = this.KhachHang_UpdateCommand(MangThongTin);
//                    if (DBTools.UpdateRecord(sqlcmd) == true) {
//                        this.IdDoiTuong = MangThongTin.IdDoiTuong;
//                        CapNhatDiaChi(sqlcmd);
//                        //this.KhachHang_SuaRong(this.dgvKhachHang.CurrentRow.Index, MangThongTin);
//                        this.cboCha.Refresh();
//                        this.dgvKhachHang.Refresh();
//                        int Index = this.KhachHang_DefaultView_Find(MangThongTin.IdDoiTuong);
//                        cm.Position = Index;
//                        this.KhachHang_CapNhatSoTT(Index);
//                        ListCha_GanNguon();
//                        this.KhachHang_HienThi(this.cm.Position);


//                        Common.LogAction("Cập nhật danh mục khách hàng", "IdDoiTuong " + MangThongTin.IdDoiTuong, -1);

//                        MessageBox.Show("Cập nhật khách hàng thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }
//                    else {
//                        MessageBox.Show("Lỗi cập nhật khách hàng: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK);
//                    }
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
//            btnThemMoi.Enabled = true;
//        }

//        private void CapNhatDiaChi(GtidCommand sqlcmd)
//        {
//            //sqlcmd.CommandText = "sp_DM_DoiTuong_DiaChi_Delete";
//            //sqlcmd.Parameters.Clear();
//            //sqlcmd.Parameters.AddWithValue("@IdDoiTuong", this.IdDoiTuong);
//            //if (!DBTools.DeleteRecord(sqlcmd)) throw DBTools._LastError;
//            sqlcmd.CommandText = "sp_DM_DoiTuong_DC_MV_Insert";
//            string lstSN="";
//            foreach (DataGridViewRow dgr in dgvDiaChi.Rows) {
//                if (!dgr.IsNewRow) {
//                    sqlcmd.Parameters.Clear();
//                    sqlcmd.Parameters.AddWithValue("@IdDoiTuong", this.IdDoiTuong);
//                    sqlcmd.Parameters.AddWithValue("@SiteNumber", dgr.Cells["clSiteNumber"].Value);
//                    sqlcmd.Parameters.AddWithValue("@MaVung", dgr.Cells["clMaVung"].Value);
//                    sqlcmd.Parameters.AddWithValue("@DiaChi", dgr.Cells["clDiaChi"].Value);
//                    if (!DBTools.InsertRecord(sqlcmd)) throw DBTools._LastError;
//                    lstSN += "'" + dgr.Cells["clSiteNumber"].Value + "',";
//                }
//            }
//            if (lstSN.Length>0)
//            {
//                lstSN = lstSN.Substring(0, lstSN.Length - 1);
//                sqlcmd.CommandText = String.Format("Delete From tbl_DM_Doituong_Diachi Where IdDoituong={0} and SiteNumber not in ({1})",
//                                    this.IdDoiTuong, lstSN);
//                sqlcmd.CommandType = CommandType.Text;
//                sqlcmd.ExecuteNonQuery();
            //            }
            #endregion
            //isAdd = false;
            //frmChiTiet_KhachHang frm = new frmChiTiet_KhachHang(this);
            //frm.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            #region Old
            //string dk = "1=1";
            //if (!String.IsNullOrEmpty(txtFilterMa.Text)) {
            //    dk += String.Format(" and MaDoiTuong like '{0}'", txtFilterMa.Text);
            //}
            //if (!String.IsNullOrEmpty(txtFilterTen.Text)) {
            //    dk += String.Format(" and TenDoiTuong like N'{0}'", txtFilterTen.Text);
            //}
            ////string sql = "SELECT 0 as SoTT,IdDoiTuong, IdCha, MaDoiTuong, TenDoiTuong, NguoiLienLac, DienThoai,"
            ////            + " Fax, Email, MaSoThue, Type, SuDung, GhiChu, GioiTinh, NgaySinh, IdOrderType"
            ////            + " FROM tbl_DM_DoiTuong WHERE " + dk;
            ////this.listDoiTuong = DBTools.getData("tbl_DM_DoiTuong", sql).Tables["tbl_DM_DoiTuong"];
            //this.listDoiTuong = DoiTuongDataProvider.GetListDoiTuongInfo();

            //this.LuoiHienThi_GanNguon();
            //this.LuoiHienThi_AnCot();
            //this.KhachHang_CapNhatSoTT(0);

            //cm = (CurrencyManager)this.BindingContext[this.listDoiTuong];
            //cm.PositionChanged += new EventHandler(this.Position_Changed);
            //this.KhachHang_HienThi(this.cm.Position);
            #endregion

            dgvKhachHang.DataSource = DmDoiTuongProvider.Search(new DMDoiTuongInfo{MaDoiTuong = txtFilterMa.Text.Trim(),TenDoiTuong = txtFilterTen.Text.Trim()});
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
       {
           //try
           //{
           //    Common.ValdateCharInTextBox_Keypress(ref  sender, ref e, Common.strValidate.STR_CHAR_A_Z_a_z_0_9);
           //    Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_TOUPPER);
           //}
           //catch (Exception ex)
           //{
           //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
           //}
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        { 
            //try
            //{
            //    Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_PHONE);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtSoTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //try
            //{
            //    Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_CHAR_A_Z_a_z_0_9);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dgvKhachHang_Resize(object sender, EventArgs e)
        {
            //try
            //{
            //    this.LuoiHienThi_Resize();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void frmDM_KhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (e.KeyCode == Keys.Enter)
            //        SendKeys.Send("{TAB}");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //try
            //{
            //    Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_NOT_SPACE);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dgvKhachHang_Sorted(object sender, EventArgs e)
        {
            //try
            //{
            //    this.KhachHang_CapNhatSoTT(0);
            //    if (this.dgvKhachHang.CurrentRow != null)
            //        this.KhachHang_HienThi(this.dgvKhachHang.CurrentRow.Index);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
#endregion      

        private void txtOrderType_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    txtOrderType_Leave(sender, e);
            //}
        }

        private void txtOrderType_Leave(object sender, EventArgs e)
        {
            //bool found = false;
            //for (int i = 0; i < dtOrderType.Rows.Count; i++)
            //{
            //    if (txtOrderType.Text.Equals(dtOrderType.Rows[i]["Code"].ToString()))
            //    {
            //        //cboOrderType.SelectedIndex = i;
            //        cboOrderType.SelectedValue = dtOrderType.Rows[i]["IdOrderType"];
            //        found = true;
            //        break;
            //    }
            //}
            //if (!found)
            //{
            //    txtOrderType.Text = "";
            //    cboOrderType.Text = "";
            //}
        }

        private void cboOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    txtOrderType.Text = dtOrderType.Rows[cboOrderType.SelectedIndex]["Code"].ToString();
            //}
            //catch { txtOrderType.Text = ""; }
        }

        private void dgvDiaChi_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dgvDiaChi_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //if (e.Context == DataGridViewDataErrorContexts.Formatting || e.Context == DataGridViewDataErrorContexts.PreferredSize ||
            //    e.Context == DataGridViewDataErrorContexts.Display)
            //    e.ThrowException = false;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && listDoiTuong.Count > 0)
            {
                SetControl(true);
                OidKhachHang = Convert.ToInt32(listDoiTuong[dgvKhachHang.CurrentCell.RowIndex].IdDoiTuong.ToString());
            }
        }

        private void dgvKhachHang_DoubleClick(object sender, EventArgs e)
        {
            //isAdd = false;
            //frmChiTiet_KhachHang frm = new frmChiTiet_KhachHang(this);
            //frm.ShowDialog();
        }

        private void dgvKhachHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow dataGridViewRow in dgvKhachHang.Rows)
            {
                dataGridViewRow.HeaderCell.Value = dataGridViewRow.Index.ToString();
            }
        }
    }
}