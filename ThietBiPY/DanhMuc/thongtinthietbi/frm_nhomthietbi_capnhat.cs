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
using Net.SourceForge.Vietpad.InputMethod;

namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    public partial class frm_nhomthietbi_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";
        public frm_nhomthietbi_capnhat()
        {
            InitializeComponent();
            this.Text = "Thêm nhóm thiết bị";
        }

        public frm_nhomthietbi_capnhat(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            var NHOMTB_TT = new NHOMTHIETBI_BLL().nhomthietbi_thongtin(ma);
            this.Text = "Hiệu chỉnh nhóm thiết bị,ID=" + NHOMTB_TT.NhomTBID.ToString();
            this.txt_nhomthietbi.Text = NHOMTB_TT.TenNhomTB;
            this.txt_diengiai.Text = NHOMTB_TT.DienGiai;
        }

        #region "Hàm xử lý"
        NHOMTHIETBI_BLL NHOMTB = new NHOMTHIETBI_BLL();
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

            NHOMTB.NHOMTHIETBI_DTO.TenNhomTB = txt_nhomthietbi.Text;
            NHOMTB.NHOMTHIETBI_DTO.DienGiai = txt_diengiai.Text;

            if (ma == "")
            {

                if (NHOMTB.nhomthietbi_them() > 0)
                {
                    guidulieu(NHOMTB.NHOMTHIETBI_DTO.NhomTBID.ToString());
                    this.Close();
                }
            }
            else
            {
                if (NHOMTB.nhomthietbi_sua(ma) > 0)
                {
                    guidulieu(NHOMTB.NHOMTHIETBI_DTO.NhomTBID.ToString());
                    this.Close();
                }
            }
        }
        //
        #endregion

        private void frm_nhomthietbi_capnhat_Load(object sender, EventArgs e)
        {
            txt_nhomthietbi.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_nhomthietbi).OnKeyPress);
            txt_diengiai.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_diengiai).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        private void txt_nhomthietbi_Validated(object sender, EventArgs e)
        {
            if (txt_nhomthietbi.Text != "")
            {
                DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
                if (ma == "")
                {
                    if (NHOMTB.nhomthietbi_kiemtra (txt_nhomthietbi.Text.Trim()) == true)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("nhóm thiết bị này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_nhomthietbi.Focus();
                    }
                }
                else
                {
                    if (!txt_nhomthietbi.Text.Equals(NHOMTB.nhomthietbi_thongtin(ma).TenNhomTB))
                    {
                        if (NHOMTB.nhomthietbi_kiemtra(txt_nhomthietbi.Text.Trim()) == true)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("nhóm thiết bị này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_nhomthietbi.Focus();
                        }

                    }
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            xuly();
        }
        private void frm_nhomthietbi_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: this.Close(); break;
                case Keys.F8: btn_luu_Click(null, null); break;
            }
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
