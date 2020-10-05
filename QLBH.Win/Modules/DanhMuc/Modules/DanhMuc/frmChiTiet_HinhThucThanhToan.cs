using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_HinhThucThanhToan : DevExpress.XtraEditors.XtraForm
    {
        private DMThanhToanInfor dmThanhToanInfo;
        public frmChiTiet_HinhThucThanhToan()
        {
            InitializeComponent();
            this.dmThanhToanInfo = new DMThanhToanInfor();
        }

        public frmChiTiet_HinhThucThanhToan(DMThanhToanInfor dmThanhToanInfo)
        {
            InitializeComponent();
            this.dmThanhToanInfo = dmThanhToanInfo;
            txtThanhToan.Text = dmThanhToanInfo.Ten;
            btnDelete.Enabled = dmThanhToanInfo.IdThanhToan != 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                dmThanhToanInfo.Ten = txtThanhToan.Text;
                
                if (txtThanhToan.Text == String.Empty)
                {
                    throw new Exception("Tên Danh mục Không Được Để Trống!");
                }

                if (DMThanhToanDataProvider.Instance.IsExisted(dmThanhToanInfo))
                {
                    throw new Exception("Tên Danh mục Đã Tồn Tại!");
                }

                if (dmThanhToanInfo.IdThanhToan == 0)
                {
                    DMThanhToanDataProvider.Instance.Insert(dmThanhToanInfo);
                    MessageBox.Show("Thêm mới thành công.", "Thông báo");
                }else
                {
                    DMThanhToanDataProvider.Instance.Update(dmThanhToanInfo);
                    MessageBox.Show("Cập nhật thành công.", "Thông báo");                    
                }
                
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), "Thông báo");
#else
                MessageBox.Show(ex.Message, "Thông báo");
#endif
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DMThanhToanDataProvider.Instance.Delete(dmThanhToanInfo);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), "Thông báo");
#else
                MessageBox.Show(ex.Message, "Thông báo");
#endif
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}