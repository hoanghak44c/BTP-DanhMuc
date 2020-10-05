using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class SegmentInfo
    {
        [CaptionColumn("Mã")]
        public string Ma { get; set; }
        [CaptionColumn("Tên")]
        public string Ten { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is SegmentInfo && Ma == ((SegmentInfo)obj).Ma;
        }
    }
}
