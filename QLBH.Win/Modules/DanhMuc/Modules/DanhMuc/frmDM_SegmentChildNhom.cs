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
    public partial class frmDM_SegmentChildNhom : frmDM_SegmentChild
    {
        public frmDM_SegmentChildNhom()
        {
            InitializeComponent();
            dmSegmentChildDataProvider = DmNhomDataProvider.Instance;
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
        }
        protected override void LoadData()
        {
            grcBase.DataSource = DmNhomDataProvider.Instance.GetListSegmentChildInfor();
        }

        private void frmDM_SegmentChildNhom_OnCapNhat(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmentChildNhom frm = new frmChiTiet_SegmentChildNhom(Info);
                frm.ShowDialog();
            }
        }

        void frmDM_SegmentChildNhom_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Info = ((SegmentChildInfo)dgvDanhSachMatHang.GetFocusedRow());
            btnXoa.Enabled = false;
        }

        private void frmDM_SegmentChildNhom_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Info != null)
            {
                isAdd = false;
                frmChiTiet_SegmentChildNhom frm = new frmChiTiet_SegmentChildNhom(Info);
                frm.ShowDialog();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = dmSegmentChildDataProvider.SearchSegmentChildInfor(txtTimKiemMa.Text, txtTimKiemTen.Text);
        }
    }
}