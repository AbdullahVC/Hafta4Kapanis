# **Teknoloji Mağazası - Ürün Kayıt Sistemi**

Bu proje, bir teknoloji mağazasında Telefon ve Bilgisayar gibi ürünlerin kayıt işlemlerini gerçekleştiren bir konsol uygulamasıdır. Uygulama, nesne yönelimli programlama (OOP) prensiplerini kullanarak, ürünlerin özelliklerini saklar ve yönetir.

## **Özellikler**

- **BaseMakine Sınıfı:** 
  - Telefon ve Bilgisayar sınıflarının türediği bir temel sınıftır.
  - Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi gibi ortak özellikleri barındırır.
  - `BilgileriYazdir()` metodu ile bu bilgileri yazdırır.

- **Telefon Sınıfı:** 
  - BaseMakine sınıfından miras alır.
  - Tr Lisanslı olup olmama durumunu ve işletim sistemi özelliklerini içerir.
  - `UrunAdiGetir()` metodu ile "Telefonunuzun adı ---> ..." şeklinde bir mesaj döndürür.

- **Bilgisayar Sınıfı:** 
  - BaseMakine sınıfından miras alır.
  - USB giriş sayısı (2 veya 4 olabilir) ve Bluetooth olup olmama durumunu içerir. 
  - Geçerli olmayan bir USB giriş sayısı girildiğinde uyarı mesajı verilir ve -1 atanır.
  - `UrunAdiGetir()` metodu ile "Bilgisayarınızın adı ---> ..." şeklinde bir mesaj döndürür.

- **Polymorphism:** 
  - Derived sınıflar, Base sınıfın `BilgileriYazdir()` metodunu ezerek kendi özellikleriyle birlikte bilgileri yazdırır.

- **Abstraction:** 
  - BaseMakine sınıfında tanımlanan abstract `UrunAdiGetir()` metodu, Telefon ve Bilgisayar sınıflarında ayrı ayrı ezilmiştir.

## **Kullanım**

1. Uygulama çalıştırıldığında, kullanıcıya telefon üretmek için "1", bilgisayar üretmek için "2" tuşuna basması gerektiği belirtilir.
2. Kullanıcının seçimine göre ilgili sınıftan bir nesne üretilir ve gerekli özellikler konsol üzerinden kullanıcıdan alınır.
3. Tüm bilgiler girildikten sonra ürün başarıyla üretildiğine dair bir mesaj gösterilir.
4. Kullanıcıdan başka bir ürün üretmek isteyip istemediği sorulur. Eğer evet cevabı verilirse tekrar işlem başlatılır, hayır cevabı verilirse uygulama sonlandırılır.

## **Kullanılan Teknolojiler**

- **C# Programlama Dili:** Uygulamanın ana programlama dilidir.
- **Nesne Yönelimli Programlama (OOP):** Projede miras (inheritance), çok biçimlilik (polymorphism), soyutlama (abstraction) ve kapsülleme (encapsulation) gibi OOP prensipleri kullanılmıştır.
- **.NET Core:** Uygulamanın geliştirilmesi için kullanılan platformdur.
