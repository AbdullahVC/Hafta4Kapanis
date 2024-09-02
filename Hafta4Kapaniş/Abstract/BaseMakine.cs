using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Kapanis.Abstract
{
    internal abstract class BaseMakine
    {
        protected BaseMakine()
        {
            UretimTarihi = DateTime.Now;   
        }
        public DateTime UretimTarihi { get; set; }
        public string SerialNum { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }
        public virtual void BilgileriYazdir ()
        {
            Console.WriteLine($"Ürünün üretim tarihi = {UretimTarihi}");
            Console.WriteLine($"Ürünün seri numarası = {SerialNum}");
            Console.WriteLine($"Ürünün adı = {Ad}");
            Console.WriteLine($"Ürünün açıklaması = {Aciklama}");
            Console.WriteLine($"Ürünün işletim sistemi = {IsletimSistemi}");
        }
        public abstract void UrunAdiGetir();





    }
}
