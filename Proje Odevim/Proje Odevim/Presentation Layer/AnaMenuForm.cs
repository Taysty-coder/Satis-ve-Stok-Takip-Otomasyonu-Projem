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
    public partial class AnaMenuForm : Form
    {
        public AnaMenuForm()
        {
            InitializeComponent();
        }
        public string kullaniciRolu;
        private void AnaMenuForm_Load(object sender, EventArgs e)
        {
            if (kullaniciRolu == "Satış Personeli") 
            {
               
                          
                btnRaporlama.Enabled = false;
                btnUrunYonetimi.Enabled = true; 

                btnSatisEkrani.Enabled = true;
                btnMusteriYonetimi.Enabled = false;
            }
            else if (kullaniciRolu == "Depo") 
            {
                btnSatisEkrani.Enabled = false;
                btnRaporlama.Enabled = false;
                btnMusteriYonetimi.Enabled = false;
                btnUrunYonetimi.Enabled = true;
            }
            else if (kullaniciRolu == "Yönetici") 
            {
                
             
                btnUrunYonetimi.Enabled = true;
                btnMusteriYonetimi.Enabled = true;
                btnSatisEkrani.Enabled = true;
                btnRaporlama.Enabled = true;
            }

        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            MusteriForm frm = new MusteriForm();
            frm.Show();
        }

        public static void UygulamayiKapat()
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinizden eminmisiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }   

        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            AnaMenuForm.UygulamayiKapat();
        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            
            Presentation_Layer.UrunForm frm = new Presentation_Layer.UrunForm();
            frm.Show(); 
        }

        private void AnaMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSatisEkrani_Click(object sender, EventArgs e)
        {
            satisekrani frmSatis = new satisekrani();

            frmSatis.Show();

        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            RaporlamaEkrani frmrapor = new RaporlamaEkrani();

            frmrapor.Show();
        }
    }
}
