using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ThietBiDAL;
using ThietBiBLL;
using Microsoft.Reporting.WinForms;

namespace ThietBiPY.BaoCao_ThongKe.report
{
    public partial class frm_bienban_thuhoithietbi : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_bienban_thuhoithietbi()
        {
            InitializeComponent();
        }

        public frm_bienban_thuhoithietbi(string ThuHoiID)
        {
            InitializeComponent();
            hienthichungtu(ThuHoiID);
        }

        public void hienthichungtu(string ThuHoiID)
        {
            var THUHOI = new PHIEUTHUHOI_BLL().phieuthuhoi_danhsach().Where(c => c.ThuHoiID == int.Parse(ThuHoiID)).Select(c => new
            {
                ThuHoiID=c.ThuHoiID,
                SoVanBan = c.SoVanBan,
                NgayVanBan = (c.NgayVanBan !=null?c.NgayVanBan .Value.Date.ToString("dd/MM/yyyy"):""),
                NgayThuHoi = (c.NgayThuHoi !=null?c.NgayThuHoi .Value.Date.ToString("dd/MM/yyyy"):""),
                ThamQuyenQD = c.ThamQuyenQD ,
                DonViThuHoi = (c.DonViThuHoi !=0?c.DONVI.TenDonVi :""),
                DaiDienThuHoi = (c.DaiDienThuHoi !=0?c.NHANVIEN.HoNV +" "+c.NHANVIEN.TenNV:""),
                ChucVuDaiDienThuHoi=(c.DaiDienThuHoi!=0?(c.NHANVIEN.ChucVuID !=0?c.NHANVIEN.CHUCVU.TenChucVu:""):""),
                DonViSuDung=(c.DonViSuDung !=0?c.DONVI1.TenDonVi :""),
                BoPhanSuDung=(c.BoPhanSuDung !=0?c.BOPHAN .TenBoPhan:""),
                LiDoThuHoi = (c.LiDoThuHoi !=0?c.TINHTRANG.TenTinhTrang:""),
            }).ToList();

            var CTTHUHOI = new CTTHUHOI_BLL().ctthuhoi_danhsach(ThuHoiID).Select(c => new
            {
                MaThietBi = c.THIETBI.MaThietBi,
                SoHieu = c.THIETBI.SoHieu,
                TenThietBi = c.THIETBI.TenThietBi ,
                DonViTinh = (c.THIETBI.DVTID !=0?c.THIETBI.DONVITINH.TenDVT :""),
                LoaiTB = (c.THIETBI.LoaiTBID !=0?c.THIETBI.LOAITHIETBI.TenLoaiTB :""),
                SoLuongThuHoi = c.SoLuong,
                HienTrang = c.HienTrang,
            }).ToList();

           //
            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThietBiPY.BaoCao_ThongKe.report.rpt_bienban_thuhoithietbi.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource Source_THUHOI = new ReportDataSource("ds_thuhoithietbi_THUHOI",THUHOI);
            ReportDataSource Source_CTTHUHOI = new ReportDataSource("ds_thuhoithietbi_CTTHUHOI", CTTHUHOI);

            this.reportViewer1.LocalReport.DataSources.Add(Source_THUHOI);
            this.reportViewer1.LocalReport.DataSources.Add(Source_CTTHUHOI);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.DisplayName = "CT_thuhoithietbi_" + THUHOI.Single().ThuHoiID.ToString() + "_" + THUHOI.Single().NgayThuHoi;

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 88;


        }
    }
}
