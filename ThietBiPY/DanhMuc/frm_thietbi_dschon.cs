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

namespace ThietBiPY.DanhMuc
{
    public partial class frm_thietbi_dschon : DevComponents.DotNetBar.Office2007Form
    {
        //
        List<string> LST_THIETBIDACHON = new List<string>();

        //
        public frm_thietbi_dschon()
        {
            InitializeComponent();
            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã thiết bị", 100);
            lv_thietbi.Columns.Add("Số hiệu", 100);
            lv_thietbi.Columns.Add("Tên thiết bị", 200);
            lv_thietbi.Columns.Add("Nước SX", 200);
            lv_thietbi.Columns.Add("Năm SX", 100,HorizontalAlignment.Center);

            //
            danhmuc_loaithietbi("");
            tieuchitimkiem();
            txt_tukhoa.TextChanged += new EventHandler(danhsach_thietbi);
        }
        public frm_thietbi_dschon(List<string> LST_THIETBIDACHON)
        {
            InitializeComponent();
            this.LST_THIETBIDACHON = LST_THIETBIDACHON;

            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã thiết bị", 100);
            lv_thietbi.Columns.Add("Số hiệu", 100);
            lv_thietbi.Columns.Add("Tên thiết bị", 200);
            lv_thietbi.Columns.Add("Nước SX", 200);
            lv_thietbi.Columns.Add("Năm SX", 100);

            //
            danhmuc_loaithietbi("");
            tieuchitimkiem();
            txt_tukhoa.TextChanged += new EventHandler(danhsach_thietbi);
        }
        
        //
        public void danhmuc_loaithietbi(string giatri)
        {
            BindingSource binding_loaithietbi = new BindingSource();
            binding_loaithietbi.DataSource = new LOAITHIETBI_BLL().loaithietbi_danhsach().Select(c => new
            {
                LoaiTBID = c.LoaiTBID,
                TenLoaiTB =c.TenLoaiTB,
                TenNhomTB = (c.NhomTBID !=0?c.NHOMTHIETBI.TenNhomTB :"Chưa xác định"),
            });

           binding_loaithietbi.Add (new {LoaiTBID=binding_loaithietbi.Count,TenLoaiTB="Tất cả",TenNhomTB="Tất cả"});

            cbo_loaithietbi.DataSource = binding_loaithietbi;
            cbo_loaithietbi.GroupingMembers = "TenNhomTB";
            cbo_loaithietbi.ValueMember = "LoaiTBID";
            cbo_loaithietbi.DisplayMembers = "TenLoaiTB";

            if (giatri == "")
            {
                cbo_loaithietbi.SelectedIndex = 0;
            }
            else cbo_loaithietbi.SelectedValue = int.Parse(giatri);

            cbo_loaithietbi.SelectedIndexChanged += new EventHandler(danhsach_thietbi);
           // danhsach_thietbi(null, null);
        }
        public void tieuchitimkiem()
        {
            cbo_tieuchi.DataSource = new LopHoTro.DOITUONG[]{
                new LopHoTro.DOITUONG ("Mã TB",1),
                new LopHoTro.DOITUONG ("Số hiệu",2),
                new LopHoTro.DOITUONG ("Tên TB",3),
            };
            cbo_tieuchi.ValueMember = "value";
            cbo_tieuchi.DisplayMember = "name";

            cbo_tieuchi.SelectedIndexChanged += new EventHandler(danhsach_thietbi);
            danhsach_thietbi(null, null);
        }
        
        //
        public void danhsach_thietbi(object sender,EventArgs e)
        {
            var LST_THIETBI = new THIETBI_BLL().thietbi_danhsach().Where (c=>!LST_THIETBIDACHON.Contains(c.ThietBiID.ToString())).ToList ();
            if (opt_loaithietbi.Checked)
            {
                if (cbo_loaithietbi.SelectedIndex >= 0 && cbo_loaithietbi.SelectedNode.Text!="Tất cả") LST_THIETBI = LST_THIETBI.Where(c => c.LoaiTBID == (int)cbo_loaithietbi.SelectedValue).ToList();
            }
                if (txt_tukhoa.Text != "")
            {
                switch ((int)cbo_tieuchi.SelectedValue)
                {
                    case 1:
                        LST_THIETBI = LST_THIETBI.Where(c => c.MaThietBi.Contains(txt_tukhoa.Text.ToUpper())).ToList();
                        break;
                    case 2: 
                        LST_THIETBI = LST_THIETBI.Where(c => c.SoHieu.Contains(txt_tukhoa.Text.ToUpper())).ToList();
                        break;
                    case 3:
                        LST_THIETBI = LST_THIETBI.Where(c => c.TenThietBi.ToUpper().Contains(txt_tukhoa.Text.ToUpper())).ToList();
                        break;
                }
            }
            //
            lv_thietbi.Items.Clear();
            if (LST_THIETBI.Count() > 0)
            {   
                int dem = 0;
                ListViewItem item = null;
                foreach (var TB in LST_THIETBI)
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = TB.ThietBiID.ToString();
                    lv_thietbi.Items.Add(item);
                    item.SubItems.Add(TB.MaThietBi);
                    item.SubItems.Add(TB.SoHieu);
                    item.SubItems.Add(TB.TenThietBi);
                    item.SubItems.Add(TB.NuocSX!=0?TB.NUOC.TenNuoc :"Chưa xác định");
                    item.SubItems.Add(TB.NamSX.ToString());

                    for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                    {
                        if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
           //
        }

        private void opt_batki_CheckedChanged(object sender, DevComponents.DotNetBar.CheckBoxChangeEventArgs e)
        {
            if (opt_batki.Checked == true)
            {
                cbo_loaithietbi.Enabled = false;
            }
            else cbo_loaithietbi.Enabled = true;
            danhsach_thietbi(null, null);
        }
    
        //
        public delegate void passData(string giatri);
        public passData DuLieu;
        public void guidulieu(string giatri)
        {
            if (DuLieu != null) DuLieu(giatri);
        }
        
        //
        public void chon()
        {
            foreach (ListViewItem item in lv_thietbi.Items)
            {
                if (item.Checked == true)
                {
                    guidulieu(item.Tag.ToString());
                    lv_thietbi.Items.Remove(item);
                }
            }
        }

        //
        private void btn_chon_Click(object sender, EventArgs e)
        {
            chon();
        }
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            if (cbo_loaithietbi.SelectedNode.Text != "Tất cả")
            {
                string loaitb = cbo_loaithietbi.SelectedValue.ToString();
                danhmuc_loaithietbi(loaitb);
            }
            else danhmuc_loaithietbi("");
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lv_thietbi_DoubleClick(object sender, EventArgs e)
        {
            if (lv_thietbi.SelectedItems.Count > 0)
            {
                guidulieu(lv_thietbi.SelectedItems[0].Tag.ToString());
                lv_thietbi.Items.Remove(lv_thietbi.SelectedItems[0]);
            }
        }

        private void frm_thietbi_dschon_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: this.Close(); break;
                case Keys.F12:
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    else this.WindowState = FormWindowState.Maximized;
                    break;
                case Keys.F5: btn_lamtuoi_Click(null, null); break;
            }
        }
    }
}
