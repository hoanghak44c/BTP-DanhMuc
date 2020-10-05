using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Providers;
using System.Collections;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Infors;

//Note:@CuongTT frmDM_NhanVien
namespace QLBanHang.Modules.DanhMuc
{

    public partial class frmDM_NhanVien_OLD : DevExpress.XtraEditors.XtraForm
    {
        public bool isAdd;
        public int OidNhanVien =0;

        public frmDM_NhanVien_OLD()
        {
            InitializeComponent();
            //Common.LoadStyle(this);
            dgvListGent();
        }

        #region Action

        #region LoadChucVu
        private  void  LoadChucVu()
        {
            cboChucDanhS.DataSource = DMChucVuDataProvider.GetListChucVuPairInfo();
            cboChucDanhS.DisplayMember = "TenChucVu";
            cboChucDanhS.ValueMember = "IdChucVu";

        }
        #endregion

        #region LoadPhongBan
        private void  LoadPhongBan()
        {
            cboPhongBanS.DataSource = DMPhongBanDataProvider.Instance.GetListPhongBanPairInfo();
            cboPhongBanS.DisplayMember = "TenPhongBan";
            cboPhongBanS.ValueMember = "IdPhongBan";
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            dgvList.DataSource = DmNhanVienDataProvider.GetListDmNhanVienInfor();
        }
        #endregion

        #region ReLoad
        public  void  ReLoad()
        {
            LoadData();
            dgvList.Refresh();
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if(MessageBox.Show("Bạn có muốn xóa bản ghi này ?","thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Kho_NhanVienDelInfo kho = new Kho_NhanVienDelInfo();
                //kho.IdNhanVien = OidNhanVien;
                //Kho_NhanVienDataProvider.Delete(new Kho_NhanvienInfo { IdNhanVien = OidNhanVien });
                //DmNhanVienInfo nv = new DmNhanVienInfo();

                //nv.IdNhanVien = OidNhanVien;
                DmNhanVienDataProvider.Delete(new DMNhanVienInfo { IdNhanVien = OidNhanVien });
                MessageBox.Show("Xóa thành công bản ghi !");
                LoadData();
                SetControl(false);
            }
        }
        #endregion

        #region dgvListGent
        private void dgvListGent()
        {
            dgvList.AutoGenerateColumns = true;
            dgvList.ReadOnly = true;
            dgvList.AllowUserToAddRows = false;

            dgvList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvList.GridColor = SystemColors.ActiveBorder;
            dgvList.RowHeadersVisible = false;
            dgvList.RowHeadersVisible = false;

            //dgvList.Rows.Clear();
            dgvList.Columns.Clear();

            //DataGridViewTextBoxColumn colSTT = new DataGridViewTextBoxColumn();
            //colSTT.Name = "STT";
            //colSTT.HeaderText = "STT";
            //colSTT.SortMode = DataGridViewColumnSortMode.NotSortable;
            //colSTT.Width = 50;
            //colSTT.ReadOnly = true;
            //colSTT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //colSTT.DataPropertyName = "SoTT";
            //dgvList.Columns.Add(colSTT);

            DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            colID.Name = "ID";
            colID.HeaderText = "ID";
            colID.SortMode = DataGridViewColumnSortMode.NotSortable;
            colID.ReadOnly = true;
            colID.Visible = false;
            colID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colID.DataPropertyName = "IdNhanVien";
            dgvList.Columns.Add(colID);

            DataGridViewTextBoxColumn colMa = new DataGridViewTextBoxColumn();
            colMa.Name = "MaNhanVien";
            colMa.HeaderText = "Mã nhân viên";
            //colMa.SortMode = DataGridViewColumnSortMode.NotSortable;
            colMa.Width = 110;
            colMa.ReadOnly = true;
            colMa.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMa.DataPropertyName = "MaNhanVien";
            dgvList.Columns.Add(colMa);

            DataGridViewTextBoxColumn colTen = new DataGridViewTextBoxColumn();
            colTen.Name = "HoTen";
            colTen.HeaderText = "Họ tên";
            colTen.ValueType = typeof(string);
            //colTen.SortMode = DataGridViewColumnSortMode.NotSortable;
            colTen.Width = 203;
            colTen.ReadOnly = true;
            colTen.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colTen.DataPropertyName = "HoTen";
            colTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTen.MinimumWidth = 200;
            dgvList.Columns.Add(colTen);

            DataGridViewTextBoxColumn colNgaySinh = new DataGridViewTextBoxColumn();
            colNgaySinh.Name = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.Visible = false;
            colNgaySinh.DataPropertyName = "NgaySinh";
            dgvList.Columns.Add(colNgaySinh);

            DataGridViewTextBoxColumn colGioiTinh = new DataGridViewTextBoxColumn();
            colGioiTinh.Name = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.Width = 0;
            colGioiTinh.Visible = false;
            colGioiTinh.DataPropertyName = "GioiTinh";
            dgvList.Columns.Add(colGioiTinh);

            DataGridViewTextBoxColumn colNhom = new DataGridViewTextBoxColumn();
            colNhom.Name = "PhongBan";
            colNhom.HeaderText = "Phòng ban";
            colNhom.ValueType = typeof(string);
            colNhom.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNhom.Width = 150;
            colNhom.ReadOnly = true;
            colNhom.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //colNhom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNhom.MinimumWidth = 150;
            colNhom.DataPropertyName = "TenPhongBan";
            dgvList.Columns.Add(colNhom);

            DataGridViewTextBoxColumn colChucVu = new DataGridViewTextBoxColumn();
            colChucVu.Name = "ChucVu";
            colChucVu.HeaderText = "Chức vụ";
            colChucVu.ValueType = typeof(string);
            colChucVu.SortMode = DataGridViewColumnSortMode.NotSortable;
            colChucVu.Width = 150;
            colChucVu.ReadOnly = true;
            colChucVu.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //colChucVu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colChucVu.MinimumWidth = 150;
            colChucVu.DataPropertyName = "TenChucVu";
            dgvList.Columns.Add(colChucVu);

            DataGridViewTextBoxColumn colDiaChi = new DataGridViewTextBoxColumn();
            colDiaChi.Name = "DiaChi";
            colDiaChi.HeaderText = "Địa chỉ";
            colDiaChi.Visible = false;
            colDiaChi.DataPropertyName = "DiaChi";
            //colDiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //colDiaChi.MinimumWidth = 200;
            dgvList.Columns.Add(colDiaChi);

            DataGridViewTextBoxColumn colDienThoai = new DataGridViewTextBoxColumn();
            colDienThoai.Name = "DienThoai";
            colDienThoai.HeaderText = "Điện thoại";
            colDienThoai.Visible = false;
            colDienThoai.DataPropertyName = "DienThoai";
            dgvList.Columns.Add(colDienThoai);

            DataGridViewCheckBoxColumn colSuDung = new DataGridViewCheckBoxColumn();
            colSuDung.Name = "SuDung";
            colSuDung.HeaderText = "Sử dụng";
            colSuDung.Width = 60;
            colSuDung.ReadOnly = true;
            colSuDung.SortMode = DataGridViewColumnSortMode.NotSortable;
            colSuDung.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSuDung.DataPropertyName = "SuDung";
            dgvList.Columns.Add(colSuDung);

            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "Email";
            colEmail.HeaderText = "Email";
            colEmail.Visible = false;
            colEmail.DataPropertyName = "Email";
            dgvList.Columns.Add(colEmail);

            DataGridViewTextBoxColumn colGhiChu = new DataGridViewTextBoxColumn();
            colGhiChu.Name = "GhiChu";
            colGhiChu.HeaderText = "Ghi chú";
            colGhiChu.Visible = false;
            colGhiChu.DataPropertyName = "GhiChu";
            dgvList.Columns.Add(colGhiChu);

            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.MultiSelect = false;
            dgvList.AutoGenerateColumns = false;
        }
        #endregion

        //#region Search
        //private bool Search(DmNhanVienGridInfo dmNVInfor)
        //{
        //    return (txtFilterMa.Text.Trim() == String.Empty || (txtFilterMa.Text.Trim() != String.Empty &&
        //            dmNVInfor.MaNhanVien.ToLower().Contains(txtFilterMa.Text.Trim().ToLower())))
        //           && (txtFilterTen.Text.Trim() == String.Empty || (txtFilterTen.Text.Trim() != String.Empty &&
        //               dmNVInfor.HoTen.ToLower().Contains(txtFilterTen.Text.Trim().ToLower())))
        //               && (cboChucDanhS.Text.Trim() == String.Empty || (cboChucDanhS.Text.Trim() != String.Empty &&
        //               dmNVInfor.IdChucVu == Convert.ToInt32(cboChucDanhS.SelectedValue.ToString())))
        //               && (cboPhongBanS.Text.Trim() == String.Empty || (cboPhongBanS.Text.Trim() != String.Empty &&
        //               dmNVInfor.IdPhongBan == Convert.ToInt32(cboPhongBanS.SelectedValue.ToString())));

        //}
        //#endregion

        #region SetControl
        public void SetControl(bool var)
        {
            btnXoa.Enabled = var;
            btnCapNhat.Enabled = var;
        }
        #endregion

        #endregion

        private void frmDM_NhanVien_Load(object sender, EventArgs e)
        {
            dgvList.Sorted += new System.EventHandler(this.dgvDanhSachNhanvien_Sorted);
            SetControl(false);
            LoadChucVu();
            LoadPhongBan();
            LoadData();
        }

        private void DanhMuc_CapNhatSoTT()
        {
            if (dgvList.Rows.Count > 0)
            {
                for (int i = 0; i <= dgvList.Rows.Count - 1; i++)
                {
                    dgvList.Rows[i].Cells[0].Value = i+1;
                }
            }
        }

        private void dgvDanhSachNhanvien_Sorted(object sender, EventArgs e)
        {
            try
            {
                this.DanhMuc_CapNhatSoTT();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            #region old
            //if (dgvList.Rows.Count > 0)
            //{
            //    //GridIndex = dgvList.CurrentCell.RowIndex;
            //    ActionType = false;
            //    txtMaNhanVien.Enabled = false;
            //    txtIdNhanVien.Text = dgvList.Rows[dgvList.CurrentCell.RowIndex].Cells[1].Value.ToString();
            //    txtMaNhanVien.Text = dgvList.Rows[dgvList.CurrentCell.RowIndex].Cells[2].Value.ToString();
            //    txtHoTen.Text = dgvList.Rows[dgvList.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //    txtNgaySinh.Text = dgvList.Rows[dgvList.CurrentCell.RowIndex].Cells[4].Value.ToString();
            //    if (dgvList[5, dgvList.CurrentRow.Index].Value.ToString() == "True")
            //    {
            //        optNam.Checked = true;
            //        optNu.Checked = false;
            //    }
            //    else
            //    {
            //        optNam.Checked = false;
            //        optNu.Checked = true;
            //    }
            //    cboPhongBan.Text = dgvList.Rows[dgvList.CurrentCell.RowIndex].Cells[6].Value.ToString();
            //    cboChucVu.Text = dgvList.Rows[dgvList.CurrentCell.RowIndex].Cells[7].Value.ToString();
            //    txtDiaChi.Text = dgvList.Rows[dgvList.CurrentCell.RowIndex].Cells[8].Value.ToString();
            //    txtDienThoai.Text = dgvList.Rows[dgvList.CurrentCell.RowIndex].Cells[9].Value.ToString();
            //    chkSuDung.Checked = Common.BoolValue(dgvList[10, dgvList.CurrentRow.Index].Value.ToString());
            //    txtEmail.Text = dgvList[11, dgvList.CurrentRow.Index].Value.ToString();
            //    txtGhiChu.Text = dgvList[12, dgvList.CurrentRow.Index].Value.ToString();

            //    SetCheckListKho();
            //}
            //else
            //{
            //    txtMaNhanVien.Text = "";
            //    txtHoTen.Text = "";
            //    txtNgaySinh.Text = "";
            //    optNam.Checked = true;
            //    cboPhongBan.Text = "";
            //    cboChucVu.Text = "";
            //    txtDiaChi.Text = "";
            //    txtDienThoai.Text = "";
            //    chkSuDung.Checked = false;
            //}
            #endregion

            //if (dgvList.Rows.Count > 0)
            //{
            //    OidNhanVien = int.Parse(dgvList.Rows[dgvList.CurrentCell.RowIndex].Cells["IdNhanVien"].ToString());
            //}
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //isAdd = true;
            //frmChiTiet_NhanVien frm = new frmChiTiet_NhanVien(this);
            //frm.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            #region OLD
            //if (txtMaNhanVien.Text == "")
            //{
            //    MessageBox.Show("Mã nhân viên chưa nhập."+"\n"+"-Hãy nhập mã nhân viên", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtMaNhanVien.Focus();
            //    return;
            //}
            //if (txtMaNhanVien.Text == "")
            //{
            //    MessageBox.Show("Mã nhân viên chưa nhập."+"\n"+"-Hãy nhập mã nhân viên", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtMaNhanVien.Focus();
            //    return;
            //}
            //if (txtHoTen.Text == "")
            //{
            //    MessageBox.Show("Tên nhân viên chưa nhập." + "\n" + "-Hãy nhập tên nhân viên", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtHoTen.Focus();
            //    return;
            //}

            //
            //Sự hợp lệ của thông tin ngày xuất
            //
            //if (this.txtNgaySinh.Text.Trim().Length == 4)
            //{
            //    MessageBox.Show("Ngày sinh chưa nhập." + "\n" + "-Hãy nhập ngày sinh", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.txtNgaySinh.Focus();
            //    return ;
            //}
            //if (this.txtNgaySinh.Text.Trim().Length > 4 && this.txtNgaySinh.Text.Trim().Length < 10)
            //{
            //    MessageBox.Show("Ngày sinh nhập chưa đúng." + "\n" + "-Hãy nhập lại ngày sinh", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.txtNgaySinh.Focus();
            //    return ;
            //}
            //if (!Common.IsValidDate(txtNgaySinh.Text.Trim()))
            //{
            //    MessageBox.Show(Declare.msgDateTimeValid, Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.txtNgaySinh.Focus();
            //    return ;
            //}
            //if (Common.ParseDate(txtNgaySinh.Text.Trim())>=Common.ParseDate(DateTime.Today.Day.ToString()+"/"+DateTime.Today.Month.ToString()+"/"+DateTime.Today.Year.ToString()))
            //{
            //    MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại."+"\n"+"-Hãy nhập lại ngày sinh", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    this.txtNgaySinh.Focus();
            //    return ;
            //}
//            if (cboPhongBan.Text.Trim().Length == 0)
//            {
//                MessageBox.Show("Phòng ban chưa chọn." + "\n" + "-Hãy chọn phòng ban", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                cboPhongBan.Focus();
//                return;
//            }
//            if (cboChucVu.Text.Trim().Length == 0)
//            {
//                MessageBox.Show("Chức vụ chưa chọn." + "\n" + "-Hãy chọn chức vụ", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                cboChucVu.Focus();
//                return;
//            }

//            if (this.txtEmail.Text.Trim().Length > 0)
//                if (Common.ValidEmail(this.txtEmail.Text.Trim()) == false) {
//                    MessageBox.Show(Declare.msgValidateEmail, Declare.titleWarning, MessageBoxButtons.OK);
//                    this.txtEmail.Focus();
//                    return;
//                }

            
//            try
//            {
//                chklstKho.EndUpdate();
//                string sql;
//                byte InUse;
//                int GioiTinh = optNam.Checked ? 1 : 0;
//                ListItem selectedPhongBan = (ListItem)cboPhongBan.SelectedItem;

//                if (chkSuDung.Checked.ToString() == "True")
//                    InUse = 1;
//                else
//                    InUse = 0;
                
//                string strSqlTen = "Select * from tbl_DM_NhanVien where HoTen"
//                + "=N'" + this.txtHoTen.Text.Trim() + "' and IdPhongBan = " + selectedPhongBan.ItemData.ToString()
//                + " and GioiTinh=" + GioiTinh + (String.IsNullOrEmpty(txtIdNhanVien.Text) ? String.Empty : (" and IdNhanVien <> " + txtIdNhanVien.Text));

//                if (DBTools.ExistData(strSqlTen)) {
//                    MessageBox.Show("Trong một phòng không thể có 2 nhân viên cùng tên và cùng chức năng." + "\n" + "-Hãy nhập lại tên (thêm A, B,..) hoặc chọn lại chức năng", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    this.txtHoTen.Focus();
//                    return;
//                }

//                if (ActionType || dgvList.RowCount == 0)
//                {

//                    if (cboChucVu.SelectedItem != null)
//                        strSqlTen += " and IdChucVu=" + (cboChucVu.SelectedItem as ListItem).ItemData;
                    
//                    if (DBTools.ExistData("tbl_DM_NhanVien", "MaNhanVien", typeof(string), txtMaNhanVien.Text.Trim()))
//                    {
//                        MessageBox.Show("Mã nhân viên đã tồn tại." + "\n" + "-Hãy nhập lại mã nhân viên", Declare.titleWarning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                        txtMaNhanVien.Focus();
//                        return;
//                    }

//                    //sql = "Insert Into tbl_DM_NhanVien(MaNhanVien, HoTen, NgaySinh, GioiTinh, IdNhomNguoiDung, DiaChi, DienThoai, SuDung) " + 
//                    //        "Values('" + txtMaNhanVien.Text + "', N'" + txtHoTen.Text + "', '" + txtNgaySinh.Text + "', " + GioiTinh + ", " + selectedNhomChucNang.ItemData + ", N'" + txtDiaChi.Text + "', '" + txtDienThoai.Text + "', " + InUse + ")";
//                    //SqlConnection SqlConn = Connection.Instance.GetSqlConnection();
//                    //if (!(SqlConn.State == ConnectionState.Open)) SqlConn.Open();

//                    try
//                    {
//                        //sql = "Insert Into tbl_DM_NhanVien(MaNhanVien, HoTen, NgaySinh, GioiTinh, IdNhomNguoiDung, DiaChi, DienThoai, SuDung) " +
//                        //        "Values(@MaNhanVien, @HoTen, @NgaySinh, @GioiTinh, @IdNhomNguoiDung, @DiaChi, @DienThoai, @SuDung";

//                        GtidCommand SqlCmd = ConnectionUtil.Instance.GetConnection().CreateCommand();
//                        SqlCmd.CommandText = "sp_DM_NhanVien_Insert";
//                        SqlCmd.CommandType = CommandType.StoredProcedure;
//                        SqlCmd.Parameters.AddWithValue("@IdNhanVien", 0).Direction = ParameterDirection.Output;
//                        SqlCmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@NgaySinh", txtNgaySinh.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@GioiTinh", GioiTinh).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@IdPhongBan", Common.IntValue(selectedPhongBan.ItemData.ToString())).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@IdChucVu", Common.IntValue(((ListItem)cboChucVu.SelectedItem).ItemData.ToString())).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text).Direction = ParameterDirection.Input;
//                        SqlCmd.Parameters.AddWithValue("@SuDung", InUse).Direction = ParameterDirection.Input;
//                        SqlCmd.ExecuteNonQuery();

//                        object[] arrMang ={ dgvList.Rows.Count + 1, SqlCmd.Parameters[0].Value, txtMaNhanVien.Text, txtHoTen.Text, txtNgaySinh.Text, GioiTinh, cboPhongBan.Text, 
//                                            cboChucVu.Text, txtDiaChi.Text, txtDienThoai.Text, InUse, txtEmail.Text,txtGhiChu.Text };
//                        dgvList.Rows.Add(arrMang);

//                        dgvList.Rows[dgvList.Rows.Count - 1].Selected = true;
//                        txtIdNhanVien.Text = SqlCmd.Parameters[0].Value.ToString();
//                        txtMaNhanVien.Text = dgvList.Rows[dgvList.Rows.Count - 1].Cells[2].Value.ToString();
//                        txtHoTen.Text = dgvList.Rows[dgvList.Rows.Count - 1].Cells[3].Value.ToString();
//                        txtNgaySinh.Text = dgvList.Rows[dgvList.Rows.Count - 1].Cells[4].Value.ToString();
//                        cboPhongBan.Text = dgvList.Rows[dgvList.Rows.Count - 1].Cells[6].Value.ToString();
//                        cboChucVu.Text = dgvList.Rows[dgvList.Rows.Count - 1].Cells[7].Value.ToString();
//                        txtDiaChi.Text = dgvList.Rows[dgvList.Rows.Count - 1].Cells[8].Value.ToString();
//                        txtDienThoai.Text = dgvList.Rows[dgvList.Rows.Count - 1].Cells[9].Value.ToString();
//                        chkSuDung.Checked = Common.BoolValue(dgvList.Rows[dgvList.Rows.Count - 1].Cells[10].Value.ToString());
//                        int idnv = Common.IntValue(SqlCmd.Parameters[0].Value);
//                        if (idnv > 0)
//                        {
//                            foreach (ListItem item in chklstKho.CheckedItems)
//                            {
//                                DBTools.ExecuteQuery(String.Format("Insert tbl_Kho_NhanVien(IdKho, IdNhanVien) values({0},{1})", item.ItemData, idnv), CommandType.Text);
//                            }
//                        }

//                        Common.LogAction("Thêm mới danh mục nhân viên", "IdNhanVien " + arrMang[0], -1);

//                        MessageBox.Show("Thêm mới nhân viên thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        GridIndex = dgvList.Rows.Count - 1;
//                    }
//                    catch(Exception ex)
//                    {
//#if DEBUG
//                        MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#else
//                        MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//#endif
//                    }
//                    finally
//                    {
//                        //if (!(SqlConn.State == ConnectionState.Closed)) SqlConn.Close();
//                    }
//                    RefreshGrid();
//                }
//                else
//                {
//                    sql = "Update tbl_DM_NhanVien Set MaNhanVien = '" + txtMaNhanVien.Text + "', HoTen = N'" + txtHoTen.Text + "', NgaySinh = '" + txtNgaySinh.Text + "', " +
//                                "GioiTinh = " + GioiTinh + ", IdPhongBan = " + selectedPhongBan.ItemData + ", IdChucVu = " + ((ListItem)cboChucVu.SelectedItem).ItemData + ", DiaChi = N'" + txtDiaChi.Text + "', DienThoai = '" + txtDienThoai.Text + "', SuDung =" + InUse +
//                          ", Email='" + txtEmail.Text + "', GhiChu=N'" + txtGhiChu.Text + "' Where IdNhanVien = " + Common.IntValue(txtIdNhanVien.Text);

//                    if (DBTools.ExecuteQuery(sql, CommandType.Text) != null)
//                    {

//                        dgvList.Rows[dgvList.CurrentRow.Index].Cells[2].Value = txtMaNhanVien.Text;
//                        dgvList.Rows[dgvList.CurrentRow.Index].Cells[3].Value = txtHoTen.Text;
//                        dgvList.Rows[dgvList.CurrentRow.Index].Cells[4].Value = txtNgaySinh.Text;
//                        dgvList.Rows[dgvList.CurrentRow.Index].Cells[5].Value = (optNam.Checked == true ? true : false);
//                        dgvList.Rows[dgvList.CurrentRow.Index].Cells[6].Value = cboPhongBan.Text;
//                        dgvList.Rows[dgvList.CurrentRow.Index].Cells[7].Value = cboChucVu.Text;
//                        dgvList.Rows[dgvList.CurrentRow.Index].Cells[8].Value = txtDiaChi.Text;
//                        dgvList.Rows[dgvList.CurrentRow.Index].Cells[9].Value = txtDienThoai.Text;
//                        dgvList.Rows[dgvList.CurrentRow.Index].Cells[10].Value = InUse;
//                        dgvList.Rows[dgvList.CurrentRow.Index].Selected = true;
//                        sql = "Delete tbl_Kho_NhanVien where IdNhanVien=" + Common.IntValue(txtIdNhanVien.Text);
//                        if (DBTools.ExecuteQuery(sql, CommandType.Text) != null)
//                        {                
//                            foreach (ListItem item in chklstKho.CheckedItems)
//                            {
//                                sql = String.Format("Insert into tbl_Kho_NhanVien(IdKho, IdNhanVien) values({0},{1})",item.ItemData, Common.IntValue(txtIdNhanVien.Text));
//                                DBTools.ExecuteQuery(sql, CommandType.Text);
//                            }
//                        }

//                        Common.LogAction("Cập nhật danh mục nhân viên", "IdNhanVien " + txtIdNhanVien.Text, -1);

//                        MessageBox.Show("Cập nhật nhân viên thành công.", Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        GridIndex = dgvList.CurrentRow.Index;
//                    }
//                    else
//                    {
//                        MessageBox.Show(Declare.msgUpdateErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        return;
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
            #endregion
            //isAdd = false;
            //frmChiTiet_NhanVien frm = new frmChiTiet_NhanVien(this);
            //frm.ShowDialog();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            #region old
            //            try {
//                if (dgvList.Rows.Count > 0) {
//                    if (MessageBox.Show(Declare.msgRemoveData, Declare.titleNotice, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

//                        if (DBTools.ExecuteQuery("Delete tbl_Kho_NhanVien where IdNhanVien=" + Common.IntValue(txtIdNhanVien.Text), CommandType.Text) == null) {
//                            MessageBox.Show(Declare.msgDeleteErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        }

//                        object obj = DBTools.ExecuteQuery("Delete From tbl_DM_NhanVien Where IdNhanVien = " + Common.IntValue(txtIdNhanVien.Text), CommandType.Text);
//                        if (obj == null)
//                            MessageBox.Show(Declare.msgDeleteErr, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        else {

//                            if ((GridIndex == dgvList.Rows.Count - 1) || (dgvList.CurrentCell.RowIndex == dgvList.Rows.Count))
//                                GridIndex = GridIndex - 1;
//                            if (GridIndex < 0) GridIndex = 0;

//                            RefreshGrid();

//                            Common.LogAction("Xóa danh mục nhân viên", "IdNhanVien " + txtIdNhanVien.Text, -1);

//                            MessageBox.Show(Declare.msgDeleteSucc, Declare.titleNotice, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        }
//                    }
//                }
//            }
//            catch (System.Exception ex) {
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_CHAR_A_Z_a_z_0_9);
                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_TOUPPER);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNhomChucNang_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (e.KeyCode == Keys.F4)
            //    {
            //        frmDM_Chung frm = new frmDM_Chung("frmDM_NhomChucNang");
            //        frm.ShowDialog();

            //        int Index = this.cboPhongBan.SelectedIndex;

            //        DBTools.List_LoadData(cboPhongBan, "Select IdNhomChucNang, TenNhomChucNang From tbl_DM_NhomChucNang Where SuDung = 1", "IdNhomChucNang", "TenNhomChucNang", "", 1);

            //        if (Index < this.cboPhongBan.Items.Count - 1)
            //            this.cboPhongBan.SelectedIndex = Index;
            //        else
            //            this.cboPhongBan.SelectedIndex = this.cboPhongBan.Items.Count - 1;

            //        e.Handled = true;
            //        frm.Dispose();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ:" + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cboChucVu_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (e.KeyCode == Keys.F4)
            //    {
            //        frmDM_Chung frm = new frmDM_Chung("frmDM_ChucVu");
            //        frm.ShowDialog();

            //        int Index = this.cboChucVu.SelectedIndex;

            //        DBTools.List_LoadData(cboChucVu, "Select IdChucVu, TenChucVu From tbl_DM_ChucVu Where SuDung = 1", "IdChucVu", "TenChucVu", "", 1);

            //        if (Index < this.cboChucVu.Items.Count - 1)
            //            this.cboChucVu.SelectedIndex = Index;
            //        else
            //            this.cboChucVu.SelectedIndex = this.cboChucVu.Items.Count - 1;

            //        e.Handled = true;
            //        frm.Dispose();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ:" + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            #region old
            //            try {
//                string dk = "1=1";
//                if (!String.IsNullOrEmpty(txtFilterMa.Text)) {
//                    dk += String.Format(" and tbl_DM_NhanVien.MaNhanVien like '%{0}%'", txtFilterMa.Text);
//                }

//                if (!String.IsNullOrEmpty(txtFilterTen.Text)) {
//                    dk += String.Format(" and tbl_DM_NhanVien.HoTen like N'%{0}%'", txtFilterTen.Text);
//                }

//                if (cboPhongBanS.SelectedValue != null)
//                {
//                    dk += String.Format(" and tbl_DM_NhanVien.IdPhongBan = {0}", cboPhongBanS.SelectedValue);
//                }
//                if (cboChucDanhS.SelectedValue != null)
//                {
//                    dk += String.Format(" and tbl_DM_NhanVien.IdChucVu = {0}", cboChucDanhS.SelectedValue);
//                }

//                string sql = "SELECT     tbl_DM_NhanVien.IdNhanVien, tbl_DM_NhanVien.MaNhanVien, tbl_DM_NhanVien.HoTen, tbl_DM_NhanVien.NgaySinh, " +
//                            "tbl_DM_NhanVien.GioiTinh, tbl_DM_PhongBan.TenPhongBan, tbl_DM_ChucVu.TenChucVu, tbl_DM_NhanVien.DiaChi, tbl_DM_NhanVien.DienThoai, tbl_DM_NhanVien.SuDung, tbl_DM_NhanVien.Email, tbl_DM_NhanVien.GhiChu " +
//                "FROM         tbl_DM_NhanVien LEFT OUTER JOIN " +
//                            "tbl_DM_PhongBan ON tbl_DM_NhanVien.IdPhongBan = tbl_DM_PhongBan.IdPhongBan LEFT OUTER JOIN " +
//                            "tbl_DM_ChucVu ON tbl_DM_NhanVien.IdChucVu = tbl_DM_ChucVu.IdChucVu where " + dk;
//                DBTools.GridView_LoadData(dgvList, sql, true);
//                int index;
//                if (GridIndex == -1 || GridIndex >= dgvList.Rows.Count)
//                    index = 0;
//                else
//                    index = GridIndex;

//                if (dgvList.Rows.Count > 0) {
//                    dgvList.Rows[index].Selected = true;
//                    txtIdNhanVien.Text = dgvList[1, index].Value.ToString();
//                    txtMaNhanVien.Text = dgvList[2, index].Value.ToString();
//                    txtHoTen.Text = dgvList[3, index].Value.ToString();
//                    txtNgaySinh.Text = dgvList[4, index].Value.ToString();
//                    if (dgvList[5, index].Value.ToString() == "True") {
//                        optNam.Checked = true;
//                        optNu.Checked = false;
//                    }
//                    else {
//                        optNam.Checked = false;
//                        optNu.Checked = true;
//                    }
//                    cboPhongBan.Text = (dgvList[6, index].Value.ToString() == "") ? dgvList[6, index].Value.ToString() : "";
//                    cboChucVu.Text = (dgvList[7, index].Value.ToString() == "") ? dgvList[7, index].Value.ToString() : "";
//                    txtDiaChi.Text = dgvList[8, index].Value.ToString();
//                    txtDienThoai.Text = dgvList[9, index].Value.ToString();
//                    chkSuDung.Checked = Common.BoolValue(dgvList[10, index].Value.ToString());
//                    txtEmail.Text = dgvList[11, index].Value.ToString();
//                    txtGhiChu.Text = dgvList[12, index].Value.ToString();

//                    SetCheckListKho();
//                }
//                else {
//                    txtIdNhanVien.Text = "";
//                    txtMaNhanVien.Text = "";
//                    txtHoTen.Text = "";
//                    txtNgaySinh.Text = "";
//                    txtDiaChi.Text = "";
//                    txtDienThoai.Text = "";
//                    chkSuDung.Checked = false;
//                }
//            }
//            catch (System.Exception ex) {
//#if DEBUG
//                MessageBox.Show(ex.ToString());
//#else
//                MessageBox.Show(ex.Message);
//#endif
            //            }
            #endregion
            DMNhanVienInfo dm = new DMNhanVienInfo();
            dm.HoTen = txtFilterTen.Text.Trim();
            dm.MaNhanVien = txtFilterMa.Text.Trim();
            dm.IdChucVu = Convert.ToInt32(cboChucDanhS.SelectedValue.ToString());
            dm.IdPhongBan = Convert.ToInt32(cboPhongBanS.SelectedValue.ToString());
            dgvList.DataSource = DmNhanVienDataProvider.Search(dm);
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            try {
                Common.ValdateCharInTextBox_Keypress(ref sender, ref e, Common.strValidate.STR_PHONE);
            }
            catch (Exception ex) {
#if DEBUG
                MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvList.Rows.Count > 0)
            {
                SetControl(true);
                OidNhanVien = int.Parse(dgvList.Rows[dgvList.CurrentCell.RowIndex].Cells["ID"].Value.ToString());
            }
        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            //isAdd = false;
            //frmChiTiet_NhanVien frm = new frmChiTiet_NhanVien(this);
            //frm.ShowDialog();
        }
    }
}