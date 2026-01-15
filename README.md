# 📦 Gelişmiş Stok, Satış ve Envanter Yönetim Sistemi

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-00000f?style=for-the-badge&logo=mysql&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

Bu proje, bir işletmenin tüm ticari döngüsünü (Satın alma, stok yönetimi, müşteri ilişkileri ve satış analizi) dijitalleştirmek amacıyla geliştirilmiş, **N-Katmanlı Mimari (N-Tier Architecture)** tabanlı bir masaüstü uygulamasıdır. Akademik bir çalışma olarak tasarlanmış olup, kurumsal yazılım geliştirme standartlarını (Clean Code, OOP, Separation of Concerns) temel alır.

---

## 📽️ Uygulama Tanıtımı ve Demo
Sistemin tüm fonksiyonlarını ve kullanıcı akışlarını aşağıdaki bağlantıdan izleyebilirsiniz:

[![Proje Demo Videosu](https://img.shields.io/badge/YouTube-Video_Demo-red?style=for-the-badge&logo=youtube)](https://youtu.be/aQdzXtGIhWs)

---

## 📋 Proje Vizyonu ve YBS Yaklaşımı
Bu yazılım sadece bir "kayıt tutma" aracı değil, bir **Karar Destek Sistemi (DSS)** niteliğindedir. Yönetim Bilişim Sistemleri (YBS) prensipleri gereği:
- **Veri Doğruluğu:** Stoklar eksiye düşmez, satış anında veritabanı bütünlüğü korunur.
- **Raporlama Gücü:** Veriler sadece saklanmaz; kâr/zarar ve en çok satan ürün analizleri ile stratejik bilgiye dönüştürülür.
- **Operasyonel Verimlilik:** Rol tabanlı yetkilendirme ile personel karmaşası önlenir.

---

## 🛠️ Teknik Özellikler ve Modüller

### 1. Kullanıcı Yetkilendirme (RBAC)
Uygulama, giriş yapan kullanıcının rolüne göre (`Yönetici`, `Satış Personeli`, `Depo`) arayüzü dinamik olarak şekillendirir:
- **Yönetici:** Finansal raporlar dahil tüm sisteme tam erişim.
- **Satış Personeli:** Sadece satış ekranı ve sınırlı ürün listeleme.
- **Depo Görevlisi:** Ürün ekleme, güncelleme ve stok giriş-çıkış kontrolü.

### 2. Akıllı Stok Yönetimi
- **Kritik Eşik Uyarıları:** Her ürün için tanımlanan `min_stok` miktarı, sistem tarafından anlık kontrol edilir. Eşiğin altına düşen ürünler DataGridView üzerinde **Kırmızı (Red Alert)** olarak işaretlenir.
- **Dinamik Stok Güncelleme:** Satış onaylandığı anda ilgili ürünün stoğu otomatik olarak düşürülür.

### 3. Satış ve Sepet Algoritması
- Birden fazla ürünün aynı anda satılabilmesi için `List<Domain.satis>` yapısı kullanılarak sanal bir sepet oluşturulur.
- Satış sırasında "Müşteri - Ürün - Miktar" ilişkisi kurularak veritabanına `Transaction` mantığında işlenir.

### 4. Gelişmiş Raporlama Motoru
- **Net Kâr Analizi:** `(Satış Fiyatı - Alış Fiyatı) * Miktar` formülü ile işletmenin gerçek kârı hesaplanır.
- **Ciro Takibi:** Belirli periyotlardaki toplam nakit akışı izlenir.
- **Satış Performansı:** Hangi ürünün kaç adet satıldığına dair istatistiksel veriler sunulur.

---

## 🏗️ Proje Mimarisi (N-Tier)

Proje fiziksel ve mantıksal olarak 3 katmana ayrılmıştır:

```text
Proje_Odevim/
├── Presentation_Layer (UI)   # WinForms ekranları, Kullanıcı etkileşimi.
├── Service (BLL)             # İş kuralları, Validasyonlar, Hesaplamalar.
├── DAL (Data Access Layer)   # CRUD operasyonları, MySQL Bağlantı yönetimi (DAO sınıfları).
└── Domain (Entities)         # Veritabanı tablolarının sınıfsal karşılıkları (Product, Customer, etc.).
