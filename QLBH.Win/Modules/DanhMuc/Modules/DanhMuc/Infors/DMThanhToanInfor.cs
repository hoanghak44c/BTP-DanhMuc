using System;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMThanhToanInfor
    {
        [DefaultDisplay(false)]
        public int IdThanhToan { get; set; }
        [CaptionColumn("Mã")]
        public string Ma { get; set; }
        [CaptionColumn("Tên")]
        public string Ten { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
        [CaptionColumn("Loại thanh toán")]
        public int LoaiThanhToan { get; set; }
    }
}
