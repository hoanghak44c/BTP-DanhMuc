using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMLoaiItemInfor
    {
        [DefaultDisplay(false)]
        public int IdLoaiItem { get; set; }
        [CaptionColumn("Mã loại Item")]
        public string MaLoaiItem { get; set; }
        [CaptionColumn("Tên loại Item")]
        public string TenLoaiItem { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
    }
}
