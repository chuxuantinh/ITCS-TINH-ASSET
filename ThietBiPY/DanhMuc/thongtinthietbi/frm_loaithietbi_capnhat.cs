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
    public partial class frm_loaithietbi_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";
        public frm_loaithietbi_capnhat()
        {
            InitializeComponent();
            this.Text = "Thêm loại thiết bị";
            load_nhomthietbi();
        }
        public frm_loaithietbi_capnhat(string NhomTBID)
        {
            InitializeComponent();
            this.Text = "Thêm loại thiết bị";
            load_nhomthietbi();
            this.cbo_nhomthietbi.SelectedValue = int.Parse(NhomTBID);
        }
        public frm_loaithietbi_capnhat(string ma, string NhomTBID)
        {
            InitializeComponent();
            this.ma = ma;
            this.Text = "Hiệu chỉnh loại thiết bị: ID=" + ma;
            var LOAI = new LOAITHIETBI_BLL().loaithietbi_thongtin(ma);
            this.txt_loaithietbi.Text = LOAI.TenLoaiTB;
            this.txt_diengiai.Text = LOAI.DienGiai;
            load_nhomthietbi();
            this.cbo_nhomthietbi.SelectedValue = LOAI.NhomTBID;
        }

        //
        public void load_nhomthietbi()
        {
            cbo_nhomthietbi.DataSource = new NHOMTHIETBI_BLL().nhomthietbi_danhsach().ToList();
            cbo_nhomthietbi.ValueMember = "NhomTBID";
            cbo_nhomthietbi.DisplayMember = "TenNhomTB";
        }

        //
        private void frm_loaithietbi_capnhat_Load(object sender, EventArgs e)
        {
            txt_loaithietbi.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_loaithietbi).OnKeyPress);
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
        public void nhandulieu(string giatri)
        {
            if (giatri != null || giatri != "")
            {
                load_nhomthietbi();
                cbo_nhomthietbi.SelectedValue = int.Parse(giatri);
            }
        }
        
        //
        public void xuly()
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            LOAITHIETBI_BLL LOAITB = new LOAITHIETBI_BLL();
            LOAITB.LOAITHIETBI_DTO.TenLoaiTB = txt_loaithietbi.Text.Trim();
            LOAITB.LOAITHIETBI_DTO.NhomTBID = (int)cbo_nhomthietbi.SelectedValue;
            LOAITB.LOAITHIETBI_DTO.DienGiai = txt_diengiai.Text.Trim();
            if (ma == "")
            {
                if (LOAITB.loaithietbi_them() > 0)
                {
                    guidulieu(LOAITB.LOAITHIETBI_DTO.LoaiTBID.ToString());
                    this.Close();
                }
            }
            else
            {
                if (LOAITB.loaithietbi_sua(ma) > 0)
                {
                    guidulieu(LOAITB.LOAITHIETBI_DTO.LoaiTBID.ToString());
                    this.Close();
                }
            }
        }
        #endregion

        private void btn_luulai_Click(object sender, EventArgs e)
        {
            xuly();
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_loaithietbi_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: btn_huybo_Click(null, null); break;
            }
        }
        private void btn_themnhomthietbi_Click(object sender, EventArgs e)
        {
            frm_nhomthietbi_capnhat frm = new frm_nhomthietbi_capnhat();
            frm.DuLieu = new frm_nhomthietbi_capnhat.passData(nhandulieu);
            frm.ShowDialog();
        }

        //
        private void txt_loaithietbi_Validated(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (txt_loaithietbi.Text != "")
            {
                if (ma == "")
                {
                    if (new LOAITHIETBI_BLL().loaithietbi_kiemtraten(txt_loaithietbi.Text) == true)
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show("Loại thiết bị này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_loaithietbi.Focus();
                    }
                }
                else
                {
                    if (!txt_loaithietbi.Text.ToUpper().Equals(new LOAITHIETBI_BLL().loaithietbi_thongtin(ma).TenLoaiTB.ToUpper()))
                    {
                        if (new LOAITHIETBI_BLL().loaithietbi_kiemtraten(txt_loaithietbi.Text) == true)
                        {
                            DevComponents.DotNetBar.MessageBoxEx.Show("Loại thiết bị này đã tồn tại!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txt_loaithietbi.Focus();
                        }
                    }
                }
            }
        }
    }
}
