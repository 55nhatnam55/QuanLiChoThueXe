using DevExpress.XtraEditors;
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
        private bool ExistForm(XtraForm form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
           
        }
        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new FormDoiMatKhau();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
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
            var form = new phieuthue();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();

        }

        private void btnPhieuThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new thanhtoan();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnTraCuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new searching();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnXemDanhSachXeChoThue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new danhsachthuexe();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void btnNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmThongTinNguoiDung();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
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
            var form = new FormThongTinKhacHang();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new FrmBaoCao();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
    }
}
