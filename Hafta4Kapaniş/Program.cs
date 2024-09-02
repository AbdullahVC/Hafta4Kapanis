using Hafta4Kapanis.Concrete;


bool baskaVeriGirilecekMi = true;

while (baskaVeriGirilecekMi)
{

tercih:
    Console.WriteLine("Telefon - Bilgisayar Üretim Merkezine Hoşgeldiniz");
    Console.WriteLine("Telefon Üretmek için --> 1\n" +
    "Bilgisayar üretimi içi -->2 tıklayın.");
    int tercih = Convert.ToInt32(Console.ReadLine());

    if (tercih == 1)
    {
        Telefon yeniTelefon = new Telefon();

        Console.WriteLine("Telefonun seri numarasını girin:");
        yeniTelefon.SerialNum = Console.ReadLine();

        Console.WriteLine("Telefonun adını girin:");
        yeniTelefon.Ad = Console.ReadLine();

        Console.WriteLine("Telefonun açıklamasını girin:");
        yeniTelefon.Aciklama = Console.ReadLine();

        Console.WriteLine("Telefonun işletim sistemini girin:");
        yeniTelefon.IsletimSistemi = Console.ReadLine();

        Console.WriteLine("Telefonun türkiye lisansı var mı ?");
        yeniTelefon.TrLisansliMi = Convert.ToBoolean(Console.ReadLine());

    }
    else if (tercih == 2)
    {
        Bilgisayar yeniBilgisayar = new Bilgisayar();

        Console.WriteLine("Bilgisayarın seri numarasını girin:");
        yeniBilgisayar.SerialNum = Console.ReadLine();

        Console.WriteLine("Bilgisayarın adını girin:");
        yeniBilgisayar.Ad = Console.ReadLine();

        Console.WriteLine("Bilgisayarın açıklamasını girin:");
        yeniBilgisayar.Aciklama = Console.ReadLine();

        Console.WriteLine("Bilgisayarın işletim sistemini girin:");
        yeniBilgisayar.IsletimSistemi = Console.ReadLine();

        Console.WriteLine("Bilgisayarın usb giriş sayısını girin:");
        yeniBilgisayar.UsbGirisSayisi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bilgisayarın bluetooth var mı ?");
        yeniBilgisayar.BluetoothVarMi = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Üretmek istediğiniz bilgisayar aşşağıdaki özlliklerle oluşturuldu.");
        yeniBilgisayar.BilgileriYazdir();





    }
    else
    {

        Console.WriteLine("Yanlış bir sayı girdiniz.");
        goto tercih;

    }

    tercih2:
    Console.WriteLine("Başka bir ürün daha üretmek ister misiniz ? (e / h )");
    string cevap = Console.ReadLine();
    if (cevap == "e")
    {

    }
    else if (cevap == "h")
    {
        baskaVeriGirilecekMi = false;
    }
    else 
    {

        Console.WriteLine("Hatalı giriş");
        goto tercih2;

    }



}

