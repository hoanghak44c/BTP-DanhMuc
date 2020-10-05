using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class SegmentChildInfo : SegmentInfo
    {
        [CaptionColumn("Mã cha")]
        public string MaCha { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is SegmentChildInfo && Ma == ((SegmentChildInfo)obj).Ma && MaCha == ((SegmentChildInfo)obj).MaCha;
        }
    }
}
