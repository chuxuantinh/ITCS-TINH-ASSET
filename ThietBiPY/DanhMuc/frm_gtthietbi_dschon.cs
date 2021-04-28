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
    public partial class frm_gtthietbi_dschon : DevComponents.DotNetBar.Office2007Form
    {
        //
        List<string> LST_THIETBIDACHON = new List<string>();

        //
        public frm_gtthietbi_dschon()
        {
            InitializeComponent();
            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã thiết bị", 100);
            lv_thietbi.Columns.Add("Số hiệu", 150);
            lv_thietbi.Columns.Add("Ngày nhập", 200);
            lv_thietbi.Columns.Add("Đơn giá nhập", 200);

            //
            danhmuc_loaithietbi("");
            tieuchitimkiem();
            txt_tukhoa.TextChanged += new EventHandler(danhsach_gtthietbi);
        }
        public frm_gtthietbi_dschon(List<string> LST_THIETBIDACHON)
        {
            InitializeComponent();
            this.LST_THIETBIDACHON = LST_THIETBIDACHON;

            lv_thietbi.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_thietbi.Columns.Add("Mã thiết bị", 100);
            lv_thietbi.Columns.Add("Số hiệu", 150);
            lv_thietbi.Columns.Add("Mã cá biệt", 150);
            lv_thietbi.Columns.Add("Ngày nhập", 200);
            lv_thietbi.Columns.Add("Đơn giá nhập", 200);

            //
            danhmuc_loaithietbi("");
            tieuchitimkiem();
            txt_tukhoa.TextChanged += new EventHandler(danhsach_gtthietbi);
        }

        #region "Hàm xử lý"
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
            cbo_loaithietbi.DataSource = binding_loaithietbi;
            cbo_loaithietbi.GroupingMembers = "TenNhomTB";
            cbo_loaithietbi.ValueMember = "LoaiTBID";
            cbo_loaithietbi.DisplayMembers = "TenLoaiTB";

            if (giatri == "")
            {
                cbo_loaithietbi.SelectedIndex = 0;
            }
            else cbo_loaithietbi.SelectedValue = int.Parse(giatri);

            cbo_loaithietbi.SelectedIndexChanged += new EventHandler(danhsach_gtthietbi);
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

            cbo_tieuchi.SelectedIndexChanged += new EventHandler(danhsach_gtthietbi);
            danhsach_gtthietbi(null, null);
        }
        
        //
        public class Lay1GiaTriThietBi : IEqualityComparer<GTTHIETBI>
        {
            public bool Equals(GTTHIETBI x, GTTHIETBI y)
            {
                if (x == null || y == null)
                    return false;
                else
                    return x.ThietBiID == y.ThietBiID;
            }

            public int GetHashCode(GTTHIETBI obj)
            {
                return obj.ThietBiID.GetHashCode();
            }

        }
        public void danhsach_gtthietbi(object sender, EventArgs e)
        {
            var LST_THIETBI = new GTTHIETBI_BLL().gtthietbi_danhsach().Where(c => !LST_THIETBIDACHON.Contains(c.GTThietBiID.ToString())).ToList();
            if (opt_loaithietbi.Checked)
            {
                if (cbo_loaithietbi.SelectedIndex >= 0) LST_THIETBI = LST_THIETBI.Where(c => c.THIETBI.LoaiTBID == (int)cbo_loaithietbi.SelectedValue).Distinct(new Lay1GiaTriThietBi()).ToList();
            }
            if (txt_tukhoa.Text != "")
            {
                switch ((int)cbo_tieuchi.SelectedValue)
                {
                    case 1:
                        LST_THIETBI = LST_THIETBI.Where(c => c.THIETBI.MaThietBi.Contains(txt_tukhoa.Text.ToUpper())).ToList();
                        break;
                    case 2:
                        LST_THIETBI = LST_THIETBI.Where(c => c.THIETBI.SoHieu.Contains(txt_tukhoa.Text.ToUpper())).ToList();
                        break;
                    case 3:
                        LST_THIETBI = LST_THIETBI.Where(c => c.THIETBI.TenThietBi.ToUpper().Contains(txt_tukhoa.Text)).ToList();
                        break;
                }
            }
            //
            lv_thietbi.Items.Clear();
            if (LST_THIETBI.Count() > 0)
            {
                ListViewItem item = null;
                ListViewGroup lv_gr = null;
                foreach (var TB in LST_THIETBI)
                {
                    int dem = 0;
                    lv_gr = new ListViewGroup(TB.THIETBI.TenThietBi);
                    this.lv_thietbi.Groups.Add(lv_gr);

                    List<GTTHIETBI> LST_GTTB = new List<GTTHIETBI>();
                    LST_GTTB = new GTTHIETBI_BLL().gtthietbi_danhsach().Where(c => c.ThietBiID == TB.ThietBiID).ToList();
                    if (LST_GTTB != null)
                    {
                        foreach (var GTTB in LST_GTTB)
                        {
                            dem++;
                            item = new ListViewItem(dem.ToString());
                            item.Tag = GTTB.GTThietBiID.ToString();
                            item.Group = lv_gr;
                            lv_thietbi.Items.Add(item);
                            item.SubItems.Add(GTTB.THIETBI.MaThietBi);
                            item.SubItems.Add(GTTB.THIETBI.SoHieu);
                            item.SubItems.Add(GTTB.MaCaBiet);
                            item.SubItems.Add(GTTB.CTPHIEUNHAP.PHIEUNHAP.NgayNhap.Value.Date.ToString("dd/MM/yyyy"));
                            item.SubItems.Add(string.Format("{0:0,0}", GTTB.CTPHIEUNHAP.DonGia));

                            for (int cot = 0; cot < lv_thietbi.Columns.Count; cot++)
                            {
                                if (dem % 2 == 0) item.SubItems[cot].BackColor = Color.AliceBlue;
                            }
                        }
                    }
                }
            }
        }
            
        //
        
        private void opt_batki_CheckedChanged(object sender, DevComponents.DotNetBar.CheckBoxChangeEventArgs e)
        {
            if (opt_batki.Checked == true)
            {
                cbo_loaithietbi.Enabled = false;
            }
            else cbo_loaithietbi.Enabled = true;
            danhsach_gtthietbi(null, null);
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
        #endregion

        #region "Sự kiện"

        private void btn_chon_Click(object sender, EventArgs e)
        {
            chon();
        }
        private void btn_lamtuoi_Click(object sender, EventArgs e)
        {
            string loaitb = cbo_loaithietbi.SelectedValue.ToString();
            danhmuc_loaithietbi(loaitb);
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
        #endregion
    }
}
