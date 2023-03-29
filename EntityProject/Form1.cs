﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATEGORI.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI kategoriTable = new TBLKATEGORI();
            kategoriTable.AD = textBox2.Text;
            db.TBLKATEGORI.Add(kategoriTable);
            db.SaveChanges();
            MessageBox.Show("Kategori eklendi.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATEGORI.Find(x);
            db.TBLKATEGORI.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TBLKATEGORI.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme yapılmıştır.");
        }
    }
}
