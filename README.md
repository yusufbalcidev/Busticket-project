# 🚌 Otobüs Bilet Rezervasyon Sistemi

Basit ama işlevsel bir otobüs bileti rezervasyon uygulaması. ASP.NET MVC 5 mimarisiyle geliştirilmiş, Code First yaklaşımıyla yapılandırılmış, yönetici paneli içeren bir sistemdir.

![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white)

## 📋 Proje Özellikleri

### 👤 Kullanıcı Tarafı
- Otobüs seferlerini listeleme
- Kalkış/Varış ve tarih filtresi
- Koltuk seçimi
- Rezervasyon oluşturma
- Rezervasyon detaylarını görüntüleme
- Mobil uyumlu arayüz

### 🛠️ Admin Paneli
- Sefer ekleme/güncelleme/silme
- Otobüs tanımlama
- Koltuk planı oluşturma
- Rezervasyonları listeleme
- Yönetici giriş sistemi

## 🧰 Kullanılan Teknolojiler

- **Framework**: ASP.NET MVC 5
- **Dil**: C#
- **ORM**: Entity Framework (Code First)
- **Veritabanı**: SQL Server
- **Frontend**: HTML5, CSS3, JavaScript, jQuery, Bootstrap 4
- **IDE**: Visual Studio 2022

## 🗃️ Veritabanı Yapısı (Entity'ler)

- `Bus`: Otobüs bilgileri (plaka, kapasite)
- `Route`: Kalkış-varış şehirleri
- `Trip`: Sefer (tarih, saat, otobüs, rota ilişkisi)
- `Seat`: Otobüsteki koltuklar
- `Reservation`: Kullanıcı rezervasyon bilgileri
- `Admin`: Yönetici giriş bilgileri

## 🚀 Kurulum

1. Projeyi klonlayın:
   ```bash
   git clone https://github.com/kullaniciAdi/otobus-rezervasyon.git
