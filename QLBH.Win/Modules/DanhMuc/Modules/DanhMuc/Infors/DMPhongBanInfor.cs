using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMPhongBanInfor
    {
        [DefaultDisplay(false), CaptionColumn("ID")]
        public int IdPhongBan { get; set; }
        [CaptionColumn("Mã Phòng Ban")]
        public string MaPhongBan { get; set; }
        [CaptionColumn("Tên Phòng Ban")]
        public string TenPhongBan { get; set; }
        [CaptionColumn("Ghi Chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
    }
}
