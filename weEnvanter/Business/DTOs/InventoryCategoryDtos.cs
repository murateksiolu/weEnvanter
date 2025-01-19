namespace weEnvanter.Business.DTOs
{
    public class InventoryCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class InventoryCategoryCreateDto
    {
        public string Name { get; set; }
    }

    public class InventoryCategoryUpdateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
} 