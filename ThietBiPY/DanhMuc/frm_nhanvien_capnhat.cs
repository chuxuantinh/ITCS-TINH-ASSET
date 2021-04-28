using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ThietBiBLL;
using ThietBiDAL;

using ThietBiPY.DanhMuc.thongtindonvi;
using ThietBiPY.DanhMuc.thongtinnhanvien;
using ThietBiPY.DanhMuc.vitridiali;

using Net.SourceForge.Vietpad.InputMethod;
using DevComponents.DotNetBar.Validator;

namespace ThietBiPY.DanhMuc
{
    public partial class frm_nhanvien_capnhat :DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";
        public frm_nhanvien_capnhat()
        {
            InitializeComponent();
            this.Text = "Thêm nhân viên";

            //
            txt_manv.Text = new NHANVIEN_BLL().nhanvien_taoma();

            danhmuc_tinh("0");
            danhmuc_donvi("0");
            danhmuc_chucvu("0");
            danhmuc_gioitinh("0");
        }
        public frm_nhanvien_capnhat(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            var NV = new NHANVIEN_BLL().nhanvien_thongtin(ma);
            this.Text = "Hiệu chỉnh nhân viên: Mã NV = " + NV.MaNV;
            
          
            txt_manv.Text = NV.MaNV;
            txt_honv.Text = NV.HoNV;
            txt_tennv.Text = NV.TenNV;

            if (NV.ChanDung != null) pic_chandung.Image = new LopHoTro.CHUYENKIEU().BinaryToImage(NV.ChanDung);
            if (NV.NgaySinh != null) dtp_ngaysinh.Value = NV.NgaySinh.Value.Date;

            if(NV.CMND!=null)input_cmnd.Value = int.Parse(NV.CMND);
            if(NV.NgayCap!=null) dtp_ngaycap.Value = NV.NgayCap.Value.Date;
            txt_noicap.Text = NV.NoiCap;

            txt_diachi.Text = NV.DiaChi;
            txt_dienthoai.Text = NV.DienThoai;
            txt_email.Text = NV.Email;
            //
            danhmuc_tinh (NV.TinhID.ToString ());
            danhmuc_donvi(NV.DonViID .ToString ());
            danhmuc_chucvu(NV.ChucVuID.ToString());
            danhmuc_gioitinh((NV.GioiTinh==true ?"1":"0"));
        }

        public frm_nhanvien_capnhat(int DonViID)
        {
            InitializeComponent();
            this.Text = "Thêm nhân viên";

            //
            txt_manv.Text = new NHANVIEN_BLL().nhanvien_taoma();

            danhmuc_tinh("0");
            danhmuc_donvi(DonViID.ToString());
            danhmuc_chucvu("0");
            danhmuc_gioitinh("0");
        }

        #region "Load danh mục"
        public void danhmuc_tinh(string giatri)
        {
            BindingSource binding_tinh = new BindingSource();
            binding_tinh.DataSource = new TINH_BLL().tinh_danhsach().Select(c => new
            {
                TinhID = c.TinhID,
                TenTinh = c.TenTinh,
                TenNuoc = c.NUOC.TenNuoc,
            });
            binding_tinh.Add(new { TinhID=0,TenTinh="Chưa xác định",TenNuoc="Nước khác.." });
            cbo_tinh_tp.DataSource = binding_tinh;
            
            cbo_tinh_tp.GroupingMembers = "TenNuoc";
            cbo_tinh_tp.DisplayMembers = "TenTinh";
            cbo_tinh_tp.ValueMember = "TinhID";
            cbo_tinh_tp.SelectedValue = int.Parse(giatri);
        }
        public void danhmuc_donvi(string giatri)
        {
            if (giatri != null || giatri != "")
            {
                BindingSource binding_donvi = new BindingSource();
                binding_donvi.DataSource = new DONVI_BLL().donvi_danhsach().ToList();
                binding_donvi.Add(new DONVI { DonViID = 0, TenDonVi = "Chưa xác định", DienThoai = "", DienGiai = "" });

                cbo_donvi.DataSource = binding_donvi;
                cbo_donvi.ValueMember = "DonViID";
                cbo_donvi.DisplayMember = "TenDonVi";

                cbo_donvi.SelectedValue = int.Parse (giatri);
            }
        }
        public void danhmuc_chucvu(string giatri)
        {
            if (giatri != null || giatri != "")
            {
                BindingSource binding_chucvu = new BindingSource();
                binding_chucvu.DataSource = new CHUCVU_BLL().chucvu_danhsach().ToList();
                binding_chucvu.Add(new CHUCVU { ChucVuID = 0, TenChucVu = "Chưa xác định", CapBac = 0, DienGiai = "" });
                cbo_chucvu.DataSource = binding_chucvu;

                cbo_chucvu.ValueMember = "ChucVuID";
                cbo_chucvu.DisplayMember = "TenChucVu";

                cbo_chucvu.SelectedValue = int.Parse(giatri);
            }
        }
        public void danhmuc_gioitinh(string giatri)
        {
            if (giatri != null || giatri != "")
            {
                cbo_gioitinh.DataSource = new LopHoTro.DOITUONG[]{
                new LopHoTro.DOITUONG("Nam",1),
                new LopHoTro.DOITUONG ("Nữ",0),
            };
                cbo_gioitinh.DisplayMember = "name";
                cbo_gioitinh.ValueMember = "value";
                cbo_gioitinh.SelectedValue = (int.Parse(giatri));
            }
        }
        #endregion

        #region "Chân dung"
        private void context_menu_btn_chonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "File JPG|*.jpg| Tất cả|*.*";
            diag.Title = "Chân dung";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                pic_chandung.Image = Image.FromFile(diag.FileName);
            }
        }
        private void context_menu_btn_xoaanh_Click(object sender, EventArgs e)
        {
            pic_chandung.Image = null;
        }
        #endregion

        #region "Sự kiện"
        private void btn_themtinh_Click(object sender, EventArgs e)
        {
            frm_tinh_capnhat frm = new frm_tinh_capnhat();
            frm.DuLieu = new frm_tinh_capnhat.passData(danhmuc_tinh);
            frm.ShowDialog();
        }
        private void btn_themdonvi_Click(object sender, EventArgs e)
        {
            frm_donvi_capnhat frm = new frm_donvi_capnhat();
            frm.DuLieu = new frm_donvi_capnhat.passData(danhmuc_donvi);
            frm.ShowDialog();
        }
        private void btn_themchucvu_Click(object sender, EventArgs e)
        {
            frm_chucvu_capnhat frm = new frm_chucvu_capnhat();
            frm.DuLieu = new frm_chucvu_capnhat.passData(danhmuc_chucvu);
            frm.ShowDialog();
        }
        //
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (txt_manv.Text == "")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa nhập mã nhân viên", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_manv.Focus();
            }
            else if (txt_honv.Text == "")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa nhập họ và tên đệm", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_honv.Focus();
            }
            else if (txt_tennv.Text == "")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa nhập tên nhân viên", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_tennv.Focus();
            }
            else xuly();
        }
        private void pic_chandung_Click(object sender, EventArgs e)
        {
            context_menu_chandung.Show();
            context_menu_chandung.Top = Cursor.Position.Y;
            context_menu_chandung.Left = Cursor.Position.X;
            if (pic_chandung.Image != null)
            {
                context_menu_btn_xoaanh.Enabled = true;
            }
            else context_menu_btn_xoaanh.Enabled = false;
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        private void frm_nhanvien_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: btn_huybo_Click(null, null); break;
            }
        }
        private void frm_nhanvien_capnhat_Load(object sender, EventArgs e)
        {
            txt_honv.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_honv).OnKeyPress);
            txt_tennv.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tennv).OnKeyPress);
            txt_noicap.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_noicap).OnKeyPress);
            txt_diachi.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_diachi).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }

        #endregion

        #region "Xử lý"
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu !=null) DuLieu(giatri);
        }
        public void xuly()
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            NHANVIEN_BLL NHANVIEN = new NHANVIEN_BLL();
            NHANVIEN.NHANVIEN_DTO.MaNV = txt_manv.Text;
            NHANVIEN.NHANVIEN_DTO.HoNV = txt_honv.Text;
            NHANVIEN.NHANVIEN_DTO.TenNV = txt_tennv.Text;
            NHANVIEN.NHANVIEN_DTO.GioiTinh = ((int)cbo_gioitinh.SelectedValue == 1 ? true : false);
            if(cbo_tinh_tp.SelectedIndex>=0)NHANVIEN.NHANVIEN_DTO.TinhID = (int)cbo_tinh_tp.SelectedValue;

         if (dtp_ngaysinh.Value.Date != new DateTime(01, 01, 0001)) NHANVIEN.NHANVIEN_DTO.NgaySinh = dtp_ngaysinh.Value.Date;
         if(input_cmnd.Value>0)NHANVIEN.NHANVIEN_DTO.CMND = input_cmnd.Value.ToString();
         if (dtp_ngaycap.Value.Date != new DateTime(01, 01, 0001)) NHANVIEN.NHANVIEN_DTO.NgayCap = dtp_ngaycap.Value.Date;
         NHANVIEN.NHANVIEN_DTO.NoiCap = txt_noicap.Text;
         NHANVIEN.NHANVIEN_DTO.DiaChi = txt_diachi.Text;

         if(cbo_donvi.SelectedIndex >=0)NHANVIEN.NHANVIEN_DTO.DonViID = (int)cbo_donvi.SelectedValue;
         if(cbo_chucvu.SelectedIndex>=0)NHANVIEN.NHANVIEN_DTO.ChucVuID = (int)cbo_chucvu.SelectedValue;
         NHANVIEN.NHANVIEN_DTO.DienThoai = txt_dienthoai.Text;
         NHANVIEN.NHANVIEN_DTO.Email = txt_email.Text;

         if(pic_chandung.Image!=null)NHANVIEN.NHANVIEN_DTO.ChanDung = new LopHoTro.CHUYENKIEU().ImageToBinary(pic_chandung.Image);

         if (ma == "")
         {
             if (NHANVIEN.nhanvien_them() > 0)
             {
                 guidulieu(NHANVIEN.NHANVIEN_DTO.NhanVienID.ToString());
                 this.Close();
             }
         }
         else
         {
             if (DevComponents.DotNetBar.MessageBoxEx.Show("Lưu hay không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 if (NHANVIEN.nhanvien_sua(ma) > 0)
                 {
                     guidulieu(NHANVIEN.NHANVIEN_DTO.NhanVienID.ToString());
                     this.Close();
                 }
             }
         }
        }
        #endregion

        private void txt_manv_Validated(object sender, EventArgs e)
        {
            if (txt_manv.Text.Length > 0)
            {

                if (ma == "")
                {
                    if (new NHANVIEN_BLL().nhanvien_kiemtrama(txt_manv.Text) == true)
                    {
                        errorProvider1.SetError(txt_manv, "Mã nhân viên đã tồn tại");
                       highlighter1.SetHighlightColor (txt_manv,DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                       txt_manv.Focus();
                    }
                  else {errorProvider1.Clear();highlighter1.SetHighlightColor(txt_manv, DevComponents.DotNetBar.Validator.eHighlightColor.Blue);}
                }
                else
                {
                    if (!txt_manv.Text.Equals(new NHANVIEN_BLL().nhanvien_thongtin(ma).TenNV))
                    {
                        if (new NHANVIEN_BLL().nhanvien_kiemtrama(txt_manv.Text) == true)
                        {

                            errorProvider1.SetError(txt_manv, "Mã nhân viên đã tồn tại");
                            highlighter1.SetHighlightColor(txt_manv, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                            txt_manv.Focus();
                        }
                    }
                    else { errorProvider1.Clear(); highlighter1.SetHighlightColor(txt_manv, DevComponents.DotNetBar.Validator.eHighlightColor.Blue); }
                }
            }
        }
    }
}
