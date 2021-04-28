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
    public partial class frm_bienban_thanhlythietbi : DevComponents.DotNetBar.Office2007Form
    {

        public frm_bienban_thanhlythietbi()
        {
            InitializeComponent();
        }
        public frm_bienban_thanhlythietbi(string ThanhLyID)
        {
            InitializeComponent();
            hienthireport(ThanhLyID);
        }

        public void hienthireport(string ThanhLyID)
        {
            var THANHLY = new PHIEUTHANHLY_BLL().phieuthanhly_danhsach().Where(c => c.ThanhLyID == int.Parse(ThanhLyID)).Select(c => new
            {
                ThanhLyID = c.ThanhLyID,
                SoVanBan = c.SoVanBan,
                NgayVanBan = c.NgayVanBan.Value.Date.ToString("dd/MM/yyyy"),
                ThamQuyenQD = c.ThamQuyenQD,
                NgayThanhLy = c.NgayThanhLy.Value.Date.ToString("dd/MM/yyyy"),
                DaiDienThanhLy = (c.DaiDienThanhLy != 0 ? c.NHANVIEN.HoNV + " " + c.NHANVIEN.TenNV : ""),
                DonViThanhLy =(c.DaiDienThanhLy !=0?(c.NHANVIEN.DonViID !=0?c.NHANVIEN.DONVI.TenDonVi:""):""),
                ChucVuDaiDienThanhLy = (c.DaiDienThanhLy !=0?(c.NHANVIEN.ChucVuID !=0?c.NHANVIEN.CHUCVU.TenChucVu:""):""),
                DaiDienBenMua = c.DaiDienBenMua,
            }).ToList();

            var LST_CTTHANHLY = new CTTHANHLY_BLL().ctthanhly_danhsach(ThanhLyID).Select(c => new
            {
                MaThietBi = c.SOTHEODOI.GTTHIETBI.THIETBI.MaThietBi,
                SoHieu = c.SOTHEODOI.GTTHIETBI.THIETBI.SoHieu,
                TenThietBi = c.SOTHEODOI.GTTHIETBI.THIETBI.TenThietBi,
                DonViTinh = (c.SOTHEODOI.GTTHIETBI.THIETBI.DVTID !=0?c.SOTHEODOI.GTTHIETBI.THIETBI.DONVITINH.TenDVT :""),
                
                MaCaBiet=c.SOTHEODOI.GTTHIETBI.MaCaBiet,
                GiaTriThanhLy = c.GiaTriThanhLy,
            }).ToList();

            string DocSoTien = new LopHoTro.CHUYENKIEU().DecimalToString(LST_CTTHANHLY.Select(c => c.GiaTriThanhLy).Sum());
            //
            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThietBiPY.BaoCao_ThongKe.report.rpt_bienban_thanhlythietbi.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource Source_ThanhLy = new ReportDataSource("ds_thanhlythietbi_THANHLY", THANHLY);
            ReportDataSource Source_CTThanhLy = new ReportDataSource("ds_thanhlythietbi_CTTHANHLY", LST_CTTHANHLY);

            this.reportViewer1.LocalReport.DataSources.Add(Source_ThanhLy);
            this.reportViewer1.LocalReport.DataSources.Add(Source_CTThanhLy);

            //
            List<ReportParameter> parameters = new List<ReportParameter>();
            ReportParameter para = new ReportParameter();
            para = new ReportParameter("DocSoTien", DocSoTien);
            parameters.Add(para);
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.LocalReport.DisplayName = "CT_thanhlythietbi_" + THANHLY.Single().ThanhLyID.ToString() + "_" + THANHLY.Single().NgayThanhLy;
            this.reportViewer1.RefreshReport();

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 88;
        }
    }
}
