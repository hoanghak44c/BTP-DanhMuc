using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmLoaiHoaDonDAO : SynchronizableDAO
    {
        private static DmLoaiHoaDonDAO instance;
        private DmLoaiHoaDonDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLoaiHoaDon;
            UseCaching = true;
        }

        public static DmLoaiHoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmLoaiHoaDonDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmLoaiHoaDonSynchronize.Instance.Synchronize();
        }

        public List<DMLoaiHoaDonInfo> GetListLoaiHoaDonInfor()
        {
            return GetListCommand<DMLoaiHoaDonInfo>(Declare.StoreProcedureNamespace.spLoaiHoaDonSelectAll, Declare.TableNamespace.DmLoaiHoaDon);
        }

        internal void Update(DMLoaiHoaDonInfo dmLoaiHoaDonInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLoaiHoaDonUpdate, ParseToParams(dmLoaiHoaDonInfo));
        }

        internal int Insert(DMLoaiHoaDonInfo dmLoaiHoaDonInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLoaiHoaDonInsert, ParseToParams(dmLoaiHoaDonInfo));

            return Convert.ToInt32(Parameters["p_IdLoaiHoaDon"].Value.ToString());
        }
        internal void Delete(DMLoaiHoaDonInfo dmLoaiHoaDonInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLoaiHoaDonDelete, dmLoaiHoaDonInfo.Id);
        }

        public bool Exist(DMLoaiHoaDonInfo dmLoaiHoaDonInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLoaiHoaDonExist, dmLoaiHoaDonInfo.Id, dmLoaiHoaDonInfo.KyHieu);

            return Convert.ToInt32(Parameters["p_Count"].Value) == 1;
        }

        internal List<DMLoaiHoaDonInfo> Search(DMLoaiHoaDonInfo dmLoaiHoaDonInfo)
        {
            return GetListCommand<DMLoaiHoaDonInfo>(Declare.StoreProcedureNamespace.spLoaiHoaDonSearch, dmLoaiHoaDonInfo.KyHieu, dmLoaiHoaDonInfo.Ten);
        }

        public DMLoaiHoaDonInfo GetLoaiHoaDonByIdInfo(int idLoaiHoaDon)
        {
            return GetObjectCommand<DMLoaiHoaDonInfo>(Declare.StoreProcedureNamespace.spLoaiHoaDonGetbyId, idLoaiHoaDon);
        }

    }
}
