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
using ThietBiPY.LopHoTro;

using Net.SourceForge.Vietpad.InputMethod;

namespace ThietBiPY.DanhMuc
{
    public partial class frm_nhanvien : DevComponents.DotNetBar.Office2007Form
    {
        int vitri = 0;
        int sodong = 100, tongsotrang = 0;
        List<NHANVIEN> LST_NHANVIEN = new List<NHANVIEN>();

        public frm_nhanvien()
        {
            InitializeComponent();
            lv_nhanvien.Columns.Add("STT", 50, HorizontalAlignment.Center);
            lv_nhanvien.Columns.Add("Mã NV", 80);
            lv_nhanvien.Columns.Add("Họ tên", 200);
            lv_nhanvien.Columns.Add("Giới tính", 60);
            lv_nhanvien.Columns.Add("Đơn vị", 200);
            lv_nhanvien.Columns.Add("Chức vụ", 200);

            hienthi_tatca();
            cbo_donvi_SelectIndexChanged(null, null);
        }

        #region "Hàm xử lý"
        //danh mục tìm kiếm
        public void danhmuc_gioitinh(string giatri)
        {
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = new DOITUONG[]{
                new DOITUONG ("Nam",1),
                new DOITUONG ("Nữ",0),
                new DOITUONG ("[Tất cả]",2),
            };
            cbo_gioitinh.DataSource = binding_source;
            cbo_gioitinh.DisplayMember = "name";
            cbo_gioitinh.ValueMember = "value";
            cbo_gioitinh.SelectedValue = int.Parse(giatri);
            cbo_gioitinh.SelectedIndexChanged += new EventHandler(cbo_gioitinh_SelectIndexChanged);
        }
        public void danhmuc_donvi(string giatri)
        {
            BindingSource binding_donvi = new BindingSource();
            binding_donvi.DataSource = new DONVI_BLL().donvi_danhsach().ToList();
            binding_donvi.Add(new DONVI { DonViID = 0, TenDonVi = "[Chưa xác định]", DienThoai = "", DienGiai = "" });
            binding_donvi.Add(new DONVI { DonViID = binding_donvi.Count, TenDonVi = "[Tất cả]", DienThoai = "", DienGiai = "" });

            cbo_donvi.DataSource = binding_donvi;
            cbo_donvi.ValueMember = "DonViID";
            cbo_donvi.DisplayMember = "TenDonVi";

            cbo_donvi.SelectedIndexChanged += new EventHandler(cbo_donvi_SelectIndexChanged);

            if (giatri != "")
            {
                cbo_donvi.SelectedValue = int.Parse(giatri);
            }
            else cbo_donvi.SelectedIndex = 0;
            //cbo_donvi_SelectIndexChanged(null, null);
        }
        public void danhmuc_chucvu(string giatri)
        {
            BindingSource binding_chucvu = new BindingSource();
            binding_chucvu.DataSource = new CHUCVU_BLL().chucvu_danhsach().ToList();
            binding_chucvu.Add(new CHUCVU { ChucVuID = 0, TenChucVu = "[Chưa xác định]", CapBac = 0, DienGiai = "" });
            binding_chucvu.Add(new CHUCVU { ChucVuID = binding_chucvu.Count, TenChucVu = "[Tất cả]", CapBac = 0, DienGiai = "" });
            cbo_chucvu.DataSource = binding_chucvu;
            cbo_chucvu.ValueMember = "ChucVuID";
            cbo_chucvu.DisplayMember = "TenChucVu";

            if (giatri != "")
            {
                cbo_chucvu.SelectedValue = int.Parse(giatri);
            }else cbo_chucvu.SelectedIndex =new CHUCVU_BLL().chucvu_danhsach().Count() + 1;

            cbo_chucvu.SelectedIndexChanged += new EventHandler(cbo_chucvu_SelectIndexChanged);
           // cbo_chucvu_SelectIndexChanged(null, null);
        }
        public void danhmuc_tieuchitimkiem(string giatri)
        {
            cbo_tieuchitimkiem.DataSource = new DOITUONG[]{
                new DOITUONG ("Mã nhân viên",1),
                new DOITUONG ("Tên NV",2),
                new DOITUONG ("[Tất cả]",3),
            };
            cbo_tieuchitimkiem.ValueMember = "value";
            cbo_tieuchitimkiem.DisplayMember = "name";
            cbo_tieuchitimkiem.SelectedValue = int.Parse(giatri);

            cbo_tieuchitimkiem.SelectedIndexChanged += new EventHandler(cbo_tieuchitimkiem_SelectIndexChanged);
        }
        //
        public void nhandulieu(string giatri)
        {
            if (giatri != null)
            {
                var NV = new NHANVIEN_BLL().nhanvien_thongtin(giatri);
                vitri = 0;
                LST_NHANVIEN = new NHANVIEN_BLL().nhanvien_danhsach().ToList();
                danhsachnhanvien(LST_NHANVIEN);
                cbo_donvi.SelectedValue = NV.DonViID;
                cbo_donvi_SelectIndexChanged(null, null);
            }
        }
        public void danhsachnhanvien(List<NHANVIEN> LST)
        {
            lv_nhanvien.Items.Clear();
            tongsotrang = 1;

            if (LST.Count>0)
            {
                ListViewItem item = null;
                int dem = 0;
                tongsotrang = (int)(Math.Floor((decimal)(LST.Count / sodong)) + (LST.Count % sodong == 0 ? 0 : 1));
                foreach (var NV in LST.Skip (vitri*sodong).Take(sodong).ToList())
                {
                    dem++;
                    item = new ListViewItem(dem.ToString());
                    item.Tag = NV.NhanVienID;
                    lv_nhanvien.Items.Add(item);
                    item.SubItems.Add(NV.MaNV);
                    item.SubItems.Add(NV.HoNV + " " + NV.TenNV);
                    item.SubItems.Add((NV.GioiTinh == true ? "Nam" : "Nữ"));

                    item.SubItems.Add((NV.DONVI !=null ? NV.DONVI.TenDonVi : "Chưa xác định"));
                    item.SubItems.Add((NV.CHUCVU !=null ? NV.CHUCVU.TenChucVu : "Chưa xác định"));

                    for (int cot = 0; cot < lv_nhanvien.Columns.Count; cot++)
                    {
                       if(dem%2==0) item.SubItems[cot].BackColor = Color.AliceBlue;
                    }
                }
            }
            thongke();
        }
        public void thongke()
        {
            lbl_tongso.Text = "Tổng số: " + LST_NHANVIEN.Count.ToString();
            lbl_soluong.Text = "Trang "+ (vitri+1).ToString ()+", số lượng: " + lv_nhanvien.Items.Count.ToString();
            txt_vitri_tongsotrang.Text = (vitri + 1).ToString() + "/" + tongsotrang.ToString();
        }

        //
        public void hienthi_tatca()
        {
            txt_tukhoa.Text = "";
            danhmuc_gioitinh("2"); //1:Nam,0:Nữ, 2:Tất cả
            danhmuc_donvi(""); //Tất cả: vị trí cuối cùng (tính cả vị trí 0)

            danhmuc_chucvu("");
            danhmuc_tieuchitimkiem("3");

            txt_tukhoa.TextChanged += new EventHandler(txt_tukhoa_TextChanged);
            LST_NHANVIEN = new NHANVIEN_BLL().nhanvien_danhsach().ToList();
            danhsachnhanvien(LST_NHANVIEN);
        }
        public void loc_danhsachnhanvien()
        {
            vitri = 0;
           // tongsotrang = 1;

            LST_NHANVIEN = new NHANVIEN_BLL().nhanvien_danhsach().ToList();

            //lọc đơn vị
            if (cbo_donvi.SelectedIndex >=0)
            {
                //MessageBox.Show(cbo_donvi.SelectedIndex.ToString());
                if ((int)cbo_donvi.SelectedIndex < (cbo_donvi.Items.Count - 1)) LST_NHANVIEN = LST_NHANVIEN.Where(c => c.DonViID == (int)cbo_donvi.SelectedValue).ToList();   
            }
            //lọc chức vụ
            if (cbo_chucvu.SelectedIndex >= 0)
            {
                if ((int)cbo_chucvu.SelectedIndex < (cbo_chucvu.Items.Count - 1)) LST_NHANVIEN = LST_NHANVIEN.Where(c => c.ChucVuID == (int)cbo_chucvu.SelectedValue).ToList();
            }
            //lọc giới tính
            if ((int)cbo_gioitinh.SelectedIndex < 2) LST_NHANVIEN = LST_NHANVIEN.Where(c => c.GioiTinh == ((int)cbo_gioitinh.SelectedValue == 1 ? true : false)).ToList();
           
            //
            if (txt_tukhoa.Text != "")
            {
                switch ((int)cbo_tieuchitimkiem.SelectedValue)
                {
                    case 1: //lọc theo mã nhân viên
                        LST_NHANVIEN = LST_NHANVIEN.Where(c => c.MaNV.Contains(txt_tukhoa.Text.ToUpper())).ToList();
                        break;

                    case 2://lọc theo tên nhân viên
                        LST_NHANVIEN = LST_NHANVIEN.Where(c => c.TenNV.ToUpper().Contains(txt_tukhoa.Text.ToUpper())).ToList();
                        break;
                }
            }

            danhsachnhanvien(LST_NHANVIEN);
        }
        //
        public void chitietnhanvien()
        {
            if (lv_nhanvien.SelectedItems.Count > 0)
            {
                var NV = LST_NHANVIEN.Single(c => c.NhanVienID == Int64.Parse(lv_nhanvien.SelectedItems[0].Tag.ToString()));
                if (NV != null)
                {
                    pic_chandung.Image = new LopHoTro.CHUYENKIEU().BinaryToImage(NV.ChanDung);
                    string chitiet = "";
                  //chitiet = "Mã nhân viên: " + NV.MaNV + Environment.NewLine;
                    chitiet += " * Họ tên: " + NV.HoNV + " " + NV.TenNV + Environment.NewLine;
                    chitiet += " * Ngày sinh: " + (NV.NgaySinh !=null? NV.NgaySinh.Value.Date.ToString("dd/MM/yyyy"):"[chưa cập nhật]") + " || Giới tính: " + (NV.GioiTinh == true ? "Nam" : "Nữ") + Environment.NewLine;
                    chitiet += " * CMND: " + (NV.CMND==null?"[chưa cập nhật]":NV.CMND) + " || Ngày cấp: " + (NV.NgayCap != null ? NV.NgayCap.Value.Date.ToString("dd/MM/yyyy") : "[chưa cập nhật]") + " || Nơi cấp: " + (NV.NoiCap!=null?NV.NoiCap:"[chưa cập nhật]") + Environment.NewLine;
                    chitiet += " * Địa chỉ: " + Environment.NewLine+(NV.DiaChi !=null ? "  - " +NV.DiaChi.PadLeft(3) :"[chưa cập nhật]") + Environment.NewLine;

                    dockContainerItem1.Text = "Mã nhân viên: " + NV.MaNV;
                    rtb_chitiet.Text = chitiet;
                    toolTip1.SetToolTip(pic_chandung, NV.HoNV + " " + NV.TenNV);
                }
            }
            else
            {
                dockContainerItem1.Text = "Chi tiết";
                rtb_chitiet.Text = "";
                pic_chandung.Image = null;
            }
        }
        public void bangdieukhien(int tt)
        {
            frm_nhanvien_capnhat frm = null;
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;

            switch (tt)
            {
                case (int)LopHoTro.DIEUKHIEN.them :
                    frm = new frm_nhanvien_capnhat();
                    frm.DuLieu = new frm_nhanvien_capnhat.passData(nhandulieu);
                    frm.ShowDialog();
                    break;

                case (int)LopHoTro.DIEUKHIEN.sua :
                    if (lv_nhanvien.SelectedItems.Count > 0)
                    {
                        frm = new frm_nhanvien_capnhat(lv_nhanvien.SelectedItems[0].Tag.ToString());
                        frm.DuLieu = new frm_nhanvien_capnhat.passData(nhandulieu);
                        frm.ShowDialog();
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần hiệu chỉnh!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)LopHoTro.DIEUKHIEN.xoa :
                    if (lv_nhanvien.SelectedItems.Count > 0)
                    {
                        if (DevComponents.DotNetBar.MessageBoxEx.Show("Xóa dòng đang chọn?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            if (new NHANVIEN_BLL().nhanvien_xoa(lv_nhanvien.SelectedItems[0].Tag.ToString()) > 0)
                            {
                                lv_nhanvien.Items.Remove(lv_nhanvien.SelectedItems[0]);
                            }
                        }
                    }
                    else DevComponents.DotNetBar.MessageBoxEx.Show("Chưa chọn dòng cần xóa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case (int)LopHoTro.DIEUKHIEN.lamtuoi :
                    loc_danhsachnhanvien();
                    break;
            }
        }
        public void tien_lui(int yc)
        {
            switch (yc)
            {
                case (int)tienlui.tien: //tiến
                    vitri = (vitri < tongsotrang-1 ? vitri +1: vitri);
                    break;
                case (int)tienlui.lui: //lùi
                    vitri=(vitri > 0 ? vitri-1 : vitri);
                    break;
            }
            danhsachnhanvien(LST_NHANVIEN);
        }
        //
        #endregion

        #region "Sự kiện"
        //
        private void cbo_gioitinh_SelectIndexChanged(object sender, EventArgs e)
        {
            loc_danhsachnhanvien();
        }
        private void cbo_donvi_SelectIndexChanged(object sender, EventArgs e)
        {
            loc_danhsachnhanvien();
        }
        private void cbo_chucvu_SelectIndexChanged(object sender, EventArgs e)
        {
            loc_danhsachnhanvien();
        }
        private void cbo_tieuchitimkiem_SelectIndexChanged(object sender, EventArgs e)
        {
            loc_danhsachnhanvien();
        }
        private void txt_tukhoa_TextChanged(object sender, EventArgs e)
        {
            loc_danhsachnhanvien();
        }

        //
        private void lv_nhanvien_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_nhanvien.SelectedItems.Count > 0)
            {
                chitietnhanvien();
                lv_nhanvien.ContextMenuStrip = context_menu_btn_dieukhien;
            }
            else lv_nhanvien.ContextMenuStrip = null; 
            
        }
        private void frm_nhanvien_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F6: btn_dieukhien_themmoi_Click(null, null); break;
                case Keys.F7: btn_dieukhien_sua_Click(null, null); break;
                case Keys.Delete: btn_dieukhien_xoachon_Click(null, null); break;
                case Keys.F5: btn_dieukhien_lamtuoi_Click(null, null); break;
                case Keys.Escape: this.Close(); break;
            }
        }
        //
        private void btn_dieukhien_lamtuoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.lamtuoi);
        }
        private void btn_dieukhien_themmoi_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.them);
        }
        private void btn_dieukhien_sua_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.sua);
        }
        private void btn_dieukhien_xoachon_Click(object sender, EventArgs e)
        {
            bangdieukhien((int)LopHoTro.DIEUKHIEN.xoa);
        }


        private void context_menu_btn_suadong_Click(object sender, EventArgs e)
        {
            btn_dieukhien_sua_Click(null, null);
        }
        private void context_menu_btn_xoadong_Click(object sender, EventArgs e)
        {
            btn_dieukhien_xoachon_Click(null, null);
        }

        private void lv_nhanvien_DoubleClick(object sender, EventArgs e)
        {
            btn_dieukhien_sua_Click(null, null);
        }
        private void pic_chandung_DoubleClick(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            diag.Title = "Lưu chân dung";
            diag.FileName = lv_nhanvien.SelectedItems[0].SubItems[1].Text;
            diag.Filter = "File Ảnh (*.jpg)|*.jpg";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                pic_chandung.Image.Save(diag.FileName);
            }
            //btn_dieukhien_sua_Click(null, null);
        }

        //tiến - lùi
        public enum tienlui
        {
            tien=1,
            lui=2,
        }
        private void btn_tien_Click(object sender, EventArgs e)
        {
            tien_lui((int)tienlui.tien);
        }
        private void btn_lui_Click(object sender, EventArgs e)
        {
            tien_lui((int)tienlui.lui);
        }
        //
        private void llbl_tatca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hienthi_tatca();
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            txt_tukhoa.KeyPress += new KeyPressEventHandler(new VietKeyHandler(txt_tukhoa).OnKeyPress);

            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }

        private void cbo_donvi_DrawItem(object sender, DrawItemEventArgs e)
        {
         /*   if (e.Index == -1)
            {
                return;
            }
            //user mouse is hovering over this drop-down item, update its data 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {   // this tooltip simply shows the displayed text to the right of the drop-down  box, customize as needed 
                toolTip1.Show(cbo_donvi.GetItemText(cbo_donvi.Items[e.Index]), cbo_donvi, e.Bounds.Right, e.Bounds.Bottom);
            }
            e.DrawBackground();
            // draw text strings 
            e.Graphics.DrawString(cbo_donvi.Items[e.Index].ToString(), e.Font,
                Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y));
          */
        }

        private void cbo_donvi_DropDownClosed(object sender, EventArgs e)
        {
           toolTip1.Hide(cbo_donvi);
        }

        //
        #endregion
    }
}
