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

namespace ThietBiPY.DanhMuc.thongtinthietbi
{
    public partial class frm_tinhtrangthietbi_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";
        public frm_tinhtrangthietbi_capnhat()
        {
            InitializeComponent();
        }
        public frm_tinhtrangthietbi_capnhat(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            this.Text = "Hiệu chỉnh tình trạng, ID=" + ma;
            var TT = new TINHTRANG_BLL().tinhtrang_thongtin(ma);
            if (TT != null)
            {
                txt_tinhtrang.Text = TT.TenTinhTrang;
                txt_diengiai.Text = TT.DienGiai;
                chk_macdinh.Checked = TT.MacDinh;
                chk_trangthai.Checked = TT.TrangThai;
            }
        }

        private void frm_tinhtrangthietbi_capnhat_Load(object sender, EventArgs e)
        {
            txt_tinhtrang.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tinhtrang).OnKeyPress);
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
            TINHTRANG_BLL TINHTRANG = new TINHTRANG_BLL();
            TINHTRANG.TINHTRANG_DTO.TenTinhTrang = txt_tinhtrang.Text.Trim();
            TINHTRANG.TINHTRANG_DTO.DienGiai = txt_diengiai.Text.Trim();
            TINHTRANG.TINHTRANG_DTO.MacDinh = (chk_macdinh.Checked ? true : false);
            TINHTRANG.TINHTRANG_DTO.TrangThai = (chk_trangthai.Checked ? true : false);

            if (ma == "")
            {
                if (TINHTRANG.tinhtrang_them() > 0)
                {
                    guidulieu(TINHTRANG.TINHTRANG_DTO.TinhTrangID.ToString());
                    this.Close();
                }
            }
            else
            {
                if (TINHTRANG.tinhtrang_sua(ma) > 0)
                {
                    guidulieu(TINHTRANG.TINHTRANG_DTO.TinhTrangID.ToString());
                    this.Close();
                }
            }
        }

        #endregion

        #region "Sự kiện"
        private void txt_tinhtrang_Validated(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            if (txt_tinhtrang.Text != "")
            {
                if (ma == "")
                {
                    if (new TINHTRANG_BLL().tinhtrang_kiemtra(txt_tinhtrang.Text.Trim()) == true)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Tình trạng nãy đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_tinhtrang.Focus();
                    }
                }
                else
                {
                    if (!txt_tinhtrang.Text.Equals(new TINHTRANG_BLL().tinhtrang_thongtin(ma).TenTinhTrang))
                    {
                        if (new TINHTRANG_BLL().tinhtrang_kiemtra(txt_tinhtrang.Text.Trim()) == true)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Tình trạng nãy đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txt_tinhtrang.Focus();
                        }
                    }
                }
            }
        }
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            xuly();
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_tinhtrangthietbi_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: btn_huybo_Click(null, null); break;
            }
        }
        #endregion
     
    }
}
