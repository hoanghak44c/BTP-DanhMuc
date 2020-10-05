using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Core.Data;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    // <Remarks>
    // Tạo DMTrungTamProvider
    // Người tạo: Bùi Đức Hạnh
    // Ngày tạo : 01/03/2012
    // Người sửa cuối:01/03/2012
    // </remarks>
    [Serializable]
    public class TblDMTrungTam : DataObject
    {
        public override string GetDataObjectName()
        {
            return Declare.TableNamespace.DmTrungTam;
        }
    }
    [Serializable]
    public class DMTrungTamInfor :TblDMTrungTam
    {
        public DMTrungTamInfor()
        {
            SetNullValues(this);
        }

        [IsKey(true)]
        [NullValue(-1)]
        public int Number { get; set; }

        [NullValue("")]
        public string MaTrungTam { get; set; }

        [NullValue("")]
        public string TenTrungTam { get; set; }

        [NullValue("")]
        public string DiaChi { get; set; }

        [NullValue("")]
        public string Fax { get; set; }

        [NullValue("")]
        public string Email { get; set; }

        [NullValue("")]
        public string GhiChu { get; set; }

        [NullValue(-1)]
        public int SuDung { get; set; }

        [NullValue(-1)]
        public int IdBangGia { get; set; }

        [NullValue(-1)]
        public int Price_List_Id { get; set; }
    }
   public class DM_TrungTamDataProvider
    {
       public static List<DMTrungTamInfor> GetListTrungTamInfo()
       {
           return ProviderBase.SelectAll<DMTrungTamInfor>();
       }
    }
}
