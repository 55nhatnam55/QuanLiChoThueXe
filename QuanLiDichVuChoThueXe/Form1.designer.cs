﻿namespace QuanLiDichVuChoThueXe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.btnXemDanhSachXeChoThue = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLapPhieuThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuThanhToan = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraCuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnCauHinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnDangNhap = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.barDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barMdiChildrenListItem2 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh Mục";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnNguoiDung);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Danh Mục";
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.Caption = "Quản lí tài khoản nhân viên";
            this.btnNguoiDung.Id = 8;
            this.btnNguoiDung.ImageOptions.LargeImage = global::QuanLiDichVuChoThueXe.Properties.Resources.user_male_icon;
            this.btnNguoiDung.LargeWidth = 100;
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNguoiDung_ItemClick);
            // 
            // btnXemDanhSachXeChoThue
            // 
            this.btnXemDanhSachXeChoThue.Caption = "Danh Sách Xe Cho Thuê";
            this.btnXemDanhSachXeChoThue.Id = 9;
            this.btnXemDanhSachXeChoThue.ImageOptions.LargeImage = global::QuanLiDichVuChoThueXe.Properties.Resources.Sportscar_car_icon;
            this.btnXemDanhSachXeChoThue.LargeWidth = 100;
            this.btnXemDanhSachXeChoThue.Name = "btnXemDanhSachXeChoThue";
            this.btnXemDanhSachXeChoThue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXemDanhSachXeChoThue_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Chức Năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLapPhieuThu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhieuThanhToan);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTraCuu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnXemDanhSachXeChoThue);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Chức Năng";
            // 
            // btnLapPhieuThu
            // 
            this.btnLapPhieuThu.Caption = "Lập Phiếu Thu";
            this.btnLapPhieuThu.Id = 1;
            this.btnLapPhieuThu.ImageOptions.LargeImage = global::QuanLiDichVuChoThueXe.Properties.Resources.add_event_icon;
            this.btnLapPhieuThu.LargeWidth = 100;
            this.btnLapPhieuThu.Name = "btnLapPhieuThu";
            this.btnLapPhieuThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapPhieuThu_ItemClick);
            // 
            // btnPhieuThanhToan
            // 
            this.btnPhieuThanhToan.Caption = "Lập Phiếu Thanh Toán";
            this.btnPhieuThanhToan.Id = 5;
            this.btnPhieuThanhToan.ImageOptions.LargeImage = global::QuanLiDichVuChoThueXe.Properties.Resources.Open_Folder_Add_icon;
            this.btnPhieuThanhToan.LargeWidth = 100;
            this.btnPhieuThanhToan.Name = "btnPhieuThanhToan";
            this.btnPhieuThanhToan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuThanhToan_ItemClick);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Caption = "Tra Cứu";
            this.btnTraCuu.Id = 7;
            this.btnTraCuu.ImageOptions.LargeImage = global::QuanLiDichVuChoThueXe.Properties.Resources.Start_Menu_Search_icon;
            this.btnTraCuu.LargeWidth = 100;
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraCuu_ItemClick);
            // 
            // btnCauHinh
            // 
            this.btnCauHinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.btnDangNhap});
            this.btnCauHinh.Name = "btnCauHinh";
            this.btnCauHinh.Text = "Hệ Thống";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ItemLinks.Add(this.btnDangXuat);
            this.btnDangNhap.ItemLinks.Add(this.btnDoiMatKhau);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Text = "Hệ Thống";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng Xuất";
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.ImageOptions.LargeImage = global::QuanLiDichVuChoThueXe.Properties.Resources.Logout_icon;
            this.btnDangXuat.LargeWidth = 100;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.Id = 4;
            this.btnDoiMatKhau.ImageOptions.LargeImage = global::QuanLiDichVuChoThueXe.Properties.Resources.img_557896;
            this.btnDoiMatKhau.LargeWidth = 100;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // barDangNhap
            // 
            this.barDangNhap.Caption = "Đăng Nhập";
            this.barDangNhap.Id = 2;
            this.barDangNhap.ImageOptions.LargeImage = global::QuanLiDichVuChoThueXe.Properties.Resources.Login_icon;
            this.barDangNhap.LargeWidth = 100;
            this.barDangNhap.Name = "barDangNhap";
            this.barDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDangNhap_ItemClick);
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 11;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barMdiChildrenListItem2
            // 
            this.barMdiChildrenListItem2.Caption = "barMdiChildrenListItem2";
            this.barMdiChildrenListItem2.Id = 12;
            this.barMdiChildrenListItem2.Name = "barMdiChildrenListItem2";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLapPhieuThu,
            this.barDangNhap,
            this.btnDangXuat,
            this.btnDoiMatKhau,
            this.btnPhieuThanhToan,
            this.btnTraCuu,
            this.btnNguoiDung,
            this.btnXemDanhSachXeChoThue,
            this.barMdiChildrenListItem1,
            this.barMdiChildrenListItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.btnCauHinh,
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản Lý Dịch Vụ Cho Thuê Xe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnXemDanhSachXeChoThue;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnLapPhieuThu;
        private DevExpress.XtraBars.BarButtonItem btnPhieuThanhToan;
        private DevExpress.XtraBars.BarButtonItem btnTraCuu;
        private DevExpress.XtraBars.Ribbon.RibbonPage btnCauHinh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem barDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}
