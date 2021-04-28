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
using System.Drawing.Printing;
using iTextSharp.text.pdf;

namespace ThietBiPY.DanhMuc
{
    public partial class frm_thietbi_thongtinchitiet : DevComponents.DotNetBar.Office2007Form
    {
        public frm_thietbi_thongtinchitiet()
        {
            InitializeComponent();
        }

        string MaCaBiet = "";
        public frm_thietbi_thongtinchitiet(string MaCaBiet)
        {
            InitializeComponent();
            this.Name = "frm_thietbi_thongtinchitiet" + MaCaBiet;
            this.Text = "Mã cá biệt: " + MaCaBiet;
            this.MaCaBiet = MaCaBiet;
            lv_thongtincoban.Columns.Add("Thông tin", 100);
            lv_thongtincoban.Columns.Add("Chi tiết", 250);

            //
            lv_thongtingiatri_thietbi.Columns.Add("Mã cá biệt", 150);
            lv_thongtingiatri_thietbi.Columns.Add("Ngày nhập", 80);
            lv_thongtingiatri_thietbi.Columns.Add("Số văn bản", 80, HorizontalAlignment.Center);
            lv_thongtingiatri_thietbi.Columns.Add("Nguyên giá", 100, HorizontalAlignment.Right);

            lv_thongtingiatri_thietbi.Columns.Add("Đơn vị SD", 150);
            lv_thongtingiatri_thietbi.Columns.Add("Bộ phận SD", 150);
            lv_thongtingiatri_thietbi.Columns.Add("Tình trạng", 100);
            lv_thongtingiatri_thietbi.Columns.Add("Hiện trạng", 100);
            //
            var GTThietBiID = new GTTHIETBI_BLL().gtthietbi_danhsach().Where(c => c.MaCaBiet.Equals(MaCaBiet)).SingleOrDefault().GTThietBiID;
            var CHITIET = new SOTHEODOI_BLL().sotheodoi_chitietthietbi(GTThietBiID.ToString());

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

            g.DrawImage(code128.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.Transparent), new PointF(0, 0));
            g.DrawString(MaCaBiet, new Font("Tahoma", 10), new SolidBrush(Color.Black), new PointF((int)code128.BarcodeSize.Width / 2, (int)code128.BarcodeSize.Height + 0), strFormat);
            pic_macabiet.Image = bm_out;

            if (CHITIET.GTTHIETBI.THIETBI.HinhAnh != null) pic_hinhanh.Image = new LopHoTro.CHUYENKIEU().BinaryToImage(CHITIET.GTTHIETBI.THIETBI.HinhAnh);
            lv_thongtincoban.Items[0].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.MaThietBi);
            lv_thongtincoban.Items[1].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.LoaiTBID != 0 ? CHITIET.GTTHIETBI.THIETBI.LOAITHIETBI.TenLoaiTB : "Chưa xác định");

            lv_thongtincoban.Items[2].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.SoHieu);
            lv_thongtincoban.Items[3].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.NuocSX != 0 ? CHITIET.GTTHIETBI.THIETBI.NUOC.TenNuoc : "Chưa xác định");
            lv_thongtincoban.Items[4].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.NamSX.ToString());
            lv_thongtincoban.Items[5].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.HanBaoHanh + " tháng");
            lv_thongtincoban.Items[6].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.TaiLieuKT != "" ? "Click để xem" : "Không");

            if (CHITIET.GTTHIETBI.THIETBI.TaiLieuKT != "")
            {
                lv_thongtincoban.Items[6].Tag = CHITIET.GTTHIETBI.ThietBiID.ToString();
                lv_thongtincoban.DoubleClick += new EventHandler(lv_thongtincoban_DoubleClick);
            }
            else for (int cot = 0; cot < lv_thongtincoban.Columns.Count; cot++) lv_thongtincoban.Items[6].SubItems[cot].BackColor = Color.WhiteSmoke;
            //
            wb_thongtin_thietbi.DocumentText = "<html><body><font size='2' face='tahoma' color='blue'><p align=center>Thông Số Kỹ Thuật</p></font><font size='2' face='tahoma'>" + CHITIET.GTTHIETBI.THIETBI.ThongSoKT + "</font></body></html>";

            //
            lv_thongtingiatri_thietbi.Items.Add(MaCaBiet);
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.NgayNhap.Value.Date.ToString("dd/MM/yyyy"));
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.SoVanBan);
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(string.Format("{0:0,0 đ}", CHITIET.GTTHIETBI.CTPHIEUNHAP.DonGia));
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.DonViSD != 0 ? CHITIET.DONVI.TenDonVi : "Chưa xác định");
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.BoPhanSD != 0 ? CHITIET.BOPHAN.TenBoPhan : "Chưa xác định");
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.TinhTrang != 0 ? CHITIET.TINHTRANG1.TenTinhTrang : "Chưa xác định");
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.HienTrang);
        }
        public frm_thietbi_thongtinchitiet(string MaCaBiet,string DonViID,string BoPhanID)
        {
            InitializeComponent();
            this.MaCaBiet = MaCaBiet;
            lv_thongtincoban.Columns.Add("Thông tin", 100);
            lv_thongtincoban.Columns.Add("Chi tiết", 250);

            //
            lv_thongtingiatri_thietbi.Columns.Add("Mã cá biệt", 150);
            lv_thongtingiatri_thietbi.Columns.Add("Ngày nhập", 80);
            lv_thongtingiatri_thietbi.Columns.Add("Số văn bản",80,HorizontalAlignment.Center);
            lv_thongtingiatri_thietbi.Columns.Add("Nguyên giá", 100,HorizontalAlignment.Right);

            lv_thongtingiatri_thietbi.Columns.Add("Đơn vị SD", 150);
            lv_thongtingiatri_thietbi.Columns.Add("Bộ phận SD", 150);
            lv_thongtingiatri_thietbi.Columns.Add("Tình trạng", 100);
            lv_thongtingiatri_thietbi.Columns.Add("Hiện trạng", 100);
            //
            var GTThietBiID = new GTTHIETBI_BLL().gtthietbi_danhsach().Where(c => c.MaCaBiet.Equals(MaCaBiet)).Single().GTThietBiID;
            var CHITIET = new SOTHEODOI_BLL().sotheodoi_chitietthietbi(GTThietBiID.ToString());
            /* var CHITIET = (from tb in new THIETBI_BLL().thietbi_danhsach()
                           join gttb in new GTTHIETBI_BLL().gtthietbi_danhsach() on tb.ThietBiID equals gttb.ThietBiID
                           join ctpn in new CTPHIEUNHAP_BLL().ctphieunhap_danhsach() on gttb.CTNhapID equals ctpn.CTNhapID into ctpn_gttb
                           join std in new SOTHEODOI_BLL().sotheodoi_danhsach() on gttb.GTThietBiID equals std.GTThietBiID
                           from f in ctpn_gttb.DefaultIfEmpty()
                           where gttb.GTThietBiID == GTThietBiID && std.DonViSD == int.Parse(DonViID) && std.BoPhanSD == int.Parse(BoPhanID)

                           select new
                           {
                               ThietBiID = tb.ThietBiID,
                               MaThietBi = tb.MaThietBi,
                               TenThietBi = tb.TenThietBi,
                               LoaiTB = (tb.LoaiTBID != 0 ? tb.LOAITHIETBI.TenLoaiTB : ""),
                               SoHieu = tb.SoHieu,
                               NuocSanXuat = (tb.NuocSX != 0 ? tb.NUOC.TenNuoc : ""),
                               NamSanXuat = tb.NamSX.ToString(),
                               HanBaoHanh = tb.HanBaoHanh.ToString(),
                               TaiLieuDinhKem = tb.TaiLieuKT,
                               NDTaiLieu = tb.NDTaiLieuKT,
                               ThongSoKT = tb.ThongSoKT,
                               HinhAnh = tb.HinhAnh,
                               MoTaThem = tb.MoTaThem,

                               NgayNhap = (f.PhieuNhapID != 0 ? f.PHIEUNHAP.NgayNhap.Value.ToString("dd/MM/yyyy") : ""),
                               SoVanBan = (f.PhieuNhapID != 0 ? f.PHIEUNHAP.SoVanBan : ""),
                               DonGia = string.Format("{0:0,0 đồng}", f.DonGia),
                               DonViSD = (std.DonViSD != 0 ? std.DONVI.TenDonVi : "Chưa xác định"),
                               BoPhanSD = (std.BoPhanSD != 0 ? std.BOPHAN.TenBoPhan : "Chưa xác định"),

                               TinhTrang = (std.TinhTrang != 0 ? std.TINHTRANG1.TenTinhTrang : "Chưa xác định"),
                               HienTrang = std.HienTrang,
                           }).SingleOrDefault();
            */

            //

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

            g.DrawImage(code128.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.Transparent), new PointF(0, 0));
            g.DrawString(MaCaBiet, new Font("Tahoma", 10), new SolidBrush(Color.Black), new PointF((int)code128.BarcodeSize.Width / 2, (int)code128.BarcodeSize.Height + 0), strFormat);
            pic_macabiet.Image = bm_out;

            this.Text = MaCaBiet + " - " + CHITIET.GTTHIETBI.THIETBI.TenThietBi;

            if (CHITIET.GTTHIETBI.THIETBI.HinhAnh != null) pic_hinhanh.Image = new LopHoTro.CHUYENKIEU().BinaryToImage(CHITIET.GTTHIETBI.THIETBI.HinhAnh);
            lv_thongtincoban.Items[0].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.MaThietBi);
            lv_thongtincoban.Items[1].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.LoaiTBID != 0 ? CHITIET.GTTHIETBI.THIETBI.LOAITHIETBI.TenLoaiTB : "Chưa xác định");

            lv_thongtincoban.Items[2].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.SoHieu);
            lv_thongtincoban.Items[3].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.NuocSX!=0?CHITIET.GTTHIETBI.THIETBI.NUOC.TenNuoc:"Chưa xác định");
            lv_thongtincoban.Items[4].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.NamSX.ToString());
            lv_thongtincoban.Items[5].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.HanBaoHanh +" tháng");
            lv_thongtincoban.Items[6].SubItems.Add(CHITIET.GTTHIETBI.THIETBI.TaiLieuKT != "" ? "Click để xem" : "Không");

            if (CHITIET.GTTHIETBI.THIETBI.TaiLieuKT != "")
            {
                lv_thongtincoban.Items[6].Tag = CHITIET.GTTHIETBI.ThietBiID.ToString();
                lv_thongtincoban.DoubleClick += new EventHandler(lv_thongtincoban_DoubleClick);
            }
            else for(int cot=0;cot<lv_thongtincoban.Columns.Count;cot++)lv_thongtincoban.Items[6].SubItems[cot].BackColor = Color.WhiteSmoke;
            //
            wb_thongtin_thietbi.DocumentText = "<html><body><font size='2' face='tahoma' color='blue'><p align=center>Thông Số Kỹ Thuật</p></font><font size='2' face='tahoma'>" + CHITIET.GTTHIETBI.THIETBI.ThongSoKT + "</font></body></html>";
        
            //
            lv_thongtingiatri_thietbi.Items.Add(MaCaBiet);
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.NgayNhap.Value.Date.ToString("dd/MM/yyyy"));
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.GTTHIETBI.CTPHIEUNHAP.PHIEUNHAP.SoVanBan);
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(string.Format("{0:0,0 đ}",CHITIET.GTTHIETBI.CTPHIEUNHAP.DonGia));
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.DonViSD!=0?CHITIET.DONVI.TenDonVi:"Chưa xác định");
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.BoPhanSD!=0?CHITIET.BOPHAN.TenBoPhan:"Chưa xác định");
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.TinhTrang!=0?CHITIET.TINHTRANG1.TenTinhTrang:"Chưa xác định");
            lv_thongtingiatri_thietbi.Items[0].SubItems.Add(CHITIET.HienTrang);
        }
        private void lv_thongtincoban_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var TB = new THIETBI_BLL().thietbi_thongtin(lv_thongtincoban.Items[6].Tag.ToString());
                if (System.IO.File.Exists(System.IO.Path.GetTempPath() + "\\" + TB.TaiLieuKT))
                {
                    System.IO.File.Delete(System.IO.Path.GetTempPath() + "\\" + TB.TaiLieuKT);
                }

                new LopHoTro.CHUYENKIEU().BinaryToFile(TB.NDTaiLieuKT, System.IO.Path.GetTempPath() + "\\" + TB.TaiLieuKT);
                System.Diagnostics.Process.Start(System.IO.Path.GetTempPath() + "\\" + TB.TaiLieuKT);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void frm_thietbi_thongtinchitiet_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: this.Close(); break;
                case Keys.F12 :
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    else this.WindowState = FormWindowState.Maximized;
                    break;
            }
        }

        private void pic_macabiet_DoubleClick(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            diag.Filter = "File ảnh(*.gif)|*.gif";
            diag.FileName = MaCaBiet;
            diag.Title = "Lưu file...";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                pic_macabiet.Image.Save(diag.FileName);
            }
        }
        private void pic_macabiet_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_macabiet, MaCaBiet);
        }

    }
}
