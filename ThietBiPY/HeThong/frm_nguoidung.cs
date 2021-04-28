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
using DevComponents.DotNetBar.Validator;
using ThietBiPY.DanhMuc;

namespace ThietBiPY.HeThong
{
    public partial class frm_nguoidung : DevComponents.DotNetBar.Office2007Form
    {
        string yeucau = "";
        string TaiKhoan = "";

        public frm_nguoidung()
        {
            InitializeComponent();
        }
        public frm_nguoidung(string yeucau)
        {
            InitializeComponent();
            this.yeucau = yeucau;

            switch (yeucau)
            {
                case "dangki":
                    this.Text = "Đăng kí";
                    this.ShowIcon = false;
                    this.ShowInTaskbar = false;
                    this.AcceptButton = btn_dangki;

                    this.superTabControl1.Tabs.Remove(superTabItem_dangnhap);
                    this.superTabControl1.Tabs.Remove(superTabItem_doimatkhau);
                    this.txt_dki_manhanvien.Focus();
                    break;

                case "dangnhap":
                    this.TopMost = true;
                    this.Text = "Đăng nhập";

                    this.superTabControl1.Tabs.Remove(superTabItem_dangki);
                    this.superTabControl1.Tabs.Remove(superTabItem_doimatkhau);
                    this.txt_dn_taikhoan.Focus();
                    break;

                case "doimatkhau":
                    this.ShowIcon = false;
                    this.ShowInTaskbar = false;
                    this.AcceptButton = btn_doimatkhau;

                    this.TaiKhoan = new HETHONGBLL().TenTaiKhoan();
                    this.Text = "Đổi mật khẩu : " + TaiKhoan;
                    this.superTabControl1.Tabs.Remove(superTabItem_dangnhap);
                    this.superTabControl1.Tabs.Remove(superTabItem_dangki);
                    break;
            }
        }

        #region "Sự kiện"

        //Đăng kí
        private void txt_dki_manhanvien_Validated(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            if (txt_dki_manhanvien.Text != "")
            {
                var NV = new NHANVIEN_BLL().nhanvien_danhsach().SingleOrDefault(c => c.MaNV == txt_dki_manhanvien.Text);
                if (NV == null)
                {
                    highlighter1.SetHighlightColor(txt_dki_manhanvien, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    errorProvider1.SetError(txt_dki_manhanvien, "Không có nhân viên này!xin kiểm tra lại mã nhân viên");
                    txt_dki_manhanvien.Focus();
                }

                else if (new NGUOIDUNG_BLL().nguoidung_kiemtranhanvien(NV.NhanVienID.ToString()) != null)
                {
                    highlighter1.SetHighlightColor(txt_dki_manhanvien, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    errorProvider1.SetError(txt_dki_manhanvien, "nhân viên này đã đăng kí tài khoản rồi!");
                    txt_dki_manhanvien.Focus();
                }
                else
                {
                    highlighter1.SetHighlightColor(txt_dki_manhanvien, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                    txt_dki_taikhoan.Text = txt_dki_manhanvien.Text.Trim();
                    txt_dki_taikhoan.Enabled = false;
                    errorProvider1.SetError(txt_dki_manhanvien, "Họ tên: " + NV.HoNV + " " + NV.TenNV + " -Chức vụ: " + (NV.ChucVuID != 0 ? NV.CHUCVU.TenChucVu : "Chưa xác định"));

                    txt_dki_matkhau.Text = "123456";
                    txt_dki_xacnhanlaimk.Text = "123456";
                }
            }
        }
        private void txt_dki_taikhoan_Validated(object sender, EventArgs e)
        {
            if (txt_dki_taikhoan.Text != "")
            {
                DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
                int kt = new NGUOIDUNG_BLL().nguoidung_kiemtrataikhoan(txt_dki_taikhoan.Text);
                if (kt == 1)
                {
                    highlighter1.SetHighlightColor(txt_dki_taikhoan, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    errorProvider1.SetError(txt_dki_taikhoan, "tài khoản này đã được dùng!");
                    txt_dki_taikhoan.Focus();
                }
                else if (kt == 2)
                {
                    highlighter1.SetHighlightColor(txt_dki_taikhoan, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                    errorProvider1.Clear();
                }
            }
        }
        private void txt_dki_xacnhanlaimk_Validated(object sender, EventArgs e)
        {
            if (txt_dki_matkhau.Text != "")
            {
                DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
                if (!txt_dki_matkhau.Text.ToUpper().Equals(txt_dki_xacnhanlaimk.Text.ToUpper()))
                {
                    highlighter1.SetHighlightColor(txt_dki_xacnhanlaimk, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    errorProvider1.SetError(txt_dki_xacnhanlaimk, "xác nhận lại mật khẩu không khớp!");
                    txt_dki_xacnhanlaimk.Focus();
                }
                else
                {
                    highlighter1.SetHighlightColor(txt_dki_xacnhanlaimk, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                    errorProvider1.Clear();
                }
            }
        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            if (txt_dki_manhanvien.Text == "")
            {
                errorProvider1.SetError(txt_dki_manhanvien, "chưa nhập mã nhân viên!");
                txt_dki_manhanvien.Focus();
            }
            else if (txt_dki_taikhoan.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_dki_taikhoan, "chưa nhập tài khoản!");
                txt_dki_taikhoan.Focus();
            }
            else if (txt_dki_matkhau.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_dki_matkhau, "chưa nhập mật khẩu!");
                txt_dki_matkhau.Focus();
            }
            else if (txt_dki_xacnhanlaimk.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txt_dki_xacnhanlaimk, "chưa xác nhận lại mật khẩu!");
                txt_dki_xacnhanlaimk.Focus();
            }
            else
            {
                errorProvider1.Clear();

                bangdieukhien();
                //
            }
        }

        //
        private void chonnhanvien_dangki(string giatri)
        {
            if (giatri != "")
            {
                var NV = new NHANVIEN_BLL().nhanvien_thongtin(giatri);
                txt_dki_manhanvien.Text = NV.MaNV;
            }
        }
        private void btn_dangki_chonhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien_dschon frm = new frm_nhanvien_dschon();
            frm.DuLieu = new frm_nhanvien_dschon.passData(chonnhanvien_dangki);
            frm.ShowDialog();

        }


        //Đăng nhập
        private void txt_dn_taikhoan_Validated(object sender, EventArgs e)
        {
            if (txt_dn_taikhoan.Text != "")
            {
                if (new NGUOIDUNG_BLL().nguoidung_kiemtrataikhoan(txt_dn_taikhoan.Text) == 2)
                {
                    highlighter1.SetHighlightColor(txt_dn_taikhoan, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    errorProvider1.SetError(txt_dn_taikhoan, "Tài khoản này không tồn tại!");
                    txt_dn_taikhoan.Focus();
                    solan += 1;
                }
                else
                {
                    highlighter1.SetHighlightColor(txt_dn_taikhoan, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                    errorProvider1.Clear();
                }
            }
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (solan != 0)
            {
                if (txt_dn_taikhoan.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txt_dn_taikhoan, "chưa nhập tài khoản!");
                    txt_dn_taikhoan.Focus();
                }
                else if (txt_dn_matkhau.Text == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txt_dn_matkhau, "chưa nhập mật khẩu!");
                    txt_dn_matkhau.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    bangdieukhien();
                }
            }
            else Application.ExitThread();
        }

        //Đổi mật khẩu
        private void txt_dmk_matkhaucu_Validated(object sender, EventArgs e)
        {
            if (txt_dmk_matkhaucu.Text != "")
            {
                int kt_mk = new NGUOIDUNG_BLL().nguoidung_dangnhap(TaiKhoan, txt_dmk_matkhaucu.Text);
                if (kt_mk == 3)
                {
                    highlighter1.SetHighlightColor(txt_dmk_matkhaucu, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    errorProvider1.SetError(txt_dmk_matkhaucu, "Sai mật khẩu!");
                    txt_dmk_matkhaucu.Focus();
                }
                else
                {
                    highlighter1.SetHighlightColor(txt_dmk_matkhaucu, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                    errorProvider1.Clear();
                }
            }
        }
        private void txt_dmk_xacnhanmkmoi_Validated(object sender, EventArgs e)
        {
            if (txt_dmk_matkhaumoi.Text != "")
            {
                if (!txt_dmk_matkhaumoi.Text.ToUpper().Equals(txt_dmk_xacnhanmkmoi.Text.ToUpper()))
                {
                    highlighter1.SetHighlightColor(txt_dmk_xacnhanmkmoi, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                    errorProvider1.SetError(txt_dmk_xacnhanmkmoi, "Xác nhận lại mật khẩu mới không chính xác!");
                    txt_dmk_xacnhanmkmoi.Focus();
                }
                else
                {
                    highlighter1.SetHighlightColor(txt_dmk_xacnhanmkmoi, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                    errorProvider1.Clear();
                }
            }
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            if (txt_dmk_matkhaucu.Text == "")
            {
                highlighter1.SetHighlightColor(txt_dmk_matkhaucu, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                errorProvider1.SetError(txt_dmk_matkhaucu, "Chưa nhập mật khẩu cũ!");
                txt_dmk_matkhaucu.Focus();
            }
            else if (txt_dmk_matkhaumoi.Text == "")
            {
                highlighter1.SetHighlightColor(txt_dmk_matkhaumoi, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                errorProvider1.SetError(txt_dmk_matkhaumoi, "Chưa nhập mật khẩu mới!");
                txt_dmk_matkhaumoi.Focus();
            }
            else if (txt_dmk_xacnhanmkmoi.Text == "")
            {
                highlighter1.SetHighlightColor(txt_dmk_xacnhanmkmoi, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                errorProvider1.SetError(txt_dmk_xacnhanmkmoi, "Chưa nhập xác nhận mật khẩu mới!");
                txt_dmk_xacnhanmkmoi.Focus();
            }
            else
            {
                highlighter1.SetHighlightColor(txt_dmk_xacnhanmkmoi, DevComponents.DotNetBar.Validator.eHighlightColor.None);
                errorProvider1.Clear();
                bangdieukhien();
            }
        }
        #endregion

        #region "Hàm xử lý"
        //-- 
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        //--
        private string LayNhanVienID(string MaNV)
        {
            string kq = "";
            var NV = new NHANVIEN_BLL().nhanvien_danhsach().SingleOrDefault(c => c.MaNV.Equals(MaNV.ToUpper()));
            if (NV != null) kq = NV.NhanVienID.ToString();
            return kq;
        }

        static int solan = 3;
        public void bangdieukhien()
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            NGUOIDUNG_BLL NGUOIDUNG = new NGUOIDUNG_BLL();
            switch (yeucau)
            {
                case "dangki":
                    NGUOIDUNG.NGUOIDUNG_DTO.NhanVienID = Int64.Parse(LayNhanVienID(txt_dki_manhanvien.Text));
                    NGUOIDUNG.NGUOIDUNG_DTO.TaiKhoan = txt_dki_taikhoan.Text;
                    NGUOIDUNG.NGUOIDUNG_DTO.MatKhau = txt_dki_matkhau.Text;

                    if (NGUOIDUNG.nguoidung_them() > 0)
                    {
                        guidulieu(NGUOIDUNG.NGUOIDUNG_DTO.NguoiDungID.ToString());
                        DevComponents.DotNetBar.MessageBoxEx.Show("Đã đăng kí!", "Thông báo", MessageBoxButtons.OK);
                        this.Close();
                        //superTabControl1.SelectedTab = superTabItem_dangnhap;
                    }
                    break;

                case "dangnhap":

                    int kq_dangnhap = NGUOIDUNG.nguoidung_dangnhap(txt_dn_taikhoan.Text, txt_dn_matkhau.Text);
                    if (kq_dangnhap == 1)
                    {
                        highlighter1.SetHighlightColor(txt_dn_taikhoan, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                        errorProvider1.SetError(txt_dn_taikhoan, "tài khoản này không tồn tại!");
                        txt_dn_taikhoan.Focus();
                        solan -= 1;
                        lbl_solannhapsai.Text = "X" + solan;
                    }
                    else if (kq_dangnhap == 2)
                    {
                        highlighter1.SetHighlightColor(txt_dn_taikhoan, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                        errorProvider1.SetError(txt_dn_taikhoan, "chưa được cấp quyền truy cập hệ thống!");
                        txt_dn_taikhoan.Focus();
                        solan -= 1;
                        lbl_solannhapsai.Text = "X" + solan;
                    }
                    else if (kq_dangnhap == 3)
                    {
                        highlighter1.SetHighlightColor(txt_dn_matkhau, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                        errorProvider1.SetError(txt_dn_matkhau, "Sai mật khẩu!");
                        txt_dn_matkhau.Focus();
                        solan -= 1;
                        lbl_solannhapsai.Text = "X" + solan;
                    }
                    else
                    {
                        var ND = new NGUOIDUNG_BLL().nguoidung_thongtin_TK(txt_dn_taikhoan.Text);
                        solan = 3;
                        if (ND.Quyen == 1)
                        {
                            frm_main_quantri frm = new frm_main_quantri();
                            frm.Shown += new EventHandler(Dong_FormDangNhap);
                            frm.AddOwnedForm(this);
                            frm.Show();
                        }
                        else
                        {
                            frm_main_khac frm = new frm_main_khac();
                            frm.Shown += new EventHandler(Dong_FormDangNhap);
                            frm.AddOwnedForm(this);
                            frm.Show();
                        }
                    }
                    break;

                case "doimatkhau":
                    NGUOIDUNG.NGUOIDUNG_DTO.MatKhau = txt_dmk_matkhaumoi.Text;
                    if (NGUOIDUNG.nguoidung_doimatkhau(new NGUOIDUNG_BLL().nguoidung_danhsach().Single(c => c.TaiKhoan == TaiKhoan).NguoiDungID.ToString()) > 0)
                    {
                        this.Close();
                    }
                    break;
            }
        }

        private void Dong_FormDangNhap(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
