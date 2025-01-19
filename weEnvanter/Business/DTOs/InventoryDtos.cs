namespace weEnvanter.Business.DTOs
{
    public class InventoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class InventoryCreateDto
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int CategoryId { get; set; }
    }

    public class InventoryUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int CategoryId { get; set; }
    }
} 