using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMTaiKhoanQuyInfo
    {
        [CaptionColumn("Tài khoản quỹ")]
        public string TaiKhoanQuy { get; set; }
        [CaptionColumn("Ngân hàng")]
        public string NganHang { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
        [CaptionColumn("ID trung tâm")]
        public int IdTrungTam { get; set; }
        [CaptionColumn("ID ngân hàng")]
        public int IdNganHang { get; set; }
    }
}
