using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

// <Remarks>

// </remarks>

namespace QLBanHang.Modules.DanhMuc.Providers
{

    public class DMCaBanHangDataProvider
    {
        private static DMCaBanHangDataProvider instance;
        public static DMCaBanHangDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMCaBanHangDataProvider();
                return instance;
            }   
        }
        public List<DmCaBanHangInfor> GetListCaBanHangInfors()
        {
            return DmCaBanHangDAO.Instance.GetListCaBanHangInfors();
        }
        public DmCaBanHangInfor GetCurrentCaBanHangInfors()
        {
            DmCaBanHangInfor t = DmCaBanHangDAO.Instance.GetCurrentCaBanHangInfors();
            if (t == null) t = new DmCaBanHangInfor() {CaBanHang = "Không xác định", KyHieu = ""};
            return t;
        }
    }
}
