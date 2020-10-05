using System;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmDM_SegmentChildModel : frmDM_SegmentChild
    {
        public frmDM_SegmentChildModel()
        {
            InitializeComponent();
            dmSegmentChildDataProvider = DmModelDataProvider.Instance;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void frmDM_SegmentChildModel_OnCapNhat(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmentChildModel frm = new frmChiTiet_SegmentChildModel(Info);
                frm.ShowDialog();
            }
        }

        void frmDM_SegmentChildModel_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Info = ((SegmentChildInfo)dgvDanhSachMatHang.GetFocusedRow());
            btnXoa.Enabled = false;
        }

        private void frmDM_SegmentChildModel_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmentChildModel frm = new frmChiTiet_SegmentChildModel(Info);
                frm.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = dmSegmentChildDataProvider.SearchSegmentChildInfor(txtTimKiemMa.Text, txtTimKiemTen.Text);
        }
    }
}