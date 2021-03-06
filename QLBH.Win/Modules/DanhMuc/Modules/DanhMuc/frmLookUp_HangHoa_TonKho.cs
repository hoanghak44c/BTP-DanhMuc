using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc;
using QLBH.Common;
using QLBH.Common.Objects;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common.Providers;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmLookUp_HangHoa_TonKho : DevExpress.XtraEditors.XtraForm
    {
        private DMSanPhamBriefInfo SanPham;

        public frmLookUp_HangHoa_TonKho()
        {
            InitializeComponent();
            Common.LoadStyle(this);
        }

        public frmLookUp_HangHoa_TonKho(DMSanPhamBriefInfo sp)
        {
            InitializeComponent();
            Common.LoadStyle(this);
            this.SanPham = sp;
        }

        private void frm_ThietLapKM_Load(object sender, EventArgs e)
        {
            LoadSanPhamInfor();
            LoadTonChiTiet();
        }

        private void LoadSanPhamInfor()
        {
            txtSanPham.Text = SanPham.MaSanPham + " - " + SanPham.TenSanPham;
            txtDonViTinh.Text = SanPham.TenDonViTinh;
        }

        private void LoadTonChiTiet()
        {
            List<ItemTonKhoInfor> liTonKho = DmSanPhamProvider.Instance.LoadTonKhoTheoTrungTam(SanPham.IdSanPham);
            gTonKho.DataSource = liTonKho;
            gvTonKho.ExpandAllGroups();
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThietLapKM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.cmdDong_Click(sender, e);
        }
    }
}