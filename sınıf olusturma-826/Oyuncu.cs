using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_olusturma_826
{
    internal class Oyuncu
    {
        public string Id { get; set; }
        public string Ad { get; set; }
        public String Soyad { get; set; }
        public string Posta { get; set; }
        public double Puan { get; set; }
        public DateTime KayitTarihi { get; set; }   
        public bool  Aktif { get; set; }    
    }
}
