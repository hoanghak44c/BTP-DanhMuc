using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMLoaiSanPhamInfo
    {
        [DefaultDisplay(false)]
        public int IdLoaiSP { get; set; }
        [CaptionColumn("Mã loại sản phẩm")]
        public string MaLoaiSP { get; set; }
        [CaptionColumn("Tên loại sản phẩm")]
        public string TenLoaiSP { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
        [CaptionColumn("Nhóm cha")]
        public int NhomCha { get; set; }
        [CaptionColumn("Lĩnh vực")]
        public string LinhVuc { get; set; }
        [CaptionColumn("Ngành")]
        public string Nganh { get; set; }
        [CaptionColumn("Loại")]
        public string Loai { get; set; }
        [CaptionColumn("Chủng")]
        public string Chung { get; set; }
        [CaptionColumn("Nhóm")]
        public string Nhom { get; set; }
        [CaptionColumn("Hãng")]
        public string Hang { get; set; }

        public string Model { get; set; }

    }
}
