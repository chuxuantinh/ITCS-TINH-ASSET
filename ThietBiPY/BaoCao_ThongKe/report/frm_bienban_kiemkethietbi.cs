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
    public partial class frm_bienban_kiemkethietbi : DevComponents.DotNetBar.Office2007Form
    {
        public frm_bienban_kiemkethietbi()
        {
            InitializeComponent();
        }

        public frm_bienban_kiemkethietbi(string KiemKeID)
        {
            InitializeComponent();
            var KIEMKE = new PHIEUKIEMKE_BLL().phieukiemke_thongtin(KiemKeID);

            var LST_DDKK = new DAIDIENKIEMKE_BLL().ddkiemke_danhsach(KiemKeID).Select(c => new
            {
                HoTen=(c.NhanVienID !=0?c.NHANVIEN.HoNV+" "+c.NHANVIEN.TenNV:""),
                ChucVu=(c.NhanVienID!=0?(c.NHANVIEN.ChucVuID!=0?c.NHANVIEN.CHUCVU.TenChucVu:""):""),
                QuyenKiemKe=c.QuyenKiemKe,
            }).ToList();

            var LST_CTKK = new CTKIEMKE_BLL().ctkiemke_danhsach(KiemKeID).Select(c => new
            {
                MaCaBiet = c.SOTHEODOI.GTTHIETBI.MaCaBiet,
                MaThietBi = c.SOTHEODOI.GTTHIETBI.THIETBI.MaThietBi,
                SoHieu = c.SOTHEODOI.GTTHIETBI.THIETBI.SoHieu,
                TenThietBi = c.SOTHEODOI.GTTHIETBI.THIETBI.TenThietBi,
                NgaySuDung = c.SOTHEODOI.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.NgayNhap.Value.Date.ToString("dd/MM/yyyy"),
                BaoHanh = c.SOTHEODOI.GTTHIETBI.THIETBI.HanBaoHanh.ToString() + "tháng",
                TinhTrangSS = (c.TinhTrang0 != 0 ? c.TINHTRANG.TenTinhTrang : ""),
                HienTrangSS = c.HienTrang0,
                TinhTrangKK = (c.TinhTrang1 != 0 ? c.TINHTRANG2.TenTinhTrang : ""),
                HienTrangKK = c.HienTrang1,
            }).ToList();

            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThietBiPY.BaoCao_ThongKe.report.rpt_bienban_kiemkethietbi.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource Source_DDKK= new ReportDataSource("ds_kiemkethietbi_DAIDIENKIEMKE", LST_DDKK);
            ReportDataSource Source_CTKK = new ReportDataSource("ds_kiemkethietbi_CTKIEMKE", LST_CTKK);

            this.reportViewer1.LocalReport.DataSources.Add(Source_DDKK);
            this.reportViewer1.LocalReport.DataSources.Add(Source_CTKK);

            List<ReportParameter> parameters = new List<ReportParameter>();
            ReportParameter para = new ReportParameter();
            para = new ReportParameter("NgayKiemKe", (KIEMKE.NgayKiemKe != null ? KIEMKE.NgayKiemKe.Value.Date.ToString("dd/MM/yyyy") : ""));
            parameters.Add(para);
            
            para = new ReportParameter("NgayVanBan", (KIEMKE.NgayVanBan != null ? KIEMKE.NgayVanBan.Value.Date.ToString("dd/MM/yyyy") : ""));
            parameters.Add(para);

            para = new ReportParameter("SoVanBan", KIEMKE.SoVanBan);
            parameters.Add(para);

            para = new ReportParameter("ThamQuyenQD", KIEMKE.ThamQuyenQD);
            parameters.Add(para);

            para = new ReportParameter("DonViKiemKe", KIEMKE.DONVI.TenDonVi);
            parameters.Add(para);

            para = new ReportParameter("BoPhanKiemKe", (KIEMKE.BoPhanKiemKe != 0 ? KIEMKE.BOPHAN.TenBoPhan : ""));
            parameters.Add(para);

            para = new ReportParameter("DonViKiemKe", KIEMKE.DONVI.TenDonVi);
            parameters.Add(para);

            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 88;
        }
    }
}
