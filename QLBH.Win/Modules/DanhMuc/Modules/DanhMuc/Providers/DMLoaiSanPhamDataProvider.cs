using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DMLoaiSanPhamDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMLoaiSanPhamInfo>
    {
        private static DMLoaiSanPhamDataProvider instance;

        private DMLoaiSanPhamDataProvider()
        {
            controllerDAO = DMLoaiSPDAO.Instance;
        }

        public static DMLoaiSanPhamDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMLoaiSanPhamDataProvider();
                return instance;
            }   
        }
        public static List<DMLoaiSanPhamInfo> GetLoaiSPInfor()
        {
            return DMLoaiSPDAO.Instance.GetListLoaiSPInfo();
        }
        public static List<DMLoaiSPPairInfo> GetLoaiSPPairInfor()
        {
            return DMLoaiSPDAO.Instance.GetListLoaiSPPairInfo();
        }

        public DMLoaiSanPhamInfo GetFullInfoByKey(params object[] keyParams)
        {
            return DMLoaiSPDAO.Instance.GetLoaiSPByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMLoaiSanPhamInfo dmChucNangInfor)
        {
            return DMLoaiSPDAO.Instance.Insert(dmChucNangInfor);
        }
        public void Delete(DMLoaiSanPhamInfo dmChucNangInfor)
        {
            DMLoaiSPDAO.Instance.Delete(dmChucNangInfor);
        }

        public bool IsExisted(DMLoaiSanPhamInfo checkInfo)
        {
            return DMLoaiSPDAO.Instance.Exist(checkInfo);
        }

        public bool IsUsed(DMLoaiSanPhamInfo checkInfo)
        {
            return false;
        }

        public void Update(DMLoaiSanPhamInfo dmChucNangInfor)
        {
            DMLoaiSPDAO.Instance.Update(dmChucNangInfor);
        }

        public static List<DMLoaiSanPhamInfo> Search(DMLoaiSanPhamInfo match)
        {
            return DMLoaiSPDAO.Instance.Search(match);
        }
        public DMLoaiSanPhamInfo GetLoaiSanPhamByText(string loaisp)
        {
            return DMLoaiSPDAO.Instance.GetLoaiSanPhamByText(loaisp);
        }
    }
}
