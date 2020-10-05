using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMTaxCodeInfor
    {
        [DefaultDisplay(false)]
        public int IdTaxCode { get; set; }
        [CaptionColumn("Mã")]
        public string Code { get; set; }
        [CaptionColumn("Tên")]
        public string Name { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
        [CaptionColumn("Giá trị")]
        public int GiaTri { get; set; }
    }
}
