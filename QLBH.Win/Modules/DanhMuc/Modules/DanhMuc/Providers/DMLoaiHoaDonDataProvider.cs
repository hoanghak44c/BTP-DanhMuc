using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DMLoaiHoaDonDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMLoaiHoaDonInfo>
    {
        private static DMLoaiHoaDonDataProvider instance;
        private DMLoaiHoaDonDataProvider()
        {
            controllerDAO = DmLoaiHoaDonDAO.Instance;
        }

        public static DMLoaiHoaDonDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMLoaiHoaDonDataProvider();
                return instance;
            }   
        }
        public List<DMLoaiHoaDonInfo> GetListLoaiHoaDonInfo()
        {
            return  DmLoaiHoaDonDAO.Instance.GetListLoaiHoaDonInfor();
        }

        public DMLoaiHoaDonInfo GetFullInfoByKey(params object[] keyParams)
        {
            return DmLoaiHoaDonDAO.Instance.GetLoaiHoaDonByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMLoaiHoaDonInfo dmLoaiHoaDonInfo)
        {
            return DmLoaiHoaDonDAO.Instance.Insert(dmLoaiHoaDonInfo);
        }

        public void Update(DMLoaiHoaDonInfo dmLoaiHoaDonInfo)
        {
            DmLoaiHoaDonDAO.Instance.Update(dmLoaiHoaDonInfo);
        }

        public void Delete(DMLoaiHoaDonInfo deleteInfo)
        {
            DmLoaiHoaDonDAO.Instance.Delete(deleteInfo);
        }

        public bool IsExisted(DMLoaiHoaDonInfo checkInfo)
        {
            return DmLoaiHoaDonDAO.Instance.Exist(checkInfo);
        }

        public bool IsUsed(DMLoaiHoaDonInfo checkInfo)
        {
            return true;
        }
        public List<DMLoaiHoaDonInfo> Search(DMLoaiHoaDonInfo match)
        {
            return DmLoaiHoaDonDAO.Instance.Search(match);
        }
    }
}
