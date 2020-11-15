using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
//using Oracle.DataAccess.Client;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;
namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DoiTuong_DiaChiDAO : BaseDAO
    {
        private static DoiTuong_DiaChiDAO instance;
        private DoiTuong_DiaChiDAO()
        {
            CRUDTableName = Declare.TableNamespace.DoiTuongDiaChi;
            UseCaching = true;
        }
        public static DoiTuong_DiaChiDAO Instance
        {
            get
            {
                if (instance == null) instance = new DoiTuong_DiaChiDAO();
                return instance;
            }
        }
        internal void Insert(DoiTuong_DiaChiInfo dmTrungTamInfor)
        {
            GetObjectCommand<int>(Declare.StoreProcedureNamespace.spDoiTuongDiaChiInsert,
                ParseToParams<DoiTuong_DiaChiInfo>(dmTrungTamInfor));

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spDoiTuongDiaChiInsert);
            //SetParams(dmTrungTamInfor);
            ////Parameters["@IdDoiTuong"].Direction = ParameterDirection.Output;
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@IdDoiTuong"].Value.ToString());
        }
        internal void Delete(DoiTuong_DiaChiInfo dmTrungTamInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spDoiTuongDiaChiDelete,
                dmTrungTamInfor.IdDoiTuong);

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spDoiTuongDiaChiDelete);
            //Parameters.AddWithValue("@IdDoiTuong", dmTrungTamInfor.IdDoiTuong);
            //ExecuteNoneQuery();
        }
        public List<DoiTuong_DiaChiInfo> GetDoiTuongDiaChiByIdInfo(int idDoiTuong)
        {
            return GetListCommand<DoiTuong_DiaChiInfo>(Declare.StoreProcedureNamespace.spDoiTuongDiaChiSelectByidDoiTuong,
                idDoiTuong);

            //CreateGetListCommand(Declare.StoreProcedureNamespace.spDoiTuongDiaChiSelectByidDoiTuong);
            //Parameters.AddWithValue("@IdDoiTuong", idDoiTuong);
            //return FillToList<DoiTuong_DiaChiInfo>();
        }
    }
}
