﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace QuanLiDichVuChoThueXe
{
    public partial class searching : DevExpress.XtraEditors.XtraForm
    {
        public searching()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        QL_ThuexeotoEntities conectdb = new QL_ThuexeotoEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Tên Xe")
            {
                search();
            }
            if (comboBox1.Text == "Loại Xe")
            {             
                var ds = (from av in conectdb.tbl_THONGTINXE
                          join lx in conectdb.tbl_LOAIXE on av.MaLoai equals lx.MaLoai
                          join bl in conectdb.tbl_BANGLAI on lx.MaLoai equals bl.LoaiXe
                          select new { av.SoXe, av.NamSX, av.TenXe, av.DonGiaNgay, av.MaLoai, lx.HangXe, lx.Soluong, bl.YeuCauBangLai }).Where(p => p.MaLoai.Contains(textBox1.Text));
                dataGridView1.DataSource = ds.ToList();

            }
            if (comboBox1.Text == "Hãng Xe")
            {
                var ds = (from av in conectdb.tbl_THONGTINXE
                          join lx in conectdb.tbl_LOAIXE on av.MaLoai equals lx.MaLoai
                          join bl in conectdb.tbl_BANGLAI on lx.MaLoai equals bl.LoaiXe
                          select new { av.SoXe, av.NamSX, av.TenXe, av.DonGiaNgay, av.MaLoai, lx.HangXe, lx.Soluong, bl.YeuCauBangLai }).Where(p => p.HangXe.Contains(textBox1.Text));
                dataGridView1.DataSource = ds.ToList();
            }
            if (comboBox1.Text == "Bằng lái")
            {
                var ds = (from av in conectdb.tbl_THONGTINXE
                          join lx in conectdb.tbl_LOAIXE on av.MaLoai equals lx.MaLoai
                          join bl in conectdb.tbl_BANGLAI on lx.MaLoai equals bl.LoaiXe
                          select new { av.SoXe, av.NamSX, av.TenXe, av.DonGiaNgay, av.MaLoai, lx.HangXe, lx.Soluong, bl.YeuCauBangLai }).Where
                          (p => p.YeuCauBangLai.Contains(textBox1.Text));
                          dataGridView1.DataSource = ds.ToList();

            }
            if (comboBox1.Text == "Bằng lái")
            {
                var ds = (from av in conectdb.tbl_THONGTINXE
                          join lx in conectdb.tbl_LOAIXE on av.MaLoai equals lx.MaLoai
                          join bl in conectdb.tbl_BANGLAI on lx.MaLoai equals bl.LoaiXe
                          select new { av.SoXe, av.NamSX, av.TenXe, av.DonGiaNgay, av.MaLoai, lx.HangXe, lx.Soluong, bl.YeuCauBangLai }).Where
                          (p => p.YeuCauBangLai.Contains(textBox1.Text));
                dataGridView1.DataSource = ds.ToList();

            }
            if (comboBox1.Text == "Số Xe")
            {
                var ds = (from av in conectdb.tbl_THONGTINXE
                          join lx in conectdb.tbl_LOAIXE on av.MaLoai equals lx.MaLoai
                          join bl in conectdb.tbl_BANGLAI on lx.MaLoai equals bl.LoaiXe
                          select new { av.SoXe, av.NamSX, av.TenXe, av.DonGiaNgay, av.MaLoai, lx.HangXe, lx.Soluong, bl.YeuCauBangLai }).Where
                          (p => p.SoXe.Contains(textBox1.Text));
                dataGridView1.DataSource = ds.ToList();

            }


        }
        private void search()
        {
            var ds = (from av in conectdb.tbl_THONGTINXE
                      join lx in conectdb.tbl_LOAIXE on av.MaLoai equals lx.MaLoai
                      join bl in conectdb.tbl_BANGLAI on lx.MaLoai equals bl.LoaiXe
                      select new { av.SoXe, av.NamSX, av.TenXe, av.DonGiaNgay, av.MaLoai, lx.HangXe, lx.Soluong, bl.YeuCauBangLai }).Where(p => p.TenXe.Contains(textBox1.Text.Trim()));
            dataGridView1.DataSource = ds.ToList();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Controls.Clear();
        }

        private void searching_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            var ds = (from av in conectdb.tbl_THONGTINXE
                      join lx in conectdb.tbl_LOAIXE on av.MaLoai equals lx.MaLoai
                      join bl in conectdb.tbl_BANGLAI on lx.MaLoai equals bl.LoaiXe
                      select new { av.SoXe, av.NamSX, av.TenXe, av.DonGiaNgay, av.MaLoai, lx.HangXe, lx.Soluong, bl.YeuCauBangLai });
            dataGridView1.DataSource = ds.ToList();
        }
    }
}
