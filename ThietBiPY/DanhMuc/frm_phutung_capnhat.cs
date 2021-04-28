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
    public partial class frm_phutung_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";
        public frm_phutung_capnhat()
        {
            InitializeComponent();
            this.Text = "Thêm phụ tùng";

            txt_maphutung.Text = new PHUTUNG_BLL().phutung_taoma();
            txt_sohieu.Text = txt_maphutung.Text + DateTime.Now.Date.ToString("ddMMyyyy");

            danhmuc_nuocsanxuat("0");
            danhmuc_loaithietbi("0");
            danhmuc_donvitinh("0");
        }
        public frm_phutung_capnhat(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            var PT = new PHUTUNG_BLL().phutung_thongtin(ma);
            if (PT != null)
            {
                txt_maphutung.Text = PT.MaPhuTung;
                txt_sohieu.Text = PT.SoHieu;
                txt_tenphutung.Text = PT.TenPhuTung;
                
                danhmuc_nuocsanxuat(PT.NuocSX.ToString());
                input_namsx.Value =(int) PT.NamSX;
                 input_namsx.Value = (int)PT.HanBaoHanh;

                danhmuc_loaithietbi(PT.LoaiTBID.ToString());
                danhmuc_donvitinh(PT.DVTID.ToString());
                txt_thongsokt.Text = PT.ThongSoKT;
                txt_motathem.Text = PT.MoTaThem;
            }
        }

        #region "Xử lý"
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
                TenNhomTB = (c.NHOMTHIETBI !=null? c.NHOMTHIETBI.TenNhomTB:"Chưa xác định"),
            });
            binding_loaithietbi.Add(new { LoaiTBID = 0, TenLoaiTB = "Chưa xác định", TenNhomTB = "Chưa xác định" });
            cbo_loaithietbi.DataSource = binding_loaithietbi;
            cbo_loaithietbi.GroupingMembers = "TenNhomTB";
            cbo_loaithietbi.ValueMember = "LoaiTBID";
            cbo_loaithietbi.DisplayMembers = "TenLoaiTB";

            cbo_loaithietbi.SelectedValue = int.Parse(giatri);
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
        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }
        //
        public void xuly()
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            PHUTUNG_BLL PHUTUNG = new PHUTUNG_BLL();
            PHUTUNG.PHUTUNG_DTO.MaPhuTung = txt_maphutung.Text;
            PHUTUNG.PHUTUNG_DTO.SoHieu = txt_sohieu.Text;
            PHUTUNG.PHUTUNG_DTO.TenPhuTung = txt_tenphutung.Text;

            PHUTUNG.PHUTUNG_DTO.NuocSX = (int)cbo_nuocsanxuat.SelectedValue;
            if (input_namsx.Value > 0) PHUTUNG.PHUTUNG_DTO.NamSX = input_namsx.Value;
            PHUTUNG.PHUTUNG_DTO.ThongSoKT = txt_thongsokt.Text;
            PHUTUNG.PHUTUNG_DTO.MoTaThem = txt_motathem.Text;
            if (pic_hinhanh.Image != null) PHUTUNG.PHUTUNG_DTO.HinhAnh = new LopHoTro.CHUYENKIEU().ImageToBinary(pic_hinhanh.Image);

            if (ma == "")
            {
                if (PHUTUNG.phutung_them() > 0)
                {
                    guidulieu(PHUTUNG.PHUTUNG_DTO.PhuTungID.ToString());
                    this.Close();
                }
            }
            else
            {
                if (DevComponents.DotNetBar.MessageBoxEx.Show("Cập nhật lại dữ liệu ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    if (PHUTUNG.phutung_sua(ma) > 0)
                    {
                        guidulieu(PHUTUNG.PHUTUNG_DTO.PhuTungID.ToString());
                        this.Close();
                    }
                }
            }
        }
        //
        #endregion

        #region "Sự kiện"
        //
        private void btn_themnuocsx_Click(object sender, EventArgs e)
        {
            DanhMuc.vitridiali.frm_nuoc_capnhat frm = new ThietBiPY.DanhMuc.vitridiali.frm_nuoc_capnhat();
            frm.DuLieu = new ThietBiPY.DanhMuc.vitridiali.frm_nuoc_capnhat.passData(danhmuc_nuocsanxuat);
            frm.ShowDialog();
        }
        private void btn_themloaithietbi_Click(object sender, EventArgs e)
        {
            DanhMuc.thongtinthietbi.frm_loaithietbi_capnhat frm = new ThietBiPY.DanhMuc.thongtinthietbi.frm_loaithietbi_capnhat();
            frm.DuLieu = new ThietBiPY.DanhMuc.thongtinthietbi.frm_loaithietbi_capnhat.passData(danhmuc_loaithietbi);
            frm.ShowDialog();
        }
        private void btn_themdonvitinh_Click(object sender, EventArgs e)
        {
            DanhMuc.thongtinthietbi.frm_donvitinh_capnhat frm = new ThietBiPY.DanhMuc.thongtinthietbi.frm_donvitinh_capnhat();
            frm.DuLieu = new ThietBiPY.DanhMuc.thongtinthietbi.frm_donvitinh_capnhat.passData(danhmuc_donvitinh);
            frm.ShowDialog();
        }

        private void btn_luulai_Click(object sender, EventArgs e)
        {
            xuly();
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void context_menu_hinhanh_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Title = "Chọn phụ tùng";
            diag.Filter = " File ảnh .JPG|*.jpg|Tất cả .*|*.*";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                pic_hinhanh.ImageLocation = diag.FileName;
            }
        }
        private void context_menu_hinhanh_xoaanh_Click(object sender, EventArgs e)
        {
            pic_hinhanh.Image = null;
        }
        //
        private void pic_hinhanh_Click(object sender, EventArgs e)
        {
            context_menu_hinhanh.Show();
            context_menu_hinhanh.Top = Cursor.Position.Y;
            context_menu_hinhanh.Left = Cursor.Position.X;

            context_menu_hinhanh_xoaanh.Enabled = (pic_hinhanh.Image != null ? true : false);
        }
        //
        private void frm_phutung_capnhat_Load(object sender, EventArgs e)
        {
            txt_tenphutung.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tenphutung).OnKeyPress);
            txt_thongsokt.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_thongsokt).OnKeyPress);
            txt_motathem.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_motathem).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        private void txt_maphutung_Validated(object sender, EventArgs e)
        {
            if (txt_maphutung.Text != "")
            {
                DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

                if (ma == "")
                {
                    if (new PHUTUNG_BLL().phutung_kiemtrama(txt_maphutung.Text) == true)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Mã phụ tùng này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_maphutung.Focus();
                    }
                }
                //
                else
                {
                    if (!txt_maphutung.Text.Equals(new PHUTUNG_BLL().phutung_thongtin(ma).MaPhuTung))
                    {
                        if (new PHUTUNG_BLL().phutung_kiemtrama(txt_maphutung.Text) == true)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Mã phụ tùng này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txt_maphutung.Focus();
                        }
                    }
                }
            }
        }
        private void frm_phutung_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: btn_huybo_Click(null, null); break;
                case Keys.F8: btn_luulai_Click(null, null); break;
            }
        }
        #endregion

    }
}
