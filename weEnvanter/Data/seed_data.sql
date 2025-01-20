-- Departmanlar
SET IDENTITY_INSERT Departments ON;
INSERT INTO Departments (Id, Name, DepartmentCode, Description, ParentDepartmentId, IsActive, CreatedDate, IsDeleted, CreatedBy, ModifiedBy, ModifiedDate) VALUES
(1, 'Bilgi Teknolojileri', 'BT-001', 'Bilgi Teknolojileri Departmanı', NULL, 1, GETDATE(), 0, 1, NULL, NULL),
(2, 'İnsan Kaynakları', 'IK-001', 'İnsan Kaynakları Departmanı', NULL, 1, GETDATE(), 0, 1, NULL, NULL),
(3, 'Üretim', 'UR-001', 'Üretim Departmanı', NULL, 1, GETDATE(), 0, 1, NULL, NULL),
(4, 'Kalite Kontrol', 'KK-001', 'Kalite Kontrol Departmanı', NULL, 1, GETDATE(), 0, 1, NULL, NULL),
(5, 'Ar-Ge', 'AR-001', 'Araştırma ve Geliştirme Departmanı', NULL, 1, GETDATE(), 0, 1, NULL, NULL);
SET IDENTITY_INSERT Departments OFF;

-- Çalışanlar
SET IDENTITY_INSERT Employees ON;
INSERT INTO Employees (Id, FirstName, LastName, EmployeeNumber, DepartmentId, Email, Phone, Notes, HireDate, IsActive, CreatedDate, IsDeleted, CreatedBy, ModifiedBy, ModifiedDate) VALUES
(1, 'Ahmet', 'Yılmaz', 'EMP001', 1, 'ahmet.yilmaz@firma.com', '5551112233', 'BT Uzmanı', GETDATE(), 1, GETDATE(), 0, 1, NULL, NULL),
(2, 'Mehmet', 'Kaya', 'EMP002', 1, 'mehmet.kaya@firma.com', '5551112234', 'Yazılım Geliştirici', GETDATE(), 1, GETDATE(), 0, 1, NULL, NULL),
(3, 'Ayşe', 'Demir', 'EMP003', 2, 'ayse.demir@firma.com', '5551112235', 'İK Uzmanı', GETDATE(), 1, GETDATE(), 0, 1, NULL, NULL),
(4, 'Fatma', 'Çelik', 'EMP004', 3, 'fatma.celik@firma.com', '5551112236', 'Üretim Sorumlusu', GETDATE(), 1, GETDATE(), 0, 1, NULL, NULL),
(5, 'Ali', 'Öztürk', 'EMP005', 4, 'ali.ozturk@firma.com', '5551112237', 'Kalite Kontrol Uzmanı', GETDATE(), 1, GETDATE(), 0, 1, NULL, NULL);
SET IDENTITY_INSERT Employees OFF;

-- Demirbaş Kategorileri
SET IDENTITY_INSERT InventoryCategories ON;
INSERT INTO InventoryCategories (Id, Name, CategoryCode, Description, ParentCategoryId, IsActive, CreatedDate, IsDeleted, CreatedBy, ModifiedBy, ModifiedDate) VALUES
(1, 'Bilgisayarlar', 'CAT001', 'Masaüstü ve Dizüstü Bilgisayarlar', NULL, 1, GETDATE(), 0, 1, NULL, NULL),
(2, 'Monitörler', 'CAT002', 'Bilgisayar Monitörleri', NULL, 1, GETDATE(), 0, 1, NULL, NULL),
(3, 'Yazıcılar', 'CAT003', 'Yazıcı ve Tarayıcılar', NULL, 1, GETDATE(), 0, 1, NULL, NULL),
(4, 'Test Cihazları', 'CAT004', 'Kalibrasyon Gerektiren Test Cihazları', NULL, 1, GETDATE(), 0, 1, NULL, NULL),
(5, 'Ofis Mobilyaları', 'CAT005', 'Masa, Sandalye vb.', NULL, 1, GETDATE(), 0, 1, NULL, NULL);
SET IDENTITY_INSERT InventoryCategories OFF;

-- Demirbaşlar
SET IDENTITY_INSERT Inventories ON;
INSERT INTO Inventories (
    Id, InventoryCode, Name, Description, InventoryCategoryId, DepartmentId, 
    AssignedEmployeeId, AssignmentDate, AssignmentNotes, PurchasePrice, CurrentValue, 
    PurchaseDate, WarrantyExpirationDate, CalibrationDueDate, 
    LastMaintenanceDate, NextMaintenanceDate, Status, 
    SerialNumber, Brand, Model, IsActive, CreatedDate, IsDeleted,
    CreatedBy, ModifiedBy, ModifiedDate
) VALUES
-- Normal kullanımda olan demirbaş
(1, 'INV001', 'Dizüstü Bilgisayar', 'Dell Latitude 5520', 1, 1, 1, GETDATE(), 'İlk zimmetleme', 15000, 12000, 
 DATEADD(month, -6, GETDATE()), DATEADD(year, 2, GETDATE()), NULL,
 NULL, NULL, 1, 'SN123456', 'Dell', 'Latitude 5520', 1, GETDATE(), 0,
 1, NULL, NULL),

-- Garantisi yakında bitecek demirbaş
(2, 'INV002', 'Masaüstü Bilgisayar', 'HP EliteDesk 800', 1, 1, 2, GETDATE(), 'İlk zimmetleme', 12000, 10000,
 DATEADD(year, -1, GETDATE()), DATEADD(day, 25, GETDATE()), NULL,
 NULL, NULL, 1, 'SN123457', 'HP', 'EliteDesk 800', 1, GETDATE(), 0,
 1, NULL, NULL),

-- Kalibrasyonu yakında gelecek test cihazı
(3, 'INV003', 'Multimetre', 'Fluke 87V', 4, 4, NULL, NULL, NULL, 5000, 4000,
 DATEADD(month, -3, GETDATE()), DATEADD(year, 2, GETDATE()), DATEADD(day, 15, GETDATE()),
 DATEADD(month, -6, GETDATE()), NULL, 1, 'SN123458', 'Fluke', '87V', 1, GETDATE(), 0,
 1, NULL, NULL),

-- Bakımı yakında gelecek yazıcı
(4, 'INV004', 'Renkli Yazıcı', 'HP Color LaserJet Pro', 3, 2, NULL, NULL, NULL, 8000, 6000,
 DATEADD(month, -8, GETDATE()), DATEADD(year, 1, GETDATE()), NULL,
 DATEADD(month, -3, GETDATE()), DATEADD(day, 20, GETDATE()), 1, 'SN123459', 'HP', 'Color LaserJet Pro', 1, GETDATE(), 0,
 1, NULL, NULL),

-- Bakımda olan demirbaş
(5, 'INV005', 'Test Cihazı', 'Oscilloscope', 4, 4, NULL, NULL, NULL, 20000, 18000,
 DATEADD(month, -2, GETDATE()), DATEADD(year, 3, GETDATE()), DATEADD(month, 6, GETDATE()),
 DATEADD(month, -1, GETDATE()), NULL, 3, 'SN123460', 'Tektronix', 'TBS1052B', 1, GETDATE(), 0,
 1, NULL, NULL);
SET IDENTITY_INSERT Inventories OFF;

-- Bakım Kayıtları
SET IDENTITY_INSERT Maintenances ON;
INSERT INTO Maintenances (
    Id, InventoryId, Description, StartDate, EndDate, Notes, Status,
    IsActive, CreatedDate, IsDeleted, CreatedBy, ModifiedBy, ModifiedDate
) VALUES
-- Tamamlanmış bakım
(1, 4, 'Periyodik bakım', DATEADD(month, -3, GETDATE()), DATEADD(month, -3, GETDATE()),
 'Bakım başarıyla tamamlandı', 3, 1, GETDATE(), 0, 1, NULL, NULL),

-- Devam eden bakım
(2, 5, 'Kalibrasyon ve bakım', GETDATE(), NULL,
 'Kalibrasyon işlemi devam ediyor', 2, 1, GETDATE(), 0, 1, NULL, NULL),

-- Yaklaşan bakım için kayıt
(3, 3, 'Kalibrasyon', DATEADD(day, 15, GETDATE()), NULL,
 'Planlanmış kalibrasyon', 1, 1, GETDATE(), 0, 1, NULL, NULL);
SET IDENTITY_INSERT Maintenances OFF;

-- Zimmet Kayıtları
SET IDENTITY_INSERT InventoryAssignments ON;
INSERT INTO InventoryAssignments (
    Id, InventoryId, EmployeeId, AssignmentDate, ReturnDate,
    AssignedById, Notes, IsReturned, IsActive, CreatedDate, IsDeleted,
    CreatedBy, ModifiedBy, ModifiedDate
) VALUES
(1, 1, 1, GETDATE(), NULL, 1, 'İlk zimmetleme', 0, 1, GETDATE(), 0, 1, NULL, NULL),
(2, 2, 2, GETDATE(), NULL, 1, 'İlk zimmetleme', 0, 1, GETDATE(), 0, 1, NULL, NULL);
SET IDENTITY_INSERT InventoryAssignments OFF;

-- Sistem Logları
SET IDENTITY_INSERT SystemLogs ON;
INSERT INTO SystemLogs (
    Id, UserId, LogDate, LogType, Action, Description, 
    EntityName, EntityId, OldValue, NewValue, IpAddress,
    IsActive, CreatedDate, IsDeleted, CreatedBy, ModifiedBy, ModifiedDate
) VALUES
(1, 1, DATEADD(hour, -1, GETDATE()), 1, 'Demirbaş Ekleme', 'Yeni dizüstü bilgisayar eklendi',
 'Inventory', '1', NULL, 'INV001', '192.168.1.100', 1, GETDATE(), 0, 1, NULL, NULL),
(2, 1, DATEADD(hour, -2, GETDATE()), 1, 'Zimmetleme', 'Dizüstü bilgisayar Ahmet Yılmaz''a zimmetlendi',
 'Inventory', '1', NULL, 'EMP001', '192.168.1.100', 1, GETDATE(), 0, 1, NULL, NULL),
(3, 1, GETDATE(), 2, 'Bakım Başlatma', 'Test cihazı bakıma alındı',
 'Maintenance', '2', NULL, 'InProgress', '192.168.1.100', 1, GETDATE(), 0, 1, NULL, NULL);
SET IDENTITY_INSERT SystemLogs OFF;

-- Kullanıcılar (Şifre: 123456)
SET IDENTITY_INSERT Users ON;
INSERT INTO Users (
    Id, Username, Password, Email, Phone, FirstName, LastName,
    Role, LastLoginDate, IsActive, CreatedDate, IsDeleted,
    CreatedBy, ModifiedBy, ModifiedDate
) VALUES
(1, 'admin', 'hashed_password', 'admin@firma.com', '5551112233', 'Admin', 'User', 1, GETDATE(), 1, GETDATE(), 0, 1, NULL, NULL),
(2, 'user', 'hashed_password', 'user@firma.com', '5551112234', 'Normal', 'User', 2, GETDATE(), 1, GETDATE(), 0, 1, NULL, NULL);
SET IDENTITY_INSERT Users OFF; 