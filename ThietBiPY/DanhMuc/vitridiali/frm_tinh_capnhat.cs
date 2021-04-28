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

namespace ThietBiPY.DanhMuc.vitridiali
{
    public partial class frm_tinh_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";

        //
        public frm_tinh_capnhat()
        {
            InitializeComponent();
            danhsachnuoc("");
        }
        public frm_tinh_capnhat(string NuocID)
        {
            InitializeComponent();
            danhsachnuoc(NuocID);
        }
        public frm_tinh_capnhat(string ma,string NuocID)
        {
            InitializeComponent();
            this.ma = ma;
            danhsachnuoc(NuocID);
            var LST_TINH = new TINH_BLL().tinh_thongtin(ma);
            if (LST_TINH != null)
            {
                this.txt_tentinh.Text = LST_TINH.TenTinh;
            }
        }

        #region "Hàm Xử Lý"
        
        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        //
        public void danhsachnuoc(string giatri)
        {
            cbo_nuoc.DataSource = new NUOC_BLL().nuoc_danhsach();
            cbo_nuoc.ValueMember = "NuocID";
            cbo_nuoc.DisplayMember = "TenNuoc";

            if (giatri != "") cbo_nuoc.SelectedValue = int.Parse(giatri);
            else cbo_nuoc.SelectedIndex = 0;
        }
        public void nhandulieu(string giatri)
        {
            danhsachnuoc(giatri);
        }
        #endregion

        //
        private void frm_tinh_capnhat_Load(object sender, EventArgs e)
        {
            txt_tentinh.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tentinh).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        private void btn_themnuoc_Click(object sender, EventArgs e)
        {
            frm_nuoc_capnhat frm = new frm_nuoc_capnhat();
            frm.DuLieu = new frm_nuoc_capnhat.passData(nhandulieu);
            frm.ShowDialog();
        }
        public void thuchienluu()
        {
            TINH_BLL TINH = new TINH_BLL();
            TINH.TINH_DTO.TenTinh = txt_tentinh.Text.Trim();
            TINH.TINH_DTO.NuocID = (int)cbo_nuoc.SelectedValue;
            if (ma == "")
            {
                if (TINH.tinh_them() > 0)
                {
                    guidulieu(TINH.TINH_DTO.TinhID.ToString());
                    this.Close();
                }
            }

            else
            {
                if (TINH.tinh_sua(ma) > 0)
                {
                    guidulieu(TINH.TINH_DTO.TinhID.ToString());
                    this.Close();
                }
            }
        }
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            thuchienluu();
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
