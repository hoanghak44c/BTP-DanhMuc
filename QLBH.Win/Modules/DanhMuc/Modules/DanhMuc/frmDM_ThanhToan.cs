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
    public partial class frmDM_ThanhToan : DevExpress.XtraEditors.XtraForm
    {
        public frmDM_ThanhToan()
        {
            InitializeComponent();
        }

        private void frmDM_ThanhToan_Load(object sender, EventArgs e)
        {
            try
            {
                dgvList.DataSource = DMThanhToanDataProvider.GetListDMThanhToanInfo();
                btnXoa.Enabled = dgvList.Rows.Count > 0 && dgvList.CurrentRow != null;
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                this.Dispose();
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnXoa.Enabled = dgvList.CurrentRow != null;
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), "Thông báo");
#else
                MessageBox.Show(ex.Message, "Thông báo");
#endif
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            frmChiTiet_HinhThucThanhToan frmChiTietHinhThucThanhToan = new frmChiTiet_HinhThucThanhToan();
            if(frmChiTietHinhThucThanhToan.ShowDialog()==DialogResult.OK)
                dgvList.DataSource = DMThanhToanDataProvider.GetListDMThanhToanInfo(); ;
        }

        private void dgvList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.CurrentRow != null)
                {
                    frmChiTiet_HinhThucThanhToan frmChiTietHinhThucThanhToan =
                        new frmChiTiet_HinhThucThanhToan((DMThanhToanInfor) dgvList.CurrentRow.DataBoundItem);
                    if (frmChiTietHinhThucThanhToan.ShowDialog() == DialogResult.OK)
                        dgvList.DataSource = DMThanhToanDataProvider.GetListDMThanhToanInfo(); ;
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), "Thông báo");
#else
                MessageBox.Show(ex.Message, "Thông báo");
#endif
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.CurrentRow == null)
                {
                    MessageBox.Show("Bạn chưa chọn loại thanh toán", "Thông báo");
                    return;
                }

                frmChiTiet_HinhThucThanhToan frmChiTietHinhThucThanhToan =
                    new frmChiTiet_HinhThucThanhToan((DMThanhToanInfor)dgvList.CurrentRow.DataBoundItem);
                if (frmChiTietHinhThucThanhToan.ShowDialog() == DialogResult.OK)
                    dgvList.DataSource = DMThanhToanDataProvider.GetListDMThanhToanInfo();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), "Thông báo");
#else
                MessageBox.Show(ex.Message, "Thông báo");
#endif
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.CurrentRow == null)
                {
                    MessageBox.Show("Bạn chưa chọn loại thanh toán", "Thông báo");
                    return;
                }

                if(MessageBox.Show("Bạn có chắc xóa loại thanh toán này không?", "Xác nhận", MessageBoxButtons.YesNo) ==DialogResult.Yes)
                {
                    DMThanhToanDataProvider.Instance.Delete((DMThanhToanInfor)dgvList.CurrentRow.DataBoundItem);
                    dgvList.DataSource = DMThanhToanDataProvider.GetListDMThanhToanInfo(); ;
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), "Thông báo");
#else
                MessageBox.Show(ex.Message, "Thông báo");
#endif
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
