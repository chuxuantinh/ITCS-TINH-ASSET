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
    public partial class frm_nhanvien_dschon : DevComponents.DotNetBar.Office2007Form 
    {
        public frm_nhanvien_dschon()
        {
            InitializeComponent();

            lv_nhanvien.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_nhanvien.Columns.Add("Mã NV", 70);
            lv_nhanvien.Columns.Add("Họ tên", 200);
            lv_nhanvien.Columns.Add("Chức vụ", 200);

            danhmuc_donvi("");
            danhmuc_timtheo("");
            txt_tukhoa.TextChanged += new EventHandler(txt_tukhoa_TextChanged);
        }

        public frm_nhanvien_dschon(string DonViID)
        {
            InitializeComponent();

            lv_nhanvien.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_nhanvien.Columns.Add("Mã NV", 70);
            lv_nhanvien.Columns.Add("Họ tên", 200);
            lv_nhanvien.Columns.Add("Chức vụ", 200);

            danhmuc_donvi(DonViID);
            cbo_donvi.Enabled = false;
            danhmuc_timtheo("");
            txt_tukhoa.TextChanged += new EventHandler(txt_tukhoa_TextChanged);
        }
        
        //
        public void danhmuc_donvi(string giatri)
        {
            BindingSource binding_donvi = new BindingSource();
            binding_donvi.DataSource = new DONVI_BLL().donvi_danhsach().Select(c => new 
            {
                DonViID = c.DonViID,
                TenDonVi = c.TenDonVi,
            });
            binding_donvi.Add(new {DonViID = 0, TenDonVi = "Chưa xác định" });

            cbo_donvi.DataSource = binding_donvi;
            cbo_donvi.ValueMember = "DonViID";
            cbo_donvi.DisplayMember = "TenDonVi";

            if (giatri != "")
            {
                cbo_donvi.SelectedValue = int.Parse(giatri);
            }
            else cbo_donvi.SelectedIndex = 0;

            cbo_donvi.SelectedIndexChanged += new EventHandler(cbo_donvi_SelectIndexChanged);
            cbo_donvi_SelectIndexChanged(null, null);
        }
        public void danhmuc_timtheo(string giatri)
        {
            cbo_timtheo.DataSource = new LopHoTro.DOITUONG[]{
                new LopHoTro.DOITUONG ("Tên NV",1),
                new LopHoTro.DOITUONG ("Mã NV",2),
            };
            cbo_timtheo.ValueMember = "value";
            cbo_timtheo.DisplayMember = "name";

            if (giatri != "")
            {
                cbo_timtheo.SelectedValue = int.Parse(giatri);
            }
            else cbo_timtheo.SelectedIndex = 0;
            cbo_timtheo_SelectIndexChanged(null, null);
        }

        private void cbo_donvi_SelectIndexChanged(object sender, EventArgs e)
        {
            danhsach_nhanvien();
        }
        private void cbo_timtheo_SelectIndexChanged(object sender, EventArgs e)
        {
            danhsach_nhanvien();
        }
        private void txt_tukhoa_TextChanged(object sender, EventArgs e)
        {
            danhsach_nhanvien();
        }
        
        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }

        public void chonnhanvien()
        {
            if (lv_nhanvien.SelectedItems.Count > 0)
            {
                guidulieu(lv_nhanvien.SelectedItems[0].Tag.ToString());
                this.Close();
            }
        }
        //
        public void danhsach_nhanvien()
        {
            var NHANVIEN = new NHANVIEN_BLL().nhanvien_danhsach().Select(c => new
            {
                NhanVienID = c.NhanVienID,
                MaNV= c.MaNV,
                HoTen = c.HoNV +" " +c.TenNV,
                DonViID =c.DonViID,
                TenDonVi = (c.DonViID !=0?c.DONVI.TenDonVi :"Chưa xác định"),
                ChucVuID = c.ChucVuID ,
                TenChucVu =(c.ChucVuID !=0?c.CHUCVU .TenChucVu:"Chưa xác định"),
            });
            if (cbo_donvi.SelectedIndex >= 0)
            {
                NHANVIEN = NHANVIEN.Where(c => c.DonViID == (int)cbo_donvi.SelectedValue).ToList();
            }
            if (txt_tukhoa.Text != "")
            {
                if ((int)cbo_timtheo.SelectedValue == 1)
                {
                    NHANVIEN = NHANVIEN.Where(c => c.HoTen.ToUpper().Contains(txt_tukhoa.Text.ToUpper())).ToList();

                }
                else if ((int)cbo_timtheo.SelectedValue == 2)
                {
                    NHANVIEN = NHANVIEN.Where(c => c.MaNV.ToUpper().Contains(txt_tukhoa.Text.ToUpper())).ToList();
                }
            }

            //
            lv_nhanvien.Items.Clear();
            ListViewItem item = null;
            int dem = 0;
            foreach (var NV in NHANVIEN)
            {
                dem++;
                item = new ListViewItem(dem.ToString());
                item.Tag = NV.NhanVienID.ToString();
                lv_nhanvien.Items.Add(item);
                item.SubItems.Add(NV.MaNV);
                item.SubItems.Add(NV.HoTen);
                item.SubItems.Add(NV.TenChucVu);

                for (int cot = 0; cot < lv_nhanvien.Columns.Count; cot++)
                {
                    if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    item.SubItems[0].BackColor = Color.WhiteSmoke;
                }
            }
            //
            lbl_thongke.Text = "Số lượng: " + lv_nhanvien.Items.Count.ToString();

        }

        private void frm_nhanvien_dschon_Load(object sender, EventArgs e)
        {
            txt_tukhoa.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tukhoa).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }

        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            txt_tukhoa.Text= "";
            cbo_timtheo.SelectedValue = 1;
            danhmuc_donvi("");
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            chonnhanvien();
        }
        private void lv_nhanvien_DoubleClick(object sender, EventArgs e)
        {
            btn_chon_Click(null, null);
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_nhanvien_dschon_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F8: btn_chon_Click(null, null); break;
                case Keys.F5: btn_lamtuoi_Click(null, null); break;
                case Keys.Escape: btn_dong_Click(null, null); break;
                case Keys.F12:
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    else this.WindowState = FormWindowState.Maximized;
                    break;
            }
        }
        //

    }
}
