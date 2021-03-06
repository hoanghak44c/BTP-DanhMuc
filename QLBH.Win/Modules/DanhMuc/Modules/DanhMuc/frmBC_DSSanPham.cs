using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using QLBanHang.Modules.DanhMuc.Reports;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmBC_DSSanPham : frmBCBase
    {
        public frmBC_DSSanPham()
        {
            InitializeComponent();
            Common.LoadStyle(this);
            rpt = new rpt_BC_DSSanPham();
        }


        private void frm_BaoCaoDSHangHoa_Load(object sender, EventArgs e)
        {
//            string sql;
//            sql = @"SELECT     IdTrungTam, TenTrungTam FROM tbl_DM_TrungTam";
//            ut.LoadComboBox(cboTrungTam, sql,0,"");
//            sql = string.Format(@"SELECT IdDoiTuong, TenDoiTuong  FROM tbl_DM_DoiTuong
//                  WHERE Type IN ({0},{1})", (int)CustomerType.NHA_CUNG_CAP, (int)CustomerType.DAI_LY);
            
        }
                    

        private void cboTrungTam_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdIn_Click(object sender, EventArgs e)
        {
            try {
                ShowReport("Danh sách sản phẩm");
            }
            catch (System.Exception ex) {
#if DEBUG
                MessageBox.Show(ex.ToString());
#else
                MessageBox.Show(ex.Message);
#endif
            }
        }
        protected override void OnSetParameterFields(ParameterFields myParams)
        {
            //myParams.Clear();
            //ut.SetParameterReport(myParams, "pTrungTam", cboTrungTam.Text);
            //ut.SetParameterReport(myParams, "pKho", cboKho.Text);
            
        }

        protected override string OnSetSqlParameters(string cmdTextFormatString)
        {
            if (!String.IsNullOrEmpty(txtMaSanPham.Text))
                cmdTextFormatString += String.Format(" and tbl_SanPham.MaSanPham like N'%{0}%'", txtMaSanPham.Text);
            if (!String.IsNullOrEmpty(txtTenSanPham.Text))
                cmdTextFormatString += String.Format(" and tbl_SanPham.TenSanPham like N'%{0}%'", txtTenSanPham.Text);
            
            return cmdTextFormatString;

        }
        protected override void OnLoadReport()
        {
            string sql = @"SELECT     tbl_SanPham.IdSanPham, tbl_SanPham.MaSanPham, tbl_SanPham.TenSanPham, tbl_DM_DonViTinh.TenDonViTinh, 
                      tbl_SanPham.GiaNhap, tbl_SanPham.Mota
FROM         tbl_DM_DonViTinh INNER JOIN
                      tbl_SanPham ON tbl_DM_DonViTinh.IdDonViTinh = tbl_SanPham.IdDonViTinh";
            sql += " WHERE 1=1";
            base.SetParameterFields();
            base.SetSqlParameters(sql, CommandType.Text, "vBCDSSanPham");
        }
        private void cboTrungTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}