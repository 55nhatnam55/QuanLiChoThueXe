using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiDichVuChoThueXe
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDoiMatKhau f1 = new FormDoiMatKhau();
            f1.MdiParent = this;
            f1.Show();
        }

        private void barDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLogin f1 = new FormLogin();
            f1.MdiParent = this;
            f1.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Session.id == 2)
            {
                ribbonPage1.Visible = false;
              
            }         
        }

        private void btnLapPhieuThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            phieuthue f1 = new phieuthue();
            f1.MdiParent = this;
            f1.Show();
        }

        private void btnPhieuThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            thanhtoan f1 = new thanhtoan();
            f1.MdiParent = this;
            f1.Show();
        }

        private void btnTraCuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            searching f1 = new searching();
            f1.MdiParent = this;
            f1.Show();
        }

        private void btnXemDanhSachXeChoThue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            danhsachthuexe f1 = new danhsachthuexe();
            f1.MdiParent = this;
            f1.Show();
        }

        private void btnNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinNguoiDung f1 = new frmThongTinNguoiDung();
            f1.MdiParent = this;
            f1.Show();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Session.id = -1;
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            this.Close();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormThongTinKhacHang f1 = new FormThongTinKhacHang();
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
