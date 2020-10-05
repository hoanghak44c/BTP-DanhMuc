using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMTrungTamInfor
    {
        [DefaultDisplay(false), CaptionColumn("ID")]
        public int IdTrungTam { get; set; }
        /// <summary>
        /// Được dùng để đồng bộ
        /// </summary>
        [CaptionColumn("Mã Trung Tâm")]
        public string MaTrungTam { get; set; }
        /// <summary>
        /// Được dùng để đồng bộ
        /// </summary>
        [CaptionColumn("Tên Trung Tâm")]
        public string TenTrungTam { get; set; }
        /// <summary>
        /// Được dùng để đồng bộ
        /// </summary>
        [CaptionColumn("Địa Chỉ")]
        public string DiaChi { get; set; }
        [CaptionColumn("Điện Thoại")]
        public string DienThoai { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }
        [CaptionColumn("Ghi Chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
        [DefaultDisplay(false)]
        public int IdBangGia { get; set; }
        [DefaultDisplay(false)]
        public int Price_List_Id { get; set; }
        [CaptionColumn("Vị Trí")]
        public string ViTri { get; set; }
        [CaptionColumn("Đường")]
        public string Duong { get; set; }
        [CaptionColumn("Tỉnh")]
        public string Tinh { get; set; }
        [CaptionColumn("Quốc Gia")]
        public string QuocGia { get; set; }
        [CaptionColumn("ChannelCode")]
        public string ChannelCode { get; set; }

    }
}
