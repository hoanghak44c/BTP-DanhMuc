using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DMLyDoTraHangDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMLyDoTraHangInfo>
    {
        private static DMLyDoTraHangDataProvider instance;
        private DMLyDoTraHangDataProvider()
        {
            controllerDAO = DmLyDoTraHangDAO.Instance;
        }

        public static DMLyDoTraHangDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMLyDoTraHangDataProvider();
                return instance;
            }   
        }
        public List<DMLyDoTraHangInfo> GetListLyDoTraHangInfo()
        {
            return DmLyDoTraHangDAO.Instance.GetListLyDoTraHangInfor();
        }
        public List<DMLyDoTraHangInfo> Search(DMLyDoTraHangInfo match)
        {
            return DmLyDoTraHangDAO.Instance.Search(match);
        }
        public DMLyDoTraHangInfo GetFullInfoByKey(params object[] keyParams)
        {
            return DmLyDoTraHangDAO.Instance.GetLyDoTraHangByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMLyDoTraHangInfo dmLyDoTraHangInfo)
        {
            return DmLyDoTraHangDAO.Instance.Insert(dmLyDoTraHangInfo);
        }

        public void Update(DMLyDoTraHangInfo dmLyDoTraHangInfo)
        {
            DmLyDoTraHangDAO.Instance.Update(dmLyDoTraHangInfo);
        }

        public void Delete(DMLyDoTraHangInfo dmLyDoTraHangInfo)
        {
            DmLyDoTraHangDAO.Instance.Delete(dmLyDoTraHangInfo);
        }

        public bool IsExisted(DMLyDoTraHangInfo dmLyDoTraHangInfo)
        {
            return DmLyDoTraHangDAO.Instance.Exist(dmLyDoTraHangInfo);
        }

        public bool IsUsed(DMLyDoTraHangInfo checkInfo)
        {
            return false;
        }
    }
}
