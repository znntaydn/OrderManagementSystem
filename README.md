Ürün Sipariş Yönetimi Otomasyonu
Bu proje, C# ve SQL veritabanı kullanarak geliştirilmiş bir ürün sipariş yönetimi otomasyonudur. Uygulama, müşterilerin, ürünlerin ve siparişlerin yönetimini kolaylaştırmak amacıyla tasarlanmıştır.

Özellikler
* Müşteri Yönetimi: Müşteri ekleme, listeleme, güncelleme ve silme işlemleri.
* Ürün Yönetimi: Ürün ekleme, listeleme, güncelleme ve silme işlemleri.
* Sipariş Yönetimi: Sipariş ekleme, listeleme, güncelleme ve silme işlemleri.

Kurulum

Gereksinimler

# Visual Studio
# SQL Server

Adımlar
1.Proje Dosyalarını İndirin veya Klonlayın
git clone https://github.com/kullaniciadi/OrderManagementSystem.git

2.Veritabanını Kurun
ProjelerVTEntities.sql dosyasını kullanarak SQL Server'da veritabanınızı oluşturun.

3.Visual Studio'da Projeyi Açın
OrderManagementSystem.sln dosyasını Visual Studio'da açın.

4.Bağlantı Dizesini Ayarlayın
App.config dosyasındaki veritabanı bağlantı dizesini kendi veritabanı bilgilerinizle güncelleyin.

Kullanım

Form1
Bu ana formdur. Ürün, müşteri ve sipariş formlarına erişim sağlar.

 # Ürün Formu (UrunForm)
   * Tüm ürünleri listeleme
   * Yeni ürün ekleme
   * Ürün güncelleme
   * Ürün silme
   * Müşteri Formu (MusteriForm)

# Tüm müşterileri listeleme
   * Yeni müşteri ekleme
   * Müşteri güncelleme
   * Müşteri silme

# Sipariş Formu (SiparisForm)
  * Tüm siparişleri listeleme
  * Yeni sipariş ekleme
  * Sipariş güncelleme
  * Sipariş silme
  
Kod Dosyaları
* Form1.cs: Ana form ve diğer formlara erişim.
* UrunForm.cs: Ürün yönetimi formu.
* MusteriForm.cs: Müşteri yönetimi formu.
* SiparisForm.cs: Sipariş yönetimi formu.

Lisans
Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için LICENSE dosyasına bakın.

