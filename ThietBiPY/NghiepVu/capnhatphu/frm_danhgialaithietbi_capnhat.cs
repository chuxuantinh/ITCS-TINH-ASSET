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
using iTextSharp.text.pdf;
using Net.SourceForge.Vietpad.InputMethod;

namespace ThietBiPY.NghiepVu.capnhatphu
{
    public partial class frm_danhgialaithietbi_capnhat : DevComponents.DotNetBar.Office2007Form
    {
        public frm_danhgialaithietbi_capnhat()
        {
            InitializeComponent();
        }

        string GTThietBiID = "";

        public frm_danhgialaithietbi_capnhat(string GTThietBiID)
        {
            InitializeComponent();

            this.GTThietBiID = GTThietBiID;
            var TB = new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.GTThietBiID == Int64.Parse(GTThietBiID)).SingleOrDefault();

            Barcode128 code128 = new Barcode128();
            code128.CodeType = Barcode.CODE128;
            code128.ChecksumText = true;
            code128.GenerateChecksum = true;
            code128.StartStopText = true;
            code128.Code = TB.GTTHIETBI.MaCaBiet;


            Bitmap bm_out = new Bitmap((int)code128.BarcodeSize.Width, (int)code128.BarcodeSize.Height + 10);
            Graphics g = Graphics.FromImage(bm_out);

            StringFormat strFormat = new StringFormat();
            strFormat.Alignment = StringAlignment.Center;
            strFormat.LineAlignment = StringAlignment.Center;

            g.DrawImage(code128.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.Transparent), new PointF(0, 0));
            g.DrawString(TB.GTTHIETBI.MaCaBiet, new Font("Tahoma", 10), new SolidBrush(Color.Black), new PointF((int)code128.BarcodeSize.Width / 2, (int)code128.BarcodeSize.Height + 0), strFormat);
            pic_macabiet.Image = bm_out;

            txt_tenthietbi.Text = TB.GTTHIETBI.THIETBI.TenThietBi;
            danhmuc_donvi(TB.DonViSD.ToString());
            cbo_bophansudung.SelectedValue = TB.BoPhanSD;

            danhmuc_tinhtrang(TB.TinhTrang.ToString());

            cbo_tinhtrang.SelectedValue = TB.TinhTrang;
            txt_hientrang.Text = TB.HienTrang;

            cbo_bophansudung.Enabled = false;
            cbo_donvisudung.Enabled = false;
        }
 
        //
        public void danhmuc_donvi(string giatri)
        {
            BindingSource binding_donvi = new BindingSource();
            binding_donvi.DataSource = new DONVI_BLL().donvi_danhsach().Select(c=>new{
                DonViID=c.DonViID,
                TenDonVi=c.TenDonVi,
            });
            binding_donvi.Add(new { DonViID = 0, TenDonVi = "Chưa xác định" });
            cbo_donvisudung.DataSource = binding_donvi;
            cbo_donvisudung.ValueMember = "DonViID";
            cbo_donvisudung.DisplayMember = "TenDonVi";

            cbo_donvisudung.SelectedIndexChanged += new EventHandler(cbo_donvisudung_SelectedIndexChanged);
            if (giatri != "") cbo_donvisudung.SelectedValue = int.Parse(giatri);
            else cbo_donvisudung.SelectedIndex = 0;
            cbo_donvisudung_SelectedIndexChanged(null, null);

        }
        private void cbo_donvisudung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_donvisudung.SelectedIndex >= 0)
            {
                danhmuc_bophan("0");
            }
        }
        public void danhmuc_bophan(string giatri)
        {
            BindingSource binding_bophan = new BindingSource();
            binding_bophan.DataSource = new BOPHAN_BLL().bophan_danhsach().Where(c=>c.DonViID==int.Parse(cbo_donvisudung.SelectedValue.ToString())).Select(c => new
            {
                BoPhanID=c.BoPhanID,
                TenBoPhan=c.TenBoPhan,
            });
            binding_bophan.Add(new { BoPhanID = 0, TenBoPhan = "Chưa xác định" });
            cbo_bophansudung.DataSource = binding_bophan;
            cbo_bophansudung.ValueMember = "BoPhanID";
            cbo_bophansudung.DisplayMember = "TenBoPhan";
            if (giatri != "") cbo_bophansudung.SelectedValue = int.Parse(giatri);
            else cbo_bophansudung.SelectedIndex = 0;
        }
        public void danhmuc_tinhtrang(string giatri)
        {
            BindingSource binding_tinhtrang = new BindingSource();
            binding_tinhtrang.DataSource = new TINHTRANG_BLL().tinhtrang_danhsach().Select(c => new
            {
                TinhTrangID=c.TinhTrangID,
                TenTinhTrang=c.TenTinhTrang,
            });
            binding_tinhtrang.Add(new { TinhTrangID = 0, TenTinhTrang = "Chưa xác định" });
            cbo_tinhtrang.DataSource = binding_tinhtrang;
            cbo_tinhtrang.ValueMember = "TinhTrangID";
            cbo_tinhtrang.DisplayMember = "TenTinhTrang";
            if (giatri != "") cbo_tinhtrang.SelectedValue = int.Parse(giatri);
            else cbo_tinhtrang.SelectedIndex = 0;
        }

        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        private void btn_luulai_Click(object sender, EventArgs e)
        {
            SOTHEODOI_BLL STD = new SOTHEODOI_BLL();
            STD.SOTHEODOI_DTO.DonViSD = (int)cbo_donvisudung.SelectedValue;
            STD.SOTHEODOI_DTO.BoPhanSD = (int)cbo_bophansudung.SelectedValue;
            STD.SOTHEODOI_DTO.TinhTrang = (int)cbo_tinhtrang.SelectedValue;
            STD.SOTHEODOI_DTO.HienTrang = txt_hientrang.Text;

            if (STD.sotheodoi_danhgialai(GTThietBiID) > 0)
            {
                guidulieu(GTThietBiID);
                this.Close();
            }
        }

        //
        private void frm_danhgialaithietbi_capnhat_Load(object sender, EventArgs e)
        {
            txt_hientrang.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_hientrang).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        private void frm_danhgialaithietbi_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: this.Close(); break;
            }
        }
    }
}
