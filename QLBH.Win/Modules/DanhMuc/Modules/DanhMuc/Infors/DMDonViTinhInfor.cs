using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMDonViTinhInfor
    {
        [DefaultDisplay(false)]
        public int IdDonViTinh { get; set; }
        [CaptionColumn("Ký hiệu")]
        public string KyHieu { get; set; }
        [CaptionColumn("Tên đơn vị tính")]
        public string TenDonViTinh { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
    }
}
