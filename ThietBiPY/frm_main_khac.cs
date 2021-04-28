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
using ThietBiPY.BaoCao_ThongKe.thongkethietbi;
using ThietBiPY.NghiepVu;
using ThietBiPY.DanhMuc;
using ThietBiPY.HeThong;
using ThietBiPY.BaoCao_ThongKe;
using ThietBiPY.LopHoTro;

namespace ThietBiPY
{
    public partial class frm_main_khac : DevComponents.DotNetBar.Office2007Form
    {
        HETHONGBLL HETHONG = new HETHONGBLL();
        int DonVi = 0;
        public int quyen = 0;

        public frm_main_khac()
        {
            InitializeComponent();
            lv_thongtinchung.Columns.Add("", lv_thongtinchung.Width - 2);
            //
            status_btn_tenserver.Text = "Server: " + HETHONG.TenServer();
            status_btn_tencsdl.Text = "CSDL: " + HETHONG.TenCSDL();

            string TenPC = HETHONG.TenPC();
            status_btn_tenpc.Text = TenPC;
            status_btn_tentaikhoan.Text = "Tài khoản: " + HETHONG.TenTaiKhoan();
            status_btn_tenpc.Tooltip = "Tên PC : " + TenPC.Substring(0, TenPC.IndexOf(':')) + Environment.NewLine + "Địa chỉ MAC: " + TenPC.Substring(TenPC.IndexOf(':') + 1);

            //
            status_btn_date.Text = "Date: " + DateTime.Now.Date.ToString("dd/MM/yyyy");
            Timer status_time = new Timer();
            status_time.Interval = 1000;
            status_time.Start();
            status_time.Tick += new EventHandler(Time_Tick);

            //
            var NV = new NGUOIDUNG_BLL().nguoidung_thongtin_TK(HETHONG.TenTaiKhoan());
            this.DonVi = NV.NHANVIEN.DonViID;

            this.Text = "Đơn vị: " + (NV.NHANVIEN.DonViID != 0 ? NV.NHANVIEN.DONVI.TenDonVi : "Chưa xác định");
            status_btn_tentaikhoan.Tooltip = "Họ tên: " + NV.NHANVIEN.HoNV + " " + NV.NHANVIEN.TenNV+Environment.NewLine+
                "Quyền truy cập: "+(NV.Quyen==2?"Quản lý thiết bị đơn vị":"Nhân viên đơn vị");
            btn_menuphai_lamtuoi_Click(null, null);

            //
            PHANQUYEN.quyen = NV.Quyen;
            switch (PHANQUYEN.quyen)
            {
                case (int)QUYEN.nhanviendonvi:
                    btn_bangiaothietbi.Visible = false;
                    btn_danhgialaithietbi.Visible = false;
                    btn_themthietbi.Visible = false;
                    break;
            }
        }

        //Các hàm khác
        public void Time_Tick(object sender, EventArgs e)
        {
            status_btn_time.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_menuphai_lamtuoi_Click(object sender, EventArgs e)
        {
            danhmuc_bophan();
            thongtinchung();
        }
        private void danhmuc_bophan()
        {
            trv_bophan.Nodes.Clear();
            TreeNode nutgoc = new TreeNode(new DONVI_BLL().donvi_thongtin (DonVi.ToString()).TenDonVi);
            TreeNode nutcha = null;
            foreach (var BP in new BOPHAN_BLL().bophan_danhsach().Where(c => c.DonViID == DonVi).ToList())
            {
                nutcha = new TreeNode(BP.TenBoPhan);
                nutcha.Tag = BP.BoPhanID.ToString();
                nutgoc.Nodes.Add(nutcha);
            }
            nutgoc.ExpandAll();
            trv_bophan.Nodes.Add(nutgoc);
        }
        private void thongtinchung()
        {
            lv_thongtinchung.Items.Clear();
            ListViewItem item = null;
            item = new ListViewItem("Tổng số:" + new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.DonViSD == DonVi).Count().ToString());
            lv_thongtinchung.Items.Add(item);

            var TK_TT = from c in (new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c=>c.DonViSD==DonVi).Select(c => new
            {
                TinhTrang = c.TinhTrang,
                BoPhanSD = c.BoPhanSD,
            }).GroupBy(gr => gr.TinhTrang)
            .Select(k => new { TinhTrang = k.Key, SoLuong = k.Count() }).ToList())
                        join tt in new TINHTRANG_BLL().tinhtrang_danhsach() on c.TinhTrang equals tt.TinhTrangID
                        select new
                        {
                            TenTinhTrang=c.TinhTrang!=0?tt.TenTinhTrang:"Chưa xác định",
                            SoLuong=c.SoLuong,
                        };

            foreach (var TT in TK_TT.ToList())
            {
                item = new ListViewItem(TT.TenTinhTrang + ":" + TT.SoLuong.ToString());
                lv_thongtinchung.Items.Add(item);
            }

        }

        //
        private void btn_thongkethietbi_theobophan_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_thongke_thietbi_theonoisudung"))
                {
                    f.Activate(); return;
                }
            }
            frm_thongke_thietbi_theonoisudung frm = new frm_thongke_thietbi_theonoisudung(DonVi);
            frm.Text = "Thống kê theo bộ phận";
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_danhgialaithietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_danhgialaithietbi"))
                {
                    f.Activate(); return;
                }
            }
            frm_danhgialaithietbi frm = new frm_danhgialaithietbi(DonVi.ToString());
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_themthietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_giaonhanthietbi_capnhat"))
                {
                    f.Activate(); return;
                }
            }
            frm_giaonhanthietbi_capnhat frm = new frm_giaonhanthietbi_capnhat(DonVi);
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        private void btn_bangiaothietbi_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_bangiaothietbi_capnhat"))
                {
                    f.Activate(); return;
                }
            }
            frm_bangiaothietbi_capnhat frm = new frm_bangiaothietbi_capnhat(DonVi);
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        //
        private void btn_timkiem_thongtinthietbi_Click(object sender, EventArgs e)
        {
            string macabiet = "";
            if (new HOPTHOAI().InputBox(DonVi, "", "nhập mã cá biệt", ref macabiet) == DialogResult.OK)
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name.Equals("frm_thietbi_thongtinchitiet" + macabiet)) { f.Activate(); return; }
                }

                frm_thietbi_thongtinchitiet frm = new frm_thietbi_thongtinchitiet(macabiet);
                frm.WindowState = FormWindowState.Maximized;
                frm.MdiParent = this;
                frm.Show();
            }
        }
        private void btn_thongkethietbi_bangiao_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals("frm_hoso_bangiaothietbi"))
                {
                    f.Activate(); return;
                }
            }
            frm_hoso_bangiaothietbi frm = new frm_hoso_bangiaothietbi(DonVi);
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        //
        private void btn_hethong_dangnhaplai_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void btn_hethong_thoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.MessageBoxEx.EnableGlass = false;
            if (DevComponents.DotNetBar.MessageBoxEx.Show("Thoát chương trình!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
        private void btn_hethong_thaydoimatkhau_Click(object sender, EventArgs e)
        {
            frm_nguoidung frm = new frm_nguoidung("doimatkhau");
            frm.ShowDialog();
        }

        //
    }
}

public class HOPTHOAI
{
    public DialogResult InputBox(int DonVi, string title, string promptText, ref string value)
    {
        //Form form = new Form();

        DevComponents.DotNetBar.Office2007Form form = new DevComponents.DotNetBar.Office2007Form();
        DevComponents.DotNetBar.LabelX label = new DevComponents.DotNetBar.LabelX();

        DevComponents.DotNetBar.Controls.TextBoxX textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
        DevComponents.DotNetBar.ButtonX buttonOk = new DevComponents.DotNetBar.ButtonX();
        DevComponents.DotNetBar.ButtonX buttonCancel = new DevComponents.DotNetBar.ButtonX();

        AutoCompleteStringCollection Str_Col = new AutoCompleteStringCollection();
        var LST = (from gttb in new GTTHIETBI_BLL().gtthietbi_danhsach()
                   join std in new SOTHEODOI_BLL().sotheodoi_danhsach().Where(c => c.DonViSD == DonVi) on gttb.GTThietBiID equals std.GTThietBiID
                   select new { MaCaBiet = gttb.MaCaBiet }).ToList();

        foreach (var str in LST.Skip(0).Take(10).ToList())
        {
            Str_Col.Add(str.MaCaBiet);
        }
        textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
        textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        textBox.AutoCompleteCustomSource = Str_Col;

        form.EnableGlass = false;
        form.Text = title;
        label.Text = promptText;
        textBox.Text = value;
        textBox.CharacterCasing = CharacterCasing.Upper;

        buttonOk.Text = "Xem";
        buttonCancel.Text = "Đóng";
        buttonOk.DialogResult = DialogResult.OK;
        buttonCancel.DialogResult = DialogResult.Cancel;

        label.SetBounds(9, 20, 372, 13);
        textBox.SetBounds(12, 36, 372, 20);
        buttonOk.SetBounds(228, 72, 75, 23);
        buttonCancel.SetBounds(309, 72, 75, 23);

        label.AutoSize = true;
        textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
        buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

        form.ClientSize = new Size(396, 107);
        form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
        form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
        form.FormBorderStyle = FormBorderStyle.FixedDialog;
        form.StartPosition = FormStartPosition.CenterScreen;
        form.MinimizeBox = false;
        form.MaximizeBox = false;
        form.AcceptButton = buttonOk;
        form.CancelButton = buttonCancel;


        DialogResult dialogResult = form.ShowDialog();
        value = textBox.Text;
        return dialogResult;
    }
}