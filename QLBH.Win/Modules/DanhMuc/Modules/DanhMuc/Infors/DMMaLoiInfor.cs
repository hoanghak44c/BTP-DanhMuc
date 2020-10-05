using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMMaLoiInfor
    {
        [DefaultDisplay(false)]
        public int IdMaLoi { get; set; }
        [CaptionColumn("Mã lỗi")]
        public string MaLoi { get; set; }
        [DefaultDisplay(false)]
        public int IdLoaiItem { get; set; }
        [CaptionColumn("Tên lỗi")]
        public string TenLoi { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
        [CaptionColumn("Tên loại sản phẩm")]
        public string TenLoaiSP { get; set; }
    }
}
