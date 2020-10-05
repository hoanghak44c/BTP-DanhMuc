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
using QLBH.Common;
using QLBH.Core.Data;
using System.Collections;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DanhMuc.Infors;

//Note:@CuongTT frmDM_MatHang
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_MatHang_Old : DevExpress.XtraEditors.XtraForm
    {
        #region "Khai báo biến"
        DataTable dtLoaiHangHoa;
        List<DMSanPhamInfo> liSanPham = new List<DMSanPhamInfo>();
        DMSanPhamInfo dm = new DMSanPhamInfo();


        public int IdMa = 0;

        public bool isAdd;
        public int OidMatHang;
        #endregion

        #region"Phương thức khởi tạo"
        public frmDM_MatHang_Old()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        #endregion

        #region"Các phương thức"
        #region old
        private void LuoiHienThi_CotAn()
        {

            dgvDanhSachMatHang.Columns["IdSanPham"].Visible = false;
            dgvDanhSachMatHang.Columns["IdCha"].Visible = false;
            dgvDanhSachMatHang.Columns["MaVach"].Visible = false;
            dgvDanhSachMatHang.Columns["IdDonViTinh"].Visible = false;
            dgvDanhSachMatHang.Columns["MoTa"].Visible = false;
        }

        //private void LuoiHienThi_Resize()
        //{
        //    this.dgvDanhSachMatHang.Columns["TenThuoc"].Width = this.dgvDanhSachMatHang.Width - this.SoTT.Width 
        //}

        private void DayDuLieuLenComboBox(ComboBox cbo, string DisplayMember, string ValueMember, DataTable dt)
        {
            cbo.DataSource = dt;
            cbo.DisplayMember = DisplayMember;
            cbo.ValueMember = ValueMember;
        }

        //private void DayDuLieuNenCheckListBox()
        //{
        //    this.chklstHoTriLieu.Items.Clear();
        //    for (int i = 0; i <= this.dtHoTriLieu.Rows.Count - 1; i++)
        //    {
        //        this.chklstHoTriLieu.Items.Add(dtHoTriLieu.Rows[i]["TenHoTriLieu"].ToString(), false);
        //    }
        //}

        //private void SetIsCheckListBoxItem()
        //{
        //    DataView dvHoTriLieu_Thuoc;
        //    dvHoTriLieu_Thuoc = this.dtHoTriLieu_Thuoc.DefaultView;
        //    dvHoTriLieu_Thuoc.RowFilter = "IdThuoc=" + this.dv[cm.Position]["IdThuoc"].ToString();
        //    if (dvHoTriLieu_Thuoc.Count == 0)
        //    {
        //        for (int i = 0; i <= this.chklstHoTriLieu.Items.Count - 1; i++)
        //        {
        //            this.chklstHoTriLieu.SetItemChecked(i, false);
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 0; i <= dvHoTriLieu_Thuoc.Count - 1; i++)
        //        {
        //            for (int j = 0; j <= this.dtHoTriLieu.Rows.Count - 1; j++)
        //            {
        //                if ((int)dvHoTriLieu_Thuoc[i]["IdHoTriLieu"] == (int)this.dtHoTriLieu.Rows[j]["IdHoTriLieu"])
        //                    this.chklstHoTriLieu.SetItemChecked(j, true);
        //                else
        //                {
        //                    if (i > 0)
        //                    {
        //                        if (this.chklstHoTriLieu.GetItemChecked(j) == true)
        //                            continue;
        //                    }
        //                    this.chklstHoTriLieu.SetItemChecked(j, false);
        //                }

        //            }
        //        }
        //    }
        //    dvHoTriLieu_Thuoc.RowFilter = null;       
        //}

        //private int[] Get_IdHoChiLieu_IsChecked()
        //{
        //    int[] arr = null;
        //    for (int i = 0; i <= this.chklstHoTriLieu.Items.Count - 1; i++)
        //    {
        //        if (this.chklstHoTriLieu.GetItemChecked(i) == true)
        //        {
        //            Array.Resize(ref arr, arr == null ? 1 : arr.Length + 1);
        //            arr[arr.Length - 1] = (int)this.dtHoTriLieu.Rows[i]["IdHoTriLieu"];
        //        }
        //    }
        //    return arr;  
        //}

        //private void UndoIsCheckListBoxItem()
        //{
        //    for (int i = 0; i <= this.chklstHoTriLieu.Items.Count - 1; i++)
        //        if (this.chklstHoTriLieu.GetItemChecked(i) == true)
        //            this.chklstHoTriLieu.SetItemChecked(i, false);
        //        else
        //            continue;
        //}

//        private int GetIndexRow(DataTable dt, string strTenTruong, int GiaTri)
//        {
//            for (int i = 0; i <= dt.Rows.Count - 1; i++)
//            {
//                if (int.Parse(dt.Rows[i][strTenTruong].ToString()) == GiaTri)
//                    return i;
//            }
//            return -1;
//        }

//        private void HienThiThongTin(int IndexRow)
//        {
//            if (IndexRow >= 0)
//            {
//                this.MatHang_IsThemMoi = false;
//                this.txtMaSanPham.Text = this.dv[IndexRow]["MaSanPham"].ToString();
//                this.txtTenSanPham.Text = this.dv[IndexRow]["TenSanPham"].ToString();
//                this.txtMaVach.Text = this.dv[IndexRow]["MaVach"].ToString();
//                this.cboLoaiMatHang.SelectedValue = this.dv[IndexRow]["IdCha"];
//                this.cboDonViTinh.SelectedValue = this.dv[IndexRow]["IdDonViTinh"];
//                this.txtGiaNhap.Text = this.dv[IndexRow]["GiaNhap"] == System.DBNull.Value ? String.Empty : Common.Double2Str(Convert.ToDouble(this.dv[IndexRow]["GiaNhap"]));
//                this.txtMoTa.Text = this.dv[IndexRow]["MoTa"].ToString();
//                this.chkSuDung.Checked = this.dv[IndexRow]["SuDung"] == System.DBNull.Value ? false : Equals(this.dv[IndexRow]["SuDung"],(decimal)1);
//                this.chkTrungMaVach.Checked = this.dv[IndexRow]["TrungMaVach"] == DBNull.Value ? false : Equals(this.dv[IndexRow]["TrungMaVach"],(decimal)1);
//                this.chkChietKhau.Checked = this.dv[IndexRow]["ChietKhau"] == DBNull.Value ? false : Equals(this.dv[IndexRow]["ChietKhau"],(decimal)1);
//                this.IdMa = this.dv[IndexRow]["IdSanPham"] == DBNull.Value ? 0 : Common.IntValue(this.dv[IndexRow]["IdSanPham"]);
//                this.txtTenTat.Text = this.dv[IndexRow]["TenVietTat"].ToString();
//            }
//            else
//            {
//                this.KhoiTaoGiaTri();
//            }
//        }

//        private object[] MangThongTinHangHoa()
//        {
//            object[] arrMang ={ 0,
//                                this.cboLoaiMatHang.SelectedValue == null ? System.DBNull.Value : this.cboLoaiMatHang.SelectedValue,
//                                this.txtMaVach.Text.Trim(),
//                                this.txtMaSanPham.Text.Trim(), 
//                                this.txtTenSanPham.Text.Trim(),
//                                this.cboDonViTinh.SelectedValue,
//                                Common.DoubleValue(this.txtGiaNhap.Text.Trim()),
//                                this.txtMoTa.Text.Trim(),
//                                this.chkSuDung.Checked ? 1 : 0,
//                                this.chkTrungMaVach.Checked ? 1 : 0,
//                                this.txtTenTat.Text,
//                                this.chkChietKhau.Checked ? 1 : 0};
//            return arrMang;
//        }

//        private void ThemMoi()
//        {
//            this.KhoiTaoGiaTri();
//            this.txtMaSanPham.Focus();
//            btnThemMoi.Enabled = false;
//        }

//        private void ThemMoiMotRongThongTin(Object[] arrMangThongTin)
//        {
//            DataRowView rw = this.dv.AddNew();
//            for (byte i = 0; i <= (byte)arrMangThongTin.Length - 1; i++)
//            {
//                rw[i] = arrMangThongTin[i];
//            }

//            rw.EndEdit();
//        }

//        private void KhoiTaoGiaTri()
//        {
//            this.MatHang_IsThemMoi = true;
//            this.txtMaSanPham.Text = "";
//            this.txtTenSanPham.Text = "";
//            if (this.cboLoaiMatHang.Items.Count > 0)
//                this.cboLoaiMatHang.SelectedValue = 0;
//            else
//                this.cboLoaiMatHang.SelectedValue = -1;
//            if (this.cboDonViTinh.Items.Count > 0)
//                this.cboDonViTinh.SelectedValue = 0;
//            else
//                this.cboDonViTinh.SelectedValue = -1;
//            this.txtMaVach.Text = "";
//            this.txtGiaNhap.Text = String.Empty;
//            this.txtMoTa.Text = "";
//            this.chkSuDung.Checked = true;
//            this.chkTrungMaVach.Checked = false;
//            this.chkChietKhau.Checked = false;
//            this.IdMa = 0;
//            this.txtTenTat.Text = "";
//        }

//        private bool Load_DuLieu()
//        {
//            DataSet ds;
//            string[] arr ={ "tbl_SanPham", "tbl_DM_DonViTinh", "tbl_DM_TienTe" };
//            ds = DBTools.GetData(this.MangLoadCommand(), arr);
//            if (ds == null)
//                return false;

//            this.dtHangHoa = (DataTable)ds.Tables["tbl_SanPham"];
//            this.ThemTruongSoTT();

//            this.dv = this.dtHangHoa.DefaultView;
//            this.CapNhatDuLieuCotSoTT(0);
//            this.dgvDanhSachMatHang.DataSource = dv;

//            this.dtLoaiHangHoa = (DataTable)ds.Tables["tbl_SanPham"];
//            this.DayDuLieuLenComboBox(this.cboLoaiMatHang, "TenSanPham", "IdSanPham", this.dtLoaiHangHoa);

//            this.dtDonViTinh = (DataTable)ds.Tables["tbl_DM_DonViTinh"];
//            this.DayDuLieuLenComboBox(this.cboDonViTinh, "TenDonViTinh", "IdDonViTinh", this.dtDonViTinh);

//            return true;
//        }

//        private void ThemTruongSoTT()
//        {
//            this.dtHangHoa.Columns.Add("SoTT", System.Type.GetType("System.Int16"));
//        }

//        private void CapNhatDuLieuCotSoTT(int VitriRong)
//        {
//            if (this.dv == null) return;
//            if (this.dv.Count == 0) return;
//            for (int i = VitriRong; i <= this.dv.Count - 1; i++)
//            {
//                this.dv[i]["SoTT"] = i + 1;
//            }
//        }

//        private void ThemCacMucVao_CboLoc()
//        {
//            //this.cboLoc.Items.Add("Tên mặt hàng");
//            //this.cboLoc.Items.Add("Loại mặt hàng");
//            //this.cboLoc.Items.Add("Đặc điểm, tính chất");
//        }

//        private void EnalbleControlFilter(bool Ischeck)
//        {
//            //this.cboLoc.Enabled = Ischeck;
//            //this.cboLoc.SelectedIndex = -1;
//            //this.txtLoc.Enabled = Ischeck;
//            //this.txtLoc.Text = "";
//        }

//        private bool SuHopLeCuaThongTinCapNhat()
//        {
//            if (String.IsNullOrEmpty(this.txtMaSanPham.Text)) {
//                MessageBox.Show("Mã mặt hàng chưa nhập." + "\n" + "-Hãy nhập mã mặt hàng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                this.txtMaSanPham.Focus();
//                return false;
//            }
//            else {
//                string sql = "select * from tbl_SanPham where MaSanPham=N'" + txtMaSanPham.Text + "'";
//                sql += " and IdSanPham <> " + IdMa;
//                if (DBTools.ExecuteScalar(sql) != null) {
//                    MessageBox.Show("Mã mặt hàng đã được sử dụng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    this.txtMaSanPham.Focus();
//                    return false;                    
//                }
//            }

//            if (String.IsNullOrEmpty(this.txtTenSanPham.Text)) {
//                MessageBox.Show("Tên mặt hàng chưa nhập." + "\n" + "-Hãy nhập tên mặt hàng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                this.txtTenSanPham.Focus();
//                return false;
//            }
//            else {
//                string sql = "select * from tbl_SanPham where TenSanPham=N'" + txtTenSanPham.Text + "'";
//                sql += " and IdSanPham <> " + IdMa;
//                if (DBTools.ExecuteScalar(sql) != null) {
//                    MessageBox.Show("Tên mặt hàng đã được sử dụng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    this.txtTenSanPham.Focus();
//                    return false;
//                }
//            }

//            //if (this.cboLoaiMatHang.SelectedIndex == -1)
//            //{
//            //    MessageBox.Show("Chưa chọn thông tin loại mặt hàng." + "\n" + "-Hãy chọn thông tin loại mặt hàng", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//            //    this.cboLoaiMatHang.Focus();
//            //    return false;
//            //}

//            if (this.cboDonViTinh.SelectedIndex == -1) {
//                MessageBox.Show("Chưa chọn thông tin đơn vị tính." + "\n" + "-Hãy chọn thông tin đơn vị tính", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                this.cboDonViTinh.Focus();
//                return false;
//            }

//            return true;
//        }

//        private bool IsDouble(String strNumber)
//        {
//            try
//            {
//                double dbNumber;
//                dbNumber = double.Parse(strNumber.Trim(), new System.Globalization.CultureInfo("en-US"));
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }

//        private void SuaRongDuLieu(int VitriRong, Object[] arrMangGiaTri)
//        {
//            this.dv.AllowEdit = true;
//            this.dv.BeginInit();
//            for (int i = 0; i <= arrMangGiaTri.Length - 1; i++)
//            {
//                this.dv[VitriRong][i] = arrMangGiaTri[i];
//            }
//            this.dv.EndInit();
//        }


//        private GtidCommand LoadCommand(string spName)
//        {
//            GtidCommand sqlcmd = new GtidCommand();
//            sqlcmd.CommandText = spName;
//            sqlcmd.CommandType = CommandType.StoredProcedure;
//            return sqlcmd;
//        }

//        private GtidCommand[] MangLoadCommand()
//        {
//            GtidCommand[] arrSqlCommand = new GtidCommand[3];
//            arrSqlCommand[0] = this.LoadCommand("sp_DM_HangHoa_Load");
//            arrSqlCommand[1] = this.LoadCommand("sp_DM_DonViTinh_Load");
//            arrSqlCommand[2] = this.LoadCommand("sp_DM_DonViTienTe_Load");
//            return arrSqlCommand;
//        }

//        private GtidCommand GetInsertCommand_HangHoa()
//        {
//            object[] arrMangThongTin = this.MangThongTinHangHoa();

//            GtidCommand sqlcmd = new GtidCommand();
//            sqlcmd.CommandText = "sp_DM_HangHoa_Insert_CK";
//            sqlcmd.Parameters.AddWithValue("@IdSanPham", arrMangThongTin[0]).Direction = ParameterDirection.Output;
//            sqlcmd.Parameters.AddWithValue("@IdCha", arrMangThongTin[1]);
//            sqlcmd.Parameters.AddWithValue("@MaVach", arrMangThongTin[2]);
//            sqlcmd.Parameters.AddWithValue("@MaSanPham", arrMangThongTin[3]);
//            sqlcmd.Parameters.AddWithValue("@TenSanPham", arrMangThongTin[4]);
//            sqlcmd.Parameters.AddWithValue("@IdDonViTinh", arrMangThongTin[5]);
//            sqlcmd.Parameters.AddWithValue("@MoTa", arrMangThongTin[7]);
//            sqlcmd.Parameters.AddWithValue("@Sudung", arrMangThongTin[8]);
//            sqlcmd.Parameters.AddWithValue("@TrungMaVach", arrMangThongTin[9]);
//            sqlcmd.Parameters.AddWithValue("@TenVietTat", arrMangThongTin[10]);
//            sqlcmd.Parameters.AddWithValue("@ChietKhau", arrMangThongTin[11]);
//            sqlcmd.CommandType = CommandType.StoredProcedure;
//            return sqlcmd;
//        }

//        private GtidCommand GetUpdateCommand_HangHoa(object[] arrMangThongTin)
//        {
//            GtidCommand sqlcmd = new GtidCommand();
//            sqlcmd.CommandText = "sp_DM_HangHoa_Update_CK";
//            sqlcmd.Parameters.AddWithValue("@IdSanPham", arrMangThongTin[0]);
//            sqlcmd.Parameters.AddWithValue("@IdCha", arrMangThongTin[1]);
//            sqlcmd.Parameters.AddWithValue("@MaVach", arrMangThongTin[2]);
//            sqlcmd.Parameters.AddWithValue("@MaSanPham", arrMangThongTin[3]);
//            sqlcmd.Parameters.AddWithValue("@TenSanPham", arrMangThongTin[4]);
//            sqlcmd.Parameters.AddWithValue("@IdDonViTinh", arrMangThongTin[5]);
//            sqlcmd.Parameters.AddWithValue("@MoTa", arrMangThongTin[7]);
//            sqlcmd.Parameters.AddWithValue("@Sudung", arrMangThongTin[8]);
//            sqlcmd.Parameters.AddWithValue("@TrungMaVach", arrMangThongTin[9]);
//            sqlcmd.Parameters.AddWithValue("@TenVietTat", arrMangThongTin[10]);
//            sqlcmd.Parameters.AddWithValue("@ChietKhau", arrMangThongTin[11]);
//            sqlcmd.CommandType = CommandType.StoredProcedure;
//            return sqlcmd;
//        }


//        private GtidCommand GetDeleteComand_DM_HangHoa(int IdMatHang)
//        {
//            GtidCommand sqlcmd = new GtidCommand("sp_DM_HangHoa_Delete");
//            sqlcmd.Parameters.AddWithValue("@IdSanPham", IdMatHang);
//            sqlcmd.CommandType = CommandType.StoredProcedure;
//            return sqlcmd;
//        }

//        private GtidCommand GetHangHoa_CheckExists_IsForegin(int IdMatHang)
//        {
//            GtidCommand sqlcmd = new GtidCommand("sp_DM_HangHoa_ChkRef");
//            sqlcmd.Parameters.AddWithValue("@IdSanPham", IdMatHang);
//            sqlcmd.Parameters.AddWithValue("@IsCheck", 0).Direction = ParameterDirection.Output;
//            sqlcmd.CommandType = CommandType.StoredProcedure;
//            return sqlcmd;
//        }

//        private GtidCommand HangHoa_MaHangTuDong_Command(string TenMatHang)
//        {
//            GtidCommand sqlcmd = new GtidCommand("sp_DM_HangHoa_MaHangTuDong");
//            sqlcmd.Parameters.AddWithValue("@TenMatHang", TenMatHang);
//            sqlcmd.CommandType = CommandType.StoredProcedure;
//            return sqlcmd;
//        }

//        private void ThemMoiDuLieu()
//        {
//            GtidCommand sqlCmd = null;
//            Object[] arrMangThongTin;
//            DataTable dtMatHangThemMoi = dtHangHoa.Clone();
//            try
//            {

//                arrMangThongTin = this.MangThongTinHangHoa();
//                sqlCmd = this.GetInsertCommand_HangHoa();
//                if (DBTools.InsertRecord(sqlCmd) == true)
//                {
//                    arrMangThongTin[0] = sqlCmd.Parameters[0].Value;
//                    this.IdMa = int.Parse(arrMangThongTin[0].ToString());
//                    Common.LogAction("Thêm mới danh mục sản phẩm", "IdSanPham " + this.IdMa, -1);

//                    dtMatHangThemMoi.Rows.Add(arrMangThongTin);
//                    //arrMangThongTin[0] = dtMatHangThemMoi.Rows[0]["IdSanPham"];
//                    this.ThemMoiMotRongThongTin(arrMangThongTin);

//                    this.CapNhatDuLieuCotSoTT(0);
//                    cm.Position = this.dv.Count - 1;
//                }
//                else
//                {
//                    MessageBox.Show("Lỗi ngoại lệ: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK);
//                }
//                MessageBox.Show("Thêm mới danh mục sản phẩm thành công. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//            catch (Exception ex)
//            {
//#if DEBUG
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#else
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#endif
//            }
//            finally
//            {

//                dtMatHangThemMoi.Dispose();
//                this.MatHang_IsThemMoi = false;
//            }
//        }

//        private void CapNhatDuLieu()
//        {
//            DataTable dtMatHangCapNhat = dtHangHoa.Clone();
//            Object[] arrMangThongTin;
//            try
//            {
//                arrMangThongTin = this.MangThongTinHangHoa();
//                arrMangThongTin[0] = this.dv[this.cm.Position]["IdSanPham"];

//                if (DBTools.UpdateRecord(this.GetUpdateCommand_HangHoa(arrMangThongTin)) == true)
//                {
//                    this.SuaRongDuLieu(this.cm.Position, arrMangThongTin);

//                    this.HienThiThongTin(this.cm.Position);

//                    Common.LogAction("Cập nhật danh mục sản phẩm", "IdSanPham " + arrMangThongTin[0], -1);

//                }
//                else
//                {
//                    MessageBox.Show("Lỗi ngoại lệ: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK);
//                }
//                MessageBox.Show("Sửa danh mục mặt hàng thành công. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//            catch (Exception ex)
//            {
//#if DEBUG
//                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK);
//#else
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK);
//#endif
//            }
//            finally
//            {
//                dtMatHangCapNhat.Dispose();
//            }
//        }

        private string GetString_Mang_IdLoaiMatHang(string strTenLoaiMatHang)
        {
            string str = "";
            DataView dv = this.dtLoaiHangHoa.DefaultView;
            dv.RowFilter = "TenLoaiMatHang like '%" + strTenLoaiMatHang + "%'";
            for (int i = 0; i <= dv.Count - 1; i++)
            {
                if (i == 0)
                    str = dv[i][0].ToString();
                else
                    str = str + "," + dv[i][0].ToString();
            }
            if (str.Trim().Length == 0)
                str = "-1";
            dv.RowFilter = null;
            return str;
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            dgvDanhSachMatHang.AutoGenerateColumns = false;
            liSanPham = DmSanPhamProvider.GetListDmSanPhamInfo();
            //dgvDanhSachMatHang.DataSource = null;
            dgvDanhSachMatHang.DataSource = liSanPham;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //dm.IdSanPham = OidMatHang;
                DmSanPhamProvider.Delete(new DMSanPhamInfo { IdSanPham = OidMatHang });
                MessageBox.Show("Xóa thành công bản ghi");
            }
            LoadData();
            SetControl(false);
        }
        #endregion

        #region ReLoad
        public void ReLoad()
        {
            LoadData();
            dgvDanhSachMatHang.Refresh();
        }
        #endregion

        #region SetControl
        public void SetControl(bool var)
        {
            btnXoa.Enabled = var;
            btnCapNhat.Enabled = var;
        }
        #endregion

        private bool Search(DMSanPhamInfo dmQuyenHoaDonInfo)
        {
            return ((txtFilterMa.Text.Trim() == String.Empty || (txtFilterMa.Text.Trim() != String.Empty &&
                    dmQuyenHoaDonInfo.MaSanPham.ToLower().Contains(txtFilterMa.Text.Trim().ToLower())))
                   && (txtFilterTen.Text.Trim() == String.Empty || (txtFilterTen.Text.Trim() != String.Empty &&
                       dmQuyenHoaDonInfo.TenSanPham.ToLower().Contains(txtFilterTen.Text.Trim().ToLower()))));

        }

        #endregion

        #region "Các sự kiện"
        private void frmDM_MatHang_Load(object sender, EventArgs e)
        {
            LoadData();
            SetControl(false);

            #region old

            //            try
//            {
//                if (!this.Load_DuLieu())
//                {
//                    MessageBox.Show("Lỗi load dữ liệu: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK);
//                    return;
//                }
//                this.LuoiHienThi_CotAn();

//                cm = (CurrencyManager)this.BindingContext[this.dv];
//                cm.PositionChanged += new EventHandler(this.Position_Changed);
//                this.HienThiThongTin(this.cm.Position);

//                this.ThemCacMucVao_CboLoc();
//                this.EnalbleControlFilter(false);

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
        }

        private void Position_Changed(object sender, EventArgs e)
        {
            //this.HienThiThongTin(this.cm.Position);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            #region old
            //try
            //{
            //    if (this.dgvDanhSachMatHang.RowCount > 0)
            //    {
            //        int IdMatHang = (int)this.dgvDanhSachMatHang.CurrentRow.Cells["IdSanPham"].Value;
            //        DBTools._IsCheck IsCheck;
            //        IsCheck = DBTools.CheckExistsRecord(this.GetHangHoa_CheckExists_IsForegin(IdMatHang));
            //        if (IsCheck == DBTools._IsCheck._TRUE)
            //        {
            //            MessageBox.Show("Thông tin mặt hàng này đã được sử dụng. Nên không thể xóa được", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //        else if (IsCheck == DBTools._IsCheck._EXCEPTION)
            //        {
            //            MessageBox.Show("Lỗi kiểm tra dữ liệu: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //        if (MessageBox.Show("Bạn có muốn xóa mặt hàng này không?", Declare.titleNotice, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //        {
            //            if (!DBTools.DeleteRecord(this.GetDeleteComand_DM_HangHoa(IdMatHang)))
            //            {
            //                Common.LogAction("Xóa danh mục sản phẩm", "IdSanPham " + IdMatHang, -1);

            //                MessageBox.Show("Lỗi xóa mặt hàng: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                return;
            //            }
            //            else
            //            {
            //                int Index = this.cm.Position;
            //                this.dv.Delete(Index);
            //                if (Index < this.dv.Count)
            //                {
            //                    this.CapNhatDuLieuCotSoTT(Index);
            //                }
            //                if (Index > 0)
            //                {
            //                    this.HienThiThongTin(this.cm.Position);
            //                    this.dgvDanhSachMatHang.CurrentRow.Selected = true;
            //                }
            //            }
            //            MessageBox.Show("Xóa danh mục mặt hàng thành công. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //btnThemMoi.Enabled = true;
            #endregion
            Delete();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //this.ThemMoi();
            //isAdd = true;
            //frmChiTiet_MatHang frm = new frmChiTiet_MatHang(this);
            //frm.ShowDialog();
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            #region old
            //dgvDanhSachMatHang.EndEdit();
            //if (!this.SuHopLeCuaThongTinCapNhat())
            //    return;

            //if (this.MatHang_IsThemMoi || this.IdMa==0)//dgvDanhSachMatHang.RowCount == 0)
            //    this.ThemMoiDuLieu();
            //else
            //    this.CapNhatDuLieu();
            //btnThemMoi.Enabled = true;
            #endregion
            //isAdd = false;
            //frmChiTiet_MatHang frm = new frmChiTiet_MatHang(this);
            //frm.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtTen_LostForcus(object sender, System.EventArgs e)
        {
            //if (this.MatHang_IsThemMoi)
            //{
            //    if (this.txtTenSanPham.Text.Trim() != "")
            //    {
            //        this.txtMaSanPham.Text = DBTools.ExecuteScalar(this.HangHoa_MaHangTuDong_Command(this.txtTenSanPham.Text.Trim())).ToString();
            //    }
            //}
            //else
            //{
            //    if (this.txtTenSanPham.Text.Trim() != this.dgvDanhSachMatHang.CurrentRow.Cells["TenMatHang"].Value.ToString())
            //    {
            //        this.txtMaSanPham.Text = DBTools.ExecuteScalar(this.HangHoa_MaHangTuDong_Command(this.txtTenSanPham.Text.Trim())).ToString();
            //    }
            //}
        }
        #endregion

        private void frmDM_Thuoc_KeyDown(object sender, KeyEventArgs e)
        {

                //if (e.KeyCode == Keys.Enter)
                //{
                //    if (!this.dgvDanhSachMatHang.Focused)
                //    {
                //        SendKeys.Send("{TAB}");
                //        e.Handled = true;
                //        return;
                //    }
                //}
        }

        private void chkLocTheo_CheckedChanged_1(object sender, EventArgs e)
        {
            //if (this.chkLocTheo.Checked)
            //{
            //    this.EnalbleControlFilter(true);
            //}
            //else
            //{
            //    this.dv.RowFilter = "";
            //    this.CapNhatDuLieuCotSoTT(0);
            //    if (this.dgvDanhSachMatHang.CurrentRow != null)
            //        this.HienThiThongTin(this.dgvDanhSachMatHang.CurrentRow.Index);
            //    this.EnalbleControlFilter(false);
            //}
        }

        private void txtLoc_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                //if (chkLocTheo.Checked)
                //{
                //    int Index = this.cm.Position;
                //    switch (this.cboLoc.SelectedIndex)
                //    {
                //        case 0:
                //            this.dv.RowFilter = "TenMatHang like'%" + this.txtLoc.Text.Trim() + "%'";
                //            break;
                //        case 1:
                //            this.dv.RowFilter = "IdLoaiMatHang in(" + this.GetString_Mang_IdLoaiMatHang(this.txtLoc.Text.Trim()) + ")";
                //            break;
                //        case 2:
                //            this.dv.RowFilter = "TinhChat like'%" + this.txtLoc.Text.Trim() + "%' or ThongTinKhac like '%" + this.txtLoc.Text.Trim() + "%'";
                //            break;

                //    }
                //    this.CapNhatDuLieuCotSoTT(0);
                //    if (this.cm.Position >= 0)
                //    {
                //        if (cm.Position == Index)
                //        {
                //            this.HienThiThongTin(Index);
                //        }
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(Declare.msgLoiNgoaiLe + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.txtLoc.Text != "")
            //    this.txtLoc.Text = "";
        }

        private void dgvDanhSachThuoc_Resize(object sender, EventArgs e)
        {
            //this.LuoiHienThi_Resize();
        }

        private void DanhMuc_CapNhatSoTT(int VitriRong)
        {
            //if (this.dtHangHoa != null)
            //{
            //    for (int i = VitriRong; i <= this.dtHangHoa.DefaultView.Count - 1; i++)
            //    {
            //        this.dtHangHoa.DefaultView[i]["SoTT"] = i + 1;
            //    }
            //}
        }

        private void dgvDanhSachThuoc_Sorted(object sender, EventArgs e)
        {
            //try
            //{
            //    this.DanhMuc_CapNhatSoTT(0);
            //    if (this.dgvDanhSachMatHang.CurrentRow != null)
            //        this.HienThiThongTin(this.dgvDanhSachMatHang.CurrentRow.Index);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cboLoaiThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F4)
            //{
            //    frmDM_Chung frm = new frmDM_Chung("frmDM_LoaiHangHoa");
            //    frm.ShowDialog();
            //    int IdLoaiMatHang = frm.IdMa;
            //    int Index = this.cboLoaiMatHang.SelectedIndex;

            //    DataTable dt = null;
            //    dt = DBTools.getData("tbl_DM_LoaiHangHoa", "Select IdLoaiMatHang,TenLoaiMatHang from tbl_DM_LoaiHangHoa").Tables["tbl_DM_LoaiHangHoa"];
            //    if (dt == null)
            //    {
            //        MessageBox.Show("Lỗi nấy dữ liệu loại mặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        e.Handled = true;
            //        frm.Dispose();
            //        return;
            //    }
            //    this.dtLoaiHangHoa = dt;
            //    this.DayDuLieuLenComboBox(this.cboLoaiMatHang, "TenLoaiMatHang", "IdLoaiMatHang", this.dtLoaiHangHoa);
            //    if (IdLoaiMatHang != 0)
            //        this.cboLoaiMatHang.SelectedValue = IdLoaiMatHang;
            //    else
            //    {
            //        if (Index < this.cboLoaiMatHang.Items.Count - 1)
            //            this.cboLoaiMatHang.SelectedIndex = Index;
            //        else
            //            this.cboLoaiMatHang.SelectedIndex = this.cboLoaiMatHang.Items.Count - 1;
            //    }

            //    e.Handled = true;
            //    frm.Dispose();
            //}
        }

        private void cboDonViTinh_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F4)
            //{
            //    frmDM_Chung frm = new frmDM_Chung("frmDM_DonViTinh");
            //    frm.ShowDialog();
            //    int IdDonViTinh = frm.IdMa;
            //    int Index = this.cboDonViTinh.SelectedIndex;

            //    DataTable dt = null;
            //    dt = DBTools.getData("tbl_DM_DonViTinh", "Select IdDonViTinh,TenDonViTinh from tbl_DM_DonViTinh").Tables["tbl_DM_DonViTinh"];
            //    if (dt == null)
            //    {
            //        MessageBox.Show("Lỗi nấy dữ liệu đơn vị tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        e.Handled = true;
            //        frm.Dispose();
            //        return;
            //    }
            //    this.dtDonViTinh = dt;
            //    this.DayDuLieuLenComboBox(this.cboDonViTinh, "TenDonViTinh", "IdDonViTinh", this.dtDonViTinh);
            //    if (IdDonViTinh != 0)
            //        this.cboDonViTinh.SelectedValue = IdDonViTinh;
            //    else
            //    {
            //        if (Index < this.cboDonViTinh.Items.Count - 1)
            //            this.cboDonViTinh.SelectedIndex = Index;
            //        else
            //            this.cboDonViTinh.SelectedIndex = this.cboDonViTinh.Items.Count - 1;
            //    }

            //    e.Handled = true;
            //    frm.Dispose();
            //}
        }

        //private void cboNhaSanXuat_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.F4)
        //    {
        //        frmDM_NhaCC_NhaSX frm = new frmDM_NhaCC_NhaSX("frmDM_NhaSanXuat");
        //        frm.ShowDialog();
        //        int IdNhaSanXuat = frm.IdMa;

        //        DataTable dt = null;
        //        dt = DBTools.getData("tbl_DM_NhaSanXuat", "Select IdNhaSanXuat,TenNhaSanXuat from tbl_DM_NhaSanXuat").Tables["tbl_DM_NhaSanXuat"];
        //        if (dt == null)
        //        {
        //            MessageBox.Show("Lỗi nấy dữ liệu nhà sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            e.Handled = true;
        //            frm.Dispose();
        //            return;
        //        }
        //        this.dtNhaSanXuat = dt;

        //        e.Handled = true;
        //        frm.Dispose();
        //    }
        //}


        private void txtIsNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //try
            //{
            //    Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_ISDOUBLE);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtIsNumber_LostForcus(object sender, System.EventArgs e)
        {
            //try
            //{
            //    TextBox txtSo = (TextBox)sender;
            //    if (Common.ValidateDouble(txtSo.Text.Trim()))
            //    {
            //        txtSo.Text = Common.Double2Str(Common.DoubleValue(txtSo.Text.Trim()));
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtIsNumber_GotForcus(object sender, System.EventArgs e)
        {
            //try
            //{
            //    TextBox txtSo = (TextBox)sender;
            //    if (Common.DoubleValue(txtSo.Text.Trim()) == 0)
            //    {
            //        txtSo.Select(0, txtSo.Text.Trim().Length);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            #region old
            //string dk = "1=1";
            //if (!String.IsNullOrEmpty(txtFilterMa.Text)) {
            //    dk += String.Format(" and MaSanPham like '{0}'", txtFilterMa.Text);
            //}
            //if (!String.IsNullOrEmpty(txtFilterTen.Text)) {
            //    dk += String.Format(" and TenSanPham like N'{0}'", txtFilterTen.Text);
            //}

            //string sql = "Select * from tbl_SanPham where " + dk;
            //this.dtHangHoa = DBTools.getData("tbl_SanPham", sql).Tables["tbl_SanPham"];
            //this.ThemTruongSoTT();

            //this.dv = this.dtHangHoa.DefaultView;
            //this.CapNhatDuLieuCotSoTT(0);
            //this.dgvDanhSachMatHang.DataSource = dv;

            //this.LuoiHienThi_CotAn();

            //cm = (CurrencyManager)this.BindingContext[this.dv];
            //cm.PositionChanged += new EventHandler(this.Position_Changed);
            //this.HienThiThongTin(this.cm.Position);
            #endregion

            dgvDanhSachMatHang.DataSource = null;
            dgvDanhSachMatHang.DataSource = DmSanPhamProvider.Search(new DMSanPhamInfo{TenSanPham = txtFilterTen.Text.Trim(),MaSanPham = txtFilterMa.Text.Trim()});
        }

        private void dgvDanhSachMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDanhSachMatHang_DoubleClick(object sender, EventArgs e)
        {
            //isAdd = false;
            //frmChiTiet_MatHang frm = new frmChiTiet_MatHang(this);
            //frm.ShowDialog();
        }

        private void dgvDanhSachMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && liSanPham.Count > 0)
            {
                SetControl(true);
                OidMatHang = Convert.ToInt32((liSanPham[dgvDanhSachMatHang.CurrentCell.RowIndex]).IdSanPham.ToString());
            }
        }
    }
}