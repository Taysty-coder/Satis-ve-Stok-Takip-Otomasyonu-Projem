using Proje_Odevim.DAL;
using Proje_Odevim.Domain;
using Proje_Odevim.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Odevim
{
    public partial class StokveSatişTakipGiriş : Form
    {
        public StokveSatişTakipGiriş()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string kadi = txtkullaniciAdi.Text;
            string sifre = txtSifre.Text;

            Proje_Odevim.DAL.kullaniciDAO dal = new Proje_Odevim.DAL.kullaniciDAO();
            string gelenRol = dal.GirisKontrol(kadi, sifre);

            if (gelenRol != "")
            {
                MessageBox.Show("Hoşgeldiniz! Rolünüz: " + gelenRol);

               
                AnaMenuForm menu = new AnaMenuForm();
                menu.kullaniciRolu = gelenRol; 
                menu.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }
    }
}
