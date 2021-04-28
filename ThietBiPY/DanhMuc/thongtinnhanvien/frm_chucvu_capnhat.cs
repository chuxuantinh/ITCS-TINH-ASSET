using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Net.SourceForge.Vietpad.InputMethod;
using ThietBiBLL;
using ThietBiDAL;

namespace ThietBiPY.DanhMuc.thongtinnhanvien
{
    public partial class frm_chucvu_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";

        public frm_chucvu_capnhat()
        {
            InitializeComponent();
            this.Text = "Thêm chức vụ";
        }
        public frm_chucvu_capnhat(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            this.Text = "Hiệu chỉnh chức vụ: ID="+ma;
            var CV = new CHUCVU_BLL().chucvu_thongtin(ma);
            txt_chucvu.Text = CV.TenChucVu;
            input_capbac.Value = (short)CV.CapBac;
            txt_diengiai.Text = CV.DienGiai;
        }

        private void frm_chucvu_capnhat_Load(object sender, EventArgs e)
        {
            txt_chucvu.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_chucvu).OnKeyPress);
            txt_diengiai.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_diengiai).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }

        #region "Hàm xử lý"
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
            CHUCVU_BLL CHUCVU = new CHUCVU_BLL();
            CHUCVU.CHUCVU_DTO.TenChucVu = txt_chucvu.Text;
            CHUCVU.CHUCVU_DTO.CapBac = (short)input_capbac.Value;
            CHUCVU.CHUCVU_DTO.DienGiai = txt_diengiai.Text;

            if (ma == "")
            {
                if (CHUCVU.chucvu_them() > 0)
                {
                    guidulieu(CHUCVU.CHUCVU_DTO.ChucVuID.ToString());
                    this.Close();
                }
            }
            else
            {
                if (CHUCVU.chucvu_sua(ma) > 0)
                {
                    guidulieu(CHUCVU.CHUCVU_DTO.ChucVuID.ToString());
                    this.Close();
                }
            }

        }
        #endregion

        #region "Sự kiện"
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            xuly();
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_chucvu_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: btn_huybo_Click(null, null); break;
            }
        }
        private void txt_chucvu_Validated(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (txt_chucvu.Text != "")
            {
                if (ma == "")
                {
                    if (new CHUCVU_BLL().chucvu_kiemtra(txt_chucvu.Text.Trim()) == true)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Chức vụ này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_chucvu.Focus();
                    }
                }
                else
                {
                    if (!txt_chucvu.Text.Trim().Equals(new CHUCVU_BLL().chucvu_thongtin(ma).TenChucVu))
                    {
                        if (new CHUCVU_BLL().chucvu_kiemtra(txt_chucvu.Text.Trim()) == true)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Chức vụ này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txt_chucvu.Focus();
                        }
                    }
                }
            }
        }
        #endregion
    }
}
