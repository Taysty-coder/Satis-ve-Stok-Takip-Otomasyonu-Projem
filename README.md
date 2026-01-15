# 📦 Stok ve Satış Takip Sistemi (N-Tier Architecture)

Bu proje, küçük ve orta ölçekli işletmelerin ürün, müşteri ve satış süreçlerini dijital ortamda yönetebilmesi için **C# WinForms** kullanılarak geliştirilmiştir. Proje, **Yönetim Bilişim Sistemleri (YBS)** prensiplerine uygun olarak raporlama ve veri analizi odaklı tasarlanmıştır.

---

## 📺 Proje Demo Videosu
Uygulamanın çalışma mantığını ve arayüzünü buradan izleyebilirsiniz:
[![YouTube İzle](https://img.shields.io/badge/YouTube-İzle-red?style=for-the-badge&logo=youtube)](https://youtu.be/aQdzXtGIhWs)

---

## ✨ Öne Çıkan Özellikler

### 🛡️ Yetkilendirme ve Rol Yönetimi
* **Yönetici:** Tüm sisteme erişim, tam yetkili raporlama ve yönetim.
* **Satış Personeli:** Satış yapma ve ürün listeleme yetkisi.
* **Depo Görevlisi:** Ürün ekleme, stok güncelleme ve envanter yönetimi.

### 📊 Akıllı Raporlama Modülleri
* **Kâr/Zarar Analizi:** Alış ve satış fiyatları üzerinden anlık finansal durum hesaplama.
* **En Çok Satanlar:** Ürün bazlı satış performans analizi.
* **Kritik Stok Yönetimi:** Stok miktarı, belirlenen `min_stok` limitinin altına düşen ürünlerin otomatik olarak **kırmızı** ile vurgulanması.
* **Ciro Takibi:** Toplam satış tutarlarının anlık izlenmesi.

---

## 🏗️ Teknik Mimari (N-Katmanlı Yapı)

Proje, kodun okunabilirliği ve bakımı için 3 ana katman üzerine kurulmuştur:

1.  **Presentation Layer (UI):** Kullanıcı arayüzü (Forms).
2.  **Business Logic Layer (Service):** İş kurallarının (Stok kontrolü, yetkilendirme vb.) kontrol edildiği katman.
3.  **Data Access Layer (DAL):** MySQL veritabanı ile ham SQL sorgularının yönetildiği katman (DAO sınıfları).

---

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C# (.NET Framework)
* **Veritabanı:** MySQL
* **Mimari:** N-Tier (Katmanlı Mimari)
* **Kavramlar:** OOP (Encapsulation, Classes, List Structures), CRUD İşlemleri.

---

## 🗄️ Veritabanı Yapısı

Sistem aşağıdaki 4 temel tablo üzerinden yönetilmektedir:
* `urunler`: Ürün detayları, fiyatlandırma ve stok limitleri.
* `satislar`: Satış transaction kayıtları ve tarihsel veri.
* `musteriler`: Perakende/Toptan müşteri kayıtları.
* `kullanicilar`: Kullanıcı giriş bilgileri ve yetki rolleri.

---

## ⚙️ Kurulum ve Çalıştırma

1.  Veritabanı bağlantı adresini (IP/Kullanıcı adı/Şifre) `DAL` katmanındaki DAO sınıfları içerisinden kendi sunucunuza göre güncelleyin.
2.  MySQL üzerinde `26_132430028` (veya kendi belirlediğiniz isimle) bir veritabanı oluşturun.
3.  Projeyi Visual Studio ile açın ve `Build` ederek çalıştırın.

---

## 👨‍💻 Geliştirici
**Gökhan Lermi** *Yönetim Bilişim Sistemleri (YBS) Öğrencisi*

---
> [!IMPORTANT]
> Bu proje eğitim amaçlı geliştirilmiş olup, MySQL bağlantı güvenliği ve OOP katmanlı mimari mantığını pekiştirmek için tasarlanmıştır.
