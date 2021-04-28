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
    public partial class frm_nhacungcap_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";
        public frm_nhacungcap_capnhat()
        {
            InitializeComponent();
            this.Text = "Thêm nhà cung cấp";
            danhmuc_tinh("0");
        }
        public frm_nhacungcap_capnhat(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            var NCC = new NHACUNGCAP_BLL().nhacungcap_thongtin(ma);
            this.Text = "Hiệu chỉnh nhà cung cấp: ID="+NCC.NCCID .ToString ();
            txt_tenncc.Text = NCC.TenNCC;
            txt_honglh.Text = NCC.HoNguoiLH;
            txt_tennglh.Text = NCC.TenNguoiLH;
            txt_chucvu.Text = NCC.ChucVu;

            danhmuc_tinh(NCC.TinhID.ToString());
            txt_diachi.Text = NCC.DiaChi;
            txt_dienthoai.Text = NCC.DienThoai;
            txt_fax.Text = NCC.FAX;
            txt_email.Text = NCC.Email;
            txt_website.Text = NCC.Website;
            txt_ghichu.Text = NCC.GhiChu;
        }

        #region "Hàm xử lý"
        //
        public void danhmuc_tinh(string giatri)
        {
            BindingSource binding_tinh = new BindingSource();
            binding_tinh.DataSource = new TINH_BLL().tinh_danhsach().Select(c => new
            {
                TinhID = c.TinhID ,
                TenTinh=c.TenTinh,
                TenNuoc = c.NUOC.TenNuoc,
            });
           binding_tinh.Add(new {TinhID=0,TenTinh="Chưa xác định",TenNuoc="Nước khác.." });
            cbo_tinh.DataSource = binding_tinh;
            cbo_tinh.ValueMember = "TinhID";
            cbo_tinh.DisplayMembers = "TenTinh";
            cbo_tinh.GroupingMembers = "TenNuoc";
            cbo_tinh.SelectedValue = int.Parse(giatri);
        }

        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        public void xuly()
        {
            NHACUNGCAP_BLL NHACUNGCAP = new NHACUNGCAP_BLL();
            NHACUNGCAP.NHACUNGCAP_DTO.TenNCC = txt_tenncc.Text;
            NHACUNGCAP.NHACUNGCAP_DTO.HoNguoiLH = txt_honglh.Text;
            NHACUNGCAP.NHACUNGCAP_DTO.TenNguoiLH = txt_tennglh.Text;
            NHACUNGCAP.NHACUNGCAP_DTO.ChucVu = txt_chucvu.Text;
            NHACUNGCAP.NHACUNGCAP_DTO.TinhID = (int)cbo_tinh.SelectedValue;

            NHACUNGCAP.NHACUNGCAP_DTO.DiaChi = txt_diachi.Text;
            NHACUNGCAP.NHACUNGCAP_DTO.DienThoai = txt_dienthoai.Text;
            NHACUNGCAP.NHACUNGCAP_DTO.FAX = txt_fax.Text;
            NHACUNGCAP.NHACUNGCAP_DTO.Email = txt_email.Text;
            NHACUNGCAP.NHACUNGCAP_DTO.Website = txt_website.Text;
            NHACUNGCAP.NHACUNGCAP_DTO.GhiChu = txt_ghichu.Text;

            if (ma == "")
            {
                if (NHACUNGCAP.nhacungcap_them() > 0)
                {
                    guidulieu(NHACUNGCAP.NHACUNGCAP_DTO.NCCID.ToString());
                    this.Close();
                }
            }
            else
            {
                if (NHACUNGCAP.nhacungcap_sua(ma) > 0)
                {
                    guidulieu(NHACUNGCAP.NHACUNGCAP_DTO.NCCID.ToString());
                    this.Close();
                }
            }
        }
        //
        #endregion

        #region "Sự kiện"
        private void btn_themtinh_Click(object sender, EventArgs e)
        {
            vitridiali.frm_tinh_capnhat frm = new ThietBiPY.DanhMuc.vitridiali.frm_tinh_capnhat();
            frm.DuLieu = new ThietBiPY.DanhMuc.vitridiali.frm_tinh_capnhat.passData(danhmuc_tinh);
            frm.ShowDialog();
        }
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (txt_tenncc.Text == "")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa nhập tên nhà cung cấp", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_tenncc.Focus();
            }
            else if (txt_honglh.Text == "")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa nhập họ và tên đệm của người liên hệ!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_honglh.Focus();
            }
            else if (txt_tennglh.Text == "")
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Chưa nhập tên người liên hệ!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txt_tennglh.Focus();
            }
            else xuly();
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void frm_nhacungcap_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: btn_huybo_Click(null, null); break;
                case Keys.F8: btn_luulai_Click(null, null); break;
            }
        }
        #endregion

        private void txt_tenncc_Validated(object sender, EventArgs e)
        {
            if (txt_tenncc.Text != "")
            {
                DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

                if (ma == "")
                {
                    if (new NHACUNGCAP_BLL().nhacungcap_kiemtratenncc(txt_tenncc.Text) == true)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Tên nhà cung cấp này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_tenncc.Focus();
                    }
                } //sửa
                else
                {
                    if (!txt_tenncc.Text.Equals(new NHACUNGCAP_BLL().nhacungcap_thongtin(ma).TenNCC))
                    {
                        if (new NHACUNGCAP_BLL().nhacungcap_kiemtratenncc(txt_tenncc.Text) == true)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Tên nhà cung cấp này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txt_tenncc.Focus();
                        }
                    }
                }
            }
        }
        private void frm_nhacungcap_capnhat_Load(object sender, EventArgs e)
        {
            txt_tenncc.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tenncc).OnKeyPress);
            txt_honglh.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_honglh).OnKeyPress);
            txt_tennglh.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tennglh).OnKeyPress);
            txt_chucvu.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_chucvu).OnKeyPress);

            txt_diachi.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_diachi).OnKeyPress);
            txt_ghichu.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_ghichu).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
    }
}
