using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DongBoERP;
using QLBanHang.Modules.DongBoERP.Infors;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmDonViTinhDAO :SynchronizableDAO
    {
        private static DmDonViTinhDAO instance;
        private DmDonViTinhDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmDonViTinh;
            UseCaching = true;
        }
        public static DmDonViTinhDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmDonViTinhDAO();
                return instance;
            }
        }

        internal override void Synchronize(bool isCompleted)
        {
            DmDonViTinhSynchronize.Instance.Synchronize(isCompleted);
        }

        public List<DMDonViTinhInfor> GetListDonViTinhInfo()
        {
            return GetListAll<DMDonViTinhInfor>(Declare.StoreProcedureNamespace.spDonViTinhSelectAll, Declare.TableNamespace.DmDonViTinh);
        }

        public List<DMDonViTinhLoadInfor> GetListDonViTinhLoadInfo()
        {
            return GetListAll<DMDonViTinhLoadInfor>(Declare.StoreProcedureNamespace.spDonViTinhLoad, Declare.TableNamespace.DmDonViTinh);
        }

        internal void Update(DMDonViTinhInfor dmDonViTinhInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spDonViTinhUpdate);
            SetParams(dmDonViTinhInfor);
            ExecuteNoneQuery();
        }

        internal int Insert(DMDonViTinhInfor dmDonViTinhInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spDonViTinhInsert);
            SetParams(dmDonViTinhInfor);
            Parameters["@IdDonViTinh"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@IdDonViTinh"].Value.ToString());
        }

        internal void Delete(DMDonViTinhInfor dmDonViTinhInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spDonViTinhDelete);
            Parameters.AddWithValue("@IdDonViTinh", dmDonViTinhInfor.IdDonViTinh);
            ExecuteNoneQuery();
        }

        internal bool Exist(DMDonViTinhInfor dmDonViTinhInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spDonViTinhExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@IdDonViTinh", dmDonViTinhInfor.IdDonViTinh);
            Parameters.AddWithValue("@KyHieu", dmDonViTinhInfor.KyHieu);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }

        internal List<DMDonViTinhInfor> Search(DMDonViTinhInfor dmDonViTinhInfor)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spDonViTinhSearch);
            Parameters.AddWithValue("@TenDonViTinh", dmDonViTinhInfor.TenDonViTinh);
            Parameters.AddWithValue("@KyHieu", dmDonViTinhInfor.KyHieu);
            return FillToList<DMDonViTinhInfor>();
        }
        public DMDonViTinhInfor GetDonViTinhByIdInfo(int idDonViTinh)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spDonViTinhGetbyId);
            Parameters.AddWithValue("@IdDonViTinh", idDonViTinh);
            return FillToObject<DMDonViTinhInfor>();
        }

        public bool IsUsed(int idDonViTinh)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spDonViTinhIsUsed, idDonViTinh);
            return Convert.ToInt32(Parameters["p_Count"].Value) == 1;
        }
        internal  List<DMDonViTinhInfor> TimKiem(string madonvitinh,string tendonvitinh)
        {
            return GetListCommand<DMDonViTinhInfor>(Declare.StoreProcedureNamespace.spDonViTinhSearch, madonvitinh,
                                                    tendonvitinh);
        }
        
    }
}
