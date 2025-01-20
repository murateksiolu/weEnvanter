-- Veritabanını kullan
USE [weEnvanter]
GO

-- Identity insert açık
SET IDENTITY_INSERT [dbo].[Users] ON
GO

-- Users tablosu için örnek veriler
INSERT INTO [dbo].[Users] ([Id], [Username], [Password], [Email], [Phone], [FirstName], [LastName], [Role], [LastLoginDate], [IsActive], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsDeleted])
VALUES 
(1, 'admin', 'jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=', 'admin@weenvanter.com', '5551234567', 'System', 'Admin', 1, GETDATE(), 1, GETDATE(), 'System', NULL, NULL, 0),
(2, 'user1', 'jGl25bVBBBW96Qi9Te4V37Fnqchz/Eu4qB9vKrRIqRg=', 'user1@weenvanter.com', '5551234568', 'Test', 'User', 2, GETDATE(), 1, GETDATE(), 'System', NULL, NULL, 0)
GO

SET IDENTITY_INSERT [dbo].[Users] OFF
GO

-- Departments tablosu için örnek veriler
SET IDENTITY_INSERT [dbo].[Departments] ON
GO

INSERT INTO [dbo].[Departments] ([Id], [Name], [DepartmentCode], [Description], [ParentDepartmentId], [IsActive], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsDeleted])
VALUES 
(1, 'Bilgi Teknolojileri', 'BT', 'Bilgi Teknolojileri Departmanı', NULL, 1, GETDATE(), 'System', NULL, NULL, 0),
(2, 'İnsan Kaynakları', 'IK', 'İnsan Kaynakları Departmanı', NULL, 1, GETDATE(), 'System', NULL, NULL, 0),
(3, 'Muhasebe', 'MHS', 'Muhasebe Departmanı', NULL, 1, GETDATE(), 'System', NULL, NULL, 0),
(4, 'Yazılım Geliştirme', 'BTYZ', 'Yazılım Geliştirme Birimi', 1, 1, GETDATE(), 'System', NULL, NULL, 0),
(5, 'Sistem Yönetimi', 'BTSY', 'Sistem Yönetimi Birimi', 1, 1, GETDATE(), 'System', NULL, NULL, 0)
GO

SET IDENTITY_INSERT [dbo].[Departments] OFF
GO

-- Employees tablosu için örnek veriler
SET IDENTITY_INSERT [dbo].[Employees] ON
GO

INSERT INTO [dbo].[Employees] ([Id], [FirstName], [LastName], [EmployeeNumber], [Email], [Phone], [Notes], [DepartmentId], [HireDate], [IsActive], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsDeleted])
VALUES 
(1, 'Ahmet', 'Yılmaz', 'EMP001', 'ahmet.yilmaz@weenvanter.com', '5551234001', 'Yazılım Geliştirici', 4, '2023-01-15', 1, GETDATE(), 'System', NULL, NULL, 0),
(2, 'Ayşe', 'Demir', 'EMP002', 'ayse.demir@weenvanter.com', '5551234002', 'İK Uzmanı', 2, '2023-02-01', 1, GETDATE(), 'System', NULL, NULL, 0),
(3, 'Mehmet', 'Kaya', 'EMP003', 'mehmet.kaya@weenvanter.com', '5551234003', 'Sistem Yöneticisi', 5, '2023-03-15', 1, GETDATE(), 'System', NULL, NULL, 0),
(4, 'Fatma', 'Şahin', 'EMP004', 'fatma.sahin@weenvanter.com', '5551234004', 'Muhasebe Uzmanı', 3, '2023-04-01', 1, GETDATE(), 'System', NULL, NULL, 0),
(5, 'Ali', 'Öztürk', 'EMP005', 'ali.ozturk@weenvanter.com', '5551234005', 'Test Mühendisi', 4, '2023-05-15', 1, GETDATE(), 'System', NULL, NULL, 0)
GO

SET IDENTITY_INSERT [dbo].[Employees] OFF
GO

-- InventoryCategories tablosu için örnek veriler
SET IDENTITY_INSERT [dbo].[InventoryCategories] ON
GO

INSERT INTO [dbo].[InventoryCategories] ([Id], [CategoryCode], [Name], [Description], [ParentCategoryId], [IsActive], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsDeleted])
VALUES 
(1, 'BLG', 'Bilgisayar', 'Bilgisayar Ekipmanları', NULL, 1, GETDATE(), 'System', NULL, NULL, 0),
(2, 'MOB', 'Mobil Cihazlar', 'Mobil Cihazlar', NULL, 1, GETDATE(), 'System', NULL, NULL, 0),
(3, 'YAZ', 'Yazıcılar', 'Yazıcı Ekipmanları', NULL, 1, GETDATE(), 'System', NULL, NULL, 0),
(4, 'BLGNB', 'Notebook', 'Taşınabilir Bilgisayarlar', 1, 1, GETDATE(), 'System', NULL, NULL, 0),
(5, 'BLGPC', 'Masaüstü', 'Masaüstü Bilgisayarlar', 1, 1, GETDATE(), 'System', NULL, NULL, 0)
GO

SET IDENTITY_INSERT [dbo].[InventoryCategories] OFF
GO

-- Inventories tablosu için örnek veriler
SET IDENTITY_INSERT [dbo].[Inventories] ON
GO

INSERT INTO [dbo].[Inventories] ([Id], [InventoryCode], [BarcodeNumber], [QRCode], [Name], [Description], [Location], [InventoryCategoryId], [AssignedEmployeeId], [AssignmentDate], [AssignmentNotes], [PurchasePrice], [CurrentValue], [PurchaseDate], [WarrantyExpirationDate], [CalibrationDueDate], [CalibrationPeriod], [LastMaintenanceDate], [NextMaintenanceDate], [MaintenancePeriod], [ExpirationDate], [Status], [SerialNumber], [Brand], [Model], [Supplier], [SupplierPhone], [SupplierEmail], [Notes], [IsActive], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsDeleted])
VALUES 
(1, 'NB001', 'BN001', 'QR001', 'Dell Latitude 5520', 'İş Laptopu', 'Kat 1 - Yazılım Ofisi', 4, 1, '2023-06-01', 'Yazılım geliştirme için', 25000.00, 22500.00, '2023-06-01', '2024-06-01', NULL, NULL, NULL, NULL, NULL, NULL, 1, 'DL55201234', 'Dell', 'Latitude 5520', 'ABC Bilgisayar', '5559876543', 'abc@supplier.com', 'i7, 16GB RAM, 512GB SSD', 1, GETDATE(), 'System', NULL, NULL, 0),
(2, 'PC001', 'BN002', 'QR002', 'HP ProDesk 600', 'Masaüstü Bilgisayar', 'Kat 2 - Muhasebe', 5, 4, '2023-06-15', 'Muhasebe işlemleri için', 15000.00, 13500.00, '2023-06-15', '2024-06-15', NULL, NULL, NULL, NULL, NULL, NULL, 1, 'HP60012345', 'HP', 'ProDesk 600', 'ABC Bilgisayar', '5559876543', 'abc@supplier.com', 'i5, 8GB RAM, 256GB SSD', 1, GETDATE(), 'System', NULL, NULL, 0),
(3, 'PR001', 'BN003', 'QR003', 'HP LaserJet Pro', 'Renkli Lazer Yazıcı', 'Kat 1 - Yazıcı Odası', 3, NULL, NULL, NULL, 8000.00, 7200.00, '2023-07-01', '2024-07-01', '2024-01-01', 180, '2023-07-01', '2024-01-01', 180, NULL, 1, 'HPLJ123456', 'HP', 'LaserJet Pro', 'XYZ Teknoloji', '5559876544', 'xyz@supplier.com', 'Renkli, Çift Taraflı Baskı', 1, GETDATE(), 'System', NULL, NULL, 0),
(4, 'NB002', 'BN004', 'QR004', 'Lenovo ThinkPad', 'İş Laptopu', 'Kat 2 - IK Ofisi', 2, 2, '2023-07-15', 'IK işlemleri için', 20000.00, 18000.00, '2023-07-15', '2024-07-15', NULL, NULL, '2023-10-15', '2024-01-15', 90, NULL, 1, 'LTP123456', 'Lenovo', 'ThinkPad T14', 'ABC Bilgisayar', '5559876543', 'abc@supplier.com', 'i5, 8GB RAM, 256GB SSD', 1, GETDATE(), 'System', NULL, NULL, 0),
(5, 'MOB001', 'BN005', 'QR005', 'iPhone 13', 'Akıllı Telefon', 'Kat 1 - BT Ofisi', 2, 3, '2023-08-01', 'Sistem yönetimi için', 30000.00, 27000.00, '2023-08-01', '2024-08-01', NULL, NULL, NULL, NULL, NULL, NULL, 1, 'IPH123456', 'Apple', 'iPhone 13', 'DEF Teknoloji', '5559876545', 'def@supplier.com', '128GB, Siyah', 1, GETDATE(), 'System', NULL, NULL, 0)
GO

SET IDENTITY_INSERT [dbo].[Inventories] OFF
GO

-- InventoryAssignments tablosu için örnek veriler
SET IDENTITY_INSERT [dbo].[InventoryAssignments] ON
GO

INSERT INTO [dbo].[InventoryAssignments] ([Id], [InventoryId], [EmployeeId], [AssignmentDate], [ReturnDate], [AssignedById], [Notes], [IsReturned], [IsActive], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsDeleted])
VALUES 
(1, 1, 1, '2023-06-01', NULL, 1, 'Yazılım geliştirme için zimmetlendi', 0, 1, GETDATE(), 'System', NULL, NULL, 0),
(2, 2, 4, '2023-06-15', NULL, 1, 'Muhasebe işlemleri için zimmetlendi', 0, 1, GETDATE(), 'System', NULL, NULL, 0),
(3, 4, 2, '2023-07-15', NULL, 1, 'IK işlemleri için zimmetlendi', 0, 1, GETDATE(), 'System', NULL, NULL, 0),
(4, 5, 3, '2023-08-01', NULL, 1, 'Sistem yönetimi için zimmetlendi', 0, 1, GETDATE(), 'System', NULL, NULL, 0)
GO

SET IDENTITY_INSERT [dbo].[InventoryAssignments] OFF
GO

-- Maintenances tablosu için örnek veriler
SET IDENTITY_INSERT [dbo].[Maintenances] ON
GO

INSERT INTO [dbo].[Maintenances] ([Id], [InventoryId], [Description], [StartDate], [EndDate], [Notes], [Status], [MaintenanceType], [Cost], [PerformedBy], [CompanyName], [ContactPerson], [ContactPhone], [InvoiceNumber], [NextMaintenanceDate], [ReplacedParts], [Recommendations], [FailureDescription], [Resolution], [WarrantyPeriodInDays], [IsUnderWarranty], [IsActive], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsDeleted])
VALUES 
(1, 3, 'Periyodik Bakım', '2023-07-01', '2023-07-02', 'Rutin bakım yapıldı', 3, 1, 500.00, 'Teknisyen Ahmet', 'XYZ Teknoloji', 'Mehmet Tekniker', '5559876544', 'INV001', '2024-01-01', 'Toner değiştirildi', 'Düzenli temizlik önerilir', NULL, 'Bakım tamamlandı', 180, 1, 1, GETDATE(), 'System', NULL, NULL, 0),
(2, 4, 'Donanım Arızası', '2023-10-15', '2023-10-16', 'RAM arızası giderildi', 3, 2, 1200.00, 'Teknisyen Mehmet', 'ABC Bilgisayar', 'Ali Tekniker', '5559876543', 'INV002', '2024-01-15', 'RAM modülü', 'Yedek RAM bulundurulması önerilir', 'RAM arızası', 'Yeni RAM takıldı', 90, 1, 1, GETDATE(), 'System', NULL, NULL, 0),
(3, 3, 'Yazıcı Bakımı', '2024-01-01', NULL, 'Periyodik bakım planlandı', 1, 1, NULL, NULL, 'XYZ Teknoloji', 'Mehmet Tekniker', '5559876544', NULL, '2024-07-01', NULL, NULL, NULL, NULL, NULL, 1, 1, GETDATE(), 'System', NULL, NULL, 0)
GO

SET IDENTITY_INSERT [dbo].[Maintenances] OFF
GO

-- SystemLogs tablosu için örnek veriler
SET IDENTITY_INSERT [dbo].[SystemLogs] ON
GO

INSERT INTO [dbo].[SystemLogs] ([Id], [UserId], [LogDate], [LogType], [Action], [Description], [EntityName], [EntityId], [OldValue], [NewValue], [IpAddress], [IsActive], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [IsDeleted])
VALUES 
(1, 1, GETDATE(), 1, 'Login', 'Kullanıcı girişi yapıldı', 'User', '1', NULL, NULL, '192.168.1.100', 1, GETDATE(), 'System', NULL, NULL, 0),
(2, 1, GETDATE(), 2, 'Create', 'Yeni demirbaş eklendi', 'Inventory', '1', NULL, 'Dell Latitude 5520', '192.168.1.100', 1, GETDATE(), 'System', NULL, NULL, 0),
(3, 1, GETDATE(), 3, 'Update', 'Demirbaş zimmetlendi', 'InventoryAssignment', '1', NULL, 'Ahmet Yılmaz - NB001', '192.168.1.100', 1, GETDATE(), 'System', NULL, NULL, 0)
GO

SET IDENTITY_INSERT [dbo].[SystemLogs] OFF
GO 