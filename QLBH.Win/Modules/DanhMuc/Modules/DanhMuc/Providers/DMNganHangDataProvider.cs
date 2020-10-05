using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

// <Remarks>
// Tạo DMBieuMauThueProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 09/03/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.DanhMuc.Providers
{

    public class DMNganHangDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMNganHangInfor>
    {
        private static DMNganHangDataProvider instance;

        private DMNganHangDataProvider()
        {
            controllerDAO = DmNganHangDAO.Instance;
        }

        public static DMNganHangDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMNganHangDataProvider();
                return instance;
            }   
        }
        public List<DMNganHangInfor> GetListNganHangInfors()
        {
            return DmNganHangDAO.Instance.GetListNganHangInfors();
        }

        public DMNganHangInfor GetFullInfoByKey(params object[] keyParams)
        {
            return DmNganHangDAO.Instance.GetNganHangByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMNganHangInfor insertInfo)
        {
            return DmNganHangDAO.Instance.Insert(insertInfo);
        }

        public void Update(DMNganHangInfor updateInfo)
        {
            DmNganHangDAO.Instance.Update(updateInfo);
        }

        public void Delete(DMNganHangInfor deleteInfo)
        {
            DmNganHangDAO.Instance.Delete(deleteInfo);
        }

        public bool IsExisted(DMNganHangInfor checkInfo)
        {
            return DmNganHangDAO.Instance.Exist(checkInfo);
        }

        public bool IsUsed(DMNganHangInfor checkInfo)
        {
            return false;
        }
        public List<DMNganHangInfor> Search(DMNganHangInfor match)
        {
            return DmNganHangDAO.Instance.Search(match);
        }
        public DMNganHangInfor GetNganHangByText(string nganHang)
        {
            return DmNganHangDAO.Instance.GetNganHangByText(nganHang);
        }
        public DMNganHangInfor GetNganHangById(int idNganHang)
        {
            return DmNganHangDAO.Instance.GetNganHangByIdInfo(idNganHang);
        }
    }
}
