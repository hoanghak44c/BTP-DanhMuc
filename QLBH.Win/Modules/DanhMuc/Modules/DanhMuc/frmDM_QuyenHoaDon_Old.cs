using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core;

// <Remarks>
// Tạo form frmDM_QuyenHoaDon
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 29/02/2012
// Người sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc 
{
    //Note :@HanhBD frmDM_QuyenHoaDon

    public partial class frmDM_QuyenHoaDon_Old : DevExpress.XtraEditors.XtraForm
    {
        private List<DMQuyenHoaDonInfor> arHoaDon = new List<DMQuyenHoaDonInfor>();

        public frmDM_QuyenHoaDon_Old()
        {
            InitializeComponent();
            ucActions1.IsSynchronizable = KhaiBaoDMDataProvider.IsSync(Declare.TableNamespace.DmQuyenHoaDon);
        }

        private DMQuyenHoaDonInfor getinfor()
        {
            DMQuyenHoaDonInfor dmQuyenHoaDonInfor = new DMQuyenHoaDonInfor();
            dmQuyenHoaDonInfor.KyHieuHoaDon = txtKyHieu.Text;
            dmQuyenHoaDonInfor.KyTuDauSerie = txtKyHieuDau.Text;
            dmQuyenHoaDonInfor.SoLuong = Convert.ToInt32(txtSoLuong.Text);
            dmQuyenHoaDonInfor.SuDung = Convert.ToInt32(txtDaDung.Text);
            return dmQuyenHoaDonInfor;
        }
        
        private void ucActions1_OnAdd(object obj)
        {
            DMQuyenHoaDonDataProvider.Insert(getinfor());
            MessageBox.Show("Thêm bảng thành công!");
            dgvList.DataSource = DMQuyenHoaDonDataProvider.GetListQuyenHoaDonInfor();
        }
        private void ucActions1_OnClose()
        {
            this.Close();
        }

        private void ucActions1_OnDelete(object obj)
        {
            //DMQuyenHoaDonInfo khaibao = new DMQuyenHoaDonInfo();
            //khaibao.KyHieuHoaDon = Convert.ToString(getValue("KyHieuHoaDon"));
            //khaibao.KyTuDauSerie = Convert.ToString(getValue("KyTuDauSerie"));
            DMQuyenHoaDonDataProvider.Delete(new DMQuyenHoaDonInfor { KyHieuHoaDon = Convert.ToString(getValue("KyHieuHoaDon"))});
            MessageBox.Show("Xóa Thành Công", "Thông Báo");
            dgvList.DataSource = DMQuyenHoaDonDataProvider.GetListQuyenHoaDonInfor();
        }

        private object getValue(string colName)
        {
            if (dgvList.CurrentRow != null && !dgvList.CurrentRow.IsNewRow)
                return dgvList.CurrentRow.Cells[colName].Value;
            return null;
        }

        private void ucActions1_OnDisableEditor()
        {
            txtKyHieu.Enabled = false;
            txtKyHieuDau.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDaDung.Enabled = false;
            txtConLai.Enabled = false;
        }

        private void ucActions1_OnEnableEditor()
        {
            txtSoLuong.Enabled = true;
            txtKyHieuDau.Enabled = txtKyHieuDau.Text.Trim() == String.Empty;
            txtDaDung.Enabled = true;
            txtKyHieu.Enabled = txtKyHieu.Text.Trim() == String.Empty;
            txtConLai.Enabled = true;
        }

        private void ucActions1_OnLoadEditor(object obj)
        {
            if (obj != null)
            {
                txtKyHieu.Text = Convert.ToString(getValue("KyHieuHoaDon"));
                txtKyHieuDau.Text = Convert.ToString(getValue("KyTuDauSerie"));
                txtSoLuong.Text = Convert.ToString(getValue("SoLuong"));
                txtDaDung.Text = Convert.ToString(getValue("SuDung"));
                return;
            }
            txtKyHieu.Text = String.Empty;
            txtKyHieuDau.Text = String.Empty;
            txtSoLuong.Text = String.Empty;
            txtDaDung.Text = String.Empty;
            txtConLai.Text = String.Empty;

        }

        private void ucActions1_OnUpdate(object obj)
        {
            DMQuyenHoaDonDataProvider.Update(getinfor());
            MessageBox.Show("Sửa bảng thành công!");
            dgvList.DataSource = DMQuyenHoaDonDataProvider.GetListQuyenHoaDonInfor();
        }

        private void ucActions1_OnValidate(object obj, QLBH.Core.ActionState actionMode)
        {
            switch (actionMode)
            {
                case ActionState.ADD:
                case ActionState.UPDATE:
                    if (txtKyHieu.Text == String.Empty)
                    {
                        throw new Exception("Ký Hiệu hóa đơn không Được Để Trống!");
                    }
                    if(txtKyHieuDau.Text == String.Empty)
                    {
                        throw new Exception("Ký hiệu đầu serie không được để trống!");
                    }
                    if (DMQuyenHoaDonDataProvider.Kiemtra(new DMQuyenHoaDonInfor{KyHieuHoaDon = txtKyHieu.Text,KyTuDauSerie = txtKyHieuDau.Text}))
                    {
                        throw new Exception("Ký Hiệu hóa đơn và ký hiệu đầu serie Đã Tồn Tại!");
                    }
                    break;
            }
        }

        private bool Exist(DMQuyenHoaDonInfor dmQuyenHoaDonInfor)
        {
            return dmQuyenHoaDonInfor.KyTuDauSerie.ToLower() == txtKyHieuDau.Text.Trim().ToLower() 
                && dmQuyenHoaDonInfor.KyHieuHoaDon.ToLower() == txtKyHieu.Text.Trim().ToLower();
        }

        private bool Search(DMQuyenHoaDonInfor dmQuyenHoaDonInfor)
        {
            return ((txtFilterKyHieuDau.Text.Trim() == String.Empty || (txtFilterKyHieuDau.Text.Trim() != String.Empty &&
                    dmQuyenHoaDonInfor.KyTuDauSerie.ToLower().Contains(txtFilterKyHieuDau.Text.Trim().ToLower())))
                   && (txtFilterKyHieu.Text.Trim() == String.Empty || (txtFilterKyHieu.Text.Trim() != String.Empty &&
                       dmQuyenHoaDonInfor.KyHieuHoaDon.ToLower().Contains(txtFilterKyHieu.Text.Trim().ToLower()))));
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //dgvList.DataSource = DMQuyenHoaDonDataProvider.Search(Search);
            DMQuyenHoaDonInfor dmQuyenHoaDonInfor = new DMQuyenHoaDonInfor();
            dmQuyenHoaDonInfor.KyHieuHoaDon = txtKyHieu.Text;
            dmQuyenHoaDonInfor.KyTuDauSerie = txtKyHieuDau.Text;
            dgvList.DataSource = DMQuyenHoaDonDataProvider.Search(dmQuyenHoaDonInfor);
        }

        private void frmDM_QuyenHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = DMQuyenHoaDonDataProvider.GetListQuyenHoaDonInfor();
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

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0 && !dgvList.Rows[e.RowIndex].IsNewRow)
                ucActions1.LoadEditor(dgvList.Rows[e.RowIndex]);
            else ucActions1.LoadEditor(null);
            //ucActions1.LoadEditor(dgvList.Rows[e.RowIndex].IsNewRow ? null : dgvList.Rows[e.RowIndex]);
        }

        private void ucActions1_OnSynchronize()
        {
            throw new NotImplementedException("Synchronize function is not implemented.");
        }
    }
}