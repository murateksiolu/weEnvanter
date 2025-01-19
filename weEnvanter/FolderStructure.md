# weEnvanter Klasör Yapısı

```
weEnvanter/
│
├── src/
│   ├── weEnvanter.Core/                 # Çekirdek iş mantığı ve entities
│   │   ├── Entities/                    # Veritabanı entity sınıfları
│   │   ├── Interfaces/                  # Interface tanımlamaları
│   │   ├── Enums/                       # Enum tanımlamaları
│   │   └── Constants/                   # Sabit değerler
│   │
│   ├── weEnvanter.Data/                 # Veritabanı işlemleri
│   │   ├── Context/                     # SQLite context
│   │   ├── Repositories/                # Repository sınıfları
│   │   ├── Migrations/                  # Veritabanı migrations
│   │   └── Scripts/                     # SQL scriptleri
│   │
│   └── weEnvanter.UI/                   # Windows Form UI katmanı
│       ├── Forms/                       # Form sınıfları
│       │   ├── Auth/                    # Giriş/yetki formları
│       │   ├── User/                    # Kullanıcı yönetimi
│       │   ├── Inventory/               # Demirbaş yönetimi
│       │   ├── Employee/                # Çalışan yönetimi
│       │   ├── Department/              # Departman yönetimi
│       │   ├── Maintenance/             # Bakım yönetimi
│       │   └── Reports/                 # Rapor formları
│       │
│       ├── Controls/                    # Özel kontroller
│       ├── Helpers/                     # Yardımcı sınıflar
│       ├── Resources/                   # Resource dosyaları
│       │   ├── Images/                  # Resimler
│       │   ├── Icons/                   # İkonlar
│       │   └── Layouts/                 # DevExpress layout dosyaları
│       │
│       └── Reports/                     # DevExpress report tasarımları
│
├── tests/                               # Test projeleri
│   ├── weEnvanter.Core.Tests/
│   ├── weEnvanter.Data.Tests/
│   └── weEnvanter.UI.Tests/
│
├── docs/                                # Dökümantasyon
│   ├── PRD.md
│   └── Database/                        # Veritabanı diyagramları
│
└── tools/                               # Yardımcı araçlar
    ├── Backup/                          # Yedekleme araçları
    └── Scripts/                         # Yardımcı scriptler
```

## Katman Açıklamaları

### Core Katmanı (weEnvanter.Core)

- Temel veri yapıları
- Entity sınıfları
- Interface tanımlamaları
- Enum ve sabit değerler

### Veri Katmanı (weEnvanter.Data)

- SQLite veritabanı bağlantısı
- Repository pattern implementasyonu
- Veritabanı migration yönetimi
- CRUD operasyonları

### UI Katmanı (weEnvanter.UI)

- Windows Form arayüzleri
- DevExpress form ve raporları
- Özel kontroller
- Resource yönetimi

### Test Projeleri

- Birim testleri
- Entegrasyon testleri
- UI testleri

### Dokümantasyon

- PRD ve diğer dokümanlar
- Veritabanı şemaları
- API dokümantasyonu

### Araçlar

- Yedekleme ve geri yükleme araçları
- Yardımcı scriptler
