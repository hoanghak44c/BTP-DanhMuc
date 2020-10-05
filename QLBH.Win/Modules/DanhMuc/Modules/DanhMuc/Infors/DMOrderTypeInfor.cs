using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMOrderTypeInfor
    {
        public int IdOrderType { get; set; }

        public string OrderType { get; set; }
        [CaptionColumn("Tên")]
        public string Name { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }

        public string LineType { get; set; }

        public string LineKm { get; set; }

        public string LineCk { get; set; }
        [CaptionColumn("Ngành hàng")]
        public string NganhHang { get; set; }
    }
}
