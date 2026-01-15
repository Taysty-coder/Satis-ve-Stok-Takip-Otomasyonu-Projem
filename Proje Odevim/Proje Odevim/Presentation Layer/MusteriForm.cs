using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Odevim.Presentation_Layer
{
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        private void MusteriForm_Load(object sender, EventArgs e)

        {
            cmbTur.SelectedIndex = 0;
            Guncelle();
        }
       
        public void Guncelle()
        {
            Proje_Odevim.Service.musteriService servis = new Proje_Odevim.Service.musteriService();

           
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = servis.MusteriListesiGetir();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Proje_Odevim.Domain.musteri yeniMusteri = new Proje_Odevim.Domain.musteri();
            yeniMusteri.Ad = txtAd.Text;
            yeniMusteri.Soyad = txtSoyad.Text;
            yeniMusteri.Telefon = txtTel.Text;
            yeniMusteri.Tur = cmbTur.Text;

            // 2. Servisi çağır ve kaydet
            Proje_Odevim.Service.musteriService servis = new Proje_Odevim.Service.musteriService();
            servis.Kaydet(yeniMusteri);

            MessageBox.Show("Müşteri Kaydedildi!");
            Guncelle(); 
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int seciliId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            Proje_Odevim.Service.musteriService servis = new Proje_Odevim.Service.musteriService();
            servis.Sil(seciliId);

            MessageBox.Show("Müşteri Silindi!");
            Guncelle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbTur.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            
          
            int seciliId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

           
            Proje_Odevim.Domain.musteri m = new Proje_Odevim.Domain.musteri();
            m.Id = seciliId; 
            m.Ad = txtAd.Text;
            m.Soyad = txtSoyad.Text;
            m.Telefon = txtTel.Text;
            m.Tur = cmbTur.Text;

            
            Proje_Odevim.Service.musteriService servis = new Proje_Odevim.Service.musteriService();
            servis.Guncelle(m);

            MessageBox.Show("Müşteri bilgileri güncellendi!");

            // 4. Listeyi yenile ki değişikliği hemen gör
            Guncelle();
            dataGridView1.DataSource = servis.MusteriListesiGetir();
            lblToplam.Text = "Toplam Müşteri Sayısı: " + dataGridView1.Rows.Count.ToString();
        }
    }
}
