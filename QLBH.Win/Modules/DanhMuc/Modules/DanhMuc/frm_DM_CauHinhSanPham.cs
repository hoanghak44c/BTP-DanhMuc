using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frm_DM_CauHinhSanPham : DevExpress.XtraEditors.XtraForm
    {
        public bool isAdd = false;
        public int Oid;
        public frm_DM_CauHinhSanPham()
        {
            InitializeComponent();
        }
        private void LoadDataGridSanPham()
        {
            if (bteSanPham.Tag != null)
            {
                List<DMSanPhamInfo> listSP = (List<DMSanPhamInfo>)bteSanPham.Tag;
                string Id = String.Empty;
                foreach (DMSanPhamInfo dmSanPhamInfo in listSP)
                {
                    Id += dmSanPhamInfo.IdSanPham + ",";
                }
                //lstSP = NoteReportDataProvider.Instance.SanPhamGetTenByIdSanPham(Id);
                //grcSanPham.DataSource = null;
                //grcSanPham.DataSource = lstSP;
            }
            else
            {
                clsUtils.MsgThongBao("Bạn chưa chọn sản phẩm!");
            }
        }
        #region Event bteSanPham
        private void bteSanPham_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_SanPham_CauHinh frmLookUp = new frmLookUp_SanPham_CauHinh(false, String.Format("%{0}%", bteSanPham.Text));
            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteSanPham.EditValue = String.Empty;
                bteSanPham.Tag = frmLookUp.SelectedItem;
                bteSanPham.Text = frmLookUp.SelectedItem.MaSanPham;
                //foreach (DMSanPhamInfo selectedItem in frmLookUp.SelectedItems)
                //{
                //    bteSanPham.EditValue += selectedItem.MaSanPham + ",";
                //}
                //LoadDataGridSanPham();
            }
        }
        private void bteSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_SanPham_CauHinh frmLookUp = new frmLookUp_SanPham_CauHinh(false, String.Format("%{0}%", bteSanPham.Text));
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteSanPham.Tag = frmLookUp.SelectedItem;
                    bteSanPham.Text = frmLookUp.SelectedItem.MaSanPham;
                    //foreach (DMSanPhamInfo selectedItem in frmLookUp.SelectedItems)
                    //{
                    //    bteSanPham.EditValue += selectedItem.MaSanPham + ",";
                    //}
                    //LoadDataGridSanPham();
                }
            }
        }
        private void bteSanPham_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteSanPham.Text)) bteSanPham.Tag = null;
        }
        #endregion 

        #region Event bteNhaCC
        private void bteNhaCC_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmLookUp_Hang frmLookUp = new frmLookUp_Hang(false, String.Format("%{0}%", bteNhaCC.Text));
            if (frmLookUp.ShowDialog() == DialogResult.OK)
            {
                bteNhaCC.EditValue = String.Empty;
                bteNhaCC.Tag = frmLookUp.SelectedItem;
                bteNhaCC.Text = frmLookUp.SelectedItem.Ten;
                //foreach (DMDoiTuongInfo selectedItem in frmLookUp.SelectedItems)
                //{
                //    bteNhaCC.EditValue += selectedItem.TenDoiTuong + ",";
                //}
                //LoadDataGridSanPham();
            }
        }
        private void bteNhaCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_Hang frmLookUp = new frmLookUp_Hang(false, String.Format("%{0}%", bteNhaCC.Text));
                if (frmLookUp.ShowDialog() == DialogResult.OK)
                {
                    bteNhaCC.Tag = frmLookUp.SelectedItems;
                    bteNhaCC.Text = frmLookUp.SelectedItem.Ten;
                    //foreach (DMSanPhamInfo selectedItem in frmLookUp.SelectedItems)
                    //{
                    //    bteNhaCC.EditValue += selectedItem.MaSanPham + ",";
                    //}
                    //LoadDataGridSanPham();
                }
            }
        }
        private void bteNhaCC_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bteNhaCC.Text)) bteNhaCC.Tag = null;
        }
        #endregion 
        private void LoadTon()
        {
            List<LookUp> lidanhmuc = new List<LookUp>();
            lidanhmuc.Add(new LookUp { OID = 1, Name = "Có tồn" });
            lidanhmuc.Add(new LookUp { OID = 0, Name = "Không có tồn" });
            lueTon.Properties.DataSource = null;
            lueTon.Properties.DataSource = lidanhmuc;
            lueTon.EditValue = lidanhmuc[0].OID;
        }
        protected void LoadData()
        {
            grcDMCauHinhSanPham.DataSource = DMCauHinhSanPhamDataProvider.Instance.GetListCauHinhSanPham();
            rdoCoCauHinh.Checked = true;
        }
        public void SetControl(bool var)
        {
            btnDelete.Enabled = var;
        }
        private void Delete()
        {
            if (grvDMCauHinhSanPham.FocusedRowHandle < 0) return;
            DMCauHinhSanPhamInfo info = ((DMCauHinhSanPhamInfo)grvDMCauHinhSanPham.GetRow(grvDMCauHinhSanPham.FocusedRowHandle));
            DMCauHinhSanPhamDataProvider.Instance.Delete(new DMCauHinhSanPhamInfo { IdSanPham = info.IdSanPham });
        }

        #region Events
        private void frm_DM_CauHinhSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadTon();
            grbListCauHinh.Text = "Tìm thấy : " + grvDMCauHinhSanPham.RowCount + " bản ghi";
        }
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            isAdd = true;
            frm_ChiTiet_CauHinhSanPham frm = new frm_ChiTiet_CauHinhSanPham(this);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                grcDMCauHinhSanPham.DataSource = DMCauHinhSanPhamDataProvider.Instance.GetListCauHinhSanPham();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            //isAdd = false;
            if (grvDMCauHinhSanPham.FocusedRowHandle < 0) return;
            DMCauHinhSanPhamInfo info = ((DMCauHinhSanPhamInfo)grvDMCauHinhSanPham.GetRow(grvDMCauHinhSanPham.FocusedRowHandle));
            List<DMCauHinhSanPhamInfo> lst = DMCauHinhSanPhamDataProvider.Instance.GetCauHinhByIdSanPham(info.IdSanPham);
            if(lst.Count==0)
            {
                frm_ChiTiet_CauHinhSanPham frm = new frm_ChiTiet_CauHinhSanPham(this, info.IdSanPham, info.TenSanPham,"","");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    grcDMCauHinhSanPham.DataSource = DMCauHinhSanPhamDataProvider.Instance.GetListCauHinhSanPham();
                }
            }
            else
            {
                frm_ChiTiet_CauHinhSanPham frm = new frm_ChiTiet_CauHinhSanPham(this, info.IdSanPham, info.TenSanPham, lst[0].TenCauHinh, lst[0].GiaTri);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    grcDMCauHinhSanPham.DataSource = DMCauHinhSanPhamDataProvider.Instance.GetListCauHinhSanPham();
                }
            }
        }
        private void grcDMCauHinhSanPham_DoubleClick(object sender, EventArgs e)
        {
            //isAdd = false;
            if (grvDMCauHinhSanPham.FocusedRowHandle < 0) return;
            DMCauHinhSanPhamInfo info = ((DMCauHinhSanPhamInfo)grvDMCauHinhSanPham.GetRow(grvDMCauHinhSanPham.FocusedRowHandle));
            List<DMCauHinhSanPhamInfo> lst = DMCauHinhSanPhamDataProvider.Instance.GetCauHinhByIdSanPham(info.IdSanPham);
            if (lst.Count == 0)
            {
                frm_ChiTiet_CauHinhSanPham frm = new frm_ChiTiet_CauHinhSanPham(this, info.IdSanPham, info.TenSanPham, "", "");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    grcDMCauHinhSanPham.DataSource = DMCauHinhSanPhamDataProvider.Instance.GetListCauHinhSanPham();
                }
            }
            else
            {
                frm_ChiTiet_CauHinhSanPham frm = new frm_ChiTiet_CauHinhSanPham(this, info.IdSanPham, info.TenSanPham, lst[0].TenCauHinh, lst[0].GiaTri);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    grcDMCauHinhSanPham.DataSource = DMCauHinhSanPhamDataProvider.Instance.GetListCauHinhSanPham();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản ghi này ?", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Delete();
                MessageBox.Show("Xóa thành công bản ghi !");
                LoadData();
                //SetControl(false);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lueTon.EditValue) == 0)
            {
                if (rdoCoCauHinh.Checked)
                {
                    grcDMCauHinhSanPham.DataSource = DMCauHinhSanPhamDataProvider.Instance.GetListSearchCauHinhSanPhamCo(0);
                    grbListCauHinh.Text = "Tìm thấy : " + grvDMCauHinhSanPham.RowCount + " bản ghi";
                }
                else
                {
                    grcDMCauHinhSanPham.DataSource = DMCauHinhSanPhamDataProvider.Instance.GetListSearchCauHinhSanPhamKhong(0);
                    grbListCauHinh.Text = "Tìm thấy : " + grvDMCauHinhSanPham.RowCount + " bản ghi";
                }
            }
            else
            {
                if (rdoCoCauHinh.Checked)
                {
                    grcDMCauHinhSanPham.DataSource = DMCauHinhSanPhamDataProvider.Instance.GetListSearchCauHinhSanPhamCo(1);
                    grbListCauHinh.Text = "Tìm thấy : " + grvDMCauHinhSanPham.RowCount + " bản ghi";
                }
                else
                {
                    grcDMCauHinhSanPham.DataSource = DMCauHinhSanPhamDataProvider.Instance.GetListSearchCauHinhSanPhamKhong(1);
                    grbListCauHinh.Text = "Tìm thấy : " + grvDMCauHinhSanPham.RowCount + " bản ghi";
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Common.DevExport2Excel(grvDMCauHinhSanPham);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
