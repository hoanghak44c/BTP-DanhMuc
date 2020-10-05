using System;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core;

//Note:@HanhBD frmDM_TrungTam
// <Remarks>
// tạo form danh mục Trung Tâm
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 01/03/2012
// Người sửa cuối:02/03/2012
// </remarks>

namespace QLBanHang.Modules.DanhMuc
{
    public interface IfrmDmTrungTamTestView
    {
        void TestLogin(string username, string pass);
    }

    public partial class frmDM_TrungTam_oLD : DevExpress.XtraEditors.XtraForm
    {
        private int idTrungTam = 0;
        public frmDM_TrungTam_oLD()
        {
            InitializeComponent();
            ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmTrungTam);
        }

        private void frmDM_TrungTam_Load(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = DMTrungTamDataProvider.GetListTrungTamInfo();
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

        private DMTrungTamInfor getinfor()
        {
            DMTrungTamInfor dmTrungTamInfor = new DMTrungTamInfor();
            dmTrungTamInfor.MaTrungTam = txtMaTrungTam.Text;
            dmTrungTamInfor.TenTrungTam = txtTenTrungTam.Text;
            dmTrungTamInfor.DiaChi = txtDiaChi.Text;
            dmTrungTamInfor.DienThoai = txtDienThoai.Text;
            dmTrungTamInfor.Email = txtEmail.Text;
            dmTrungTamInfor.Fax = txtFax.Text;
            dmTrungTamInfor.GhiChu = txtGhiChu.Text;
            dmTrungTamInfor.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dmTrungTamInfor.IdTrungTam = idTrungTam;
            return dmTrungTamInfor;
        }

        private void ucActions1_OnAdd(object obj)
        {
            DMTrungTamDataProvider.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
            dgvList.DataSource = DMTrungTamDataProvider.GetListTrungTamInfo();
        }

        private void ucActions1_OnClose()
        {
            this.Close();
        } 

        private void ucActions1_OnDelete(object obj)
        {
            DMTrungTamDataProvider.Delete(new DMTrungTamInfor{IdTrungTam = idTrungTam});
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvList.DataSource = DMTrungTamDataProvider.GetListTrungTamInfo();
        }

        //private object getValue(string colName)
        //{
        //    if (dgvList.CurrentRow != null && !dgvList.CurrentRow.IsNewRow)
        //        return dgvList.CurrentRow.Cells[colName].Value;
        //    return null;
        //}

        private void ucActions1_OnDisableEditor()
        {
            txtMaTrungTam.Enabled = false;
            txtTenTrungTam.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            txtEmail.Enabled = false;
            txtFax.Enabled = false;
            txtGhiChu.Enabled = false;
            chkSuDung.Enabled = false;
        }

        private void ucActions1_OnEnableEditor()
        {
            txtMaTrungTam.Enabled = true;
            txtTenTrungTam.Enabled = true;
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;
            txtFax.Enabled = true;
            txtGhiChu.Enabled = true;
            chkSuDung.Enabled = true;
        }

        private void ucActions1_OnLoadEditor(object obj)
        {
            if (obj != null)
            {
                txtMaTrungTam.Text = ((DMTrungTamInfor) obj).MaTrungTam;
                txtTenTrungTam.Text = ((DMTrungTamInfor)obj).TenTrungTam;
                txtDiaChi.Text = ((DMTrungTamInfor)obj).DiaChi;
                txtDienThoai.Text = ((DMTrungTamInfor)obj).DienThoai;
                txtEmail.Text = ((DMTrungTamInfor)obj).Email;
                txtFax.Text = ((DMTrungTamInfor)obj).Fax;
                txtGhiChu.Text = ((DMTrungTamInfor)obj).GhiChu;
                chkSuDung.Checked = ((DMTrungTamInfor)obj).SuDung == 1;
                idTrungTam = ((DMTrungTamInfor)obj).IdTrungTam;
                return;
            }
            txtMaTrungTam.Text = String.Empty;
            txtTenTrungTam.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtDienThoai.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtFax.Text = String.Empty;
            txtGhiChu.Text = String.Empty;
            chkSuDung.Checked = false;
            idTrungTam = 0;
        }

        private void ucActions1_OnUpdate(object obj)
        {
            DMTrungTamDataProvider.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
            dgvList.DataSource = DMTrungTamDataProvider.GetListTrungTamInfo();
        }

        private void ucActions1_OnValidate(object obj, QLBH.Core.ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    //idTrungTam = getEditId(obj);
                    if (txtMaTrungTam.Text == String.Empty)
                    {
                        throw new Exception("Mã Trung Tâm Không Được Để Trống!");
                    }
                    if (DMTrungTamDataProvider.KiemTra(new DMTrungTamInfor { IdTrungTam = idTrungTam, MaTrungTam = txtMaTrungTam.Text }))
                    {
                        //todo: @HanhBD (PENDING) check delete references
                        //với trường hợp update, delete thì thì phải check xem là đã có bảng nào tham chiếu đến chưa. 
                        //Nếu có thì không xóa mà warning người dùng và cập nhật lại sudung=0, và phải warning nếu update.
                        throw new Exception("Mã Trung Tâm Đã Tồn Tại!");
                    }
                    break;
            }
        }

        //private int getEditId(object obj)
        //{
        //    DataGridViewRow dr = obj as DataGridViewRow;
        //    if (dr == null) return 0;
        //    return Convert.ToInt32(dr.Cells["IdTrungTam"].Value);
        //}

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvList.Rows[e.RowIndex].IsNewRow)
                ucActions1.LoadEditor(null);
            else
                ucActions1.LoadEditor(dgvList.Rows[e.RowIndex].DataBoundItem);
        }
        
        //private bool Search(DMTrungTamInfor dmTrungTamInfor)
        //{
        //    return ((txtTimKiemTen.Text.Trim() == String.Empty || (txtTimKiemTen.Text.Trim() != String.Empty &&
        //            dmTrungTamInfor.TenTrungTam.ToLower().Contains(txtTimKiemTen.Text.Trim().ToLower())))
        //           && (txtTimKiemMa.Text.Trim() == String.Empty || (txtTimKiemMa.Text.Trim() != String.Empty &&
        //               dmTrungTamInfor.MaTrungTam.ToLower().Contains(txtTimKiemMa.Text.Trim().ToLower()))));
        //}

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DMTrungTamInfor dmTrungTamInfor = new DMTrungTamInfor();
            dmTrungTamInfor.TenTrungTam = txtTimKiemTen.Text;
            dmTrungTamInfor.MaTrungTam = txtTimKiemMa.Text;
            dgvList.DataSource = DMTrungTamDataProvider.Search(dmTrungTamInfor);
        }

        private void ucActions1_OnSynchronize()
        {
            throw new NotImplementedException("Synchronize function is not implemented.");
        }

        #region OLD
//        #region "Khai báo biên"
//        DataTable dtTrungTam;
//        bool _IsThemMoi = false;
//        CurrencyManager cm;
//        string _MaTrungTam = "";
//        string _TenTrungTam = "";
//        public int IdTrungTam = 0;
//#endregion

//#region "Các phương thức khởi tạo"
//        public frmDM_TrungTam()
//        {
//            InitializeComponent();
//            Common.LoadStyle(this);
//            this.Text = "Danh mục trung tâm";
//        }
//#endregion

//#region "Các phương thức"
//        private void LuoiHienThi_AnCot()
//        {
//            this.dgvList.Columns["IdTrungTam"].Visible = false;
//            this.dgvList.Columns["GhiChu"].Visible = false;
//        }

//        private void LuoiHienThi_GanNguon()
//        {
//            if (this.dtTrungTam != null)
//            {
//                this.dgvList.DataSource = this.dtTrungTam.DefaultView;
//                this.dgvList.Refresh();
//            }
//        }

//        private void LuoiHienThi_Resize()
//        {
//            int Luoi_ChieuDai=this.dgvList.Width;
//            int Luoi_ChieuDaiCacCot;
//            Luoi_ChieuDaiCacCot = this.SoTT.Width +
//                this.SuDung.Width +
//                this.TenTrungTam.Width +
//                this.MaTrungTam.Width +
//                this.DiaChi.Width +
//                this.DienThoai.Width +
//                this.dgvList.RowHeadersWidth + 2;
//            if (Luoi_ChieuDai > Luoi_ChieuDaiCacCot)
//                this.dgvList.Columns["DiaChi"].Width = Luoi_ChieuDai - (this.SoTT.Width +
//                                                    this.SuDung.Width +
//                                                    this.TenTrungTam.Width +
//                                                    this.MaTrungTam.Width +
//                                                    this.DienThoai.Width +
//                                                    this.dgvList.RowHeadersWidth + 2);
//            else
//                this.dgvList.Columns["DiaChi"].Width = 300;
//            this.dgvList.Refresh();

                                      
//        }

//        private object[] TrungTam_MangThongTin()
//        {
//            object[] arrMang ={ 0,
//                              this.txtMaTrungTam.Text.Trim(),
//                              this.txtTenTrungTam.Text.Trim(),
//                              this.txtDiaChi.Text.Trim(),
//                              this.txtDienThoai.Text.Trim(),
//                              this.txtFax.Text.Trim(),
//                              this.txtEmail.Text.Trim(),
//                              this.txtGhiChu.Text.Trim() ,
//                              this.chkSuDung.Checked ? 1 : 0 };

//            return arrMang;
//        }

//        private void TrungTam_ThemMoi()
//        {
//            this.TrungTam_KhoiTaoGiaTri();
//            this.txtMaTrungTam.Focus();
//            btnThemMoi.Enabled = false;
//        }

//        private void TrungTam_KhoiTaoGiaTri()
//        {
//            this._IsThemMoi = true;
//            this.txtMaTrungTam.Text = "";
//            this.txtTenTrungTam.Text = "";
//            this.txtDiaChi.Text = "";
//            this.txtDienThoai.Text = "";
//            this.txtEmail.Text = "";
//            this.txtFax.Text = "";
//            this.txtGhiChu.Text = "";
//            this.chkSuDung.Checked = true;
//        }

//        private bool TrungTam_LayDuLieu()
//        {
//            this.dtTrungTam = DBTools.getData("tbl_DM_TrungTam", "select IdTrungTam,MaTrungTam,TenTrungTam,DiaChi,DienThoai,Fax,Email,GhiChu,SuDung from tbl_DM_TrungTam order by MaTrungTam,TenTrungTam").Tables["tbl_DM_TrungTam"];
//            if (this.dtTrungTam == null)
//                return false;

//            this.TrungTam_ThemCotSoTT();
//            this.TrungTam_CapNhatSoTT(0);

//            return true;
//        }

//        private void TrungTam_ThemCotSoTT()
//        {
//            this.dtTrungTam.Columns.Add("SoTT", System.Type.GetType("System.Int16"));
//            this.TrungTam_CapNhatSoTT(0);
//        }

//        private void TrungTam_CapNhatSoTT(int VitriRong)
//        {
//            for (int i = VitriRong; i <= this.dtTrungTam.Rows.Count - 1; i++)
//            {
//                this.dtTrungTam.DefaultView[i]["SoTT"] = i + 1;
//            }
//        }

//        private void TrungTam_HienThi(int IndexRow)
//        {
//            if (IndexRow >= 0)
//            {
//                this._IsThemMoi = false;
//                this.txtMaTrungTam.Text = this.dtTrungTam.DefaultView[IndexRow]["MaTrungTam"].ToString();
//                this._MaTrungTam = this.txtMaTrungTam.Text.Trim();
//                this.txtTenTrungTam.Text = this.dtTrungTam.DefaultView[IndexRow]["TenTrungTam"].ToString();
//                this._TenTrungTam = this.txtTenTrungTam.Text.Trim();
//                this.txtDiaChi.Text = this.dtTrungTam.DefaultView[IndexRow]["DiaChi"].ToString();
//                this.txtDienThoai.Text = this.dtTrungTam.DefaultView[IndexRow]["DienThoai"].ToString();
//                this.txtFax.Text = this.dtTrungTam.DefaultView[IndexRow]["Fax"].ToString();
//                this.txtEmail.Text = this.dtTrungTam.DefaultView[IndexRow]["Email"].ToString();
//                this.txtGhiChu.Text = this.dtTrungTam.DefaultView[IndexRow]["GhiChu"].ToString();
//                this.chkSuDung.Checked = int.Parse(this.dtTrungTam.DefaultView[IndexRow]["SuDung"].ToString()) == 1;
//                this.IdTrungTam = int.Parse(this.dtTrungTam.DefaultView[IndexRow]["IdTrungTam"].ToString());
//            }
//            else
//            {
//                this.TrungTam_KhoiTaoGiaTri();
//                this._MaTrungTam = "";
//                this._TenTrungTam = "";
//            }
//        }

//        private bool TrungTam_SuHopLeCuaThongTin()
//        {
//            if (this.txtMaTrungTam.Text.Trim().Length == 0)
//            {
//                MessageBox.Show(Declare.msgFrmDM_Chung_MaChuaNhap, Declare.titleWarning, MessageBoxButtons.OK,MessageBoxIcon.Warning);
//                this.txtMaTrungTam.Focus();
//                return false;
//            }
//            string strSql = "Select * from tbl_DM_TrungTam where MaTrungTam=N'" + this.txtMaTrungTam.Text.Trim() + "'";
//            if (this._IsThemMoi)
//            {
//                if (DBTools.ExistData(strSql) == true)
//                {
//                    MessageBox.Show("Mã trung tâm này đã có." + "\n" + "-Hãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    this.txtMaTrungTam.Focus();
//                    return false;
//                }
//            }
//            else
//            {
//                if (string.Compare(this.txtMaTrungTam.Text.Trim(), this._MaTrungTam) != 0)
//                {
//                    if (DBTools.ExistData(strSql) == true)
//                    {
//                        MessageBox.Show("Mã trung tâm này đã có." + "\n" + "-Hãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                        this.txtMaTrungTam.Focus();
//                        return false;
//                    }
//                }
//            }

//            if (this.txtTenTrungTam.Text.Trim().Length == 0)
//            {
//                MessageBox.Show("Tên trung tâm chưa nhập.", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                this.txtTenTrungTam.Focus();
//                return false;
//            }

//            string strSqlTen = "Select * from tbl_DM_TrungTam where TenTrungTam=N'" + this.txtTenTrungTam.Text.Trim() + "'";
//            if (this._IsThemMoi)
//            {
//                if (DBTools.ExistData(strSqlTen) == true)
//                {
//                    MessageBox.Show("Têm trung tâm này đã có." + "\n" + "-Hãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    this.txtTenTrungTam.Focus();
//                    return false;
//                }
//            }
//            else
//            {
//                if (string.Compare(this.txtTenTrungTam.Text.Trim(), this._TenTrungTam) != 0)
//                {
//                    if (DBTools.ExistData(strSqlTen) == true)
//                    {
//                        MessageBox.Show("Tên trung tâm này đã có." + "\n" + "-Hãy nhập lại", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                        this.txtTenTrungTam.Focus();
//                        return false;
//                    }
//                }
//            }

//            if (this.txtDiaChi.Text.Trim().Length == 0)
//            {
//                MessageBox.Show("Địa chỉ trung tâm chưa nhập.", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                this.txtDiaChi.Focus();
//                return false;
//            }
////            if (!this._IsThemMoi)
////            {
////                DBTools._IsCheck IsCheck;
////                IsCheck = DBTools.CheckExistsRecord(this.TrungTam_IsCheckDeleteCommand((int)this.dgvList.CurrentRow.Cells["IdTrungTam"].Value));
////                if (IsCheck == DBTools._IsCheck._TRUE)
////                {
////                    if (!this.chkSuDung.Checked)
////                    {
////                        MessageBox.Show("Dữ liệu của danh mục trung tâm này đã được sử dụng nên trạng thái sử dụng luôn được chọn." + "\n" + "-Hãy chọn lại trạng thái sử dụng", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
////                        this.chkSuDung.Focus();
////                        return false;
////                    }
////                }
////                else if (IsCheck == DBTools._IsCheck._EXCEPTION)
////                {
////#if DEBUG
////                    MessageBox.Show(DBTools._LastError.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
////#else
////                    MessageBox.Show("Lỗi kiểm tra dữ liệu: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
////#endif
////                    return false;
////                }
////            }
//            return true;
//        }

//        private int TrungTam_DefaultView_Find(int Id)
//        {
//            if (this.dtTrungTam != null)
//            {
//                for (int i = 0; i <= this.dtTrungTam.DefaultView.Count - 1; i++)
//                {
//                    if (this.dtTrungTam.DefaultView[i]["IdTrungTam"].Equals((decimal)Id))
//                        return i;
//                }
//            }
//            return -1;
//        }

//        private void TrungTam_CapNhatRong(int VitriRong, Object[] MangGiaTri)
//        {
//            this.dtTrungTam.DefaultView.AllowEdit=true;
//            this.dtTrungTam.DefaultView.BeginInit();
//            for (int i = 0; i < MangGiaTri.Length; i++) {
//                this.dtTrungTam.DefaultView[VitriRong][i] = MangGiaTri[i];
//            }
//            this.dtTrungTam.EndInit();
//        }

//        private GtidCommand TrungTam_InsertCommand(Object[] arrMangThongTin)
//        {
//            GtidCommand sqlcmd = new GtidCommand();
//            sqlcmd.CommandText = "sp_DM_TrungTam_Insert";
//            sqlcmd.Parameters.AddWithValue("@IdTrungTam", arrMangThongTin[0]).Direction = ParameterDirection.Output;
//            sqlcmd.Parameters.AddWithValue("@MaTrungTam", arrMangThongTin[1]);
//            sqlcmd.Parameters.AddWithValue("@TenTrungTam", arrMangThongTin[2]);
//            sqlcmd.Parameters.AddWithValue("@DiaChi", arrMangThongTin[3]);
//            sqlcmd.Parameters.AddWithValue("@DienThoai", arrMangThongTin[4]);
//            sqlcmd.Parameters.AddWithValue("@Fax", arrMangThongTin[5]);
//            sqlcmd.Parameters.AddWithValue("@Email", arrMangThongTin[6]);
//            sqlcmd.Parameters.AddWithValue("@GhiChu", arrMangThongTin[7]);
//            sqlcmd.Parameters.AddWithValue("@SuDung", arrMangThongTin[8]);
              
//            sqlcmd.CommandType = CommandType.StoredProcedure;
//            return sqlcmd;
//        }

//        private GtidCommand TrungTam_UpdateCommand(Object[] arrMangThongTin)
//        {
//            GtidCommand sqlcmd = new GtidCommand();
//            sqlcmd.CommandText = "sp_DM_TrungTam_Update";
//            sqlcmd.Parameters.AddWithValue("@IdTrungTam", arrMangThongTin[0]);
//            sqlcmd.Parameters.AddWithValue("@MaTrungTam", arrMangThongTin[1]);
//            sqlcmd.Parameters.AddWithValue("@TenTrungTam", arrMangThongTin[2]);
//            sqlcmd.Parameters.AddWithValue("@DiaChi", arrMangThongTin[3]);
//            sqlcmd.Parameters.AddWithValue("@DienThoai", arrMangThongTin[4]);
//            sqlcmd.Parameters.AddWithValue("@Fax", arrMangThongTin[5]);
//            sqlcmd.Parameters.AddWithValue("@Email", arrMangThongTin[6]);
//            sqlcmd.Parameters.AddWithValue("@GhiChu", arrMangThongTin[7]);
//            sqlcmd.Parameters.AddWithValue("@SuDung", arrMangThongTin[8]);

//            sqlcmd.CommandType = CommandType.StoredProcedure;
//            return sqlcmd;
//        }

//        private GtidCommand TrungTam_DeleteCommand(int IdTrungTam)
//        {
//            GtidCommand sqlcmd = new GtidCommand();
//            sqlcmd.CommandText = "sp_DM_TrungTam_Delete";
//            sqlcmd.Parameters.AddWithValue("@IdTrungTam", IdTrungTam);
//            sqlcmd.CommandType = CommandType.StoredProcedure;
//            return sqlcmd;
//        }

//        private GtidCommand TrungTam_IsCheckDeleteCommand(int IdTrungTam)
//        {
//            GtidCommand sqlcmd = new GtidCommand();
//            sqlcmd.CommandText = "sp_DM_TrungTam_IsCheckDelete";
//            sqlcmd.Parameters.AddWithValue("@IdTrungTam", IdTrungTam);
//            sqlcmd.Parameters.AddWithValue("@IsCheck",0).Direction = ParameterDirection.Output;
//            sqlcmd.CommandType = CommandType.StoredProcedure;
//            return sqlcmd;
//        }
//#endregion
        
//#region "Các sự kiện"
//        private void frmDM_Kho_Load(object sender, EventArgs e)
//        {
//            try {
//                if (!this.TrungTam_LayDuLieu()) {
//                    throw DBTools._LastError;
//                }
//                this.LuoiHienThi_GanNguon();
//                this.LuoiHienThi_AnCot();

//                cm = (CurrencyManager)this.BindingContext[this.dtTrungTam.DefaultView];
//                cm.PositionChanged += new EventHandler(this.Position_Changed);
//                this.TrungTam_HienThi(this.cm.Position);
//            }
//            catch (Exception ex) {
//#if DEBUG
//                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#else
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#endif
//            }
//        }

//        private void btnThemMoi_Click(object sender, EventArgs e)
//        {
//            this.TrungTam_ThemMoi();
//        }

//        private void btnCapNhat_Click(object sender, EventArgs e)
//        {
//            GtidCommand sqlcmd = null;
//            Object[] MangThongTin;
//            if (!this.TrungTam_SuHopLeCuaThongTin())
//            {
//                return;
//            }

//            MangThongTin = this.TrungTam_MangThongTin();
//            if (this._IsThemMoi || dgvList.RowCount == 0)
//            {
//                sqlcmd = this.TrungTam_InsertCommand(MangThongTin);
//                if (DBTools.InsertRecord(sqlcmd) == true)
//                {
//                    MangThongTin[0] = sqlcmd.Parameters[0].Value;
//                    this.dtTrungTam.Rows.Add(MangThongTin);
//                    this.dgvList.Refresh();

//                    this.TrungTam_CapNhatSoTT(0);
//                    int Index = this.TrungTam_DefaultView_Find((int)MangThongTin[0]);
//                    cm.Position = Index;

//                    this._IsThemMoi = false;
//                    MessageBox.Show("Thêm mới trung tâm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//                else
//                {
//                    throw DBTools._LastError;
//                }
//            }
//            else
//            {
//                MangThongTin[0] = int.Parse(this.dgvList.CurrentRow.Cells["IdTrungTam"].Value.ToString());
//                sqlcmd = this.TrungTam_UpdateCommand(MangThongTin);

//                if (DBTools.UpdateRecord(sqlcmd) == true)
//                {
//                    this.TrungTam_CapNhatRong(this.dgvList.CurrentRow.Index, MangThongTin);
//                    int Index = this.TrungTam_DefaultView_Find((int)MangThongTin[0]);
//                    cm.Position = Index;
//                    this.TrungTam_CapNhatSoTT(0);
//                    this.dgvList.Refresh();
//                    this._MaTrungTam = this.txtMaTrungTam.Text.Trim();
//                    this._TenTrungTam = this.txtTenTrungTam.Text.Trim();
//                }
//                else
//                {
//                    throw DBTools._LastError;
//                }
//                MessageBox.Show("Cập nhật trung tâm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//            btnThemMoi.Enabled = true;
//        }

//        private void btnXoa_Click(object sender, EventArgs e)
//        {
//            if (this.dgvList.RowCount > 0)
//            {
//                //DBTools._IsCheck IsCheck;
//                //IsCheck = DBTools.CheckExistsRecord(this.TrungTam_IsCheckDeleteCommand((int)this.dtTrungTam.Rows[cm.Position]["IdTrungTam"]));
//                //if (IsCheck == DBTools._IsCheck._TRUE)
//                //{
//                //    MessageBox.Show("Danh mục trung tâm này đã được sử dụng. Nên không thể xóa được", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                //    return;
//                //}
//                //else if (IsCheck == DBTools._IsCheck._EXCEPTION)
//                //{
//                //    MessageBox.Show("Lỗi kiểm tra dữ liệu: "+ DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                //    return;
//                //}

//                if (DBTools.ExecuteScalar("select * from tbl_DM_Kho where IdTrungTam=" + this.dtTrungTam.Rows[cm.Position]["IdTrungTam"].ToString()) != null)
//                {
//                    MessageBox.Show("Danh mục trung tâm này đã được sử dụng. Nên không thể xóa được", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return;
//                }

//                if (MessageBox.Show("Bạn có muốn xóa danh mục trung tâm này không?", Declare.titleNotice, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
//                {
//                    if (DBTools.DeleteRecord(this.TrungTam_DeleteCommand(int.Parse(this.dtTrungTam.Rows[cm.Position]["IdTrungTam"].ToString()))))
//                    {
//                        int Index = this.cm.Position;
//                        this.dtTrungTam.Rows.RemoveAt(Index);
//                        if (Index < this.dtTrungTam.Rows.Count)
//                        {
//                            this.TrungTam_CapNhatSoTT(Index);
//                            this.TrungTam_HienThi(this.cm.Position);
//                        }
//                        else
//                        {
//                            if (Index > 0)
//                                this.dgvList.CurrentRow.Selected = true;
//                        }
//                        MessageBox.Show("Xóa danh mục trung tâm thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    }

//                    else
//                    {
//                        MessageBox.Show(Declare.msgDeleteErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    }
//                }
//            }
//            btnThemMoi.Enabled = true;

//        }

//        private void Position_Changed(object sender, EventArgs e)
//        {
//            try {
//                this.TrungTam_HienThi(this.cm.Position);
//            }
//            catch (Exception ex) {
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnDong_Click(object sender, EventArgs e)
//        {
//            this.Dispose();
//        }

//        private void txtMaKho_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            try {
//                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_CHAR_A_Z_a_z_0_9);
//                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_TOUPPER);
//            }
//            catch (Exception ex) {
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            try {
//                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_PHONE);
//            }
//            catch (Exception ex) {
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void frmDM_Kho_KeyDown(object sender, KeyEventArgs e)
//        {
//            try {
//                if (e.KeyCode == Keys.Enter) {
//                    if (!this.txtGhiChu.Focused)
//                        SendKeys.Send("{TAB}");
//                    e.Handled = true;
//                }
//                else if (e.KeyCode == Keys.F3) {
//                    if (this.WindowState == FormWindowState.Maximized)
//                        this.WindowState = FormWindowState.Normal;
//                    else
//                        this.WindowState = FormWindowState.Maximized;
//                    e.Handled = true;
//                }
//            }
//            catch (Exception ex) {
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void dgvList_Click(object sender, EventArgs e)
//        {
//            try {
//                int Index;
//                Index = this.dgvList.CurrentRow.Index;
//                if (Index == cm.Position)
//                    this.TrungTam_HienThi(cm.Position);
//            }
//            catch (Exception ex) {
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void dgvList_Resize(object sender, EventArgs e)
//        {
//            try {
//                this.LuoiHienThi_Resize();
//            }
//            catch (Exception ex) {
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnTimKiem_Click(object sender, EventArgs e)
//        {
//            string sql = "select IdTrungTam,MaTrungTam,TenTrungTam,DiaChi,DienThoai,Fax,Email,GhiChu,SuDung from tbl_DM_TrungTam where 1=1";
//            if (!String.IsNullOrEmpty(txtTimKiemMa.Text))
//                sql += " and MaTrungTam like '" + txtTimKiemMa.Text + "'";
//            if(!String.IsNullOrEmpty(txtTimKiemTen.Text))
//                sql += " and TenTrungTam like N'" + txtTimKiemTen.Text + "'";
//            sql += " order by MaTrungTam,TenTrungTam";
//            this.dtTrungTam = DBTools.getData("tbl_DM_TrungTam", sql).Tables["tbl_DM_TrungTam"];
//            if (this.dtTrungTam == null)
//                return ;
//            dgvList.DataSource = dtTrungTam;
//            this.TrungTam_ThemCotSoTT();
//            this.TrungTam_CapNhatSoTT(0);
//            dgvList.Refresh();
//        }

//        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            try {
//                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_NOT_SPACE);
//            }
//            catch (Exception ex) {
//                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//#endregion
        #endregion
    }
}