using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMKhoCBOLoadInfo
    {
        public int IdTrungTam { get; set; }

        public string MaTrungTam { get; set; }

        public string TenTrungTam { get; set; }

        public int IdKho { get; set; }

        public string MaKho { get; set; }

        public string TenKho { get; set; }

        public int SuDung { get; set; }

        public DateTime NgayDuDau { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is DMKhoCBOLoadInfo)
            {
                return Equals((DMKhoCBOLoadInfo) obj);
            }
            return base.Equals(obj);
        }

        public bool Equals(DMKhoCBOLoadInfo other)
        {
            return other.IdKho == IdKho && other.IdTrungTam == IdTrungTam && Equals(other.TenKho, TenKho) && other.SuDung == SuDung;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = IdKho;
                result = (result*397) ^ IdTrungTam;
                result = (result*397) ^ (TenKho != null ? TenKho.GetHashCode() : 0);
                result = (result*397) ^ SuDung;
                return result;
            }
        }
    }
}
