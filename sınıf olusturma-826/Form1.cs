using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıf_olusturma_826
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSoyad_Click(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.Id = "12545245755454";
            oyuncu1.Ad = "kübra";
            oyuncu1.Soyad = "tas";
            oyuncu1.Posta = "kubra_tas_2008gmail.com";
            oyuncu1.Puan = 100;
            oyuncu1.KayitTarihi = DateTime.Now;
            oyuncu1.Aktif = false;

            MessageBox.Show("Ad:" + oyuncu1.Ad + "\nPuan:"
                                  + oyuncu1.Puan + "\nAktif :"
                                  + oyuncu1.Aktif);
        }
    }
}
