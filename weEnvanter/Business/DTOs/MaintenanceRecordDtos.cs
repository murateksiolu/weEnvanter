using System;

namespace weEnvanter.Business.DTOs
{
    public class MaintenanceRecordDto
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public string InventoryName { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Description { get; set; }
    }

    public class MaintenanceRecordCreateDto
    {
        public int InventoryId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Description { get; set; }
    }

    public class MaintenanceRecordUpdateDto
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Description { get; set; }
    }
} 