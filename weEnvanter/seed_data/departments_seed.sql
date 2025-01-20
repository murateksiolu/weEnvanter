-- Departments tablosu için örnek veriler
INSERT INTO Departments (Name, DepartmentCode, ParentDepartmentId, IsActive, IsDeleted, CreatedDate, ModifiedDate)
VALUES 
    -- Ana departmanlar
    ('Bilgi Teknolojileri', 'BT001', NULL, 1, 0, GETDATE(), NULL),
    ('İnsan Kaynakları', 'IK001', NULL, 1, 0, GETDATE(), NULL),
    ('Muhasebe', 'MH001', NULL, 1, 0, GETDATE(), NULL),

    -- Alt departmanlar
    ('Yazılım Geliştirme', 'BT002', 1, 1, 0, GETDATE(), NULL),  -- Bilgi Teknolojileri altında
    ('Sistem ve Network', 'BT003', 1, 1, 0, GETDATE(), NULL);   -- Bilgi Teknolojileri altında 