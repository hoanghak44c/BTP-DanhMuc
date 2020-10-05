using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DMChiPhiDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMChiPhiInfo>
    {
        private static DMChiPhiDataProvider instance;
        private DMChiPhiDataProvider()
        {
            controllerDAO = DmChiPhiDAO.Instance;
        }

        public static DMChiPhiDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMChiPhiDataProvider();
                return instance;
            }   
        }
        public List<DMChiPhiInfo> GetListChiPhiInfo()
        {
            return DmChiPhiDAO.Instance.GetListChiPhiInfor();
        }
        public List<DMChiPhiInfo> GetListActivedChiPhiInfo()
        {
            return DmChiPhiDAO.Instance.GetListActivedChiPhiInfor();
        }

        public DMChiPhiInfo GetFullInfoByKey(params object[] keyParams)
        {
            return DmChiPhiDAO.Instance.GetChiPhiByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMChiPhiInfo dmChiPhiInfo)
        {
            return DmChiPhiDAO.Instance.Insert(dmChiPhiInfo);
        }

        public void Update(DMChiPhiInfo dmChiPhiInfo)
        {
            DmChiPhiDAO.Instance.Update(dmChiPhiInfo);
        }

        public void Delete(DMChiPhiInfo dmChiPhiInfo)
        {
            DmChiPhiDAO.Instance.Delete(dmChiPhiInfo);
        }

        public bool IsExisted(DMChiPhiInfo dmChiPhiInfo)
        {
            return DmChiPhiDAO.Instance.Exist(dmChiPhiInfo);
        }

        public bool IsUsed(DMChiPhiInfo checkInfo)
        {
            return false;
        }
        public List<DMChiPhiInfo> Search(DMChiPhiInfo match)
        {
            return DmChiPhiDAO.Instance.Search(match);
        }
    }
}
