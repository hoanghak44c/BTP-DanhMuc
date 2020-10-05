using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMDuAnInfor
    {
        [DefaultDisplay(false)]
        public int IdDuAn { get; set; }
        [CaptionColumn("Mã dự án")]
        public string MaDuAn { get; set; }
        [CaptionColumn("Tên dự án")]
        public string TenDuAn { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
    }
}
