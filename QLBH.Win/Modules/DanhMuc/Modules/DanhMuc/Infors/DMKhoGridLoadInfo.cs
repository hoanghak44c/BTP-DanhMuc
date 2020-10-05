using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMKhoGridLoadInfo
    {
        [DefaultDisplay(false)]
        public int IdKho { get; set; }

        [DefaultDisplay(false)]
        public int IdTrungTam { get; set; }

        [CaptionColumn("Mã kho")]
        public string MaKho { get; set; }

        [CaptionColumn("Tên kho")]
        public string TenKho { get; set; }

        [CaptionColumn("Địa chỉ")]
        public string DiaChi { get; set; }

        [CaptionColumn("Điện thoại")]
        public string DienThoai { get; set; }


        public string Fax { get; set; }

        public string Email { get; set; }

        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }

        [CaptionColumn("Mã vùng")]
        public string MaVung { get; set; }

        [CaptionColumn("Trung tâm khác")]
        public string OtherTrungTam { get; set; }

        [CaptionColumn("Mã kho ORC")]
        public string MaKhoOracle { get; set; }

        [CaptionColumn("Kho Demo"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int Type { get; set; }
    }
}
