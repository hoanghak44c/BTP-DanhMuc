using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Core.Data;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmTaxCodeDAO: SynchronizableDAO
    {
        private static DmTaxCodeDAO instance;
        private DmTaxCodeDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmTaxCode;
            UseCaching = true;
        }
        public static DmTaxCodeDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmTaxCodeDAO();
                return instance;
            }   
        }

        internal override void Synchronize(bool isComplete)
        {
            DmTaxCodeSynchronize.Instance.Synchronize(isComplete);
        }

        public List<DMTaxCodeInfor> GetListTaxCodeInfo()
        {
            return GetListAll<DMTaxCodeInfor>(Declare.StoreProcedureNamespace.spTaxCodeSelectAll, Declare.TableNamespace.DmTaxCode);
        }

        internal void Update(DMTaxCodeInfor dmTaxCodeInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spTaxCodeUpdate);
            SetParams(dmTaxCodeInfor);
            ExecuteNoneQuery();
        }

        internal int Insert(DMTaxCodeInfor dmTaxCodeInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spTaxCodeInsert);
            SetParams(dmTaxCodeInfor);//tự động set Id từ Infor vào 
            ExecuteNoneQuery();
            return Convert.ToInt32(Parameters["@IdTaxCode"].Value.ToString());
        }

        internal void Delete(DMTaxCodeInfor dmTaxCodeInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spTaxCodeDelete);
            Parameters.AddWithValue("@IdTaxCode", dmTaxCodeInfor.IdTaxCode);
            ExecuteNoneQuery();
        }

        internal bool Exist(DMTaxCodeInfor dmTaxCodeInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spTaxCodeExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@IdTaxCode", dmTaxCodeInfor.IdTaxCode);
            Parameters.AddWithValue("@Code", dmTaxCodeInfor.Code);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }
        internal List<DMTaxCodeInfor> Search(DMTaxCodeInfor dmMaLoiInfor)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spTaxCodeSearch);
            Parameters.AddWithValue("@TenLoi", dmMaLoiInfor.Name);
            Parameters.AddWithValue("@IdLoaiItem", dmMaLoiInfor.Code);
            return FillToList<DMTaxCodeInfor>();
        }
        public DMTaxCodeInfor GetTaxCodeByIdInfo(int id)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spTaxCodeGetById);
            Parameters.AddWithValue("@IdLoaiItem", id);
            return FillToObject<DMTaxCodeInfor>();
        }

        //internal List<DMTaxCodeInfor> Search(DMTaxCodeInfor dmTaxCodeInfor)
        //{
        //    CreateGetListCommand(Declare.StoreProcedureNamespace.spTrungTamSearch);
        //    Parameters.AddWithValue("@TenTrungTam", dmTaxCodeInfor.IdTaxCode);
        //    Parameters.AddWithValue("@MaTrungTam", dmTaxCodeInfor.MaTrungTam);
        //    return FillToList<DMTrungTamInfor>();
        //}

    }
}
