using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama24
{
    public partial class Form1 : Form
    {
        List<Ogrenciler> liste = new List<Ogrenciler>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = int.Parse(txtNumara.Text);
            ogrenci.AdSoyad = txtAdSyd.Text;
            ogrenci.DersNotu = int.Parse(txtDersNotu.Text);
            liste.Add(ogrenci);
            Bagla();
        }

        private void Bagla()
        {
            gridliste.DataSource = null;
            gridliste.DataSource = liste;
        }

        private void gridliste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumara.Text = gridliste.CurrentRow.Cells[0].Value.ToString();
            txtAdSyd.Text = gridliste.CurrentRow.Cells[1].Value.ToString();
            txtDersNotu.Text = gridliste.CurrentRow.Cells[2].Value.ToString();
        }
    }

    class Ogrenciler
    {
        public int Numara { get; set; }
        public string AdSoyad { get; set; }
        public int DersNotu { get; set; }
    }
}   