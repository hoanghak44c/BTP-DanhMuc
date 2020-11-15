using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
//using Oracle.DataAccess.Client;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmTrungTamDAO : SynchronizableDAO
    {
        private static DmTrungTamDAO instance;
        private DmTrungTamDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmTrungTam;
            UseCaching = false;
        }

        public static DmTrungTamDAO Instance
        {
            get
            {
                if(instance == null) instance = new DmTrungTamDAO();
                return instance;
            }   
        }

        internal override void Synchronize()
        {
            DmTrungTamSynchronize.Instance.Synchronize();
        }

        public List<DMTrungTamInfor> GetListTrungTamInfo(int baoHanh)
        {
            //return GetListAll<DMTrungTamInfor>(Declare.StoreProcedureNamespace.spTrungTamSelectAll, Declare.TableNamespace.DmTrungTam);
            return GetListCommand<DMTrungTamInfor>(Declare.StoreProcedureNamespace.spTrungTamSelectAllBaoHanh, baoHanh);
        }

        public List<DMTrungTamPairInfor> GetListTrungTamPairInfo()
        {
            return GetListAll<DMTrungTamPairInfor>(Declare.StoreProcedureNamespace.spTrungTamSelectPair, Declare.TableNamespace.DmTrungTam);
        }

        public List<DMTrungTamInfor> GetListTrungTamInfoByIdNhanVien(int idNhanVien, int baoHanh)
        {
            return GetListCommand<DMTrungTamInfor>(Declare.StoreProcedureNamespace.spTrungTamGetAllByIdNhanVien, idNhanVien, baoHanh);
        }

        public List<DMTrungTamPairInfor> GetListTrungTamPairInfoByIdNhanVien(int idNhanVien)
        {
            return GetListCommand<DMTrungTamPairInfor>(Declare.StoreProcedureNamespace.spTrungTamSelectByIdNhanVien, idNhanVien);
        }

        internal void Update(DMTrungTamInfor dmTrungTamInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spTrungTamUpdate, ParseToParams(dmTrungTamInfor));
        }

        internal int Insert(DMTrungTamInfor dmTrungTamInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spTrungTamInsert, ParseToParams(dmTrungTamInfor));

            return Convert.ToInt32(Parameters["p_IdTrungTam"].Value.ToString());
        }

        internal void Delete(DMTrungTamInfor dmTrungTamInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spTrungTamDelete, dmTrungTamInfor.IdTrungTam);
        }

        internal bool Exist(DMTrungTamInfor dmTrungTamInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spTrungTamExist, dmTrungTamInfor.IdTrungTam, dmTrungTamInfor.MaTrungTam) > 0;
        }

        internal List<DMTrungTamInfor> Search(DMTrungTamInfor dmTrungTamInfor)
        {
            return GetListCommand<DMTrungTamInfor>(Declare.StoreProcedureNamespace.spTrungTamSearch, dmTrungTamInfor.MaTrungTam, dmTrungTamInfor.TenTrungTam);
       }

        public DMTrungTamInfor GetTrungTamByIdInfo(int idTrungTam)
        {
            return GetObjectCommand<DMTrungTamInfor>(Declare.StoreProcedureNamespace.spTrungTamGetById, idTrungTam);
        }

        public DMTrungTamInfor GetTrungTamByIdKho(int idKho)
        {
            return GetObjectCommand<DMTrungTamInfor>(Declare.StoreProcedureNamespace.spTrungTamGetByIdKho, idKho);
        }

        public DMTrungTamInfor GetTrungTamByText(string trungtam)
        {
            return GetObjectCommand<DMTrungTamInfor>(Declare.StoreProcedureNamespace.spTrungTamGetByText, trungtam);
        }

        public DMTrungTamInfor GetTrungTamByMa(string maTrungtam)
        {
            return GetObjectCommand<DMTrungTamInfor>(Declare.StoreProcedureNamespace.spTrungTamGetByMa, maTrungtam);
        }
        public List<DMTrungTamPairInfor> GetTrungTamNoWeb()
        {
            return GetListCommand<DMTrungTamPairInfor>(Declare.StoreProcedureNamespace.spTrungTamLoadNoWeb);
        }
        public List<DMTrungTamInfor>GetAllTrungTam()
        {
            return GetListCommand<DMTrungTamInfor>(Declare.StoreProcedureNamespace.spTrungTamSelectAll);
        }

        public bool IsCrossedOU(int idTrungTam1, int idTrungTam2)
        {
            return Convert.ToInt32(ExecuteScalar(@"select decode(tt1.ouid, (select tt2.ouid from tbl_dm_trungtam tt2 
                    where tt2.idtrungtam = :IdTrungTam2), 0, 1) from tbl_dm_trungtam tt1
                where tt1.idtrungtam = :IdTrungTam1", idTrungTam2, idTrungTam1)) == 1;
        }
    }
}
