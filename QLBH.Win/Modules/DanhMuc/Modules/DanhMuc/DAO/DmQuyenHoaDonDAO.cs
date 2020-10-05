using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmQuyenHoaDonDAO : SynchronizableDAO
    {
        private static DmQuyenHoaDonDAO instance;
        private DmQuyenHoaDonDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmQuyenHoaDon;
            UseCaching = true;
        }

        public static DmQuyenHoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmQuyenHoaDonDAO();
                return instance;
            }
        }
        public List<DMQuyenHoaDonInfor> GetListQuyenHoaDonInfor()
        {
            return GetListAll<DMQuyenHoaDonInfor>(Declare.StoreProcedureNamespace.spHoaDonSelectAll);
        }

        public List<DMQuyenHoaDonInfor> GetListQuyenHoaDonEmptyInfor()
        {
            return GetListCommand<DMQuyenHoaDonInfor>(Declare.StoreProcedureNamespace.spHoaDonGetAllEmpty);
        }
        internal void Update (DMQuyenHoaDonInfor dmQuyenHoaDonInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spHoaDonUpdate);
            SetParams(dmQuyenHoaDonInfor);
            ExecuteNoneQuery();
        }

        internal void Insert(DMQuyenHoaDonInfor dmQuyenHoaDonInfor)//nếu store không trả về kiểu out hay in thì dùng hàm void 
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spHoaDonInsert);
            SetParams(dmQuyenHoaDonInfor);
            //Parameters["@KyHieuHoaDon"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@KyHieuHoaDon"].Value.ToString());
        }

        internal void Delete(DMQuyenHoaDonInfor dmQuyenHoaDonInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spHoaDonDelete);
            Parameters.AddWithValue("@KyHieuHoaDon", dmQuyenHoaDonInfor.KyHieuHoaDon);
            Parameters.AddWithValue("@KyTuDauSerie", dmQuyenHoaDonInfor.KyTuDauSerie);
            ExecuteNoneQuery();
        }

        internal bool Exist(DMQuyenHoaDonInfor dmQuyenHoaDonInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spHoaDonExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@KyHieuHoaDon", dmQuyenHoaDonInfor.KyHieuHoaDon);
            Parameters.AddWithValue("@KyTuDauSerie", dmQuyenHoaDonInfor.KyTuDauSerie);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }
        internal List<DMQuyenHoaDonInfor> Search(DMQuyenHoaDonInfor dmQuyenHoaDonInfor)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spHoaDonSearch);
            Parameters.AddWithValue("@KyHieuHoaDon", dmQuyenHoaDonInfor.KyHieuHoaDon);
            Parameters.AddWithValue("@KyTuDauSerie", dmQuyenHoaDonInfor.KyTuDauSerie);
            return FillToList<DMQuyenHoaDonInfor>();
        }
        public DMQuyenHoaDonInfor GetHoaDonInfo(string kytudau,string kyhieuhoadon)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spHoaDonGetById);
            Parameters.AddWithValue("@KyTuDau", kytudau);
            Parameters.AddWithValue("@KyHieuHoaDon", kyhieuhoadon);
            return FillToObject<DMQuyenHoaDonInfor>();
        }
    }
}
