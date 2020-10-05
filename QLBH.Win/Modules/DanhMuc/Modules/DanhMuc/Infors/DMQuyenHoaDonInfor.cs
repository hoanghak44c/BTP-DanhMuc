using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMQuyenHoaDonInfor
    {
        [CaptionColumn("Ký hiệu hóa đơn")]        
        public string KyHieuHoaDon { get; set; }
        [CaptionColumn("Ký tự đầu serie")]
        public string KyTuDauSerie { get; set; }
        [CaptionColumn("Số lượng")]
        public int SoLuong { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
    }
}
