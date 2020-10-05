using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DMCachGiaoHangDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMCachGiaoHangInfo>
    {
        private static DMCachGiaoHangDataProvider instance;
        private DMCachGiaoHangDataProvider()
        {
            controllerDAO = DmCachGiaoHangDAO.Instance;
        }

        public static DMCachGiaoHangDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMCachGiaoHangDataProvider();
                return instance;
            }   
        }
        public List<DMCachGiaoHangInfo> GetListCachGiaoHangInfo()
        {
            return DmCachGiaoHangDAO.Instance.GetListCachGiaoHangInfor();
        }
        public List<DMCachGiaoHangInfo> Search(DMCachGiaoHangInfo match)
        {
            return DmCachGiaoHangDAO.Instance.Search(match);
        }
        public DMCachGiaoHangInfo GetFullInfoByKey(params object[] keyParams)
        {
            return DmCachGiaoHangDAO.Instance.GetCachGiaoHangByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMCachGiaoHangInfo dmCachGiaoHangInfo)
        {
            return DmCachGiaoHangDAO.Instance.Insert(dmCachGiaoHangInfo);
        }

        public void Update(DMCachGiaoHangInfo dmCachGiaoHangInfo)
        {
            DmCachGiaoHangDAO.Instance.Update(dmCachGiaoHangInfo);
        }

        public void Delete(DMCachGiaoHangInfo dmCachGiaoHangInfo)
        {
            DmCachGiaoHangDAO.Instance.Delete(dmCachGiaoHangInfo);
        }

        public bool IsExisted(DMCachGiaoHangInfo dmCachGiaoHangInfo)
        {
            return DmCachGiaoHangDAO.Instance.Exist(dmCachGiaoHangInfo);
        }

        public bool IsUsed(DMCachGiaoHangInfo dmCachGiaoHangInfo)
        {
            return false;
        }
    }
}
