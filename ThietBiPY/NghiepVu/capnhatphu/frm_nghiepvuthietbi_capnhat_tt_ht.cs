using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Net.SourceForge.Vietpad.InputMethod;

using ThietBiDAL;
using ThietBiBLL;

namespace ThietBiPY.NghiepVu.capnhatphu
{
    public partial class frm_nghiepvuthietbi_capnhat_tt_ht : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_nghiepvuthietbi_capnhat_tt_ht()
        {
            InitializeComponent();
        }

        public frm_nghiepvuthietbi_capnhat_tt_ht(string tinhtrang,string hientrang)
        {
            InitializeComponent();
            danhmuc_tinhtrang(tinhtrang);
            txt_hientrang.Text = hientrang;
        }

        public void danhmuc_tinhtrang(string giatri)
        {
            BindingSource binding_tinhtrang= new BindingSource ();
            binding_tinhtrang.DataSource = new TINHTRANG_BLL().tinhtrang_danhsach().Select(c => new
            {
                TinhTrangID=c.TinhTrangID,
                TenTinhTrang=c.TenTinhTrang,
            });
            binding_tinhtrang.Add(new { TinhTrangID = 0, TenTinhTrang = "Chưa xác định" });
            cbo_tinhtrang.DataSource = binding_tinhtrang;
            cbo_tinhtrang.ValueMember = "TinhTrangID";
            cbo_tinhtrang.DisplayMember = "TenTinhTrang";
            if (giatri != "") cbo_tinhtrang.SelectedValue = int.Parse(giatri);
            else if (cbo_tinhtrang.Items.Count>0) cbo_tinhtrang.SelectedIndex = 0;
        }

        #region "Hàm xử lý"
        //
        public delegate void passData(string soluong, string hientrang);
        public passData DuLieu;
        public void guidulieu(string soluong, string hientrang)
        {
            if (DuLieu != null) DuLieu(soluong, hientrang);
        }

        //
        public void bangdieukhien(string yeucau)
        {
            switch (yeucau)
            {
                case "luulai":
                    guidulieu(cbo_tinhtrang.SelectedValue.ToString(), txt_hientrang.Text.Trim());
                    this.Close();
                    break;

                case "dong":
                    this.Close();
                    break;
            }
        }
        #endregion

        #region "Sự kiện"
        //
        private void btn_luulai_Click(object sender, EventArgs e)
        {
            bangdieukhien("luulai");
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            bangdieukhien("dong");
        }

        private void frm_bangiaothietbi_capnhat_sl_ht_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_luulai_Click(null, null); break;
                case Keys.Escape: btn_dong_Click(null, null); break;
            }
        }
        private void frm_bangiaothietbi_capnhat_sl_ht_Load(object sender, EventArgs e)
        {
            txt_hientrang.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_hientrang).OnKeyPress);
            
            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
        #endregion

        private void btn_lamtuoi_tinhtrang_Click(object sender, EventArgs e)
        {
            danhmuc_tinhtrang("");
        }

        private void btn_them_tinhtrang_Click(object sender, EventArgs e)
        {
            DanhMuc.thongtinthietbi.frm_tinhtrangthietbi_capnhat frm = new ThietBiPY.DanhMuc.thongtinthietbi.frm_tinhtrangthietbi_capnhat();
            frm.DuLieu = new ThietBiPY.DanhMuc.thongtinthietbi.frm_tinhtrangthietbi_capnhat.passData(danhmuc_tinhtrang);
            frm.ShowDialog();
        }
    }
}
