using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;

// <Remarks>
// Tạo DMBieuMauThueProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 09/03/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.DanhMuc.Providers
{

    public class DMTaxCodeDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMTaxCodeInfor>
    {
        private static DMTaxCodeDataProvider instance;

        private DMTaxCodeDataProvider()
        {
            controllerDAO = DmTaxCodeDAO.Instance;
        }

        public static DMTaxCodeDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMTaxCodeDataProvider();
                return instance;
            }   
        }
        public static List<DMTaxCodeInfor> GetListTaxCodeInfor()
        {
            return DmTaxCodeDAO.Instance.GetListTaxCodeInfo();
        }

        public DMTaxCodeInfor GetFullInfoByKey(params object[] keyParams)
        {
            return DmTaxCodeDAO.Instance.GetTaxCodeByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMTaxCodeInfor dmTaxCodeInfor)
        {
            return DmTaxCodeDAO.Instance.Insert(dmTaxCodeInfor);
        }

        public void Delete(DMTaxCodeInfor dmTaxCodeInfor)
        {
            DmTaxCodeDAO.Instance.Delete(dmTaxCodeInfor);
        }

        public void Update(DMTaxCodeInfor dmTaxCodeInfor)
        {
            DmTaxCodeDAO.Instance.Update(dmTaxCodeInfor);
        }

        public  bool IsExisted(DMTaxCodeInfor dmTaxCodeInfor)
        {
            return DmTaxCodeDAO.Instance.Exist(dmTaxCodeInfor);
        }

        public bool IsUsed(DMTaxCodeInfor checkInfo)
        {
            return false;
        }

        public static List<DMTaxCodeInfor> Search(DMTaxCodeInfor dmMaLoiInfor)
        {
            return DmTaxCodeDAO.Instance.Search(dmMaLoiInfor);
        }
    }
}
