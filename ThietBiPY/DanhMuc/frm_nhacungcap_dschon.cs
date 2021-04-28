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

namespace ThietBiPY.DanhMuc
{
    public partial class frm_nhacungcap_dschon : DevComponents.DotNetBar .Office2007Form 
    {
        public frm_nhacungcap_dschon()
        {
            InitializeComponent();
            //
            lv_nhacungcap.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_nhacungcap.Columns.Add("Nhà cung cấp", 200);
            lv_nhacungcap.Columns.Add("Người đại diện", 200);
            lv_nhacungcap.Columns.Add("Địa chỉ",200);
            lv_nhacungcap.Columns.Add("Số điện thoại", 200);

            danhsach_nhacungcap(null,null);
            txt_nhacungcap.TextChanged += new EventHandler(danhsach_nhacungcap);
        }

        //
        public void danhsach_nhacungcap(object sender,EventArgs e)
        {

            var NCC = new NHACUNGCAP_BLL().nhacungcap_danhsach().Select(c => new
            {
                NCCID = c.NCCID,
                TenNCC = c.TenNCC,
                NguoiDaiDien = c.HoNguoiLH + " " + c.TenNguoiLH,
                DiaChi = c.DiaChi,
                DienThoai = c.DienThoai,
            }).ToList();

            if (txt_nhacungcap.Text != "")
            {
                NCC = NCC.Where(c => c.TenNCC.ToUpper().Contains(txt_nhacungcap.Text.ToUpper())).ToList();
            }
            //
            lv_nhacungcap.Items.Clear();
            ListViewItem item = null;
            int dem=0;
            if (NCC.Count() > 0)
            {
                foreach (var N in NCC)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = N.NCCID.ToString();
                    lv_nhacungcap.Items.Add(item);
                    item.SubItems.Add(N.TenNCC);
                    item.SubItems.Add(N.NguoiDaiDien);
                    item.SubItems.Add(N.DiaChi);
                    item.SubItems.Add(N.DienThoai);

                    for (int cot = 0; cot < lv_nhacungcap.Columns.Count; cot++)
                    {
                      if(dem%2==0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
            lbl_thongke.Text = "Số lượng: " + lv_nhacungcap.Items.Count.ToString();

        }
    
        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        //
        public void chonnhacungcap()
        {
            if (lv_nhacungcap.SelectedItems.Count > 0)
            {
                guidulieu(lv_nhacungcap.SelectedItems[0].Tag.ToString());
                this.Close();
            }
        }

        private void btn_chonnhacungcap_Click(object sender, EventArgs e)
        {
            chonnhacungcap();
        }
        private void lv_nhacungcap_DoubleClick(object sender, EventArgs e)
        {
            chonnhacungcap();
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            danhsach_nhacungcap(null,null);
        }

        //
        private void frm_nhacungcap_dschon_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: btn_dong_Click(null, null); break;
                case Keys.F8: btn_chonnhacungcap_Click(null, null); break;
                case Keys.F5: btn_lamtuoi_Click(null, null); break;
            }
        }
        private void frm_nhacungcap_dschon_Load(object sender, EventArgs e)
        {
            txt_nhacungcap.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_nhacungcap).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }
    }
}
