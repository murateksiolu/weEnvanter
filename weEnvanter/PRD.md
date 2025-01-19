# weEnvanter - Demirbaş Takip Sistemi PRD

## 1. Proje Genel Bakış

weEnvanter, üretim sahasındaki demirbaş malzemelerin takibini sağlayan, Windows Form tabanlı bir masaüstü uygulamasıdır. Sistem, demirbaşların çalışanlara atanması, bakım takibi ve detaylı raporlama özelliklerini içermektedir.

## 2. Teknik Altyapı

- Windows Form Application (.NET Framework)
- SQLite Veritabanı
- DevExpress UI Bileşenleri ve Raporlama Araçları
- Offline Çalışma Desteği

## 3. Temel Özellikler

### 3.1. Kullanıcı Yönetimi ve Güvenlik

- Rol tabanlı yetkilendirme sistemi (Admin, Yönetici, Kullanıcı)
- Kullanıcı işlemleri (Ekleme, Güncelleme, Silme)
- Şifre yönetimi ve güvenlik politikaları
- Oturum yönetimi

### 3.2. Demirbaş Yönetimi

- Demirbaş kayıt işlemleri (Ekleme, Güncelleme, Silme)
- Demirbaş kategorileri yönetimi
- Barkod/Seri numarası takibi
- Garanti takibi
- Satın alma bilgileri (Tarih, Fiyat)
- Durum takibi (Aktif, Pasif, Bakımda, vb.)
- Fotoğraf ekleme ve görüntüleme

### 3.3. Çalışan ve Departman Yönetimi

- Çalışan kayıt işlemleri
- Departman kayıt işlemleri
- Çalışan-Departman ilişkilendirme
- Çalışan demirbaş atama geçmişi

### 3.4. Bakım Yönetimi

- Periyodik bakım planlaması
- Bakım geçmişi kaydı
- Arıza/Tamir kayıtları
- Bakım hatırlatmaları

### 3.5. Demirbaş Atama İşlemleri

- Demirbaş atama
- Demirbaş geri alma
- Atama geçmişi görüntüleme
- Toplu atama işlemleri

### 3.6. Raporlama Sistemi

- Departman bazlı envanter raporu
- Çalışan bazlı envanter raporu
- Kategori bazlı envanter raporu
- Maliyet raporları
- Bakım/Arıza raporları
- Excel/PDF export özellikleri
- Özelleştirilebilir rapor tasarımları

### 3.7. Log ve Tarihçe

- Kullanıcı işlem logları
- Demirbaş hareket geçmişi
- Sistem logları
- Log filtreleme ve arama

### 3.8. Veritabanı Yönetimi

- Otomatik yedekleme
- Veritabanı optimizasyonu
- Veri import/export özellikleri

## 4. Kullanıcı Arayüzü

- DevExpress bileşenleri ile modern arayüz
- Ribbon menü tasarımı
- Kişiselleştirilebilir grid görünümleri
- Kullanıcı bazlı layout kaydetme
- Gelişmiş arama ve filtreleme
- Dashboard özelliği

## 5. Performans Gereksinimleri

- Hızlı veri erişimi
- Büyük veri setlerinde etkili çalışma
- Optimize edilmiş sorgu yapısı
- Önbellek mekanizması

## 6. Güvenlik Gereksinimleri

- Rol bazlı erişim kontrolü
- Veri bütünlüğü kontrolleri
- Şifreleme mekanizmaları
- Kritik işlemler için onay mekanizması

## 7. Bakım ve Destek

- Hata ayıklama ve log inceleme
- Veritabanı bakım araçları
- Yedekleme ve geri yükleme özellikleri
