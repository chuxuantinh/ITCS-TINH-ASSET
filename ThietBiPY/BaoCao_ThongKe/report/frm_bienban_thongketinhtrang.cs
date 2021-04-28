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
    public partial class frm_bienban_thongketinhtrang : Form
    {
        public frm_bienban_thongketinhtrang()
        {
            InitializeComponent();

          var LST_TKDV = (from std in new SOTHEODOI_BLL().sotheodoi_danhsach()
                            join dv in new DONVI_BLL().donvi_danhsach() on std.DonViSD equals dv.DonViID 
                            join tt in new TINHTRANG_BLL().tinhtrang_danhsach() on std.TinhTrang equals tt.TinhTrangID into std_tt

                            from f in std_tt.DefaultIfEmpty()
                            select new
                            {
                                TenDonVi = dv.TenDonVi,
                                TinhTrang =(f!=null? f.TenTinhTrang:"Chưa xác định"),
                                GTThietBiID = std.GTThietBiID,
                            }).ToList();


          /* var LST_TKDV = new DBDataContext().PRO_THONGKE_DONVI().Select(c => new
         {
             TenDonVi=c.TenDonvi,
             TenTinhTrang=c.TenTinhTrang,
             SL=c.SL,
         }); */
            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThietBiPY.BaoCao_ThongKe.report.rpt_bienban_thongkedonvi.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource Source_SOTHEODOI = new ReportDataSource("ds_thietbidonvi_DONVI", LST_TKDV.ToList());
            this.reportViewer1.LocalReport.DataSources.Add(Source_SOTHEODOI);
 
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;

            this.reportViewer1.RefreshReport();
        }
    }
}
