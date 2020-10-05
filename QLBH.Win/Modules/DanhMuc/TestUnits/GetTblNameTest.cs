using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLBH.Core.Data;

namespace QLBanHang.TestUnits
{
    [TestClass]
    public class GetTblNameTest
    {
        [TestMethod]
        public void TestGetTblName()
        {
            string input = @"SELECT kho.IdKho, kho.TenKho, hhct.IdSanPham, sp.MaSanPham, dvt.TenDonViTinh, sp.TenSanPham,
  
-- so luong ton dau ky

  -- so luong nhap ton
  NVL((SELECT     NVL(SoLuong, 0)
    FROM          tbl_HangHoa_DuDauKy ddk
    WHERE      ddk.IdSanPham = hhct.IdSanPham AND ddk.ThoiGian = kho.NgayDuDau AND ddk.ThoiGian < p_FromDate), 0) +
  --so luong nhap/nhap tra lai/tra lai khuyen mai
  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
    tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND ct.LoaiChungTu IN (3, 5, 10)
    AND ct.NgayLap < p_FromDate AND ctct.IdSanPham = hhct.IdSanPham), 0) +
  --so luong chuyen den
  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
    tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKhoDieuChuyen = kho.IdKho AND ct.LoaiChungTu = 4 
    AND ct.NgayLap < p_FromDate AND ctct.IdSanPham = hhct.IdSanPham), 0) -
  --so luong xuat ban/huy/khuyen mai
  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
    tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND ct.LoaiChungTu IN (1, 7, 9) 
    AND ct.NgayLap < p_FromDate AND ctct.IdSanPham = hhct.IdSanPham), 0) -
  --so luong chuyen di
  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
    tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND ct.LoaiChungTu = 4 
    AND ct.NgayLap < p_FromDate AND ctct.IdSanPham = hhct.IdSanPham), 0) AS SoLuongTonDauKy,              

-- tien ton dau ky

  --tien nhap ton
  NVL((SELECT     NVL(ThanhTien, 0)
    FROM          tbl_HangHoa_DuDauKy ddk
    WHERE      IdSanPham = hhct.IdSanPham AND ThoiGian = kho.NgayDuDau AND ddk.ThoiGian < p_FromDate), 0) +
  --tien nhap/nhap tra lai/tra lai khuyen mai
  NVL((SELECT     SUM(NVL(ABS(ctct.ThanhTien), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN 
    tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND ct.LoaiChungTu IN (3, 5, 10) 
    AND ctct.IdSanPham = hhct.IdSanPham AND ct.NgayLap < p_FromDate), 0) +
  --tien chuyen den
  NVL((SELECT     SUM(NVL(ABS(ctct.ThanhTien), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
    tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKhoDieuChuyen = kho.IdKho AND ct.LoaiChungTu = 4
    AND ctct.IdSanPham = hhct.IdSanPham AND ct.NgayLap < p_FromDate), 0) - 
  --tien xuat ban/huy/khuyen mai
  CostOf(kho.IdKho, hhct.IdSanPham, p_ToDate)*(
  --so luong xuat ban/huy/khuyen mai
  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
       tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND ct.LoaiChungTu IN (1, 7, 9) AND 
       ct.NgayLap < p_FromDate AND ctct.IdSanPham = hhct.IdSanPham), 0) +
  --so luong chuyen di
  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
       tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND ct.LoaiChungTu = 4 AND 
       ct.NgayLap < p_FromDate AND ctct.IdSanPham = hhct.IdSanPham), 0)
)
AS TienTonDauKy,

-- so luong nhap trong ky
  -- so luong nhap ton
  NVL((SELECT     NVL(SoLuong, 0)
    FROM          tbl_HangHoa_DuDauKy ddk
    WHERE      ddk.IdSanPham = hhct.IdSanPham AND ddk.ThoiGian = kho.NgayDuDau 
    AND ddk.ThoiGian >= p_FromDate AND ddk.ThoiGian <= p_ToDate), 0) +
  --so luong nhap/nhap tra lai/tra lai khuyen mai
  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
    tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND ct.LoaiChungTu IN (3, 5, 10) 
    AND ct.NgayLap >= p_FromDate AND ct.NgayLap <= p_ToDate AND ctct.IdSanPham = hhct.IdSanPham), 0) +
  --so luong chuyen den
  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
       tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKhoDieuChuyen = kho.IdKho AND ct.LoaiChungTu = 4 AND 
       ct.NgayLap >= p_FromDate AND ct.NgayLap <= p_ToDate AND ctct.IdSanPham = hhct.IdSanPham), 0) AS SoLuongNhapTrongKy,

-- so tien nhap trong ky
  --tien nhap ton
  NVL((SELECT     NVL(ABS(ThanhTien), 0)
    FROM          tbl_HangHoa_DuDauKy ddk
    WHERE      IdSanPham = hhct.IdSanPham AND ThoiGian = kho.NgayDuDau
    AND ddk.ThoiGian >= p_FromDate AND ddk.ThoiGian <= p_ToDate), 0) +
  --so tien nhap/nhap tra lai/tra lai khuyen mai
  NVL((SELECT     SUM(NVL(ABS(ctct.ThanhTien), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
    tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND LoaiChungTu IN (3, 5, 10) 
    AND ct.NgayLap >= p_FromDate AND ct.NgayLap <= p_ToDate AND ctct.IdSanPham = hhct.IdSanPham), 0) +
  --so tien chuyen den
  NVL((SELECT     SUM(NVL(ABS(ctct.ThanhTien), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN 
    tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKhoDieuChuyen = kho.IdKho AND ct.LoaiChungTu = 4 
    AND ct.NgayLap >= p_FromDate AND ct.NgayLap <= p_ToDate AND ctct.IdSanPham = hhct.IdSanPham), 0) AS TienNhapTrongKy,

--so luong xuat trong ky

  --so luong xuat ban/huy/khuyen mai
  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
       tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND ct.LoaiChungTu IN (1, 7, 9) AND 
       ct.NgayLap >= p_FromDate AND ct.NgayLap <= p_ToDate AND ctct.IdSanPham = hhct.IdSanPham), 0) +
  --so luong chuyen di
  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
       tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND ct.LoaiChungTu = 4 AND 
       ct.NgayLap >= p_FromDate AND ct.NgayLap <= p_ToDate AND ctct.IdSanPham = hhct.IdSanPham), 0) AS SoLuongXuatTrongKy,              

--so tien xuat trong ky
  qlbh.CostOf(kho.IdKho, hhct.IdSanPham, p_ToDate)*
  --so luong xuat ban/huy/khuyen mai
(  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
       tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND ct.LoaiChungTu IN (1, 7, 9) AND 
       ct.NgayLap >= p_FromDate AND ct.NgayLap <= p_ToDate AND ctct.IdSanPham = hhct.IdSanPham), 0) +
  --so luong chuyen di
  NVL((SELECT     SUM(NVL(ABS(ctct.SoLuong), 0)) AS Expr1
    FROM          tbl_ChungTu_Chitiet ctct INNER JOIN
       tbl_ChungTu ct ON ct.IdChungTu = ctct.IdChungTu WHERE ct.IdKho = kho.IdKho AND ct.LoaiChungTu = 4 AND 
       ct.NgayLap >= p_FromDate AND ct.NgayLap <= p_ToDate AND ctct.IdSanPham = hhct.IdSanPham), 0)              
)
AS TienXuatTrongKy
FROM         qlbh.tbl_DM_Kho kho INNER JOIN
  qlbh.tbl_SanPham sp INNER JOIN
  qlbh.tbl_HangHoa_Chitiet hhct ON sp.IdSanPham = hhct.IdSanPham INNER JOIN
  qlbh.tbl_DM_DonViTinh dvt ON sp.IdDonViTinh = dvt.IdDonViTinh ON kho.IdKho = hhct.IdKho
GROUP BY kho.IdKho, kho.IdTrungTam, hhct.IdSanPham, sp.MaSanPham, dvt.TenDonViTinh, sp.TenSanPham, kho.NgayDuDau, kho.TenKho
HAVING (kho.IdTrungTam = p_IdTrungTam OR p_IdTrungTam = 0)
AND (kho.IdKho = p_IdKho OR p_IdKho = 0)
AND (hhct.IdSanPham = p_IdSanPham OR p_IdSanPham = 0)
AND (p_SanPham is null or sp.MaSanPham like '%'||p_SanPham||'%' or sp.TenSanPham like N'%'||p_SanPham||'%');";

            input = GetTblName(input);
            Assert.AreEqual(input, "tbl_DM_DoiTuong");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">command text sql</param>
        /// <returns>concated name of tables</returns>
        /// Who     Action      YYYYMMDDHHMM    Description
        /// hah     created     201202231106    tạo hàm extract tên các bảng trong câu lệnh sql
        public string GetTblName(string input)
        {
            int startIndex = 0, postIndex = 0;
            string result = String.Empty, tblUnit = String.Empty;
            string tblPrefix = "tbl_";
            char[] chrs = new char[] { ' ', ',', '.' };
            input = input.ToLower();
            startIndex = input.IndexOf(tblPrefix);
            postIndex = input.IndexOfAny(chrs, startIndex);
            while (startIndex > 0 && startIndex < input.Length)
            {
                if (postIndex > startIndex)
                {
                    tblUnit = input.Substring(startIndex, postIndex - startIndex);
                    if(result.IndexOf(tblUnit) < 0) result += tblUnit + ",";
                    startIndex = input.IndexOf(tblPrefix, postIndex);
                    if(startIndex > 0) postIndex = input.IndexOfAny(chrs, startIndex);
                }
                else
                {
                    tblUnit = input.Substring(startIndex);
                    if (result.IndexOf(tblUnit) < 0) result += tblUnit + ",";
                    startIndex = input.ToLower().IndexOf(tblPrefix, startIndex + 1);
                }
            }
            if (result.Length > 0)
                return result.Substring(0, result.Length - 1);
            return result;
        }
        
        [TestMethod]
        public void GetMacAddress()
        {
            string macAddresses = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            Debug.Print(macAddresses);
        }

        [TestMethod]
        public void TestJoinString()
        {
            Assert.AreEqual(String.Join(",", new string[] {"1", "2", "3"}), ",1,2,3,");
            //ProviderBase.Insert()
        }
        
    }
}
