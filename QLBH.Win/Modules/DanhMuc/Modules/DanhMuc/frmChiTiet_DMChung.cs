using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Properties;

// <Remarks>
// form frmChiTiet_DMChung
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 25/04/2012
// Ngày sửa cuối:
// </remarks>
//Note:@HanhBD frmChiTiet_DMChung
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_DMChung : frmEditBase
    {
        public frmChiTiet_DMChung()
        {
            InitializeComponent();
            btnClose.Click += btnDong_Click;
            btnXoa.Click += btnXoa_Click;
            btnCapNhat.Click += btnCapNhat_Click;
            btnCapNhat.Text = Resources.btnSave;
            btnXoa.Text = Resources.btnDelete;
            btnDong.Text = Resources.btnClose;
        }

        private void frmChiTiet_DMChung_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            QLBH.Core.QLBHUtils.PerformShortCutKey(this,e.KeyCode);
        }
    }
}
