using System;
using System.Data;
using System.Windows.Forms;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frm_Chon_SanPham : Form
    {
        TextBox txt=null;
        DataGridViewCell cellID = null;
        DataGridViewCell cellMa=null;
        DataGridViewCell cellTen = null;
        DataGridViewCell cellDonGia = null;
        DataGridViewCell cellDonViTinh = null;
        double tyLeVAT = 0;
        Utils ut = new Utils();
        //bool multi = true;
        public frm_Chon_SanPham()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
        public frm_Chon_SanPham(TextBox pTxt)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            txt = pTxt;
        }
        public frm_Chon_SanPham(DataGridViewCell pCellID, DataGridViewCell pCellMa, DataGridViewCell pCellTen)
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
        public frm_Chon_SanPham(DataGridViewCell pCellID, DataGridViewCell pCellMa, DataGridViewCell pCellTen, double pTyLeVAT)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            cellMa = pCellMa;
            cellTen = pCellTen;
            cellID = pCellID;
            tyLeVAT = pTyLeVAT;
            if (pCellMa.Value != null) txtSearchMa.Text = pCellMa.Value.ToString();
            if (pCellTen.Value != null) txtSearchTen.Text = pCellTen.Value.ToString();
            LoadLstSanPham();

        }
        public frm_Chon_SanPham(DataGridViewCell pCellID, DataGridViewCell pCellMa, DataGridViewCell pCellTen, DataGridViewCell pCellDonGia)
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
        public frm_Chon_SanPham(DataGridViewCell pCellID, DataGridViewCell pCellMa, DataGridViewCell pCellTen, DataGridViewCell pCellDonGia, DataGridViewCell pCellTenDonViTinh)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            cellMa = pCellMa;
            cellTen = pCellTen;
            cellID = pCellID;
            cellDonGia = pCellDonGia;
            cellDonViTinh = pCellTenDonViTinh;
            if (pCellMa.Value != null) txtSearchMa.Text = pCellMa.Value.ToString();
            if (pCellTen.Value != null) txtSearchTen.Text = pCellTen.Value.ToString();
            LoadLstSanPham();

        }
        
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (txt!=null)
                txt.Text = "";
            if (cellMa != null)
            {
                cellID.Value = 0;
                cellMa.Value = "";
                cellTen.Value = "";
                if (cellDonGia != null) cellDonGia.Value = DBNull.Value;
            }
            this.Close();
        }

        private void LoadLstSanPham()
        {
            string dk = "1=1";
            if (txtSearchMa.Text.Trim() != "") dk = dk + " and MaSanPham Like N'" + txtSearchMa.Text.Trim() + "%'";
            if (txtSearchTen.Text.Trim() != "") dk = dk + " and TenSanPham Like N'" + txtSearchTen.Text.Trim() + "%'";
            if (tyLeVAT != 0) dk += " and TyLeVAT = " + tyLeVAT;

            string sql = "SELECT sp.IdSanPham,sp.MaSanPham,sp.TenSanPham, dvt.TenDonViTinh FROM tbl_SanPham sp"
                + " inner join tbl_DM_DonViTinh dvt on dvt.IdDonViTinh = sp.IdDonViTinh"
                + " Where " + dk;
            DataSet Ds = ut.getDataSet(sql);
            dgvDanhMuc.DataSource = Ds.Tables[0]; 
        }
        private void choice()
        {
            try
            {
                if (dgvDanhMuc.SelectedRows.Count == 0) {
                    MessageBox.Show("Bạn chưa chọn một danh mục nào. Mời lựa chọn!");
                    return;
                }

                string st = dgvDanhMuc.SelectedRows[0].Cells["colMa"].Value.ToString();
                string stTen = dgvDanhMuc.SelectedRows[0].Cells["colTen"].Value.ToString();
                int ID = int.Parse(dgvDanhMuc.SelectedRows[0].Cells["colID"].Value.ToString());
                float stDonGia = 0;// ut.getFloat(dgvDanhMuc.SelectedRows[0].Cells["colGiaBanChuaVAT"].Value);
                if (txt != null)
                    txt.Text = st;
                if (cellMa != null) {
                    cellTen.Value = stTen;
                    cellID.Value = ID.ToString();
                    cellMa.Value = st;
                    if (cellDonGia != null) cellDonGia.Value = stDonGia.ToString();
                    if (cellDonViTinh != null) cellDonViTinh.Value = dgvDanhMuc.SelectedRows[0].Cells["TenDonViTinh"].Value;
                }

                this.Close();
                //MessageBox.Show(string.Format("ID: {0}; Ma: {1}; Ten: {2}",ID, st, stTen));
            }
            catch (System.Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
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