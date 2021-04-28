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

using Net.SourceForge.Vietpad.InputMethod;

namespace ThietBiPY.DanhMuc
{
    public partial class frm_thietbi_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        //danhsachphutung_thietbi() là hàm hiển thị danh sách phụ tùng kèm theo tương ứng với thiết bị đó
        
        string ma = "";

        //Khai báo
        public frm_thietbi_capnhat()
        {
            InitializeComponent();
            this.Text = "Thêm thiết bị";

            lv_phutung.Columns.Add("STT", 40, HorizontalAlignment.Center);
            lv_phutung.Columns.Add("Phụ tùng", 200);
            lv_phutung.Columns.Add("Số hiệu", 200);
            lv_phutung.Columns.Add("Nước sản xuất", 200);

            txt_mathietbi.Text = new THIETBI_BLL().thietbi_taoma();
            txt_sohieu.Text = txt_mathietbi.Text + DateTime.Now.Date.ToString("ddMMyyyy");
            danhmuc_nuocsanxuat("0");
            danhmuc_loaithietbi("");
            danhmuc_donvitinh("0");
            danhmuc_phutung("0");
        }
        public frm_thietbi_capnhat(string LoaiTB)
        {
            InitializeComponent();
            this.Text = "Thêm thiết bị";

            lv_phutung.Columns.Add("STT", 40, HorizontalAlignment.Center);
            lv_phutung.Columns.Add("Phụ tùng", 200);
            lv_phutung.Columns.Add("Số hiệu", 200);
            lv_phutung.Columns.Add("Nước sản xuất", 200);

            txt_mathietbi.Text = new THIETBI_BLL().thietbi_taoma();
            txt_sohieu.Text = txt_mathietbi.Text + DateTime.Now.Date.ToString("ddMMyyyy");
            danhmuc_nuocsanxuat("0");
            danhmuc_loaithietbi(LoaiTB);
            danhmuc_donvitinh("0");
            danhmuc_phutung("0");
        }
        public frm_thietbi_capnhat(string ma,string LoaiTB)
        {
            InitializeComponent();
            this.ma = ma;

            lv_phutung.Columns.Add("STT", 40, HorizontalAlignment.Center);
            lv_phutung.Columns.Add("Phụ tùng", 200);
            lv_phutung.Columns.Add("Số hiệu", 200);
            lv_phutung.Columns.Add("Nước sản xuất", 200);

            LST_PHUTUNG = new PHUTUNG_BLL().phutung_danhsach().Where(c => c.ThietBiID == int.Parse(ma)).ToList();
            danhsachphutung_thietbi();

            var TB = new THIETBI_BLL().thietbi_thongtin(ma);
            if (TB != null)
            {
                this.Text = "Hiệu chỉnh thiết bị:ID=" + ma + ";Tên gọi:" + TB.TenThietBi;
                txt_mathietbi.Text = TB.MaThietBi;
                txt_sohieu.Text = TB.SoHieu;
                txt_tenthietbi.Text = TB.TenThietBi;

                danhmuc_donvitinh(TB.DVTID.ToString());
                input_baohanh.Value = (int)TB.HanBaoHanh;
                danhmuc_loaithietbi(LoaiTB);
                danhmuc_nuocsanxuat(TB.NuocSX.ToString());
                input_namsx.Value = (int)TB.NamSX;

                txt_thongsokt.Text = TB.ThongSoKT;
                txt_motathem.Text = TB.MoTaThem;
                txt_tailieu.Text = TB.TaiLieuKT;
                txt_tailieu.Tag = (TB.NDTaiLieuKT!=null? TB.NDTaiLieuKT.ToArray():null);
               
                if (TB.HinhAnh != null) pic_hinhanh.Image = new LopHoTro.CHUYENKIEU().BinaryToImage(TB.HinhAnh);

                danhmuc_phutung("0");
            }
        }

        //Biến toàn cục
        List<PHUTUNG> LST_PHUTUNG = new List<PHUTUNG>();

        //
        #region "Hàm xử lý"
        //
        public void danhmuc_nuocsanxuat(string giatri)
        {
            BindingSource binding_nuocsx = new BindingSource();
            binding_nuocsx.DataSource = new NUOC_BLL().nuoc_danhsach().ToList();
            binding_nuocsx.Add(new NUOC { NuocID = 0, TenNuoc = "Chưa xác định" });
            cbo_nuocsanxuat.DataSource = binding_nuocsx;
            cbo_nuocsanxuat.DisplayMember = "TenNuoc";
            cbo_nuocsanxuat.ValueMember = "NuocID";

            cbo_nuocsanxuat.SelectedValue = int.Parse(giatri);
        }
        public void danhmuc_loaithietbi(string giatri)
        {
            BindingSource binding_loaithietbi = new BindingSource();
            binding_loaithietbi.DataSource = new LOAITHIETBI_BLL().loaithietbi_danhsach().Select(c => new
            {
                LoaiTBID = c.LoaiTBID,
                TenLoaiTB = c.TenLoaiTB,
                TenNhomTB = (c.NHOMTHIETBI != null ? c.NHOMTHIETBI.TenNhomTB : "Chưa xác định"),
            });
            binding_loaithietbi.Add(new { LoaiTBID = 0, TenLoaiTB = "Chưa xác định", TenNhomTB = "Chưa xác định" });
            cbo_loaithietbi.DataSource = binding_loaithietbi;
            cbo_loaithietbi.GroupingMembers = "TenNhomTB";
            cbo_loaithietbi.ValueMember = "LoaiTBID";
            cbo_loaithietbi.DisplayMembers = "TenLoaiTB";

            if (giatri != "") cbo_loaithietbi.SelectedValue = int.Parse(giatri);
            else cbo_loaithietbi.SelectedIndex = 0;
        }
        public void danhmuc_donvitinh(string giatri)
        {
            BindingSource binding_donvitinh = new BindingSource();
            binding_donvitinh.DataSource = new DONVITINH_BLL().donvitinh_danhsach().ToList();
            binding_donvitinh.Add(new DONVITINH { DVTID = 0, TenDVT = "Chưa xác định", DienGiai = "" });
            cbo_donvitinh.DataSource = binding_donvitinh;
            cbo_donvitinh.ValueMember = "DVTID";
            cbo_donvitinh.DisplayMember = "TenDVT";
            cbo_donvitinh.SelectedValue = int.Parse(giatri);
        }
        public void danhmuc_phutung(string giatri)
        {
            cbo_phutung.DataSource = new PHUTUNG_BLL().phutung_danhsach().Where(c => c.ThietBiID ==0 && LST_PHUTUNG.SingleOrDefault(p=>p.PhuTungID ==c.PhuTungID)==null).OrderBy(c => c.TenPhuTung).ToList();

            cbo_phutung.ValueMember = "PhuTungID";
            cbo_phutung.DisplayMembers = "TenPhuTung";
            cbo_phutung.SelectedValue = int.Parse(giatri);
        }
        
        //
        private enum dieukhien
        {
            chon = 1,
            loaibo = 2,
        }
        public void bangdieukhien(int tt)
        {
            switch (tt)
            {
                case (int)dieukhien.chon:
                    if (cbo_phutung.SelectedIndex >= 0)
                    {
                        if (ma == "")
                        {
                            LST_PHUTUNG.Add(new PHUTUNG_BLL().phutung_thongtin(cbo_phutung.SelectedValue.ToString()));
                        }
                        else
                        {
                            var PT = new PHUTUNG_BLL().phutung_thongtin(cbo_phutung.SelectedValue.ToString());
                            PT.ThietBiID = int.Parse(ma);
                            LST_PHUTUNG.Add(PT);
                        }
                            danhsachphutung_thietbi();
                    }

                    break;

                case (int)dieukhien.loaibo:
                    if (lv_phutung.SelectedItems.Count > 0)
                    {
                        if (ma == "")
                        {
                            if (LST_PHUTUNG.Remove(LST_PHUTUNG.Single(c => c.PhuTungID == int.Parse(lv_phutung.SelectedItems[0].Tag.ToString()))))
                            {
                                lv_phutung.Items.Remove(lv_phutung.SelectedItems[0]);
                            }
                        }
                        else //cập nhật
                        {
                            var LST = LST_PHUTUNG.Single(c => c.PhuTungID == int.Parse(lv_phutung.SelectedItems[0].Tag.ToString()));
                            LST.ThietBiID = 0;
                            lv_phutung.Items.Remove(lv_phutung.SelectedItems[0]);
                        }
                    }
                    break;
            }
            danhmuc_phutung("0");
            lbl_thongke_phutung.Text = "Số lượng: " + lv_phutung.Items.Count.ToString();
        }

        public void danhsachphutung_thietbi()
        {
                lv_phutung.Items.Clear();
                if (LST_PHUTUNG.Count > 0)
                {
                    ListViewItem item = null;
                    foreach (var PT in LST_PHUTUNG)
                    {
                        item = new ListViewItem((lv_phutung.Items.Count + 1).ToString());
                        item.Tag = PT.PhuTungID.ToString();
                        lv_phutung.Items.Add(item);
                        item.SubItems.Add(PT.TenPhuTung);
                        item.SubItems.Add(PT.SoHieu);
                        item.SubItems.Add((PT.NUOC != null ? PT.NUOC.TenNuoc : "Chưa xác định"));
                    }
                }
        } //danh sách phụ tùng kèm theo
        public void capnhat_thongtinphutung(string giatri)
        {
            var PT = LST_PHUTUNG.Single(c => c.PhuTungID == int.Parse(giatri));
            var PT_CN = new PHUTUNG_BLL().phutung_thongtin(giatri);
            PT.SoHieu = PT_CN.SoHieu;
            PT.MaPhuTung = PT_CN.MaPhuTung;
            PT.NUOC.TenNuoc = PT_CN.NUOC.TenNuoc;
            danhsachphutung_thietbi();
        }

        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }
        public void nhandulieu(string giatri)
        {
            if (giatri != null)
            {
                LST_PHUTUNG.Add(new PHUTUNG_BLL().phutung_thongtin(giatri));
                danhsachphutung_thietbi();
                danhmuc_phutung("0");
                lbl_thongke_phutung.Text = "Số lượng: " + lv_phutung.Items.Count.ToString();
            }
        }
        #endregion
        //
        #region "Sự kiện"
        
        //thêm các danh mục con
        private void btn_themdonvitinh_Click(object sender, EventArgs e)
        {
            DanhMuc.thongtinthietbi.frm_donvitinh_capnhat frm = new ThietBiPY.DanhMuc.thongtinthietbi.frm_donvitinh_capnhat();
            frm.DuLieu = new ThietBiPY.DanhMuc.thongtinthietbi.frm_donvitinh_capnhat.passData(danhmuc_donvitinh);
            frm.ShowDialog();
        }
        private void btn_themloaithietbi_Click(object sender, EventArgs e)
        {
            DanhMuc.thongtinthietbi.frm_loaithietbi_capnhat frm = new ThietBiPY.DanhMuc.thongtinthietbi.frm_loaithietbi_capnhat();
            frm.DuLieu = new ThietBiPY.DanhMuc.thongtinthietbi.frm_loaithietbi_capnhat.passData(danhmuc_loaithietbi);
            frm.ShowDialog();
        }
        private void btn_themnuocsanxuat_Click(object sender, EventArgs e)
        {
            DanhMuc.vitridiali.frm_nuoc_capnhat frm = new ThietBiPY.DanhMuc.vitridiali.frm_nuoc_capnhat();
            frm.DuLieu = new ThietBiPY.DanhMuc.vitridiali.frm_nuoc_capnhat.passData(danhmuc_nuocsanxuat);
            frm.ShowDialog();
        }
       
        //thanh phụ tùng
        private void btn_chonphutung_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)dieukhien.chon);
        }
        private void btn_danhsachphutung_Click(object sender, EventArgs e)
        {
            frm_phutung frm = new frm_phutung(LST_PHUTUNG);
            frm.DuLieu = new frm_phutung.passData(nhandulieu);
            frm.ShowDialog();
        }
        private void btn_themphutung_Click(object sender, EventArgs e)
        {
            frm_phutung_capnhat frm = new frm_phutung_capnhat();
            frm.DuLieu = new frm_phutung_capnhat.passData(danhmuc_phutung);
            frm.ShowDialog();
        }
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            danhsachphutung_thietbi();
        }

        //
        private void lv_phutung_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_phutung.SelectedItems.Count > 0)
            {
                lv_phutung.ContextMenuStrip = context_menu_phutung;
            }
            else lv_phutung.ContextMenuStrip = null;
        }
        private void lv_phutung_DoubleClick(object sender, EventArgs e)
        {
            context_dieukhien_phutung_chitiet_Click(null, null);
        }

        //
        private void pic_hinhanh_Click(object sender, EventArgs e)
        {
            context_menu_hinhanh.Show();
            context_menu_hinhanh.Top = Cursor.Position.Y;
            context_menu_hinhanh.Left = Cursor.Position.X;
            if (pic_hinhanh.Image != null)
            {
                context_menu_hinhanh_xoaanh.Enabled = true;
            }
            else context_menu_hinhanh_xoaanh.Enabled = false;
        }
        
        //thao tác chính
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            THIETBI_BLL THIETBI = new THIETBI_BLL();
            THIETBI.THIETBI_DTO.MaThietBi = txt_mathietbi.Text;
            THIETBI.THIETBI_DTO.SoHieu = txt_sohieu.Text;
            THIETBI.THIETBI_DTO.TenThietBi = txt_tenthietbi.Text;
            THIETBI.THIETBI_DTO.DVTID = (int)cbo_donvitinh.SelectedValue ;
            THIETBI.THIETBI_DTO.HanBaoHanh = (Int16)input_baohanh.Value;

            THIETBI.THIETBI_DTO.LoaiTBID = (int)cbo_loaithietbi.SelectedValue;
            THIETBI.THIETBI_DTO.NuocSX = (int)cbo_nuocsanxuat.SelectedValue;
            THIETBI.THIETBI_DTO.NamSX = input_namsx.Value;

            if (pic_hinhanh.Image != null) THIETBI.THIETBI_DTO.HinhAnh = new LopHoTro.CHUYENKIEU().ImageToBinary(pic_hinhanh.Image);
           
            THIETBI.THIETBI_DTO.ThongSoKT = txt_thongsokt.Text;
            THIETBI.THIETBI_DTO.MoTaThem = txt_motathem.Text;

            THIETBI.THIETBI_DTO.TaiLieuKT = (txt_tailieu.Text != "" ? txt_mathietbi.Text + System.IO.Path.GetExtension(txt_tailieu.Text.Trim()) : txt_tailieu.Text);

            if (txt_tailieu.Tag == null)
            {
                THIETBI.THIETBI_DTO.NDTaiLieuKT = null; 
            }
            else THIETBI.THIETBI_DTO.NDTaiLieuKT = (byte[])txt_tailieu.Tag;

            if (ma == "")
            {
                List<string> LST = new List<string>();

                foreach (var PT in LST_PHUTUNG) LST.Add(PT.PhuTungID.ToString());
                if (THIETBI.thietbi_them(LST) > 0)
                {
                    guidulieu(THIETBI.THIETBI_DTO.ThietBiID.ToString());
                    this.Close();
                }
            }
            else
            {
                if (THIETBI.thietbi_sua(ma, LST_PHUTUNG) > 0)
                {
                    guidulieu(THIETBI.THIETBI_DTO.ThietBiID.ToString());
                    this.Close();
                }
            }
        }
        
        //
        private void btn_themtailieu_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Title = "Chọn tài liệu kỹ thuật ..";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                txt_tailieu.Tag = new LopHoTro.CHUYENKIEU().FileToBinary(diag.FileName);
                txt_tailieu.Text = System.IO.Path.GetFileName(diag.FileName);
            }
        }
        private void btn_xoatailieu_Click(object sender, EventArgs e)
        {
            txt_tailieu.Text = "";
            txt_tailieu.Tag = null;
        }

        //thanh context menu
        private void context_dieukhien_phutung_loaibo_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)dieukhien.loaibo);
        }
        private void context_dieukhien_phutung_chitiet_Click(object sender, EventArgs e)
        {
            if (lv_phutung.SelectedItems.Count > 0)
            {
                frm_phutung_capnhat frm = new frm_phutung_capnhat(lv_phutung.SelectedItems[0].Tag.ToString());
                frm.DuLieu = new frm_phutung_capnhat.passData(capnhat_thongtinphutung);
                frm.ShowDialog();
            }
        }
        private void context_menu_hinhanh_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Title = "Chọn ảnh..";
            diag.Filter = "File ảnh (*.jpg)|*.jpg|Tất cả|*.*";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                pic_hinhanh.ImageLocation = diag.FileName;
            }
        }
        private void context_menu_hinhanh_xoaanh_Click(object sender, EventArgs e)
        {
            pic_hinhanh.Image = null;
        }

        // Sự kiện của form
        private void frm_thietbi_capnhat_Load(object sender, EventArgs e)
        {
            txt_tenthietbi.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tenthietbi).OnKeyPress);
            txt_thongsokt.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_thongsokt).OnKeyPress);
            txt_motathem.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_motathem).OnKeyPress);
            txt_motathem.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_motathem).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        private void frm_thietbi_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_chonphutung_Click(null, null); break;
                case Keys.Escape: btn_huybo_Click(null, null); break;
            }
        }
        #endregion


    }
}
//Bùi Thành Nhân - 08/06/2011