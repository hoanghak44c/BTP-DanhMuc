using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frm_Chon_SanPham_MaVach : Form
    {
        TextBox txt=null;
        int IdKho = 0;
        bool SoLuong = false;
        DataGridViewCell cellID = null;
        DataGridViewCell cellMa=null;
        DataGridViewCell cellTen = null;
        DataGridViewCell cellDonGia = null;
        Utils ut = new Utils();
        bool LoadNullData = true;

        //bool multi = true;
        public frm_Chon_SanPham_MaVach()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frm_Chon_SanPham_MaVach(TextBox pTxt)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            txt = pTxt;
            txtSearchMa.Text = txt.Text;
        }
        public frm_Chon_SanPham_MaVach(TextBox pTxt,int pIdKho)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            txt = pTxt;
            txtSearchMa.Text = txt.Text;
            IdKho = pIdKho;
        }
        public frm_Chon_SanPham_MaVach(DataGridViewCell pCellID, DataGridViewCell pCellMa, DataGridViewCell pCellTen)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            cellMa = pCellMa;
            cellTen = pCellTen;
            cellID = pCellID;
            if (pCellMa.Value!=null) txtSearchMa.Text = pCellMa.Value.ToString();
            if (pCellTen.Value != null) txtSearchTen.Text = pCellTen.Value.ToString();
            LoadLstSanPham();
            
        }
        public frm_Chon_SanPham_MaVach(DataGridViewCell pCellID, DataGridViewCell pCellMa, DataGridViewCell pCellTen, int pIdKho, bool pSoLuong)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            cellMa = pCellMa;
            cellTen = pCellTen;
            cellID = pCellID;
            IdKho = pIdKho;
            SoLuong = pSoLuong;
            if (pCellMa.Value != null) txtSearchMa.Text = pCellMa.Value.ToString();
            if (pCellTen.Value != null) txtSearchTen.Text = pCellTen.Value.ToString();
            LoadLstSanPham();

        }
        public frm_Chon_SanPham_MaVach(DataGridViewCell pCellID, DataGridViewCell pCellMa, DataGridViewCell pCellTen, int pIdKho, bool pSoLuong, bool pNulData)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            cellMa = pCellMa;
            cellTen = pCellTen;
            cellID = pCellID;
            IdKho = pIdKho;
            SoLuong = pSoLuong;
            LoadNullData = pNulData;
            if (pCellMa.Value != null) txtSearchMa.Text = pCellMa.Value.ToString();
            if (pCellTen.Value != null) txtSearchTen.Text = pCellTen.Value.ToString();
            LoadLstSanPham();

        }
        public frm_Chon_SanPham_MaVach(DataGridViewCell pCellID, DataGridViewCell pCellMa, DataGridViewCell pCellTen, DataGridViewCell pCellDonGia)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            cellMa = pCellMa;
            cellTen = pCellTen;
            cellID = pCellID;
            cellDonGia = pCellDonGia;
            if (pCellMa.Value != null) txtSearchMa.Text = pCellMa.Value.ToString();
            if (pCellTen.Value != null) txtSearchTen.Text = pCellTen.Value.ToString();
            LoadLstSanPham();

        }
        
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (!LoadNullData) return;
            if (txt!=null)
                txt.Text = "";
            if (cellMa != null)
            {
                cellID.Value = 0;
                cellMa.Value = "";
                cellTen.Value = "";
                if (cellDonGia != null) cellDonGia.Value = null;
            }
            this.Close();
        }

        private void LoadLstSanPham()
        {
            string dk = "1=1";
            if (txtSearchMa.Text.Trim() != "") dk = dk + " and tbl_HangHoa_Chitiet.MaVach Like N'" + txtSearchMa.Text.Trim() + "%'";
            if (IdKho != 0) dk = dk + " and tbl_HangHoa_Chitiet.IdKho=" + IdKho.ToString();
            if (SoLuong) dk = dk + " and tbl_HangHoa_Chitiet.SoLuong > 0 ";
            if (txtSearchTen.Text.Trim() != "") dk = dk + " and TenSanPham Like N'" + txtSearchTen.Text.Trim() + "%'";
            if (cellID != null && Common.IntValue(cellID.Value) > 0) dk = dk + " and tbl_SanPham.IdSanPham = " + cellID.Value;

            string sql = @"SELECT     tbl_SanPham.IdSanPham, tbl_HangHoa_Chitiet.MaVach, tbl_SanPham.TenSanPham
                            FROM         tbl_HangHoa_Chitiet INNER JOIN
                                      tbl_SanPham ON tbl_HangHoa_Chitiet.IdSanPham = tbl_SanPham.IdSanPham
                            Where " + dk;
            DataSet Ds = ut.getDataSet(sql);
            dgvDanhMuc.DataSource = Ds.Tables[0]; 
        }
        private void choice()
        {
            if (dgvDanhMuc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn một danh mục nào. Mời lựa chọn!");
                return;
            }
            
            string st = dgvDanhMuc.SelectedRows[0].Cells["colMa"].Value.ToString();
            string stTen = dgvDanhMuc.SelectedRows[0].Cells["colTen"].Value.ToString();
            int ID=int.Parse(dgvDanhMuc.SelectedRows[0].Cells["colID"].Value.ToString());
            float stDonGia = 0;// ut.getFloat(dgvDanhMuc.SelectedRows[0].Cells["colGiaBanChuaVAT"].Value);
            if (txt != null)
                txt.Text = st;
            else if (cellMa != null)
            {
                cellTen.Value = stTen;
                cellID.Value = ID.ToString();
                cellMa.Value = st;
                if (cellDonGia != null) cellDonGia.Value = stDonGia.ToString();
            }

            this.Close();
            //MessageBox.Show(string.Format("ID: {0}; Ma: {1}; Ten: {2}",ID, st, stTen));
        }
        


        private void txtSearchMa_TextChanged(object sender, EventArgs e)
        {
            LoadLstSanPham();
        }

        private void txtSearchTen_TextChanged(object sender, EventArgs e)
        {
            LoadLstSanPham();
        }

        private void dgvDanhMuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                choice();
        }

        private void txtSearchMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtSearchTen.Focus();
        }

        private void txtSearchTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) dgvDanhMuc.Focus();
        }

        private void dgvDanhMuc_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void frm_Chon_SanPham_Load(object sender, EventArgs e)
        {
            txtSearchMa.Focus();
            LoadLstSanPham();
        }

        private void dgvDanhMuc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            choice();
        }
    }
}