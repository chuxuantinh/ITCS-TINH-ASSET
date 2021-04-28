using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ThietBiPY.BaoCao_ThongKe.dataset;
using ThietBiPY.BaoCao_ThongKe.report;
using ThietBiDAL;
using ThietBiBLL;
using Microsoft.Reporting.WinForms;


namespace ThietBiPY.BaoCao_ThongKe.report
{
    public partial class frm_bienban_giaonhanthietbi : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_bienban_giaonhanthietbi()
        {
            InitializeComponent();
        }

        string PhieuNhapID = "";
        public frm_bienban_giaonhanthietbi(string PhieuNhapID)
        {
            InitializeComponent();
            this.PhieuNhapID = PhieuNhapID;
        }

        private void frm_bienban_giaonhanthietbi_Load(object sender, EventArgs e)
        {

            HienThiReport();
        }

        //
        public void HienThiReport()
        {
            var LST_PHIEUNHAP = new PHIEUNHAP_BLL().phieunhap_danhsach().Where(c => c.PhieuNhapID == int.Parse(PhieuNhapID)).Select(c => new
            {
                PhieuNhapID = c.PhieuNhapID,
                SoVanBan = c.SoVanBan,
                NgayNhap = c.NgayNhap.Value.Date,
                NgayVanBan =(c.NgayVanBan!=null?c.NgayVanBan.Value.Date.ToString("dd/MM/yyyy"):""),
                TenNCC = (c.NCCID!=0?c.NHACUNGCAP.TenNCC:""),
                HoTenNLH = (c.NCCID!=0? c.NHACUNGCAP.HoNguoiLH + " " + c.NHACUNGCAP.TenNguoiLH:""),
                ChucVu = (c.NCCID!=0?c.NHACUNGCAP.ChucVu:""),
                NhanVienNhan1 = (c.NhanVienNhan1 !=0?c.NHANVIEN.HoNV +" " + c.NHANVIEN.TenNV:""),
                CVNhanVienNhan1 = (c.NhanVienNhan1!=0? (c.NHANVIEN.ChucVuID !=0? c.NHANVIEN.CHUCVU.TenChucVu:""):""),

                NhanVienNhan2 = (c.NhanVienNhan2!=0? c.NHANVIEN1 .HoNV +" "+c.NHANVIEN1.TenNV:""),
                CVNhanVienNhan2 =(c.NhanVienNhan2!=0? (c.NHANVIEN1.ChucVuID !=0?c.NHANVIEN1.CHUCVU.TenChucVu:""):""),

                DonViNhan= (c.DonViNhan !=0?c.DONVI.TenDonVi:""),
                BoPhanNhan= (c.BoPhanNhan!=0?c.BOPHAN .TenBoPhan:""),

                ThamQuyenQD = c.ThamQuyenQD,
            });//.Single();

            var LST_CTTHIETBI = new CTPHIEUNHAP_BLL().ctphieunhap_danhsach().Where (c=>c.PhieuNhapID ==int.Parse(PhieuNhapID)).Select(c => new
            {
                ThietBiID = c.ThietBiID,
                TenThietBi = c.THIETBI.TenThietBi,
                SoHieu = c.THIETBI.SoHieu,
                DonViTinh = (c.THIETBI.DVTID !=0?c.THIETBI.DONVITINH.TenDVT :""),
                NuocSX = (c.THIETBI.NamSX!=0?c.THIETBI.NUOC.TenNuoc :""),
                NamSX = c.THIETBI.NamSX,
                HanBaoHanh = c.THIETBI.HanBaoHanh,
                SoLuong = c.SoLuong,
                DonGia = c.DonGia,
                TaiLieuKT = (c.THIETBI.TaiLieuKT !=""?"Có":"Không"),
                LoaiTB = (c.THIETBI.LoaiTBID !=0?c.THIETBI.LOAITHIETBI.TenLoaiTB :"[Chưa xác định]"),
            });

            string NguyenGia = new LopHoTro.CHUYENKIEU().DecimalToString(LST_CTTHIETBI.Select(c => (decimal)c.SoLuong * c.DonGia).Sum());


            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ThietBiPY.BaoCao_ThongKe.report.rpt_bienban_giaonhanthietbi.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource Source_CTPhieuNhap = new ReportDataSource("ds_giaonhanthietbi_CTPHIEUNHAP", LST_CTTHIETBI);
            ReportDataSource Source_PhieuNhap = new ReportDataSource("ds_giaonhanthietbi_PHIEUNHAP", LST_PHIEUNHAP);

            this.reportViewer1.LocalReport.DataSources.Add(Source_CTPhieuNhap);
            this.reportViewer1.LocalReport.DataSources.Add(Source_PhieuNhap);

            reportViewer1.LocalReport.DisplayName = "HS_GiaoNhanThietBi_" + LST_PHIEUNHAP.Single().SoVanBan+ "_"+ LST_PHIEUNHAP.Single().NgayNhap.ToString("ddMMyyyy");

            List<ReportParameter> parameters = new List<ReportParameter>();
            ReportParameter para = new ReportParameter();
            para = new ReportParameter("DocNguyenGia", NguyenGia);
            parameters.Add(para);
            this.reportViewer1.LocalReport.SetParameters(parameters);
            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 88;
        }
    }
}
