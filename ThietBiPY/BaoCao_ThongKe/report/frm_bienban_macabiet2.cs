using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using iTextSharp.text.pdf;

namespace ThietBiPY.BaoCao_ThongKe.report
{
    public partial class frm_bienban_macabiet2 : Form
    {

        DataTable dt = new DataTable();
        public frm_bienban_macabiet2(List<string> LST_MaCaBiet)
        {
            InitializeComponent();
            dt.Columns.Add("HinhAnh");

            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThietBiPY.BaoCao_ThongKe.report.rpt_bienban_macabiet.rdlc";
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.DataSources.Clear();

           
            foreach (var str in LST_MaCaBiet)
            {
                Add_List(str);
            }
            ReportDataSource Source_MACABIET = new ReportDataSource("ds_thietbidonvi_MACABIET",dt);
            this.reportViewer1.LocalReport.DataSources.Add(Source_MACABIET);
            this.reportViewer1.RefreshReport();
        }

        private void frm_bienban_macabiet2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void Add_List(string MaCaBiet)
        {
            Barcode128 code128 = new Barcode128();
            code128.CodeType = Barcode.CODE128;
            code128.ChecksumText = true;
            code128.GenerateChecksum = true;
            code128.StartStopText = true;
            code128.Code = MaCaBiet;


            Bitmap bm_out = new Bitmap((int)code128.BarcodeSize.Width, (int)code128.BarcodeSize.Height + 10);
            Graphics g = Graphics.FromImage(bm_out);

            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;

            g.DrawImage(code128.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White), new PointF(0, 0));
            g.DrawString(MaCaBiet, new Font("Tahoma", 10), new SolidBrush(Color.Black), new PointF((int)code128.BarcodeSize.Width / 2, (int)code128.BarcodeSize.Height + 0), strFormat);
            bm_out.Save(System.IO.Path.GetTempPath() + "\\" + MaCaBiet + ".gif", System.Drawing.Imaging.ImageFormat.Gif);

            DataRow dr = dt.NewRow();
            dr["HinhAnh"] = "file:" + System.IO.Path.GetTempPath() + "\\" + MaCaBiet + ".gif";
            dt.Rows.Add(dr);
        }
    }
}
