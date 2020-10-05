using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMListInfor
    {
        [CaptionColumn("Tên bảng")]
        public string TblName { get; set; }
        [CaptionColumn("Tên danh mục")]
        public string Name { get; set; }
        [CaptionColumn("Chỉ sử dụng tại POS"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int OnlyPOS { get; set; }
    }
}
