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
    public partial class frm_donvitinh_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";
        public frm_donvitinh_capnhat()
        {
            InitializeComponent();
            this.Text = "Thêm đơn vị tính";

        }
        public frm_donvitinh_capnhat(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            var DVT_TT = new DONVITINH_BLL().donvitinh_thongtin(ma);
            if (DVT_TT != null)
            {
                this.Text = "Hiệu chỉnh đơn vị tính, ID=" + DVT_TT.DVTID.ToString();
                txt_tendvt.Text = DVT_TT.TenDVT;
                txt_diengiai.Text = DVT_TT.DienGiai;
            }
        }

        DONVITINH_BLL DVT = new DONVITINH_BLL();

        #region "Hàm xử lý"
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        public void xuly()
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            DVT.DONVITINH_DTO.TenDVT = txt_tendvt.Text;
            DVT.DONVITINH_DTO.DienGiai = txt_diengiai.Text;

            if (ma == "")
            {

                if (DVT.donvitinh_them() > 0)
                {
                    guidulieu(DVT.DONVITINH_DTO.DVTID.ToString());
                    this.Close();
                }
            }
            else
            {
                if (DVT.donvitinh_sua(ma) > 0)
                {
                    guidulieu(DVT.DONVITINH_DTO.DVTID.ToString());
                    this.Close();
                }
            }
        }
        #endregion

        #region "Sự kiện"
        private void txt_tendvt_Validated(object sender, EventArgs e)
        {
            if (txt_tendvt.Text != "")
            {
                DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
                if (ma == "")
                {
                    if (DVT.donvitinh_kiemtra(txt_tendvt.Text.Trim()) == true)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Đơn vị tính này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_tendvt.Focus();
                    }
                }
                else
                {
                    if (!txt_tendvt.Text.ToUpper().Equals(DVT.donvitinh_thongtin(ma).TenDVT.ToUpper()))
                    {
                        if (DVT.donvitinh_kiemtra(txt_tendvt.Text.Trim()) == true)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Đơn vị tính này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_tendvt.Focus();
                        }
                    }
                }
            }
        }
        private void frm_donvitinh_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: this.Close(); break;
                case Keys.F8: btn_luu_Click(null, null); break;
            }
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            xuly();
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void frm_donvitinh_capnhat_Load(object sender, EventArgs e)
        { 
            txt_tendvt.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tendvt).OnKeyPress);
            txt_diengiai.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_diengiai).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
    }
}
