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
    public partial class frm_bienban_bangiaothietbi : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_bienban_bangiaothietbi()
        {
            InitializeComponent();
        }

        public frm_bienban_bangiaothietbi(string BanGiaoID)
        {
            InitializeComponent();
            HienThiReport(BanGiaoID);
        }

        //
        private void HienThiReport(string BanGiaoID)
        {
            var BANGIAO = new PHIEUBANGIAO_BLL().phieubangiao_danhsach().Where(c => c.BanGiaoID == int.Parse(BanGiaoID)).Select(c => new
            {
                BanGiaoID = c.BanGiaoID,
                SoVanBan = c.SoVanBan,
                NgayVanBan = (c.NgayVanBan!=null? c.NgayVanBan.Value.Date.ToString ("dd/MM/yyyy"):""),
                NgayBanGiao = (c.NgayBanGiao!=null? c.NgayBanGiao.Value.Date.ToString("dd/MM/yyyy"):""),
                ThamQuyenQD = c.ThamQuyenQD,

                DonViBanGiao = (c.DonViBanGiao != 0 ? c.DONVI.TenDonVi : ""),
                BoPhanBanGiao =(c.BoPhanBanGiao !=0?c.BOPHAN.TenBoPhan:""),
               NhanVienBanGiao = (c.NhanVienBanGiao !=0 ?c.NHANVIEN.HoNV +" " + c.NHANVIEN.TenNV:""),
                ChucVuNVBanGiao  = (c.NhanVienBanGiao!=0?(c.NHANVIEN.ChucVuID !=0?c.NHANVIEN.CHUCVU.TenChucVu:""):""),

                DonViNhan = (c.DonViNhan != 0 ? c.DONVI1.TenDonVi : ""),
                BoPhanNhan = (c.BoPhanNhan != 0 ? c.BOPHAN1.TenBoPhan : ""),
               NhanVienNhan = (c.NhanVienNhan != 0 ? c.NHANVIEN1.HoNV + " " + c.NHANVIEN1.TenNV : ""),
                ChucVuNVNhan = (c.NhanVienNhan != 0 ? (c.NHANVIEN1.ChucVuID != 0 ? c.NHANVIEN.CHUCVU.TenChucVu : "") : ""),
            }).ToList();

            var LS_CTBANGIAO = new CTBANGIAO_BLL().ctbangiao_danhsach(BanGiaoID).Select(c => new
            {
                GTThietBiID = c.GTThietBiID,
                MaThietBi =c.SOTHEODOI .GTTHIETBI.THIETBI.MaThietBi,
                MaCaBiet=c.SOTHEODOI.GTTHIETBI.MaCaBiet,
                TenThietBi = c.SOTHEODOI.GTTHIETBI.THIETBI.TenThietBi,
                DonViTinh = (c.SOTHEODOI.GTTHIETBI.THIETBI.DVTID != 0 ? c.SOTHEODOI.GTTHIETBI.THIETBI.DONVITINH.TenDVT : ""),
                SoHieu = c.SOTHEODOI.GTTHIETBI.THIETBI.SoHieu,
                LoaiTB = (c.SOTHEODOI.GTTHIETBI.THIETBI.LoaiTBID != 0 ? c.SOTHEODOI.GTTHIETBI.THIETBI.LOAITHIETBI.TenLoaiTB : "Chưa xác định"),
                TinhTrang=(c.SOTHEODOI.TinhTrang!=0?c.SOTHEODOI.TINHTRANG1.TenTinhTrang:"Chưa xác định"),
                HienTrang=c.SOTHEODOI.HienTrang,
            }).ToList();

            //
            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThietBiPY.BaoCao_ThongKe.report.rpt_bienban_bangiaothietbi.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource Source_BANGIAO = new ReportDataSource("ds_bangiaothietbi_BANGIAO",BANGIAO);
            ReportDataSource Source_CTBANGIAO = new ReportDataSource("ds_bangiaothietbi_CTBANGIAO",LS_CTBANGIAO);

            this.reportViewer1.LocalReport.DataSources.Add(Source_BANGIAO);
            this.reportViewer1.LocalReport.DataSources.Add(Source_CTBANGIAO);

            this.reportViewer1.LocalReport.DisplayName = "CT_bangiaothietbi_" + BANGIAO.Single ().BanGiaoID.ToString() + "_" + BANGIAO.Single().NgayBanGiao;

            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 88;
        }

    }
}
