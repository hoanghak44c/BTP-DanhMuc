using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_DongBo : Form
    {
        DataSet ds;
        Thread importThread;
        //SqlConnection SqlConn;
        GtidCommand SqlComm;
        //SqlTransaction SqlTran;

        public frmDM_DongBo()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }


        private delegate void SetStatusDelegate(string value);
        private SetStatusDelegate dgSetStatus;
        private void SetStatus(string value)
        {
            lblStatus.Text = value;
        }
        private string Status
        {
            set
            {
                this.Invoke(dgSetStatus, value);
            }
        }

        private delegate void SetProgressValueDelegate(int value);
        private SetProgressValueDelegate dgSetProgressMaxValue;
        private void SetProgressMaxValue(int value)
        {
            progressBar1.Maximum = value;
        }
        private int ProgressMaxValue
        {
            set
            {
                this.Invoke(dgSetProgressMaxValue, value);
            }
        }

        private SetProgressValueDelegate dgSetProgressCurValue;
        private void SetProgressCurValue(int value)
        {
            progressBar1.Value = value;
        }
        private int ProgressCurrentValue
        {
            set
            {
                this.Invoke(dgSetProgressCurValue, value);
            }
            get
            {
                return progressBar1.Value;
            }
        }

        private delegate void DisableChapNhanButtonDelegate(bool value);
        private DisableChapNhanButtonDelegate dgDisableChapNhanButton;
        private void SetChapNhanButtonEnableState(bool value){
            btnChapNhan.Enabled = value;
        }
        private bool ChapNhanEnableState {
            get { return btnChapNhan.Enabled; }
            set { this.Invoke(dgDisableChapNhanButton, value); }
        }

        private delegate void CloseFormDelegate();
        private CloseFormDelegate dgCloseForm;
        private void CloseFormWithThread() {
            if (dgCloseForm == null)
                dgCloseForm = new CloseFormDelegate(this.Close);
            this.Invoke(dgCloseForm);
        }


        private void Import()
        {
            try {
                //SqlConn.Open();
                //SqlTran = SqlConn.BeginTransaction();
                SqlComm.Transaction = ConnectionUtil.Instance.BeginTransaction();

                ChapNhanEnableState = false;
                Status = "Đang xử lý";
                string[,] fieldAndFormats;

                if (!String.IsNullOrEmpty(txtTrungTam.Text)) {
                    LoadDistinctData(txtTrungTam.Text, "ORG_CODE_INV", "CODE", "NAME");
                    fieldAndFormats = new string[,] { 
                    { "CODE", "MaTrungTam", "N'{0}'" }, 
                    { "NAME", "TenTrungTam", "N'{1}'" } };
                    ImportDanhMuc("ORG_CODE_INV", "tbl_DM_TrungTam", fieldAndFormats);
                }
                if (!String.IsNullOrEmpty(txtKho.Text)) {
                    LoadDistinctData(txtKho.Text, "SUBINVENTORY", "CODE", "NAME", "CODE_TRUNGTAM");
                    fieldAndFormats = new string[,] { 
                    { "CODE", "MaKho", "N'{0}'" }, 
                    { "NAME", "TenKho", "N'{1}'" },
                    { "CODE_TRUNGTAM", "IdTrungTam", "{2}" } };
                    ImportDanhMuc("SUBINVENTORY", "tbl_DM_Kho", fieldAndFormats);
                    UpdateDanhMucKho("SUBINVENTORY", "tbl_DM_Kho", fieldAndFormats);
                }
                if (!String.IsNullOrEmpty(txtKhachHang.Text)) {
                    LoadDistinctData(txtKhachHang.Text, "Customer", "CODE", "NAME", "TAX");
                    fieldAndFormats = new string[,] { 
                    { "CODE", "MaDoiTuong", "N'{0}'" }, 
                    { "NAME", "TenDoiTuong", "N'{1}'" },
                    { "TAX", "MaSoThue", "'{2}'" },
                    { "TAX", "Type", "0" } };
                    ImportDanhMuc("Customer", "tbl_DM_DoiTuong", fieldAndFormats);

                    LoadData(txtKhachHang.Text, "Customer", "CODE", "SITE_NUMBER", "ADDRESS1");
                    fieldAndFormats = new string[,] { 
                    { "SITE_NUMBER", "SiteNumber", "N'{0}'" }, 
                    { "ADDRESS1", "DiaChi", "N'{1}'" },
                    { "CODE", "IdDoiTuong", "{2}" }};
                    UpdateDanhMucKhachHang("Customer", "tbl_DM_DoiTuong_DiaChi", fieldAndFormats);
                }

                if (!String.IsNullOrEmpty(txtDonViTinh.Text)) {
                    LoadData(txtDonViTinh.Text, "Đơn Vị Tính", "CODE", "NAME");
                    fieldAndFormats = new string[,] { 
                    { "CODE", "KyHieu", "N'{0}'" }, 
                    { "NAME", "TenDonViTinh", "N'{1}'" } };
                    ImportDanhMuc("Đơn Vị Tính", "tbl_DM_DonViTinh", fieldAndFormats);
                }

                if (!String.IsNullOrEmpty(txtSanPham.Text)) {
                    LoadData(txtSanPham.Text, "Item", "CODE", "NAME", "CODE_DVT");
                    fieldAndFormats = new string[,] { 
                    { "CODE", "MaSanPham", "N'{0}'" }, 
                    { "NAME", "TenSanPham", "N'{1}'" } };
                    ImportDanhMuc("Item", "tbl_SanPham", fieldAndFormats);
                    fieldAndFormats = new string[,] { 
                    { "CODE", "MaSanPham", "N'{0}'" }, 
                    { "NAME", "TenSanPham", "N'{1}'" },
                    { "CODE_DVT", "MaSanPham", "N'{0}'" }};
                    UpdateDanhMucSanPham("Item", "tbl_SanPham", fieldAndFormats);
                }

                if (!String.IsNullOrEmpty(txtOrderType.Text)) {
                    LoadData(txtOrderType.Text, "ORDER TYPE", "CODE", "NAME");
                    fieldAndFormats = new string[,] { 
                    { "CODE", "Code", "N'{0}'" }, 
                    { "NAME", "Name", "N'{1}'" } };
                    ImportDanhMuc("ORDER TYPE", "tbl_DM_OrderType", fieldAndFormats);
                }

                if (!String.IsNullOrEmpty(txtPayment.Text)) {
                    LoadData(txtPayment.Text, "Payment Term", "CODE", "NAME");
                    fieldAndFormats = new string[,] { 
                    { "CODE", "KyHieu", "N'{0}'" }, 
                    { "NAME", "Ten", "N'{1}'" },
                    { "NAME", "Type", "0" }};
                    ImportDanhMuc("Payment Term", "tbl_DM_LoaiThuChi", fieldAndFormats);
                }

                if (!String.IsNullOrEmpty(txtNhanVien.Text)) {
                    LoadData(txtNhanVien.Text, "Sale Person", "CODE", "NAME");
                    fieldAndFormats = new string[,] { 
                    { "CODE", "MaNhanVien", "N'{0}'" }, 
                    { "NAME", "HoTen", "N'{1}'" } };
                    ImportDanhMuc("Sale Person", "tbl_DM_NhanVien", fieldAndFormats);
                }

                if (!String.IsNullOrEmpty(txtTaxCode.Text)) {
                    LoadData(txtTaxCode.Text, "Taxcode", "CODE", "NAME");
                    fieldAndFormats = new string[,] { 
                    { "CODE", "MaBieuThue", "N'{0}'" }, 
                    { "NAME", "TenBieuThue", "N'{1}'" } };
                    ImportDanhMuc("Taxcode", "tbl_DM_BieuThue", fieldAndFormats);
                }
                ConnectionUtil.Instance.CommitTransaction();
                //SqlTran.Commit();
                //SqlConn.Close();
                Status = "Hoàn thành";
                ChapNhanEnableState = true;
            }
            catch (ThreadAbortException ex)
            {
                ConnectionUtil.Instance.RollbackTransaction();
                ChapNhanEnableState = true;
                CloseFormWithThread();
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
            catch (OleDbException ex) {
                ConnectionUtil.Instance.RollbackTransaction();
                ChapNhanEnableState = true;
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
            catch (Exception ex) {
                ConnectionUtil.Instance.RollbackTransaction();
                ChapNhanEnableState = true;
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }


        private void LoadDistinctData(string sourceFie, string workSheetName, params string[] columns)
        {
            Status = String.Format("Nạp dữ liệu từ {0}", sourceFie);
            using (OleDbConnection oConn = new OleDbConnection()) {
                oConn.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes\"", sourceFie);
                oConn.Open();
                string fields = String.Empty;
                Array.ForEach(columns,
                delegate(string s)
                {
                    fields += String.IsNullOrEmpty(fields) ? String.Format("[{0}]", s) : String.Format(", [{0}]", s);
                });
                using (OleDbDataAdapter ad = new OleDbDataAdapter(String.Format("Select distinct {0} from [{1}$]", fields, workSheetName), oConn)) {
                    if (ds == null)
                        ds = new DataSet();
                    foreach (DataTable dt in ds.Tables)
                        if (dt.TableName == workSheetName) {
                            ds.Tables.Remove(dt);
                            break;
                        }
                    ad.Fill(ds, workSheetName);
                }
                oConn.Close();
            }
        }

        private void LoadData(string sourceFie, string workSheetName, params string[] columns)
        {
            Status = String.Format("Nạp dữ liệu từ {0}", sourceFie);
            using (OleDbConnection oConn = new OleDbConnection()) {
                oConn.ConnectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes\"", sourceFie);
                oConn.Open();
                string fields = String.Empty;
                Array.ForEach(columns,
                delegate(string s)
                {
                    fields += String.IsNullOrEmpty(fields) ? String.Format("[{0}]", s) : String.Format(", [{0}]", s);
                });
                using (OleDbDataAdapter ad = new OleDbDataAdapter(String.Format("Select {0} from [{1}$]", fields, workSheetName), oConn)) {
                    if (ds == null)
                        ds = new DataSet();
                    foreach (DataTable dt in ds.Tables)
                        if (dt.TableName == workSheetName) {
                            ds.Tables.Remove(dt);
                            break;
                        }
                    ad.Fill(ds, workSheetName);
                }
                oConn.Close();
            }
        }

        private void ImportDanhMuc(string workSheetName, string tableName, string[,] fieldAndFormats)
        {
            if (chkDeleteData.Checked)
            {
                Status = String.Format("Xóa bảng {0}", tableName);
                SqlComm.CommandText = String.Format("Delete from {0}", tableName);
                SqlComm.ExecuteNonQuery();

                SqlComm.CommandText = String.Format("DBCC CHECKIDENT ( {0}, RESEED, 0 ) ", tableName);
                SqlComm.ExecuteNonQuery();
            }

            Status = String.Format("Nạp dữ liệu cho bảng {0}", tableName);

            string sqlFormat = "Insert into {0}({1}, SuDung) values({2}, 1)";
            string fieldName = String.Empty;
            string format = String.Empty;
            int fieldCount = fieldAndFormats.Length / 3;

            for (int i = 0; i < fieldCount; i++) {
                fieldName += String.IsNullOrEmpty(fieldName) ? fieldAndFormats[i, 1] : String.Format(", {0}", fieldAndFormats[i, 1]);
                format += String.IsNullOrEmpty(format) ? fieldAndFormats[i, 2] : String.Format(", {0}", fieldAndFormats[i, 2]);
            }

            sqlFormat = String.Format(sqlFormat, tableName, fieldName, format);

            ProgressMaxValue = ds.Tables[workSheetName].Rows.Count;
            ProgressCurrentValue = 0;
            foreach (DataRow dr in ds.Tables[workSheetName].Rows) {
                object[] objParams = new object[fieldCount];

                for (int i = 0; i < fieldCount; i++) {
                    if (dr[fieldAndFormats[i, 0]] != DBNull.Value)
                        objParams[i] = Escape(dr[fieldAndFormats[i, 0]].ToString());
                    else
                        objParams[i] = DBNull.Value;
                }
                SqlComm.CommandText = String.Format(sqlFormat, objParams);
                SqlComm.ExecuteNonQuery();
                ProgressCurrentValue += 1;
            }
            Common.LogAction(String.Format("Khởi tạo dữ liệu bảng {0}", tableName), "Completed.", -1);
        }

        private void UpdateDanhMucKho(string workSheetName, string tableName, string[,] fieldAndFormats)
        {
            Status = "Cập nhật danh mục thông tin trung tâm";
            //Connection objConn = new Connection();
            //using (SqlConnection SqlConn = objConn.GetSqlConnection()) {

                //SqlConn.Open();
                int fieldCount = fieldAndFormats.Length / 3;


                ProgressMaxValue = ds.Tables[workSheetName].Rows.Count;
                ProgressCurrentValue = 0;
                foreach (DataRow dr in ds.Tables[workSheetName].Rows) {

                    SqlComm.CommandText = String.Format("Select IdTrungTam from tbl_DM_TrungTam where MaTrungTam=N'{0}'", dr[fieldAndFormats[2, 0]]);

                    object IdTrungTam = SqlComm.ExecuteScalar();

                    string sqlFormat = String.Format("Update {0} set IdTrungTam = {1} where IdTrungTam={2}", tableName, IdTrungTam, dr[fieldAndFormats[2, 0]]);

                    SqlComm.CommandText = sqlFormat;
                    SqlComm.ExecuteNonQuery();
                    ProgressCurrentValue += 1;
                }
                //SqlConn.Close();
            //}
        }

        private void UpdateDanhMucKhachHang(string workSheetName, string tableName, string[,] fieldAndFormats)
        {
            if (chkDeleteData.Checked)
            {

                Status = String.Format("Xóa bảng {0}", tableName);

                SqlComm.CommandText = String.Format("Delete from {0}", tableName);
                SqlComm.ExecuteNonQuery();

                SqlComm.CommandText = String.Format("DBCC CHECKIDENT ( {0}, RESEED, 0 ) ", tableName);
                SqlComm.ExecuteNonQuery();
            }
            Status = "Cập nhật địa chỉ khách hàng";

            string sqlFormat = "Insert into {0}({1}) values({2})";
            string fieldName = String.Empty;
            string format = String.Empty;
            int fieldCount = fieldAndFormats.Length / 3;

            for (int i = 0; i < fieldCount; i++) {
                fieldName += String.IsNullOrEmpty(fieldName) ? fieldAndFormats[i, 1] : String.Format(", {0}", fieldAndFormats[i, 1]);
                format += String.IsNullOrEmpty(format) ? fieldAndFormats[i, 2] : String.Format(", {0}", fieldAndFormats[i, 2]);
            }

            sqlFormat = String.Format(sqlFormat, tableName, fieldName, format);

            ProgressMaxValue = ds.Tables[workSheetName].Rows.Count;
            ProgressCurrentValue = 0;
            foreach (DataRow dr in ds.Tables[workSheetName].Rows) {

                SqlComm.CommandText = String.Format("Select IdDoiTuong from tbl_DM_DoiTuong where MaDoiTuong=N'{0}'", dr[fieldAndFormats[2, 0]]);

                object IdDoiTuong = SqlComm.ExecuteScalar();

                if (IdDoiTuong == null) continue;

                object[] objParams = new object[fieldCount];

                for (int i = 0; i < fieldCount; i++) {
                    objParams[i] = DBNull.Value;
                    if (i != 2 && dr[fieldAndFormats[i, 0]] != DBNull.Value) {
                        objParams[i] = Escape(dr[fieldAndFormats[i, 0]].ToString());
                    }
                    else if (i == 2) {
                        objParams[i] = IdDoiTuong;
                    }
                }

                try {
                    SqlComm.CommandText = String.Format(sqlFormat, objParams);
                    SqlComm.ExecuteNonQuery();
                    ProgressCurrentValue += 1;
                }
                catch (Exception ex) {
                    MessageBox.Show(SqlComm.CommandText);
                    //Common.LogAction("Khởi tạo dữ liệu bảng " + tableName, "Failed.\n " + String.Format(sqlFormat, objParams), -1);
                    throw ex;
                }
            }
        }

        private void UpdateDanhMucSanPham(string workSheetName, string tableName, string[,] fieldAndFormats)
        {
            Status = "Cập nhật đơn vị tính sản phẩm";
            //Connection objConn = new Connection();
            //using (SqlConnection SqlConn = objConn.GetSqlConnection()) {

            //SqlConn.Open();
            int fieldCount = fieldAndFormats.Length / 3;


            ProgressMaxValue = ds.Tables[workSheetName].Rows.Count;
            ProgressCurrentValue = 0;
            foreach (DataRow dr in ds.Tables[workSheetName].Rows) {
                try {

                    SqlComm.CommandText = String.Format("Select IdDonViTinh from tbl_DM_DonViTinh where KyHieu=N'{0}'", dr[fieldAndFormats[2, 0]]);

                    object IdDonViTinh = SqlComm.ExecuteScalar();
                    if (IdDonViTinh == null) continue;
                    string sqlFormat = String.Format("Update {0} set IdDonViTinh = {1} where MaSanPham=N'{2}'", tableName, IdDonViTinh, dr[fieldAndFormats[0, 0]]);

                    SqlComm.CommandText = sqlFormat;
                    SqlComm.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    MessageBox.Show(SqlComm.CommandText);
                    throw ex;
                }
                ProgressCurrentValue += 1;
            }
            //SqlConn.Close();
            //}
        }

        private string Escape(string param)
        {
            return param.Replace("'", "''"); //.Replace("\"", "\'");
        }

        private void SelectFile(TextBox txtControl) {
            openFileDialog1.FileName = "*.xls";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                if (chkUseForAll.Checked)
                    SetTextBoxValues(this, openFileDialog1.FileName);
                else
                    txtControl.Text = openFileDialog1.FileName;
            }
        }

        private void SetTextBoxValues(Control parent, string value)
        {
            foreach (Control ctl in parent.Controls) {
                if (ctl is TextBox) {
                    (ctl as TextBox).Text = value;
                }
                if (ctl.HasChildren) {
                    SetTextBoxValues(ctl, value);
                }
            }
        }

        private TextBox MapTextBoxControl(object sender) {
            if (Object.Equals(sender, btnChonTrungTam)) return txtTrungTam;
            if (Object.Equals(sender, btnDVT)) return txtDonViTinh;
            if (Object.Equals(sender, btnKhachHang)) return txtKhachHang;
            if (Object.Equals(sender, btnKho)) return txtKho;
            if (Object.Equals(sender, btnNhanVien)) return txtNhanVien;
            if (Object.Equals(sender, btnOrderType)) return txtOrderType;
            if (Object.Equals(sender, btnPayment)) return txtPayment;
            if (Object.Equals(sender, btnSanPham)) return txtSanPham;
            if (Object.Equals(sender, btnTaxCode)) return txtTaxCode;
            return null;
        }

        private void frmDM_DongBo_Load(object sender, EventArgs e)
        {
            lblStatus.Text = String.Empty;
            dgSetStatus = SetStatus;
            dgSetProgressMaxValue = SetProgressMaxValue;
            dgSetProgressCurValue = SetProgressCurValue;
            dgDisableChapNhanButton = SetChapNhanButtonEnableState;
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            lblStatus.Text = "Đang xử lý";

            SqlComm = ConnectionUtil.Instance.GetConnection().CreateCommand();
            SqlComm.CommandType = CommandType.Text;

            importThread = new Thread(Import);
            importThread.Start();

            //try {
            //}
            //catch (Exception ex) {
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            try {
                if (importThread != null && importThread.IsAlive) {
                    if (MessageBox.Show("Hệ thống đang cập nhật dữ liệu, bạn có muốn hủy không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) {
                        return;
                    }
                    importThread.Abort();
                }
                else {
                    this.Close();
                }
            }
            catch (Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            SelectFile(MapTextBoxControl(sender));
        }
    }
}