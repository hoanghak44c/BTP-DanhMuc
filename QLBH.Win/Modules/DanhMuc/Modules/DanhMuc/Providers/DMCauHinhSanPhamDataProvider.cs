using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.DAO;

// <Remarks>
// Tạo DMDuAnProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 08/03/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DMCauHinhSanPhamDataProvider //: SynchronizableProvider, IDanhMucEditInfor<DMCauHinhSanPhamInfo>
    {
        private static DMCauHinhSanPhamDataProvider instance;
        //private DMCauHinhSanPhamDataProvider()
        //{
        //    controllerDAO = DmCauHinhSanPhamDAO.Instance;
        //}

        public static DMCauHinhSanPhamDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMCauHinhSanPhamDataProvider();
                return instance;
            }   
        }
        public List<DMCauHinhSanPhamInfo> GetListCauHinhSanPham()
        {
            return DmCauHinhSanPhamDAO.Instance.GetListCauHinhSanPham();
        }
        public List<DMCauHinhSanPhamInfo> GetListSearchCauHinhSanPhamCo(int ton)
        {
            return DmCauHinhSanPhamDAO.Instance.GetListSearchCauHinhSanPhamCo(ton);
        }
        public List<DMCauHinhSanPhamInfo> GetListSearchCauHinhSanPhamKhong(int ton)
        {
            return DmCauHinhSanPhamDAO.Instance.GetListSearchCauHinhSanPhamKhong(ton);
        }
       public DMCauHinhSanPhamInfo GetNhaCCByIdSanPham(int idSanPham)
       {
           return DmCauHinhSanPhamDAO.Instance.GetNhaCCByIdSanPham(idSanPham);
       }
       public void Insert(int idSanPham, string tenCauHinh,string giaTri,int soTT)
       {
            DmCauHinhSanPhamDAO.Instance.Insert(idSanPham,tenCauHinh,giaTri,soTT);
       }

       public void Delete(DMCauHinhSanPhamInfo dmCauHinhSanPhamInfo)
       {
           DmCauHinhSanPhamDAO.Instance.Delete(dmCauHinhSanPhamInfo);
       }

       public void Delete(int idSanPham)
       {
           DmCauHinhSanPhamDAO.Instance.Delete(idSanPham);
       }

        public bool IsExisted(DMCauHinhSanPhamInfo checkInfo)
        {
            throw new NotImplementedException();
        }

        public bool DaCoCauHinh(int idSanPham)
        {
            return DmCauHinhSanPhamDAO.Instance.DaCoCauHinh(idSanPham);
        }

        public void Update(int idSanPham, string tenCauHinh, string giaTri, int soTT)
        {
            DmCauHinhSanPhamDAO.Instance.Update(idSanPham, tenCauHinh, giaTri, soTT);
        }
        public void UpdateLogo(int idSanPham,string loGo)
        {
            DmCauHinhSanPhamDAO.Instance.UpdateLogo(idSanPham,loGo);
        }
       //public bool IsExisted(DMCauHinhSanPhamInfo dmCauHinhSanPhamInfo)
       //{
       //    return DmCauHinhSanPhamDAO.Instance.Exist(dmCauHinhSanPhamInfo);
       //}

       public bool IsUsed(DMCauHinhSanPhamInfo checkInfo)
       {
           return false;
       }

       public List<DMCauHinhSanPhamInfo> Search(DMCauHinhSanPhamInfo match)
       {
           return DmCauHinhSanPhamDAO.Instance.Search(match);
       }

       public List<DMCauHinhSanPhamInfo> GetCauHinhByIdSanPham(int idSanPham)
       {
           List<DMCauHinhSanPhamInfo> result = DmCauHinhSanPhamDAO.Instance.GetCauHinhByIdSanPham(idSanPham);
           
           result.ForEach(delegate (DMCauHinhSanPhamInfo action)
                              {
                                  action.SetOrigin();
                              });
           return result;
       }
    }
}
