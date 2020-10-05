﻿using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMLoaiHoaDonInfo
    {
        [DefaultDisplay(false)]
        public int Id { get; set; }
        [CaptionColumn("Ký hiệu")]
        public string KyHieu { get; set; }
        [CaptionColumn("Tên")]
        public string Ten { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
    }
}
