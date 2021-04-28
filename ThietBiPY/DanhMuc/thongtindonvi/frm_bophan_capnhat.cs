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

namespace ThietBiPY.DanhMuc.thongtindonvi
{
    public partial class frm_bophan_capnhat : DevComponents.DotNetBar.Office2007Form 
    {
        string ma = "";

        //
        public frm_bophan_capnhat()
        {
            InitializeComponent();
            this.Text = "Thêm bộ phận";
            danhmuc_donvi("0");
        }
        public frm_bophan_capnhat(string DonViID)
        {
            InitializeComponent();
            this.Text = "Thêm bộ phận";
            danhmuc_donvi(DonViID);
        }
        public frm_bophan_capnhat(string ma,string DonViID)
        {
            InitializeComponent();
            this.ma = ma;
            var BP = new BOPHAN_BLL().bophan_thongtin(ma);
            this.Text = "Hiệu chỉnh bộ phận: ID="+ma+";Tên gọi:"+BP.TenBoPhan;
            this.txt_tenbophan.Text = BP.TenBoPhan;
            danhmuc_donvi(DonViID);
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
        public void danhmuc_donvi(string giatri)
        {
            BindingSource binding_donvi = new BindingSource();
            binding_donvi.DataSource = new DONVI_BLL().donvi_danhsach().ToList();
            binding_donvi.Add(new DONVI { DonViID = 0, TenDonVi = "Chưa xác định", DienThoai = "", DienGiai = "" });
            cbo_donvi.DataSource = binding_donvi;
            cbo_donvi.ValueMember = "DonViID";
            cbo_donvi.DisplayMember = "TenDonVi";

            if (giatri != null) cbo_donvi.SelectedValue = int.Parse(giatri);
        }
        public void xuly()
        {
            BOPHAN_BLL BOPHAN = new BOPHAN_BLL();
            BOPHAN.BOPHAN_DTO.TenBoPhan = txt_tenbophan.Text;
            BOPHAN.BOPHAN_DTO.DienGiai = txt_diengiai.Text;
            BOPHAN.BOPHAN_DTO.DonViID = (int)cbo_donvi.SelectedValue;

            if (ma == "")
            {
                if (BOPHAN.bophan_them() > 0)
                {
                    guidulieu(BOPHAN.BOPHAN_DTO.BoPhanID.ToString());
                    this.Close();
                }
            }
            else
            {
                if (BOPHAN.bophan_sua(ma) > 0)
                {
                    guidulieu(BOPHAN.BOPHAN_DTO.BoPhanID.ToString());
                    this.Close();
                }
            }
        }

        #endregion
        //
        #region "Sự kiện"
        private void btn_themdonvi_Click(object sender, EventArgs e)
        {
            frm_donvi_capnhat frm = new frm_donvi_capnhat();
            frm.DuLieu = new frm_donvi_capnhat.passData(danhmuc_donvi);
            frm.ShowDialog();
        }
        //
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            if (txt_tenbophan.Text == "")
            {
                this.errorProvider1.SetError(txt_tenbophan, "Chưa nhập tên bộ phận");
                txt_tenbophan.Focus();
            }
            else
            {
                xuly();
            }
        }
        private void btn_huybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_tenbophan_Validated(object sender, EventArgs e)
        {
            if (txt_tenbophan.Text != "")
            {
                if (ma == "")
                {
                    if (new BOPHAN_BLL().bophan_kiemtra(txt_tenbophan.Text) == true)
                    {
                        this.errorProvider1.SetError(txt_tenbophan, "Bộ phận này đã tồn tại");
                        txt_tenbophan.Focus();
                    }
                }
                else
                {
                    if (!txt_tenbophan.Text.Equals(new BOPHAN_BLL().bophan_thongtin(ma).TenBoPhan))
                    {
                        if (new BOPHAN_BLL().bophan_kiemtra(txt_tenbophan.Text) == true)
                        {
                            this.errorProvider1.SetError(txt_tenbophan, "Bộ phận này đã tồn tại");
                            txt_tenbophan.Focus();
                        }
                    }
                }
            }
        }

        //Sự kiện của Form
        private void frm_bophan_capnhat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: btn_huybo_Click(null, null); break;
            }
        }
        private void frm_bophan_capnhat_Load(object sender, EventArgs e)
        {
            txt_tenbophan.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tenbophan).OnKeyPress);
            txt_diengiai.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_diengiai).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        //
        #endregion
    }
}
