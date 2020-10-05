using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;

// <Remarks>
// DMLoaiThuChiDataProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 02/03/2012
//Người sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc.Providers
{
    //[Serializable]
    //public class TblDMThanhToan : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmThanhToan;
    //    }
    //}
    //[Serializable]
    //public class DMThanhToanInfor :TblDMThanhToan
    //{
    //    public DMThanhToanInfor()
    //    {
    //        SetNullValues(this);
    //    }

    //    [NullValue(-1)]
    //    [IsKey(false)]
    //    public int IdThanhToan { get; set; }

    //    [NullValue("")]
    //    public string HinhThucThanhToan { get; set; }
    //}
    public class DMThanhToanDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMThanhToanInfor>
    {
        private static DMThanhToanDataProvider instance;
        private DMThanhToanDataProvider()
        {
            controllerDAO = DmThanhToanDAO.Instance;
        }

        public static DMThanhToanDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMThanhToanDataProvider();
                return instance;
            }   
        }
       public static List<DMThanhToanInfor> GetListDMThanhToanInfo()
       {
           return DmThanhToanDAO.Instance.GetListDmThanhToanInfo();
       }

        public DMThanhToanInfor GetFullInfoByKey(params object[] keyParams)
        {
            return DmThanhToanDAO.Instance.GetThanhToanByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMThanhToanInfor insertInfo)
        {
            return DmThanhToanDAO.Instance.Insert(insertInfo);
        }

        public void Update(DMThanhToanInfor updateInfo)
        {
            DmThanhToanDAO.Instance.Update(updateInfo);
        }

        public void Delete(DMThanhToanInfor deleteInfo)
        {
            DmThanhToanDAO.Instance.Delete(deleteInfo);
        }

        public bool IsExisted(DMThanhToanInfor checkInfo)
        {
            return DmThanhToanDAO.Instance.CheckExist(checkInfo);
        }

        public bool IsUsed(DMThanhToanInfor checkInfo)
        {
            return false;
        }
        public List<DMThanhToanInfor> Search(DMThanhToanInfor match)
        {
            return DmThanhToanDAO.Instance.Search(match);
        }
       // internal static void Insert(DMThanhToanInfor dmThanhToanInfor)
       //{
       //    DmThanhToanDAO.Instance.Insert(dmThanhToanInfor);
       //}

       //internal static void Update(DMThanhToanInfor dmThanhToanInfor)
       //{
       //    DmThanhToanDAO.Instance.Update(dmThanhToanInfor);
       //}

       //internal static bool IsExisted(DMThanhToanInfor match)
       //{
       //    return DmThanhToanDAO.Instance.CheckExist(match);
       //}

       //internal static void Delete(DMThanhToanInfor dmThanhToanInfor)
       //{
       //    DmThanhToanDAO.Instance.Delete(dmThanhToanInfor);
       //}
    }
}
