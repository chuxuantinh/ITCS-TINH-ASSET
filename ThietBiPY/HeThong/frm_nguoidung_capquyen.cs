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

namespace ThietBiPY.HeThong
{
    public partial class frm_nguoidung_capquyen : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_nguoidung_capquyen()
        {
            InitializeComponent();
            danhmuc_trangthai("");
        }

        string NguoiDungID = "";
        public frm_nguoidung_capquyen(string NguoiDungID)
        {
            InitializeComponent();
            this.NguoiDungID = NguoiDungID;
            var ND = new NGUOIDUNG_BLL().nguoidung_thongtin_ID(NguoiDungID);
            txt_taikhoan.Text = ND.TaiKhoan;
            danhmuc_trangthai(ND.TrangThai == true ? "1" : "0");
            danhmuc_quyen(ND.Quyen.ToString());
        }
        //
        public void danhmuc_quyen(string giatri)
        {
            cbo_quyen.DataSource = new LopHoTro.DOITUONG[]{
                new LopHoTro.DOITUONG ("Quản trị thiết bị",1),
                new LopHoTro.DOITUONG ("Quản lý thiết bị đơn vị",2),
                new LopHoTro.DOITUONG ("Nhân viên đơn vị",0),
            };
            cbo_quyen.ValueMember = "value";
            cbo_quyen.DisplayMember = "name";

            if (giatri != "")
            {
                cbo_quyen.SelectedValue = int.Parse(giatri);
            }
            else cbo_quyen.SelectedIndex = 0;
        }
        public void danhmuc_trangthai(string giatri)
        {
            cbo_trangthai.DataSource = new LopHoTro.DOITUONG[]{
                new LopHoTro.DOITUONG ("Kích hoạt",1),
                new LopHoTro.DOITUONG ("Chưa kích hoạt",0),
            };
            cbo_trangthai.ValueMember = "value";
            cbo_trangthai.DisplayMember = "name";

            if (giatri != "")
            {
                cbo_trangthai.SelectedValue = int.Parse(giatri);
            }
            else cbo_trangthai.SelectedIndex = 0;
        }

        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        public void xuly()
        {
            NGUOIDUNG_BLL NGUOIDUNG = new NGUOIDUNG_BLL();
            NGUOIDUNG.NGUOIDUNG_DTO.TaiKhoan = txt_taikhoan.Text;
            NGUOIDUNG.NGUOIDUNG_DTO.Quyen = (int)cbo_quyen.SelectedValue;
            NGUOIDUNG.NGUOIDUNG_DTO.TrangThai = ((int)cbo_trangthai.SelectedValue ==1?true:false);
            if (NGUOIDUNG.nguoidung_capquyen(NguoiDungID) > 0)
            {
                guidulieu(NguoiDungID);
                this.Close();
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            xuly();
        }
    }
}
