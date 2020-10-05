using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DMPhuongThucBHDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMPhuongThucBanHangInfo>
    {
        private static DMPhuongThucBHDataProvider instance;
        private DMPhuongThucBHDataProvider()
        {
            controllerDAO = DmPhuongThucBanHangDAO.Instance;
        }

        public static DMPhuongThucBHDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMPhuongThucBHDataProvider();
                return instance;
            }   
        }
        public List<DMPhuongThucBanHangInfo> GetListPhuongThucBHInfo()
        {
            return DmPhuongThucBanHangDAO.Instance.GetListPhuongThucBanHangInfor();
        }
        public List<DMPhuongThucBanHangInfo> Search(DMPhuongThucBanHangInfo match)
        {
            return DmPhuongThucBanHangDAO.Instance.Search(match);
        }
        public DMPhuongThucBanHangInfo GetFullInfoByKey(params object[] keyParams)
        {
            return DmPhuongThucBanHangDAO.Instance.GetPhuongThucBanHangByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMPhuongThucBanHangInfo dmPhuongThucBanHangInfo)
        {
            return DmPhuongThucBanHangDAO.Instance.Insert(dmPhuongThucBanHangInfo);
        }

        public void Update(DMPhuongThucBanHangInfo dmPhuongThucBanHangInfo)
        {
            DmPhuongThucBanHangDAO.Instance.Update(dmPhuongThucBanHangInfo);
        }

        public void Delete(DMPhuongThucBanHangInfo dmPhuongThucBanHangInfo)
        {
            DmPhuongThucBanHangDAO.Instance.Delete(dmPhuongThucBanHangInfo);
        }

        public bool IsExisted(DMPhuongThucBanHangInfo dmPhuongThucBanHangInfo)
        {
            return DmPhuongThucBanHangDAO.Instance.Exist(dmPhuongThucBanHangInfo);
        }

        public bool IsUsed(DMPhuongThucBanHangInfo checkInfo)
        {
            return false;
        }
    }
}
