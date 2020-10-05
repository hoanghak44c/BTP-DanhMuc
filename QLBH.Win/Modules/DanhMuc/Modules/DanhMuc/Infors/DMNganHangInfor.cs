using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMNganHangInfor
    {
        [DefaultDisplay(false)]
        public int IdNganHang { get; set; }
        [CaptionColumn("Mã ngân hàng")]
        public string MaNganHang { get; set; }
        [CaptionColumn("Tên ngân hàng")]
        public string TenNganHang { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
    }
}
