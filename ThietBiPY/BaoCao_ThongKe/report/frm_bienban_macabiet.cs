using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;

namespace ThietBiPY.BaoCao_ThongKe.report
{
    public partial class frm_bienban_macabiet : DevComponents.DotNetBar.Office2007Form
    {
        ImageList img = new ImageList();

        public frm_bienban_macabiet()
        {
            InitializeComponent();
        }

        public frm_bienban_macabiet(List<string> LST_MaCaBiet)
        {
            InitializeComponent();

            lv_thietbi.LargeImageList  = img;
            lv_thietbi.LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
            lv_thietbi.LargeImageList.ImageSize = new Size(128, 43);
            ListViewItem item = null;
            
            foreach (var str in LST_MaCaBiet)
            {
                Add_List(str);
                item = new ListViewItem(str);
                item.Tag = str;
                item.ImageKey = str;
                lv_thietbi.Items.Add(item);
            }
        }

        public void Add_List(string MaCaBiet)
        {
            Barcode128 code128 = new Barcode128();
            code128.CodeType = Barcode.CODE128;
            code128.ChecksumText = true;
            code128.GenerateChecksum = true;
            code128.StartStopText = true;
            code128.Code = MaCaBiet;
            
            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(code128.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White));
            img.Images.Add(MaCaBiet,bm);
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, this.ClientRectangle);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height)); //Takes the Snap of the Exact WindowForm size as Bitmap image
            e.Graphics.DrawImage(bmp, 0, 0);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void frm_bienban_macabiet_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F11:
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument1;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                    break;
            }
        }

        private void lv_thietbi_DoubleClick(object sender, EventArgs e)
        {
            if (lv_thietbi.SelectedItems.Count > 0)
            {
                DanhMuc.frm_thietbi_thongtinchitiet frm = new ThietBiPY.DanhMuc.frm_thietbi_thongtinchitiet(lv_thietbi.SelectedItems[0].Tag.ToString());
                frm.ShowDialog();
            }
        }
    }
}
