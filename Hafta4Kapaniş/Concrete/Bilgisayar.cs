using Hafta4Kapanis.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Kapanis.Concrete
{
    internal class Bilgisayar :BaseMakine
    {
        int _usbGirisSayisi;
        public int UsbGirisSayisi 
        {
            get 
            {
            return _usbGirisSayisi;
            }
            set
            { 
                if (value ==2 ||  value ==4)
                    _usbGirisSayisi = value;
                else
                { 
                    _usbGirisSayisi = -1;
                    Console.WriteLine("Usb giriş sayısı hatalı.");
                }
            }   
        }
        public bool BluetoothVarMi { get; set; }
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Ürünün usb giriş sayısı = {UsbGirisSayisi}");
            Console.WriteLine(BluetoothVarMi ? "Bluetooth var." : "Bluetooth yok.");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }

    }
}
