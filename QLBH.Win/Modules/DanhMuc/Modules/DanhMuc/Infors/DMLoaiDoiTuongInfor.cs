using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DmLoaiDoiTuongInfor
    {
        [DefaultDisplay(false)]
        public int IdLoaiDT { get; set; }
        [CaptionColumn("Nhóm cha")]
        public int NhomCha { get; set; }
        [CaptionColumn("Mã loại đối tượng")]
        public string MaLoaiDT { get; set; }
        [CaptionColumn("Tên loại đối tượng")]
        public string TenLoaiDT { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }

    }
}
