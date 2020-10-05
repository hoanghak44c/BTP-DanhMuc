using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DMLyDoGiaoDichDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMLyDoGiaoDichInfo>
    {
        private static DMLyDoGiaoDichDataProvider instance;
        private DMLyDoGiaoDichDataProvider()
        {
            controllerDAO = DmLyDoGiaoDichDAO.Instance;
        }

        public static DMLyDoGiaoDichDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMLyDoGiaoDichDataProvider();
                return instance;
            }   
        }
        public List<DMLyDoGiaoDichInfo> GetListLyDoGiaoDichInfo()
        {
            return DmLyDoGiaoDichDAO.Instance.GetListLyDoGiaoDichInfor();
        }
        public List<DMLyDoGiaoDichInfo> Search(DMLyDoGiaoDichInfo match)
        {
            return DmLyDoGiaoDichDAO.Instance.Search(match);
        }
        public DMLyDoGiaoDichInfo GetFullInfoByKey(params object[] keyParams)
        {
            return DmLyDoGiaoDichDAO.Instance.GetLyDoGiaoDichByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMLyDoGiaoDichInfo dmLyDoGiaoDichInfo)
        {
            return DmLyDoGiaoDichDAO.Instance.Insert(dmLyDoGiaoDichInfo);
        }

        public void Update(DMLyDoGiaoDichInfo dmLyDoGiaoDichInfo)
        {
            DmLyDoGiaoDichDAO.Instance.Update(dmLyDoGiaoDichInfo);
        }

        public void Delete(DMLyDoGiaoDichInfo dmLyDoGiaoDichInfo)
        {
            DmLyDoGiaoDichDAO.Instance.Delete(dmLyDoGiaoDichInfo);
        }

        public bool IsExisted(DMLyDoGiaoDichInfo dmLyDoGiaoDichInfo)
        {
            return DmLyDoGiaoDichDAO.Instance.Exist(dmLyDoGiaoDichInfo);
        }

        public bool IsUsed(DMLyDoGiaoDichInfo checkInfo)
        {
            return false;
        }
    }
}
