-- Veritabanını temizle
DELETE FROM SystemLogs;
DELETE FROM Maintenances;
DELETE FROM InventoryAssignments;
DELETE FROM Inventories;
DELETE FROM InventoryCategories;
DELETE FROM Employees;
DELETE FROM Departments;
DELETE FROM Users;
GO

-- Users tablosu (5 kullanıcı)
SET IDENTITY_INSERT Users ON;
INSERT INTO Users (Id, Username, Password, Email, Phone, FirstName, LastName, Role, LastLoginDate, IsActive, IsDeleted, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
VALUES 
(1, 'admin', 'jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=', 'admin@weenvanter.com', '5551234567', 'System', 'Admin', 1, GETDATE(), 1, 0, GETDATE(), NULL, NULL, NULL),
(2, 'user1', 'jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=', 'user1@weenvanter.com', '5551234568', 'Test', 'User', 2, GETDATE(), 1, 0, GETDATE(), NULL, NULL, NULL),
(3, 'user2', 'jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=', 'user2@weenvanter.com', '5551234569', 'Depo', 'Sorumlusu', 2, GETDATE(), 1, 0, GETDATE(), NULL, NULL, NULL),
(4, 'user3', 'jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=', 'user3@weenvanter.com', '5551234570', 'Zimmet', 'Sorumlusu', 2, GETDATE(), 1, 0, GETDATE(), NULL, NULL, NULL),
(5, 'user4', 'jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=', 'user4@weenvanter.com', '5551234571', 'Bakım', 'Sorumlusu', 2, GETDATE(), 1, 0, GETDATE(), NULL, NULL, NULL);
SET IDENTITY_INSERT Users OFF;
GO

-- Departments tablosu (7 departman)
SET IDENTITY_INSERT Departments ON;
INSERT INTO Departments (Id, Name, DepartmentCode, Description, ParentDepartmentId, IsActive, IsDeleted, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
VALUES 
(1, 'Bilgi Teknolojileri', 'BT', 'Bilgi Teknolojileri Departmanı', NULL, 1, 0, GETDATE(), NULL, NULL, NULL),
(2, 'İnsan Kaynakları', 'IK', 'İnsan Kaynakları Departmanı', NULL, 1, 0, GETDATE(), NULL, NULL, NULL),
(3, 'Muhasebe', 'MHS', 'Muhasebe Departmanı', NULL, 1, 0, GETDATE(), NULL, NULL, NULL),
(4, 'Yazılım Geliştirme', 'BTYZ', 'Yazılım Geliştirme Birimi', 1, 1, 0, GETDATE(), NULL, NULL, NULL),
(5, 'Sistem Yönetimi', 'BTSY', 'Sistem Yönetimi Birimi', 1, 1, 0, GETDATE(), NULL, NULL, NULL),
(6, 'Satın Alma', 'STN', 'Satın Alma Departmanı', NULL, 1, 0, GETDATE(), NULL, NULL, NULL),
(7, 'Üretim', 'URE', 'Üretim Departmanı', NULL, 1, 0, GETDATE(), NULL, NULL, NULL);
SET IDENTITY_INSERT Departments OFF;
GO

-- Employees tablosu (8 çalışan)
SET IDENTITY_INSERT Employees ON;
INSERT INTO Employees (Id, FirstName, LastName, EmployeeNumber, Email, Phone, Notes, DepartmentId, HireDate, IsActive, IsDeleted, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
VALUES 
(1, 'Ahmet', 'Yılmaz', 'EMP001', 'ahmet.yilmaz@weenvanter.com', '5551234001', 'Yazılım Geliştirici', 4, '2023-01-15', 1, 0, GETDATE(), NULL, NULL, NULL),
(2, 'Ayşe', 'Demir', 'EMP002', 'ayse.demir@weenvanter.com', '5551234002', 'İK Uzmanı', 2, '2023-02-01', 1, 0, GETDATE(), NULL, NULL, NULL),
(3, 'Mehmet', 'Kaya', 'EMP003', 'mehmet.kaya@weenvanter.com', '5551234003', 'Sistem Yöneticisi', 5, '2023-03-01', 1, 0, GETDATE(), NULL, NULL, NULL),
(4, 'Fatma', 'Şahin', 'EMP004', 'fatma.sahin@weenvanter.com', '5551234004', 'Muhasebe Uzmanı', 3, '2023-04-01', 1, 0, GETDATE(), NULL, NULL, NULL),
(5, 'Ali', 'Öztürk', 'EMP005', 'ali.ozturk@weenvanter.com', '5551234005', 'Yazılım Geliştirici', 4, '2023-05-01', 1, 0, GETDATE(), NULL, NULL, NULL),
(6, 'Zeynep', 'Çelik', 'EMP006', 'zeynep.celik@weenvanter.com', '5551234006', 'Satın Alma Uzmanı', 6, '2023-06-01', 1, 0, GETDATE(), NULL, NULL, NULL),
(7, 'Mustafa', 'Arslan', 'EMP007', 'mustafa.arslan@weenvanter.com', '5551234007', 'Üretim Şefi', 7, '2023-07-01', 1, 0, GETDATE(), NULL, NULL, NULL),
(8, 'Elif', 'Yıldız', 'EMP008', 'elif.yildiz@weenvanter.com', '5551234008', 'Üretim Operatörü', 7, '2023-08-01', 1, 0, GETDATE(), NULL, NULL, NULL);
SET IDENTITY_INSERT Employees OFF;
GO

-- InventoryCategories tablosu (8 kategori)
SET IDENTITY_INSERT InventoryCategories ON;
INSERT INTO InventoryCategories (Id, CategoryCode, Name, Description, IsActive, IsDeleted, ParentCategoryId, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
VALUES 
(1, 'BLG', 'Bilgisayar', 'Bilgisayar Ekipmanları', 1, 0, NULL, GETDATE(), NULL, NULL, NULL),
(2, 'MOB', 'Mobilya', 'Ofis Mobilyaları', 1, 0, NULL, GETDATE(), NULL, NULL, NULL),
(3, 'BLGDS', 'Masaüstü Bilgisayar', 'Masaüstü Bilgisayarlar', 1, 0, 1, GETDATE(), NULL, NULL, NULL),
(4, 'BLGLP', 'Dizüstü Bilgisayar', 'Dizüstü Bilgisayarlar', 1, 0, 1, GETDATE(), NULL, NULL, NULL),
(5, 'MOBMS', 'Masa', 'Çalışma Masaları', 1, 0, 2, GETDATE(), NULL, NULL, NULL),
(6, 'MOBDLP', 'Dolap', 'Ofis Dolapları', 1, 0, 2, GETDATE(), NULL, NULL, NULL),
(7, 'MOBSNK', 'Sandalye', 'Ofis Sandalyeleri', 1, 0, 2, GETDATE(), NULL, NULL, NULL),
(8, 'BLGYZ', 'Yazıcı', 'Yazıcılar', 1, 0, 1, GETDATE(), NULL, NULL, NULL);
SET IDENTITY_INSERT InventoryCategories OFF;
GO

-- Inventories tablosu (8 demirbaş)
SET IDENTITY_INSERT Inventories ON;
INSERT INTO Inventories (Id, InventoryCode, BarcodeNumber, QRCode, Name, Description, Location, InventoryCategoryId, 
    AssignedEmployeeId, AssignmentDate, AssignmentNotes, PurchasePrice, CurrentValue, PurchaseDate, 
    WarrantyExpirationDate, CalibrationDueDate, CalibrationPeriod, LastMaintenanceDate, NextMaintenanceDate, 
    MaintenancePeriod, ExpirationDate, Status, SerialNumber, Brand, Model, Supplier, SupplierPhone, 
    SupplierEmail, Notes, IsActive, IsDeleted, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
VALUES 
(1, 'LP001', 'BN001', 'QR001', 'Dizüstü Bilgisayar 1', 'Dell Latitude', 'Kat 1 - Yazılım Ofisi', 4, 
    NULL, NULL, NULL, 15000.00, 12000.00, '2023-01-15', '2026-01-15', NULL, NULL, NULL, NULL,
    NULL, NULL, 1, 'SN001', 'Dell', 'Latitude 5520', 'ABC Bilgisayar', '5559876543', 
    'abc@supplier.com', 'İyi durumda', 1, 0, GETDATE(), NULL, NULL, NULL),
(2, 'LP002', 'BN002', 'QR002', 'Dizüstü Bilgisayar 2', 'HP EliteBook', 'Kat 1 - IK Ofisi', 4, 
    NULL, NULL, NULL, 16000.00, 13000.00, '2022-02-01', '2024-02-01', NULL, NULL, NULL, NULL,
    NULL, NULL, 1, 'SN002', 'HP', 'EliteBook 850', 'XYZ Bilgisayar', '5559876544', 
    'xyz@supplier.com', 'Normal durumda', 1, 0, GETDATE(), NULL, NULL, NULL),
(3, 'DS001', 'BN003', 'QR003', 'Masaüstü Bilgisayar 1', 'Dell OptiPlex', 'Kat 2 - Muhasebe', 3, 
    NULL, NULL, NULL, 12000.00, 10000.00, '2023-03-01', '2026-03-01', '2024-02-01', 180, NULL, NULL,
    NULL, NULL, 1, 'SN003', 'Dell', 'OptiPlex 7090', 'ABC Bilgisayar', '5559876543', 
    'abc@supplier.com', 'Kalibrasyon gerekiyor', 1, 0, GETDATE(), NULL, NULL, NULL),
(4, 'DS002', 'BN004', 'QR004', 'Masaüstü Bilgisayar 2', 'HP ProDesk', 'Kat 2 - Sistem Odası', 3, 
    NULL, NULL, NULL, 13000.00, 11000.00, '2023-04-01', '2026-04-01', NULL, NULL, NULL, NULL,
    NULL, NULL, 1, 'SN004', 'HP', 'ProDesk 600', 'XYZ Bilgisayar', '5559876544', 
    'xyz@supplier.com', 'Bakım gerekiyor', 1, 0, GETDATE(), NULL, NULL, NULL),
(5, 'MS001', 'BN005', 'QR005', 'Çalışma Masası 1', 'L Tipi Çalışma Masası', 'Kat 1 - Yazılım Ofisi', 5, 
    NULL, NULL, NULL, 5000.00, 4000.00, '2023-05-01', '2026-05-01', NULL, NULL, NULL, NULL,
    NULL, NULL, 2, 'SN005', 'Bürotime', 'L Desk 160', 'DEF Mobilya', '5559876545', 
    'def@supplier.com', 'Onarımda', 1, 0, GETDATE(), NULL, NULL, NULL),
(6, 'PR001', 'BN006', 'QR006', 'Yazıcı 1', 'Renkli Lazer Yazıcı', 'Kat 1 - Ortak Alan', 8,
    NULL, NULL, NULL, 8000.00, 7000.00, '2023-06-01', '2026-06-01', '2024-03-01', 90, NULL, NULL,
    NULL, NULL, 1, 'SN006', 'HP', 'Color LaserJet', 'XYZ Bilgisayar', '5559876544', 
    'xyz@supplier.com', 'Düzenli bakım yapılıyor', 1, 0, GETDATE(), NULL, NULL, NULL),
(7, 'SNK001', 'BN007', 'QR007', 'Ofis Sandalyesi 1', 'Ergonomik Çalışma Koltuğu', 'Kat 2 - Muhasebe', 7,
    NULL, NULL, NULL, 3000.00, 2500.00, '2023-07-01', '2026-07-01', NULL, NULL, NULL, NULL,
    NULL, NULL, 1, 'SN007', 'Herman Miller', 'Aeron', 'DEF Mobilya', '5559876545', 
    'def@supplier.com', 'Yeni alındı', 1, 0, GETDATE(), NULL, NULL, NULL),
(8, 'DLP001', 'BN008', 'QR008', 'Dosya Dolabı 1', 'Metal Dosya Dolabı', 'Kat 1 - IK Ofisi', 6,
    NULL, NULL, NULL, 4000.00, 3500.00, '2023-08-01', '2026-08-01', NULL, NULL, NULL, NULL,
    NULL, NULL, 1, 'SN008', 'Bürotime', 'File Cabinet XL', 'DEF Mobilya', '5559876545', 
    'def@supplier.com', 'İyi durumda', 1, 0, GETDATE(), NULL, NULL, NULL);
SET IDENTITY_INSERT Inventories OFF;
GO

-- InventoryAssignments tablosu (8 zimmet)
SET IDENTITY_INSERT InventoryAssignments ON;
INSERT INTO InventoryAssignments (Id, InventoryId, EmployeeId, AssignmentDate, ReturnDate, AssignedById, Notes, 
    IsReturned, IsActive, IsDeleted, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
VALUES 
(1, 1, 1, '2023-01-16', NULL, 1, 'Yazılım geliştirme için', 0, 1, 0, GETDATE(), NULL, NULL, NULL),
(2, 2, 2, '2023-02-02', NULL, 1, 'İK işlemleri için', 0, 1, 0, GETDATE(), NULL, NULL, NULL),
(3, 3, 4, '2023-03-02', NULL, 1, 'Muhasebe işlemleri için', 0, 1, 0, GETDATE(), NULL, NULL, NULL),
(4, 4, 3, '2023-04-02', NULL, 1, 'Sistem yönetimi için', 0, 1, 0, GETDATE(), NULL, NULL, NULL),
(5, 5, 5, '2023-05-02', NULL, 1, 'Yazılım geliştirme için', 0, 1, 0, GETDATE(), NULL, NULL, NULL),
(6, 6, 6, '2023-06-02', NULL, 1, 'Satın alma işlemleri için', 0, 1, 0, GETDATE(), NULL, NULL, NULL),
(7, 7, 7, '2023-07-02', NULL, 1, 'Üretim yönetimi için', 0, 1, 0, GETDATE(), NULL, NULL, NULL),
(8, 8, 8, '2023-08-02', NULL, 1, 'Üretim operasyonları için', 0, 1, 0, GETDATE(), NULL, NULL, NULL);
SET IDENTITY_INSERT InventoryAssignments OFF;
GO

-- Maintenances tablosu (5 bakım)
SET IDENTITY_INSERT Maintenances ON;
INSERT INTO Maintenances (Id, InventoryId, Description, StartDate, EndDate, Notes, Status, MaintenanceType, Cost,
    PerformedBy, CompanyName, ContactPerson, ContactPhone, InvoiceNumber, NextMaintenanceDate, ReplacedParts,
    Recommendations, FailureDescription, Resolution, WarrantyPeriodInDays, IsUnderWarranty, IsActive, IsDeleted,
    CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
VALUES 
(1, 1, 'Rutin Bakım', '2023-06-01', '2023-06-02', 'Temizlik ve kontrol yapıldı', 3, 1, 500.00,
    'Teknisyen A', 'ABC Teknik', 'Mehmet Tekniker', '5559876546', 'INV001', '2024-06-01', 'Termal macun',
    'Düzenli temizlik önerilir', NULL, 'Bakım tamamlandı', 30, 1, 1, 0, GETDATE(), NULL, NULL, NULL),
(2, 5, 'Arıza Onarımı', '2024-01-15', NULL, 'Masa ayağı değişimi gerekiyor', 2, 2, 1000.00,
    'Teknisyen B', 'DEF Mobilya', 'Ali Usta', '5559876547', 'INV002', '2024-07-15', 'Masa ayağı',
    'Düzenli kontrol önerilir', 'Masa dengesi bozuk', 'Onarım devam ediyor', 90, 1, 1, 0, GETDATE(), NULL, NULL, NULL),
(3, 4, 'Periyodik Bakım', '2024-02-01', NULL, 'Donanım kontrolü yapılacak', 1, 1, 750.00,
    'Teknisyen C', 'XYZ Teknik', 'Ayşe Tekniker', '5559876548', 'INV003', '2024-08-01', NULL,
    'Parça değişimi gerekebilir', NULL, NULL, 60, 1, 1, 0, GETDATE(), NULL, NULL, NULL),
(4, 6, 'Yazıcı Bakımı', '2023-12-15', '2023-12-16', 'Yazıcı kafası temizliği', 3, 1, 300.00,
    'Teknisyen D', 'XYZ Teknik', 'Hasan Tekniker', '5559876549', 'INV004', '2024-06-15', 'Toner',
    'Aylık temizlik önerilir', NULL, 'Bakım tamamlandı', 30, 1, 1, 0, GETDATE(), NULL, NULL, NULL),
(5, 3, 'Donanım Yükseltme', '2024-01-20', NULL, 'RAM yükseltmesi yapılacak', 1, 3, 2000.00,
    'Teknisyen E', 'ABC Teknik', 'Fatma Tekniker', '5559876550', 'INV005', '2024-07-20', 'RAM Modülü',
    'SSD yükseltmesi de önerilir', NULL, NULL, 90, 1, 1, 0, GETDATE(), NULL, NULL, NULL);
SET IDENTITY_INSERT Maintenances OFF;
GO

-- SystemLogs tablosu (8 log kaydı)
SET IDENTITY_INSERT SystemLogs ON;
INSERT INTO SystemLogs (Id, UserId, LogDate, LogType, Action, Description, EntityName, EntityId, OldValue, NewValue, 
    IpAddress, IsActive, IsDeleted, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy)
VALUES 
(1, 1, GETDATE(), 1, 'Login', 'Kullanıcı girişi yapıldı', 'User', '1', NULL, NULL, '192.168.1.100', 1, 0, GETDATE(), NULL, NULL, NULL),
(2, 1, GETDATE(), 2, 'Create', 'Yeni demirbaş eklendi', 'Inventory', '1', NULL, 'LP001', '192.168.1.100', 1, 0, GETDATE(), NULL, NULL, NULL),
(3, 1, GETDATE(), 3, 'Update', 'Demirbaş zimmeti güncellendi', 'InventoryAssignment', '1', NULL, 'EMP001', '192.168.1.100', 1, 0, GETDATE(), NULL, NULL, NULL),
(4, 2, GETDATE(), 1, 'Login', 'Kullanıcı girişi yapıldı', 'User', '2', NULL, NULL, '192.168.1.101', 1, 0, GETDATE(), NULL, NULL, NULL),
(5, 2, GETDATE(), 2, 'Create', 'Yeni bakım kaydı oluşturuldu', 'Maintenance', '1', NULL, 'MNT001', '192.168.1.101', 1, 0, GETDATE(), NULL, NULL, NULL),
(6, 3, GETDATE(), 1, 'Login', 'Kullanıcı girişi yapıldı', 'User', '3', NULL, NULL, '192.168.1.102', 1, 0, GETDATE(), NULL, NULL, NULL),
(7, 3, GETDATE(), 4, 'Delete', 'Zimmet iadesi yapıldı', 'InventoryAssignment', '2', 'EMP002', NULL, '192.168.1.102', 1, 0, GETDATE(), NULL, NULL, NULL),
(8, 1, GETDATE(), 3, 'Update', 'Demirbaş bilgileri güncellendi', 'Inventory', '3', NULL, 'DS001', '192.168.1.100', 1, 0, GETDATE(), NULL, NULL, NULL);
SET IDENTITY_INSERT SystemLogs OFF;
GO

-- Demirbaşların zimmet durumlarını güncelle
UPDATE Inventories 
SET AssignedEmployeeId = a.EmployeeId,
    AssignmentDate = a.AssignmentDate,
    AssignmentNotes = a.Notes,
    ModifiedDate = GETDATE(),
    ModifiedBy = 1
FROM Inventories i
INNER JOIN InventoryAssignments a ON i.Id = a.InventoryId
WHERE a.IsReturned = 0;
GO 