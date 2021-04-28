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
    public partial class frm_bienban_theodonvisudung : DevComponents.DotNetBar.Office2007Form 
    {

        //
        string DonViID = "";
        bool TSCD = false;

        //
        public frm_bienban_theodonvisudung()
        {
            InitializeComponent();
            controlContainerItem_donvi.Visible = true;
            lbl_donvi.Visible = true;
            danhmuc_donvi("");
        }
        public frm_bienban_theodonvisudung(string DonViID,bool TSCD)
        {
            InitializeComponent();
            this.DonViID = DonViID;
            this.TSCD = TSCD;

            danhmuc_tinhtrang("");
            danhmuc_bophan("");

            hienthireport();
        }

        //
        private void hienthireport()
        {
            var NOISUDUNG = new DONVI_BLL().donvi_thongtin(DonViID);
            string TenDonVi = NOISUDUNG.TenDonVi;

            /*   string chuoitruyvan="";
               chuoitruyvan += "SELECT THIETBI.MaThietBi,THIETBI.HanBaoHanh,THIETBI.TenThietBi,GTTHIETBI.MaCaBiet,PHIEUNHAP.NgayNhap,CTPHIEUNHAP.DonGia,TINHTRANG.TenTinhTrang FROM SOTHEODOI ";
               chuoitruyvan +="inner join GTTHIETBI on SOTHEODOI.GTThietBiID=GTTHIETBI.GTThietBiID ";
               chuoitruyvan +="LEFT OUTER JOIN THIETBI on THIETBI.ThietBiID=GTTHIETBI.ThietBiID ";
               chuoitruyvan +="LEFT OUTER JOIN CTPHIEUNHAP on CTPHIEUNHAP.CTNhapID=GTTHIETBI.CTNhapID ";
               chuoitruyvan +="LEFT OUTER JOIN PHIEUNHAP on CTPHIEUNHAP.PhieuNhapID=PHIEUNHAP.PhieuNhapID ";
               chuoitruyvan += "LEFT OUTER JOIN TINHTRANG on TINHTRANG.TinhTrangID=SOTHEODOI.TinhTrang WHERE SOTHEODOI.DONVISD='" + DonViID + "'";
            */

            var LST_THEODOI = new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.DonViSD == NOISUDUNG.DonViID).Select(c => new
            {
                MaThietBi = c.GTTHIETBI.THIETBI.MaThietBi,
                TenThietBi = c.GTTHIETBI.THIETBI.TenThietBi,
                MaCaBiet = c.GTTHIETBI.MaCaBiet,
                NgaySD = (c.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.NgayNhap != null ? c.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.NgayNhap.Value.Date.ToString("dd/MM/yyyy") : ""),
                BaoHanh = c.GTTHIETBI.THIETBI.HanBaoHanh.ToString() + " tháng",
                GiaMua = c.GTTHIETBI.CTPHIEUNHAP.DonGia,
                TinhTrang = (c.TinhTrang != 0 ? c.TINHTRANG1.TenTinhTrang : ""),

                TinhTrangID=c.TinhTrang,
                BoPhanID=c.BoPhanSD,
            }).ToList();

            if (TSCD == true) LST_THEODOI = LST_THEODOI.Where(c => c.GiaMua >= 10000000).ToList();
            if (cbo_tinhtrang.SelectedIndex != cbo_tinhtrang.Items.Count - 1) LST_THEODOI = LST_THEODOI.Where(c => c.TinhTrangID == int.Parse(cbo_tinhtrang.SelectedValue.ToString())).ToList();
            if (cbo_bophan.SelectedIndex != cbo_bophan.Items.Count - 1) LST_THEODOI = LST_THEODOI.Where(c => c.BoPhanID == int.Parse(cbo_bophan.SelectedValue.ToString())).ToList();

            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThietBiPY.BaoCao_ThongKe.report.rpt_bienban_theodonvisudung.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource Source_SOTHEODOI = new ReportDataSource("ds_thietbidonvi_THIETBIDONVI", LST_THEODOI.ToList());

            this.reportViewer1.LocalReport.DataSources.Add(Source_SOTHEODOI);

            //
            List<ReportParameter> parameters = new List<ReportParameter>();
            ReportParameter para = new ReportParameter();
            para = new ReportParameter("para_donvi", TenDonVi);
            parameters.Add(para);

            para = new ReportParameter("para_tscd", (TSCD == true ? "1" : "0"));
            parameters.Add(para);

            para = new ReportParameter("para_bophan", cbo_bophan.Text);
            parameters.Add(para);

            para = new ReportParameter("para_tinhtrang",cbo_tinhtrang.Text);
            parameters.Add(para);

            this.reportViewer1.LocalReport.SetParameters(parameters);
            //
            reportViewer1.LocalReport.DisplayName = "SOTHEODOI_" + DateTime.Now.Year.ToString() + "_" + TenDonVi;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }

        //
        private void danhmuc_donvi(string giatri)
        {
            BindingSource binding_donvi = new BindingSource();
            binding_donvi.DataSource = new SOTHEODOI_BLL().sotheodoi_danhsach().Select(c => new
            {
                DonViID=c.DonViSD,
                TenDonVi=(c.DonViSD!=0?c.DONVI.TenDonVi:"Chưa xác định"),
            }).Distinct().ToList();
            cbo_donvi.DataSource = binding_donvi;
            if (binding_donvi.Count > 0)
            {
                cbo_donvi.DisplayMember = "TenDonVi";
                cbo_donvi.ValueMember = "DonViID";

                if (giatri != "") cbo_donvi.SelectedValue = int.Parse(giatri);
                else cbo_donvi.SelectedIndex = 0;
                cbo_donvi.SelectedIndexChanged += new EventHandler(cbo_donvi_SelectIndexChanged);
                cbo_donvi_SelectIndexChanged(null, null);
            }
        }
        private void cbo_donvi_SelectIndexChanged(object sender, EventArgs e)
        {
            if (cbo_donvi.SelectedIndex >= 0)
            {
                this.DonViID = cbo_donvi.SelectedValue.ToString();
                danhmuc_bophan("");
                danhmuc_tinhtrang("");
            }
        }

        private void danhmuc_tinhtrang(string giatri)
        {
            BindingSource binding_tinhtrang = new BindingSource();
            binding_tinhtrang.DataSource = new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.DonViSD == int.Parse(DonViID)).Select(c => new
            {
                TinhTrangID = c.TinhTrang,
                TenTinhTrang = (c.TinhTrang != 0 ? c.TINHTRANG1.TenTinhTrang : "Chưa xác định"),
            }).Distinct().ToList();
            // binding_tinhtrang.Add(new { TinhTrangID = 0, TenTinhTrang = "Chưa xác định" });
            binding_tinhtrang.Add(new { TinhTrangID = binding_tinhtrang.Count, TenTinhTrang = "Tất cả" });
            cbo_tinhtrang.DataSource = binding_tinhtrang;

            if (binding_tinhtrang.Count > 0)
            {
                cbo_tinhtrang.ValueMember = "TinhTrangID";
                cbo_tinhtrang.DisplayMember = "TenTinhTrang";

                if (giatri != "") cbo_tinhtrang.SelectedValue = int.Parse(giatri);
                else cbo_tinhtrang.SelectedIndex = cbo_tinhtrang.Items.Count - 1;

                cbo_tinhtrang.SelectedIndexChanged += new EventHandler(cbo_tinhtrang_SelectIndexChanged);
                cbo_tinhtrang_SelectIndexChanged(null, null);
            }
        }
        private void cbo_tinhtrang_SelectIndexChanged(object sender, EventArgs e)
        {
            hienthireport();
        }

        private void danhmuc_bophan(string giatri)
        {
            BindingSource binding_bophan = new BindingSource();
            binding_bophan.DataSource = new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.DonViSD == int.Parse(this.DonViID)).Select(c => new
            {
                BoPhanID=c.BoPhanSD,
                TenBoPhan=(c.BoPhanSD!=0?c.BOPHAN.TenBoPhan:"Chưa xác định"),
            }).Distinct().ToList();
            binding_bophan.Add(new { BoPhanID = binding_bophan.Count, TenBoPhan = "Tất cả" });

            cbo_bophan.DataSource = binding_bophan;
            cbo_bophan.ValueMember = "BoPhanID";
            cbo_bophan.DisplayMember = "TenBoPhan";

            if (giatri != "") cbo_bophan.SelectedValue = int.Parse(giatri);
            else cbo_bophan.SelectedIndex = cbo_bophan.Items.Count - 1;

            cbo_bophan.SelectedIndexChanged += new EventHandler(cbo_bophan_SelectIndexChanged);
            cbo_bophan_SelectIndexChanged(null, null);
        }
        private void cbo_bophan_SelectIndexChanged(object sender, EventArgs e)
        {
            hienthireport();
        }
    }
}
/*-- 05/07/2011-Thứ 3 
    
*/