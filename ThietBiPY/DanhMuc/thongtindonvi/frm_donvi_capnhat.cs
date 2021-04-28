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

namespace ThietBiPY.DanhMuc.thongtindonvi
{
    public partial class frm_donvi_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";
        public frm_donvi_capnhat()
        {
            InitializeComponent();
            this.Text = "Thêm đơn vị mới";
        }

        public frm_donvi_capnhat(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            this.Text = "Hiệu chỉnh đơn vị : ID=" + ma;
            var DV = new DONVI_BLL().donvi_thongtin(ma);
            if (DV != null)
            {
                txt_donvi.Text = DV.TenDonVi;
                txt_dienthoai.Text = DV.DienThoai;
                txt_diengiai.Text = DV.DienGiai;
            }
        }

        #region "Hàm xử lý"
        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri) { if (DuLieu != null)DuLieu(giatri); }
        public void xuly()
        {
            DONVI_BLL DONVI = new DONVI_BLL();
            DONVI.DONVI_DTO.TenDonVi = txt_donvi.Text;
            DONVI.DONVI_DTO.DienThoai = txt_dienthoai.Text;
            DONVI.DONVI_DTO.DienGiai = txt_diengiai.Text;
            if (ma == "")
            {
                if (DONVI.donvi_them() > 0)
                {
                    guidulieu(DONVI.DONVI_DTO.DonViID.ToString());
                    this.Close();
                }
            }
            else
            {
                if (DONVI.donvi_sua(ma) > 0)
                {
                    guidulieu(DONVI.DONVI_DTO.DonViID.ToString());
                    this.Close();
                }
            }
        }
        //
        #endregion

        private void frm_donvi_capnhat_Load(object sender, EventArgs e)
        {
            txt_donvi.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_donvi).OnKeyPress);
            txt_dienthoai.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_dienthoai).OnKeyPress);
            txt_diengiai.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_diengiai).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }

        #region "Sự kiện"
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            xuly();
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_donvi_capnhat_KeyDown(object sender, KeyEventArgs e)
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
