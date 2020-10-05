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
using System.Data.SqlClient;
using System.Drawing;
using System.Collections.Generic;
using QLBH.Common.Objects;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DanhMuc.Infors;

//Note:@CuongTT frmDM_The
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_The_Old : Form
    {
#region "Khai báo biến"
        //Utils ut = new Utils();
        //bool g1Sua = true;
        //LoaiThe_KhachHang g1LoaiThe=new LoaiThe_KhachHang();
        //int g1QuyenLoi_Count,g1UuDai_Count;
        //List<int> g1Lst_IdSanPham = new List<int>();
        public bool isAdd;
        public int OidThe = 0;
#endregion

#region"Phương thức khởi tạo"
        public frmDM_The_Old()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }
#endregion


      
#region "Các sự kiện"
        
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
            #region old
            //try
            //{
            //    btnThemMoi.Enabled = false;
            //    g1Sua = false;
            //    txtMaThe.Text = "";
            //    txtTenThe.Text = "";
            //    txtHieuLuc.Text = "";
            //    txtBaoLuuDiem.Text = "";
            //    txtTinhNangKhac.Text = "";
            //    txtTichLuyTu.Text = "";
            //    txtTichLuyDen.Text = "";
            //    txtGiaTriMuaLanDau.Text = "";
            //    chkBaoHanhVang.Checked = false;
            //    chkCapNhatThongTinSanPhamMoi.Checked = false;
            //    chkDuocTuVanHoTro.Checked = false;
            //    chkTangQuaSinhNhat.Checked = false;
            //    chkThamGiaDaoTao.Checked = false;
            //    dgvQuyenLoi.Rows.Clear();
            //    dgvUuDai.Rows.Clear();
            //    for (int i = 0; i < chkLstSanPham.Items.Count; i++)
            //        chkLstSanPham.SetItemChecked(i, false);

                
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            #endregion

            //isAdd = true;
            //frmChiTiet_The frm = new frmChiTiet_The(this);
            //frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            #region Old
            //try
            //{
            //    if (dgvLoaiThe.SelectedRows.Count < 1)
            //    {
            //        MessageBox.Show("Chưa chọn loại thẻ nào để xóa!");
            //        return;
            //    }
            //    if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại thẻ này không (Yes/No)?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.No) return;
                
            //    int IdLoaiThe = ut.getInt(dgvLoaiThe.SelectedRows[0].Cells["colIdLoaiThe"].Value);
            //    if (IdLoaiThe < 1)
            //        MessageBox.Show("Chưa chọn loại thẻ nào để xóa");
            //    else
            //    {
            //        g1LoaiThe.Delete(IdLoaiThe);
            //        btnLoc_Click(sender, e);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //btnThemMoi.Enabled = true;
            #endregion
            Delete();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            #region old
            //try
            //{
            //    sCapNhat();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi ngoại lệ: " + ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //btnThemMoi.Enabled = true;
            #endregion
            //isAdd = false;
            //frmChiTiet_The frm = new frmChiTiet_The(this);
            //frm.ShowDialog();
        }

#endregion      
#region Ham tu tao

#region old
        //private void sLocThe(string dk)
        //{
        //    string sql = "SELECT * FROM tbl_DM_LoaiThe_KhachHang WHERE " + dk;
        //    dgvLoaiThe.DataSource = ut.getDataTable(sql);
        //    for (int i = 0; i < dgvLoaiThe.Rows.Count; i++)
        //        dgvLoaiThe.Rows[i].Cells["colTT"].Value = i + 1;
        //}
        //private bool DuLieuHopLe()
        //{
        //    if (txtMaThe.Text.Trim() == "" || txtTenThe.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Mã thẻ, tên thẻ chưa đủ");
        //        return false;
        //    }
        //    //Kiem tra trung ma
        //    string sql = string.Format("SELECT IDLoaiThe FROM tbl_DM_LoaiThe_KhachHang WHERE MaThe='{0}'", txtMaThe.Text);
        //    if (g1Sua) sql += " And IdLoaiThe<>" + g1LoaiThe.Id.ToString();
        //    int ID = ut.fGetID_sql(sql);
        //    if (ID > 0)
        //    {
        //            MessageBox.Show("Trùng mã thẻ. Mời nhập lại");
        //            return false;
        //    }
        //    return true;
        //}
        //private void sLoad_LoaiThe(int IdLoaiThe)
        //{
        //    g1LoaiThe.getLoaiThe(IdLoaiThe);
        //    txtMaThe.Text = g1LoaiThe.MaThe;
        //    txtTenThe.Text = g1LoaiThe.TenThe;
        //    cboDoUuTien.Text = g1LoaiThe.DoUuTien.ToString();
        //    txtHieuLuc.Text = g1LoaiThe.ThoiGianHieuLuc.ToString();
        //    txtTinhNangKhac.Text = g1LoaiThe.GhiChu;
        //    chkCapNhatThongTinSanPhamMoi.Checked = g1LoaiThe.DuocCapNhatSanPhamMoi;
        //    chkThamGiaDaoTao.Checked = g1LoaiThe.DuocThamGiaDaoTao;
        //    chkDuocTuVanHoTro.Checked = g1LoaiThe.DuocTuVanHoTro;
        //    txtBaoLuuDiem.Text = g1LoaiThe.BaoLuuDiem.ToString();
        //    chkTangQuaSinhNhat.Checked = g1LoaiThe.DuocTangQuaSinhNhat;
        //    chkBaoHanhVang.Checked = g1LoaiThe.DuocBaoHanhVang;
        //    txtGiaTriMuaLanDau.Text = this.txtGiaTriMuaLanDau.Text = Common.Double2Str(g1LoaiThe.Dk_GiaTri_LanDau);// g1LoaiThe.Dk_GiaTri_LanDau.ToString();
        //    txtTichLuyTu.Text = Common.Double2Str(g1LoaiThe.Dk_GiaTri_TichLuy_Tu);
        //    txtTichLuyDen.Text = Common.Double2Str(g1LoaiThe.Dk_GiaTri_TichLuy_Den);
        //    //Load Quyen Loi
        //    dgvQuyenLoi.DataSource=null;
        //    dgvQuyenLoi.Rows.Clear();
        //    g1QuyenLoi_Count = 0;
        //    foreach (LoaiThe_QuyenLoi tmp in g1LoaiThe.LstQuyenLoi)
        //    {
        //        g1QuyenLoi_Count++;
        //        dgvQuyenLoi.Rows.Add(g1QuyenLoi_Count,tmp.IdSanPham, tmp.TyleGiam);
        //    }
        //    //Load Uu dai
        //    dgvUuDai.DataSource = null;
        //    dgvUuDai.Rows.Clear();
        //    g1UuDai_Count = 0;
        //    foreach (LoaiThe_UuDai tmp in g1LoaiThe.LstUuDai)
        //    {
        //        g1UuDai_Count++;
        //        dgvUuDai.Rows.Add(g1UuDai_Count,tmp.DichVu, tmp.UuDai);
        //    }
        //    chkSuDung.Checked = g1LoaiThe.SuDung;
        //    string Ds_SanPham_KemTheo = g1LoaiThe.Dk_SanPham_KemTheo + ",";
        //    for (int i = 0; i < chkLstSanPham.Items.Count; i++)
        //    {
        //        if (Ds_SanPham_KemTheo.IndexOf(g1Lst_IdSanPham[i].ToString() + ",") > -1)
        //            chkLstSanPham.SetItemChecked(i, true);
        //        else
        //            chkLstSanPham.SetItemChecked(i, false);
        //    }
        //}
        //private void sCapNhat()
        //{
        //    if (!DuLieuHopLe()) return;
        //    //Gan gia tri tu form vao g1LoaiThe
        //    g1LoaiThe.MaThe = txtMaThe.Text;
        //    g1LoaiThe.TenThe = txtTenThe.Text;
        //    g1LoaiThe.DoUuTien = ut.getInt(cboDoUuTien.Text);
        //    g1LoaiThe.ThoiGianHieuLuc = ut.getInt(txtHieuLuc.Text);
        //    g1LoaiThe.GhiChu = txtTinhNangKhac.Text;
        //    g1LoaiThe.DuocCapNhatSanPhamMoi = chkCapNhatThongTinSanPhamMoi.Checked;
        //    g1LoaiThe.DuocThamGiaDaoTao = chkThamGiaDaoTao.Checked;
        //    g1LoaiThe.DuocTuVanHoTro = chkDuocTuVanHoTro.Checked;
        //    g1LoaiThe.BaoLuuDiem = ut.getDouble(txtBaoLuuDiem.Text);///100;
        //    g1LoaiThe.DuocTangQuaSinhNhat = chkTangQuaSinhNhat.Checked;
        //    g1LoaiThe.DuocBaoHanhVang = chkBaoHanhVang.Checked;
        //    g1LoaiThe.Dk_GiaTri_LanDau = ut.getDouble(txtGiaTriMuaLanDau.Text);
        //    g1LoaiThe.Dk_GiaTri_TichLuy_Tu = ut.getDouble(txtTichLuyTu.Text);
        //    g1LoaiThe.Dk_GiaTri_TichLuy_Den = ut.getDouble(txtTichLuyDen.Text);
        //    g1LoaiThe.SuDung = chkSuDung.Checked;
        //    g1LoaiThe.Dk_SanPham_KemTheo = fGet_DS_IdSanPham();
        //    if (g1Sua == false)
        //    {
        //        bool kq = g1LoaiThe.AddNew();
        //        if (kq == false)
        //            MessageBox.Show("Không thêm mới được");
        //        else
        //           MessageBox.Show("Dữ liệu đã được thêm mới");
        //        g1Sua = true;
        //        sLocThe("1=1");
        //    }
        //    else
        //    {
        //        g1LoaiThe.Update();
        //        MessageBox.Show("Dữ liệu đã được sửa");
        //        //Gan lai cac o trong dgvLoaiThe
        //        int r = dgvLoaiThe.CurrentRow.Index;
        //        dgvLoaiThe.Rows[r].Cells["colMaThe"].Value=g1LoaiThe.MaThe;
        //        dgvLoaiThe.Rows[r].Cells["colTenThe"].Value=g1LoaiThe.TenThe;
        //        dgvLoaiThe.Rows[r].Cells["colGhiChu"].Value=g1LoaiThe.GhiChu;
        //        dgvLoaiThe.Rows[r].Cells["colSuDung"].Value = g1LoaiThe.SuDung;
        //    }
        //    btnThemMoi.Enabled = true;
        //}
        //private string fGet_DS_IdSanPham()
        //{
        //    string kq = "";
        //    for (int i = 0; i < chkLstSanPham.Items.Count; i++)
        //    {
        //        if (chkLstSanPham.GetItemChecked(i))
        //            kq += g1Lst_IdSanPham[i].ToString() + ",";
        //    }
        //    return kq.Trim(',');
        //}
#endregion

        #region LoadData
        private void LoadData()
        {
            dgvLoaiThe.DataSource = DmLoaitheKhachHangProvider.GetListDmLoaiTheInfo();
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (MessageBox.Show("bạn có chắc chắn muốn xóa bản ghi này ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //DmLoaiTheKhachHangInfo dm = new DmLoaiTheKhachHangInfo();
                //dm.IdLoaiThe = OidThe;
                DmLoaitheKhachHangProvider.Delete(new DMLoaiTheKhachHangInfo{IdLoaiThe = OidThe});
                MessageBox.Show("Xóa thành công bản ghi !");
                //this.Close();
                LoadData();
                SetControl(false);
            }
        }
        #endregion

        #region Reload
        public void ReLoad()
        {
            LoadData();
            dgvLoaiThe.Refresh();
        }
        #endregion

        #region SetControl
        public void SetControl(bool var)
        {
            btnXoa.Enabled = var;
            btnCapNhat.Enabled = var;
        }
        #endregion

        private bool Search(DMLoaiTheKhachHangInfo dmLoaitheInfo)
        {
            return ((txtMaTheLoc.Text.Trim() == String.Empty || (txtMaTheLoc.Text.Trim() != String.Empty &&
                    dmLoaitheInfo.MaThe.ToLower().Contains(txtMaTheLoc.Text.Trim().ToLower())))
                   && (txtTenTheLoc.Text.Trim() == String.Empty || (txtTenTheLoc.Text.Trim() != String.Empty &&
                       dmLoaitheInfo.TenThe.ToLower().Contains(txtTenTheLoc.Text.Trim().ToLower())))
            && (txtGhiChuLoc.Text.Trim() == String.Empty || (txtGhiChuLoc.Text.Trim() != String.Empty &&
                       dmLoaitheInfo.GhiChu.ToLower().Contains(txtGhiChuLoc.Text.Trim().ToLower()))));

        }

#endregion

        private void frmDM_The_Load(object sender, EventArgs e)
        {
            #region old
            //Load Do uu tien
            //List<int> lst=new List<int>();
            //for (int i=1;i<10;i++)
            //    lst.Add(i);
            //cboDoUuTien.DataSource = lst;
            
            ////Nap loai san pham
            //string sql;
            //bool isChecked;
            //sql = @"SELECT IdSanPham,TenSanPham FROM tbl_SanPham WHERE IdCha=0 or IdCha is null";
            //DataTable dt = ut.getDataTable(sql);
            //foreach (DataRow r in dt.Rows)
            //{
            //    chkLstSanPham.Items.Add(r["TenSanPham"].ToString());
            //    g1Lst_IdSanPham.Add(ut.getInt(r["IdSanPham"]));
            //}
            //colSanPham.DataSource = dt;
            //colSanPham.DisplayMember = "TenSanPham";
            //colSanPham.ValueMember = "IdSanPham";
            
            //dgvLoaiThe.AutoGenerateColumns = false;
            //sLocThe("1=1");    
            #endregion

            SetControl(false);
            LoadData();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            #region old
            //string dk="1=1";
            //if (txtMaTheLoc.Text.Trim() != "") dk += string.Format(" and MaThe Like N'%{0}%'", txtMaTheLoc.Text.Trim());
            //if (txtTenTheLoc.Text.Trim() != "") dk += string.Format(" and TenThe Like N'%{0}%'", txtTenTheLoc.Text.Trim());
            //if (txtGhiChuLoc.Text.Trim() != "") dk += string.Format(" and GhiChu Like N'%{0}%'", txtGhiChuLoc.Text.Trim());
            //sLocThe(dk);
            #endregion

            dgvLoaiThe.DataSource = DmLoaitheKhachHangProvider.Search(new DMLoaiTheKhachHangInfo{TenThe = txtTenTheLoc.Text.Trim(),MaThe = txtMaTheLoc.Text.Trim()});
        }

        private void dgvLoaiThe_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvLoaiThe.SelectedRows.Count > 0)
            //{
            //    int IdLoaiThe = ut.getInt(dgvLoaiThe.SelectedRows[0].Cells["colIdLoaiThe"].Value);
            //    if (IdLoaiThe > 0)
            //        sLoad_LoaiThe(IdLoaiThe);
            //}
        }

        private void dgvUuDai_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //g1UuDai_Count++;
            //int r=e.Row.Index;
            //if ( r> 0)
            //{
            //    dgvUuDai.Rows[r - 1].Cells["UuDai_TT"].Value = g1UuDai_Count.ToString();
            //    LoaiThe_UuDai tmp = new LoaiThe_UuDai();
            //    tmp.TT = g1UuDai_Count;
            //    tmp.ThayDoi = 1;
            //    g1LoaiThe.LstUuDai.Add(tmp);
            //}
        }

        private void dgvUuDai_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //int TT=ut.getInt(e.Row.Cells["UuDai_TT"].Value);
            //LoaiThe_UuDai tmp=g1LoaiThe.LstUuDai.Find(
            //    delegate(LoaiThe_UuDai ct)
            //    {
            //        return ct.TT == TT;
            //    });
            //if (tmp == null) return;
            //if (tmp.ThayDoi == 1)
            //    tmp.ThayDoi = 0;//Khong them, khong xoa
            //else
            //    tmp.ThayDoi = 3;//Xoa

        }

        private void dgvLoaiThe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //dgvLoaiThe.Rows[e.RowIndex].Cells["colTT"].Value = e.RowIndex + 1;
        }

        private void dgvUuDai_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int TT = ut.getInt(dgvUuDai.Rows[e.RowIndex].Cells["UuDai_TT"].Value);
            //LoaiThe_UuDai tmp = g1LoaiThe.LstUuDai.Find(
            //    delegate(LoaiThe_UuDai ct)
            //    {
            //        return ct.TT == TT;
            //    });
            //if (tmp != null)
            //{
            //    tmp.DichVu = ut.getString(dgvUuDai.Rows[e.RowIndex].Cells["colDichVu"].Value);
            //    tmp.UuDai = ut.getString(dgvUuDai.Rows[e.RowIndex].Cells["colUuDai"].Value);
            //    if (tmp.ThayDoi!=1) tmp.ThayDoi = 2;
            //}

        }

        private void dgvUuDai_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dgvQuyenLoi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ////MessageBox.Show(dgvQuyenLoi.Rows[e.RowIndex].Cells["colSanPham"].Value.ToString());
            //int TT = ut.getInt(dgvQuyenLoi.Rows[e.RowIndex].Cells["QuyenLoi_TT"].Value);
            //LoaiThe_QuyenLoi tmp = g1LoaiThe.LstQuyenLoi.Find(
            //    delegate(LoaiThe_QuyenLoi ct)
            //    {
            //        return ct.TT == TT;
            //    });
            //if (tmp != null)
            //{
            //    tmp.IdSanPham = ut.getInt(dgvQuyenLoi.Rows[e.RowIndex].Cells["colSanPham"].Value);
            //    tmp.TyleGiam = ut.getDouble(dgvQuyenLoi.Rows[e.RowIndex].Cells["colTyLeGiam"].Value);
            //    if (tmp.ThayDoi != 1) tmp.ThayDoi = 2;
            //}
        }

        private void dgvQuyenLoi_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }

        private void dgvQuyenLoi_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //g1QuyenLoi_Count++;
            //int r = e.Row.Index;
            //if ( r> 0)
            //{
            //    dgvQuyenLoi.Rows[r - 1].Cells["QuyenLoi_TT"].Value = g1QuyenLoi_Count.ToString();
            //    LoaiThe_QuyenLoi tmp = new LoaiThe_QuyenLoi();
            //    tmp.TT = g1QuyenLoi_Count;
            //    tmp.ThayDoi = 1;
            //    g1LoaiThe.LstQuyenLoi.Add(tmp);
            //}
        }

        private void dgvQuyenLoi_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //int TT = ut.getInt(e.Row.Cells["QuyenLoi_TT"].Value);
            //LoaiThe_QuyenLoi tmp = g1LoaiThe.LstQuyenLoi.Find(
            //    delegate(LoaiThe_QuyenLoi ct)
            //    {
            //        return ct.TT == TT;
            //    });
            //if (tmp == null) return;
            //if (tmp.ThayDoi == 1)
            //    tmp.ThayDoi = 0;//Khong them, khong xoa
            //else
            //    tmp.ThayDoi = 3;//Xoa
        }

        private void txtGiaTriMuaLanDau_Leave(object sender, EventArgs e)
        {
            //this.txtGiaTriMuaLanDau.Text = Common.Double2Str(Common.DoubleValue(this.txtGiaTriMuaLanDau.Text.Trim()));
        }

        private void txtTichLuyTu_Leave(object sender, EventArgs e)
        {
            //this.txtTichLuyTu.Text = Common.Double2Str(Common.DoubleValue(this.txtTichLuyTu.Text.Trim()));
        }

        private void txtTichLuyDen_Leave(object sender, EventArgs e)
        {
            //this.txtTichLuyDen.Text = Common.Double2Str(Common.DoubleValue(this.txtTichLuyDen.Text.Trim()));
        }

        private void dgvLoaiThe_DoubleClick(object sender, EventArgs e)
        {
            //isAdd = false;
            //frmChiTiet_The frm = new frmChiTiet_The(this);
            //frm.ShowDialog();
        }

        private void dgvLoaiThe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLoaiThe.Rows.Count > 0)
            {
                SetControl(true);
                OidThe = int.Parse(dgvLoaiThe.Rows[dgvLoaiThe.CurrentCell.RowIndex].Cells["colIdLoaiThe"].Value.ToString());
            }
        }
    }
}