using Hafta4Kapanis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Kapanis.Concrete
{
    internal class Telefon :BaseMakine
    {
        public bool TrLisansliMi { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine(TrLisansliMi ? "Ürün tr lisanslı." : "Ürün tr lisanslı değil.");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }

    }
}
