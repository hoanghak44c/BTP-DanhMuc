﻿using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMChucVuInfor
    {
        [DefaultDisplay(false)]
        public int IdChucVu { get; set; }
        [CaptionColumn("Mã chức vụ")]
        public string MaChucVu { get; set; }
        [CaptionColumn("Tên chức vụ")]
        public string TenChucVu { get; set; }
        [CaptionColumn("Ghi chú")]
        public string GhiChu { get; set; }
        [CaptionColumn("Sử dụng"), XtraGridEditor(typeof(RepositoryItemCheckEdit))]
        public int SuDung { get; set; }
    }
}
