using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DMBangKeThueDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMBangKeThueInfo>
    {
        private static DMBangKeThueDataProvider instance;
        private DMBangKeThueDataProvider()
        {
            controllerDAO = DmBangKeThueDAO.Instance;
        }

        public static DMBangKeThueDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMBangKeThueDataProvider();
                return instance;
            }   
        }
        public List<DMBangKeThueInfo> GetListBangKeThueInfo()
        {
            return DmBangKeThueDAO.Instance.GetListBangKeThueInfor();
        }
        public List<DMBangKeThueInfo> Search(DMBangKeThueInfo match)
        {
            return DmBangKeThueDAO.Instance.Search(match);
        }
        public DMBangKeThueInfo GetFullInfoByKey(params object[] keyParams)
        {
            return DmBangKeThueDAO.Instance.GetBangKeThueByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMBangKeThueInfo dmBangKeThueInfo)
        {
            return DmBangKeThueDAO.Instance.Insert(dmBangKeThueInfo);
        }

        public void Update(DMBangKeThueInfo dmBangKeThueInfo)
        {
            DmBangKeThueDAO.Instance.Update(dmBangKeThueInfo);
        }

        public void Delete(DMBangKeThueInfo dmBangKeThueInfo)
        {
            DmBangKeThueDAO.Instance.Delete(dmBangKeThueInfo);
        }

        public bool IsExisted(DMBangKeThueInfo dmBangKeThueInfo)
        {
            return DmBangKeThueDAO.Instance.Exist(dmBangKeThueInfo);
        }

        public bool IsUsed(DMBangKeThueInfo dmBangKeThueInfo)
        {
            return false;
        }
    }
}
