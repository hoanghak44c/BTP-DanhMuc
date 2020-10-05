using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.DAO;

// <Remarks>
// Tạo DMDuAnProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 08/03/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.DanhMuc.Providers
{
    //[Serializable]
    //public class TblDMDuAn : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmDuAn;
    //    }
    //}
    //[Serializable]
    //public class DMDuAnInfor : TblDMDuAn
    //{
    //    public DMDuAnInfor()
    //    {
    //        SetNullValues(this);
    //    }
    //    [IsKey(false)]
    //    [NullValue(-1)]
    //    public int IdDuAn { get; set; }
    //    [NullValue("")]
    //    public string MaDuAn { get; set; }

    //    [NullValue("")]
    //    public string TenDuAn { get; set; }

    //    [NullValue("")]
    //    public string GhiChu { get; set; }

    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}

    public class DMDuAnDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMDuAnInfor>
    {
        private static DMDuAnDataProvider instance;
        private DMDuAnDataProvider()
        {
            controllerDAO = DmDuAnDAO.Instance;
        }

        public static DMDuAnDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMDuAnDataProvider();
                return instance;
            }   
        }

       public List<DMDuAnInfor> GetListDuAnInfo()
       {
           return DmDuAnDAO.Instance.GetListDuAnInfor();
       }

        public int Insert(DMDuAnInfor dMDuAnInfor)
       {
           return DmDuAnDAO.Instance.Insert(dMDuAnInfor);
       }

       public void Delete(DMDuAnInfor dmDuAnInfor)
       {
           DmDuAnDAO.Instance.Delete(dmDuAnInfor);
       }

       public void Update(DMDuAnInfor dMDuAnInfor)
       {
           DmDuAnDAO.Instance.Update(dMDuAnInfor);
       }

       public bool IsExisted(DMDuAnInfor dmDuAnInfor)
       {
           return DmDuAnDAO.Instance.Exist(dmDuAnInfor);
       }

       public bool IsUsed(DMDuAnInfor checkInfo)
       {
           return false;
       }

       public List<DMDuAnInfor> Search(DMDuAnInfor match)
       {
           return DmDuAnDAO.Instance.Search(match);
       }

       public DMDuAnInfor GetFullInfoByKey(params object[] keyParams)
       {
           return DmDuAnDAO.Instance.GetDuAnByIdInfo(Convert.ToInt32(keyParams[0]));
       }
    }
}
