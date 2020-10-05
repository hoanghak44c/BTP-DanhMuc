using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Core.Data;

//using QLBanHang.Class;

//todo: @HanhBD frmDM_DMChung

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_Chung : Form
    {
        #region "Khai báo biến"
        DataTable dtDanhSach;
        bool blnThemMoi = false;
        CurrencyManager cm;
        string strMa = "";
        string strTen = "";
        public int IdMa = 0;

        string TenBang;
        string TenTruong1;
        string TenTruong2;
        string TenTruong3;
        string TenTruong4 = "GhiChu";
        string TenTruong5 = "SuDung";
        #endregion

        #region "Phương thức khởi tạo"
        public frmDM_Chung(string strTen)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            switch (strTen)
            {
                case "frmDM_TienTe":
                    {
                        this.TenBang = "tbl_DM_TienTe";
                        this.TenTruong1 = "IdTienTe";
                        this.TenTruong2 = "KyHieu";
                        this.TenTruong3 = "TenTienTe";
                        string[] arrMangTieuDe ={ "Tiền tệ", "DANH MỤC TIỀN TỆ", "Danh sách tiền tệ", "Mã tiền tệ", "Tên tiền tệ" };
                        this.DanhMuc_CapNhatTieuDe(arrMangTieuDe);
                        Int16[] arrMangGiaTri ={ 10, 100, 250 };
                        this.DanhMuc_GioiHanChieuDaiNhap(arrMangGiaTri);
                        break;
                    }
                case "frmDM_NhomNguoiDung":
                    {
                        this.TenBang = "tbl_DM_NhomNguoiDung";
                        this.TenTruong1 = "IdNhomNguoiDung";
                        this.TenTruong2 = "MaNhom";
                        this.TenTruong3 = "TenNhom";
                        string[] arrMangTieuDe ={ "Nhóm người dùng", "DANH MỤC NHÓM NGƯỜI DÙNG", "Danh sách nhóm người dùng", "Mã nhóm", "Tên nhóm" };
                        this.DanhMuc_CapNhatTieuDe(arrMangTieuDe);
                        Int16[] arrMangGiaTri ={ 5, 150, 250 };
                        this.DanhMuc_GioiHanChieuDaiNhap(arrMangGiaTri);
                        break;
                    }
                case "frmDM_ChucNang":
                    {
                        this.TenBang = "tbl_DM_ChucNang";
                        this.TenTruong1 = "IdChucNang";
                        this.TenTruong2 = "MaChucNang";
                        this.TenTruong3 = "TenChucNang";
                        string[] arrMangTieuDe ={ "Chức năng", "DANH MỤC CHỨC NĂNG", "Danh sách chức năng", "Mã chức năng", "Tên chức năng" };
                        this.DanhMuc_CapNhatTieuDe(arrMangTieuDe);
                        Int16[] arrMangGiaTri ={ 5, 150, 250 };
                        this.DanhMuc_GioiHanChieuDaiNhap(arrMangGiaTri);
                        break;
                    }
                case "frmDM_DonViTinh":
                    {
                        this.TenBang = "tbl_DM_DonViTinh";
                        this.TenTruong1 = "IdDonViTinh";
                        this.TenTruong2 = "KyHieu";
                        this.TenTruong3 = "TenDonViTinh";
                        string[] arrMangTieuDe ={ "Đơn vị tính", "DANH MỤC ĐƠN VỊ TÍNH", "Danh sách đơn vị tính", "Ký hiệu", "Tên đơn vị tính" };
                        this.DanhMuc_CapNhatTieuDe(arrMangTieuDe);
                        Int16[] arrMangGiaTri ={ 10, 50, 250 };
                        this.DanhMuc_GioiHanChieuDaiNhap(arrMangGiaTri);
                        break;

                    }
                case "frmDM_PhongBan":
                    {
                        this.TenBang = "tbl_DM_PhongBan";
                        this.TenTruong1 = "IdPhongBan";
                        this.TenTruong2 = "MaPhongBan";
                        this.TenTruong3 = "TenPhongBan";
                        string[] arrMangTieuDe ={ "Phòng ban", "DANH MỤC PHÒNG BAN", "Danh sách phòng ban", "Mã phòng ban", "Tên phòng ban" };
                        this.DanhMuc_CapNhatTieuDe(arrMangTieuDe);
                        Int16[] arrMangGiaTri ={ 10, 100, 250 };
                        this.DanhMuc_GioiHanChieuDaiNhap(arrMangGiaTri);
                        break;

                    }
                case "frmDM_ChucVu":
                    {
                        this.TenBang = "tbl_DM_ChucVu";
                        this.TenTruong1 = "IdChucVu";
                        this.TenTruong2 = "MaChucVu";
                        this.TenTruong3 = "TenChucVu";
                        string[] arrMangTieuDe ={ "Chức vụ", "DANH MỤC CHỨC VỤ", "Danh sách các chức vụ", "Mã chức vụ", "Tên chức vụ" };
                        this.DanhMuc_CapNhatTieuDe(arrMangTieuDe);
                        Int16[] arrMangGiaTri ={ 10, 100, 250 };
                        this.DanhMuc_GioiHanChieuDaiNhap(arrMangGiaTri);
                        break;
                    }
                case "frmDM_OrderType":
                    {
                        this.TenBang = "tbl_DM_OrderType";
                        this.TenTruong1 = "IdOrderType";
                        this.TenTruong2 = "Code";
                        this.TenTruong3 = "Name";
                        string[] arrMangTieuDe ={ "Order Type", "DANH MỤC ORDER TYPE", "Danh sách các Order Type", "Mã Order Type", "Tên Order Type" };
                        this.DanhMuc_CapNhatTieuDe(arrMangTieuDe);
                        Int16[] arrMangGiaTri ={ 500, 150, 250 };
                        this.DanhMuc_GioiHanChieuDaiNhap(arrMangGiaTri);
                        break;
                    }
                case "frmDM_TaxCode":
                    {
                        this.TenBang = "tbl_DM_BieuThue";
                        this.TenTruong1 = "IdBieuThue";
                        this.TenTruong2 = "MaBieuThue";
                        this.TenTruong3 = "TenBieuThue";
                        string[] arrMangTieuDe ={ "Tax Code", "DANH MỤC TAX CODE", "Danh sách các Tax Code", "Mã Tax Code", "Tên Tax Code" };
                        this.DanhMuc_CapNhatTieuDe(arrMangTieuDe);
                        Int16[] arrMangGiaTri ={ 50, 150, 250 };
                        this.DanhMuc_GioiHanChieuDaiNhap(arrMangGiaTri);
                        //this.dgvList.AutoGenerateColumns = false;
                        break;
                    }
                case "frmDM_DuAn":
                    {
                        this.TenBang = "tbl_DM_DuAn";
                        this.TenTruong1 = "IdDuAn";
                        this.TenTruong2 = "MaDuAn";
                        this.TenTruong3 = "TenDuAn";
                        string[] arrMangTieuDe ={ "Dự án", "DANH MỤC DỰ ÁN", "Danh sách các dự án", "Mã dự án", "Tên dự án" };
                        this.DanhMuc_CapNhatTieuDe(arrMangTieuDe);
                        Int16[] arrMangGiaTri ={ 20, 50, 250 };
                        this.DanhMuc_GioiHanChieuDaiNhap(arrMangGiaTri);
                        break;
                    }
            }
        }
        #endregion

        #region "Các phương thức"
        private void DanhMuc_CapNhatTieuDe(string[] arrMangTieuDe)
        {
            if (arrMangTieuDe != null)
            {
                this.Text = arrMangTieuDe[0];
                this.lblTieuDe.Text = arrMangTieuDe[1];
                this.grpThongTin.Text = arrMangTieuDe[2];
                this.lblMa.Text = arrMangTieuDe[3];
                this.lblTen.Text = arrMangTieuDe[4];
            }
            return;
        }

        private void DanhMuc_GioiHanChieuDaiNhap(Int16[] arrMangGiaTri)
        {
            if (arrMangGiaTri != null)
            {
                this.txtMa.MaxLength = arrMangGiaTri[0];
                this.txtTen.MaxLength = arrMangGiaTri[1];
                this.txtMoTa.MaxLength = arrMangGiaTri[2];
            }
        }

        private void LuoiHienThi_TaoCauTruc()
        {
            this.dgvList.Columns[this.TenTruong2].HeaderText = this.lblMa.Text;
            //this.dgvList.Columns[this.TenTruong2].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgvList.Columns[this.TenTruong2].Width = 110;
            this.dgvList.Columns[this.TenTruong2].ReadOnly = true;
            this.dgvList.Columns[this.TenTruong2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvList.Columns[this.TenTruong3].HeaderText = this.lblTen.Text;
            //this.dgvList.Columns[this.TenTruong3].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgvList.Columns[this.TenTruong3].Width = 110;
            this.dgvList.Columns[this.TenTruong3].ReadOnly = true;
            this.dgvList.Columns[this.TenTruong3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dgvList.Columns[this.TenTruong4].HeaderText = this.lblMoTa.Text;
            this.dgvList.Columns[this.TenTruong4].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgvList.Columns[this.TenTruong4].Width = 160;
            this.dgvList.Columns[this.TenTruong4].ReadOnly = true;
            this.dgvList.Columns[this.TenTruong4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.dgvList.Columns[this.TenTruong5].HeaderText = this.lblSuDung.Text;
            this.dgvList.Columns[this.TenTruong5].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgvList.Columns[this.TenTruong5].Width = 60;
            this.dgvList.Columns[this.TenTruong5].ReadOnly = true;
            this.dgvList.Columns[this.TenTruong5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvList.Columns[this.TenTruong1].Visible = false;
        }

        private void LuoiHienThi_GanNguon()
        {
            if (this.dtDanhSach != null)
            {
                this.dgvList.DataSource = this.dtDanhSach.DefaultView;
                this.dgvList.Refresh();
            }
        }

        private void LuoiHienThi_Resize()
        {
            int iChieuDai = 0;
            iChieuDai = (this.dgvList.Width - this.dgvList.Columns["SoTT"].Width
                                            - this.dgvList.Columns[this.TenTruong2].Width
                                            - this.dgvList.Columns[this.TenTruong5].Width) / 5;
            this.dgvList.Columns[this.TenTruong3].Width = 2 * iChieuDai;
            this.dgvList.Columns[this.TenTruong4].Width = this.dgvList.Width - this.dgvList.Columns["SoTT"].Width
                                                                             - this.dgvList.Columns[this.TenTruong2].Width
                                                                             - this.dgvList.Columns[this.TenTruong3].Width
                                                                             - this.dgvList.Columns[this.TenTruong5].Width
                                                                             - this.dgvList.RowHeadersWidth - 2;
            this.dgvList.Refresh();
        }

        private object[] DanhMuc_MangThongTin()
        {
            object[] arrMang ={ 0,
                                this.txtMa.Text.Trim(),
                                this.txtTen.Text.Trim(),
                                this.txtMoTa.Text.Trim(), 
                                this.chkSuDung.Checked ? 1 : 0 };
            return arrMang;
        }

        private void DanhMuc_ThemMoi()
        {
            this.DanhMuc_KhoiTaoGiaTri();
            this.txtMa.Focus();
            btnThemMoi.Enabled = false;
        }

        private void DanhMuc_KhoiTaoGiaTri()
        {
            this.blnThemMoi = true;
            this.txtMa.Text = "";
            this.txtTen.Text = "";
            this.txtMoTa.Text = "";
            this.IdMa = 0;
            this.chkSuDung.Checked = true;
        }

        private bool DanhMuc_NayDuLieu()
        {
            this.dtDanhSach = (DataTable)DBTools.getData(this.TenBang).Tables[this.TenBang];
            if (this.dtDanhSach == null)
                return false;
            this.dtDanhSach.Columns.Add("SoTT", System.Type.GetType("System.Int16"));
            this.DanhMuc_CapNhatSoTT(0);

            return true;
        }

        private void DanhMuc_CapNhatSoTT(int VitriRong)
        {
            if (this.dtDanhSach != null)
            {
                for (int i = VitriRong; i <= this.dtDanhSach.DefaultView.Count - 1; i++)
                {
                    this.dtDanhSach.DefaultView[i]["SoTT"] = i + 1;
                }
            }
        }
        private int DanhSach_DefaultView_Find(int Id)
        {
            if (this.dtDanhSach != null)
            {
                for (int i = 0; i <= this.dtDanhSach.DefaultView.Count - 1; i++)
                {
                    if (Equals(this.dtDanhSach.DefaultView[i][this.TenTruong1], (decimal)Id))
                        return i;
                }
            }
            return -1;
        }


        private void DanhMuc_HienThi(int IndexRow)
        {
            if (IndexRow >= 0)
            {
                if (this.blnThemMoi)
                    this.blnThemMoi = false;
                this.txtMa.Text = this.dtDanhSach.DefaultView[IndexRow][1].ToString();
                this.strMa = this.txtMa.Text.Trim();
                this.txtTen.Text = this.dtDanhSach.DefaultView[IndexRow][2].ToString();
                this.strTen = this.txtTen.Text.Trim();
                this.txtMoTa.Text = this.dtDanhSach.DefaultView[IndexRow][3].ToString();
                if (this.dtDanhSach.DefaultView[IndexRow][4] != System.DBNull.Value)
                {
                    this.chkSuDung.Checked = Equals(this.dtDanhSach.DefaultView[IndexRow][4],(decimal)1);
                }
                this.IdMa = int.Parse(this.dtDanhSach.DefaultView[IndexRow][this.TenTruong1].ToString());
            }
            else
            {
                this.DanhMuc_KhoiTaoGiaTri();
                this.strMa = "";
                this.strTen = "";
            }
        }
        //TuanLM moidfied 30/03/08
        private bool DanhMuc_SuHopLeCuaThongTin()
        {
            if (string.Compare(this.Text.Trim().ToLower(), "quốc gia") != 0)
            {
                //kiem tra ma
                if (this.txtMa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã " + this.Text.ToLower() + " chưa nhập." + "\n" + "-Hãy nhập mã " + this.Text.ToLower(), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtMa.Focus();
                    return false;
                }
                string strSqlMa = "Select * from " + this.TenBang + " where " + this.TenTruong2
                                                 + "=N'" + this.txtMa.Text.Trim() + "'"
                                                 + " and " + this.TenTruong1 + " <> " + IdMa;


                if (this.blnThemMoi)
                {
                    if (DBTools.ExistData(strSqlMa) == true)
                    {
                        MessageBox.Show("Mã " + this.txtMa.Text + " đã tồn tại." + "\n" + "-Hãy nhập lại mã " + this.Text.ToLower(), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtMa.Focus();
                        return false;
                    }
                }

                else
                {
                    if (string.Compare(this.txtMa.Text.Trim().ToUpper(), this.strMa) != 0)
                    {
                        if (DBTools.ExistData(strSqlMa) == true)
                        {
                            MessageBox.Show("Mã " + this.txtMa.Text + " đã tồn tại." + "\n" + "-Hãy nhập lại mã " + this.Text.ToLower(), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.txtMa.Focus();
                            return false;
                        }
                    }
                }

                //kiem tra ten
                if (this.txtTen.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Tên " + this.Text.ToLower() + " chưa nhập." + "\n" + "-Hãy nhập tên " + this.Text.ToLower(), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtTen.Focus();
                    return false;
                }
                else
                {
                    string strSqlTen = "Select * from " + this.TenBang + " where " + this.TenTruong3
                                                     + "=N'" + this.txtTen.Text.Trim() + "'";

                    if (this.blnThemMoi)
                    {
                        if (DBTools.ExistData(strSqlTen) == true)
                        {
                            MessageBox.Show("Tên " + this.txtTen.Text + " đã tồn tại." + "\n" + "-Hãy nhập lại tên " + this.Text.ToLower(), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.txtTen.Focus();
                            return false;
                        }

                    }
                    else
                    {
                        if (string.Compare(this.txtTen.Text.Trim(), this.strTen) != 0)
                        {
                            if (DBTools.ExistData(strSqlTen) == true)
                            {
                                MessageBox.Show("Tên " + this.txtTen.Text + " đã tồn tại." + this.strTen + "\n" + "-Hãy nhập lại tên " + this.Text.ToLower(), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.txtTen.Focus();
                                return false;
                            }
                        }
                    }
                }

            }
            else//if(string.Compare(this.Text.Trim().ToLower(), "quốc gia")==0)
            {
                //kiem tra ma
                if (this.txtMa.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Mã " + this.Text.ToLower() + " chưa nhập." + "\n" + "-Hãy nhập mã " + this.Text.ToLower(), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtMa.Focus();
                    return false;
                }
                if (this.blnThemMoi)
                {
                    if (DBTools.ExistData("Select * from tbl_DM_QuocGia where MaQuocGia=N'" + this.txtMa.Text.Trim() + "'") == true)
                    {
                        MessageBox.Show("Mã " + this.txtMa.Text + " đã tồn tại." + "\n" + "-Hãy nhập lại mã " + this.Text.ToLower(), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtMa.Focus();
                        return false;
                    }
                }
                else
                {
                    if (this.txtMa.Text.Trim() != strMa)
                    {
                        if (DBTools.ExistData("Select * from tbl_DM_QuocGia where MaQuocGia=N'" + this.txtMa.Text.Trim() + "'") == true)
                        {
                            MessageBox.Show("Mã " + this.Text.ToLower() + " đã tồn tại." + "\n" + "-Hãy nhập lại mã " + this.Text.ToLower(), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.txtMa.Focus();
                            return false;
                        }
                    }
                }
                //kiem tra ten
                string strTen;
                strTen = this.dgvList.CurrentRow.Index >= 0 ? this.dgvList.CurrentRow.Cells[this.TenTruong3].Value.ToString().ToLower() : "";
                if (this.txtTen.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Tên " + this.Text.ToLower() + " chưa nhập." + "\n" + "-Hãy nhập tên " + this.Text.ToLower(), Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtTen.Focus();
                    return false;
                }
                if (this.blnThemMoi)
                {
                    if (DBTools.ExistData("Select * from tbl_DM_QuocGia where TenQuocGia=N'" + this.txtTen.Text.Trim() + "'") == true)
                    {
                        MessageBox.Show("Tên " + this.Text.ToLower() + " đã tồn tại." + "\n" + "-Hãy nhập lại tên " + this.Text.ToLower(), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtTen.Focus();
                        return false;
                    }
                }
                else
                {
                    if (this.txtTen.Text.Trim().ToLower() != strTen)
                    {
                        if (DBTools.ExistData("Select * from tbl_DM_QuocGia where TenQuocGia=N'" + this.txtTen.Text.Trim() + "'") == true)
                        {
                            MessageBox.Show("Tên " + this.Text.ToLower() + " đã tồn tại." + "\n" + "-Hãy nhập lại tên " + this.Text.ToLower(), Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.txtTen.Focus();
                            return false;
                        }
                    }
                }

            }

            if (!this.blnThemMoi)
            {
                if (this.TenBang != "tbl_DM_QuocGia")
                {
                    DBTools._IsCheck IsCheck;
                    IsCheck = DBTools.CheckExistsRecord(this.DanhMuc_IsChecExitForeginKeyCommand(int.Parse(this.dgvList.CurrentRow.Cells[this.TenTruong1].Value.ToString())));
                    if (IsCheck == DBTools._IsCheck._TRUE)
                    {
                        if (!this.chkSuDung.Checked)
                        {
                            MessageBox.Show("Dữ liệu của danh mục " + this.Text + " đã được sử dụng nên trạng thái sử dụng luôn được chọn", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.chkSuDung.Focus();
                            return false;
                        }
                    }
                    else if (IsCheck == DBTools._IsCheck._EXCEPTION)
                    {
                        MessageBox.Show("Lỗi kiểm tra dữ liệu " + this.Text.Trim().ToLower() + ": " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        //~TuanLM moidfied 30/03/08
        private void DanhMuc_SuaRong(int VitriRong, Object[] arrMangGiaTri)
        {
            if (this.dtDanhSach != null)
            {
                this.dtDanhSach.DefaultView.AllowEdit = true;
                this.dtDanhSach.DefaultView.BeginInit();
                for (int i = 0; i <= this.dtDanhSach.Columns.Count - 2; i++)
                {
                    if (i < arrMangGiaTri.Length)
                    {
                        this.dtDanhSach.DefaultView[VitriRong][i] = arrMangGiaTri[i];
                    }
                }
                this.dtDanhSach.DefaultView.EndInit();
            }
        }

        private GtidCommand DanhMuc_InsertCommand(Object[] arrMangThongTin)
        {
            GtidCommand sqlcmd = new GtidCommand();
            sqlcmd.CommandText = "sp" + this.TenBang.Substring(3) + "_Insert";
            sqlcmd.Parameters.AddWithValue("@" + this.TenTruong1.Trim(), arrMangThongTin[0]).Direction = ParameterDirection.Output;
            sqlcmd.Parameters.AddWithValue("@" + this.TenTruong2.Trim(), arrMangThongTin[1]).Direction = ParameterDirection.Input;
            sqlcmd.Parameters.AddWithValue("@" + this.TenTruong3.Trim(), arrMangThongTin[2]).Direction = ParameterDirection.Input;
            sqlcmd.Parameters.AddWithValue("@" + this.TenTruong4.Trim(), arrMangThongTin[3]).Direction = ParameterDirection.Input;
            sqlcmd.Parameters.AddWithValue("@" + this.TenTruong5.Trim(), arrMangThongTin[4]).Direction = ParameterDirection.Input;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            return sqlcmd;
        }

        private GtidCommand DanhMuc_UpdateCommand(Object[] arrMangThongTin)
        {
            GtidCommand sqlcmd = new GtidCommand();
            sqlcmd.CommandText = "sp" + this.TenBang.Substring(3) + "_Update";
            sqlcmd.Parameters.AddWithValue("@" + this.TenTruong1.Trim(), arrMangThongTin[0]).Direction = ParameterDirection.Input;
            sqlcmd.Parameters.AddWithValue("@" + this.TenTruong2.Trim(), arrMangThongTin[1]).Direction = ParameterDirection.Input;
            sqlcmd.Parameters.AddWithValue("@" + this.TenTruong3.Trim(), arrMangThongTin[2]).Direction = ParameterDirection.Input;
            sqlcmd.Parameters.AddWithValue("@" + this.TenTruong4.Trim(), arrMangThongTin[3]).Direction = ParameterDirection.Input;
            sqlcmd.Parameters.AddWithValue("@" + this.TenTruong5.Trim(), arrMangThongTin[4]).Direction = ParameterDirection.Input;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            return sqlcmd;
        }

        private GtidCommand DanhMuc_DeleteCommand(int IdDanhMuc)
        {
            GtidCommand sqlcmd = new GtidCommand();
            sqlcmd.CommandText = "sp" + this.TenBang.Substring(3) + "_Delete";
            sqlcmd.Parameters.AddWithValue("@" + this.TenTruong1.Trim(), IdDanhMuc).Direction = ParameterDirection.Input;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            return sqlcmd;
        }

        private GtidCommand DanhMuc_IsChecExitForeginKeyCommand(int IdDM)
        {
            GtidCommand sql = new GtidCommand("sp" + this.TenBang.Substring(3) + "_ChkRef");
            sql.Parameters.AddWithValue("@" + TenTruong1, IdDM).Direction = ParameterDirection.Input;
            sql.Parameters.AddWithValue("@IsCheck", 0).Direction = ParameterDirection.Output;
            sql.CommandType = CommandType.StoredProcedure;
            return sql;
        }
        #endregion

        #region "Các sự kiên"

        private void frmDM_Chung_Load(object sender, EventArgs e)
        {
            try
            {
                if (!this.DanhMuc_NayDuLieu())
                {
                    MessageBox.Show("Lỗi nấy dữ liệu: " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //this.Dispose();
                }
                this.LuoiHienThi_GanNguon();
                this.LuoiHienThi_TaoCauTruc();
                this.LuoiHienThi_Resize();

                cm = (CurrencyManager)this.BindingContext[this.dtDanhSach.DefaultView];
                cm.PositionChanged += new EventHandler(this.Position_Changed);
                this.DanhMuc_HienThi(this.cm.Position);
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                this.DanhMuc_ThemMoi();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvList.RowCount > 0)
                {
                    if (this.TenBang != "tbl_DM_QuocGia")
                    {
                        DBTools._IsCheck IsCheck;
                        IsCheck = DBTools.CheckExistsRecord(this.DanhMuc_IsChecExitForeginKeyCommand(int.Parse(this.dgvList.CurrentRow.Cells[this.TenTruong1].Value.ToString())));
                        if (IsCheck == DBTools._IsCheck._TRUE)
                        {
                            MessageBox.Show(Declare.msgFrmDM_Chung_KhongXoa, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (IsCheck == DBTools._IsCheck._EXCEPTION)
                        {
                            MessageBox.Show("Lỗi xóa " + this.Text.Trim().ToLower() + ": " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (MessageBox.Show("Bạn có chắc chắn xóa " + this.Text.Trim().ToLower() + " này không?", Declare.titleNotice, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (DBTools.DeleteRecord(this.DanhMuc_DeleteCommand(int.Parse(this.dgvList.CurrentRow.Cells[this.TenTruong1].Value.ToString()))))
                        {
                            Common.LogAction("Xóa " + this.Text.ToLower(), "Completed. " + this.TenTruong1 + "=" + this.dgvList.CurrentRow.Cells[this.TenTruong1].Value, -1);
                            int Index = this.cm.Position;
                            this.dtDanhSach.DefaultView.Delete(Index);
                            if (Index < this.dtDanhSach.Rows.Count)
                            {
                                this.DanhMuc_CapNhatSoTT(0);
                                this.DanhMuc_HienThi(this.cm.Position);
                            }
                            else
                            {
                                if (Index > 0)
                                    this.dgvList.CurrentRow.Selected = true;
                            }
                            MessageBox.Show("Xóa danh mục " + this.Text.ToString().Trim().ToLower() + " thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Common.LogAction("Xóa " + this.Text.ToLower(), "Failed. " + this.TenTruong1 + "=" + this.dgvList.CurrentRow.Cells[this.TenTruong1].Value, -1);
                            MessageBox.Show("Lỗi xóa " + this.Text.Trim().ToLower() + ": " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
            btnThemMoi.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            GtidCommand sqlcmd = null;
            Object[] MangThongTin;
            try
            {
                if (!this.DanhMuc_SuHopLeCuaThongTin())
                    return;
                MangThongTin = this.DanhMuc_MangThongTin();
                if (this.blnThemMoi)
                {
                    sqlcmd = this.DanhMuc_InsertCommand(MangThongTin);
                    if (DBTools.InsertRecord(sqlcmd) == true)
                    {
                        MangThongTin[0] = sqlcmd.Parameters[0].Value;
                        Common.LogAction("Tạo mới " + this.Text.ToLower(), "Completed. " + this.TenTruong1 + "=" + MangThongTin[0], -1);

                        this.dtDanhSach.Rows.Add(MangThongTin);
                        this.dgvList.Refresh();
                        this.DanhMuc_CapNhatSoTT(0);
                        int Index = this.DanhSach_DefaultView_Find(int.Parse(MangThongTin[0].ToString()));
                        cm.Position = Index;
                        this.blnThemMoi = false;
                        MessageBox.Show("Thêm mới " + this.Text.ToLower() + " Thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Common.LogAction("Tạo mới " + this.Text.ToLower(), "Failed. " + this.TenTruong1 + "=" + MangThongTin[0], -1);
                        MessageBox.Show("Lỗi thêm mới " + this.Text.Trim().ToLower() + ": " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MangThongTin[0] = this.dgvList.CurrentRow.Cells[this.TenTruong1].Value;
                    sqlcmd = this.DanhMuc_UpdateCommand(MangThongTin);

                    if (DBTools.UpdateRecord(sqlcmd) == true)
                    {
                        Common.LogAction("Cập nhật " + this.Text.ToLower(), "Completed. " + this.TenTruong1 + "=" + MangThongTin[0], -1);

                        this.DanhMuc_SuaRong(this.dgvList.CurrentRow.Index, MangThongTin);
                        int Index = this.DanhSach_DefaultView_Find(int.Parse(MangThongTin[0].ToString()));
                        cm.Position = Index;
                        this.DanhMuc_CapNhatSoTT(0);
                        this.dgvList.Refresh();
                        this.strMa = this.txtMa.Text.Trim();
                        this.strTen = this.txtTen.Text.Trim();
                        MessageBox.Show("Cập nhật " + this.Text.ToLower() + " thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Common.LogAction("Cập nhật " + this.Text.ToLower(), "Failed. " + this.TenTruong1 + "=" + MangThongTin[0], -1);
                        MessageBox.Show("Lỗi cập nhật " + this.Text.Trim().ToLower() + ": " + DBTools._LastError.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
            btnThemMoi.Enabled = true;
        }

        private void Position_Changed(object sender, EventArgs e)
        {
            this.DanhMuc_HienThi(this.cm.Position);
        }

        private void txtMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (this.Text.Trim().ToLower() == "quốc gia")
                {
                    Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_ISNUMBER);
                }
                else
                {
                    Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_CHAR_A_Z_a_z_0_9);
                    Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_TOUPPER);
                }
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

        private void dgvList_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtDanhSach.Rows.Count > 0)
                    if (this.dgvList.CurrentRow != null && this.dgvList.CurrentRow.Index == this.cm.Position)
                        if (this.blnThemMoi)
                            this.DanhMuc_HienThi(this.cm.Position);
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

        private void dgvList_Resize(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvList.DataSource != null)
                {
                    this.LuoiHienThi_Resize();
                }
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

        private void dgvList_Sorted(object sender, EventArgs e)
        {
            try
            {
                this.DanhMuc_CapNhatSoTT(0);
                if (this.dgvList.CurrentRow != null)
                    this.DanhMuc_HienThi(this.dgvList.CurrentRow.Index);
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
        #endregion


    }
}