using System;
using System.Collections;
using System.Collections.Generic;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.DAO;

namespace QLBanHang.Modules.DanhMuc.Providers
{

    public class ItemSegmentDataProvider
    {
        private static ItemSegmentDataProvider instance;
        public static ItemSegmentDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new ItemSegmentDataProvider();
                return instance;
            }
        }


        #region tim kiem item
        //0-linhvuc,1-nganh,2-loai,3-chung,4-nhom,5-model,6-sanpham,7-hang
        public List<ItemSegmentInfo> GetAllItemsByType(int idNhomNguoiDung, int type, int chietKhau, int suDung)
        {
            return ItemSegmentDAO.Instance.GetAllItemsByType(idNhomNguoiDung, type, chietKhau, suDung);
        }
        public ItemSegmentInfo GetAllItemsByTypeandText(int idNhomNguoiDung, int type, int chietKhau, int suDung, string text)
        {
            return ItemSegmentDAO.Instance.GetAllItemsByTypeandText(idNhomNguoiDung, type, chietKhau, suDung, text);
        }
        public ItemSegmentInfo GetItemByTypeandCode(int idNhomNguoiDung, int type, string maHang)
        {
            return ItemSegmentDAO.Instance.GetItemByTypeandCode(idNhomNguoiDung, type, maHang);
        }
        public ItemSegmentInfo GetItemChietKhauByCode(int idNhomNguoiDung, string maHang, int suDung)
        {
            return ItemSegmentDAO.Instance.GetItemChietKhauByCode(idNhomNguoiDung, maHang, suDung);
        }
        public ItemSegmentInfo GetHangSanXuat(string ma, string ten)
        {
            return ItemSegmentDAO.Instance.GetHangSanXuat(ma, ten);
        }
        public ItemSegmentInfo GetHangInfo(string ma, string ten)
        {
            return ItemSegmentDAO.Instance.GetHangInfo(ma, ten);
        }
        #endregion

    }
}
