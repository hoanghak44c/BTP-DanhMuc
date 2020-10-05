using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmLoaiThuChiDAO :SynchronizableDAO
    {
        private static DmLoaiThuChiDAO instance;
        private DmLoaiThuChiDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLoaiThuChi;
            UseCaching = true;
        }
        public static DmLoaiThuChiDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmLoaiThuChiDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmPaymentSynchronize.Instance.Synchronize();
        }

        public List<DMLoaiThuChiInfor> GetListLoaiThuChiInfor()
        {
            return GetListAll<DMLoaiThuChiInfor>(Declare.StoreProcedureNamespace.spLoaiThuChiSelectAll, Declare.TableNamespace.DmLoaiThuChi);
        }

        internal void Update(DMLoaiThuChiInfor dmLoaiThuChiInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiThuChiUpdate);
            SetParams(dmLoaiThuChiInfor);
            //Parameters["IdThuChi"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();
            //return Convert.ToInt32(Parameters["@IdThuChi"].Value.ToString());
        }

        internal int  Insert(DMLoaiThuChiInfor dmLoaiThuChiInfor)
        {
            //ExecuteCommand(Declare.StoreProcedureNamespace.spLoaiThuChiInsert, dmLoaiThuChiInfor.KyHieu,
            //               dmLoaiThuChiInfor.Ten, dmLoaiThuChiInfor.GhiChu, dmLoaiThuChiInfor.Type,
            //               dmLoaiThuChiInfor.SuDung);
            // Common.IntValue(Parameters["p_IdThuChi"].Value.ToString());
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiThuChiInsert);
            SetParams(dmLoaiThuChiInfor);
            Parameters["@IdThuChi"].Direction = ParameterDirection.Output;
            //Parameters["@IDORDERTYPE"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@IdThuChi"].Value);
        }

        internal void Delete(DMLoaiThuChiInfor dmLoaiThuChiInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiThuChiDelete);
            Parameters.AddWithValue("@IdThuChi", dmLoaiThuChiInfor.IdThuChi);
            ExecuteNoneQuery();
        }

        internal bool Exist(DMLoaiThuChiInfor dmLoaiThuChiInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiThuChiExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@IdThuChi", dmLoaiThuChiInfor.IdThuChi);
            Parameters.AddWithValue("@KyHieu", dmLoaiThuChiInfor.KyHieu);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }

        internal List<DMLoaiThuChiInfor> Search(DMLoaiThuChiInfor dmLoaiThuChiInfor)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiThuChiSearch);
            Parameters.AddWithValue("@KyHieu", dmLoaiThuChiInfor.KyHieu);
            Parameters.AddWithValue("@Ten", dmLoaiThuChiInfor.Ten);
            return FillToList<DMLoaiThuChiInfor>();
        }

        public DMLoaiThuChiInfor GetDoiTuongByIdInfo(int idThuChi)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiThuChiGetbyId);
            Parameters.AddWithValue("@IdThuChi", idThuChi);
            return FillToObject<DMLoaiThuChiInfor>();
        }

        public DMLoaiThuChiInfor GetDmThuChiInfoByText(string thuchi)
        {
            return GetObjectCommand<DMLoaiThuChiInfor>(Declare.StoreProcedureNamespace.spLoaiThuChiGetbyText, thuchi);
        }
    }
}
