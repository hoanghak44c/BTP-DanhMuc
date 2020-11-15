using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
//using Oracle.DataAccess.Client;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;
using QLBH.Core.Data;
using QLBH.Core.Form;


namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DMSanPhamDAO : SynchronizableDAO
    {
        private static DMSanPhamDAO instance;
        private DMSanPhamDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmSanPham;
            UseCaching = true;
            TrackField = "t1.modifiedat";
        }
         public static DMSanPhamDAO Instance
        {
            get
            {
                if (instance == null) instance = new DMSanPhamDAO();
                return instance;
            }
        }

         internal override void Synchronize()
         {
             if (MessageBox.Show("Bạn có muốn đồng bộ đơn vị tính không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
             {
                 frmProgress.Instance.PushStatus();
                 DmDonViTinhDAO.Instance.Synchronize(false);
                 frmProgress.Instance.PopStatus();
             }
             if (MessageBox.Show("Bạn có muốn đồng bộ biểu thuế không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
             {
                 frmProgress.Instance.PushStatus();
                 DmTaxCodeDAO.Instance.Synchronize(false);
                 frmProgress.Instance.PopStatus();
             }
             if (MessageBox.Show("Bạn có muốn đồng bộ loại sản phẩm không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
             {
                 frmProgress.Instance.PushStatus();
                 DMLoaiSPDAO.Instance.Synchronize(false);
                 frmProgress.Instance.PopStatus();
             }

             DmSanPhamSynchronize.Instance.Synchronize();
         }

        public List<DMSanPhamInfo> GetListSanPhamInfo()
        {
            //return GetListAll<DMSanPhamInfo>(Declare.StoreProcedureNamespace.spSanPhamSelectAll, Declare.TableNamespace.DmSanPham);
            return GetListAll<DMSanPhamInfo>(@"SELECT t1.idsanpham,
			         t1.idcha,
			         t1.mavach,
			         t1.masanpham,
			         t1.tensanpham, /*t1.iddonvitinh,t1.gianhap,t1.mota,t1.sudung,*/
			         t1.trungmavach, /*t1.tenviettat,*/
			         t1.chietkhau,
			         t1.baohanhhang,
			         t1.baohanhkhach,
			         nganh.ma        as Nganh, --hang.ten as Hang,
			         t2.tenloaisp    as TenLoaiSP,
			         t1.tylevat,
			         t1.chietkhau,
			         t3.giatri       as GiaTriVAT,
			         t3.code         as TaxCode,
			         t1.phukien,
			         t1.sudung,
			         loai.ten        as Loai,
			         md.ten          as Model
	        FROM tbl_sanpham t1
	        left join Tbl_Dm_Loaisanpham t2
		        on t2.idloaisp = t1.idcha
	        left join tbl_dm_taxcode t3
		        on t3.idtaxcode = t1.tylevat
	        left join tbl_dm_dl_nganh nganh
		        on nganh.ma = t2.nganh
	        left join tbl_dm_dl_hang hang
		        on hang.ma = t2.hang
	        left join tbl_dm_dl_loai loai
		        on loai.ma = t2.loai
	        left join tbl_dm_dl_model md
		        on t2.model = md.ma
	         and t2.loai = md.nhom", Declare.TableNamespace.DmSanPham);
        }

        public List<DMSanPhamInfo> GetListSanPhamCauHinhInfo()
        {
            return GetListAll<DMSanPhamInfo>(Declare.StoreProcedureNamespace.spSanPhamCauHinhSelectAll, Declare.TableNamespace.DmSanPham);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idKho"></param>
        /// <param name="idTrungTam"></param>
        /// <param name="exists">Có tìm theo tồn không?</param>
        /// <param name="isTonAo">Theo tồn ảo hay thật?</param>
        /// <returns></returns>
        public List<DMSanPhamInfo> GetListSanPhamInfo(int idKho, int idTrungTam, bool exists, bool isTonAo)
        {
            return GetListCommand<DMSanPhamInfo>(Declare.StoreProcedureNamespace.spSanPhamSelectByKTTT, idKho, idTrungTam, exists ? 1 : 0, isTonAo ? 1 : 0);
        }

        public List<DMSanPhamPairInfo> GetListSanPhamCBOInfo()
        {
            //return GetListAll<DMSanPhamPairInfo>(Declare.StoreProcedureNamespace.spSanPhamSelectPair, Declare.TableNamespace.DmSanPham);
            return GetListAll<DMSanPhamPairInfo>(@"SELECT t1.idsanpham, t1.masanpham, t1.tensanpham, t1.sudung
	                FROM tbl_sanpham t1
                 WHERE t1.sudung = 1", Declare.TableNamespace.DmSanPham);
        }
        internal void Update(DMSanPhamInfo dmSanPhamInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spSanPhamUpdate,

                           dmSanPhamInfor.IdCha,
                           dmSanPhamInfor.MaVach,
                           dmSanPhamInfor.MaSanPham,
                           dmSanPhamInfor.TenSanPham,
                           dmSanPhamInfor.IdDonViTinh,
                           dmSanPhamInfor.GiaNhap,
                           dmSanPhamInfor.MoTa,
                           dmSanPhamInfor.SuDung,
                           dmSanPhamInfor.TrungMaVach,
                           dmSanPhamInfor.TenVietTat,
                           dmSanPhamInfor.ChietKhau,
                           dmSanPhamInfor.BaoHanhHang,
                           dmSanPhamInfor.BaoHanhKhach,
                           dmSanPhamInfor.TyLeVAT,
                           dmSanPhamInfor.IdSanPham);

        }
        internal int Insert(DMSanPhamInfo dmSanPhamInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spSanPhamInsert,
                //dmSanPhamInfor.IdSanPham,
                dmSanPhamInfor.IdCha,
                dmSanPhamInfor.MaVach,
                dmSanPhamInfor.MaSanPham,
                dmSanPhamInfor.TenSanPham,
                dmSanPhamInfor.IdDonViTinh,
                dmSanPhamInfor.GiaNhap,
                dmSanPhamInfor.MoTa,
                dmSanPhamInfor.SuDung,
                dmSanPhamInfor.TrungMaVach,
                dmSanPhamInfor.TenVietTat,
                dmSanPhamInfor.ChietKhau,
                dmSanPhamInfor.BaoHanhHang,
                dmSanPhamInfor.BaoHanhKhach,
                dmSanPhamInfor.TyLeVAT);
            //return Convert.ToInt32(Parameters["p_IdSanPham"].Value.ToString());
        }
        internal void Delete(DMSanPhamInfo dmSanPhamInfor)
        {
            //CreateCommonCommand(Declare.StoreProcedureNamespace.spSanPhamDelete);
            //Parameters.AddWithValue("@IdSanPham", dmSanPhamInfor.IdSanPham);
            //ExecuteNoneQuery();
            ExecuteCommand(Declare.StoreProcedureNamespace.spSanPhamDelete, dmSanPhamInfor.IdSanPham);
        }
        internal bool Exist(DMSanPhamInfo dmSanPhamInfor)
        {
            //CreateCommonCommand(Declare.StoreProcedureNamespace.spSanPhamExist);
            //Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            //Parameters.AddWithValue("@IdSanPham", dmSanPhamInfor.IdSanPham);
            //Parameters.AddWithValue("@MaSanPham", dmSanPhamInfor.MaSanPham);
            //ExecuteNoneQuery();
            //return Convert.ToInt32(Parameters["@Count"].Value) == 1;
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spSanPhamExist, 
                dmSanPhamInfor.IdSanPham, 
                dmSanPhamInfor.MaSanPham) > 0;
        }
        internal List<DMSanPhamInfo> Search(DMSanPhamInfo dmSanPhamInfor)
        {
            return GetListCommand<DMSanPhamInfo>(Declare.StoreProcedureNamespace.spSanPhamSearch,
                dmSanPhamInfor.MaSanPham, 
                dmSanPhamInfor.TenSanPham);
        }
        public DMSanPhamInfo GetSanPhamInfoById(int idSanPham)
        {
            //CreateGetListCommand(Declare.StoreProcedureNamespace.spSanPhamGetById);
            //Parameters.AddWithValue("@IdSanPham", idSanPham);
            //return FillToObject<DMSanPhamInfo>();
            return GetObjectCommand<DMSanPhamInfo>(Declare.StoreProcedureNamespace.spSanPhamGetById, 
                idSanPham);

        }

        public DMSanPhamInfo GetSanPhamByMa(string maSanPham)
        {
            return GetObjectCommand<DMSanPhamInfo>(Declare.StoreProcedureNamespace.spSanPhamGetByMaSP, 
                maSanPham);
        }

        public List<DMSanPhamInfo> GetListSanPhamByLoaiSP(int idLoaiSp)
        {
            return GetListCommand<DMSanPhamInfo>(Declare.StoreProcedureNamespace.spSanPhamGetByLoaiSP, 
                idLoaiSp);
        }

        public List<DMSanPhamBriefInfo> GetListSanPhamBrief(int suDung, int chietKhau)
        {
            return GetListCommand<DMSanPhamBriefInfo>(Declare.StoreProcedureNamespace.spSanPhamSelectBrief, 
                suDung, chietKhau);
        }
        public List<DMSanPhamBriefInfo> GetListSanPhamBrief(int idNguoiDung, int suDung, int chietKhau)
        {
            return GetListCommand<DMSanPhamBriefInfo>(
                Declare.StoreProcedureNamespace.spSanPhamSelectBriefByNSD,
                idNguoiDung, suDung, chietKhau);
        }
        public List<DMSanPhamBriefInfo> GetListSanPhamTonBrief(int idNguoiDung, int suDung, int chietKhau, int idKho, int tonAll)
        {
            return GetListCommand<DMSanPhamBriefInfo>(
                Declare.StoreProcedureNamespace.spSanPhamSelectBriefByNSDTK,
                idNguoiDung, suDung, chietKhau, idKho, tonAll);
        }
        public DMSanPhamBriefInfo GetSanPhamBriefByMa(string maSanPham)
        {
            return GetObjectCommand<DMSanPhamBriefInfo>(
                Declare.StoreProcedureNamespace.spSanPhamSelectBriefByMa, maSanPham);
        }
        public DMSanPhamBriefInfo GetSanPhamBriefByNSDMa(string maSanPham, int idNhomNguoiDung)
        {
            return GetObjectCommand<DMSanPhamBriefInfo>(
                Declare.StoreProcedureNamespace.spSanPhamSelectBriefByNSDMa, maSanPham, idNhomNguoiDung);
        }
        //public DMSanPhamBriefInfo GetSanPhamBriefByMa(string maSanPham)
        //{ 
        //    return GetObjectCommand<DMSanPhamBriefInfo>(Declare.StoreProcedureNamespace.spSanPhamSelectBrief, maSanPham);
        //}
        public List<DMSanPhamInfo> SupplyPageOfData(string conditonLookUp, int lowerPageBoundary, int rowsPerPage)
        {
            return GetListCommand<DMSanPhamInfo>(Declare.StoreProcedureNamespace.spSanPhamSelectPagingDmSanPhamInfo,
                                                      conditonLookUp, lowerPageBoundary, rowsPerPage);
        }

        public List<ItemTonKhoInfor> LoadTonKhoTheoTrungTam(int idSanPham)
        {
            return GetListCommand<ItemTonKhoInfor>(Declare.StoreProcedureNamespace.spChungTuBanHangTonKhoBySanPham, idSanPham);
        }
        public DMSanPhamInfo GetSanPhamByText(string sanpham)
        {
            return GetObjectCommand<DMSanPhamInfo>(Declare.StoreProcedureNamespace.spSanPhamGetByText, sanpham);
        }

        public List<DMSanPhamInfo> GetListDmSanPhamInfoUsing()
        {
            //return GetListAll<DMSanPhamInfo>(Declare.StoreProcedureNamespace.spSanPhamUsingSelectAll, Declare.TableNamespace.DmSanPham);
            return GetListAll<DMSanPhamInfo>(@"SELECT t1.idsanpham,
			         t1.idcha,
			         t1.mavach,
			         t1.masanpham,
			         t1.tensanpham, /*t1.iddonvitinh,t1.gianhap,t1.mota,t1.sudung,*/
			         t1.trungmavach, /*t1.tenviettat,*/
			         t1.chietkhau,
			         t1.baohanhhang,
			         t1.baohanhkhach,
			         nganh.ma        as Nganh, --hang.ten as Hang,
			         t2.tenloaisp    as TenLoaiSP,
			         t1.tylevat,
			         t1.chietkhau,
			         t3.giatri       as GiaTriVAT,
			         t3.code         as TaxCode,
			         t1.phukien,
			         t1.sudung,
			         loai.ten        as Loai,
			         md.ten          as Model
	        FROM tbl_sanpham t1
	        left join Tbl_Dm_Loaisanpham t2
		        on t2.idloaisp = t1.idcha
	        left join tbl_dm_taxcode t3
		        on t3.idtaxcode = t1.tylevat
	        left join tbl_dm_dl_nganh nganh
		        on nganh.ma = t2.nganh
	        left join tbl_dm_dl_hang hang
		        on hang.ma = t2.hang
	        left join tbl_dm_dl_loai loai
		        on loai.ma = t2.loai
	        left join tbl_dm_dl_model md
		        on t2.model = md.ma
	         and t2.loai = md.nhom", Declare.TableNamespace.DmSanPham);
        }
    }   
}
